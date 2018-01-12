using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace AlbaAnalysis.Database {
    public static class ConfigRoutine {

        public static List<ConfigEntity> GetConfigs() {
            using (var c = new Context())
                return c.config.ToList();
        }

        public static void ClearDB() {
            using (var c = new Context()) {
                var allConfig = c.config.ToList();
                c.config.RemoveRange(allConfig);
                c.SaveChanges();
            }
        }

        public static void Insert2DB(List<ConfigEntity> ce) {
            using (var c = new Context()) {
                c.config.AddRange(ce);
                c.SaveChanges();
            }
        }
        public static void ResetDB() {
            using (var c = new Context())
            using (var sr = new StreamReader("../../../database.sql")) {
                var sql = sr.ReadToEnd();
                c.Database.ExecuteSqlCommand(sql);
                c.SaveChanges();
            }
        }
        /// <summary>
        /// 名前から表示用の名前を取得します
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetDispNameByName(string name) {
            return GetConfigs().First(c => c.name == name).disp_name;
        }

        public static int GetFilterByName(string name) {
            return GetConfigs().FirstOrDefault(c => c.name == name)?.filter_level ?? 0;
        }
    }
}
