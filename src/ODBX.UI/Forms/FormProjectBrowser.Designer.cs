namespace ODBX.Forms
{
    partial class FormProjectBrowser
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
            this.ListViewProjects = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnDriver = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSource = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTarget = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLastCompared = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLastSync = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.buttonCopyProject = new System.Windows.Forms.Button();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewProjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewProjects
            // 
            this.ListViewProjects.AllColumns.Add(this.olvColumnDriver);
            this.ListViewProjects.AllColumns.Add(this.olvColumnSource);
            this.ListViewProjects.AllColumns.Add(this.olvColumnTarget);
            this.ListViewProjects.AllColumns.Add(this.olvColumnAuthor);
            this.ListViewProjects.AllColumns.Add(this.olvColumnLastCompared);
            this.ListViewProjects.AllColumns.Add(this.olvColumnLastSync);
            this.ListViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnDriver,
            this.olvColumnSource,
            this.olvColumnTarget,
            this.olvColumnAuthor,
            this.olvColumnLastCompared,
            this.olvColumnLastSync});
            this.ListViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewProjects.FullRowSelect = true;
            this.ListViewProjects.GridLines = true;
            this.ListViewProjects.Location = new System.Drawing.Point(0, 80);
            this.ListViewProjects.MultiSelect = false;
            this.ListViewProjects.Name = "ListViewProjects";
            this.ListViewProjects.OwnerDraw = true;
            this.ListViewProjects.RowHeight = 24;
            this.ListViewProjects.SelectAllOnControlA = false;
            this.ListViewProjects.SelectColumnsMenuStaysOpen = false;
            this.ListViewProjects.SelectColumnsOnRightClick = false;
            this.ListViewProjects.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.ListViewProjects.ShowGroups = false;
            this.ListViewProjects.Size = new System.Drawing.Size(877, 458);
            this.ListViewProjects.TabIndex = 0;
            this.ListViewProjects.UseCompatibleStateImageBehavior = false;
            this.ListViewProjects.View = System.Windows.Forms.View.Details;
            this.ListViewProjects.SelectedIndexChanged += new System.EventHandler(this.ListViewProjectsSelectedIndexChanged);
            this.ListViewProjects.DoubleClick += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // olvColumnDriver
            // 
            this.olvColumnDriver.AspectName = "Driver.Name";
            this.olvColumnDriver.Text = "Driver";
            this.olvColumnDriver.Width = 199;
            // 
            // olvColumnSource
            // 
            this.olvColumnSource.AspectName = "Source.Summary";
            this.olvColumnSource.Text = "Source";
            this.olvColumnSource.Width = 176;
            // 
            // olvColumnTarget
            // 
            this.olvColumnTarget.AspectName = "Target.Summary";
            this.olvColumnTarget.Text = "Target";
            this.olvColumnTarget.Width = 187;
            // 
            // olvColumnAuthor
            // 
            this.olvColumnAuthor.AspectName = "Author";
            this.olvColumnAuthor.Text = "Author";
            this.olvColumnAuthor.Width = 100;
            // 
            // olvColumnLastCompared
            // 
            this.olvColumnLastCompared.AspectName = "LastCompared";
            this.olvColumnLastCompared.Text = "Last Compared";
            this.olvColumnLastCompared.Width = 110;
            // 
            // olvColumnLastSync
            // 
            this.olvColumnLastSync.AspectName = "LastSync";
            this.olvColumnLastSync.Text = "Last Synchronised";
            this.olvColumnLastSync.Width = 110;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(776, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 24);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(678, 7);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(92, 24);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Open";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the location to find or store project files. ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 37);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDeleteProject);
            this.panel2.Controls.Add(this.buttonCopyProject);
            this.panel2.Controls.Add(this.buttonEditProject);
            this.panel2.Controls.Add(this.buttonNewProject);
            this.panel2.Controls.Add(this.buttonBrowseFolder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 80);
            this.panel2.TabIndex = 11;
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.Enabled = false;
            this.buttonDeleteProject.Image = global::ODBX.Properties.Resources.cross;
            this.buttonDeleteProject.Location = new System.Drawing.Point(246, 44);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(70, 24);
            this.buttonDeleteProject.TabIndex = 16;
            this.buttonDeleteProject.Text = "Delete";
            this.buttonDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteProject.UseVisualStyleBackColor = true;
            // 
            // buttonCopyProject
            // 
            this.buttonCopyProject.Enabled = false;
            this.buttonCopyProject.Image = global::ODBX.Properties.Resources.clone;
            this.buttonCopyProject.Location = new System.Drawing.Point(170, 44);
            this.buttonCopyProject.Name = "buttonCopyProject";
            this.buttonCopyProject.Size = new System.Drawing.Size(70, 24);
            this.buttonCopyProject.TabIndex = 15;
            this.buttonCopyProject.Text = "Copy";
            this.buttonCopyProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCopyProject.UseVisualStyleBackColor = true;
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Enabled = false;
            this.buttonEditProject.Image = global::ODBX.Properties.Resources.pencil;
            this.buttonEditProject.Location = new System.Drawing.Point(94, 44);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(70, 24);
            this.buttonEditProject.TabIndex = 14;
            this.buttonEditProject.Text = "Edit";
            this.buttonEditProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditProject.UseVisualStyleBackColor = true;
            this.buttonEditProject.Click += new System.EventHandler(this.ButtonEditProjectClick);
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Image = global::ODBX.Properties.Resources.wand;
            this.buttonNewProject.Location = new System.Drawing.Point(18, 44);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(70, 24);
            this.buttonNewProject.TabIndex = 13;
            this.buttonNewProject.Text = "New...";
            this.buttonNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.ButtonNewProjectClick);
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseFolder.Image = global::ODBX.Properties.Resources.folder;
            this.buttonBrowseFolder.Location = new System.Drawing.Point(841, 13);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(24, 20);
            this.buttonBrowseFolder.TabIndex = 12;
            this.buttonBrowseFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.ButtonBrowseFolderClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Location:";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(74, 12);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(761, 21);
            this.comboBoxLocation.TabIndex = 10;
            this.comboBoxLocation.SelectedValueChanged += new System.EventHandler(this.ScanProjects);
            // 
            // FormProjectBrowser
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(877, 575);
            this.Controls.Add(this.ListViewProjects);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormProjectBrowser";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Browser";
            this.Shown += new System.EventHandler(this.FormProjectBrowserShown);
            ((System.ComponentModel.ISupportInitialize)(this.ListViewProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView ListViewProjects;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private BrightIdeasSoftware.OLVColumn olvColumnSource;
        private BrightIdeasSoftware.OLVColumn olvColumnTarget;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthor;
        private BrightIdeasSoftware.OLVColumn olvColumnLastCompared;
        private BrightIdeasSoftware.OLVColumn olvColumnLastSync;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDeleteProject;
        private System.Windows.Forms.Button buttonCopyProject;
        private System.Windows.Forms.Button buttonEditProject;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private BrightIdeasSoftware.OLVColumn olvColumnDriver;
    }
}