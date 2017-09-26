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
using ZedGraph;

using AlbaAnalysis.Database;
using AlbaAnalysis.Entity;
using AlbaAnalysis.Routine;


namespace AlbaAnalysis {
    public partial class AlbaChart : ZedGraphControl {

        public string _dataPropertyName = string.Empty;
        public SerialEntity se = new SerialEntity();
        static public FieldInfo f;
        GraphPane graphPane;
        PointPairList list1;

        public AlbaChart() {
            InitializeComponent();
            graphPane = GraphPane;
            list1 = new PointPairList();
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
            list1.Add(x, y);
            var lineItem = graphPane.AddBar("name", list1, Color.Red);
            graphPane.XAxis.Max = x;
        }

        private void AlbaChart_Layout(object sender, LayoutEventArgs e) {
            //this.ChartAreas[0].AxisX.Minimum = 0;
            //this.ChartAreas[0].AxisY.Minimum = 0;
            //this.ChartAreas[0].AxisX.Maximum = 0.1;
            //Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
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
            if (SerialRoutine.GetName(() => se.Cadence) == propName)
                return true;
            else if (SerialRoutine.GetName(() => se.AirSpeed) == propName)
                return true;
            else if (SerialRoutine.GetName(() => se.MpuRoll) == propName)
                return true;
            else if (SerialRoutine.GetName(() => se.MpuYaw) == propName)
                return true;
            else if (SerialRoutine.GetName(() => se.MpuPitch) == propName)
                return true;
            else return false;
        }

        private void setYValue(string propName, SerialEntity se, string ystr) {
            if (SerialRoutine.GetName(() => se.Cadence) == propName)
                se.Cadence = ystr;
            else if (SerialRoutine.GetName(() => se.AirSpeed) == propName)
                se.AirSpeed = ystr;
            else if (SerialRoutine.GetName(() => se.MpuRoll) == propName)
                se.MpuRoll = ystr;
            else if (SerialRoutine.GetName(() => se.MpuYaw) == propName)
                se.MpuYaw = ystr;
            else if (SerialRoutine.GetName(() => se.MpuPitch) == propName)
                se.MpuPitch = ystr;
        }
    }
}