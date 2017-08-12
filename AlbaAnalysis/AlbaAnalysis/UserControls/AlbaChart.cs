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


namespace AlbaAnalysis {
    public partial class AlbaChart : Chart {
        public AlbaChart() {
            InitializeComponent();
        }

        public void AddXY(string xStr, string yStr) {
            double x, y;
            x = y = 0;
            try {
                x = double.Parse(xStr);
                y = double.Parse(yStr);
            }
            catch (Exception exc) { }
            this.Series[0].Points.AddXY(x, y);
            this.ChartAreas[0].AxisX.Maximum = x;
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }

        private void AlbaChart_Layout(object sender, LayoutEventArgs e) {
            this.ChartAreas[0].AxisX.Minimum = 0;
            this.ChartAreas[0].AxisY.Minimum = 0;
            this.ChartAreas[0].AxisX.Maximum = 0.1;
            Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }
    }
}
