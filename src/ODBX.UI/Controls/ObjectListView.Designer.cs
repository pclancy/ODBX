namespace ODBX.Controls
{
    partial class ObjectListView
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
            this.ListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.olvColumnType);
            this.ListView.AllColumns.Add(this.olvColumnName);
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.CheckBoxes = true;
            this.ListView.CheckedAspectName = "Include";
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnType,
            this.olvColumnName});
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HasCollapsibleGroups = false;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.HideSelection = false;
            this.ListView.IncludeColumnHeadersInCopy = true;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.RowHeight = 24;
            this.ListView.Scrollable = false;
            this.ListView.ShowGroups = false;
            this.ListView.ShowImagesOnSubItems = true;
            this.ListView.Size = new System.Drawing.Size(761, 302);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.UseExplorerTheme = true;
            this.ListView.UseSubItemCheckBoxes = true;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectionChanged += new System.EventHandler(this.ListViewSelectionChanged);
            // 
            // olvColumnType
            // 
            this.olvColumnType.AspectName = "Type";
            this.olvColumnType.Groupable = false;
            this.olvColumnType.IsEditable = false;
            this.olvColumnType.Sortable = false;
            this.olvColumnType.Text = "Type";
            this.olvColumnType.Width = 125;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Groupable = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 167;
            // 
            // ObjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView);
            this.Name = "ObjectListView";
            this.Size = new System.Drawing.Size(761, 302);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView ListView;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
    }
}
