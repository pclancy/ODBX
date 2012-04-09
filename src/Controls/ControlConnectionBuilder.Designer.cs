namespace ODBX.Controls
{
    partial class ControlConnectionBuilder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlConnectionBuilder));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRefreshCatalogs = new System.Windows.Forms.Button();
            this.buttonRefreshServers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.cboAuthentication = new System.Windows.Forms.ComboBox();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.cboDriver);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.buttonRefreshCatalogs);
            this.panelContainer.Controls.Add(this.buttonRefreshServers);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.checkBox1);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.cboDatabase);
            this.panelContainer.Controls.Add(this.cboAuthentication);
            this.panelContainer.Controls.Add(this.cboServer);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.txtUsername);
            this.panelContainer.Controls.Add(this.label1);
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Name = "panelContainer";
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FormattingEnabled = true;
            resources.ApplyResources(this.cboDriver, "cboDriver");
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // buttonRefreshCatalogs
            // 
            resources.ApplyResources(this.buttonRefreshCatalogs, "buttonRefreshCatalogs");
            this.buttonRefreshCatalogs.Image = global::ODBX.Properties.Resources.arrow_refresh_16;
            this.buttonRefreshCatalogs.Name = "buttonRefreshCatalogs";
            this.buttonRefreshCatalogs.UseVisualStyleBackColor = true;
            this.buttonRefreshCatalogs.Click += new System.EventHandler(this.ButtonRefreshCatalogsClick);
            // 
            // buttonRefreshServers
            // 
            resources.ApplyResources(this.buttonRefreshServers, "buttonRefreshServers");
            this.buttonRefreshServers.Image = global::ODBX.Properties.Resources.arrow_refresh_16;
            this.buttonRefreshServers.Name = "buttonRefreshServers";
            this.buttonRefreshServers.UseVisualStyleBackColor = true;
            this.buttonRefreshServers.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            resources.ApplyResources(this.cboDatabase, "cboDatabase");
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.DropDown += new System.EventHandler(this.CboDatabaseDropDown);
            this.cboDatabase.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // cboAuthentication
            // 
            this.cboAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthentication.FormattingEnabled = true;
            this.cboAuthentication.Items.AddRange(new object[] {
            resources.GetString("cboAuthentication.Items"),
            resources.GetString("cboAuthentication.Items1")});
            resources.ApplyResources(this.cboAuthentication, "cboAuthentication");
            this.cboAuthentication.Name = "cboAuthentication";
            this.cboAuthentication.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // cboServer
            // 
            resources.ApplyResources(this.cboServer, "cboServer");
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Items.AddRange(new object[] {
            resources.GetString("cboServer.Items")});
            this.cboServer.Name = "cboServer";
            this.cboServer.DropDown += new System.EventHandler(this.CboServerDropDown);
            this.cboServer.SelectedIndexChanged += new System.EventHandler(this.CboServerSelectedIndexChanged);
            this.cboServer.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TextChanged += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ControlConnectionBuilder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "ControlConnectionBuilder";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.ComboBox cboAuthentication;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshServers;
        private System.Windows.Forms.Button buttonRefreshCatalogs;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label6;

    }
}
