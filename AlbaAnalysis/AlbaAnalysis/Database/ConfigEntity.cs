using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace AlbaAnalysis.Database {

    [Table("Config", Schema = "public")]
    public class ConfigEntity : INotifyPropertyChanged {
        [Key]
        public int id {
            get { return _id; }
            set { _id = value; }
        }
        private int _id;

        /// <summary>
        /// 表示順
        /// </summary>
        public int ordering {
            get { return _ordering; }
            set { _ordering = value; }
        }
        private int _ordering;

        /// <summary>
        /// メンバの名前
        /// </summary>
        public string name {
            get { return _name; }
            set { _name = value; }
        }
        private string _name;

        /// <summary>
        /// 画面表示用の名前
        /// </summary>
        public string disp_name {
            get { return _disp_name; }
            set { _disp_name = value; }
        }
        private string _disp_name;

        /// <summary>
        /// 表示・非表示の保持
        /// </summary>
        public int status_display {
            get { return _status_display; }
            set { _status_display = value; }
        }
        private int _status_display;

        /// <summary>
        /// グラフ化で使うフィルタ関数のレベル
        /// </summary>
        public int filter_level {
            get { return _filter_level; }
            set { _filter_level = value; }
        }
        private int _filter_level;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
