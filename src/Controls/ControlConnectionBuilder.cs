// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ControlConnectionBuilder.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Config;

namespace ODBX.Controls
{
    public partial class ControlConnectionBuilder : UserControl
    {
        public delegate void ConfigurationUpdated(object sender, EventArgs args);
        public event ConfigurationUpdated ConfigurationUpdatedEvent;

        private bool _gotDatabases;
        private bool _gotHosts;
        private readonly IServerConfig _serverConfig = new SqlServerConfig();

        public ControlConnectionBuilder()
        {
            InitializeComponent();
            cboAuthentication.SelectedIndex = 0;
            cboServer.SelectedIndex = 0;
            DriverRepository.GetInstalledDrivers().ForEach(item => cboDriver.Items.Add(item.Name));
            cboDriver.SelectedIndex = 0;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnConfigurationUpdated(EventArgs.Empty);
        }

        public void OnConfigurationUpdated(EventArgs args)
        {
            if (ConfigurationUpdatedEvent != null) ConfigurationUpdatedEvent(this, args);
        }


        private void CboServerDropDown(object sender, EventArgs e)
        {
            try
            {
                if (!_gotHosts)
                {
                    Cursor = Cursors.WaitCursor;
                    cboServer.Items.Clear();
                    _serverConfig.GetHosts().ForEach(item => cboServer.Items.Add(item));
                    _gotHosts = true;
                    _gotDatabases = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CboDatabaseDropDown(object sender, EventArgs e)
        {
            try
            {
                if (!_gotDatabases)
                {
                    Cursor = Cursors.WaitCursor;
                    cboDatabase.Items.Clear();
                    _serverConfig.GetCatalogs(Configuration).ForEach(item => cboDatabase.Items.Add(item));
                    _gotHosts = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public ConnectionConfiguration Configuration
        {
            get
            {
                var config = new ConnectionConfiguration
                                 {
                                     Authentication = (AuthenticationMethod) cboAuthentication.SelectedIndex + 1,
                                     Catalog = cboDatabase.Text,
                                     Host = cboServer.Text,
                                     Username = txtUsername.Text,
                                     Password = txtPassword.Text
                                 };

                return config;
            }
        }

        private void ButtonRefreshClick(object sender, EventArgs e)
        {
            _gotHosts = false;
            CboServerDropDown(sender, e);
        }

        private void ButtonRefreshCatalogsClick(object sender, EventArgs e)
        {
            _gotDatabases = false;
            CboServerDropDown(sender, e);
        }

        private void CboServerSelectedIndexChanged(object sender, EventArgs e)
        {
            _gotDatabases = false;
        }

        private void ConfigurationChanged(object sender, EventArgs e)
        {
            OnConfigurationUpdated(EventArgs.Empty);
        }

        
    }
}