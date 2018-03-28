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

namespace AlbaAnalysis
{
    public partial class SerialForm : Form
    {
        // List<SerialEntity> saveData;
        int csvFlag = 0;
        AlbaAnalysisDataHandler _ad;
        LogWrapper<FirstEntity, SecondEntity, ThirdEntity, ForthEntity> logger;
        double counter = 1;


        public SerialForm()
        {
            //saveData = new List<SerialEntity>();
            logger = new LogWrapper<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>();
            InitializeComponent();
            _ad = new AlbaAnalysisDataHandler(bauditemsBindingSource, portNamesBindingSource, filePathBindingSource);
            initializeButtonEnable();
            buttonConnect.Focus();

            serialPort1.BaudRate = ((BaudRateEntity)(bauditemsBindingSource.Current)).rate;
            serialPort1.PortName = (string)portNamesBindingSource.Current;
            //    serialPort1.Encoding = System.Text.Encoding.GetEncoding("utf-32");

            bauditemsBindingSource.PositionChanged += (s, e) =>
            {
                serialPort1.BaudRate = ((BaudRateEntity)(bauditemsBindingSource.Current)).rate;
            };
            portNamesBindingSource.PositionChanged += (s, e) =>
            {
                serialPort1.PortName = (string)portNamesBindingSource.Current;
            };

        }


        #region データ受信
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string inputLine = null;
            try
            {
                inputLine = serialPort1.ReadLine();
            }
            catch (Exception exccc)
            {
                //         Debug.Assert(false);
                return;
            }

            //if (!SerialRoutine.ValidateInput(inputLine))
            //    return;
            var flag = inputLine.Split(',').First();
            var inputArray = inputLine.Split(',').Convert2DoubleList();

            var tmp = Constants.Third;

            if (flag.Equals(Constants.firstFlag) && inputArray.Count() - 2 == Constants.First)
                ProccessSerialDatas(inputArray, inputLine, new FirstEntity());
            else if (flag.Equals(Constants.secondFlag) && inputArray.Count() - 2 == Constants.Second)
                ProccessSerialDatas(inputArray, inputLine, new SecondEntity());
            else if (flag.Equals(Constants.thirdFlag) && inputArray.Count() - 2 == Constants.Third - 2)
                ProccessSerialDatas(inputArray, inputLine, new ThirdEntity());
            else if (flag.Equals(Constants.fourthFlag) && inputArray.Count() - 2 == Constants.Forth)
                ProccessSerialDatas(inputArray, inputLine, new ForthEntity());
        }

        private async void buttonRunCsv_Click(object sender, EventArgs e)
        {
            clearForm();
            buttonStopCsv.Enabled = true;
            buttonStopCsv.Focus();
            var _resultPath = (filePathBindingSource.Current).ToString();
            csvFlag = 0;
            await Task.Run(() =>
            {
                try
                {
                    if (string.IsNullOrEmpty(_resultPath))
                    {
                        MessageBox.Show(@"パスを選択してください");
                        return;
                    }

                    if (csvFlag == 1)
                        return;


                    textBoxAllData.Text = "csv読み込みでは一覧表示はサポートされません。";
                    var read = logger.Read(_resultPath);

                    var first = read.Item1.GetCopiedList();
                    var second = read.Item2.GetCopiedList();
                    var third = read.Item3.GetCopiedList();
                    var fourth = read.Item4.GetCopiedList();

                    while (first.Count() != 0 && second.Count() != 0 && third.Count() != 0 && fourth.Count() != 0)
                    {
                        var result = _ad.PopRecord(first, second, third, fourth);
                        if (result.Item1 != null)
                            InvokeControls(result.Item1, String.Empty);

                        //csv読み込みの速度向上
                        System.Threading.Thread.Sleep(45);
                    }
                }
                catch (Exception)
                {
                    Debug.Assert(false);
                }
                MessageBox.Show("ファイルの読み込みを終了しました。");
            });
        }
        #endregion

        #region 画面描画
        private void ProccessSerialDatas(List<double> inputList, string inputLine, FirstEntity fe)
        {
            SerialRoutine.Copy2Entity(fe, inputList);
            logger.Append(fe);
            InvokeControls(fe, inputLine);
        }

