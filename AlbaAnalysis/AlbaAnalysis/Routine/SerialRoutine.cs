using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;
using AlbaAnalysis.Entity;

namespace AlbaAnalysis.Routine {
    public class SerialRoutine {

        string[] oldDatas = new string[40];
        int flag = 0;

        /// <summary>
        /// リストに保存したデータをcsvに出力します
        /// </summary>
        /// <param name="data">配列化していない受信データ</param>
        /// <param name="path"></param>
        public void writeDatas(List<string> data, string path, bool append) {
            var sw = new StreamWriter(path, append);
            foreach (var dt in data) {
                sw.Write(dt);
            }
            sw.Close();
        }
        /// <summary>
        /// シリアルから来てるデータにフィルタをかけます(操舵入力を除く)
        /// </summary>
        /// <param name="datas"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string[] fiterDatas(string[] datas, string[] filter) {
            string[] resultDatas = new string[datas.Count()];
            if (flag == 0) {
                oldDatas = datas;
                flag++;
            }
            for (int i = 6; i < 8; i++) {
                if (datas[i] != "") {
                    if (double.Parse(oldDatas[i]) - double.Parse(filter[i]) < double.Parse(datas[i])
                        && double.Parse(datas[i]) < double.Parse(oldDatas[i]) + double.Parse(filter[i])) {
                        resultDatas[i] = datas[i];
                        oldDatas[i] = datas[i];
                    }
                    else
                        resultDatas[i] = oldDatas[i];
                }
                else {
                    if (datas[i] == oldDatas[i])
                        resultDatas[i] = datas[i];
                    resultDatas[i] = oldDatas[i];
                }
            }
            return resultDatas;
        }
        /// <summary>
        /// batteryの電圧が低下したときにブザーを鳴らします
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public void checkBattery(string[] datas) {
            if (double.Parse(datas[6]) < Constants.batteryVoltageLimit) {
                System.Media.SystemSounds.Beep.Play();
            }
            else if (double.Parse(datas[7]) < Constants.batteryVoltageLimit) {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        public string AddTimeToDatas(string[] datas, string time) {
            string data = null;
            for (int i = 0; i < datas.Count() - 2; i++)
                data += datas[i] + ",";
            data += datas[21] + ",";
            data += datas[20];
            return data;
        }
    }
}
