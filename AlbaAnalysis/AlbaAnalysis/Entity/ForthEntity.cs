using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using AlbaAnalysis.Routine;

namespace AlbaAnalysis.Entity
{
    public class ForthEntity : BaseEntity
    {
        public double ControlTime { get; set; }

        public double MpuLYaw { get; set; }
        public double MpuLRoll { get; set; }


        public double VoltageR { get; set; }

        public double VoltageL { get; set; }
    }
  
  }
