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
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.olvColumnSummary = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.buttonCopyProject = new System.Windows.Forms.Button();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.olvColumnSummary);
            this.treeListView1.AllColumns.Add(this.olvColumnDate);
            this.treeListView1.CheckBoxes = false;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnSummary,
            this.olvColumnDate});
            this.treeListView1.GridLines = true;
            this.treeListView1.Location = new System.Drawing.Point(15, 79);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(694, 302);
            this.treeListView1.TabIndex = 0;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            // 
            // olvColumnSummary
            // 
            this.olvColumnSummary.Width = 187;
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.Width = 208;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(81, 13);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(593, 23);
            this.comboBoxLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(634, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(553, 396);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Open";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the location to find or store project files. ";
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Image = global::ODBX.Properties.Resources.wand;
            this.buttonNewProject.Location = new System.Drawing.Point(15, 50);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProject.TabIndex = 6;
            this.buttonNewProject.Text = "New...";
            this.buttonNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.ButtonNewProjectClick);
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Image = global::ODBX.Properties.Resources.pencil;
            this.buttonEditProject.Location = new System.Drawing.Point(97, 50);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(75, 23);
            this.buttonEditProject.TabIndex = 7;
            this.buttonEditProject.Text = "Edit";
            this.buttonEditProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditProject.UseVisualStyleBackColor = true;
            // 
            // buttonCopyProject
            // 
            this.buttonCopyProject.Image = global::ODBX.Properties.Resources.clone;
            this.buttonCopyProject.Location = new System.Drawing.Point(178, 50);
            this.buttonCopyProject.Name = "buttonCopyProject";
            this.buttonCopyProject.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyProject.TabIndex = 8;
            this.buttonCopyProject.Text = "Copy";
            this.buttonCopyProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCopyProject.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.Image = global::ODBX.Properties.Resources.cross;
            this.buttonDeleteProject.Location = new System.Drawing.Point(259, 50);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProject.TabIndex = 9;
            this.buttonDeleteProject.Text = "Delete";
            this.buttonDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteProject.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Image = global::ODBX.Properties.Resources.folder;
            this.buttonBrowseFolder.Location = new System.Drawing.Point(681, 13);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(28, 23);
            this.buttonBrowseFolder.TabIndex = 5;
            this.buttonBrowseFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.ButtonBrowseFolderClick);
            // 
            // FormProjectBrowser
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(725, 431);
            this.Controls.Add(this.buttonDeleteProject);
            this.Controls.Add(this.buttonCopyProject);
            this.Controls.Add(this.buttonEditProject);
            this.Controls.Add(this.buttonNewProject);
            this.Controls.Add(this.buttonBrowseFolder);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.treeListView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Browser";
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnSummary;
        private BrightIdeasSoftware.OLVColumn olvColumnDate;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.Button buttonEditProject;
        private System.Windows.Forms.Button buttonCopyProject;
        private System.Windows.Forms.Button buttonDeleteProject;
    }
}