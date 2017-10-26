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
        BindingSource _abd;

        public ConfigDialogDataHandler(BindingSource abd) {
            _abd = abd;
            _configBl = new BindingList<ConfigEntity>(ConfigRoutine.GetConfigs());
            _abd.DataSource = _configBl;

            _configBl.ListChanged += (s, e) => Validate();
        }

        public void ResetBinding() {
            _configBl = new BindingList<ConfigEntity>(ConfigRoutine.GetConfigs());
            _abd.DataSource = _configBl;
        }

        #region DB
  

        public void Update() {
            ConfigRoutine.ClearDB();
            ConfigRoutine.Insert2DB(_configBl.ToList());
        }
        #endregion

        /// <summary>
        /// datagridviewで変更を加えた後にidに重複があった場合のvalidateを行います
        /// </summary>
        /// <returns></returns>
        public void Validate() {
            if (_configBl.GroupBy(c => c.ordering).Any(g => g.Count() > 1))
                return;
        }
    }
}
