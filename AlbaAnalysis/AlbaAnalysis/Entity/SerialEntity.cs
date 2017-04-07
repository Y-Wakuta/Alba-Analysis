using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    public class SerialEntity {

        public SerialEntity Clone() {
            return (SerialEntity)MemberwiseClone();
        }
        public string MpuXR = "0";
        public string MpuYR = "0";
        public string MpuZR = "0";
        public string MpuXR_A = "0";
        public string MpuYR_A = "0";
        public string MpuZR_A = "0";
        public string VoltageR = "0";
        public string MpuXL = "0";
        public string MpuYL = "0";
        public string MpuZL = "0";
        public string MpuXL_A = "0";
        public string MpuYL_A = "0";
        public string MpuZL_A = "0";
        public string VoltageL = "0";
        public string ErebonRInput = "0";
        public string DrugR = "0";
        public string ErebonLInput = "0";
        public string DrugL = "0";
        public string MpuRoll = "0";
        public string MpuPitch = "0";
        public string MpuYaw = "0";
        public string AirSpeed = "0";
        public string Sonar = "0";
        public string Cadence = "0";
        //public const int Latitude = 24;
        //public const int Longitude = 25;
        public string Time = "0";
    }



    /// <summary>
    /// マクロを定義
    /// </summary>
    public class Constants {
        public const double averageLevel = 4.0;
        public const double filterLevel = 8.0;
        public const double batteryVoltageLimit = 200;
        public const int PHASE_NUM = 15;
        public const int NEUTRAL_PHASE = 7;
    }

    public enum ControlDataOrder {
        MpuXR,
        MpuYR,
        MpuZR,
        MpuXR_A,
        MpuYR_A,
        MpuZR_A,
        VoltageR,
        MpuXL,
        MpuYL,
        MpuZL,
        MpuXL_A,
        MpuYL_A,
        MpuZL_A,
        VoltageL,
    }

    public enum InputDataOrder {
        ErebonRInput,
        DrugR,
        ErebonLInput,
        DrugL,
    }

    public enum MpuDataOrder {
        MpuRoll,
        MpuPitch,
        MpuYaw,
    }

    public enum KeikiDataOrder {
        AirSpeed,
        Sonar,
        Cadence,
    }

    /// <summary>
    /// コンボボックスでアイテムとして使用するためのメンバを作成
    /// </summary>
    public class bauditems {
        public string NAME { get; set; }

        public int RATE { get; set; }
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

    public class CadenceView {
        public string cadence { get; set; }
        public string time { get; set; }
    }
}
