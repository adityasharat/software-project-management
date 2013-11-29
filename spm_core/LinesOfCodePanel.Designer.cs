namespace Spm_core
{
    partial class LinesOfCodePanel
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
            this.locResult = new System.Windows.Forms.Label();
            this.locButtonCal = new System.Windows.Forms.Button();
            this.locFilePath = new System.Windows.Forms.Label();
            this.locButtonBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locResult
            // 
            this.locResult.AutoSize = true;
            this.locResult.Location = new System.Drawing.Point(109, 45);
            this.locResult.Name = "locResult";
            this.locResult.Size = new System.Drawing.Size(0, 13);
            this.locResult.TabIndex = 7;
            // 
            // locButtonCal
            // 
            this.locButtonCal.Enabled = false;
            this.locButtonCal.Location = new System.Drawing.Point(3, 40);
            this.locButtonCal.Name = "locButtonCal";
            this.locButtonCal.Size = new System.Drawing.Size(100, 32);
            this.locButtonCal.TabIndex = 6;
            this.locButtonCal.Text = "Calculate";
            this.locButtonCal.UseVisualStyleBackColor = true;
            this.locButtonCal.Click += new System.EventHandler(this.locButtonCal_Click);
            // 
            // locFilePath
            // 
            this.locFilePath.AutoSize = true;
            this.locFilePath.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locFilePath.Location = new System.Drawing.Point(109, 11);
            this.locFilePath.Name = "locFilePath";
            this.locFilePath.Size = new System.Drawing.Size(0, 18);
            this.locFilePath.TabIndex = 5;
            // 
            // locButtonBrowse
            // 
            this.locButtonBrowse.Location = new System.Drawing.Point(3, 3);
            this.locButtonBrowse.Name = "locButtonBrowse";
            this.locButtonBrowse.Size = new System.Drawing.Size(100, 31);
            this.locButtonBrowse.TabIndex = 4;
            this.locButtonBrowse.Text = "Browse";
            this.locButtonBrowse.UseVisualStyleBackColor = true;
            this.locButtonBrowse.Click += new System.EventHandler(this.locButtonBrowse_Click);
            // 
            // LinesOfCodePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.locResult);
            this.Controls.Add(this.locButtonCal);
            this.Controls.Add(this.locFilePath);
            this.Controls.Add(this.locButtonBrowse);
            this.Name = "LinesOfCodePanel";
            this.Size = new System.Drawing.Size(480, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locResult;
        private System.Windows.Forms.Button locButtonCal;
        private System.Windows.Forms.Label locFilePath;
        private System.Windows.Forms.Button locButtonBrowse;
    }
}
