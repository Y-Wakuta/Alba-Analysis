using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public class ThirdEntity : BaseEntity
    {
        public double ControlTime { get; set; }
        public double RollInput { get; set; }
        public double DrugR { get; set; }
        public double PitchInput { get; set; }
        public double DrugL { get; set; }
        public double MpuRYaw { get; set; }
        public double MpuRRoll { get; set; }
    }
}
