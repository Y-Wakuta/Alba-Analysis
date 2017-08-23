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
        /// <param name="se">配列化していない受信データ</param>
        /// <param name="path"></param>
        public static void writeDatas(List<SerialEntity> se, string path, bool append) {
            using (var sw = new StreamWriter(path, append)) {
                foreach (var d in se) {
                    var dataStrArray = new[] { d.Time,d.MpuXR,d.MpuYR,d.MpuZR,d.MpuXR_A,d.MpuYR_A,d.MpuZR_A,d.VoltageR,d.MpuXL,d.MpuYL,d.MpuZL,d.MpuXL_A,d.MpuYL_A,d.MpuZL_A
                              ,d.VoltageL,d.ErebonRInput,d.DrugR,d.ErebonLInput,d.DrugL
                                ,d.MpuRoll,d.MpuPitch,d.MpuYaw
                                 ,d.AirSpeed,d.Sonar,d.Cadence +Environment.NewLine};
                    sw.Write(String.Join(",", dataStrArray));
                }
            }
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

        public static void CopyASCsv(SerialEntity se, string[] data) {
            se.Time = data[0];
            se.MpuXR = data[1];
            se.MpuYR = data[2];
            se.MpuZR = data[3];
            se.MpuXR_A = data[4];
            se.MpuYR_A = data[5];
            se.MpuZR_A = data[6];
            se.VoltageR = data[7];
            se.MpuXL = data[8];
            se.MpuYL = data[9];
            se.MpuZL = data[10];
            se.MpuXL_A = data[11];
            se.MpuYL_A = data[12];
            se.MpuZL_A = data[13];
            se.VoltageL = data[14];
            se.ErebonRInput = data[15];
            se.DrugR = data[16];
            se.ErebonLInput = data[17];
            se.DrugL = data[18];
            se.MpuRoll = data[19];
            se.MpuPitch = data[20];
            se.MpuYaw = data[21];
            se.AirSpeed = data[22];
            se.Sonar = data[23];
            se.Cadence = data[24];
        }

        public static void CopyASCon(SerialEntity se, string[] data) {
            se.MpuXR = data[1];
            se.MpuYR = data[2];
            se.MpuZR = data[3];
            se.MpuXR_A = data[4];
            se.MpuYR_A = data[5];
            se.MpuZR_A = data[6];
            se.VoltageR = data[7];
            se.MpuXL = data[8];
            se.MpuYL = data[9];
            se.MpuZL = data[10];
            se.MpuXL_A = data[11];
            se.MpuYL_A = data[12];
            se.MpuZL_A = data[13];
            se.VoltageL = data[14];
        }

        public static void copyDatas2Entity(SerialEntity se, string[] datas, InputEnum ie) {
            if (ie == InputEnum.keiki)
                CopyASKei(se, datas);
            else if (ie == InputEnum.mpu)
                CopyASMpu(se, datas);
            else if (ie == InputEnum.input)
                CopyASInp(se, datas);
            else if (ie == InputEnum.control)
                CopyASCon(se, datas);
        }

        public static void CopyASInp(SerialEntity se, string[] data) {
            se.ErebonRInput = data[1];
            se.DrugR = data[2];
            se.ErebonLInput = data[3];
            se.DrugL = data[4];
        }

        public static void CopyASMpu(SerialEntity se, string[] data) {
            se.MpuRoll = data[1];
            se.MpuPitch = data[2];
            se.MpuYaw = data[3];
        }

        public static void CopyASKei(SerialEntity se, string[] data) {
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
            if (se.ErebonLInput == lastSe.ErebonLInput && se.ErebonRInput == lastSe.ErebonRInput && se.DrugL == lastSe.DrugL && se.DrugR == lastSe.DrugR)
                return true;
            return false;
        }

        public static InputEnum GetTargetEntity(SerialEntity se, SerialEntity lastSe) {
            if (IsSameControlEntity(se, lastSe) && IsSameKeikiEntity(se, lastSe) && IsSameMpuEntity(se, lastSe))
                return InputEnum.input;
            else if (IsSameControlEntity(se, lastSe) && IsSameKeikiEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.mpu;
            else if (IsSameControlEntity(se, lastSe) && IsSameMpuEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.keiki;
            else if (IsSameKeikiEntity(se, lastSe) && IsSameMpuEntity(se, lastSe) && IsSameInputEntity(se, lastSe))
                return InputEnum.control;
            else
                return InputEnum.notAccepted;
        }
        #endregion
    }
}
