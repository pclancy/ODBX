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
            this.textScriptLeft = new ScintillaNET.Scintilla();
            this.textScriptRight = new ScintillaNET.Scintilla();
            this.textScriptMerged = new ScintillaNET.Scintilla();
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
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainerMain.Size = new System.Drawing.Size(800, 444);
            this.splitContainerMain.SplitterDistance = 229;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerLeftRight
            // 
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
            this.splitContainerLeftRight.Size = new System.Drawing.Size(800, 229);
            this.splitContainerLeftRight.SplitterDistance = 400;
            this.splitContainerLeftRight.TabIndex = 0;
            // 
            // textLeftScript
            // 
            this.textScriptLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptLeft.Location = new System.Drawing.Point(0, 0);
            this.textScriptLeft.Name = "textScriptLeft";
            this.textScriptLeft.Size = new System.Drawing.Size(400, 229);
            this.textScriptLeft.TabIndex = 0;
            // 
            // textScriptRight
            // 
            this.textScriptRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptRight.Location = new System.Drawing.Point(0, 0);
            this.textScriptRight.Name = "textScriptRight";
            this.textScriptRight.Size = new System.Drawing.Size(396, 229);
            this.textScriptRight.TabIndex = 0;
            // 
            // textScriptMerged
            // 
            this.textScriptMerged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textScriptMerged.Location = new System.Drawing.Point(0, 0);
            this.textScriptMerged.Name = "textScriptMerged";
            this.textScriptMerged.Size = new System.Drawing.Size(800, 211);
            this.textScriptMerged.TabIndex = 0;
            // 
            // ControlScriptDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeftRight;
        private ScintillaNET.Scintilla textScriptLeft;
        private ScintillaNET.Scintilla textScriptRight;
        private ScintillaNET.Scintilla textScriptMerged;
    }
}
