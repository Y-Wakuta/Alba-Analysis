using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    delegate void voidMethod();


    public partial class SerialForm : Form {

        DateTime start = DateTime.Now;
        List<SerialEntity> saveData = new List<SerialEntity>();
        string _resultPath = null;
        SerialRoutine serialRoutine = new SerialRoutine();
        Stopwatch sw;
        int csvFlag = 0;
        string path = null;
        CadenceView cadenceView = new CadenceView();
        SerialEntity serialEntity = new SerialEntity();
        string pathBase = @"../../../Log/";
        SerialEntity lastSerialEntity = null;             //1つ前のserialEntityをcsvでの処理用に保持する

        public SerialForm() {
            InitializeComponent();
            buttonNext.Enabled = false;

            buttonClose.Enabled = false;
            buttonStopCsv.Enabled = false;
            buttonRDrug.Enabled = false;
            buttonLDrug.Enabled = false;
            buttonConnect.Enabled = true;

            rollVerticalProgressBar.Maximum = Constants.PHASE_NUM;
            rollVerticalProgressBar.Minimum = 0;

            pitchVerticalProgressBar.Maximum = Constants.PHASE_NUM;
            pitchVerticalProgressBar.Minimum = 0;
        }

        /// <summary>
        /// シリアルポートとボートレートを取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serial_Load(object sender, EventArgs e) {
            buttonConnect.Focus();

            string[] Portlist = SerialPort.GetPortNames();

            SerialPort _serialport = new SerialPort();

            comboBoxPort.Items.Clear();
            comboBoxFiles.Items.Clear();

            foreach (var Port in Portlist)
                comboBoxPort.Items.Add(Port);

            if (comboBoxPort.Items.Count == 0)
                comboBoxPort.Items.Add("利用可能なシリアルポートは存在しません。");
            else if (comboBoxPort.Items.Count > 0) {
                comboBoxPort.SelectedIndex = 0;
                try {
                    serialPort1.PortName = comboBoxPort.SelectedItem.ToString();
                }
                catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                }

            }
            AddAllPath(pathBase);
            #region comboBoxBaudの設定
            List<bauditems> baudList = new List<bauditems>();

            bauditems baud1 = new bauditems() {
                NAME = "4800bps",
                RATE = 4800
            };
            baudList.Add(baud1);
            bauditems baud2 = new bauditems() {
                NAME = "14400bps",
                RATE = 14400
            };
            baudList.Add(baud2);
            bauditems baud3 = new bauditems() {
                NAME = "115200bps",
                RATE = 115200
            };
            baudList.Add(baud3);
            comboBoxBaud.SelectedText = "NAME";
            comboBoxBaud.SelectedValue = "RATE";
            bauditemsBindingSource.DataSource = baudList;
            comboBoxBaud.SelectedIndex = 2;
            #endregion


            ClearTextBox();
            #region グラフ設定


            chartSpeed.ChartAreas[0].AxisX.Title = "Time[s]";
            chartSpeed.ChartAreas[0].AxisY.Title = "Speed[m/s]";

            chartMpuPitch.ChartAreas[0].AxisX.Title = "Time[s]";
            chartMpuPitch.ChartAreas[0].AxisY.Title = "MPitch";

            chartCadence.ChartAreas[0].AxisX.Title = "Time[s]";
            chartCadence.ChartAreas[0].AxisY.Title = "Cadence[/m]";

            chartRBattery.ChartAreas[0].AxisX.Title = "Time[s]";
            chartRBattery.ChartAreas[0].AxisY.Title = "RBattery[V]";

            chartLBattery.ChartAreas[0].AxisX.Title = "Time[s]";
            chartLBattery.ChartAreas[0].AxisY.Title = "LBattery[V]";

            chartMpuYaw.ChartAreas[0].AxisX.Title = "Time[s]";
            chartMpuYaw.ChartAreas[0].AxisY.Title = "MpuYaw";

            chartMpuRoll.ChartAreas[0].AxisX.Title = "Time[s]";
            chartMpuRoll.ChartAreas[0].AxisY.Title = "MpuRoll";

            chartRollInput.ChartAreas[0].AxisX.Title = "Time[s]";
            chartRollInput.ChartAreas[0].AxisY.Title = "RollInput";

            chartPitchInput.ChartAreas[0].AxisX.Title = "Time[s]";
            chartPitchInput.ChartAreas[0].AxisY.Title = "PitchInput";

            chartDrugInput.ChartAreas[0].AxisX.Title = "Time[s]";
            chartDrugInput.ChartAreas[0].AxisY.Title = "DrugInput";


            #endregion
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Dispose();
            serialPort1.Close();
        }

        private void comboBoxBaud_TextChanged(object sender, EventArgs e) {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPort1.BaudRate = (int)comboBoxBaud.SelectedValue;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = null;
            sw = new Stopwatch();
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
                    // return;
                }
            }

            var temp = Enum.GetNames(typeof(ControlDataOrder)).Length;

            if (datas[0] == "con" && datas.Count() == Enum.GetNames(typeof(ControlDataOrder)).Length + 2) {
                serialEntity.MpuXR = datas[1];
                serialEntity.MpuYR = datas[2];
                serialEntity.MpuZR = datas[3];
                serialEntity.MpuXR_A = datas[4];
                serialEntity.MpuYR_A = datas[5];
                serialEntity.MpuZR_A = datas[6];
                serialEntity.VoltageR = datas[7];
                serialEntity.MpuXL = datas[8];
                serialEntity.MpuYL = datas[9];
                serialEntity.MpuZL = datas[10];
                serialEntity.MpuXL_A = datas[11];
                serialEntity.MpuYL_A = datas[12];
                serialEntity.MpuZL_A = datas[13];
                serialEntity.VoltageL = datas[14];

                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = new SerialEntity();
                tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);

                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.control);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.control);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.control);

            }
            else if (datas[0] == "inp" && datas.Count() == Enum.GetNames(typeof(InputDataOrder)).Length + 1) {
                serialEntity.ErebonRInput = datas[1];
                serialEntity.DrugR = datas[2];
                serialEntity.ErebonLInput = datas[3];
                serialEntity.DrugL = datas[4];
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = new SerialEntity();
                tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);
                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.input);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.input);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.input);
            }

            else if (datas[0] == "mpu" && datas.Count() == Enum.GetNames(typeof(MpuDataOrder)).Length + 1) {
                serialEntity.MpuRoll = datas[1];
                serialEntity.MpuPitch = datas[2];
                serialEntity.MpuYaw = datas[3];

                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();


                var tempSerial = new SerialEntity();
                tempSerial = serialEntity.Clone();
                saveData.Add(tempSerial);
                BeginInvoke(new Handler(showChart), tempSerial, data, InputEnum.mpu);
                BeginInvoke(new Handler(showText), tempSerial, data, InputEnum.mpu);
                BeginInvoke(new Handler(checkSteer), tempSerial, data, InputEnum.mpu);
            }
            else if (datas[0] == "kei" && datas.Count() == Enum.GetNames(typeof(KeikiDataOrder)).Length + 1) {
                serialEntity.AirSpeed = datas[1];
                serialEntity.Sonar = datas[2];
                serialEntity.Cadence = datas[3];
                DateTime end = DateTime.Now;
                TimeSpan time = end - start;
                serialEntity.Time = time.TotalSeconds.ToString();

                var tempSerial = new SerialEntity();
                tempSerial = serialEntity.Clone();
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
        private void checkSteer(SerialEntity datas, string data, InputEnum ie) {
            if (InputEnum.input == ie) {
                if (datas.DrugR == 1.ToString())
                    buttonRDrug.BackColor = Color.LightCoral;
                else buttonRDrug.BackColor = Color.LightGray;

                if (datas.DrugL == 1.ToString())
                    buttonLDrug.BackColor = Color.LightCoral;
                else
                    buttonLDrug.BackColor = Color.LightGray;

                try {
                    rollVerticalProgressBar.Value = int.Parse(datas.ErebonRInput) + 1;
                    rollVerticalProgressBar.Value = int.Parse(datas.ErebonRInput);

                    pitchVerticalProgressBar.Value = int.Parse(datas.ErebonLInput) + 1;
                    pitchVerticalProgressBar.Value = int.Parse(datas.ErebonLInput);
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
        private void showChart(SerialEntity datas, string data, InputEnum ie) {
            #region グラフ設定
            try {
                if (InputEnum.keiki == ie) {
                    chartSpeed.Series["Speed"].Points.AddXY(datas.Time, double.Parse(datas.AirSpeed));
                    chartCadence.Series["Cadence"].Points.AddXY(datas.Time, double.Parse(datas.Cadence));


                    chartSpeed.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartSpeed.ChartAreas[0].AxisX.Minimum = 0;
                    chartSpeed.ChartAreas[0].AxisX.Interval = 10;

                    chartCadence.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartCadence.ChartAreas[0].AxisX.Minimum = 0;
                    chartCadence.ChartAreas[0].AxisX.Interval = 10;
                }
                else if (InputEnum.control == ie) {
                    chartRBattery.Series["RBattery"].Points.AddXY(datas.Time, double.Parse(datas.VoltageR));
                    chartLBattery.Series["LBattery"].Points.AddXY(datas.Time, double.Parse(datas.VoltageL));


                    chartRBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartRBattery.ChartAreas[0].AxisX.Minimum = 0;
                    chartRBattery.ChartAreas[0].AxisX.Interval = 10;

                    chartLBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartLBattery.ChartAreas[0].AxisX.Minimum = 0;
                    chartLBattery.ChartAreas[0].AxisX.Interval = 10;
                }
                else if (InputEnum.mpu == ie) {
                    chartMpuPitch.Series["MPitch"].Points.AddXY(datas.Time, double.Parse(datas.MpuPitch));
                    chartMpuYaw.Series["MYaw"].Points.AddXY(datas.Time, double.Parse(datas.MpuYaw));
                    chartMpuRoll.Series["MRoll"].Points.AddXY(datas.Time, double.Parse(datas.MpuRoll));


                    chartMpuPitch.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartMpuPitch.ChartAreas[0].AxisX.Minimum = 0;
                    chartMpuPitch.ChartAreas[0].AxisX.Interval = 10;

                    chartMpuYaw.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartMpuYaw.ChartAreas[0].AxisX.Minimum = 0;
                    chartMpuYaw.ChartAreas[0].AxisX.Interval = 10;

                    chartMpuRoll.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartMpuRoll.ChartAreas[0].AxisX.Minimum = 0;
                    chartMpuRoll.ChartAreas[0].AxisX.Interval = 10;
                }
                else if (InputEnum.input == ie) {
                    chartDrugInput.Series["DrugInput"].Points.AddXY(datas.Time, double.Parse(datas.DrugR) - double.Parse(datas.DrugL));
                    chartRollInput.Series["RollInput"].Points.AddXY(datas.Time, double.Parse(datas.ErebonRInput));
                    chartPitchInput.Series["PitchInput"].Points.AddXY(datas.Time, double.Parse(datas.ErebonLInput));


                    chartRollInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartRollInput.ChartAreas[0].AxisX.Minimum = 0;
                    chartRollInput.ChartAreas[0].AxisX.Interval = 10;

                    chartDrugInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartDrugInput.ChartAreas[0].AxisX.Minimum = 0;
                    chartDrugInput.ChartAreas[0].AxisX.Interval = 10;

                    chartPitchInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas.Time);
                    chartPitchInput.ChartAreas[0].AxisX.Minimum = 0;
                    chartPitchInput.ChartAreas[0].AxisX.Interval = 10;
                }
                cadenceView.cadence = datas.Cadence;
                cadenceView.time = datas.Time;
            }
            catch (Exception) {
                return;
            }
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
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e) {
            var commentForm = new AdditionalFileNameDialog();
            commentForm.ShowDialog();
            var pathItem = new filePath();
            path = pathBase + "TF" + DateTime.Now.ToString("MMdd_hhmm") + commentForm.GetComment() + ".csv";
            serialRoutine.writeDatas(saveData, path, true);
            AddAllPath(pathBase);
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

        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxBaud.SelectedIndex != -1)
                serialPort1.BaudRate = (int)comboBoxBaud.SelectedValue;
        }

        private async void buttonRunCsv_Click(object sender, EventArgs e) {
            clearForm();
            buttonStopCsv.Enabled = true;
            buttonStopCsv.Focus();
            _resultPath = comboBoxFiles.Text;
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
                        MessageBox.Show("ファイルが空です。");
                        return;
                    }
                    for (int i = 0; i < csvdatas.Count() - 1; i++) {
                        if (string.IsNullOrEmpty(csvdatas[i]))
                            return;
                    }
                    if (csvdatas.Count() == 25) {
                        serialEntity.Time = csvdatas[0];
                        serialEntity.MpuXR = csvdatas[1];
                        serialEntity.MpuYR = csvdatas[2];
                        serialEntity.MpuZR = csvdatas[3];
                        serialEntity.MpuXR_A = csvdatas[4];
                        serialEntity.MpuYR_A = csvdatas[5];
                        serialEntity.MpuZR_A = csvdatas[6];
                        serialEntity.VoltageR = csvdatas[7];
                        serialEntity.MpuXL = csvdatas[8];
                        serialEntity.MpuYL = csvdatas[9];
                        serialEntity.MpuZL = csvdatas[10];
                        serialEntity.MpuXL_A = csvdatas[11];
                        serialEntity.MpuYL_A = csvdatas[12];
                        serialEntity.MpuZL_A = csvdatas[13];
                        serialEntity.VoltageL = csvdatas[14];
                        serialEntity.ErebonRInput = csvdatas[15];
                        serialEntity.DrugR = csvdatas[16];
                        serialEntity.ErebonLInput = csvdatas[17];
                        serialEntity.DrugL = csvdatas[18];
                        serialEntity.MpuRoll = csvdatas[19];
                        serialEntity.MpuPitch = csvdatas[20];
                        serialEntity.MpuYaw = csvdatas[21];
                        serialEntity.AirSpeed = csvdatas[22];
                        serialEntity.Sonar = csvdatas[23];
                        serialEntity.Cadence = csvdatas[24];
                        if (lastSerialEntity == null) {
                            lastSerialEntity = serialEntity.Clone();
                            return;
                        }
                        var targetEnum = serialRoutine.GetTargetEntity(serialEntity, lastSerialEntity);

                        BeginInvoke(new Handler(showChart), serialEntity, csvLine, targetEnum);
                        BeginInvoke(new Handler(showText), serialEntity, csvLine, targetEnum);
                        BeginInvoke(new Handler(checkSteer), serialEntity, csvLine, targetEnum);
                    }

                    //csv読み込みの速度向上
                    System.Threading.Thread.Sleep(50);
                } while (fw.EndOfStream != true);
                fw.Dispose();
                fw.Close();
            });
            MessageBox.Show("ファイルの読み込みを終了しました。");
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
            _resultPath = comboBoxFiles.Text;
            Process p = Process.Start("excel", _resultPath);
            p.WaitForExit();

        }

        private void AddAllPath(string path) {
            comboBoxFiles.Items.Clear();
            string[] _path = null;
            _path = Directory.GetFiles(path, "*");
            comboBoxFiles.Items.AddRange(_path);
            //  comboBoxFiles.SelectedIndex = 0;
        }

        private void comboBoxFiles_SelectedIndexChanged(object sender, EventArgs e) {
            buttonRunCsv.Focus();
        }

        private void chartCadence_Click(object sender, EventArgs e) {
            var detail = new Detail(cadenceView);
            detail.Show();
        }
    }
}


