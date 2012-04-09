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
            this.splitContainerInner = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.treeViewOptions = new System.Windows.Forms.TreeView();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageSources = new System.Windows.Forms.TabPage();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ODBX.Controls.GradientPanel();
            this.labelDestinationDatabase = new System.Windows.Forms.Label();
            this.labelSourceDatabase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIconDestination = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionBuilderDestination = new ODBX.Controls.ControlConnectionBuilder();
            this.ConnectionBuilderSource = new ODBX.Controls.ControlConnectionBuilder();
            this.buttonCopyLeft = new System.Windows.Forms.Button();
            this.buttonCopyRight = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelButtonBar = new System.Windows.Forms.Panel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).BeginInit();
            this.splitContainerInner.Panel1.SuspendLayout();
            this.splitContainerInner.Panel2.SuspendLayout();
            this.splitContainerInner.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageSources.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerInner
            // 
            resources.ApplyResources(this.splitContainerInner, "splitContainerInner");
            this.splitContainerInner.Name = "splitContainerInner";
            // 
            // splitContainerInner.Panel1
            // 
            this.splitContainerInner.Panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.splitContainerInner.Panel1, "splitContainerInner.Panel1");
            // 
            // splitContainerInner.Panel2
            // 
            this.splitContainerInner.Panel2.Controls.Add(this.treeViewOptions);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.CheckBoxes = true;
            resources.ApplyResources(this.treeViewOptions, "treeViewOptions");
            this.treeViewOptions.Name = "treeViewOptions";
            this.treeViewOptions.ShowRootLines = false;
            // 
            // tableLayoutMain
            // 
            resources.ApplyResources(this.tableLayoutMain, "tableLayoutMain");
            this.tableLayoutMain.Controls.Add(this.tabMain, 0, 0);
            this.tableLayoutMain.Controls.Add(this.panelButtonBar, 0, 1);
            this.tableLayoutMain.Name = "tableLayoutMain";
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
            this.tabPageSources.Controls.Add(this.cboDriver);
            this.tabPageSources.Controls.Add(this.label6);
            this.tabPageSources.Controls.Add(this.labelHeader);
            this.tabPageSources.Controls.Add(this.gradientPanel1);
            this.tabPageSources.Controls.Add(this.ConnectionBuilderDestination);
            this.tabPageSources.Controls.Add(this.ConnectionBuilderSource);
            this.tabPageSources.Controls.Add(this.buttonCopyLeft);
            this.tabPageSources.Controls.Add(this.buttonCopyRight);
            resources.ApplyResources(this.tabPageSources, "tabPageSources");
            this.tabPageSources.Name = "tabPageSources";
            this.tabPageSources.UseVisualStyleBackColor = true;
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // labelHeader
            // 
            resources.ApplyResources(this.labelHeader, "labelHeader");
            this.labelHeader.Name = "labelHeader";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.labelDestinationDatabase);
            this.gradientPanel1.Controls.Add(this.labelSourceDatabase);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.panelIconDestination);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.EndColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.StartColor = System.Drawing.Color.Empty;
            // 
            // labelDestinationDatabase
            // 
            this.labelDestinationDatabase.AutoEllipsis = true;
            resources.ApplyResources(this.labelDestinationDatabase, "labelDestinationDatabase");
            this.labelDestinationDatabase.Name = "labelDestinationDatabase";
            // 
            // labelSourceDatabase
            // 
            this.labelSourceDatabase.AutoEllipsis = true;
            resources.ApplyResources(this.labelSourceDatabase, "labelSourceDatabase");
            this.labelSourceDatabase.Name = "labelSourceDatabase";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panelIconDestination
            // 
            this.panelIconDestination.BackgroundImage = global::ODBX.Properties.Resources.database_connect;
            resources.ApplyResources(this.panelIconDestination, "panelIconDestination");
            this.panelIconDestination.Name = "panelIconDestination";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ODBX.Properties.Resources.database_connect;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ConnectionBuilderDestination
            // 
            resources.ApplyResources(this.ConnectionBuilderDestination, "ConnectionBuilderDestination");
            this.ConnectionBuilderDestination.Name = "ConnectionBuilderDestination";
            this.ConnectionBuilderDestination.ConfigurationUpdatedEvent += new ODBX.Controls.ControlConnectionBuilder.ConfigurationUpdated(this.ConnectionBuilderDestinationConfigurationUpdatedEvent);
            // 
            // ConnectionBuilderSource
            // 
            resources.ApplyResources(this.ConnectionBuilderSource, "ConnectionBuilderSource");
            this.ConnectionBuilderSource.Name = "ConnectionBuilderSource";
            this.ConnectionBuilderSource.ConfigurationUpdatedEvent += new ODBX.Controls.ControlConnectionBuilder.ConfigurationUpdated(this.ConnectionBuilderSourceConfigurationUpdatedEvent);
            // 
            // buttonCopyLeft
            // 
            this.buttonCopyLeft.Image = global::ODBX.Properties.Resources.resultset_previous;
            resources.ApplyResources(this.buttonCopyLeft, "buttonCopyLeft");
            this.buttonCopyLeft.Name = "buttonCopyLeft";
            this.buttonCopyLeft.UseVisualStyleBackColor = true;
            this.buttonCopyLeft.Click += new System.EventHandler(this.ButtonCopyLeftClick);
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
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerInner);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox1);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panelButtonBar
            // 
            this.panelButtonBar.Controls.Add(this.buttonAccept);
            this.panelButtonBar.Controls.Add(this.buttonCancel);
            resources.ApplyResources(this.panelButtonBar, "panelButtonBar");
            this.panelButtonBar.Name = "panelButtonBar";
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
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
            this.Controls.Add(this.tableLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectConfiguration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.splitContainerInner.Panel1.ResumeLayout(false);
            this.splitContainerInner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).EndInit();
            this.splitContainerInner.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageSources.ResumeLayout(false);
            this.tabPageSources.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelButtonBar.ResumeLayout(false);
            this.panelButtonBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageSources;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Panel panelButtonBar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCopyLeft;
        private System.Windows.Forms.Button buttonCopyRight;
        private ControlConnectionBuilder ConnectionBuilderDestination;
        private ControlConnectionBuilder ConnectionBuilderSource;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIconDestination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDestinationDatabase;
        private System.Windows.Forms.Label labelSourceDatabase;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerInner;
        private System.Windows.Forms.TreeView treeViewOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label6;


    }
}