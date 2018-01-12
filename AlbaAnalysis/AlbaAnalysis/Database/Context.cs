using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;

namespace AlbaAnalysis.Database {

    public class Context : DbContext {

        public Context() : base("sqlite") {}

        public DbSet<ConfigEntity> config { get; set; }
    }
}
