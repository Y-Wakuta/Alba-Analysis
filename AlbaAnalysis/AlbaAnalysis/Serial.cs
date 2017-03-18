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

    delegate void Handler(string[] strs, string str, int i);
    delegate void voidMethod();


    public partial class SerialForm : Form {

        DateTime start = DateTime.Now;
        List<string> saveData = new List<string>();
        string[] aveData = new string[40];
        string _resultPath = null;
        SerialRoutine SerialProcess = new SerialRoutine();
        Stopwatch sw;
        int csvFlag = 0;
        string path = null;
        int fileNumber = 1;


        public SerialForm() {
            InitializeComponent();
            buttonNext.Enabled = false;

            buttonClose.Enabled = false;
            buttonStopCsv.Enabled = false;
            buttonRDrug.Enabled = false;
            buttonLDrug.Enabled = false;
            buttonConnect.Enabled = false;
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
            AddAllPath();
            #region comboBoxBaudの設定
            List<bauditems> baudList = new List<bauditems>();

            bauditems baud1 = new bauditems();
            baud1.NAME = "4800bps";
            baud1.RATE = 4800;
            baudList.Add(baud1);
            bauditems baud2 = new bauditems();
            baud2.NAME = "9600bps";
            baud2.RATE = 9600;
            baudList.Add(baud2);
            bauditems baud3 = new bauditems();
            baud3.NAME = "115200bps";
            baud3.RATE = 115200;
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

            if (datas.Count() == Constants.dataMembers) {
                for (int i = 0; i < datas.Count() - 1; i++) {
                    if (string.IsNullOrEmpty(datas[i]))
                        return;
                }
                saveData.Add(data);
                BeginInvoke(new Handler(showChart), datas, data, 0);
                BeginInvoke(new Handler(showText), datas, data, 0);
                BeginInvoke(new Handler(checkSteer), datas, data, 0);
            }
        }

        /// <summary>
        /// 操舵入力に対応してボタンの色を変化させます
        /// </summary>
        /// <param name="data">配列化した受信データ</param>
        /// <param name="i"></param>
        public void checkSteer(string[] datas, string data, int i) {
            if (datas[DataOrder.DrugR] == 1.ToString())
                buttonRDrug.BackColor = Color.LightCoral;
            else buttonRDrug.BackColor = Color.LightGray;

            if (datas[DataOrder.DrugL] == 1.ToString())
                buttonLDrug.BackColor = Color.LightCoral;
            else
                buttonLDrug.BackColor = Color.LightGray;

            rollProgressBar.Value = (int)(double.Parse(datas[DataOrder.MpuRoll]) * 100);
            pitchVerticalProgressBar.Value = (int)(double.Parse(datas[DataOrder.MpuPitch]) * 100);
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
        private void showChart(string[] datas, string data, int i) {
            DateTime end = DateTime.Now;
            TimeSpan time = end - start;
            int xValue = (int)time.TotalSeconds;

            #region グラフ設定
            try {
                chartSpeed.Series["Speed"].Points.AddXY(xValue, double.Parse(datas[DataOrder.AirSpeed]));
                chartMpuPitch.Series["MPitch"].Points.AddXY(xValue, double.Parse(datas[DataOrder.MpuPitch]));
                chartCadence.Series["Cadence"].Points.AddXY(xValue, double.Parse(datas[DataOrder.Cadence]));
                chartRBattery.Series["RBattery"].Points.AddXY(xValue, double.Parse(datas[DataOrder.VoltageR]));
                chartLBattery.Series["LBattery"].Points.AddXY(xValue, double.Parse(datas[DataOrder.VoltageL]));
                chartMpuYaw.Series["MYaw"].Points.AddXY(xValue, double.Parse(datas[DataOrder.MpuYaw]));
                chartMpuRoll.Series["MRoll"].Points.AddXY(xValue, double.Parse(datas[DataOrder.MpuRoll]));
                chartDrugInput.Series["DrugInput"].Points.AddXY(xValue, double.Parse(datas[DataOrder.DrugR]) - double.Parse(datas[DataOrder.DrugL]));
                chartRollInput.Series["RollInput"].Points.AddXY(xValue, double.Parse(datas[DataOrder.RollInput]));
                chartPitchInput.Series["PitchInput"].Points.AddXY(xValue, double.Parse(datas[DataOrder.PitchInput]));
                datas[DataOrder.Time] = xValue.ToString();
            }
            catch (Exception) {
                return;
            }

            chartSpeed.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartSpeed.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuPitch.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartMpuPitch.ChartAreas[0].AxisX.Minimum = 0;

            chartCadence.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartCadence.ChartAreas[0].AxisX.Minimum = 0;

            chartRBattery.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartRBattery.ChartAreas[0].AxisX.Minimum = 0;

            chartLBattery.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartLBattery.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuYaw.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartMpuYaw.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuRoll.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartMpuRoll.ChartAreas[0].AxisX.Minimum = 0;

            chartRollInput.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartRollInput.ChartAreas[0].AxisX.Minimum = 0;

            chartDrugInput.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartDrugInput.ChartAreas[0].AxisX.Minimum = 0;

            chartPitchInput.ChartAreas[0].AxisX.Maximum = time.TotalSeconds;
            chartPitchInput.ChartAreas[0].AxisX.Minimum = 0;

            #endregion
        }

        private void showChartCsv(string[] datas, string data, int i) {
            #region グラフ設定
            try {
                chartSpeed.Series["Speed"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.AirSpeed]));
                chartMpuPitch.Series["MPitch"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.MpuPitch]));
                chartCadence.Series["Cadence"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.Cadence]));
                chartRBattery.Series["RBattery"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.VoltageR]));
                chartLBattery.Series["LBattery"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.VoltageL]));
                chartMpuYaw.Series["MYaw"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.MpuYaw]));
                chartMpuRoll.Series["MRoll"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.MpuRoll]));
                chartDrugInput.Series["DrugInput"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.DrugR]) - double.Parse(datas[DataOrder.DrugL]));
                chartRollInput.Series["RollInput"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.RollInput]));
                chartPitchInput.Series["PitchInput"].Points.AddXY(double.Parse(datas[DataOrder.Time]), double.Parse(datas[DataOrder.PitchInput]));
            }
            catch (Exception) {
                return;
            }

            chartSpeed.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartSpeed.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuPitch.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartMpuPitch.ChartAreas[0].AxisX.Minimum = 0;

            chartCadence.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartCadence.ChartAreas[0].AxisX.Minimum = 0;

            chartRBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartRBattery.ChartAreas[0].AxisX.Minimum = 0;

            chartLBattery.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartLBattery.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuYaw.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartMpuYaw.ChartAreas[0].AxisX.Minimum = 0;

            chartMpuRoll.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartMpuRoll.ChartAreas[0].AxisX.Minimum = 0;

            chartRollInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartRollInput.ChartAreas[0].AxisX.Minimum = 0;

            chartDrugInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartDrugInput.ChartAreas[0].AxisX.Minimum = 0;

            chartPitchInput.ChartAreas[0].AxisX.Maximum = double.Parse(datas[DataOrder.Time]);
            chartPitchInput.ChartAreas[0].AxisX.Minimum = 0;

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
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="datas">配列化した受信データ</param>
        /// <param name="i"></param>
        private void showText(string[] datas, string data, int i = 0) {
            #region textboxへの表示
            textBoxAllData.AppendText(data + Environment.NewLine);
            textBoxBatteryDataR.AppendText(datas[DataOrder.VoltageR] + Environment.NewLine);
            textBoxBatteryDataL.AppendText(datas[DataOrder.VoltageL] + Environment.NewLine);
            textBoxCadence.AppendText(datas[DataOrder.Cadence] + Environment.NewLine);
            textBoxMpuPitch.AppendText(datas[DataOrder.MpuPitch] + Environment.NewLine);
            textBoxMpuRoll.AppendText(datas[DataOrder.MpuRoll] + Environment.NewLine);
            textBoxMpuYaw.AppendText(datas[DataOrder.MpuYaw] + Environment.NewLine);
            textBoxSpeed.AppendText(datas[DataOrder.AirSpeed] + Environment.NewLine);
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
            var pathItem = new filePath();
            path = @"./Log/" + DateTime.Now.ToString("MMdd") + "TF" + fileNumber + ".csv";
            SerialProcess.writeDatas(saveData, path, true);
            AddAllPath();
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
            fileNumber++;
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
                    var data = fw.ReadLine();
                    string[] datas = null;
                    try {
                        datas = data.Split(',');
                    }
                    catch (Exception) {
                        MessageBox.Show("ファイルが空です。");
                        return;
                    }

                    // for (int i = 0; i < aveData.Count(); i++)
                    //     aveData[i] = 0.ToString();
                    if (datas.Count() == Constants.dataMembers) {
                        for (int i = 0; i < datas.Count() - 1; i++) {
                            if (string.IsNullOrEmpty(datas[i]))
                                return;
                        }
                        /*    for (int i = 0; i < datas.Count() - 1; i++) {
                                aveData[i] = ((double.Parse(aveData[i]) + Constants.averageLevel * double.Parse(datas[i])) / (Constants.averageLevel + Constants.filterLevel)).ToString();
                            }
                            datas = SerialProcess.fiterDatas(datas, aveData);*/
                        BeginInvoke(new Handler(showChart), datas, data, 0);
                        BeginInvoke(new Handler(showText), datas, data, 0);
                        BeginInvoke(new Handler(checkSteer), datas, data, 0);
                        //csv読み込みの速度向上
                        System.Threading.Thread.Sleep(100);
                    }
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

        private void AddAllPath() {
            comboBoxFiles.Items.Clear();
            string[] _path = null;
            _path = Directory.GetFiles(@"C:\Users\rocko\Dropbox\Albatross\TF電装データ", "*");
            comboBoxFiles.Items.AddRange(_path);
            //  comboBoxFiles.SelectedIndex = 0;
        }

        private void comboBoxFiles_SelectedIndexChanged(object sender, EventArgs e) {
            buttonRunCsv.Focus();
        }

        private void chartCadence_Click(object sender, EventArgs e) {
            Detail detail = new Detail();
    
            detail.Show();
        }
    }
}


