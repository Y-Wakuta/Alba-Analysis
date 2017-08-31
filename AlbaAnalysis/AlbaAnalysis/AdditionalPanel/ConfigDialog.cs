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
using AlbaAnalysis.AdditionalPanel;
using AlbaAnalysis.Database;

namespace AlbaAnalysis {
    public partial class ConfigDialog : Form {

        ConfigDialogDataHandler _cddh;
        Context context = new Context();

        public ConfigDialog() {
            InitializeComponent();
            _cddh = new ConfigDialogDataHandler(displayOrderAttributeBindingSource);
            try {
                var result = context.config.ToList();
            }catch(Exception e) {
            var str = System.IO.Directory.GetCurrentDirectory();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
