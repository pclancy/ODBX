﻿namespace ODBX.Forms
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.buttonProjects = new System.Windows.Forms.ToolStripButton();
            this.ButtonOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
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
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonProjects,
            this.ButtonOptions,
            this.toolStripSeparator1,
            this.ButtonRefresh,
            this.toolStripButton1});
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
            // 
            // ButtonOptions
            // 
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
            this.ButtonRefresh.Image = global::ODBX.Properties.Resources.database_refresh;
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(82, 36);
            this.ButtonRefresh.Text = "Refresh";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ODBX.Properties.Resources.database_lightning;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 36);
            this.toolStripButton1.Text = "Synchronise";
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 435);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "FormApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormApplication";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}