using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using AlbaAnalysis.Entity;
using AlbaAnalysis.AdditionalPanel;
using AlbaAnalysis.Database;

namespace AlbaAnalysis {
    public partial class ConfigDialog : Form {

        ConfigDialogDataHandler _cddh;

        public ConfigDialog() {
            InitializeComponent();
            _cddh = new ConfigDialogDataHandler(configEntityBindingSource);

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonAdapt_Click(object sender, EventArgs e) {
            ConfigRoutine.Insert2DB();
        }

        private void button1_Click(object sender, EventArgs e) {
            _cddh.Update();
        }
    }
}
