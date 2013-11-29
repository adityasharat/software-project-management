namespace Spm_core
{
    partial class CyclomaticComplexityPanel
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
            this.cycloResult = new System.Windows.Forms.Label();
            this.cyloInfo = new System.Windows.Forms.Label();
            this.cycloButtonCal = new System.Windows.Forms.Button();
            this.cycloTextArea = new System.Windows.Forms.RichTextBox();
            this.cycloFilePath = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cycloResult
            // 
            this.cycloResult.AutoSize = true;
            this.cycloResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycloResult.Location = new System.Drawing.Point(560, 142);
            this.cycloResult.Name = "cycloResult";
            this.cycloResult.Size = new System.Drawing.Size(0, 16);
            this.cycloResult.TabIndex = 13;
            // 
            // cyloInfo
            // 
            this.cyloInfo.AutoSize = true;
            this.cyloInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyloInfo.Location = new System.Drawing.Point(522, 117);
            this.cyloInfo.Name = "cyloInfo";
            this.cyloInfo.Size = new System.Drawing.Size(183, 16);
            this.cyloInfo.TabIndex = 12;
            this.cyloInfo.Text = "The Cyclomatic Complexity is";
            this.cyloInfo.Visible = false;
            // 
            // cycloButtonCal
            // 
            this.cycloButtonCal.Enabled = false;
            this.cycloButtonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycloButtonCal.Location = new System.Drawing.Point(522, 84);
            this.cycloButtonCal.Name = "cycloButtonCal";
            this.cycloButtonCal.Size = new System.Drawing.Size(100, 30);
            this.cycloButtonCal.TabIndex = 11;
            this.cycloButtonCal.Text = "Calculate";
            this.cycloButtonCal.UseVisualStyleBackColor = true;
            this.cycloButtonCal.Click += new System.EventHandler(this.cycloCal_Click);
            // 
            // cycloTextArea
            // 
            this.cycloTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cycloTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycloTextArea.Location = new System.Drawing.Point(12, 84);
            this.cycloTextArea.Name = "cycloTextArea";
            this.cycloTextArea.Size = new System.Drawing.Size(504, 331);
            this.cycloTextArea.TabIndex = 10;
            this.cycloTextArea.Text = "";
            this.cycloTextArea.TextChanged += new System.EventHandler(this.cycloTextArea_TextChanged);
            // 
            // cycloFilePath
            // 
            this.cycloFilePath.AutoSize = true;
            this.cycloFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycloFilePath.Location = new System.Drawing.Point(97, 58);
            this.cycloFilePath.Name = "cycloFilePath";
            this.cycloFilePath.Size = new System.Drawing.Size(0, 16);
            this.cycloFilePath.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "File location:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // CyclomaticComplexityPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.cycloResult);
            this.Controls.Add(this.cyloInfo);
            this.Controls.Add(this.cycloButtonCal);
            this.Controls.Add(this.cycloTextArea);
            this.Controls.Add(this.cycloFilePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CyclomaticComplexityPanel";
            this.Size = new System.Drawing.Size(736, 427);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cycloResult;
        private System.Windows.Forms.Label cyloInfo;
        private System.Windows.Forms.Button cycloButtonCal;
        private System.Windows.Forms.RichTextBox cycloTextArea;
        private System.Windows.Forms.Label cycloFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
