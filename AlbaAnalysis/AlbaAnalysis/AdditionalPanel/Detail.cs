using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbaAnalysis {
    public partial class Detail : Form {
        public Detail(Entity.DetailEntity ca) {
            InitializeComponent();

            //this.timebindingsource.datasource = new entity.time();
            //this.cadencebindingsource.datasource = new entity.cadence();
        }
    }
}
