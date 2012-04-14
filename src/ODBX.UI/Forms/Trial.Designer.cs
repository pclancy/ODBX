namespace ODBX.Forms
{
    partial class Trial
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupList1 = new ODBX.Controls.GroupList();
            this.groupList2 = new ODBX.Controls.GroupList();
            this.groupList3 = new ODBX.Controls.GroupList();
            this.groupList4 = new ODBX.Controls.GroupList();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupList1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupList2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupList3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupList4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupList1
            // 
            this.groupList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList1.Location = new System.Drawing.Point(3, 3);
            this.groupList1.Name = "groupList1";
            this.groupList1.Size = new System.Drawing.Size(773, 179);
            this.groupList1.TabIndex = 0;
            // 
            // groupList2
            // 
            this.groupList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList2.Location = new System.Drawing.Point(3, 188);
            this.groupList2.Name = "groupList2";
            this.groupList2.Size = new System.Drawing.Size(773, 179);
            this.groupList2.TabIndex = 1;
            // 
            // groupList3
            // 
            this.groupList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList3.Location = new System.Drawing.Point(3, 373);
            this.groupList3.Name = "groupList3";
            this.groupList3.Size = new System.Drawing.Size(773, 34);
            this.groupList3.TabIndex = 2;
            // 
            // groupList4
            // 
            this.groupList4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList4.Location = new System.Drawing.Point(3, 413);
            this.groupList4.Name = "groupList4";
            this.groupList4.Size = new System.Drawing.Size(773, 244);
            this.groupList4.TabIndex = 3;
            // 
            // Trial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Trial";
            this.Text = "Trial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.GroupList groupList1;
        private Controls.GroupList groupList2;
        private Controls.GroupList groupList3;
        private Controls.GroupList groupList4;
    }
}