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
    public partial class CyclomaticComplexityPanel : UserControl
    {
        public CyclomaticComplexityPanel()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fc = new OpenFileDialog();
            fc.Filter = "Source files | *.c; *.C; *.cpp; *.CPP; *.java; *.JAVA; *.php; *.PHP;";
            DialogResult result = fc.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                this.cycloFilePath.Text = fc.FileName;

                try
                {
                    string content = System.IO.File.ReadAllText(fc.FileName);
                    this.cycloTextArea.Text = content;
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been Implemented", "Informatinon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cycloCal_Click(object sender, EventArgs e)
        {
            if (!this.cycloTextArea.Text.Trim().Equals(""))
            {
                long val = CylomaticComplexity.Compute(cycloTextArea.Text);
                this.cyloInfo.Visible = true;
                this.cycloResult.Visible = true;
                this.cycloResult.Text = val.ToString();
            }
            else
            {
                cycloResult.Text = "1";
            }
        }

        private void cycloTextArea_TextChanged(object sender, EventArgs e)
        {
            if (!cycloTextArea.Text.Trim().Equals(""))
            {
                this.cycloButtonCal.Enabled = true;
            }
            else
            {
                this.cycloButtonCal.Enabled = false;
                this.cyloInfo.Visible = false;
                this.cycloResult.Visible = false;
            }
        }
    }
}
