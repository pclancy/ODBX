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
            this.tableLayoutView = new System.Windows.Forms.TableLayoutPanel();
            this.controlScriptDiff1 = new ODBX.Controls.ControlScriptDiff();
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
            this.splitContainerMain.Location = new System.Drawing.Point(0, 54);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutView);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.controlScriptDiff1);
            this.splitContainerMain.Size = new System.Drawing.Size(792, 400);
            this.splitContainerMain.SplitterDistance = 185;
            this.splitContainerMain.TabIndex = 3;
            // 
            // tableLayoutView
            // 
            this.tableLayoutView.AutoScroll = true;
            this.tableLayoutView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutView.ColumnCount = 1;
            this.tableLayoutView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutView.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutView.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutView.Name = "tableLayoutView";
            this.tableLayoutView.RowCount = 1;
            this.tableLayoutView.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutView.Size = new System.Drawing.Size(792, 185);
            this.tableLayoutView.TabIndex = 0;
            // 
            // controlScriptDiff1
            // 
            this.controlScriptDiff1.BottomContent = "";
            this.controlScriptDiff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlScriptDiff1.LeftContent = "";
            this.controlScriptDiff1.Location = new System.Drawing.Point(0, 0);
            this.controlScriptDiff1.ModelObject = null;
            this.controlScriptDiff1.Name = "controlScriptDiff1";
            this.controlScriptDiff1.RightContent = "";
            this.controlScriptDiff1.Size = new System.Drawing.Size(792, 211);
            this.controlScriptDiff1.TabIndex = 0;
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
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 54);
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
            this.panelDestination.Location = new System.Drawing.Point(440, 3);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Padding = new System.Windows.Forms.Padding(5);
            this.panelDestination.Size = new System.Drawing.Size(349, 109);
            this.panelDestination.TabIndex = 1;
            // 
            // labelTargetCatalog
            // 
            this.labelTargetCatalog.AutoEllipsis = true;
            this.labelTargetCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetCatalog.Location = new System.Drawing.Point(50, 24);
            this.labelTargetCatalog.Name = "labelTargetCatalog";
            this.labelTargetCatalog.Size = new System.Drawing.Size(290, 20);
            this.labelTargetCatalog.TabIndex = 3;
            this.labelTargetCatalog.Text = "label1";
            this.labelTargetCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTargetConnection
            // 
            this.labelTargetConnection.AutoEllipsis = true;
            this.labelTargetConnection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTargetConnection.Location = new System.Drawing.Point(50, 5);
            this.labelTargetConnection.Name = "labelTargetConnection";
            this.labelTargetConnection.Size = new System.Drawing.Size(290, 19);
            this.labelTargetConnection.TabIndex = 2;
            this.labelTargetConnection.Text = "label2";
            this.labelTargetConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelDirection.Location = new System.Drawing.Point(358, 3);
            this.panelDirection.Name = "panelDirection";
            this.panelDirection.Size = new System.Drawing.Size(75, 43);
            this.panelDirection.TabIndex = 2;
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
            this.panelSource.Size = new System.Drawing.Size(349, 109);
            this.panelSource.TabIndex = 0;
            // 
            // labelSourceCatalog
            // 
            this.labelSourceCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSourceCatalog.AutoEllipsis = true;
            this.labelSourceCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSourceCatalog.Location = new System.Drawing.Point(9, 24);
            this.labelSourceCatalog.Name = "labelSourceCatalog";
            this.labelSourceCatalog.Size = new System.Drawing.Size(282, 20);
            this.labelSourceCatalog.TabIndex = 2;
            this.labelSourceCatalog.Text = "label1jkljkljjkljkljkll";
            this.labelSourceCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSourceConnection
            // 
            this.labelSourceConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSourceConnection.AutoEllipsis = true;
            this.labelSourceConnection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSourceConnection.Location = new System.Drawing.Point(9, 5);
            this.labelSourceConnection.Name = "labelSourceConnection";
            this.labelSourceConnection.Size = new System.Drawing.Size(282, 19);
            this.labelSourceConnection.TabIndex = 1;
            this.labelSourceConnection.Text = "label1";
            this.labelSourceConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSourceIcon
            // 
            this.panelSourceIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSourceIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSourceIcon.Image = global::ODBX.Properties.Resources.database;
            this.panelSourceIcon.Location = new System.Drawing.Point(307, 5);
            this.panelSourceIcon.Name = "panelSourceIcon";
            this.panelSourceIcon.Size = new System.Drawing.Size(37, 99);
            this.panelSourceIcon.TabIndex = 0;
            this.panelSourceIcon.TabStop = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 454);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(117, 115);
            this.Name = "FormProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormProject";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDestination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDestinationIcon)).EndInit();
            this.panelSource.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelSourceConnection;
        private System.Windows.Forms.Label labelTargetConnection;
        private System.Windows.Forms.Label labelTargetCatalog;
        private System.Windows.Forms.Label labelSourceCatalog;
        private Controls.ControlScriptDiff controlScriptDiff1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutView;


    }
}