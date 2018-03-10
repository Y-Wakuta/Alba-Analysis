using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using AlbaAnalysis.Entity;

namespace AlbaAnalysis {
    public partial class Detail : Form {
        public Detail(double x,double y) {
            InitializeComponent();
            var binder = new { x, y };
            textBoxXValue.DataBindings.Add("Text", binder, "x");
            textBoxYValue.DataBindings.Add("Text", binder, "y", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
