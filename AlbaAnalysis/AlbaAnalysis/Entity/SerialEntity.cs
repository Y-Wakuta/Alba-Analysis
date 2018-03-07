using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using AlbaAnalysis.Routine;

namespace AlbaAnalysis.Entity
{
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


        public int HeightTime { get; set; }
        public int Height { get; set; }

    }

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


        public int GpsTime { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }

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

    public class ForthEntity : BaseEntity
    {
        public double ControlTime { get; set; }

        public double MpuXYaw { get; set; }
        public double MpuYRoll { get; set; }


        public double VoltageR { get; set; }

        public double VoltageL { get; set; }
    }

    public abstract class BaseEntity : INotifyPropertyChanged
    {
        public double StartUnixTime {
            get { return _start_unix_time; }
            set {
                _start_unix_time = value;
                onPropertyChanged(nameof(StartUnixTime));
            }
        }
        private double _start_unix_time;

        public T Clone<T>() {
            return (T)MemberwiseClone();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    /// <summary>
    /// ここに新しい要素を追加するときは、database.sqlにも項目を追加してください
    /// </summary>

    #region 設定用クラス
    /// <summary>
    /// マクロを定義
    /// </summary>
    public static class Constants
    {
        public const double filterLevel = 8.0;
        public static int First = Enum.GetNames(typeof(FirstDataOrder)).Length;
        public static int Second = Enum.GetNames(typeof(SecondDataOrder)).Length;
        public static int Third = Enum.GetNames(typeof(ThirdDataOrder)).Length;
        public static int Forth = Enum.GetNames(typeof(ForthDataOrder)).Length;
    }

    public class portNames
    {
        public double portName { get; set; }
    }
    /// <summary>
    /// データを保存したパスを保持
    /// </summary>
    public class filePath
    {
        public double pathName { get; set; }
    }

    public class DetailEntity
    {
        public double value { get; set; }
        public double time { get; set; }
    }
    #endregion
}
