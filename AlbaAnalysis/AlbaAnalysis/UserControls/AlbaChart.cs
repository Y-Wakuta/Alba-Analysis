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

using AlbaAnalysis.Database;
using AlbaAnalysis.Entity;


namespace AlbaAnalysis {
    public partial class AlbaChart : Chart {

        public string _dataPropertyName = string.Empty;
        public SerialEntity se = new SerialEntity();
        public FieldInfo f;

        public AlbaChart() {
            InitializeComponent();
            this.Click += new System.EventHandler(this.AlbaChart_Click);
        }

        public void SetDataPropertyName(string dpn) {
            _dataPropertyName = dpn;
        }

        public void AddXY(string xStr, string yStr) {
            double x, y;
            x = y = 0;
            try {
                x = double.Parse(xStr);
                y = double.Parse(yStr);
                se.Time = xStr;
                FieldInfo f = Extension.GetFieldMemByName(_dataPropertyName);
                f.SetValue(se, yStr);
            } catch (Exception exc) { }
            this.Series[0].Points.AddXY(x, y);
            this.ChartAreas[0].AxisX.Maximum = x;
        }

        private void AlbaChart_Layout(object sender, LayoutEventArgs e) {
            this.ChartAreas[0].AxisX.Minimum = 0;
            this.ChartAreas[0].AxisY.Minimum = 0;
            this.ChartAreas[0].AxisX.Maximum = 0.1;
            Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void AlbaChart_Click(object sender, EventArgs e) {
            using (var details = new Detail(_dataPropertyName, ref se)) {
                details.ShowDialog();
            }
        }
    }
}