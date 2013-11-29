namespace Spm_core
{
    partial class PutnamPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.effort = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.putnamButtonCal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultDM = new System.Windows.Forms.Label();
            this.resultMPB = new System.Windows.Forms.Label();
            this.resultPM = new System.Windows.Forms.Label();
            this.resultMPA = new System.Windows.Forms.Label();
            this.putnamButtonCalManPow = new System.Windows.Forms.Button();
            this.manPower = new System.Windows.Forms.TextBox();
            this.putnamButtonViz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Effort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Development Time (years):";
            // 
            // effort
            // 
            this.effort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effort.Location = new System.Drawing.Point(245, 8);
            this.effort.Name = "effort";
            this.effort.Size = new System.Drawing.Size(100, 26);
            this.effort.TabIndex = 2;
            this.effort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.effort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(245, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 26);
            this.time.TabIndex = 3;
            this.time.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // putnamButtonCal
            // 
            this.putnamButtonCal.Enabled = false;
            this.putnamButtonCal.Location = new System.Drawing.Point(368, 38);
            this.putnamButtonCal.Name = "putnamButtonCal";
            this.putnamButtonCal.Size = new System.Drawing.Size(91, 32);
            this.putnamButtonCal.TabIndex = 4;
            this.putnamButtonCal.Text = "Calculate";
            this.putnamButtonCal.UseVisualStyleBackColor = true;
            this.putnamButtonCal.Click += new System.EventHandler(this.putnamButtonCal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulty Metric:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Man Power Buildup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peak Manning:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Man Power at:";
            // 
            // resultDM
            // 
            this.resultDM.AutoSize = true;
            this.resultDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDM.Location = new System.Drawing.Point(258, 101);
            this.resultDM.Name = "resultDM";
            this.resultDM.Size = new System.Drawing.Size(0, 20);
            this.resultDM.TabIndex = 9;
            // 
            // resultMPB
            // 
            this.resultMPB.AutoSize = true;
            this.resultMPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMPB.Location = new System.Drawing.Point(258, 121);
            this.resultMPB.Name = "resultMPB";
            this.resultMPB.Size = new System.Drawing.Size(0, 20);
            this.resultMPB.TabIndex = 10;
            // 
            // resultPM
            // 
            this.resultPM.AutoSize = true;
            this.resultPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultPM.Location = new System.Drawing.Point(258, 141);
            this.resultPM.Name = "resultPM";
            this.resultPM.Size = new System.Drawing.Size(0, 20);
            this.resultPM.TabIndex = 11;
            // 
            // resultMPA
            // 
            this.resultMPA.AutoSize = true;
            this.resultMPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMPA.Location = new System.Drawing.Point(364, 161);
            this.resultMPA.Name = "resultMPA";
            this.resultMPA.Size = new System.Drawing.Size(0, 20);
            this.resultMPA.TabIndex = 12;
            // 
            // putnamButtonCalManPow
            // 
            this.putnamButtonCalManPow.Enabled = false;
            this.putnamButtonCalManPow.Location = new System.Drawing.Point(245, 195);
            this.putnamButtonCalManPow.Name = "putnamButtonCalManPow";
            this.putnamButtonCalManPow.Size = new System.Drawing.Size(100, 30);
            this.putnamButtonCalManPow.TabIndex = 13;
            this.putnamButtonCalManPow.Text = "Calculate";
            this.putnamButtonCalManPow.UseVisualStyleBackColor = true;
            this.putnamButtonCalManPow.Click += new System.EventHandler(this.putnamButtonCalManPow_Click);
            // 
            // manPower
            // 
            this.manPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manPower.Location = new System.Drawing.Point(245, 163);
            this.manPower.Name = "manPower";
            this.manPower.Size = new System.Drawing.Size(100, 26);
            this.manPower.TabIndex = 14;
            this.manPower.TextChanged += new System.EventHandler(this.manPower_TextChanged);
            this.manPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // putnamButtonViz
            // 
            this.putnamButtonViz.Enabled = false;
            this.putnamButtonViz.Location = new System.Drawing.Point(245, 231);
            this.putnamButtonViz.Name = "putnamButtonViz";
            this.putnamButtonViz.Size = new System.Drawing.Size(100, 31);
            this.putnamButtonViz.TabIndex = 15;
            this.putnamButtonViz.Text = "Visualize";
            this.putnamButtonViz.UseVisualStyleBackColor = true;
            this.putnamButtonViz.Click += new System.EventHandler(this.putnamButtonViz_Click);
            // 
            // PutnamPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.putnamButtonViz);
            this.Controls.Add(this.manPower);
            this.Controls.Add(this.putnamButtonCalManPow);
            this.Controls.Add(this.resultMPA);
            this.Controls.Add(this.resultPM);
            this.Controls.Add(this.resultMPB);
            this.Controls.Add(this.resultDM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.putnamButtonCal);
            this.Controls.Add(this.time);
            this.Controls.Add(this.effort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PutnamPanel";
            this.Size = new System.Drawing.Size(551, 275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox effort;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button putnamButtonCal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultDM;
        private System.Windows.Forms.Label resultMPB;
        private System.Windows.Forms.Label resultPM;
        private System.Windows.Forms.Label resultMPA;
        private System.Windows.Forms.Button putnamButtonCalManPow;
        private System.Windows.Forms.TextBox manPower;
        private System.Windows.Forms.Button putnamButtonViz;
    }
}
