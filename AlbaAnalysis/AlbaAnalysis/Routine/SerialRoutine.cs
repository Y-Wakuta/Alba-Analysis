using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;
using AlbaAnalysis.Entity;

namespace AlbaAnalysis.Routine
{
    public class SerialRoutine
    {

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

        /// <summary>
        /// 受信した文字列に欠損がないかを確認します
        /// </summary>
        /// <param name="inputLine"></param>
        /// <returns></returns>
        public static bool ValidateInput(string inputLine) {
            var inputList = inputLine.Split(',').ToList();
            var checkSum = inputList.Last();
            var beforeDeli = String.Join(",", inputList.Select((value, index) => new { value, index })
                                                        .Where(mem => mem.index != inputList.Count() - 1)
                                                        .Select(mem => mem.value)
                                                        .ToList());
            return checkSum == getCheckSum(beforeDeli);
        }

        /// <summary>
        /// 引数の文字列のchecksumを計算する
        /// </summary>
        /// <param name="beforDelimiter"></param>
        /// <returns></returns>
        private static string getCheckSum(string beforDelimiter) {
            var sum = '0';
            foreach (var c in beforDelimiter.ToCharArray())
                sum ^= c;
            return string.Format("{0:X2}", (int)sum);
        }

        public static void Copy2Entity(FirstEntity se, double[] data) {
            se.BaseUnixTime = data[1];
            se.AirSpeed = data[2];
            se.HeightTime = data[7];
            se.Height = data[8];
            se.CadenceTime = data[9];
            se.Cadence = data[14];
        }

        public static void Copy2Entity(SecondEntity se, double[] data) {
            se.BaseUnixTime = data[1];
            se.MpuTime = data[2];
            se.MpuYaw = data[3];
            se.MpuPitch = data[4];
            se.MpuRoll = data[5];
            se.GpsTime = data[6];
            se.Latitude = data[7];
            se.Longitude = data[8];
        }

        public static void Copy2Entity(ThirdEntity se, double[] data) {
            se.BaseUnixTime = data[1];
            se.ControlTime = data[2];

            var RInput = ExtractInputs(data[3]);
            se.RollInput = RInput.Item1;
            se.DrugR = RInput.Item2;

            var LInput = ExtractInputs(data[4]);
            se.PitchInput = LInput.Item1;
            se.DrugL = LInput.Item2;

            se.MpuRRoll = data[5];
            se.MpuRYaw = data[6];
        }

        public static void Copy2Entity(ForthEntity se, double[] data) {
            se.BaseUnixTime = data[1];
            se.ControlTime = data[2];
            se.VoltageR = data[3];

            se.VoltageL = data[4];
            se.MpuLRoll = data[5];
            se.MpuLYaw = data[6];
            se.VoltageR = data[4];
        }

        private static Tuple<double, double> ExtractInputs(double input) {
            var inputStr = input.ToString().PadLeft(4, '0');
            Double.TryParse(inputStr.Substring(0, 3), out var joyStick);
            Double.TryParse(inputStr.Substring(3, 1), out var drug);
            return Tuple.Create<double, double>(joyStick, drug);
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
