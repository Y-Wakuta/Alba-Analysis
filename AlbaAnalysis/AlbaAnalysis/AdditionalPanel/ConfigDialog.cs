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

        private void buttonReset_Click(object sender, EventArgs e) {
            if (DialogResult.Cancel == MessageBox.Show("設定をリセットしますか？", "データベースリセット", MessageBoxButtons.OKCancel))
                return;

            ConfigRoutine.ClearDB();
           ConfigRoutine.ResetDB();
            _cddh.ResetBinding();
        }

        private void buttonAdapt_Click_1(object sender, EventArgs e) {
            _cddh.Update();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
