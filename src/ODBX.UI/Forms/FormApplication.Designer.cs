namespace ODBX.Forms
{
    partial class FormApplication
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
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.buttonProjects = new System.Windows.Forms.ToolStripButton();
            this.ButtonOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.ButtonSynchronise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboBoxGroupBy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonProjects,
            this.ButtonOptions,
            this.toolStripSeparator1,
            this.ButtonRefresh,
            this.ButtonSynchronise,
            this.toolStripSeparator2,
            this.ComboBoxGroupBy,
            this.toolStripLabel1});
            this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(942, 49);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // buttonProjects
            // 
            this.buttonProjects.Image = global::ODBX.Properties.Resources.folder_database;
            this.buttonProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonProjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(94, 36);
            this.buttonProjects.Text = "Projects...";
            this.buttonProjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProjects.Click += new System.EventHandler(this.OpenProjectBrowser);
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Enabled = false;
            this.ButtonOptions.Image = global::ODBX.Properties.Resources.database_edit;
            this.ButtonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(125, 36);
            this.ButtonOptions.Text = "Project Options";
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptionsClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Enabled = false;
            this.ButtonRefresh.Image = global::ODBX.Properties.Resources.database_refresh;
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(82, 36);
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefreshClick);
            // 
            // ButtonSynchronise
            // 
            this.ButtonSynchronise.Enabled = false;
            this.ButtonSynchronise.Image = global::ODBX.Properties.Resources.database_lightning;
            this.ButtonSynchronise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSynchronise.Name = "ButtonSynchronise";
            this.ButtonSynchronise.Size = new System.Drawing.Size(107, 36);
            this.ButtonSynchronise.Text = "Synchronise";
            this.ButtonSynchronise.Click += new System.EventHandler(this.ButtonSynchroniseClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ComboBoxGroupBy
            // 
            this.ComboBoxGroupBy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ComboBoxGroupBy.AutoSize = false;
            this.ComboBoxGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroupBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxGroupBy.Items.AddRange(new object[] {
            "None",
            "Object Type",
            "Diffference"});
            this.ComboBoxGroupBy.Name = "ComboBoxGroupBy";
            this.ComboBoxGroupBy.Size = new System.Drawing.Size(150, 23);
            this.ComboBoxGroupBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroupBySelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = global::ODBX.Properties.Resources.node_tree;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 36);
            this.toolStripLabel1.Text = "Group By:";
            // 
            // menuStripMain
            // 
            this.menuStripMain.AllowMerge = false;
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(942, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 435);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "FormApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormApplication";
            this.Shown += new System.EventHandler(this.FormApplicationShown);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonProjects;
        private System.Windows.Forms.ToolStripButton ButtonOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonRefresh;
        private System.Windows.Forms.ToolStripButton ButtonSynchronise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox ComboBoxGroupBy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}