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

namespace Software_Project_Management
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CocomoPanel : UserControl
    {
        int cocomoModel = 0;
        int cocomoMode = 0;

        public CocomoPanel()
        {
            InitializeComponent();
        }

        private void CocomoPanel_Load(object sender, System.EventArgs e)
        {
            this.cocomoModelSelect.SelectedIndex = 0;
            this.cocomoModeSelect.SelectedIndex = 0;
        }

        private void modelSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cocomoModel = cocomoModelSelect.SelectedIndex;
        }

        private void cocomoModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cocomoMode = cocomoModeSelect.SelectedIndex;
        }

        private void cocomoLOC_TextChanged(object sender, EventArgs e)
        {
            if (this.cocomoLOC.Text != null && !this.cocomoLOC.Text.Equals(""))
            {
                try
                {
                    double d = Convert.ToDouble(this.cocomoLOC.Text);
                    this.cocomoButtonCal.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Number Format Exception.",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    return;
                }
            }
        }

        private void cocomoLOC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonCocomoCal_Click(object sender, EventArgs e)
        {
            if (this.cocomoModel == 0)
            {
                try
                {
                    double loc = Convert.ToDouble(this.cocomoLOC.Text);
                    cocomo.ResultSet rs = Cocomo.Calculate((float)loc, this.cocomoMode);
                    //(double)((int)(objpoints * 100)) / 100
                    this.cocomoResultAvgStaffSize.Text = ((double)((int)(rs.AverageStaffSize * 100)) / 100).ToString() + " Persons";
                    this.cocomoResultDuration.Text = ((double)((int)(rs.Duration * 100)) / 100).ToString() + " Months";
                    this.cocomoResultEffort.Text = ((double)((int)(rs.Effort * 100)) / 100).ToString() + " Person-Month";
                    this.cocomoResultProductivity.Text = ((double)((int)(rs.Productivity * 100)) / 100).ToString() + " Kloc/Month";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
            else if (this.cocomoModel == 1)
            {
                MessageBox.Show("Not Implmented.",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            else if (this.cocomoModel == 2)
            {
                MessageBox.Show("Not Implmented.",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                MessageBox.Show("Unknown Error. Please retry or contact the developer.",
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }
    }
}