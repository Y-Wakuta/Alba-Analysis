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

namespace AlbaAnalysis
{
    public partial class XChart : UserControl
    {
        public XChart()
        {
            InitializeComponent();

            this.chart.Series[0].BorderWidth = 3;
        }

        public void SetProperties(string Name)
        {
            this.chart.Series[0].Name = Name;
            this.chart.Legends[0].Name = Name;

        }

        private struct source { public double X; public double Y; }
        source s = new source();

        //ここでコンストラクタを宣言すると動かなくなる。


        public void AddXY(double x, double y)
        {
            try
            {
                this.chart.Series[0].Points.AddXY(x, y);
                //if (this.ChartAreas[0].AxisX.Maximum < x * 1.1)
                //           this.ChartAreas[0].AxisX.Maximum = x; //個々の上限は適当
               
                s = new source() { X = x, Y = y };
            }
            catch (Exception)
            {
                Debug.Assert(false);
            }
        }
    }
}
