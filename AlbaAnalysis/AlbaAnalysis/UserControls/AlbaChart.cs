using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Diagnostics;

namespace AlbaAnalysis
{
    public partial class AlbaChart : Chart
    {

        private bool _isClickable = false;
        private struct source { public double X; public double Y; }
        source s = new source();
        int counter = 0;

        public AlbaChart() { }

        public AlbaChart(bool isClickable)
        {
            InitializeComponent();
     //       this.Click += new System.EventHandler(this.AlbaChart_Click);
      //      _isClickable = isClickable;
        }

        public void AddXY(double x, double y)
        {
            try
            {
                this.Series[0].Points.AddXY(x, y);
                //if (this.ChartAreas[0].AxisX.Maximum < x * 1.1)
         //           this.ChartAreas[0].AxisX.Maximum = x; //個々の上限は適当

            //    s = new source() { X = x, Y = y };
            }
            catch (Exception)
            {
                Debug.Assert(false);
            }
        }

        private void AlbaChart_Layout(object sender, LayoutEventArgs e)
        {
            this.ChartAreas[0].AxisX.Minimum = 0;
            this.ChartAreas[0].AxisY.Minimum = 0;
            this.ChartAreas[0].AxisX.Maximum = 0.1;
         //   Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void AlbaChart_Click(object sender, EventArgs e)
        {
            if (!_isClickable)
            {
                MessageBox.Show("このグラフは詳細表示できません。");
                return;
            }

            using (var details = new Detail(s.X, s.Y))
            {
                details.ShowDialog();
            }
        }
    }
}