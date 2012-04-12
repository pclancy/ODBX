namespace ODBX.Forms
{
    partial class FormProgress
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
            this.labelOperation = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.gradientPanel2 = new ODBX.Controls.GradientPanel();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(83, 60);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(57, 15);
            this.labelOperation.TabIndex = 20;
            this.labelOperation.Text = "Waiting...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(85, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 50;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(82, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(470, 23);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Running Database Comparison...";
            // 
            // panelIcon
            // 
            this.panelIcon.AutoSize = true;
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = global::ODBX.Properties.Resources.diff;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelIcon.Location = new System.Drawing.Point(39, 37);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(37, 39);
            this.panelIcon.TabIndex = 4;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(429, 18);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "OK";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(510, 18);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.gradientPanel2.Controls.Add(this.buttonAccept);
            this.gradientPanel2.Controls.Add(this.buttonCancel);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.EndColor = System.Drawing.Color.Empty;
            this.gradientPanel2.LineBottom = false;
            this.gradientPanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanel2.LineLeft = false;
            this.gradientPanel2.LineRight = false;
            this.gradientPanel2.LineTop = true;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 155);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(597, 53);
            this.gradientPanel2.StartColor = System.Drawing.Color.Empty;
            this.gradientPanel2.TabIndex = 21;
            // 
            // FormProgress
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(597, 208);
            this.ControlBox = false;
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Status";
            this.Shown += new System.EventHandler(this.FormProgressShown);
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private Controls.GradientPanel gradientPanel2;

    }
}