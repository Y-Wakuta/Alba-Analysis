using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AlbaAnalysis {

  
    /// <summary>
    /// nameはIsDisplayがfalseの時は空でもよいとします
    /// </summary>
    public class DisplayOrderAttribute :Attribute{

        public DisplayOrderAttribute() {
            name = string.Empty;
            IsDisplay = true;
        }
        /// <summary>
        /// 属性を付けたメンバの名称を保持します
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 設定画面のxDGVに表示する順番を割り当てます
        /// </summary>
        public int order { get; set; }

        /// <summary>
        /// データを画面に表示するかどうかを保持します
        /// </summary>
        public bool IsDisplay { get; set; }
    }
}
