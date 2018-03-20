using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    [DisplayName("$1データ")]
    public class FirstEntity : BaseEntity
    {
        public double AirSpeedTime {
            get { return _airSpeed_time; }
            set {
                _airSpeed_time = value;
                onPropertyChanged(nameof(AirSpeedTime));
            }
        }
        public double _airSpeed_time;

        public double AirSpeed {
            get { return _airSpeed; }
            set {
                _airSpeed = value;
                onPropertyChanged(nameof(AirSpeed));
            }
        }
        public double _airSpeed;

        public double CadenceTime {
            get { return _cadence_time; }
            set {
                _cadence_time = value;
                onPropertyChanged(nameof(CadenceTime));
            }
        }
        public double _cadence_time;

        public double Cadence {
            get { return _cadence; }
            set {
                _cadence = value;
                onPropertyChanged(nameof(Cadence));
            }
        }
        public double _cadence;

        public double HeightTime { get; set; }
        public double Height { get; set; }
    }
}