        private void ProccessSerialDatas(List<double> inputList, string inputLine, SecondEntity se)
        {
            SerialRoutine.Copy2Entity(se, inputList);
            logger.Append(se);
            try
            {
                InvokeControls(se, inputLine);
            }
            catch (Exception e) { }
        }

        private void ProccessSerialDatas(List<double> inputList, string inputLine, ThirdEntity te)
        {
            SerialRoutine.Copy2Entity(te, inputList);
            logger.Append(te);
            InvokeControls(te, inputLine);
        }

        private void ProccessSerialDatas(List<double> inputList, string inputLine, ForthEntity fe)
        {
            SerialRoutine.Copy2Entity(fe, inputList);
            logger.Append(fe);
            InvokeControls(fe, inputLine);
        }

        #region Invoke Controls
        void InvokeControls(FirstEntity se, string inputLine)
        {
            try
            {
                Invoke((Action)(() => plotChart(se)));
                Invoke((Action)(() => appendText(se, inputLine)));
            }
            catch (TargetInvocationException ex) { }
        }

        void InvokeControls(SecondEntity se, string inputLine)
        {
            try
            {
                Invoke((Action)(() => plotChart(se)));
                Invoke((Action)(() => appendText(se, inputLine)));
            }
            catch (TargetInvocationException exc) { }
        }

        void InvokeControls(ThirdEntity se, string inputLine)
        {
            Invoke((Action)(() => plotChart(se)));
            Invoke((Action)(() => checkSteer(se)));
        }

        void InvokeControls(ForthEntity se, string inputLine)
        {
            try
            {
                Invoke((Action)(() => plotChart(se)));
                Invoke((Action)(() => appendText(se, inputLine)));
            }
            catch (TargetInvocationException e) { }
        }
        #endregion

