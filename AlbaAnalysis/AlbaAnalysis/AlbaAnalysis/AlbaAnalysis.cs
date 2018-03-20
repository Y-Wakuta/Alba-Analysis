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
using System.Reflection;

using AlbaAnalysis.Library;

namespace AlbaAnalysis {
    public partial class SerialForm : Form {
       // List<SerialEntity> saveData;
        int csvFlag = 0;
        AlbaAnalysisDataHandler _ad;
        LogWrapper<FirstEntity, SecondEntity, ThirdEntity, ForthEntity> logger;


        public SerialForm() {
            //saveData = new List<SerialEntity>();
            logger = new LogWrapper<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>();
            InitializeComponent();
            _ad = new AlbaAnalysisDataHandler(bauditemsBindingSource, portNamesBindingSource, filePathBindingSource);
            initializeButtonEnable();
            buttonConnect.Focus();

            bauditemsBindingSource.PositionChanged += (s, e) => {
                serialPort1.BaudRate = ((BaudRateEntity)(bauditemsBindingSource.Current)).rate;
            };
            portNamesBindingSource.PositionChanged += (s, e) => {
                serialPort1.PortName = ((portNames)portNamesBindingSource.Current).portName;
            };
        }


        #region データ受信
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string inputLine = null;
                try {
                inputLine = serialPort1.ReadLine();
            } catch (Exception) {
                Debug.Assert(false);
                return;
            }

            if (!SerialRoutine.ValidateInput(inputLine))
                return;

            var inputArray = inputLine.Split(',').Convert2DoubleList();

            if (inputArray.First().Equals("$1") && inputArray.Count() == Constants.First)
                ProccessSerialDatas(inputArray, inputLine);
            else if (inputArray.First().Equals("$2") && inputArray.Count() == Constants.Second)
                ProccessSerialDatas(inputArray, inputLine);
            else if (inputArray.First().Equals("$3") && inputArray.Count() == Constants.Third)
                ProccessSerialDatas(inputArray, inputLine);
            else if (inputArray.First().Equals("$4") && inputArray.Count() == Constants.Forth)
                ProccessSerialDatas(inputArray, inputLine);
        }

        private async void buttonRunCsv_Click(object sender, EventArgs e) {
            clearForm();
            buttonStopCsv.Enabled = true;
            buttonStopCsv.Focus();
            var _resultPath = (filePathBindingSource.Current).ToString();
            csvFlag = 0;
            await Task.Run(() => {
                try {
                    if (string.IsNullOrEmpty(_resultPath)) {
                        MessageBox.Show(@"パスを選択してください");
                        return;
                    }
                    foreach (var csvLine in File.ReadAllLines(_resultPath)) {
                        if (csvFlag == 1)
                            return;

                        if (!SerialRoutine.ValidateInput(csvLine))
                            return;

                        var csvInputArray = csvLine.Split(',').Convert2DoubleList();
                        var serialEntity = new SerialEntity();
                        SerialRoutine.Copy2Entity(serialEntity, csvInputArray.ToArray());
                        InvokeControls(serialEntity, csvLine);

                        //csv読み込みの速度向上
                        System.Threading.Thread.Sleep(45);
                    }
                } catch (Exception) {
                    Debug.Assert(false);
                }
                MessageBox.Show("ファイルの読み込みを終了しました。");
            });
        }
        #endregion

        #region 画面描画
        private void ProccessSerialDatas(List<double> inputList, string inputLine) {
            SerialRoutine.copyDatas2Entity(serialEntity, inputList);

            throw new Exception("saveData周りは専用のクラスを作成しよう");

            var tempSerial = serialEntity.Clone();
            saveData.Add(tempSerial);
            InvokeControls(tempSerial, inputLine);
        }

        #region Invoke Controls
        void InvokeControls(FirstEntity se, string inputLine) {
            Invoke((Action)(() => plotChart(se, inputLine)));
            Invoke((Action)(() => appendText(se, inputLine)));
        }

        void InvokeControls(SecondEntity se, string inputLine) {
            Invoke((Action)(() => plotChart(se, inputLine)));
            Invoke((Action)(() => appendText(se, inputLine)));
        }

        void InvokeControls(ThirdEntity se, string inputLine) {
            Invoke((Action)(() => plotChart(se, inputLine)));
            Invoke((Action)(() => appendText(se, inputLine)));
            Invoke((Action)(() => checkSteer(se, inputLine)));
        }

        void InvokeControls(ForthEntity se, string inputLine) {
            Invoke((Action)(() => plotChart(se, inputLine)));
            Invoke((Action)(() => appendText(se, inputLine)));
        }
        #endregion

