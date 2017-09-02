using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    /// <summary>
    /// ここに新しい要素を追加するときは、database.sqlにも項目を追加してください
    /// </summary>
    public class SerialEntity {

        public SerialEntity Clone() {
            return (SerialEntity)MemberwiseClone();
        }

        #region column
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
