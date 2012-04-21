namespace ODBX.Controls
{
    partial class ControlScriptDiff
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftRight = new System.Windows.Forms.SplitContainer();
            this.textScriptLeft = new ODBX.Controls.ScriptViewer();
            this.textScriptRight = new ODBX.Controls.ScriptViewer();
            this.textScriptMerged = new ODBX.Controls.ScriptViewer();
            this.panelDiffToolbar = new ODBX.Controls.GradientPanel();
            this.buttonTearWindow = new System.Windows.Forms.Button();
            this.labelDifference = new System.Windows.Forms.Label();
            this.labelObjectRight = new System.Windows.Forms.Label();
            this.labelObjectLeft = new System.Windows.Forms.Label();
            this.checkBoxShowDiff = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMerged = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftRight)).BeginInit();
            this.splitContainerLeftRight.Panel1.SuspendLayout();
            this.splitContainerLeftRight.Panel2.SuspendLayout();
            this.splitContainerLeftRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textScriptLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScriptRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScriptMerged)).BeginInit();
            this.panelDiffToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 33);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeftRight);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.textScriptMerged);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 411);
            this.splitContainerMain.SplitterDistance = 211;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerLeftRight
            // 
            this.splitContainerLeftRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftRight.Name = "splitContainerLeftRight";
            // 
            // splitContainerLeftRight.Panel1
            // 
            this.splitContainerLeftRight.Panel1.Controls.Add(this.textScriptLeft);
            // 
            // splitContainerLeftRight.Panel2
            // 
            this.splitContainerLeftRight.Panel2.Controls.Add(this.textScriptRight);
            this.splitContainerLeftRight.Size = new System.Drawing.Size(800, 211);
            this.splitContainerLeftRight.SplitterDistance = 400;
            this.splitContainerLeftRight.TabIndex = 0;
            // 
            // textScriptLeft
            // 
            this.textScriptLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScriptLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptLeft.Location = new System.Drawing.Point(0, 0);
            this.textScriptLeft.Name = "textScriptLeft";
            this.textScriptLeft.Size = new System.Drawing.Size(398, 209);
            this.textScriptLeft.TabIndex = 0;
            this.textScriptLeft.Text = "Left";
            // 
            // textScriptRight
            // 
            this.textScriptRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScriptRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptRight.Location = new System.Drawing.Point(0, 0);
            this.textScriptRight.Name = "textScriptRight";
            this.textScriptRight.Size = new System.Drawing.Size(394, 209);
            this.textScriptRight.TabIndex = 0;
            this.textScriptRight.Text = "Right";
            // 
            // textScriptMerged
            // 
            this.textScriptMerged.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScriptMerged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptMerged.Location = new System.Drawing.Point(0, 0);
            this.textScriptMerged.Name = "textScriptMerged";
            this.textScriptMerged.Size = new System.Drawing.Size(798, 194);
            this.textScriptMerged.TabIndex = 0;
            this.textScriptMerged.Text = "Merged";
            // 
            // panelDiffToolbar
            // 
            this.panelDiffToolbar.Controls.Add(this.buttonTearWindow);
            this.panelDiffToolbar.Controls.Add(this.labelDifference);
            this.panelDiffToolbar.Controls.Add(this.labelObjectRight);
            this.panelDiffToolbar.Controls.Add(this.labelObjectLeft);
            this.panelDiffToolbar.Controls.Add(this.checkBoxShowDiff);
            this.panelDiffToolbar.Controls.Add(this.checkBoxShowMerged);
            this.panelDiffToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiffToolbar.GradientEndColor = System.Drawing.Color.Empty;
            this.panelDiffToolbar.GradientStartColor = System.Drawing.Color.Empty;
            this.panelDiffToolbar.LineBottom = false;
            this.panelDiffToolbar.LineColor = System.Drawing.SystemColors.ControlDark;
            this.panelDiffToolbar.LineLeft = false;
            this.panelDiffToolbar.LineRight = false;
            this.panelDiffToolbar.LineTop = true;
            this.panelDiffToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelDiffToolbar.Name = "panelDiffToolbar";
            this.panelDiffToolbar.Size = new System.Drawing.Size(800, 33);
            this.panelDiffToolbar.TabIndex = 4;
            // 
            // buttonTearWindow
            // 
            this.buttonTearWindow.Image = global::ODBX.Properties.Resources.window_16;
            this.buttonTearWindow.Location = new System.Drawing.Point(3, 6);
            this.buttonTearWindow.Name = "buttonTearWindow";
            this.buttonTearWindow.Size = new System.Drawing.Size(50, 24);
            this.buttonTearWindow.TabIndex = 5;
            this.buttonTearWindow.UseVisualStyleBackColor = true;
            this.buttonTearWindow.Click += new System.EventHandler(this.ButtonTearWindowClick);
            // 
            // labelDifference
            // 
            this.labelDifference.AutoSize = true;
            this.labelDifference.Location = new System.Drawing.Point(59, 9);
            this.labelDifference.Name = "labelDifference";
            this.labelDifference.Size = new System.Drawing.Size(35, 13);
            this.labelDifference.TabIndex = 4;
            this.labelDifference.Text = "label1";
            // 
            // labelObjectRight
            // 
            this.labelObjectRight.AutoSize = true;
            this.labelObjectRight.Location = new System.Drawing.Point(410, 9);
            this.labelObjectRight.Name = "labelObjectRight";
            this.labelObjectRight.Size = new System.Drawing.Size(35, 13);
            this.labelObjectRight.TabIndex = 3;
            this.labelObjectRight.Text = "label2";
            this.labelObjectRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelObjectLeft
            // 
            this.labelObjectLeft.AutoSize = true;
            this.labelObjectLeft.Location = new System.Drawing.Point(365, 9);
            this.labelObjectLeft.Name = "labelObjectLeft";
            this.labelObjectLeft.Size = new System.Drawing.Size(35, 13);
            this.labelObjectLeft.TabIndex = 2;
            this.labelObjectLeft.Text = "label1";
            this.labelObjectLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowDiff
            // 
            this.checkBoxShowDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowDiff.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowDiff.Checked = true;
            this.checkBoxShowDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowDiff.Image = global::ODBX.Properties.Resources.application_tile_horizontal;
            this.checkBoxShowDiff.Location = new System.Drawing.Point(679, 3);
            this.checkBoxShowDiff.Name = "checkBoxShowDiff";
            this.checkBoxShowDiff.Size = new System.Drawing.Size(50, 24);
            this.checkBoxShowDiff.TabIndex = 1;
            this.checkBoxShowDiff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxShowDiff.UseVisualStyleBackColor = true;
            this.checkBoxShowDiff.CheckedChanged += new System.EventHandler(this.CheckBoxShowDiffCheckedChanged);
            // 
            // checkBoxShowMerged
            // 
            this.checkBoxShowMerged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowMerged.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowMerged.Checked = true;
            this.checkBoxShowMerged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMerged.Image = global::ODBX.Properties.Resources.split;
            this.checkBoxShowMerged.Location = new System.Drawing.Point(735, 3);
            this.checkBoxShowMerged.Name = "checkBoxShowMerged";
            this.checkBoxShowMerged.Size = new System.Drawing.Size(50, 24);
            this.checkBoxShowMerged.TabIndex = 0;
            this.checkBoxShowMerged.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxShowMerged.UseVisualStyleBackColor = true;
            this.checkBoxShowMerged.CheckedChanged += new System.EventHandler(this.CheckBoxShowMergedCheckedChanged);
            // 
            // ControlScriptDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelDiffToolbar);
            this.Name = "ControlScriptDiff";
            this.Size = new System.Drawing.Size(800, 444);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeftRight.Panel1.ResumeLayout(false);
            this.splitContainerLeftRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftRight)).EndInit();
            this.splitContainerLeftRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textScriptLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScriptRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textScriptMerged)).EndInit();
            this.panelDiffToolbar.ResumeLayout(false);
            this.panelDiffToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeftRight;
        private ScriptViewer textScriptLeft;
        private ScriptViewer textScriptRight;
        private ScriptViewer textScriptMerged;
        private GradientPanel panelDiffToolbar;
        private System.Windows.Forms.Button buttonTearWindow;
        private System.Windows.Forms.Label labelDifference;
        private System.Windows.Forms.Label labelObjectRight;
        private System.Windows.Forms.Label labelObjectLeft;
        private System.Windows.Forms.CheckBox checkBoxShowDiff;
        private System.Windows.Forms.CheckBox checkBoxShowMerged;
    }
}
