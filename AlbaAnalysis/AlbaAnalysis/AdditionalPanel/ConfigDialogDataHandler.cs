using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

using AlbaAnalysis.Entity;
using AlbaAnalysis.Database;


namespace AlbaAnalysis.AdditionalPanel {
    public class ConfigDialogDataHandler {

        BindingList<ConfigEntity> _configBl;

        public ConfigDialogDataHandler(BindingSource abd) {
            _configBl = new BindingList<ConfigEntity>(ConfigRoutine.GetConfigs());
            abd.DataSource = _configBl;
        }

        public void Update() {
            ConfigRoutine.ClearDB();
            ConfigRoutine.Insert2DB(_configBl.ToList());
        }

    }
}
