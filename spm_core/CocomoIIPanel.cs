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
    public partial class CocomoIIPanel : UserControl
    {

        public CocomoIIPanel()
        {
            InitializeComponent();
        }

        private void cocomoIIScreenSimple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cocomoIIButtonCal_Click(object sender, EventArgs e)
        {
            int _3gl = 0, reuse = 0;

            int[] s = new int[3];
            int[] r = new int[3];

            try
            {
                s[0] = Convert.ToInt32(this.cocomoIIScreenSimple.Text);
                s[1] = Convert.ToInt32(this.cocomoIIScreenMedium.Text);
                s[2] = Convert.ToInt32(this.cocomoIIScreenDifficult.Text);
                
                r[0] = Convert.ToInt32(this.cocomoIIReportSimple.Text);
                r[1] = Convert.ToInt32(this.cocomoIIReportMedium.Text);
                r[2] = Convert.ToInt32(this.cocomoIIReportDifficult.Text);
                
                _3gl = Convert.ToInt32(this.cocomoII3GL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            reuse = (int)this.cocomoIIReuse.Value;

            double objpoints = 0;

            try
            {
                objpoints = CocomoII.ObjectPoints(s, r, _3gl, reuse);
                objpoints = (double)((int)(objpoints * 100)) / 100;
                this.cocomoIIResult.Text = "Object Points: " + objpoints.ToString();
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

        private void CocomoIIPanel_Load(object sender, EventArgs e)
        { }

        private void cocomoIIReportMedium_TextChanged(object sender, EventArgs e)
        {
            foreach(TextBox t in this.Controls.OfType<TextBox>())
            {
                if (t.Text == null || t.Text.Equals(string.Empty))
                {
                    this.cocomoIIButtonCal.Enabled = false;
                    return;
                }
            }
            this.cocomoIIButtonCal.Enabled = true;
        }
    }
}
