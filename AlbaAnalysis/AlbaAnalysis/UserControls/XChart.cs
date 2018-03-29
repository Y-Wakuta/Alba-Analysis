using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AlbaAnalysis.Entity;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlbaAnalysis
{
    public partial class XChart : UserControl
    {
        string _name = string.Empty;

        public XChart()
        {
            InitializeComponent();

            this.chart.Series[0].BorderWidth = 3;
        }

        public void SetProperties(string name)
        {
            this.chart.Series[0].Name = name;
            this.chart.Legends[0].Name = name;

            _name = name;
        }

        Source s = new Source();

        //ここでコンストラクタを宣言すると動かなくなる。


        public void AddXY(double x, double y)
        {
            try
            {
                this.chart.Series[0].Points.AddXY(x, y);
                s = new Source() { X = x, Y = y };
            }
            catch (Exception)
            {
                Debug.Assert(false);
            }
        }

        public void Clear()
        {
            this.chart.Series[0].Points.Clear();
        }

        public void SaveImage(string path)
        {
            this.chart.SaveImage(path, ChartImageFormat.Jpeg);
        }

        private void chart_Click(object sender, EventArgs e)
        {
            using (var details = new Detail(ref s))
            {
                details.ShowDialog();
            }
        }
    }
}
