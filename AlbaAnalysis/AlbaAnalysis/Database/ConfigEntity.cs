using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlbaAnalysis.Database {

    [Table("Config", Schema = "public")]
    public class ConfigEntity {
        [Key]
        public string Key { get; set; }

        public string Data { get; set; }
    }
}
