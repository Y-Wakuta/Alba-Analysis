using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis {
    /// <summary>
    /// nameはIsDisplayがfalseの時は空でもよいとします
    /// </summary>
    class DisplayOrderAttribute : Attribute {

        /// <summary>
        /// 属性を付けたメンバの名称を保持します
        /// </summary>
        public string name = string.Empty;

        /// <summary>
        /// 設定画面のxDGVに表示する順番を割り当てます
        /// </summary>
        public int order = 0;

        /// <summary>
        /// データを画面に表示するかどうかを保持します
        /// </summary>
        public bool IsDisplay = true;
    }
}
