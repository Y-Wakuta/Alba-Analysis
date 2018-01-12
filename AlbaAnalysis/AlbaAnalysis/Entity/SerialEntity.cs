using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using AlbaAnalysis.Routine;

namespace AlbaAnalysis.Entity {
    /// <summary>
    /// ここに新しい要素を追加するときは、database.sqlにも項目を追加してください
    /// </summary>
    public class SerialEntity : INotifyPropertyChanged {

        public SerialEntity Clone() {
            return (SerialEntity)MemberwiseClone();
        }

        #region column
        public string MpuXR { get; set; } = "0";

        public string MpuYR { get; set; } = "0";

        public string MpuZR { get; set; } = "0";

        public string MpuXR_A { get; set; } = "0";

        public string MpuYR_A { get; set; } = "0";

        public string MpuZR_A { get; set; } = "0";

        public string VoltageR { get; set; } = "0";

        public string MpuXL { get; set; } = "0";

        public string MpuYL { get; set; } = "0";

        public string MpuZL { get; set; } = "0";

        public string MpuXL_A { get; set; } = "0";

        public string MpuYL_A { get; set; } = "0";

        public string MpuZL_A { get; set; } = "0";

        public string VoltageL { get; set; } = "0";

        public string ErebonRInput { get; set; } = "0";

        public string DrugR { get; set; } = "0";

        public string ErebonLInput { get; set; } = "0";

        public string DrugL{ get; set; } = "0";

        public string MpuRoll {
            get { return _mpuRoll; }
            set {
                _mpuRoll = value;
                onPropertyChanged(nameof(MpuRoll));
            }
        }
        private string _mpuRoll = "0";

        public string MpuPitch {
            get { return _mpuPitch; }
            set {
                _mpuPitch = value;
                onPropertyChanged(nameof(MpuPitch));
            }
        }
        public string _mpuPitch = "0";

        public string MpuYaw {
            get { return _mpuYaw; }
            set {
                _mpuYaw = value;
                onPropertyChanged(nameof(MpuYaw));
            }
        }
        public string _mpuYaw = "0";

        public string AirSpeed {
            get { return _airSpeed; }
            set {
                _airSpeed = value;
                onPropertyChanged(nameof(AirSpeed));
            }
        }
        public string _airSpeed = "0";

        public string Sonar { get; set; } = "0";

        public string Cadence {
            get { return _cadence; }
            set {
                _cadence = value;
                onPropertyChanged(nameof(Cadence));
            }
        }
        public string _cadence = "0";
        //public const int Latitude = 24;
        //public const int Longitude = 25;

        public string Time {
            get { return _time; }
            set {
                _time = value;
                onPropertyChanged(nameof(Time));
            }
        }
        private string _time = "0";

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }

    #region 設定用クラス
    /// <summary>
    /// マクロを定義
    /// </summary>
    public static class Constants {
        public const double filterLevel = 8.0;
        public static int controlDataNum = Enum.GetNames(typeof(ControlDataOrder)).Length;
        public static int InputDataNum = Enum.GetNames(typeof(InputDataOrder)).Length;
        public static int MpuDataNum = Enum.GetNames(typeof(MpuDataOrder)).Length;
        public static int KeikiDataNum = Enum.GetNames(typeof(KeikiDataOrder)).Length;
    }

    public class portNames {
        public string portName { get; set; }
    }
    /// <summary>
    /// データを保存したパスを保持
    /// </summary>
    public class filePath {
        public string pathName { get; set; }
    }

    public class DetailEntity {
        public string value { get; set; }
        public string time { get; set; }
    }
    #endregion
}
