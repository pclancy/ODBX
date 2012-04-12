namespace ODBX.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textScript = new ScintillaNET.Scintilla();
            this.tableLayoutPanel1 = new ODBX.Controls.GradientTable();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.labelTargetCatalog = new System.Windows.Forms.Label();
            this.labelTargetConnection = new System.Windows.Forms.Label();
            this.panelDestinationIcon = new System.Windows.Forms.PictureBox();
            this.panelDirection = new System.Windows.Forms.Panel();
            this.panelSource = new System.Windows.Forms.Panel();
            this.labelSourceCatalog = new System.Windows.Forms.Label();
            this.labelSourceConnection = new System.Windows.Forms.Label();
            this.panelSourceIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDestinationIcon)).BeginInit();
            this.panelSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 74);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.objectListView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panel1);
            this.splitContainerMain.Size = new System.Drawing.Size(1053, 423);
            this.splitContainerMain.SplitterDistance = 225;
            this.splitContainerMain.SplitterWidth = 5;
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
            this.objectListView.Size = new System.Drawing.Size(1053, 225);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textScript);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 193);
            this.panel1.TabIndex = 0;
            // 
            // textScript
            // 
            this.textScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScript.Indentation.IndentWidth = 45;
            this.textScript.Indentation.ShowGuides = true;
            this.textScript.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP;
            this.textScript.Location = new System.Drawing.Point(0, 0);
            this.textScript.Name = "textScript";
            this.textScript.Size = new System.Drawing.Size(1053, 193);
            this.textScript.Styles.BraceBad.Size = 9F;
            this.textScript.Styles.BraceLight.Size = 9F;
            this.textScript.Styles.ControlChar.Size = 9F;
            this.textScript.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.textScript.Styles.Default.Size = 9F;
            this.textScript.Styles.IndentGuide.Size = 9F;
            this.textScript.Styles.LastPredefined.Size = 9F;
            this.textScript.Styles.LineNumber.Size = 9F;
            this.textScript.Styles.Max.Size = 9F;
            this.textScript.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.panelDestination, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDirection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSource, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.EndColor = System.Drawing.Color.LemonChiffon;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 74);
            this.tableLayoutPanel1.StartColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelDestination
            // 
            this.panelDestination.BackColor = System.Drawing.Color.Transparent;
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDestination.Controls.Add(this.labelTargetCatalog);
            this.panelDestination.Controls.Add(this.labelTargetConnection);
            this.panelDestination.Controls.Add(this.panelDestinationIcon);
            this.panelDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestination.Location = new System.Drawing.Point(570, 3);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Padding = new System.Windows.Forms.Padding(5);
            this.panelDestination.Size = new System.Drawing.Size(480, 109);
            this.panelDestination.TabIndex = 1;
            // 
            // labelTargetCatalog
            // 
            this.labelTargetCatalog.AutoSize = true;
            this.labelTargetCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetCatalog.Location = new System.Drawing.Point(50, 24);
            this.labelTargetCatalog.Name = "labelTargetCatalog";
            this.labelTargetCatalog.Size = new System.Drawing.Size(57, 20);
            this.labelTargetCatalog.TabIndex = 3;
            this.labelTargetCatalog.Text = "label1";
            // 
            // labelTargetConnection
            // 
            this.labelTargetConnection.AutoSize = true;
            this.labelTargetConnection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTargetConnection.Location = new System.Drawing.Point(50, 5);
            this.labelTargetConnection.Name = "labelTargetConnection";
            this.labelTargetConnection.Size = new System.Drawing.Size(45, 19);
            this.labelTargetConnection.TabIndex = 2;
            this.labelTargetConnection.Text = "label2";
            // 
            // panelDestinationIcon
            // 
            this.panelDestinationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDestinationIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDestinationIcon.Image = global::ODBX.Properties.Resources.database;
            this.panelDestinationIcon.Location = new System.Drawing.Point(5, 5);
            this.panelDestinationIcon.Name = "panelDestinationIcon";
            this.panelDestinationIcon.Size = new System.Drawing.Size(37, 99);
            this.panelDestinationIcon.TabIndex = 1;
            this.panelDestinationIcon.TabStop = false;
            // 
            // panelDirection
            // 
            this.panelDirection.BackColor = System.Drawing.Color.Transparent;
            this.panelDirection.BackgroundImage = global::ODBX.Properties.Resources.big_arrow_right;
            this.panelDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDirection.Location = new System.Drawing.Point(488, 3);
            this.panelDirection.Name = "panelDirection";
            this.panelDirection.Size = new System.Drawing.Size(75, 43);
            this.panelDirection.TabIndex = 2;
            this.panelDirection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelDirectionMouseDoubleClick);
            // 
            // panelSource
            // 
            this.panelSource.BackColor = System.Drawing.Color.Transparent;
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSource.Controls.Add(this.labelSourceCatalog);
            this.panelSource.Controls.Add(this.labelSourceConnection);
            this.panelSource.Controls.Add(this.panelSourceIcon);
            this.panelSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSource.Location = new System.Drawing.Point(3, 3);
            this.panelSource.Name = "panelSource";
            this.panelSource.Padding = new System.Windows.Forms.Padding(5);
            this.panelSource.Size = new System.Drawing.Size(479, 109);
            this.panelSource.TabIndex = 0;
            // 
            // labelSourceCatalog
            // 
            this.labelSourceCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSourceCatalog.AutoSize = true;
            this.labelSourceCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSourceCatalog.Location = new System.Drawing.Point(364, 25);
            this.labelSourceCatalog.Name = "labelSourceCatalog";
            this.labelSourceCatalog.Size = new System.Drawing.Size(57, 20);
            this.labelSourceCatalog.TabIndex = 2;
            this.labelSourceCatalog.Text = "label1";
            // 
            // labelSourceConnection
            // 
            this.labelSourceConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSourceConnection.AutoSize = true;
            this.labelSourceConnection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSourceConnection.Location = new System.Drawing.Point(376, 5);
            this.labelSourceConnection.Name = "labelSourceConnection";
            this.labelSourceConnection.Size = new System.Drawing.Size(45, 19);
            this.labelSourceConnection.TabIndex = 1;
            this.labelSourceConnection.Text = "label1";
            // 
            // panelSourceIcon
            // 
            this.panelSourceIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSourceIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSourceIcon.Image = global::ODBX.Properties.Resources.database;
            this.panelSourceIcon.Location = new System.Drawing.Point(437, 5);
            this.panelSourceIcon.Name = "panelSourceIcon";
            this.panelSourceIcon.Size = new System.Drawing.Size(37, 99);
            this.panelSourceIcon.TabIndex = 0;
            this.panelSourceIcon.TabStop = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 497);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(117, 115);
            this.Name = "FormProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormProject";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDestination.ResumeLayout(false);
            this.panelDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDestinationIcon)).EndInit();
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ODBX.Controls.GradientTable tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.PictureBox panelSourceIcon;
        private System.Windows.Forms.PictureBox panelDestinationIcon;
        private System.Windows.Forms.Panel panelDirection;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private ScintillaNET.Scintilla textScript;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSourceConnection;
        private System.Windows.Forms.Label labelTargetConnection;
        private System.Windows.Forms.Label labelTargetCatalog;
        private System.Windows.Forms.Label labelSourceCatalog;


    }
}