using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Spm_core
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class FunctionPointPanel : UserControl
    {
        public FunctionPointPanel()
        {
            InitializeComponent();
        }

        private void FunctionPointPanel_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 3;
            this.comboBox2.SelectedIndex = 3;
            this.comboBox3.SelectedIndex = 3;
            this.comboBox4.SelectedIndex = 3;
            this.comboBox5.SelectedIndex = 3;
            this.comboBox6.SelectedIndex = 3;
            this.comboBox7.SelectedIndex = 3;
            this.comboBox8.SelectedIndex = 3;
            this.comboBox9.SelectedIndex = 3;
            this.comboBox10.SelectedIndex = 3;
            this.comboBox11.SelectedIndex = 3;
            this.comboBox12.SelectedIndex = 3;
            this.comboBox13.SelectedIndex = 3;
            this.comboBox14.SelectedIndex = 3;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int[][] fp = new int[5][];
            for (int i = 0; i < 5; i++)
                fp[i] = new int[3];
            
            int[] caf = new int[14];

            try
            {
                fp[0][0] = Convert.ToInt32(this.eiLow.Text);
                fp[0][1] = Convert.ToInt32(this.eiAvg.Text);
                fp[0][2] = Convert.ToInt32(this.eiHigh.Text);

                fp[1][0] = Convert.ToInt32(this.eoLow.Text);
                fp[1][1] = Convert.ToInt32(this.eoAvg.Text);
                fp[1][2] = Convert.ToInt32(this.eoHigh.Text);

                fp[2][0] = Convert.ToInt32(this.einLow.Text);
                fp[2][1] = Convert.ToInt32(this.einAvg.Text);
                fp[2][2] = Convert.ToInt32(this.einHigh.Text);

                fp[3][0] = Convert.ToInt32(this.elfLow.Text);
                fp[3][1] = Convert.ToInt32(this.elfAvg.Text);
                fp[3][2] = Convert.ToInt32(this.elfHigh.Text);

                fp[4][0] = Convert.ToInt32(this.eifLow.Text);
                fp[4][1] = Convert.ToInt32(this.eifAvg.Text);
                fp[4][2] = Convert.ToInt32(this.eifHigh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                     "Something went wrong",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }

            int index = 0;
            foreach (ComboBox a in this.comboBoxGroup.Controls.OfType<ComboBox>())
            {
                caf[index] = a.SelectedIndex;
                index++;
            }

            double result = 0;
            try
            {
                result = FunctionPoint.Calculate(fp, caf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                     "Something went wrong",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }

            this.functionPointResult.Text = "Funtion Points: " + (double)((int)(result * 100)) / 100;
        }

        private void eifAvg_TextChanged(object sender, EventArgs e)
        {
            if (this.eiLow.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eiAvg.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eiHigh.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }

            if (this.eoLow.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eoAvg.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eoHigh.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }

            if (this.einLow.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.einAvg.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.einHigh.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }

            if (this.elfLow.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.elfAvg.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.elfHigh.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }

            if (this.eifLow.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eifAvg.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }
            if (this.eifHigh.Text.Equals(string.Empty))
            {
                this.buttonCalculate.Enabled = false;
                return;
            }

            this.buttonCalculate.Enabled = true;
        }
    }
}
