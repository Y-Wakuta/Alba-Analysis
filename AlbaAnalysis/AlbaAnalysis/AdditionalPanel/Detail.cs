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
        public Detail(string dispName,ref SerialEntity se) {
            InitializeComponent();

            textBoxXValue.DataBindings.Add("Text", se, "Time");
            textBoxYValue.DataBindings.Add("Text", se, dispName, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
