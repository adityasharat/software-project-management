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
    public partial class PutnamPanel : UserControl
    {
        Putnam putnam;

        public PutnamPanel()
        {
            InitializeComponent();
        }

        private void putnamButtonCal_Click(object sender, EventArgs e)
        {
            float ti, ef;

            try
            {
                ef = (float)Convert.ToDouble(this.effort.Text);
                ti = (float)Convert.ToDouble(this.time.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            putnam = new Putnam();

            putnam.TotalDuration = ti;
            putnam.TotalEffort = ef;

            this.resultDM.Text = Math.Round(putnam.DifficultyMetric, 2).ToString();
            this.resultMPB.Text = Math.Round(putnam.ManPowerBuildup, 2).ToString();
            this.resultPM.Text = Math.Round(putnam.PeakManning, 2).ToString();

            this.putnamButtonViz.Enabled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!this.effort.Text.Equals(string.Empty) && !this.time.Text.Equals(string.Empty))
                this.putnamButtonCal.Enabled = true;
            else
                this.putnamButtonCal.Enabled = false;
        }

        private void manPower_TextChanged(object sender, EventArgs e)
        {
            if (!this.manPower.Text.Equals(string.Empty))
                this.putnamButtonCalManPow.Enabled = true;
            else
                this.putnamButtonCalManPow.Enabled = false; ;
        }

        private void putnamButtonCalManPow_Click(object sender, EventArgs e)
        {
            float ti;

            try
            {
                ti = (float)Convert.ToDouble(this.manPower.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            double result;
            try
            {
                result = Math.Round(putnam.manpowerAt(ti), 2);
            }
            catch (ArgumentException ex)
            {
                 MessageBox.Show(ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.resultMPA.Text = result.ToString();
        }

        private void putnamButtonViz_Click(object sender, EventArgs e)
        {
            double a = 0.5 * Math.Pow(putnam.TotalDuration, -2);

            string name = "Man Power Allocation";
            float xMin = 0f;
            float xMax = putnam.TotalDuration + 20;
            float yMin = -1;
            float yMax = (float)(putnam.PeakManning + 10);

            GraphLib.DataSource ds = new GraphLib.DataSource();
            ds.Name = name;
            ds.Length = ((int)xMax - (int)xMin);
            ds.AutoScaleY = false;
            ds.SetDisplayRangeY(yMin, yMax);
            ds.SetGridDistanceY((int)putnam.PeakManning / 5);

            for (int i = 0; i < ds.Length; i++)
            {
                ds.Samples[i].x = i;
                //ds.Samples[i].y = 3;
                ds.Samples[i].y = (float)(2 * putnam.TotalEffort * a
                    * i
                    * Math.Exp(-a * Math.Pow(i, 2)));
            }

            GraphViewer gv = new GraphViewer(ds);
            gv.ShowDialog();
        }
    }
}
