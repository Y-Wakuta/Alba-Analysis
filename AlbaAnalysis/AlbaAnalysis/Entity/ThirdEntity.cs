using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public class ThirdEntity : BaseEntity
    {

        [Display(Order = 0)]
        public double ControlTime { get; set; }

        [Display(Order = 1)]
        public double RollInput { get; set; }

        [Display(Order = 2)]
        public double DrugR { get; set; }

        [Display(Order = 3)]
        public double PitchInput { get; set; }

        [Display(Order = 4)]
        public double DrugL { get; set; }

        [Display(Order = 5)]
        public double MpuRYaw { get; set; }

        [Display(Order = 6)]
        public double MpuRRoll { get; set; }
    }
}
