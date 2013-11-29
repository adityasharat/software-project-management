using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLib;
namespace Spm_core
{
    public partial class GraphViewer : Form
    {
        public GraphViewer(GraphLib.DataSource ds)
        {
            InitializeComponent();
            InitializeGraph();
            CalcDataGraphs(ds);
        }

        public void CalcDataGraphs(GraphLib.DataSource ds)
        {
            this.SuspendLayout();
            this.display.SetDisplayRangeX(-0.5f, ds.Length + 5);
            this.display.DataSources.Add(new DataSource());
            this.display.PanelLayout = PlotterGraphPaneEx.LayoutMode.NORMAL;

            this.display.DataSources[0] = ds;
            this.display.DataSources[0].OnRenderXAxisLabel += RenderXLabel;
            this.display.DataSources[0].OnRenderYAxisLabel = RenderYLabel;

            this.ApplyColorSchema();

            this.ResumeLayout();
            this.display.Refresh();
        }

        private void ApplyColorSchema()
        {
            display.DataSources[0].GraphColor = Color.Green;
            display.BackgroundColorTop = Color.Black;
            display.BackgroundColorBot = Color.Black;
            display.SolidGridColor = Color.DarkGray;
            display.DashedGridColor = Color.DarkGray;
        }

        private void InitializeGraph()
        {
            this.display = new GraphLib.PlotterDisplayEx();
            this.display.BackColor = System.Drawing.Color.White;
            this.display.BackgroundColorBot = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.display.BackgroundColorTop = System.Drawing.Color.Navy;
            this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display.DashedGridColor = System.Drawing.Color.Blue;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.DoubleBuffering = true;
            this.display.Location = new System.Drawing.Point(0, 24);
            this.display.Name = "display";
            this.display.PlaySpeed = 0.5F;
            this.display.Size = new System.Drawing.Size(620, 472);
            this.display.SolidGridColor = System.Drawing.Color.Blue;
            this.display.TabIndex = 1;
            this.display.DataSources.Clear();
            this.Controls.Add(this.display);
        }

        private String RenderXLabel(DataSource s, int idx)
        {
            if (s.AutoScaleX)
            {
                //if (idx % 2 == 0)
                {
                    int Value = (int)(s.Samples[idx].x);
                    return "" + Value;
                }
                return "";
            }
            else
            {
                int Value = (int)(s.Samples[idx].x / 200);
                String Label = "" + Value + "\"";
                return Label;
            }
        }

        private String RenderYLabel(DataSource s, float value)
        {
            return String.Format("{0:0.0}", value);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            display.Dispose();
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

    }
}
