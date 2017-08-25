using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

using AlbaAnalysis.Entity;

namespace AlbaAnalysis {
    public partial class ConfigDialog : Form {

        SerialEntity serial = new SerialEntity();

        public ConfigDialog() {
            InitializeComponent();
            var result = GetNamesOrdered();
        }

        public string[] GetNamesOrdered() {
            var fields = typeof(SerialEntity).GetFields();
            var dispOrderAttribute = Attribute.GetCustomAttributes(typeof(SerialEntity), false) as DisplayOrderAttribute[];
            return dispOrderAttribute.OrderBy(r => r.order).Select(r => r.name).ToArray();
        }
    }
}
