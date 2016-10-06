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
        public const int dataMembers = 21;
        public const double averageLevel = 4.0;
        public const double filterLevel = 8.0;
        public const double batteryVoltageLimit = 200;
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
   
}
