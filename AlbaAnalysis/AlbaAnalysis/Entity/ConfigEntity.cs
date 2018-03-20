using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    /// <summary>
    /// コンボボックスでアイテムとして使用するためのメンバを作成
    /// </summary>
    public class BaudRateEntity {
        public string name { get; set; }

        public int rate { get; set; }
    }

    /// ここに新しい要素を追加するときは、database.sqlにも項目を追加してください
        /// <summary>
    /// マクロを定義
    /// </summary>
    public static class Constants
    {
        public const double filterLevel = 8.0;
        public static int First = typeof(FirstEntity).GetProperties().Count();
        public static int Second = typeof(SecondEntity).GetProperties().Count();
        public static int Third = typeof(ThirdEntity).GetProperties().Count();
        public static int Forth = typeof(ForthEntity).GetProperties().Count();
        public static string pathBase = @"../../../Log/";
    }

    public class portNames
    {
        public string portName { get; set; }
    }
    /// <summary>
    /// データを保存したパスを保持
    /// </summary>
    public class filePath
    {
        public string pathName { get; set; }
    }

    public class DetailEntity
    {
        public string value { get; set; }
        public string time { get; set; }
    }
}
