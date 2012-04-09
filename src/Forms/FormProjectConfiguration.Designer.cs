using ODBX.Controls;

namespace ODBX.Forms
{
    partial class FormProjectConfiguration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageSources = new System.Windows.Forms.TabPage();
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
            this.panelButtonBar = new System.Windows.Forms.Panel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageSources.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panelButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tabMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtonBar, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            // 
            // buttonCopyRight
            // 
            this.buttonCopyRight.Image = global::ODBX.Properties.Resources.resultset_next;
            resources.ApplyResources(this.buttonCopyRight, "buttonCopyRight");
            this.buttonCopyRight.Name = "buttonCopyRight";
            this.buttonCopyRight.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            resources.ApplyResources(this.tabPageOptions, "tabPageOptions");
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.UseVisualStyleBackColor = true;
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
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormProjectConfiguration
            // 
            this.AcceptButton = this.buttonAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectConfiguration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageSources.ResumeLayout(false);
            this.tabPageSources.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panelButtonBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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


    }
}