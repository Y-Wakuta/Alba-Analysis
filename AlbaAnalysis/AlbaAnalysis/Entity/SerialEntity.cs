using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    public class SerialEntity {
        public string MpuXR;
        public string MpuYR;
        public string MpuZR;
        public string VoltageR;
        public string MpuXL;
        public string MpuYL;
        public string MpuZL;
        public string VoltageL;
        public string ErebonRInput;
        public string DrugR;
        public string ErebonLInput;
        public string DrugL;
        public string MpuRoll;
        public string MpuPitch;
        public string MpuYaw;
        public string AirSpeed;
        public string Sonar;
        public string Cadence;
        //public const int Latitude = 24;
        //public const int Longitude = 25;
        public string Time;
    }
    /// <summary>
    /// マクロを定義
    /// </summary>
    public class Constants {
        public const double averageLevel = 4.0;
        public const double filterLevel = 8.0;
        public const double batteryVoltageLimit = 200;
    }

    public enum ControlDataOrder {
        MpuXR,
        MpuYR,
        MpuZR,
        VoltageR,
        MpuXL,
        MpuYL,
        MpuZL,
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
