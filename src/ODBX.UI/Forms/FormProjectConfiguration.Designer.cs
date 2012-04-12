using ODBX.Controls;

namespace ODBX.Forms
{
    sealed partial class FormProjectConfiguration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectConfiguration));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageSources = new System.Windows.Forms.TabPage();
            this.buttonCopyLeft = new System.Windows.Forms.Button();
            this.ConnectionBuilderDestination = new ODBX.Controls.ControlConnectionBuilder();
            this.gradientPanelHeader = new ODBX.Controls.GradientPanel();
            this.gradientPanelHeaderRight = new ODBX.Controls.GradientPanel();
            this.panelIconDestination = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDestinationDatabase = new System.Windows.Forms.Label();
            this.gradientPanelHeaderLeft = new ODBX.Controls.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSourceDatabase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionBuilderSource = new ODBX.Controls.ControlConnectionBuilder();
            this.buttonCopyRight = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewOptions = new System.Windows.Forms.TreeView();
            this.gradientPanel3 = new ODBX.Controls.GradientPanel();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.buttonResetOptions = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabPageSources.SuspendLayout();
            this.gradientPanelHeader.SuspendLayout();
            this.gradientPanelHeaderRight.SuspendLayout();
            this.gradientPanelHeaderLeft.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageSources);
            this.tabMain.Controls.Add(this.tabPageOptions);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            // 
            // tabPageSources
            // 
            this.tabPageSources.Controls.Add(this.buttonCopyLeft);
            this.tabPageSources.Controls.Add(this.ConnectionBuilderDestination);
            this.tabPageSources.Controls.Add(this.gradientPanelHeader);
            this.tabPageSources.Controls.Add(this.ConnectionBuilderSource);
            this.tabPageSources.Controls.Add(this.buttonCopyRight);
            resources.ApplyResources(this.tabPageSources, "tabPageSources");
            this.tabPageSources.Name = "tabPageSources";
            this.tabPageSources.UseVisualStyleBackColor = true;
            // 
            // buttonCopyLeft
            // 
            this.buttonCopyLeft.Image = global::ODBX.Properties.Resources.resultset_previous;
            resources.ApplyResources(this.buttonCopyLeft, "buttonCopyLeft");
            this.buttonCopyLeft.Name = "buttonCopyLeft";
            this.buttonCopyLeft.UseVisualStyleBackColor = true;
            this.buttonCopyLeft.Click += new System.EventHandler(this.ButtonCopyLeftClick);
            // 
            // ConnectionBuilderDestination
            // 
            resources.ApplyResources(this.ConnectionBuilderDestination, "ConnectionBuilderDestination");
            this.ConnectionBuilderDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionBuilderDestination.Driver = null;
            this.ConnectionBuilderDestination.Name = "ConnectionBuilderDestination";
            this.ConnectionBuilderDestination.ConfigurationUpdatedEvent += new ODBX.Controls.ControlConnectionBuilder.ConfigurationUpdated(this.ConnectionBuilderDestinationConfigurationUpdatedEvent);
            // 
            // gradientPanelHeader
            // 
            this.gradientPanelHeader.Controls.Add(this.gradientPanelHeaderRight);
            this.gradientPanelHeader.Controls.Add(this.gradientPanelHeaderLeft);
            this.gradientPanelHeader.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradientPanelHeader.LineBottom = true;
            this.gradientPanelHeader.LineColor = System.Drawing.Color.Gray;
            this.gradientPanelHeader.LineLeft = false;
            this.gradientPanelHeader.LineRight = false;
            this.gradientPanelHeader.LineTop = true;
            resources.ApplyResources(this.gradientPanelHeader, "gradientPanelHeader");
            this.gradientPanelHeader.Name = "gradientPanelHeader";
            this.gradientPanelHeader.StartColor = System.Drawing.Color.Empty;
            // 
            // gradientPanelHeaderRight
            // 
            this.gradientPanelHeaderRight.Controls.Add(this.panelIconDestination);
            this.gradientPanelHeaderRight.Controls.Add(this.label2);
            this.gradientPanelHeaderRight.Controls.Add(this.labelDestinationDatabase);
            resources.ApplyResources(this.gradientPanelHeaderRight, "gradientPanelHeaderRight");
            this.gradientPanelHeaderRight.EndColor = System.Drawing.Color.Empty;
            this.gradientPanelHeaderRight.LineBottom = false;
            this.gradientPanelHeaderRight.LineColor = System.Drawing.Color.Gray;
            this.gradientPanelHeaderRight.LineLeft = false;
            this.gradientPanelHeaderRight.LineRight = false;
            this.gradientPanelHeaderRight.LineTop = false;
            this.gradientPanelHeaderRight.Name = "gradientPanelHeaderRight";
            this.gradientPanelHeaderRight.StartColor = System.Drawing.Color.Empty;
            // 
            // panelIconDestination
            // 
            this.panelIconDestination.BackgroundImage = global::ODBX.Properties.Resources.database_connect;
            resources.ApplyResources(this.panelIconDestination, "panelIconDestination");
            this.panelIconDestination.Name = "panelIconDestination";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // labelDestinationDatabase
            // 
            this.labelDestinationDatabase.AutoEllipsis = true;
            resources.ApplyResources(this.labelDestinationDatabase, "labelDestinationDatabase");
            this.labelDestinationDatabase.Name = "labelDestinationDatabase";
            // 
            // gradientPanelHeaderLeft
            // 
            this.gradientPanelHeaderLeft.Controls.Add(this.panel1);
            this.gradientPanelHeaderLeft.Controls.Add(this.labelSourceDatabase);
            this.gradientPanelHeaderLeft.Controls.Add(this.label1);
            resources.ApplyResources(this.gradientPanelHeaderLeft, "gradientPanelHeaderLeft");
            this.gradientPanelHeaderLeft.EndColor = System.Drawing.Color.Empty;
            this.gradientPanelHeaderLeft.LineBottom = false;
            this.gradientPanelHeaderLeft.LineColor = System.Drawing.Color.Gray;
            this.gradientPanelHeaderLeft.LineLeft = false;
            this.gradientPanelHeaderLeft.LineRight = false;
            this.gradientPanelHeaderLeft.LineTop = false;
            this.gradientPanelHeaderLeft.Name = "gradientPanelHeaderLeft";
            this.gradientPanelHeaderLeft.StartColor = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = global::ODBX.Properties.Resources.database_connect;
            this.panel1.Name = "panel1";
            // 
            // labelSourceDatabase
            // 
            resources.ApplyResources(this.labelSourceDatabase, "labelSourceDatabase");
            this.labelSourceDatabase.AutoEllipsis = true;
            this.labelSourceDatabase.Name = "labelSourceDatabase";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ConnectionBuilderSource
            // 
            resources.ApplyResources(this.ConnectionBuilderSource, "ConnectionBuilderSource");
            this.ConnectionBuilderSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionBuilderSource.Driver = null;
            this.ConnectionBuilderSource.Name = "ConnectionBuilderSource";
            this.ConnectionBuilderSource.ConfigurationUpdatedEvent += new ODBX.Controls.ControlConnectionBuilder.ConfigurationUpdated(this.ConnectionBuilderSourceConfigurationUpdatedEvent);
            // 
            // buttonCopyRight
            // 
            this.buttonCopyRight.Image = global::ODBX.Properties.Resources.resultset_next;
            resources.ApplyResources(this.buttonCopyRight, "buttonCopyRight");
            this.buttonCopyRight.Name = "buttonCopyRight";
            this.buttonCopyRight.UseVisualStyleBackColor = true;
            this.buttonCopyRight.Click += new System.EventHandler(this.ButtonCopyRightClick);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.splitContainerMain);
            resources.ApplyResources(this.tabPageOptions, "tabPageOptions");
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // splitContainerMain
            // 
            resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewOptions);
            this.splitContainerMain.Panel1.Controls.Add(this.gradientPanel3);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox1);
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.CheckBoxes = true;
            resources.ApplyResources(this.treeViewOptions, "treeViewOptions");
            this.treeViewOptions.Name = "treeViewOptions";
            this.treeViewOptions.ShowRootLines = false;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Controls.Add(this.cboDriver);
            this.gradientPanel3.Controls.Add(this.buttonResetOptions);
            this.gradientPanel3.Controls.Add(this.label6);
            resources.ApplyResources(this.gradientPanel3, "gradientPanel3");
            this.gradientPanel3.EndColor = System.Drawing.Color.Empty;
            this.gradientPanel3.LineBottom = false;
            this.gradientPanel3.LineColor = System.Drawing.Color.Empty;
            this.gradientPanel3.LineLeft = false;
            this.gradientPanel3.LineRight = false;
            this.gradientPanel3.LineTop = false;
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.StartColor = System.Drawing.Color.Empty;
            // 
            // cboDriver
            // 
            this.cboDriver.DisplayMember = "Name";
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FormattingEnabled = true;
            resources.ApplyResources(this.cboDriver, "cboDriver");
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.ValueMember = "Id";
            this.cboDriver.SelectedIndexChanged += new System.EventHandler(this.CboDriverSelectedIndexChanged);
            // 
            // buttonResetOptions
            // 
            resources.ApplyResources(this.buttonResetOptions, "buttonResetOptions");
            this.buttonResetOptions.Name = "buttonResetOptions";
            this.buttonResetOptions.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormProjectConfiguration
            // 
            this.AcceptButton = this.buttonAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectConfiguration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tabMain.ResumeLayout(false);
            this.tabPageSources.ResumeLayout(false);
            this.tabPageSources.PerformLayout();
            this.gradientPanelHeader.ResumeLayout(false);
            this.gradientPanelHeaderRight.ResumeLayout(false);
            this.gradientPanelHeaderRight.PerformLayout();
            this.gradientPanelHeaderLeft.ResumeLayout(false);
            this.gradientPanelHeaderLeft.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageSources;
        private System.Windows.Forms.Label labelDestinationDatabase;
        private System.Windows.Forms.Panel panelIconDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSourceDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCopyLeft;
        private System.Windows.Forms.Button buttonCopyRight;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewOptions;
        private System.Windows.Forms.Button buttonResetOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label6;
        private GradientPanel gradientPanelHeader;
        private GradientPanel gradientPanelHeaderLeft;
        private GradientPanel gradientPanelHeaderRight;
        private ControlConnectionBuilder ConnectionBuilderDestination;
        private ControlConnectionBuilder ConnectionBuilderSource;
        private GradientPanel gradientPanel3;



    }
}