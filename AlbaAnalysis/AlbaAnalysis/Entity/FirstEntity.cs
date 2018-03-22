using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    [DisplayName(Constants.firstFlag)]
    public class FirstEntity : BaseEntity {
        [Display(Order = 0)]
        public double AirSpeedTime {
            get { return _airSpeed_time; }
            set {
                _airSpeed_time = value;
                onPropertyChanged(nameof(AirSpeedTime));
            }
        }
        public double _airSpeed_time;

        [Display(Order = 1)]
        public double AirSpeed {
            get { return _airSpeed; }
            set {
                _airSpeed = value;
                onPropertyChanged(nameof(AirSpeed));
            }
        }
        public double _airSpeed;

        [Display(Order = 2)]
        public double CadenceTime {
            get { return _cadence_time; }
            set {
                _cadence_time = value;
                onPropertyChanged(nameof(CadenceTime));
            }
        }
        public double _cadence_time;

        [Display(Order = 3)]
        public double Cadence {
            get { return _cadence; }
            set {
                _cadence = value;
                onPropertyChanged(nameof(Cadence));
            }
        }
        public double _cadence;

        [Display(Order = 4)]
        public double HeightTime { get; set; }

        [Display(Order = 5)]
        public double Height { get; set; }
    }
}
