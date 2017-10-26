using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace AlbaAnalysis {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(new SerialForm());
            } catch (Exception exc) {
                MessageBox.Show("エラーが発生しました。終了します\n" + exc.Message);
            }
        }
    }
}
