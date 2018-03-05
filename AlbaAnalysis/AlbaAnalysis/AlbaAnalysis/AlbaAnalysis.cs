﻿using System;
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

namespace AlbaAnalysis {

    delegate void Handler(SerialEntity strs, string str, InputEnum ie);

    public partial class SerialForm : Form {
        List<SerialEntity> saveData;
        int csvFlag = 0;
        AlbaAnalysisDataHandler _ad;
        DateTime start;

        List<SerialEntity> SerialDataList;

        public SerialForm() {
            saveData = new List<SerialEntity>();
            InitializeComponent();
            _ad = new AlbaAnalysisDataHandler(bauditemsBindingSource, portNamesBindingSource, filePathBindingSource);
            initializeButtonEnable();
            buttonConnect.Focus();
            SerialDataList = new List<SerialEntity>();
            foreach (var i in Enumerable.Range(0, 500000)) {
                SerialDataList.Add(new SerialEntity());
            }
            setChartDispName(new SerialEntity());

            bauditemsBindingSource.PositionChanged += (s, e) => {
                serialPort1.BaudRate = ((BaudRateEntity)(bauditemsBindingSource.Current)).rate;
            };
            portNamesBindingSource.PositionChanged += (s, e) => {
                serialPort1.PortName = ((portNames)portNamesBindingSource.Current).portName;
            };
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Dispose();
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = null;
            var sw = new Stopwatch();
            sw.Start();
            try {
                data = serialPort1.ReadLine();
            } catch (Exception) {
                Debug.Assert(false);
                return;
            }
            sw.Stop();
            if (sw.ElapsedMilliseconds > 5000)
                serialPort1.DiscardInBuffer();

            var dataArray = SerialRoutine.validateInput(data).ToArray();

            if (dataArray.First().Equals("con") && dataArray.Count() == Constants.controlDataNum + 2)
                ProccessSerialDatas(InputEnum.control, dataArray, data);
            else if (dataArray.First().Equals("inp") && dataArray.Count() == Constants.InputDataNum + 1)
                ProccessSerialDatas(InputEnum.input, dataArray, data);
            else if (dataArray.First().Equals("mpu") && dataArray.Count() == Constants.MpuDataNum + 1)
                ProccessSerialDatas(InputEnum.mpu, dataArray, data);
            else if (dataArray.First().Equals("kei") && dataArray.Count() == Constants.KeikiDataNum + 1)
                ProccessSerialDatas(InputEnum.keiki, dataArray, data);
        }

        private void ProccessSerialDatas(InputEnum ie, string[] datas, string data) {
            var serialEntity = new SerialEntity();
            SerialRoutine.copyDatas2Entity(serialEntity, datas, ie);
            var end = DateTime.Now;
            var time = end - start;
            serialEntity.Time = time.TotalSeconds.ToString();

            var tempSerial = serialEntity.Clone();
            saveData.Add(tempSerial);
            InvokeControls(tempSerial, data, ie);
        }

