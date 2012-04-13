// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProjectConfiguration.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Driver;
using ODBX.Properties;

namespace ODBX.Forms
{
    public sealed partial class FormProjectConfiguration : BaseForm
    {
        private readonly List<IDriver> _drivers;

        public FormProjectConfiguration()
        {
            InitializeComponent();

            try
            {
                Cursor = Cursors.WaitCursor;

                _drivers = DriverRepository.GetInstalledDrivers();

                driver_retry:
                while (_drivers.Count == 0)
                {
                    if (MessageBox.Show(this, Strings.ErrorNoDriversFound, Strings.Error, MessageBoxButtons.RetryCancel,
                                        MessageBoxIcon.Asterisk) == DialogResult.Retry)
                    {
                        _drivers = DriverRepository.GetInstalledDrivers(refesh: true);
                        goto driver_retry;
                    }
                }

                _drivers.ForEach(item => cboDriver.Items.Add(item));
            }
            catch (Exception ex)
            {
                Program.HandleException(this, ex, string.Empty);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public Project Project { get; set; }

        private void ConnectionBuilderSourceConfigurationUpdatedEvent(object sender, EventArgs args)
        {
            labelSourceDatabase.Text = ConnectionBuilderSource.Configuration.ConnectionString;
            EvaluateReadiness();
        }

        private void ConnectionBuilderDestinationConfigurationUpdatedEvent(object sender, EventArgs args)
        {
            labelDestinationDatabase.Text = ConnectionBuilderDestination.Configuration.ConnectionString;
            EvaluateReadiness();
        }

        private void EvaluateReadiness()
        {
            buttonAccept.Enabled = (ConnectionBuilderDestination.ValidateConfiguration() &&
                                    ConnectionBuilderSource.ValidateConfiguration() && cboDriver.SelectedItem != null);
        }

        private void ButtonCopyRightClick(object sender, EventArgs e)
        {
            ConnectionBuilderDestination.Configuration = ConnectionBuilderSource.Configuration;
        }

        private void ButtonCopyLeftClick(object sender, EventArgs e)
        {
            ConnectionBuilderSource.Configuration = ConnectionBuilderDestination.Configuration;
        }


        private void CboDriverSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDriver.SelectedItem != null)
            {
                Project.Driver = (IDriver) cboDriver.SelectedItem;
                BindDriverOptions();
            }
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            Project.Source = ConnectionBuilderSource.Configuration;
            Project.Target = ConnectionBuilderDestination.Configuration;

            State.SaveProject(Project);
        }

        private void TreeViewOptionsAfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Tag != null)
                {
                    var o = Project.Options.First(x => x.Id == ((DriverOption) e.Node.Tag).Id);
                    var t = ((DriverOption) e.Node.Tag);

                    Project.Options.First(x=>x.Id == ((DriverOption)e.Node.Tag).Id).ConfiguredValue = e.Node.Checked;
                }
            }
        }

        private void TreeViewOptionsBeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null && e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = !e.Node.Checked;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void FormProjectConfigurationShown(object sender, EventArgs e)
        {
            if (Project == null)
            {
                Project = new Project
                              {
                                  Driver = _drivers.First(),
                                  Target = new Connection {Authentication = AuthenticationMethod.Integrated},
                                  Source = new Connection { Authentication = AuthenticationMethod.Integrated },
                              };
                Project.Options = Project.Driver.Configuration.Options;
                ResetDriverOptions();
            }

            ConnectionBuilderDestination.Configuration = Project.Target;
            ConnectionBuilderDestination.Driver = Project.Driver;

            ConnectionBuilderSource.Configuration = Project.Source;
            ConnectionBuilderSource.Driver = Project.Driver;

            cboDriver.SelectedItem = cboDriver.Items.Cast<IDriver>().First(item => item.Id == Project.Driver.Id);

            BindDriverOptions();
            EvaluateReadiness();
        }

        private void ResetDriverOptions()
        {
            foreach (var driverOption in Project.Options)
            {
                driverOption.ConfiguredValue = driverOption.DefaultValue;
            }

        }

        private void BindDriverOptions()
        {
            treeViewOptions.Nodes.Clear();

            if (Project.Options == null || Project.Options.Count == 0)
            {
                MessageBox.Show(this, Strings.ErrorNoDriveOptionsFound);
            }
            else
            {
                foreach (DriverOptionCategory category in Project.Driver.Configuration.OptionCategories)
                {
                    TreeNode node = treeViewOptions.Nodes.Add(string.Format("CAT_{0}", category.Id),
                                                              string.Concat(category.Name, "    "));

                    bool allChecked = true;
                    DriverOptionCategory optionCategory = category;
                    foreach (
                        DriverOption driverOption in
                            Project.Options.Where(x => x.Category.Id == optionCategory.Id))
                    {
                        TreeNode optionNode = node.Nodes.Add(string.Format("OPT_{0}", driverOption.Id),
                                                             driverOption.Name);
                        optionNode.Checked = driverOption.ConfiguredValue;
                        optionNode.Tag = driverOption;
                        if (!driverOption.DefaultValue)
                            allChecked = false;
                    }

                    node.Checked = allChecked;
                }
            }

            treeViewOptions.ExpandAll();
        }

        private void ButtonResetOptionsClick(object sender, EventArgs e)
        {
            ResetDriverOptions();
            BindDriverOptions();
        }

    }
}