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
    public partial class LinesOfCodePanel : UserControl
    {
        public LinesOfCodePanel()
        {
            InitializeComponent();
        }

        private void locButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fc = new OpenFileDialog();
            fc.Filter = "Source files | *.c; *.C; *.cpp; *.CPP; *.java; *.JAVA; *.php; *.PHP;";
            DialogResult result = fc.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    this.locFilePath.Text = fc.FileName;
                    this.locButtonCal.Enabled = true;
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

        private void locButtonCal_Click(object sender, EventArgs e)
        {
            if (!this.locFilePath.Text.Equals("") && this.locFilePath.Text != null)
            {
                try
                {
                    long loc = LinesOfCode.GetLinesOfCode(this.locFilePath.Text);
                    this.locResult.Text = loc.ToString();
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
