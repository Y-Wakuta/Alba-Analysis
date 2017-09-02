using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace AlbaAnalysis.Database {
    public class ConfigRoutine {

        Context context = new Context();

        public List<ConfigEntity> GetConfigs() {
            using (var c = new Context())
                return c.config.ToList();
        }

        public void ClearDB() {
            using (var c = new Context()) {
                var allConfig = c.config.ToList();
                c.config.RemoveRange(allConfig);
                c.SaveChanges();
            }
        }

        public void Insert2DB(List<ConfigEntity> ce) {
            using (var c = new Context()) {
                c.config.AddRange(ce);
                c.SaveChanges();
            }
        }

        /// <summary>
        /// 名前から表示用の名前を取得します
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetDispNameByName(string name) {
            return GetConfigs().First(c => c.name == name).disp_name;
        }
    }
}
