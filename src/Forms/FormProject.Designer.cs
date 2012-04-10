﻿namespace ODBX.Forms
{
    partial class FormProject
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textScript = new ScintillaNET.Scintilla();
            this.tableLayoutPanel1 = new ODBX.Controls.GradientTable();
            this.panelSource = new System.Windows.Forms.Panel();
            this.panelSourceIcon = new System.Windows.Forms.Panel();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.panelDestinationIcon = new System.Windows.Forms.Panel();
            this.panelDirection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSource.SuspendLayout();
            this.panelDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 100);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.objectListView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.textScript);
            this.splitContainerMain.Size = new System.Drawing.Size(903, 331);
            this.splitContainerMain.SplitterDistance = 225;
            this.splitContainerMain.TabIndex = 3;
            // 
            // objectListView
            // 
            this.objectListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.objectListView.AllColumns.Add(this.olvColumnType);
            this.objectListView.AllColumns.Add(this.olvColumnName);
            this.objectListView.AllColumns.Add(this.olvColumnAction);
            this.objectListView.AllowColumnReorder = true;
            this.objectListView.CheckBoxes = true;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnType,
            this.olvColumnName,
            this.olvColumnAction});
            this.objectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView.FullRowSelect = true;
            this.objectListView.GridLines = true;
            this.objectListView.Location = new System.Drawing.Point(0, 0);
            this.objectListView.MultiSelect = false;
            this.objectListView.Name = "objectListView";
            this.objectListView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.objectListView.ShowCommandMenuOnRightClick = true;
            this.objectListView.ShowItemCountOnGroups = true;
            this.objectListView.ShowItemToolTips = true;
            this.objectListView.Size = new System.Drawing.Size(903, 225);
            this.objectListView.TabIndex = 0;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.SelectionChanged += new System.EventHandler(this.ObjectListViewSelectionChanged);
            this.objectListView.SelectedIndexChanged += new System.EventHandler(this.ObjectListViewSelectedIndexChanged);
            // 
            // olvColumnType
            // 
            this.olvColumnType.AspectName = "Type";
            this.olvColumnType.AutoCompleteEditor = false;
            this.olvColumnType.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColumnType.IsEditable = false;
            this.olvColumnType.Text = "Type";
            this.olvColumnType.Width = 100;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Fullname";
            this.olvColumnName.AutoCompleteEditor = false;
            this.olvColumnName.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Groupable = false;
            this.olvColumnName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumnName.Text = "Name";
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.AutoCompleteEditor = false;
            this.olvColumnAction.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColumnAction.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnAction.Text = "Action";
            this.olvColumnAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textScript
            // 
            this.textScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScript.Indentation.IndentWidth = 45;
            this.textScript.Indentation.ShowGuides = true;
            this.textScript.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP;
            this.textScript.Location = new System.Drawing.Point(0, 0);
            this.textScript.Name = "textScript";
            this.textScript.Size = new System.Drawing.Size(903, 102);
            this.textScript.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDestination, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDirection, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.EndColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(300, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 100);
            this.tableLayoutPanel1.StartColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelSource
            // 
            this.panelSource.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelSource.BackColor = System.Drawing.Color.Transparent;
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSource.Controls.Add(this.panelSourceIcon);
            this.panelSource.Location = new System.Drawing.Point(248, 3);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(200, 94);
            this.panelSource.TabIndex = 0;
            // 
            // panelSourceIcon
            // 
            this.panelSourceIcon.BackgroundImage = global::ODBX.Properties.Resources.database;
            this.panelSourceIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSourceIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSourceIcon.Location = new System.Drawing.Point(168, 0);
            this.panelSourceIcon.Name = "panelSourceIcon";
            this.panelSourceIcon.Size = new System.Drawing.Size(32, 94);
            this.panelSourceIcon.TabIndex = 0;
            // 
            // panelDestination
            // 
            this.panelDestination.BackColor = System.Drawing.Color.Transparent;
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDestination.Controls.Add(this.panelDestinationIcon);
            this.panelDestination.Location = new System.Drawing.Point(554, 3);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(200, 94);
            this.panelDestination.TabIndex = 1;
            // 
            // panelDestinationIcon
            // 
            this.panelDestinationIcon.BackgroundImage = global::ODBX.Properties.Resources.database;
            this.panelDestinationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDestinationIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDestinationIcon.Location = new System.Drawing.Point(0, 0);
            this.panelDestinationIcon.Name = "panelDestinationIcon";
            this.panelDestinationIcon.Size = new System.Drawing.Size(32, 94);
            this.panelDestinationIcon.TabIndex = 1;
            // 
            // panelDirection
            // 
            this.panelDirection.BackColor = System.Drawing.Color.Transparent;
            this.panelDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDirection.Location = new System.Drawing.Point(454, 3);
            this.panelDirection.Name = "panelDirection";
            this.panelDirection.Size = new System.Drawing.Size(94, 94);
            this.panelDirection.TabIndex = 2;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 431);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "FormProject";
            this.ShowIcon = false;
            this.Text = "FormProject";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSource.ResumeLayout(false);
            this.panelDestination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ODBX.Controls.GradientTable tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Panel panelSourceIcon;
        private System.Windows.Forms.Panel panelDestinationIcon;
        private System.Windows.Forms.Panel panelDirection;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private ScintillaNET.Scintilla textScript;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;


    }
}