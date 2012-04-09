// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProjectConfiguration.cs
//   
//  

using System;
using System.Drawing;
using System.Linq;
using ODBX.Config;

namespace ODBX.Forms
{
    public partial class FormProjectConfiguration : BaseForm
    {
        public FormProjectConfiguration()
        {
            InitializeComponent();
            EvaluateReadiness();
            LoadDriverOptions(DriverRepository.GetInstalledDrivers()[0]);
        }

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
            buttonAccept.Enabled = (ConnectionBuilderDestination.ValidateConfiguration() && ConnectionBuilderSource.ValidateConfiguration());
        }

        private void ButtonCopyRightClick(object sender, EventArgs e)
        {
            ConnectionBuilderDestination.Configuration = ConnectionBuilderSource.Configuration;
        }

        private void ButtonCopyLeftClick(object sender, EventArgs e)
        {
            ConnectionBuilderSource.Configuration = ConnectionBuilderDestination.Configuration;
        }

        private void LoadDriverOptions(Driver driver)
        {

            var boldFont = new Font(treeViewOptions.Font, FontStyle.Bold);

            treeViewOptions.Nodes.Clear();
            foreach (var category in driver.Configuration.OptionCategories)
            {
                var node = treeViewOptions.Nodes.Add(string.Format("CAT_{0}", category.Id), string.Concat(category.Name, " "));
                node.NodeFont = boldFont;

                var allChecked = true;
                foreach (var driverOption in driver.Configuration.Options.Where(x=>x.Category.Id == category.Id).ToList())
                {
                    var  optionNode = node.Nodes.Add(string.Format("OPT_{0}", driverOption.Id), driverOption.Name);
                    optionNode.Checked = driverOption.DefaultValue;
                    if (!driverOption.DefaultValue)
                        allChecked = false;
                    
                }

                node.Checked = allChecked;

            }
            
            treeViewOptions.ExpandAll();
            //boldFont.Dispose();
        }

    }
}