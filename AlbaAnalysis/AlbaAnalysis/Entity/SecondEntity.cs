using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public class SecondEntity : BaseEntity
    {

        [Display(Order = 0)]
        public double MpuTime {
            get { return _mpu_time; }
            set {
                _mpu_time = value;
                onPropertyChanged(nameof(MpuTime));
            }
        }
        private double _mpu_time;

        [Display(Order = 1)]
        public double MpuRoll {
            get { return _mpuRoll; }
            set {
                _mpuRoll = value;
                onPropertyChanged(nameof(MpuRoll));
            }
        }
        private double _mpuRoll;

        [Display(Order = 2)]
        public double MpuPitch {
            get { return _mpuPitch; }
            set {
                _mpuPitch = value;
                onPropertyChanged(nameof(MpuPitch));
            }
        }
        public double _mpuPitch;

        [Display(Order = 3)]
        public double MpuYaw {
            get { return _mpuYaw; }
            set {
                _mpuYaw = value;
                onPropertyChanged(nameof(MpuYaw));
            }
        }
        public double _mpuYaw;

        [Display(Order = 4)]
        public double GpsTime { get; set; }

        [Display(Order = 5)]
        public double Latitude { get; set; }

        [Display(Order = 6)]
        public double Longitude { get; set; }
    }
}
