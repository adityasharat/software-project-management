namespace Software_Project_Management
{
    partial class CocomoPanel
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cocomoButtonCal = new System.Windows.Forms.Button();
            this.cocomoLOC = new System.Windows.Forms.TextBox();
            this.cocomoResultProductivity = new System.Windows.Forms.Label();
            this.cocomoResultAvgStaffSize = new System.Windows.Forms.Label();
            this.cocomoResultDuration = new System.Windows.Forms.Label();
            this.cocomoResultEffort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cocomoModeSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cocomoModelSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Avg. Staff Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Productivity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Effort:";
            // 
            // cocomoButtonCal
            // 
            this.cocomoButtonCal.Enabled = false;
            this.cocomoButtonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoButtonCal.Location = new System.Drawing.Point(315, 59);
            this.cocomoButtonCal.Name = "cocomoButtonCal";
            this.cocomoButtonCal.Size = new System.Drawing.Size(102, 29);
            this.cocomoButtonCal.TabIndex = 25;
            this.cocomoButtonCal.Text = "Calculate";
            this.cocomoButtonCal.UseVisualStyleBackColor = true;
            this.cocomoButtonCal.Click += new System.EventHandler(this.buttonCocomoCal_Click);
            // 
            // cocomoLOC
            // 
            this.cocomoLOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoLOC.Location = new System.Drawing.Point(192, 59);
            this.cocomoLOC.Name = "cocomoLOC";
            this.cocomoLOC.Size = new System.Drawing.Size(110, 26);
            this.cocomoLOC.TabIndex = 24;
            this.cocomoLOC.TextChanged += new System.EventHandler(this.cocomoLOC_TextChanged);
            this.cocomoLOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cocomoLOC_KeyPress);
            // 
            // cocomoResultProductivity
            // 
            this.cocomoResultProductivity.AutoSize = true;
            this.cocomoResultProductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoResultProductivity.Location = new System.Drawing.Point(272, 160);
            this.cocomoResultProductivity.Name = "cocomoResultProductivity";
            this.cocomoResultProductivity.Size = new System.Drawing.Size(0, 20);
            this.cocomoResultProductivity.TabIndex = 23;
            // 
            // cocomoResultAvgStaffSize
            // 
            this.cocomoResultAvgStaffSize.AutoSize = true;
            this.cocomoResultAvgStaffSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoResultAvgStaffSize.Location = new System.Drawing.Point(272, 184);
            this.cocomoResultAvgStaffSize.Name = "cocomoResultAvgStaffSize";
            this.cocomoResultAvgStaffSize.Size = new System.Drawing.Size(0, 20);
            this.cocomoResultAvgStaffSize.TabIndex = 22;
            // 
            // cocomoResultDuration
            // 
            this.cocomoResultDuration.AutoSize = true;
            this.cocomoResultDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoResultDuration.Location = new System.Drawing.Point(272, 134);
            this.cocomoResultDuration.Name = "cocomoResultDuration";
            this.cocomoResultDuration.Size = new System.Drawing.Size(0, 20);
            this.cocomoResultDuration.TabIndex = 21;
            // 
            // cocomoResultEffort
            // 
            this.cocomoResultEffort.AutoSize = true;
            this.cocomoResultEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoResultEffort.Location = new System.Drawing.Point(272, 110);
            this.cocomoResultEffort.Name = "cocomoResultEffort";
            this.cocomoResultEffort.Size = new System.Drawing.Size(0, 20);
            this.cocomoResultEffort.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Line of Code (KLOC): ";
            // 
            // cocomoModeSelect
            // 
            this.cocomoModeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cocomoModeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoModeSelect.FormattingEnabled = true;
            this.cocomoModeSelect.Items.AddRange(new object[] {
            "Organic",
            "Semi-detached",
            "Embedded"});
            this.cocomoModeSelect.Location = new System.Drawing.Point(273, 11);
            this.cocomoModeSelect.Name = "cocomoModeSelect";
            this.cocomoModeSelect.Size = new System.Drawing.Size(158, 28);
            this.cocomoModeSelect.TabIndex = 18;
            this.cocomoModeSelect.SelectedIndexChanged += new System.EventHandler(this.cocomoModeSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mode:";
            // 
            // cocomoModelSelect
            // 
            this.cocomoModelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cocomoModelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocomoModelSelect.FormattingEnabled = true;
            this.cocomoModelSelect.Items.AddRange(new object[] {
            "Basic",
            "Intermediate",
            "Detailed"});
            this.cocomoModelSelect.Location = new System.Drawing.Point(69, 11);
            this.cocomoModelSelect.Name = "cocomoModelSelect";
            this.cocomoModelSelect.Size = new System.Drawing.Size(126, 28);
            this.cocomoModelSelect.TabIndex = 16;
            this.cocomoModelSelect.SelectedIndexChanged += new System.EventHandler(this.modelSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model: ";
            // 
            // CocomoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cocomoButtonCal);
            this.Controls.Add(this.cocomoLOC);
            this.Controls.Add(this.cocomoResultProductivity);
            this.Controls.Add(this.cocomoResultAvgStaffSize);
            this.Controls.Add(this.cocomoResultDuration);
            this.Controls.Add(this.cocomoResultEffort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cocomoModeSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cocomoModelSelect);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CocomoPanel";
            this.Size = new System.Drawing.Size(459, 211);
            this.Load += new System.EventHandler(this.CocomoPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cocomoButtonCal;
        private System.Windows.Forms.TextBox cocomoLOC;
        private System.Windows.Forms.Label cocomoResultProductivity;
        private System.Windows.Forms.Label cocomoResultAvgStaffSize;
        private System.Windows.Forms.Label cocomoResultDuration;
        private System.Windows.Forms.Label cocomoResultEffort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cocomoModeSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cocomoModelSelect;
        private System.Windows.Forms.Label label1;
    }
}
