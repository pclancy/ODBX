namespace ODBX.Controls
{
    partial class ObjectListGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridResults = new ODBX.Controls.ResultGrid();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInclude = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // GridResults
            // 
            this.GridResults.AllowUserToAddRows = false;
            this.GridResults.AllowUserToDeleteRows = false;
            this.GridResults.AllowUserToResizeColumns = false;
            this.GridResults.AllowUserToResizeRows = false;
            this.GridResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridResults.ColumnHeadersHeight = 24;
            this.GridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnName,
            this.ColumnInclude,
            this.NameRight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridResults.GridColor = System.Drawing.SystemColors.Control;
            this.GridResults.Location = new System.Drawing.Point(0, 0);
            this.GridResults.Margin = new System.Windows.Forms.Padding(0);
            this.GridResults.MultiSelect = false;
            this.GridResults.Name = "GridResults";
            this.GridResults.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridResults.RowHeadersVisible = false;
            this.GridResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResults.ShowCellErrors = false;
            this.GridResults.ShowEditingIcon = false;
            this.GridResults.ShowRowErrors = false;
            this.GridResults.Size = new System.Drawing.Size(788, 505);
            this.GridResults.TabIndex = 0;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Object.Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 140;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "SourceName";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnInclude
            // 
            this.ColumnInclude.DataPropertyName = "Include";
            this.ColumnInclude.HeaderText = "Include";
            this.ColumnInclude.Name = "ColumnInclude";
            this.ColumnInclude.ReadOnly = true;
            // 
            // NameRight
            // 
            this.NameRight.DataPropertyName = "TargetName";
            this.NameRight.HeaderText = "Name";
            this.NameRight.Name = "NameRight";
            this.NameRight.ReadOnly = true;
            // 
            // ObjectListGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridResults);
            this.Name = "ObjectListGrid";
            this.Size = new System.Drawing.Size(788, 505);
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ResultGrid GridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnInclude;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRight;
    }
}