        #region Plot Chart
        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(FirstEntity se)
        {
            counter = counter + 1;
            //   chartSpeed.AddXY(se.AirSpeedTime, se.AirSpeed);
            AirSpeedChart.Series[0].Points.AddXY(se.AirSpeedTime, se.AirSpeed);
            //     chartSpeed.Series[0].Points.AddXY(counter, counter % 10);
            CadenceChart.Series[0].Points.AddXY(se.CadenceTime, se.Cadence);
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(SecondEntity se)
        {
            try
            {
                MpuPitchChart.Series[0].Points.AddXY(se.MpuTime, se.MpuPitch);
                MpuYawChart.Series[0].Points.AddXY(se.MpuTime, se.MpuYaw);
                MpuRollChart.Series[0].Points.AddXY(se.MpuTime, se.MpuRoll);
            }
            catch (Exception e) { }
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(ThirdEntity se)
        {
            RollInputChart.Series[0].Points.AddXY(se.ControlTime, se.RollInput);
            PitchInputChart.Series[0].Points.AddXY(se.ControlTime, se.PitchInput);
            DrugInputChart.Series[0].Points.AddXY(se.ControlTime, se.DrugL + se.DrugR);
        }

        /// <summary>
        /// 受信データに対してグラフを出力します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void plotChart(ForthEntity se)
        {
            RBatteryChart.Series[0].Points.AddXY(se.ControlTime, se.VoltageR);
            LBatteryChart.Series[0].Points.AddXY(se.ControlTime, se.VoltageL);
        }
        #endregion

        #region Append Text
        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(FirstEntity se, string allInput)
        {
            textBoxAllData.AppendText(allInput + Environment.NewLine);
            textBoxSpeed.AppendText(se.AirSpeed + Environment.NewLine);
            textBoxCadence.AppendText(se.Cadence + Environment.NewLine);
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(SecondEntity se, string allInput)
        {
            textBoxAllData.AppendText(allInput + Environment.NewLine);
            textBoxMpuPitch.AppendText(se.MpuPitch + Environment.NewLine);
            textBoxMpuRoll.AppendText(se.MpuRoll + Environment.NewLine);
            textBoxMpuYaw.AppendText(se.MpuYaw + Environment.NewLine);
        }

        /// <summary>
        /// 受信データをtextboxに表示します
        /// </summary>
        /// <param name="se">配列化した受信データ</param>
        /// <param name="i"></param>
        private void appendText(ForthEntity se, string allInput)
        {
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
        private void checkSteer(ThirdEntity se)
        {
            // throw new Exception("以下の1との比較はequalsをオーバーライドする必要あり");
            buttonRDrug.BackColor = se.DrugR == 1.0 ? Color.LightCoral : Color.LightGray;
            buttonLDrug.BackColor = se.DrugL == 1.0 ? Color.LightCoral : Color.LightGray;
            rollVerticalProgressBar.SetValue(se.RollInput);
            pitchVerticalProgressBar.SetValue(se.PitchInput);
        }
        #endregion

        #region クリア処理
        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart()
        {
            var fls = typeof(SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("AlbaChart"));
            foreach (var fi in fls)
                ((Chart)fi.GetValue(this)).Series[0].Points.Clear();
        }

        /// <summary>
        /// Nextボタンを押したときにtextBoxをクリアします
        /// </summary>
        void ClearTextBox()
        {
            var fls = typeof(AlbaAnalysis.SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("TextBox"));
            foreach (var f in fls)
                ((TextBox)f.GetValue(this)).Clear();
        }

        private void clearForm()
        {
            ClearTextBox();
            ClearChart();
            ResetButton();
            logger.Clear();
        }

        /// <summary>
        /// 操舵入力表示用のボタンをNextButtonを押したときに色を戻します
        /// </summary>
        private void ResetButton()
        {
            buttonRDrug.BackColor = Color.LightGray;
            buttonLDrug.BackColor = Color.LightGray;
        }
        #endregion

        #region control event
        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                return;

            try
            {
                serialPort1.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"利用可能なシリアルポートがありません");
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            ConnectButtonEnable();
            buttonClose.Focus();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            var commentForm = new AdditionalFileNameDialog();
            serialPort1.DataReceived -= serialPort1_DataReceived;
            commentForm.ShowDialog();
            SaveAllCharts(commentForm.GetComment());
            logger.Export(Constants.pathBase + "TF" + DateTime.Now.ToString("MMdd_hhmm") + commentForm.GetComment());
            _ad.resetFileList();
            serialPort1.DiscardInBuffer();
            serialPort1.Close();
            closeButtonEnable();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            clearForm();
            buttonConnect.Focus();
        }

        private void buttonStopCsv_Click(object sender, EventArgs e)
        {
            csvFlag = 1;
            buttonRunCsv.Focus();
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e)
        {
            if (csvFlag == 0)
            {
                MessageBox.Show("ファイルの再生を終了してください。");
                return;
            }
            var p = Process.Start("excel", ((filePath)(filePathBindingSource.Current)).pathName);
            p.WaitForExit();
        }

        private void comboBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRunCsv.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var config = new ConfigDialog())
            {
                config.ShowDialog();
            }
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("serial通信を切断してください。");
                e.Cancel = true;
                return;
            }
        }
        #endregion

        #region enable
        private void initializeButtonEnable()
        {
            buttonNext.Enabled = false;
            buttonClose.Enabled = false;
            buttonStopCsv.Enabled = false;
            buttonRDrug.Enabled = false;
            buttonLDrug.Enabled = false;
            buttonConnect.Enabled = true;
        }

        private void ConnectButtonEnable()
        {
            buttonConnect.Enabled = false;
            buttonClose.Enabled = true;
            buttonNext.Enabled = false;
            buttonRunCsv.Enabled = false;
            buttonOpenCsv.Enabled = false;
        }

        private void closeButtonEnable()
        {
            buttonConnect.Enabled = true;
            buttonNext.Enabled = true;
            buttonClose.Enabled = false;
            buttonNext.Enabled = true;
            buttonRunCsv.Enabled = true;
            buttonOpenCsv.Enabled = true;
        }
        #endregion

        #region chart Method
        private void SaveAllCharts(string comment)
        {
            var nowTime = DateTime.Now.ToString("MMdd_hhmm");
            try
            {
                System.IO.Directory.CreateDirectory(@"../../../Log/chart/" + nowTime + comment);
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
            var fls = typeof(SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("Chart"));
            foreach (var f in fls)
                ((Chart)f.GetValue(this)).SaveImage(@"../../../Log/chart/" + nowTime + comment + "/" + ((Chart)f.GetValue(this)).Name + ".jpeg", ChartImageFormat.Jpeg);
        }
        #endregion
    }
}