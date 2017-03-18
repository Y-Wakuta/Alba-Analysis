using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    public class SerialEntity {
    }
    /// <summary>
    /// マクロを定義
    /// </summary>
    public class Constants {
        public const int dataMembers = 26;
        public const double averageLevel = 4.0;
        public const double filterLevel = 8.0;
        public const double batteryVoltageLimit = 200;
    }

    public static class DataOrder {
        public const int MpuXR = 0;
        public const int MpuYR = 1;
        public const int MpuZR = 2;
        public const int VoltageR = 3;
        public const int MpuXL = 4;
        public const int MpuYL = 5;
        public const int MpuZL = 6;
        public const int VoltageL = 7;
        public const int RollInput = 8;
        public const int DrugR = 12;
        public const int PitchInput = 16;
        public const int DrugL = 17;
        public const int MpuRoll = 18;
        public const int MpuPitch = 19;
        public const int MpuYaw = 20;
        public const int AirSpeed = 21;
        public const int Sonar = 22;
        public const int Cadence = 23;
        public const int Latitude = 24;
        public const int Longitude = 25;
        public const int Time = 26;
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