        #region Plot Chart
        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(FirstEntity se, string inputLine) {
            chartSpeed.AddXY(se.AirSpeedTime, se.AirSpeed);
            chartCadence.AddXY(se.CadenceTime, se.Cadence);
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(SecondEntity se, string inputLine) {
            chartMpuPitch.AddXY(se.MpuTime, se.MpuPitch);
            chartMpuYaw.AddXY(se.MpuTime, se.MpuYaw);
            chartMpuRoll.AddXY(se.MpuTime, se.MpuRoll);
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(ThirdEntity se, string inputLine) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(ForthEntity se, string inputLine) {
            chartRBattery.AddXY(se.ControlTime, se.VoltageR);
            chartLBattery.AddXY(se.ControlTime, se.VoltageL);
        }
        #endregion

        #region Append Text
        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(FirstEntity se, string allInput) {
            textBoxAllData.AppendText(allInput + Environment.NewLine);
            textBoxSpeed.AppendText(se.AirSpeed + Environment.NewLine);
            textBoxCadence.AppendText(se.Cadence + Environment.NewLine);
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(SecondEntity se, string allInput) {
            textBoxAllData.AppendText(allInput + Environment.NewLine);
            textBoxMpuPitch.AppendText(se.MpuPitch + Environment.NewLine);
            textBoxMpuRoll.AppendText(se.MpuRoll + Environment.NewLine);
            textBoxMpuYaw.AppendText(se.MpuYaw + Environment.NewLine);
        }

        private void appendText(ThirdEntity se, string allInput) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(ForthEntity se, string allInput) {
            textBoxAllData.AppendText(allInput + Environment.NewLine);
            textBoxBatteryDataR.AppendText(se.VoltageR + Environment.NewLine);
            textBoxBatteryDataL.AppendText(se.VoltageL + Environment.NewLine);
        }
        #endregion

        /// <summary>
        /// 操舵入力に対応してボタンの色を変化させます
        /// </summary>
        /// <param name="inputLine">配列化した受信データ</param>
        /// <param name="i"></param>
        private void checkSteer(ThirdEntity se, string inputLine) {
            throw new Exception("以下の1との比較はequalsをオーバーライドする必要あり");
            buttonRDrug.BackColor = se.DrugR == 1 ? Color.LightCoral : Color.LightGray;
            buttonLDrug.BackColor = se.DrugL == 1 ? Color.LightCoral : Color.LightGray;
            rollVerticalProgressBar.SetValue(se.RollInput);
            pitchVerticalProgressBar.SetValue(se.PitchInput);
        }
        #endregion

        #region クリア処理
        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart() {
            var fls = typeof(SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("AlbaChart"));
            foreach (var fi in fls)
                ((Chart)fi.GetValue(this)).Series[0].Points.Clear();
        }

        /// <summary>
        /// Nextボタンを押したときにtextBoxをクリアします
        /// </summary>
        void ClearTextBox() {
            var fls = typeof(AlbaAnalysis.SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("TextBox"));
            foreach (var f in fls)
                ((TextBox)f.GetValue(this)).Clear();
        }

        private void clearForm() {
            ClearTextBox();
            ClearChart();
            ResetButton();
            saveData.Clear();
        }

        /// <summary>
        /// 操舵入力表示用のボタンをNextButtonを押したときに色を戻します
        /// </summary>
        private void ResetButton() {
            buttonRDrug.BackColor = Color.LightGray;
            buttonLDrug.BackColor = Color.LightGray;
        }
        #endregion

        #region control event
        private void buttonConnect_Click_1(object sender, EventArgs e) {
            if (serialPort1.IsOpen)
                return;

            try {
                serialPort1.Open();
            } catch (Exception) {
                MessageBox.Show(@"利用可能なシリアルポートがありません");
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            ConnectButtonEnable();
            buttonClose.Focus();
        }

        private void buttonClose_Click_1(object sender, EventArgs e) {
            var commentForm = new AdditionalFileNameDialog();
            serialPort1.DataReceived -= serialPort1_DataReceived;
            commentForm.ShowDialog();
            SaveAllCharts(commentForm.GetComment());
            logger.Export(_ad.pathBase + "TF" + DateTime.Now.ToString("MMdd_hhmm") + commentForm.GetComment());
            SerialRoutine.writeDatas(saveData, _ad.pathBase + "TF" + DateTime.Now.ToString("MMdd_hhmm") + commentForm.GetComment() + ".csv", true);
            _ad.resetFileList();
            serialPort1.DiscardInBuffer();
            serialPort1.Close();
            closeButtonEnable();
        }

        private void buttonNext_Click_1(object sender, EventArgs e) {
            clearForm();
            buttonConnect.Focus();
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

        private void button1_Click(object sender, EventArgs e) {
            using (var config = new ConfigDialog()) {
                config.ShowDialog();
            }
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Dispose();
            serialPort1.Close();
        }
        #endregion

        #region enable
        private void initializeButtonEnable() {
            buttonNext.Enabled = false;
            buttonClose.Enabled = false;
            buttonStopCsv.Enabled = false;
            buttonRDrug.Enabled = false;
            buttonLDrug.Enabled = false;
            buttonConnect.Enabled = true;
        }

        private void ConnectButtonEnable() {
            buttonConnect.Enabled = false;
            buttonClose.Enabled = true;
            buttonNext.Enabled = false;
            buttonRunCsv.Enabled = false;
            buttonOpenCsv.Enabled = false;
        }

        private void closeButtonEnable() {
            buttonConnect.Enabled = true;
            buttonNext.Enabled = true;
            buttonClose.Enabled = false;
            buttonNext.Enabled = true;
            buttonRunCsv.Enabled = true;
            buttonOpenCsv.Enabled = true;
        }
        #endregion

        #region chart Method
        private void SaveAllCharts(string comment) {
            var nowTime = DateTime.Now.ToString("MMdd_hhmm");
            try {
                System.IO.Directory.CreateDirectory(@"../../../Log/chart/" + nowTime + comment);
            } catch (IOException io) {
                MessageBox.Show(io.Message);
            }
            var fls = typeof(SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("Chart"));
            foreach (var f in fls)
                ((Chart)f.GetValue(this)).SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + ((Chart)f.GetValue(this)).Name + ".jpeg", ChartImageFormat.Jpeg);
        }
        #endregion
    }
}