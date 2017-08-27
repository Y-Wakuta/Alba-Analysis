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

        #region column
        [DisplayOrder(order = 0, IsDisplay = false)]
        public string MpuXR = "0";

        [DisplayOrder(order = 1, IsDisplay = false)]
        public string MpuYR = "0";

        [DisplayOrder(order = 2, IsDisplay = false)]
        public string MpuZR = "0";

        [DisplayOrder(order = 3, IsDisplay = false)]
        public string MpuXR_A = "0";

        [DisplayOrder(order = 4, IsDisplay = false)]
        public string MpuYR_A = "0";

        [DisplayOrder(order = 5, IsDisplay = false)]
        public string MpuZR_A = "0";

        [DisplayOrder(name = "右翼端電圧", order = 6)]
        public string VoltageR = "0";

        [DisplayOrder(order = 7, IsDisplay = false)]
        public string MpuXL = "0";

        [DisplayOrder(order = 8, IsDisplay = false)]
        public string MpuYL = "0";

        [DisplayOrder(order = 9, IsDisplay = false)]
        public string MpuZL = "0";

        [DisplayOrder(order = 10, IsDisplay = false)]
        public string MpuXL_A = "0";

        [DisplayOrder(order = 11, IsDisplay = false)]
        public string MpuYL_A = "0";

        [DisplayOrder(order = 12, IsDisplay = false)]
        public string MpuZL_A = "0";

        [DisplayOrder(name = "左翼端電圧", order = 13)]
        public string VoltageL = "0";

        [DisplayOrder(name = "右エレボン", order = 14)]
        public string ErebonRInput = "0";

        [DisplayOrder(name = "右ドラッグ", order = 15)]
        public string DrugR = "0";

        [DisplayOrder(name = "左エレボン", order = 16)]
        public string ErebonLInput = "0";

        [DisplayOrder(name = "左ドラッグ", order = 17)]
        public string DrugL = "0";

        [DisplayOrder(name = "MPUロール", order = 18)]
        public string MpuRoll = "0";

        [DisplayOrder(name = "MPUピッチ", order = 19)]
        public string MpuPitch = "0";

        [DisplayOrder(name = "MPUヨー", order = 20)]
        public string MpuYaw = "0";

        [DisplayOrder(name = "気速", order = 21)]
        public string AirSpeed = "0";

        [DisplayOrder(order = 22, IsDisplay = false)]
        public string Sonar = "0";

        [DisplayOrder(name = "ケイデンス", order = 23)]
        public string Cadence = "0";
        //public const int Latitude = 24;
        //public const int Longitude = 25;

        [DisplayOrder(name = "時間", order = 24)]
        public string Time = "0";
        #endregion
    }

    #region 設定用クラス
    /// <summary>
    /// マクロを定義
    /// </summary>
    public class Constants {
        public const double filterLevel = 8.0;
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
