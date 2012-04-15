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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupList));
            this.objectListView = new ODBX.Controls.ObjectListView();
            this.gradientPanelGroupHeader = new ODBX.Controls.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroupIcon = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.gradientPanelGroupHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView
            // 
            this.objectListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectListView.Location = new System.Drawing.Point(0, 35);
            this.objectListView.Name = "objectListView";
            this.objectListView.Size = new System.Drawing.Size(758, 165);
            this.objectListView.TabIndex = 4;
            this.objectListView.SelectionChanged += new ModelEventHandler(this.ObjectListViewSelectionChanged);
            // 
            // gradientPanelGroupHeader
            // 
            this.gradientPanelGroupHeader.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanelGroupHeader.Controls.Add(this.pictureBox1);
            this.gradientPanelGroupHeader.Controls.Add(this.pictureBoxGroupIcon);
            this.gradientPanelGroupHeader.Controls.Add(this.labelHeader);
            this.gradientPanelGroupHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientPanelGroupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelGroupHeader.GradientEndColor = System.Drawing.Color.White;
            this.gradientPanelGroupHeader.GradientStartColor = System.Drawing.SystemColors.ControlLight;
            this.gradientPanelGroupHeader.LineBottom = true;
            this.gradientPanelGroupHeader.LineColor = System.Drawing.Color.Gray;
            this.gradientPanelGroupHeader.LineLeft = false;
            this.gradientPanelGroupHeader.LineRight = false;
            this.gradientPanelGroupHeader.LineTop = false;
            this.gradientPanelGroupHeader.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelGroupHeader.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanelGroupHeader.Name = "gradientPanelGroupHeader";
            this.gradientPanelGroupHeader.Size = new System.Drawing.Size(758, 35);
            this.gradientPanelGroupHeader.TabIndex = 3;
            this.gradientPanelGroupHeader.Click += new System.EventHandler(this.GradientPanelGroupHeaderClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
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
            // labelHeader
            // 
            this.labelHeader.AutoEllipsis = true;
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Location = new System.Drawing.Point(76, 11);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(35, 13);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "label1";
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectListView);
            this.Controls.Add(this.gradientPanelGroupHeader);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GroupList";
            this.Size = new System.Drawing.Size(758, 200);
            this.gradientPanelGroupHeader.ResumeLayout(false);
            this.gradientPanelGroupHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelGroupHeader;
        private System.Windows.Forms.PictureBox pictureBoxGroupIcon;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ObjectListView objectListView;
    }
}
