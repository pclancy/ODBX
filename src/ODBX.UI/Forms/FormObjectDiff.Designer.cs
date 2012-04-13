namespace ODBX.Forms
{
    partial class FormObjectDiff
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
            this.controlScriptDiff1 = new ODBX.Controls.ControlScriptDiff();
            this.panelDiffToolbar = new System.Windows.Forms.Panel();
            this.checkBoxShowDiff = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMerged = new System.Windows.Forms.CheckBox();
            this.panelDiffToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlScriptDiff1
            // 
            this.controlScriptDiff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlScriptDiff1.Location = new System.Drawing.Point(0, 30);
            this.controlScriptDiff1.Name = "controlScriptDiff1";
            this.controlScriptDiff1.Size = new System.Drawing.Size(806, 407);
            this.controlScriptDiff1.TabIndex = 1;
            // 
            // panelDiffToolbar
            // 
            this.panelDiffToolbar.Controls.Add(this.checkBoxShowDiff);
            this.panelDiffToolbar.Controls.Add(this.checkBoxShowMerged);
            this.panelDiffToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiffToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelDiffToolbar.Name = "panelDiffToolbar";
            this.panelDiffToolbar.Size = new System.Drawing.Size(806, 30);
            this.panelDiffToolbar.TabIndex = 2;
            // 
            // checkBoxShowDiff
            // 
            this.checkBoxShowDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowDiff.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowDiff.Checked = true;
            this.checkBoxShowDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowDiff.Image = global::ODBX.Properties.Resources.diff_16;
            this.checkBoxShowDiff.Location = new System.Drawing.Point(745, 3);
            this.checkBoxShowDiff.Name = "checkBoxShowDiff";
            this.checkBoxShowDiff.Size = new System.Drawing.Size(50, 24);
            this.checkBoxShowDiff.TabIndex = 1;
            this.checkBoxShowDiff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxShowDiff.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowMerged
            // 
            this.checkBoxShowMerged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowMerged.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowMerged.Image = global::ODBX.Properties.Resources.split;
            this.checkBoxShowMerged.Location = new System.Drawing.Point(689, 3);
            this.checkBoxShowMerged.Name = "checkBoxShowMerged";
            this.checkBoxShowMerged.Size = new System.Drawing.Size(50, 24);
            this.checkBoxShowMerged.TabIndex = 0;
            this.checkBoxShowMerged.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxShowMerged.UseVisualStyleBackColor = true;
            // 
            // FormObjectDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 437);
            this.Controls.Add(this.controlScriptDiff1);
            this.Controls.Add(this.panelDiffToolbar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FormObjectDiff";
            this.Text = "FormObjectDiff";
            this.panelDiffToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ControlScriptDiff controlScriptDiff1;
        private System.Windows.Forms.Panel panelDiffToolbar;
        private System.Windows.Forms.CheckBox checkBoxShowDiff;
        private System.Windows.Forms.CheckBox checkBoxShowMerged;
    }
}