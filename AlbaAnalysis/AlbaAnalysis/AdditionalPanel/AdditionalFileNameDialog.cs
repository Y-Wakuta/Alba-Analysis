using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbaAnalysis {
    public partial class AdditionalFileNameDialog : Form {
        public AdditionalFileNameDialog() {
            InitializeComponent();
            textBoxComment.Text = "";
        }

        /// <summary>
        /// ファイル保存時にファイル名に追加するコメント
        /// </summary>
        public string Comment { get; set; }

        private void buttonApply_Click_1(object sender, EventArgs e) {
            Comment = textBoxComment.Text;
            this.Close();
        }

        public string GetComment() {
            return Comment;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }


}
