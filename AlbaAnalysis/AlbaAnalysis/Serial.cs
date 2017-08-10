using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using AlbaAnalysis.Entity;
using AlbaAnalysis.Routine;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace AlbaAnalysis {

    delegate void Handler(SerialEntity strs, string str, InputEnum ie);

    public partial class SerialForm : Form {

        List<SerialEntity> saveData = new List<SerialEntity>();
        SerialRoutine serialRoutine = new SerialRoutine();
        int csvFlag = 0;
        CadenceView cadenceView = new CadenceView();
        SerialEntity serialEntity = new SerialEntity();
        SerialEntity lastSerialEntity = null;             //1つ前のserialEntityをcsvでの処理用に保持する
        AlbaAnalysisDataHandler _ad;
        DateTime start;

        public SerialForm() {
            InitializeComponent();
            _ad = new AlbaAnalysisDataHandler(bauditemsBindingSource, portNamesBindingSource, filePathBindingSource);

            buttonNext.Enabled = false;

            buttonClose.Enabled = false;
            buttonStopCsv.Enabled = false;
            buttonRDrug.Enabled = false;
            buttonLDrug.Enabled = false;
            buttonConnect.Enabled = true;

            bauditemsBindingSource.PositionChanged += (s, e) => {
                serialPort1.BaudRate = ((BaudRateEntity)(bauditemsBindingSource.Current)).rate;
            };
            portNamesBindingSource.PositionChanged += (s, e) => {
                serialPort1.PortName = ((portNames)portNamesBindingSource.Current).portName;
            };
            buttonConnect.Focus();

            ClearTextBox();
            #region グラフ設定

            #endregion
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Dispose();
            serialPort1.Close();
        }

        private async void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = null;
            var sw = new Stopwatch();
            sw.Start();
            try {
                data = serialPort1.ReadLine();
            }
            catch (Exception) {
                return;
            }
            sw.Stop();
            if (sw.ElapsedMilliseconds > 5000)
                serialPort1.DiscardInBuffer();

            var datas = data.Split(',');

            for (int i = 1; i < datas.Count() - 1; i++) {
                if (string.IsNullOrEmpty(datas[i]))
                    return;
                try {
                    double.Parse(datas[i]);
                }
                catch (Exception) {
                    datas[i] = 0.ToString();
                }
            }

            var temp = Enum.GetNames(typeof(ControlDataOrder)).Length;

            if (datas[0] == "con" && datas.Count() == Enum.GetNames(typeof(ControlDataOrder)).Length + 2) {

                serialRoutine.CopyASCon(serialEntity, datas);
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);

                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.control);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.control);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.control);

            }
            else if (datas[0] == "inp" && datas.Count() == Enum.GetNames(typeof(InputDataOrder)).Length + 1) {
                serialRoutine.CopyASInp(serialEntity, datas);
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);
                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.input);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.input);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.input);
            }

            else if (datas[0] == "mpu" && datas.Count() == Enum.GetNames(typeof(MpuDataOrder)).Length + 1) {
                serialRoutine.CopyASMpu(serialEntity, datas);
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);
                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.mpu);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.mpu);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.mpu);
            }
            else if (datas[0] == "kei" && datas.Count() == Enum.GetNames(typeof(KeikiDataOrder)).Length + 1) {
                serialRoutine.CopyASKei(serialEntity, datas);
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);
                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.keiki);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.keiki);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.keiki);
            }
        }

        /// <summary>
        /// 操舵入力に対応してボタンの色を変化させます
        /// </summary>
        /// <param name="data">配列化した受信データ</param>
        /// <param name="i"></param>
        private async void checkSteer(SerialEntity datas, string data, InputEnum ie) {
            if (InputEnum.input == ie) {
                if (datas.DrugR == 1.ToString())
                    buttonRDrug.BackColor = Color.LightCoral;
                else buttonRDrug.BackColor = Color.LightGray;

                if (datas.DrugL == 1.ToString())
                    buttonLDrug.BackColor = Color.LightCoral;
                else
                    buttonLDrug.BackColor = Color.LightGray;

                try {
                    var RInput = double.Parse(datas.ErebonRInput) * 100.0 + 50.0;
                    rollVerticalProgressBar.Value = (int)RInput + 1;
                    rollVerticalProgressBar.Value = (int)RInput;          //progressBarは値が下がる時はすぐに変位するので、それを利用して表示

                    var LInput = double.Parse(datas.ErebonLInput) * 100.0 + 50.0;

                    pitchVerticalProgressBar.Value = (int)LInput + 1;
                    pitchVerticalProgressBar.Value = (int)LInput;
                }
                catch {
                    return;
                }
            }
        }

        /// <summary>
        /// 操舵入力表示用のボタンをNextButtonを押したときに色を戻します
        /// </summary>
        private void ResetButton() {
            buttonRDrug.BackColor = Color.LightGray;
            buttonLDrug.BackColor = Color.LightGray;
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="datas">配列化した受信データ</param>
        /// <param name="i"></param>
        private async void showChart(SerialEntity datas, string data, InputEnum ie) {
            #region グラフ設定
            try {
                if (InputEnum.keiki == ie) {
                    chartSpeed.Series["Speed"].Points.AddXY(datas.Time, double.Parse(datas.AirSpeed));
                    chartCadence.Series["Cadence"].Points.AddXY(datas.Time, double.Parse(datas.Cadence));

                    chartSpeed.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartCadence.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                }
                else if (InputEnum.control == ie) {
                    chartRBattery.Series["RBattery"].Points.AddXY(datas.Time, double.Parse(datas.VoltageR));
                    chartLBattery.Series["LBattery"].Points.AddXY(datas.Time, double.Parse(datas.VoltageL));

                    chartRBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartLBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                }
                else if (InputEnum.mpu == ie) {
                    chartMpuPitch.Series["MPitch"].Points.AddXY(datas.Time, double.Parse(datas.MpuPitch));
                    chartMpuYaw.Series["MYaw"].Points.AddXY(datas.Time, double.Parse(datas.MpuYaw));
                    chartMpuRoll.Series["MRoll"].Points.AddXY(datas.Time, double.Parse(datas.MpuRoll));

                    chartMpuPitch.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartMpuYaw.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartMpuRoll.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                }
                else if (InputEnum.input == ie) {
                    chartDrugInput.Series["DrugInput"].Points.AddXY(datas.Time, double.Parse(datas.DrugR) - double.Parse(datas.DrugL));
                    chartRollInput.Series["RollInput"].Points.AddXY(datas.Time, double.Parse(datas.ErebonRInput));
                    chartPitchInput.Series["PitchInput"].Points.AddXY(datas.Time, double.Parse(datas.ErebonLInput));

                    chartRollInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartDrugInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartPitchInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                }
                cadenceView.cadence = datas.Cadence;
                cadenceView.time = datas.Time;
            }
            catch (Exception) {
                return;
            }
            //});
            #endregion
        }

        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart() {
            chartSpeed.Series["Speed"].Points.Clear();
            chartMpuPitch.Series["MPitch"].Points.Clear();
            chartCadence.Series["Cadence"].Points.Clear();
            chartRBattery.Series["RBattery"].Points.Clear();
            chartLBattery.Series["LBattery"].Points.Clear();
            chartMpuYaw.Series["MYaw"].Points.Clear();
            chartMpuRoll.Series["MRoll"].Points.Clear();
            chartRollInput.Series["RollInput"].Points.Clear();
            chartPitchInput.Series["PitchInput"].Points.Clear();
            chartDrugInput.Series["DrugInput"].Points.Clear();
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="datas">配列化した受信データ</param>
        /// <param name="i"></param>
        private void showText(SerialEntity datas, string data, InputEnum ie) {
            //await Task.Run(() => {
            #region textboxへの表示
            textBoxAllData.AppendText(data + Environment.NewLine);
            if (InputEnum.keiki == ie) {
                textBoxSpeed.AppendText(datas.AirSpeed + Environment.NewLine);
                textBoxCadence.AppendText(datas.Cadence + Environment.NewLine);
            }
            else if (InputEnum.control == ie) {
                textBoxBatteryDataR.AppendText(datas.VoltageR + Environment.NewLine);
                textBoxBatteryDataL.AppendText(datas.VoltageL + Environment.NewLine);
            }
            else if (InputEnum.mpu == ie) {
                textBoxMpuPitch.AppendText(datas.MpuPitch + Environment.NewLine);
                textBoxMpuRoll.AppendText(datas.MpuRoll + Environment.NewLine);
                textBoxMpuYaw.AppendText(datas.MpuYaw + Environment.NewLine);
            }
            #endregion
            //});
        }

        /// <summary>
        /// Nextボタンを押したときにtextBoxをクリアします
        /// </summary>
        void ClearTextBox() {
            textBoxAllData.Clear();
            textBoxMpuPitch.Clear();
            textBoxBatteryDataR.Clear();
            textBoxBatteryDataL.Clear();
            textBoxBatteryDataR.Clear();
            textBoxBatteryDataL.Clear();
            textBoxCadence.Clear();
            textBoxMpuPitch.Clear();
            textBoxMpuRoll.Clear();
            textBoxMpuYaw.Clear();
            textBoxSpeed.Clear();
        }

        private void buttonConnect_Click_1(object sender, EventArgs e) {

            if (serialPort1.IsOpen == false) {
                try {
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                catch (Exception) {
                    MessageBox.Show("利用可能なシリアルポートがありません");
                }
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
            }
            if (serialPort1.IsOpen == true) {
                buttonConnect.Enabled = false;
                buttonClose.Enabled = true;
                buttonNext.Enabled = false;
                buttonRunCsv.Enabled = false;
                buttonOpenCsv.Enabled = false;
                buttonClose.Focus();
                start = DateTime.Now;

            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e) {
            var commentForm = new AdditionalFileNameDialog();
            commentForm.ShowDialog();
            SaveAllCharts(commentForm.GetComment());
            serialRoutine.writeDatas(saveData, _ad.pathBase + "TF" + DateTime.Now.ToString("MMdd_hhmm") + commentForm.GetComment() + ".csv", true);
            _ad.resetFileList();
            serialPort1.DiscardInBuffer();
            serialPort1.Close();
            buttonConnect.Enabled = true;
            buttonNext.Enabled = true;
            buttonClose.Enabled = false;
            buttonNext.Enabled = true;
            buttonRunCsv.Enabled = true;
            buttonOpenCsv.Enabled = true;
        }

        private void buttonNext_Click_1(object sender, EventArgs e) {
            clearForm();
            buttonConnect.Focus();
        }

        private void clearForm() {
            ClearTextBox();
            ClearChart();
            ResetButton();
            saveData.Clear();
        }

        private async void buttonRunCsv_Click(object sender, EventArgs e) {
            clearForm();
            buttonStopCsv.Enabled = true;
            buttonStopCsv.Focus();
            var _resultPath = (filePathBindingSource.Current).ToString();
            csvFlag = 0;
            StreamReader fw;
            await Task.Run(() => {
                start = DateTime.Now;
                if (string.IsNullOrEmpty(_resultPath)) {
                    MessageBox.Show("パスを選択してください");
                    return;
                }
                try {
                    fw = new StreamReader(_resultPath);
                }
                catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    return;
                }

                do {
                    if (csvFlag == 1) {
                        fw.Dispose();
                        fw.Close();
                        return;
                    }
                    var csvLine = fw.ReadLine();
                    string[] csvdatas = null;
                    try {
                        csvdatas = csvLine.Split(',');
                    }
                    catch (Exception) {
                        // MessageBox.Show("ファイルが空です。");
                        continue;
                    }
                    if (csvdatas.Any(d => string.IsNullOrEmpty(d)))
                        return;
                    if (csvdatas.Count() == 25) {
                        serialRoutine.CopyASCsv(serialEntity, csvdatas);
                        if (lastSerialEntity == null) {
                            lastSerialEntity = serialEntity.Clone();
                            return;
                        }
                        var targetEnum = serialRoutine.GetTargetEntity(serialEntity, lastSerialEntity);
                        lastSerialEntity = serialEntity.Clone();

                        BeginInvoke(new Handler(showChart), serialEntity, csvLine, targetEnum);
                        BeginInvoke(new Handler(showText), serialEntity, csvLine, targetEnum);
                        BeginInvoke(new Handler(checkSteer), serialEntity, csvLine, targetEnum);
                    }
                    //csv読み込みの速度向上
                    System.Threading.Thread.Sleep(50);
                } while (fw.EndOfStream != true);
                fw.Dispose();
                fw.Close();
                MessageBox.Show("ファイルの読み込みを終了しました。");
            });
            comboBoxFiles.DroppedDown = true;
            comboBoxFiles.Focus();
        }

        private void buttonStopCsv_Click(object sender, EventArgs e) {
            csvFlag = 1;
            buttonRunCsv.Focus();
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e) {
            if (csvFlag == 0) {
                MessageBox.Show("ファイルの再生を終了してください。");
                return;
            }
            var p = Process.Start("excel", ((filePath)(filePathBindingSource.Current)).pathName);
            p.WaitForExit();
        }

        private void comboBoxFiles_SelectedIndexChanged(object sender, EventArgs e) {
            buttonRunCsv.Focus();
        }

        private void chartCadence_Click(object sender, EventArgs e) {
            var detail = new Detail(cadenceView);
            detail.Show();
        }

        private void SaveAllCharts(string comment) {
            var nowTime = DateTime.Now.ToString("MMdd_hhmm");
            try {
                var dir = System.IO.Directory.CreateDirectory(@"../../../Log/chart/" + nowTime + comment);
            }
            catch (IOException io) {
                MessageBox.Show(io.Message);
            }
            chartSpeed.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartSpeed.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartMpuPitch.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartMpuPitch.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartCadence.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartCadence.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartRBattery.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartRBattery + ".jpeg", ChartImageFormat.Jpeg);
            chartLBattery.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartLBattery.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartMpuYaw.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartMpuYaw.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartMpuRoll.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartMpuRoll.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartRollInput.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartRollInput.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartPitchInput.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartPitchInput.Name + ".jpeg", ChartImageFormat.Jpeg);
            chartDrugInput.SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + chartDrugInput.Name + ".jpeg", ChartImageFormat.Jpeg);
        }
    }
}


