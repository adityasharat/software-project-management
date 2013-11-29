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
    public partial class HalsteadPanel : UserControl
    {
        public HalsteadPanel()
        {
            InitializeComponent();
        }

        private void halsteadButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fc = new OpenFileDialog();
            fc.Filter = "Source files | *.c; *.C; *.cpp; *.CPP; *.java; *.JAVA; *.php; *.PHP;";
            DialogResult result = fc.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    this.halsteadFilePath.Text = fc.FileName;
                    this.halsteadButtonCal.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(),
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void halsteadButtonCal_Click(object sender, EventArgs e)
        {
            if (!this.halsteadFilePath.Text.Equals("") && this.halsteadFilePath.Text != null)
            {
                try
                {
                    Halstead.ResultSet rs = Halstead.calculate(this.halsteadFilePath.Text);

                    n1.Text = "The number of distinct operators : " + rs.n1.ToString();
                    n2.Text = "The number of distinct operands : " + rs.n2.ToString();
                    _N1.Text = "The total number of operators : " + rs.N1.ToString();
                    _N2.Text = "The total number of operands : " + rs.N2.ToString();
                    n.Text = "Program vocabulary : " + rs.n.ToString();
                    _N.Text = "Program length : " + rs.N.ToString();

                    _V.Text = "Volume : " + Math.Round(rs.V, 2).ToString();
                    _Vs.Text = "Potential volume : " + Math.Round(rs.Vs, 2).ToString();
                    _L.Text = "Program Level : " + Math.Round(rs.L, 2).ToString();
                    _D.Text = "Program Difficulty : " + Math.Round(rs.D, 2).ToString();
                    _E.Text = "Effort : " + Math.Round(rs.E, 2).ToString() + " Person-Months";
                    _Ns.Text = "Calculated program length : " + Math.Round(rs.Ns, 2).ToString();
                    _Ls.Text = "Estimated Program Level : " + Math.Round(rs.Ls, 2).ToString();
                    _Ds.Text = "Estimated Program Difficulty : " + Math.Round(rs.Ds, 2).ToString();
                    _Es.Text = "Estimated Effort : " + Math.Round(rs.Es, 2).ToString() + " Person-Months";

                    double time = Math.Round(rs.T, 2);

                    if (time < 60)
                        _T.Text = "Time required to program : " + time + " seconds";
                    else if (time > 60 && time < 3600)
                    {
                        int min = (int)time / 60;
                        int s = (int)time % 60;
                        _T.Text = "Time required to program : " + min + " minutes " + s + " seconds";
                    }
                    else if (time >= 3600 && time < 86400)
                    {
                        int hour = (int)time / 3600;
                        int min = (int)(time % 3600) / 60;
                        _T.Text = "Time required to program : " + hour + " hours " + min + " minutes";
                    }
                    else if (time >= 86400)
                    {
                        int day = (int)time / 86400;
                        int hour = (int)(time % 86400) / 3600;
                        int min = (int)((time % 86400) % 3600) / 60;
                        _T.Text = "Time required to program : " + day + " days " + hour + " hours " + min + " minutes";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(),
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
