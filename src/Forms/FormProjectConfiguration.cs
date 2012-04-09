// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProjectConfiguration.cs
//   
//  

using System;

namespace ODBX.Forms
{
    public partial class FormProjectConfiguration : BaseForm
    {
        public FormProjectConfiguration()
        {
            InitializeComponent();
        }

        private void ConnectionBuilderSourceConfigurationUpdatedEvent(object sender, EventArgs args)
        {
            labelSourceDatabase.Text = ConnectionBuilderSource.Configuration.ConnectionString;
        }

        private void ConnectionBuilderDestinationConfigurationUpdatedEvent(object sender, EventArgs args)
        {
            labelDestinationDatabase.Text = ConnectionBuilderDestination.Configuration.ConnectionString;
        }
    }
}