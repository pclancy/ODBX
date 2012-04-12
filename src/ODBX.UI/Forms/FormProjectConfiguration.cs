﻿// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProjectConfiguration.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Drawing;
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
                EvaluateReadiness();

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
                cboDriver.SelectedIndex = 0;
                LoadDriverOptions(_drivers[0]);
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

        private void LoadDriverOptions(IDriver driver)
        {
            ConnectionBuilderSource.Driver = driver;
            ConnectionBuilderDestination.Driver = driver;

            var boldFont = new Font(treeViewOptions.Font, FontStyle.Bold);

            treeViewOptions.Nodes.Clear();
            foreach (DriverOptionCategory category in driver.Configuration.OptionCategories)
            {
                TreeNode node = treeViewOptions.Nodes.Add(string.Format("CAT_{0}", category.Id),
                                                          string.Concat(category.Name, " "));
                node.NodeFont = boldFont;

                bool allChecked = true;
                foreach (
                    DriverOption driverOption in
                        driver.Configuration.Options.Where(x => x.Category.Id == category.Id).ToList())
                {
                    TreeNode optionNode = node.Nodes.Add(string.Format("OPT_{0}", driverOption.Id), driverOption.Name);
                    optionNode.Checked = driverOption.DefaultValue;
                    if (!driverOption.DefaultValue)
                        allChecked = false;
                }

                node.Checked = allChecked;
            }

            treeViewOptions.ExpandAll();
            //boldFont.Dispose();
        }

        private void CboDriverSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDriver.SelectedItem != null)
            {
                LoadDriverOptions((IDriver) cboDriver.SelectedItem);
            }
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            Project = new Project
                          {
                              Driver = (IDriver) cboDriver.SelectedItem,
                              Source = ConnectionBuilderSource.Configuration,
                              Target = ConnectionBuilderDestination.Configuration,
                              Options = null
                          };

            State.SaveProject(Project);
        }


   }
}