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
            var tmp =  string.Format("{0:X2}", (int)sum);
            return string.Format("{0:X2}", (int)sum);
        }

        public static void Copy2Entity(FirstEntity se,List<double> data) {
            se.BaseUnixTime = data[1];
            se.AirSpeed = data[2];
            se.HeightTime = data[3];
            se.Height = data[4];
            se.CadenceTime = data[5];
            se.Cadence = data[6];
        }

        public static void Copy2Entity(SecondEntity se, List<double> data) {
            se.BaseUnixTime = data[1];
            se.MpuTime = data[2];
            se.MpuYaw = data[3];
            se.MpuPitch = data[4];
            se.MpuRoll = data[5];
            se.GpsTime = data[6];
            se.Latitude = data[7];
            se.Longitude = data[8];
        }

        public static void Copy2Entity(ThirdEntity se, List<double> data) {
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

        public static void Copy2Entity(ForthEntity se, List<double> data) {
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
    }
}
