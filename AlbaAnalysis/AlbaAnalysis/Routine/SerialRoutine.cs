using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;
using AlbaAnalysis.Entity;

namespace AlbaAnalysis.Routine {
    public class SerialRoutine {

        string[] oldDatas = new string[40];

        /// <summary>
        /// リストに保存したデータをcsvに出力します
        /// </summary>
        /// <param name="se">配列化していない受信データ</param>
        /// <param name="path"></param>
        public static void writeDatas(List<SerialEntity> se, string path, bool append) {
            using (var sw = new StreamWriter(path, append)) {
                foreach (var d in se) {
                    var dataStrArray = new[] { d.Time,d.MpuRYaw,d.MpuRRoll
                        ,d.VoltageR,d.MpuXYaw,d.MpuYRoll
                              ,d.VoltageL,d.RollInput,d.DrugR,d.PitchInput,d.DrugL
                                ,d.MpuRoll,d.MpuPitch,d.MpuYaw
                                 ,d.AirSpeed,d.Sonar,d.Cadence ,Environment.NewLine};
                    sw.Write(String.Join(",", dataStrArray));
                }
            }
        }

        public static List<string> validateInput(string input) {
            var csvdatas = input.Split(',').ToList();
            foreach (var i in Enumerable.Range(0, csvdatas.Count)) {
                csvdatas[i] = csvdatas[i].Trim();
                if (string.IsNullOrEmpty(csvdatas[i]) || !double.TryParse(csvdatas[i], out double tmp))
                    csvdatas[i] = 0.ToString();
            }
            return csvdatas;
        }

        /// <summary>
        /// c++とc#で同じ文字列に対してxorをしていくのでも値が違う？
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string getCheckSum(string str) {
            var checkSum = 0;
            return "";
        }

        public static void CopyASCsv(SerialEntity se, string[] data) {
            se.Time = data[0];
            se.MpuRYaw = data[1];
            se.MpuRRoll = data[2];
            se.VoltageR = data[7];
            se.MpuXYaw = data[8];
            se.MpuYRoll = data[9];
            se.VoltageL = data[14];
            se.RollInput = data[15];
            se.DrugR = data[16];
            se.PitchInput = data[17];
            se.DrugL = data[18];
            se.MpuRoll = data[19];
            se.MpuPitch = data[20];
            se.MpuYaw = data[21];
            se.AirSpeed = data[22];
            se.Sonar = data[23];
            se.Cadence = data[24];
        }

        public static void CopyAS1(SerialEntity se, string[] data) {
            se.MpuRYaw = data[1];
            se.MpuRRoll = data[2];
            se.VoltageR = data[7];
            se.MpuXYaw = data[8];
            se.MpuYRoll = data[9];
            se.VoltageL = data[14];
        }

        public static void copyDatas2Entity(SerialEntity se, string[] datas, InputEnum ie) {
            if (ie == InputEnum.forth)
                CopyAS4(se, datas);
            else if (ie == InputEnum.third)
                CopyAS3(se, datas);
            else if (ie == InputEnum.second)
                CopyAS2(se, datas);
            else if (ie == InputEnum.first)
                CopyAS1(se, datas);
        }

        public static void CopyAS2(SerialEntity se, string[] data) {
            se.RollInput = data[1];
            se.DrugR = data[2];
            se.PitchInput = data[3];
            se.DrugL = data[4];
        }

        public static void CopyAS3(SerialEntity se, string[] data) {
            se.MpuRoll = data[1];
            se.MpuPitch = data[2];
            se.MpuYaw = data[3];
        }

        public static void CopyAS4(SerialEntity se, string[] data) {
            se.AirSpeed = data[1];
            se.Sonar = data[2];
            se.Cadence = data[3];
        }

        #region 同じentityか判定する
        public static bool IsSameControlEntity(SerialEntity se, SerialEntity lastSe) {
            if (se.VoltageL == lastSe.VoltageL && se.VoltageR == lastSe.VoltageR)
                return true;
            return false;
        }

        public static bool IsSameKeikiEntity(SerialEntity se, SerialEntity lastSe) {
            if (se.AirSpeed == lastSe.AirSpeed && se.Cadence == lastSe.Cadence)
                return true;
            return false;
        }

        public static bool IsSameMpuEntity(SerialEntity se, SerialEntity lastSe) {
            if (se.MpuPitch == lastSe.MpuPitch && se.MpuYaw == lastSe.MpuYaw && se.MpuRoll == lastSe.MpuRoll)
                return true;
            return false;
        }

        public static bool IsSameInputEntity(SerialEntity se, SerialEntity lastSe) {
            if (se.PitchInput == lastSe.PitchInput && se.RollInput == lastSe.RollInput && se.DrugL == lastSe.DrugL && se.DrugR == lastSe.DrugR)
                return true;
            return false;
        }

        public static InputEnum GetTargetEntity(SerialEntity se, SerialEntity lastSe) {
            if (IsSameControlEntity(se, lastSe) && IsSameKeikiEntity(se, lastSe) && IsSameMpuEntity(se, lastSe))
                return InputEnum.second;
            else if (IsSameControlEntity(se, lastSe) && IsSameKeikiEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.third;
            else if (IsSameControlEntity(se, lastSe) && IsSameMpuEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.forth;
            else if (IsSameKeikiEntity(se, lastSe) && IsSameMpuEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.first;
            else
                return InputEnum.notAccepted;
        }
        #endregion
    }
}