        /// <summary>
        /// 操舵入力に対応してボタンの色を変化させます
        /// </summary>
        /// <param name="data">配列化した受信データ</param>
        /// <param name="i"></param>
        private void checkSteer(SerialEntity datas, string data, InputEnum ie) {
            if (InputEnum.input != ie)
                return;

            buttonRDrug.BackColor = datas.DrugR == 1.ToString() ? Color.LightCoral : Color.LightGray;
            buttonLDrug.BackColor = datas.DrugL == 1.ToString() ? Color.LightCoral : Color.LightGray;
            rollVerticalProgressBar.SetValue(datas.ErebonRInput);
            pitchVerticalProgressBar.SetValue(datas.ErebonLInput);
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
                    chartSpeed.AddXY(datas.Time, datas.AirSpeed);
                    chartCadence.AddXY(datas.Time, datas.Cadence);
                } else if (InputEnum.control == ie) {
                    chartRBattery.AddXY(datas.Time, datas.VoltageR);
                    chartLBattery.AddXY(datas.Time, datas.VoltageL);
                } else if (InputEnum.mpu == ie) {
                    chartMpuPitch.AddXY(datas.Time, datas.MpuPitch);
                    chartMpuYaw.AddXY(datas.Time, datas.MpuYaw);
                    chartMpuRoll.AddXY(datas.Time, datas.MpuRoll);
                } else if (InputEnum.input == ie) {
                    if (!double.TryParse(datas.DrugR, out var Dr) || !double.TryParse(datas.DrugR, out var Dl))
                        return;

                    chartDrugInput.AddXY(datas.Time, (Dr - Dl).ToString());
                    chartRollInput.AddXY(datas.Time, datas.ErebonRInput);
                    chartPitchInput.AddXY(datas.Time, datas.ErebonLInput);
                }
            } catch (Exception) {
                Debug.Assert(false);
                return;
            }
            //});
            #endregion
        }

        /// <summary>
        /// Nextボタンを押したときにグラフをクリアします
        /// </summary>
        void ClearChart() {
            var fls = typeof(SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("AlbaChart"));
            foreach (var fi in fls)
                ((Chart)fi.GetValue(this)).Series[0].Points.Clear();
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
            } else if (InputEnum.control == ie) {
                textBoxBatteryDataR.AppendText(datas.VoltageR + Environment.NewLine);
                textBoxBatteryDataL.AppendText(datas.VoltageL + Environment.NewLine);
            } else if (InputEnum.mpu == ie) {
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
            var fls = typeof(AlbaAnalysis.SerialForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.FieldType.Name.Equals("TextBox"));
            foreach (var f in fls)
                ((TextBox)f.GetValue(this)).Clear();
        }

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
            start = DateTime.Now;
        }

        private void buttonClose_Click_1(object sender, EventArgs e) {
            var commentForm = new AdditionalFileNameDialog();
            serialPort1.DataReceived -= serialPort1_DataReceived;
            commentForm.ShowDialog();
            SaveAllCharts(commentForm.GetComment());
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
            SerialEntity lastSerialEntity = null;
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
                        var csvdatas = SerialRoutine.validateInput(csvLine);
                        if (csvdatas.Count() != 25)
                            continue;
                        var serialEntity = new SerialEntity();
                        SerialRoutine.CopyASCsv(serialEntity, csvdatas.ToArray());
                        if (lastSerialEntity == null) {
                            lastSerialEntity = serialEntity.Clone();
                            continue;
                        }
                        var targetEnum = SerialRoutine.GetTargetEntity(serialEntity, lastSerialEntity);
                        if (targetEnum == InputEnum.notAccepted)
                            continue;
                        lastSerialEntity = serialEntity.Clone();
                        InvokeControls(serialEntity, csvLine, targetEnum);

                        //csv読み込みの速度向上
                        System.Threading.Thread.Sleep(45);
                    }
                } catch (Exception) {
                    Debug.Assert(false);
                }
                MessageBox.Show("ファイルの読み込みを終了しました。");
            });
        }

        void InvokeControls(SerialEntity se, string dataStr, InputEnum ie) {
            try {
                Invoke(new Handler(showChart), se, dataStr, ie);
                Invoke(new Handler(showText), se, dataStr, ie);
                Invoke(new Handler(checkSteer), se, dataStr, ie);
            } catch (ObjectDisposedException) {
            }
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

        private void button1_Click(object sender, EventArgs e) {
            using (var config = new ConfigDialog()) {
                config.ShowDialog();
            }
        }

        private void setChartDispName(SerialEntity se) {
            chartCadence.SetDataPropertyName(nameof(se.Cadence));
            chartMpuPitch.SetDataPropertyName(nameof(se.MpuPitch));
            chartMpuRoll.SetDataPropertyName(nameof(se.MpuRoll));
            chartMpuYaw.SetDataPropertyName(nameof(se.MpuYaw));
            chartSpeed.SetDataPropertyName(nameof(se.AirSpeed));
            chartRBattery.SetDataPropertyName(nameof(se.VoltageR));
            chartLBattery.SetDataPropertyName(nameof(se.VoltageL));
            chartRollInput.SetDataPropertyName(nameof(se.ErebonRInput));
            chartPitchInput.SetDataPropertyName(nameof(se.ErebonLInput));
            chartDrugInput.SetDataPropertyName(nameof(se.DrugL));//ドラッグラダーのchartはここでだけLとして識別する
        }
    }
}