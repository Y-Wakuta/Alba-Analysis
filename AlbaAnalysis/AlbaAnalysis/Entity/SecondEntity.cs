using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public class SecondEntity : BaseEntity
    {
        public double MpuTime {
            get { return _mpu_time; }
            set {
                _mpu_time = value;
                onPropertyChanged(nameof(MpuTime));
            }
        }
        private double _mpu_time;

        public double MpuRoll {
            get { return _mpuRoll; }
            set {
                _mpuRoll = value;
                onPropertyChanged(nameof(MpuRoll));
            }
        }
        private double _mpuRoll;

        public double MpuPitch {
            get { return _mpuPitch; }
            set {
                _mpuPitch = value;
                onPropertyChanged(nameof(MpuPitch));
            }
        }
        public double _mpuPitch;

        public double MpuYaw {
            get { return _mpuYaw; }
            set {
                _mpuYaw = value;
                onPropertyChanged(nameof(MpuYaw));
            }
        }
        public double _mpuYaw;


        public double GpsTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
