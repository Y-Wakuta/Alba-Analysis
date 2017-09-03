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
using AlbaAnalysis.Routine;


namespace AlbaAnalysis {
    public partial class AlbaChart : Chart {

        public string _dataPropertyName = string.Empty;
        public SerialEntity se = new SerialEntity();
        static public FieldInfo f;

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
                setYValue(_dataPropertyName, se, yStr);
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
            if (!isClickable(_dataPropertyName)) {
                MessageBox.Show("このグラフは詳細表示できません。");
                return;
            }
                
            using (var details = new Detail(_dataPropertyName, ref se)) {
                details.ShowDialog();
            }
        }

        private bool isClickable(string propName) {
            if (nameof(se.Cadence) == propName)
                return true;
            else if (nameof(se.AirSpeed) == propName)
                return true;
            else if (nameof(se.MpuRoll) == propName)
                return true;
            else if (nameof(se.MpuYaw) == propName)
                return true;
            else if (nameof(se.MpuPitch) == propName)
                return true;
            else return false;
        }

        private void setYValue(string propName,SerialEntity se,string ystr) {
            if (nameof(se.Cadence) == propName)
                se.Cadence = ystr;
            else if (nameof(se.AirSpeed) == propName)
                se.AirSpeed = ystr;
            else if (nameof(se.MpuRoll) == propName)
                se.MpuRoll = ystr;
            else if (nameof(se.MpuYaw) == propName)
                se.MpuYaw = ystr;
            else if (nameof(se.MpuPitch) == propName)
                se.MpuPitch = ystr;
        }
    }
}