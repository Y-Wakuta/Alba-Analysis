using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace AlbaAnalysis {
    class VerticalProgressBar : ProgressBar {
        private int PBS_VERTICAL = 0x0004;

        protected override CreateParams CreateParams {
            [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= PBS_VERTICAL;
                return createParams;
            }
        }

        public void SetValue(double input) {
            if (input < 0 || input > 1)
                return;

            input = input * 100.0 + 50.0;
            this.Value = (int)input + 1;  //progressBarは値が下がる時はすぐに変位するので、それを利用して表示
            this.Value = (int)input;
        }
    }
}
