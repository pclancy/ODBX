// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ControlConnectionBuilder.cs
//   
//  

using System;
using System.ComponentModel;
using System.Windows.Forms;
using ODBX.Driver;
using ODBX.Properties;

namespace ODBX.Controls
{
    public partial class ControlConnectionBuilder : UserControl
    {
        #region Delegates

        public delegate void ConfigurationUpdated(object sender, EventArgs args);

        #endregion

        private bool _gotDatabases;
        private bool _gotHosts;

        public ControlConnectionBuilder()
        {
            InitializeComponent();
            cboAuthentication.SelectedIndex = 0;
            cboServer.SelectedIndex = 0;
        }

        public IDriver Driver { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Connection Configuration
        {
            get
            {
                var config = new Connection
                                 {
                                     Authentication = (AuthenticationMethod) cboAuthentication.SelectedIndex + 1,
                                     Catalog = cboDatabase.Text,
                                     Host = cboServer.Text,
                                     Username = txtUsername.Text,
                                     Password = txtPassword.Text
                                 };

                return config;
            }
            set
            {
                if (value != null)
                {
                    cboAuthentication.SelectedIndex = (int) value.Authentication - 1;
                    //cboDriver.SelectedValue = value.
                    cboDatabase.Text = value.Catalog;
                    cboServer.Text = value.Host;
                    txtUsername.Text = value.Username;
                    txtPassword.Text = value.Password;

                    OnConfigurationUpdated(EventArgs.Empty);
                }
            }
        }

        public event ConfigurationUpdated ConfigurationUpdatedEvent;


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
                    Driver.Server.GetHosts().ForEach(item => cboServer.Items.Add(item));
                    _gotHosts = true;
                    _gotDatabases = false;
                }
            }
            catch (Exception ex)
            {
                Program.HandleException(ParentForm, ex, Strings.ErrorEnumerateHosts);
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
                    Driver.Server.GetCatalogs(Configuration).ForEach(item => cboDatabase.Items.Add(item));
                    _gotHosts = true;
                }
            }
            catch (Exception ex)
            {
                Program.HandleException(ParentForm, ex,
                                        string.Format(Strings.ErrorEnumerateCatalogs, Configuration.Host));
            }
            finally
            {
                Cursor = Cursors.Default;
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

        public bool ValidateConfiguration()
        {
            return Configuration.IsReady;
        }
    }
}