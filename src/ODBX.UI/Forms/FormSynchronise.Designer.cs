namespace ODBX.Forms
{
    partial class FormSynchronise
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
            this.textScript = new ScintillaNET.Scintilla();
            this.gradientPanel2 = new ODBX.Controls.GradientPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.gradientPanel1 = new ODBX.Controls.GradientPanel();
            this.labelHeaderAction = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textScript
            // 
            this.textScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScript.IsReadOnly = true;
            this.textScript.Location = new System.Drawing.Point(0, 75);
            this.textScript.Margins.Margin0.IsClickable = true;
            this.textScript.Margins.Margin0.IsFoldMargin = true;
            this.textScript.Margins.Margin0.IsMarkerMargin = true;
            this.textScript.Margins.Margin0.Width = 50;
            this.textScript.Name = "textScript";
            this.textScript.Size = new System.Drawing.Size(818, 343);
            this.textScript.TabIndex = 2;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Controls.Add(this.buttonSave);
            this.gradientPanel2.Controls.Add(this.buttonAccept);
            this.gradientPanel2.Controls.Add(this.buttonCancel);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gradientPanel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradientPanel2.LineBottom = false;
            this.gradientPanel2.LineColor = System.Drawing.Color.DarkGray;
            this.gradientPanel2.LineLeft = false;
            this.gradientPanel2.LineRight = false;
            this.gradientPanel2.LineTop = true;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 418);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(818, 45);
            this.gradientPanel2.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 26);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save Script...";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(639, 10);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(86, 26);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Synchronise";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(731, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.Controls.Add(this.labelHeaderAction);
            this.gradientPanel1.Controls.Add(this.labelHeader);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.GradientEndColor = System.Drawing.Color.White;
            this.gradientPanel1.GradientStartColor = System.Drawing.Color.White;
            this.gradientPanel1.LineBottom = false;
            this.gradientPanel1.LineColor = System.Drawing.Color.Empty;
            this.gradientPanel1.LineLeft = false;
            this.gradientPanel1.LineRight = false;
            this.gradientPanel1.LineTop = false;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.gradientPanel1.Size = new System.Drawing.Size(818, 75);
            this.gradientPanel1.TabIndex = 0;
            // 
            // labelHeaderAction
            // 
            this.labelHeaderAction.AutoSize = true;
            this.labelHeaderAction.BackColor = System.Drawing.Color.Transparent;
            this.labelHeaderAction.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelHeaderAction.Location = new System.Drawing.Point(57, 31);
            this.labelHeaderAction.Name = "labelHeaderAction";
            this.labelHeaderAction.Size = new System.Drawing.Size(42, 16);
            this.labelHeaderAction.TabIndex = 2;
            this.labelHeaderAction.Text = "label1";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(56, 14);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(231, 17);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Database Synchronisation Script";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ODBX.Properties.Resources.database_lightning;
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormSynchronise
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(818, 463);
            this.Controls.Add(this.textScript);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormSynchronise";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synchronisation Script";
            ((System.ComponentModel.ISupportInitialize)(this.textScript)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GradientPanel gradientPanel1;
        private Controls.GradientPanel gradientPanel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private ScintillaNET.Scintilla textScript;
        private System.Windows.Forms.Label labelHeaderAction;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}