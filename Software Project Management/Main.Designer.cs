namespace Software_Project_Management
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainTabPanel = new System.Windows.Forms.TabControl();
            this.panelCocomo = new System.Windows.Forms.TabPage();
            this.cocomoPanel1 = new Software_Project_Management.CocomoPanel();
            this.panelCocomoII = new System.Windows.Forms.TabPage();
            this.cocomoIIPanel1 = new Spm_core.CocomoIIPanel();
            this.panelCycloCom = new System.Windows.Forms.TabPage();
            this.cyclomaticComplexityPanel1 = new Spm_core.CyclomaticComplexityPanel();
            this.panelFuncPoint = new System.Windows.Forms.TabPage();
            this.functionPointPanel1 = new Spm_core.FunctionPointPanel();
            this.panelHalstead = new System.Windows.Forms.TabPage();
            this.halsteadPanel1 = new Spm_core.HalsteadPanel();
            this.panelLOC = new System.Windows.Forms.TabPage();
            this.linesOfCodePanel1 = new Spm_core.LinesOfCodePanel();
            this.panelPutnam = new System.Windows.Forms.TabPage();
            this.putnamPanel1 = new Spm_core.PutnamPanel();
            this.panelOther = new System.Windows.Forms.TabPage();
            this.mainTabPanel.SuspendLayout();
            this.panelCocomo.SuspendLayout();
            this.panelCocomoII.SuspendLayout();
            this.panelCycloCom.SuspendLayout();
            this.panelFuncPoint.SuspendLayout();
            this.panelHalstead.SuspendLayout();
            this.panelLOC.SuspendLayout();
            this.panelPutnam.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Controls.Add(this.panelCocomo);
            this.mainTabPanel.Controls.Add(this.panelCocomoII);
            this.mainTabPanel.Controls.Add(this.panelCycloCom);
            this.mainTabPanel.Controls.Add(this.panelFuncPoint);
            this.mainTabPanel.Controls.Add(this.panelHalstead);
            this.mainTabPanel.Controls.Add(this.panelLOC);
            this.mainTabPanel.Controls.Add(this.panelPutnam);
            this.mainTabPanel.Controls.Add(this.panelOther);
            this.mainTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTabPanel.Margin = new System.Windows.Forms.Padding(5);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.SelectedIndex = 0;
            this.mainTabPanel.Size = new System.Drawing.Size(1059, 692);
            this.mainTabPanel.TabIndex = 0;
            // 
            // panelCocomo
            // 
            this.panelCocomo.Controls.Add(this.cocomoPanel1);
            this.panelCocomo.Location = new System.Drawing.Point(4, 32);
            this.panelCocomo.Name = "panelCocomo";
            this.panelCocomo.Padding = new System.Windows.Forms.Padding(3);
            this.panelCocomo.Size = new System.Drawing.Size(1051, 656);
            this.panelCocomo.TabIndex = 0;
            this.panelCocomo.Text = "Cocomo";
            // 
            // cocomoPanel1
            // 
            this.cocomoPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoPanel1.Location = new System.Drawing.Point(8, 6);
            this.cocomoPanel1.Name = "cocomoPanel1";
            this.cocomoPanel1.Size = new System.Drawing.Size(464, 225);
            this.cocomoPanel1.TabIndex = 0;
            // 
            // panelCocomoII
            // 
            this.panelCocomoII.Controls.Add(this.cocomoIIPanel1);
            this.panelCocomoII.Location = new System.Drawing.Point(4, 32);
            this.panelCocomoII.Name = "panelCocomoII";
            this.panelCocomoII.Padding = new System.Windows.Forms.Padding(3);
            this.panelCocomoII.Size = new System.Drawing.Size(1051, 656);
            this.panelCocomoII.TabIndex = 1;
            this.panelCocomoII.Text = "Cocomo II";
            this.panelCocomoII.UseVisualStyleBackColor = true;
            // 
            // cocomoIIPanel1
            // 
            this.cocomoIIPanel1.Location = new System.Drawing.Point(8, 6);
            this.cocomoIIPanel1.Name = "cocomoIIPanel1";
            this.cocomoIIPanel1.Size = new System.Drawing.Size(743, 236);
            this.cocomoIIPanel1.TabIndex = 0;
            // 
            // panelCycloCom
            // 
            this.panelCycloCom.Controls.Add(this.cyclomaticComplexityPanel1);
            this.panelCycloCom.Location = new System.Drawing.Point(4, 32);
            this.panelCycloCom.Name = "panelCycloCom";
            this.panelCycloCom.Padding = new System.Windows.Forms.Padding(3);
            this.panelCycloCom.Size = new System.Drawing.Size(1051, 656);
            this.panelCycloCom.TabIndex = 2;
            this.panelCycloCom.Text = "Cyclomatic Complexity";
            this.panelCycloCom.UseVisualStyleBackColor = true;
            // 
            // cyclomaticComplexityPanel1
            // 
            this.cyclomaticComplexityPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cyclomaticComplexityPanel1.Location = new System.Drawing.Point(8, 6);
            this.cyclomaticComplexityPanel1.Name = "cyclomaticComplexityPanel1";
            this.cyclomaticComplexityPanel1.Size = new System.Drawing.Size(718, 642);
            this.cyclomaticComplexityPanel1.TabIndex = 0;
            // 
            // panelFuncPoint
            // 
            this.panelFuncPoint.Controls.Add(this.functionPointPanel1);
            this.panelFuncPoint.Location = new System.Drawing.Point(4, 32);
            this.panelFuncPoint.Name = "panelFuncPoint";
            this.panelFuncPoint.Padding = new System.Windows.Forms.Padding(3);
            this.panelFuncPoint.Size = new System.Drawing.Size(1051, 656);
            this.panelFuncPoint.TabIndex = 3;
            this.panelFuncPoint.Text = "FunctionPoint";
            this.panelFuncPoint.UseVisualStyleBackColor = true;
            // 
            // functionPointPanel1
            // 
            this.functionPointPanel1.Location = new System.Drawing.Point(3, 3);
            this.functionPointPanel1.Name = "functionPointPanel1";
            this.functionPointPanel1.Size = new System.Drawing.Size(1003, 640);
            this.functionPointPanel1.TabIndex = 0;
            // 
            // panelHalstead
            // 
            this.panelHalstead.Controls.Add(this.halsteadPanel1);
            this.panelHalstead.Location = new System.Drawing.Point(4, 32);
            this.panelHalstead.Name = "panelHalstead";
            this.panelHalstead.Padding = new System.Windows.Forms.Padding(3);
            this.panelHalstead.Size = new System.Drawing.Size(1051, 656);
            this.panelHalstead.TabIndex = 7;
            this.panelHalstead.Text = "Halstead Metric";
            this.panelHalstead.UseVisualStyleBackColor = true;
            // 
            // halsteadPanel1
            // 
            this.halsteadPanel1.Location = new System.Drawing.Point(8, 6);
            this.halsteadPanel1.Name = "halsteadPanel1";
            this.halsteadPanel1.Size = new System.Drawing.Size(750, 511);
            this.halsteadPanel1.TabIndex = 0;
            // 
            // panelLOC
            // 
            this.panelLOC.Controls.Add(this.linesOfCodePanel1);
            this.panelLOC.Location = new System.Drawing.Point(4, 32);
            this.panelLOC.Name = "panelLOC";
            this.panelLOC.Padding = new System.Windows.Forms.Padding(3);
            this.panelLOC.Size = new System.Drawing.Size(1051, 656);
            this.panelLOC.TabIndex = 4;
            this.panelLOC.Text = "Lines Of Code";
            this.panelLOC.UseVisualStyleBackColor = true;
            // 
            // linesOfCodePanel1
            // 
            this.linesOfCodePanel1.Location = new System.Drawing.Point(6, 6);
            this.linesOfCodePanel1.Name = "linesOfCodePanel1";
            this.linesOfCodePanel1.Size = new System.Drawing.Size(718, 80);
            this.linesOfCodePanel1.TabIndex = 0;
            // 
            // panelPutnam
            // 
            this.panelPutnam.Controls.Add(this.putnamPanel1);
            this.panelPutnam.Location = new System.Drawing.Point(4, 32);
            this.panelPutnam.Name = "panelPutnam";
            this.panelPutnam.Padding = new System.Windows.Forms.Padding(3);
            this.panelPutnam.Size = new System.Drawing.Size(1051, 656);
            this.panelPutnam.TabIndex = 5;
            this.panelPutnam.Text = "Putman Model";
            this.panelPutnam.UseVisualStyleBackColor = true;
            // 
            // putnamPanel1
            // 
            this.putnamPanel1.Location = new System.Drawing.Point(0, 0);
            this.putnamPanel1.Name = "putnamPanel1";
            this.putnamPanel1.Size = new System.Drawing.Size(747, 292);
            this.putnamPanel1.TabIndex = 0;
            // 
            // panelOther
            // 
            this.panelOther.Location = new System.Drawing.Point(4, 32);
            this.panelOther.Name = "panelOther";
            this.panelOther.Padding = new System.Windows.Forms.Padding(3);
            this.panelOther.Size = new System.Drawing.Size(1051, 656);
            this.panelOther.TabIndex = 8;
            this.panelOther.Text = "Other Cost Models";
            this.panelOther.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 692);
            this.Controls.Add(this.mainTabPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Software Metric Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabPanel.ResumeLayout(false);
            this.panelCocomo.ResumeLayout(false);
            this.panelCocomoII.ResumeLayout(false);
            this.panelCycloCom.ResumeLayout(false);
            this.panelFuncPoint.ResumeLayout(false);
            this.panelHalstead.ResumeLayout(false);
            this.panelLOC.ResumeLayout(false);
            this.panelPutnam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabPanel;
        private System.Windows.Forms.TabPage panelCocomo;
        private System.Windows.Forms.TabPage panelCocomoII;
        private System.Windows.Forms.TabPage panelCycloCom;
        private System.Windows.Forms.TabPage panelFuncPoint;
        private System.Windows.Forms.TabPage panelLOC;
        private System.Windows.Forms.TabPage panelPutnam;
        private System.Windows.Forms.TabPage panelHalstead;
        private System.Windows.Forms.TabPage panelOther;
        private CocomoPanel cocomoPanel1;
        private Spm_core.CocomoIIPanel cocomoIIPanel1;
        private Spm_core.CyclomaticComplexityPanel cyclomaticComplexityPanel1;
        private Spm_core.FunctionPointPanel functionPointPanel1;
        private Spm_core.HalsteadPanel halsteadPanel1;
        private Spm_core.LinesOfCodePanel linesOfCodePanel1;
        private Spm_core.PutnamPanel putnamPanel1;
    }
}

