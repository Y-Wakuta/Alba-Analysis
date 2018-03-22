using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using AlbaAnalysis.Routine;
using System.ComponentModel.DataAnnotations;

namespace AlbaAnalysis.Entity
{
    [DisplayName(Constants.fourthFlag)]
    public class ForthEntity : BaseEntity
    {

        [Display(Order = 0)]
        public double ControlTime { get; set; }

        [Display(Order = 1)]
        public double MpuLYaw { get; set; }

        [Display(Order = 2)]
        public double MpuLRoll { get; set; }

        [Display(Order = 3)]
        public double VoltageR { get; set; }

        [Display(Order = 4)]
        public double VoltageL { get; set; }
    }

}
