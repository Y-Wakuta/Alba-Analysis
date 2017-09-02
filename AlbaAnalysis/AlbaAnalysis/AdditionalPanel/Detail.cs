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
        public string _disp;
        public SerialEntity _se;
        public Detail(string dispName,ref SerialEntity se) {
            InitializeComponent();
            _disp = dispName;
            _se = se;

            textBoxXValue.DataBindings.Add("Text", _se, "Time");
            textBoxYValue.DataBindings.Add("Text", _se, _disp, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}

public static class Extension {
    public static FieldInfo GetFieldMemByName(string name) {
        return typeof(SerialEntity).GetField(name);
    }
}
