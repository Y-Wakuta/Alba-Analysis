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

namespace AlbaAnalysis {
    public partial class AlbaChart : Chart {

        private bool _isClickable = false;
        private struct source { public double X; public double Y; }
        source s = new source();

        public AlbaChart(bool isClickable) {
            InitializeComponent();
            this.Click += new System.EventHandler(this.AlbaChart_Click);
            _isClickable = isClickable;
        }

        public void SetDataPropertyName(string dpn) {
            setFilterLevel();
        }

        private void setFilterLevel() {
        }

        public void AddXY(double x, double y) {
            try {
                this.Series[0].Points.AddXY(x, y);
                this.ChartAreas[0].AxisX.Maximum = x * 1.1; //個々の上限は適当
                s = new source() { X = x, Y = y };
            } catch (Exception) {
                Debug.Assert(false);
            }
        }

        private void AlbaChart_Layout(object sender, LayoutEventArgs e) {
            this.ChartAreas[0].AxisX.Minimum = 0;
            this.ChartAreas[0].AxisY.Minimum = 0;
            this.ChartAreas[0].AxisX.Maximum = 0.1;
            Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void AlbaChart_Click(object sender, EventArgs e) {
            if (!_isClickable) {
                MessageBox.Show("このグラフは詳細表示できません。");
                return;
            }

            using (var details = new Detail(s.X, s.Y)) {
                details.ShowDialog();
            }
        }

        private static bool filterDatas(List<DataSet> list, int fl = 1) { //listの要素数は3とする
                                                                          //var filter_level = ConfigRoutine.GetFilterByName(_dataPropertyName);
            if (fl == 0)
                return true;    //filter_levelのデフォルト値は0であるため、その0では無条件に値を通過させる
            var base_diff = (list[1].Y - list[0].Y) / (list[1].X - list[0].X);
            var target_diff = (list[2].Y - list[1].Y) / (list[2].X - list[1].X);
            if (target_diff < base_diff * fl)
                return true;
            else return false;


        }
    }

    public class DataSet {
        public double X;
        public double Y;
    }


}