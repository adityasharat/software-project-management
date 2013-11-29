namespace Spm_core
{
    partial class CocomoIIPanel
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
            this.cocomoIIReuse = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.cocomoIIResult = new System.Windows.Forms.Label();
            this.cocomoIIButtonCal = new System.Windows.Forms.Button();
            this.cocomoII3GL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cocomoIIReportDifficult = new System.Windows.Forms.TextBox();
            this.cocomoIIReportMedium = new System.Windows.Forms.TextBox();
            this.cocomoIIReportSimple = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cocomoIIScreenDifficult = new System.Windows.Forms.TextBox();
            this.cocomoIIScreenMedium = new System.Windows.Forms.TextBox();
            this.cocomoIIScreenSimple = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cocomoIIReuse)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cocomoIIReuse
            // 
            this.cocomoIIReuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIReuse.Location = new System.Drawing.Point(594, 50);
            this.cocomoIIReuse.Name = "cocomoIIReuse";
            this.cocomoIIReuse.Size = new System.Drawing.Size(120, 22);
            this.cocomoIIReuse.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(464, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 16);
            this.label18.TabIndex = 14;
            this.label18.Text = "Percentage Reuse:";
            // 
            // cocomoIIResult
            // 
            this.cocomoIIResult.AutoSize = true;
            this.cocomoIIResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIResult.Location = new System.Drawing.Point(91, 172);
            this.cocomoIIResult.Name = "cocomoIIResult";
            this.cocomoIIResult.Size = new System.Drawing.Size(0, 16);
            this.cocomoIIResult.TabIndex = 13;
            // 
            // cocomoIIButtonCal
            // 
            this.cocomoIIButtonCal.Enabled = false;
            this.cocomoIIButtonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIButtonCal.Location = new System.Drawing.Point(3, 141);
            this.cocomoIIButtonCal.Name = "cocomoIIButtonCal";
            this.cocomoIIButtonCal.Size = new System.Drawing.Size(84, 29);
            this.cocomoIIButtonCal.TabIndex = 12;
            this.cocomoIIButtonCal.Text = "Calculate";
            this.cocomoIIButtonCal.UseVisualStyleBackColor = true;
            this.cocomoIIButtonCal.Click += new System.EventHandler(this.cocomoIIButtonCal_Click);
            // 
            // cocomoII3GL
            // 
            this.cocomoII3GL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoII3GL.Location = new System.Drawing.Point(594, 24);
            this.cocomoII3GL.Name = "cocomoII3GL";
            this.cocomoII3GL.Size = new System.Drawing.Size(100, 22);
            this.cocomoII3GL.TabIndex = 11;
            this.cocomoII3GL.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoII3GL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(464, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "3 GL Components:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cocomoIIReportDifficult);
            this.panel2.Controls.Add(this.cocomoIIReportMedium);
            this.panel2.Controls.Add(this.cocomoIIReportSimple);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(223, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 131);
            this.panel2.TabIndex = 9;
            // 
            // cocomoIIReportDifficult
            // 
            this.cocomoIIReportDifficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIReportDifficult.Location = new System.Drawing.Point(99, 93);
            this.cocomoIIReportDifficult.Name = "cocomoIIReportDifficult";
            this.cocomoIIReportDifficult.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIReportDifficult.TabIndex = 6;
            this.cocomoIIReportDifficult.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIReportDifficult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // cocomoIIReportMedium
            // 
            this.cocomoIIReportMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIReportMedium.Location = new System.Drawing.Point(99, 60);
            this.cocomoIIReportMedium.Name = "cocomoIIReportMedium";
            this.cocomoIIReportMedium.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIReportMedium.TabIndex = 5;
            this.cocomoIIReportMedium.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIReportMedium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // cocomoIIReportSimple
            // 
            this.cocomoIIReportSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIReportSimple.Location = new System.Drawing.Point(99, 22);
            this.cocomoIIReportSimple.Name = "cocomoIIReportSimple";
            this.cocomoIIReportSimple.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIReportSimple.TabIndex = 4;
            this.cocomoIIReportSimple.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIReportSimple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Difficult:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Medium:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Simple:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cocomoIIScreenDifficult);
            this.panel1.Controls.Add(this.cocomoIIScreenMedium);
            this.panel1.Controls.Add(this.cocomoIIScreenSimple);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 132);
            this.panel1.TabIndex = 8;
            // 
            // cocomoIIScreenDifficult
            // 
            this.cocomoIIScreenDifficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIScreenDifficult.Location = new System.Drawing.Point(89, 94);
            this.cocomoIIScreenDifficult.Name = "cocomoIIScreenDifficult";
            this.cocomoIIScreenDifficult.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIScreenDifficult.TabIndex = 6;
            this.cocomoIIScreenDifficult.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIScreenDifficult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // cocomoIIScreenMedium
            // 
            this.cocomoIIScreenMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIScreenMedium.Location = new System.Drawing.Point(89, 61);
            this.cocomoIIScreenMedium.Name = "cocomoIIScreenMedium";
            this.cocomoIIScreenMedium.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIScreenMedium.TabIndex = 5;
            this.cocomoIIScreenMedium.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIScreenMedium.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // cocomoIIScreenSimple
            // 
            this.cocomoIIScreenSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoIIScreenSimple.Location = new System.Drawing.Point(89, 23);
            this.cocomoIIScreenSimple.Name = "cocomoIIScreenSimple";
            this.cocomoIIScreenSimple.Size = new System.Drawing.Size(100, 22);
            this.cocomoIIScreenSimple.TabIndex = 4;
            this.cocomoIIScreenSimple.TextChanged += new System.EventHandler(this.cocomoIIReportMedium_TextChanged);
            this.cocomoIIScreenSimple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoIIScreenSimple_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Difficult:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Medium:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Simple:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Screens";
            // 
            // CocomoIIPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.cocomoIIReuse);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cocomoIIResult);
            this.Controls.Add(this.cocomoIIButtonCal);
            this.Controls.Add(this.cocomoII3GL);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CocomoIIPanel";
            this.Size = new System.Drawing.Size(743, 236);
            this.Load += new System.EventHandler(this.CocomoIIPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cocomoIIReuse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cocomoIIReuse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label cocomoIIResult;
        private System.Windows.Forms.Button cocomoIIButtonCal;
        private System.Windows.Forms.TextBox cocomoII3GL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cocomoIIReportDifficult;
        private System.Windows.Forms.TextBox cocomoIIReportMedium;
        private System.Windows.Forms.TextBox cocomoIIReportSimple;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cocomoIIScreenDifficult;
        private System.Windows.Forms.TextBox cocomoIIScreenMedium;
        private System.Windows.Forms.TextBox cocomoIIScreenSimple;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
