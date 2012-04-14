namespace ODBX.Controls
{
    partial class GroupList
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
            this.listViewObjects = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gradientPanelGroupHeader = new ODBX.Controls.GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxGroupIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listViewObjects)).BeginInit();
            this.gradientPanelGroupHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewObjects
            // 
            this.listViewObjects.AllColumns.Add(this.olvColumnType);
            this.listViewObjects.AllColumns.Add(this.olvColumn2);
            this.listViewObjects.AllColumns.Add(this.olvColumn3);
            this.listViewObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewObjects.CheckBoxes = true;
            this.listViewObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnType,
            this.olvColumn2,
            this.olvColumn3});
            this.listViewObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewObjects.FullRowSelect = true;
            this.listViewObjects.GridLines = true;
            this.listViewObjects.Location = new System.Drawing.Point(0, 35);
            this.listViewObjects.Name = "listViewObjects";
            this.listViewObjects.Size = new System.Drawing.Size(758, 165);
            this.listViewObjects.TabIndex = 0;
            this.listViewObjects.UseCompatibleStateImageBehavior = false;
            this.listViewObjects.View = System.Windows.Forms.View.Details;
            this.listViewObjects.Visible = false;
            // 
            // olvColumnType
            // 
            this.olvColumnType.Groupable = false;
            this.olvColumnType.IsEditable = false;
            this.olvColumnType.Sortable = false;
            this.olvColumnType.Text = "Type";
            this.olvColumnType.Width = 125;
            // 
            // olvColumn2
            // 
            this.olvColumn2.Width = 167;
            // 
            // gradientPanelGroupHeader
            // 
            this.gradientPanelGroupHeader.Controls.Add(this.button1);
            this.gradientPanelGroupHeader.Controls.Add(this.pictureBoxGroupIcon);
            this.gradientPanelGroupHeader.Controls.Add(this.label1);
            this.gradientPanelGroupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelGroupHeader.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradientPanelGroupHeader.LineBottom = true;
            this.gradientPanelGroupHeader.LineColor = System.Drawing.Color.Gray;
            this.gradientPanelGroupHeader.LineLeft = false;
            this.gradientPanelGroupHeader.LineRight = false;
            this.gradientPanelGroupHeader.LineTop = false;
            this.gradientPanelGroupHeader.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelGroupHeader.Name = "gradientPanelGroupHeader";
            this.gradientPanelGroupHeader.Size = new System.Drawing.Size(758, 35);
            this.gradientPanelGroupHeader.StartColor = System.Drawing.SystemColors.Control;
            this.gradientPanelGroupHeader.TabIndex = 3;
            this.gradientPanelGroupHeader.Click += new System.EventHandler(this.GradientPanel1Click);
            // 
            // button1
            // 
            this.button1.Image = global::ODBX.Properties.Resources.expand;
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGroupIcon
            // 
            this.pictureBoxGroupIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGroupIcon.Image = global::ODBX.Properties.Resources.db_table;
            this.pictureBoxGroupIcon.Location = new System.Drawing.Point(36, 10);
            this.pictureBoxGroupIcon.Name = "pictureBoxGroupIcon";
            this.pictureBoxGroupIcon.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxGroupIcon.TabIndex = 5;
            this.pictureBoxGroupIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewObjects);
            this.Controls.Add(this.gradientPanelGroupHeader);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GroupList";
            this.Size = new System.Drawing.Size(758, 200);
            ((System.ComponentModel.ISupportInitialize)(this.listViewObjects)).EndInit();
            this.gradientPanelGroupHeader.ResumeLayout(false);
            this.gradientPanelGroupHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelGroupHeader;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxGroupIcon;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.ObjectListView listViewObjects;
    }
}
