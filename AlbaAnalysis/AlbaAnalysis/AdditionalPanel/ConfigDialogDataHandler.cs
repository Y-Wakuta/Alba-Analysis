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
        ConfigRoutine configRoutine = new ConfigRoutine();

        public ConfigDialogDataHandler(BindingSource abd) {
            _abd = abd;
            _configBl = new BindingList<ConfigEntity>(configRoutine.GetConfigs());
            _abd.DataSource = _configBl;

            _configBl.ListChanged += (s, e) => Validate();
        }

        #region DB
        public void Reset() {
            _abd.DataSource = new BindingList<ConfigEntity>(configRoutine.GetConfigs());
        }

        public void Update() {
            configRoutine.ClearDB();
            configRoutine.Insert2DB(_configBl.ToList());
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
