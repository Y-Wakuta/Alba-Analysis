﻿namespace AlbaAnalysis {
    partial class SerialForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBoxAllData = new System.Windows.Forms.GroupBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.portNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxSerialConfig = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStopCsv = new System.Windows.Forms.Button();
            this.buttonOpenCsv = new System.Windows.Forms.Button();
            this.buttonRunCsv = new System.Windows.Forms.Button();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.filePathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.bauditemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartCadence = new AlbaAnalysis.AlbaChart();
            this.chartSpeed = new AlbaAnalysis.AlbaChart();
            this.chartMpuPitch = new AlbaAnalysis.AlbaChart();
            this.chartMpuYaw = new AlbaAnalysis.AlbaChart();
            this.chartMpuRoll = new AlbaAnalysis.AlbaChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartLBattery = new AlbaAnalysis.AlbaChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chartRBattery = new AlbaAnalysis.AlbaChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rollVerticalProgressBar = new AlbaAnalysis.VerticalProgressBar();
            this.chartRollInput = new AlbaAnalysis.AlbaChart();
            this.chartPitchInput = new AlbaAnalysis.AlbaChart();
            this.chartDrugInput = new AlbaAnalysis.AlbaChart();
            this.pitchVerticalProgressBar = new AlbaAnalysis.VerticalProgressBar();
            this.buttonRDrug = new System.Windows.Forms.Button();
            this.buttonLDrug = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBatteryDataR = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCadence = new System.Windows.Forms.TextBox();
            this.textBoxMpuYaw = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMpuRoll = new System.Windows.Forms.TextBox();
            this.label_mpuData = new System.Windows.Forms.Label();
            this.textBoxMpuPitch = new System.Windows.Forms.TextBox();
            this.label_batteryDataR = new System.Windows.Forms.Label();
            this.label_batteryDataL = new System.Windows.Forms.Label();
            this.textBoxBatteryDataL = new System.Windows.Forms.TextBox();
            this.groupBoxAllData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNamesBindingSource)).BeginInit();
            this.groupBoxSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuRoll)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLBattery)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRBattery)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRollInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPitchInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrugInput)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 2500000;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllData.Location = new System.Drawing.Point(3, 24);
            this.textBoxAllData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.ReadOnly = true;
            this.textBoxAllData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllData.Size = new System.Drawing.Size(1155, 311);
            this.textBoxAllData.TabIndex = 27;
            // 
            // groupBoxAllData
            // 
            this.groupBoxAllData.AutoSize = true;
            this.groupBoxAllData.Controls.Add(this.textBoxAllData);
            this.groupBoxAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAllData.Location = new System.Drawing.Point(3, 146);
            this.groupBoxAllData.Name = "groupBoxAllData";
            this.groupBoxAllData.Size = new System.Drawing.Size(1161, 338);
            this.groupBoxAllData.TabIndex = 27;
            this.groupBoxAllData.TabStop = false;
            this.groupBoxAllData.Text = "受信データ";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DataSource = this.portNamesBindingSource;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(6, 38);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(348, 29);
            this.comboBoxPort.TabIndex = 2;
            // 
            // portNamesBindingSource
            // 
            this.portNamesBindingSource.DataSource = typeof(AlbaAnalysis.Entity.portNames);
            // 
            // groupBoxSerialConfig
            // 
            this.groupBoxSerialConfig.AutoSize = true;
            this.groupBoxSerialConfig.Controls.Add(this.button1);
            this.groupBoxSerialConfig.Controls.Add(this.buttonStopCsv);
            this.groupBoxSerialConfig.Controls.Add(this.buttonOpenCsv);
            this.groupBoxSerialConfig.Controls.Add(this.buttonRunCsv);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxFiles);
            this.groupBoxSerialConfig.Controls.Add(this.buttonNext);
            this.groupBoxSerialConfig.Controls.Add(this.buttonClose);
            this.groupBoxSerialConfig.Controls.Add(this.buttonConnect);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxBaud);
            this.groupBoxSerialConfig.Controls.Add(this.comboBoxPort);
            this.groupBoxSerialConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSerialConfig.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSerialConfig.Name = "groupBoxSerialConfig";
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(1161, 137);
            this.groupBoxSerialConfig.TabIndex = 13;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1046, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStopCsv
            // 
            this.buttonStopCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStopCsv.Location = new System.Drawing.Point(766, 77);
            this.buttonStopCsv.Name = "buttonStopCsv";
            this.buttonStopCsv.Size = new System.Drawing.Size(134, 52);
            this.buttonStopCsv.TabIndex = 37;
            this.buttonStopCsv.Text = "Stop Csv";
            this.buttonStopCsv.UseVisualStyleBackColor = true;
            this.buttonStopCsv.Click += new System.EventHandler(this.buttonStopCsv_Click);
            // 
            // buttonOpenCsv
            // 
            this.buttonOpenCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOpenCsv.Location = new System.Drawing.Point(905, 77);
            this.buttonOpenCsv.Name = "buttonOpenCsv";
            this.buttonOpenCsv.Size = new System.Drawing.Size(135, 52);
            this.buttonOpenCsv.TabIndex = 36;
            this.buttonOpenCsv.Text = "Open Csv";
            this.buttonOpenCsv.UseVisualStyleBackColor = true;
            this.buttonOpenCsv.Click += new System.EventHandler(this.buttonOpenCsv_Click);
            // 
            // buttonRunCsv
            // 
            this.buttonRunCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRunCsv.Location = new System.Drawing.Point(628, 77);
            this.buttonRunCsv.Name = "buttonRunCsv";
            this.buttonRunCsv.Size = new System.Drawing.Size(133, 52);
            this.buttonRunCsv.TabIndex = 35;
            this.buttonRunCsv.Text = "Run Csv";
            this.buttonRunCsv.UseVisualStyleBackColor = true;
            this.buttonRunCsv.Click += new System.EventHandler(this.buttonRunCsv_Click);
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.DataSource = this.filePathBindingSource;
            this.comboBoxFiles.DisplayMember = "pathName";
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(6, 91);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(615, 29);
            this.comboBoxFiles.TabIndex = 34;
            this.comboBoxFiles.ValueMember = "pathName";
            this.comboBoxFiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiles_SelectedIndexChanged);
            // 
            // filePathBindingSource
            // 
            this.filePathBindingSource.DataSource = typeof(AlbaAnalysis.Entity.filePath);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(1009, 19);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(134, 52);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(869, 19);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(134, 52);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(731, 19);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(133, 52);
            this.buttonConnect.TabIndex = 29;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click_1);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DataSource = this.bauditemsBindingSource;
            this.comboBoxBaud.DisplayMember = "NAME";
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(370, 38);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(356, 29);
            this.comboBoxBaud.TabIndex = 3;
            this.comboBoxBaud.ValueMember = "RATE";
            // 
            // bauditemsBindingSource
            // 
            this.bauditemsBindingSource.DataSource = typeof(AlbaAnalysis.Entity.BaudRateEntity);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 490);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2544, 897);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2536, 862);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Core";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.52381F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.47619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 745F));
            this.tableLayoutPanel2.Controls.Add(this.chartCadence, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartSpeed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chartMpuPitch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartMpuYaw, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartMpuRoll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23365F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.76635F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2530, 856);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // chartCadence
            // 
            this.chartCadence.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LabelStyle.Format = "#.#";
            chartArea1.AxisX.Maximum = 0.1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Cadence[/m]";
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 94F;
            this.chartCadence.ChartAreas.Add(chartArea1);
            this.chartCadence.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.476309F;
            legend1.Position.Width = 20F;
            legend1.Position.X = 79F;
            legend1.Position.Y = 2F;
            this.chartCadence.Legends.Add(legend1);
            this.chartCadence.Location = new System.Drawing.Point(1785, 431);
            this.chartCadence.Margin = new System.Windows.Forms.Padding(1);
            this.chartCadence.Name = "chartCadence";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Cadence";
            this.chartCadence.Series.Add(series1);
            this.chartCadence.Size = new System.Drawing.Size(744, 424);
            this.chartCadence.TabIndex = 17;
            this.chartCadence.Text = "Cadence";
            // 
            // chartSpeed
            // 
            this.chartSpeed.BackColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.LabelStyle.Format = "#.#";
            chartArea2.AxisX.Maximum = 0.1D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Maximum = 10D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Speed[m/s]";
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 94F;
            this.chartSpeed.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel2.SetColumnSpan(this.chartSpeed, 2);
            this.chartSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 9.476309F;
            legend2.Position.Width = 20F;
            legend2.Position.X = 79F;
            legend2.Position.Y = 2F;
            this.chartSpeed.Legends.Add(legend2);
            this.chartSpeed.Location = new System.Drawing.Point(885, 1);
            this.chartSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.chartSpeed.Name = "chartSpeed";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.LegendText = "Speed";
            series2.Name = "Speed";
            this.chartSpeed.Series.Add(series2);
            this.chartSpeed.Size = new System.Drawing.Size(1644, 428);
            this.chartSpeed.TabIndex = 18;
            this.chartSpeed.Text = "chart6";
            title1.Name = "Speed";
            this.chartSpeed.Titles.Add(title1);
            // 
            // chartMpuPitch
            // 
            this.chartMpuPitch.BackColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            chartArea3.AxisX.LabelStyle.Format = "#.#";
            chartArea3.AxisX.Maximum = 0.1D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "MPitch";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Meiryo UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 94F;
            this.chartMpuPitch.ChartAreas.Add(chartArea3);
            this.chartMpuPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 9.476309F;
            legend3.Position.Width = 20F;
            legend3.Position.X = 79F;
            legend3.Position.Y = 2F;
            this.chartMpuPitch.Legends.Add(legend3);
            this.chartMpuPitch.Location = new System.Drawing.Point(1, 431);
            this.chartMpuPitch.Margin = new System.Windows.Forms.Padding(1);
            this.chartMpuPitch.Name = "chartMpuPitch";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "MPitch";
            this.chartMpuPitch.Series.Add(series3);
            this.chartMpuPitch.Size = new System.Drawing.Size(882, 424);
            this.chartMpuPitch.TabIndex = 20;
            this.chartMpuPitch.Text = "Mpitch";
            // 
            // chartMpuYaw
            // 
            this.chartMpuYaw.BackColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.LabelStyle.Format = "#.#";
            chartArea4.AxisX.Maximum = 0.1D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "MpuYaw";
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 94F;
            this.chartMpuYaw.ChartAreas.Add(chartArea4);
            this.chartMpuYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 9.476309F;
            legend4.Position.Width = 20F;
            legend4.Position.X = 79F;
            legend4.Position.Y = 2F;
            this.chartMpuYaw.Legends.Add(legend4);
            this.chartMpuYaw.Location = new System.Drawing.Point(885, 431);
            this.chartMpuYaw.Margin = new System.Windows.Forms.Padding(1);
            this.chartMpuYaw.Name = "chartMpuYaw";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "MYaw";
            this.chartMpuYaw.Series.Add(series4);
            this.chartMpuYaw.Size = new System.Drawing.Size(898, 424);
            this.chartMpuYaw.TabIndex = 13;
            this.chartMpuYaw.Text = "MpuYaw";
            // 
            // chartMpuRoll
            // 
            this.chartMpuRoll.BackColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.LabelStyle.Format = "#.#";
            chartArea5.AxisX.Maximum = 0.1D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY.Title = "MpuRoll";
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 94F;
            this.chartMpuRoll.ChartAreas.Add(chartArea5);
            this.chartMpuRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            legend5.Position.Auto = false;
            legend5.Position.Height = 9.476309F;
            legend5.Position.Width = 20F;
            legend5.Position.X = 79F;
            legend5.Position.Y = 2F;
            this.chartMpuRoll.Legends.Add(legend5);
            this.chartMpuRoll.Location = new System.Drawing.Point(1, 1);
            this.chartMpuRoll.Margin = new System.Windows.Forms.Padding(1);
            this.chartMpuRoll.Name = "chartMpuRoll";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series5.Legend = "Legend1";
            series5.Name = "MRoll";
            this.chartMpuRoll.Series.Add(series5);
            this.chartMpuRoll.Size = new System.Drawing.Size(882, 428);
            this.chartMpuRoll.TabIndex = 19;
            this.chartMpuRoll.Text = "MpuRoll";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2536, 862);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WingEdge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLBattery
            // 
            this.chartLBattery.BackColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.LabelStyle.Format = "#.#";
            chartArea6.AxisX.Maximum = 0.1D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.AxisY.Title = "LBattery[V]";
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 94F;
            this.chartLBattery.ChartAreas.Add(chartArea6);
            this.chartLBattery.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            legend6.Position.Auto = false;
            legend6.Position.Height = 9.476309F;
            legend6.Position.Width = 20F;
            legend6.Position.X = 79F;
            legend6.Position.Y = 2F;
            this.chartLBattery.Legends.Add(legend6);
            this.chartLBattery.Location = new System.Drawing.Point(1223, 1);
            this.chartLBattery.Margin = new System.Windows.Forms.Padding(1);
            this.chartLBattery.Name = "chartLBattery";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.LegendText = "LBattery";
            series6.Name = "LBattery";
            this.chartLBattery.Series.Add(series6);
            this.chartLBattery.Size = new System.Drawing.Size(1306, 854);
            this.chartLBattery.TabIndex = 17;
            this.chartLBattery.Text = "chart4";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3004F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6996F));
            this.tableLayoutPanel3.Controls.Add(this.chartLBattery, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chartRBattery, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2530, 856);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // chartRBattery
            // 
            this.chartRBattery.BackColor = System.Drawing.Color.LightGray;
            chartArea7.AxisX.LabelStyle.Format = "#.#";
            chartArea7.AxisX.Maximum = 0.1D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisY.IsLabelAutoFit = false;
            chartArea7.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.AxisY.Title = "RBattery[V";
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.Name = "ChartArea1";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 100F;
            chartArea7.Position.Width = 94F;
            this.chartRBattery.ChartAreas.Add(chartArea7);
            this.chartRBattery.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            legend7.Position.Auto = false;
            legend7.Position.Height = 9.476309F;
            legend7.Position.Width = 20F;
            legend7.Position.X = 79F;
            legend7.Position.Y = 2F;
            this.chartRBattery.Legends.Add(legend7);
            this.chartRBattery.Location = new System.Drawing.Point(1, 1);
            this.chartRBattery.Margin = new System.Windows.Forms.Padding(1);
            this.chartRBattery.Name = "chartRBattery";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.LegendText = "RBattery";
            series7.Name = "RBattery";
            this.chartRBattery.Series.Add(series7);
            this.chartRBattery.Size = new System.Drawing.Size(1220, 854);
            this.chartRBattery.TabIndex = 16;
            this.chartRBattery.Text = "chart4";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rollVerticalProgressBar);
            this.tabPage3.Controls.Add(this.chartRollInput);
            this.tabPage3.Controls.Add(this.chartPitchInput);
            this.tabPage3.Controls.Add(this.chartDrugInput);
            this.tabPage3.Controls.Add(this.pitchVerticalProgressBar);
            this.tabPage3.Controls.Add(this.buttonRDrug);
            this.tabPage3.Controls.Add(this.buttonLDrug);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2536, 862);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rollVerticalProgressBar
            // 
            this.rollVerticalProgressBar.Location = new System.Drawing.Point(142, 16);
            this.rollVerticalProgressBar.Name = "rollVerticalProgressBar";
            this.rollVerticalProgressBar.Size = new System.Drawing.Size(107, 814);
            this.rollVerticalProgressBar.TabIndex = 20;
            // 
            // chartRollInput
            // 
            this.chartRollInput.BackColor = System.Drawing.Color.LightGray;
            chartArea8.AxisX.LabelStyle.Format = "#.#";
            chartArea8.AxisX.Maximum = 0.1D;
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.AxisY.IsLabelAutoFit = false;
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.AxisY.Title = "RollInput";
            chartArea8.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.Name = "ChartArea1";
            chartArea8.Position.Auto = false;
            chartArea8.Position.Height = 100F;
            chartArea8.Position.Width = 94F;
            this.chartRollInput.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            legend8.Position.Auto = false;
            legend8.Position.Height = 9.476309F;
            legend8.Position.Width = 20F;
            legend8.Position.X = 79F;
            legend8.Position.Y = 2F;
            this.chartRollInput.Legends.Add(legend8);
            this.chartRollInput.Location = new System.Drawing.Point(1277, 16);
            this.chartRollInput.Margin = new System.Windows.Forms.Padding(1);
            this.chartRollInput.Name = "chartRollInput";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.LegendText = "RollInput";
            series8.Name = "RollInput";
            this.chartRollInput.Series.Add(series8);
            this.chartRollInput.Size = new System.Drawing.Size(1230, 394);
            this.chartRollInput.TabIndex = 19;
            this.chartRollInput.Text = "chart4";
            // 
            // chartPitchInput
            // 
            this.chartPitchInput.BackColor = System.Drawing.Color.LightGray;
            chartArea9.AxisX.LabelStyle.Format = "#.#";
            chartArea9.AxisX.Maximum = 0.1D;
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.AxisY.IsLabelAutoFit = false;
            chartArea9.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.Minimum = 0D;
            chartArea9.AxisY.Title = "PitchInput";
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.Name = "ChartArea1";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 100F;
            chartArea9.Position.Width = 94F;
            this.chartPitchInput.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            legend9.Position.Auto = false;
            legend9.Position.Height = 9.476309F;
            legend9.Position.Width = 20F;
            legend9.Position.X = 79F;
            legend9.Position.Y = 2F;
            this.chartPitchInput.Legends.Add(legend9);
            this.chartPitchInput.Location = new System.Drawing.Point(253, 272);
            this.chartPitchInput.Margin = new System.Windows.Forms.Padding(1);
            this.chartPitchInput.Name = "chartPitchInput";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.Red;
            series9.Legend = "Legend1";
            series9.LegendText = "PitchInput";
            series9.Name = "PitchInput";
            this.chartPitchInput.Series.Add(series9);
            this.chartPitchInput.Size = new System.Drawing.Size(1019, 544);
            this.chartPitchInput.TabIndex = 18;
            this.chartPitchInput.Text = "chart4";
            // 
            // chartDrugInput
            // 
            this.chartDrugInput.BackColor = System.Drawing.Color.LightGray;
            chartArea10.AxisX.LabelStyle.Format = "#.#";
            chartArea10.AxisX.Maximum = 0.1D;
            chartArea10.AxisX.Minimum = 0D;
            chartArea10.AxisY.IsLabelAutoFit = false;
            chartArea10.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.AxisY.Title = "DrugInput";
            chartArea10.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 100F;
            chartArea10.Position.Width = 94F;
            this.chartDrugInput.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            legend10.Position.Auto = false;
            legend10.Position.Height = 9.476309F;
            legend10.Position.Width = 20F;
            legend10.Position.X = 79F;
            legend10.Position.Y = 2F;
            this.chartDrugInput.Legends.Add(legend10);
            this.chartDrugInput.Location = new System.Drawing.Point(1277, 425);
            this.chartDrugInput.Margin = new System.Windows.Forms.Padding(1);
            this.chartDrugInput.Name = "chartDrugInput";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "DrugInput";
            series10.Name = "DrugInput";
            this.chartDrugInput.Series.Add(series10);
            this.chartDrugInput.Size = new System.Drawing.Size(1230, 381);
            this.chartDrugInput.TabIndex = 17;
            this.chartDrugInput.Text = "chart4";
            // 
            // pitchVerticalProgressBar
            // 
            this.pitchVerticalProgressBar.Location = new System.Drawing.Point(13, 16);
            this.pitchVerticalProgressBar.Name = "pitchVerticalProgressBar";
            this.pitchVerticalProgressBar.Size = new System.Drawing.Size(107, 814);
            this.pitchVerticalProgressBar.TabIndex = 9;
            // 
            // buttonRDrug
            // 
            this.buttonRDrug.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRDrug.Location = new System.Drawing.Point(719, 40);
            this.buttonRDrug.Name = "buttonRDrug";
            this.buttonRDrug.Size = new System.Drawing.Size(312, 109);
            this.buttonRDrug.TabIndex = 5;
            this.buttonRDrug.Text = "右ドラッグラダー";
            this.buttonRDrug.UseVisualStyleBackColor = true;
            // 
            // buttonLDrug
            // 
            this.buttonLDrug.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonLDrug.Location = new System.Drawing.Point(369, 40);
            this.buttonLDrug.Name = "buttonLDrug";
            this.buttonLDrug.Size = new System.Drawing.Size(310, 109);
            this.buttonLDrug.TabIndex = 3;
            this.buttonLDrug.Text = "左ドラッグラダー";
            this.buttonLDrug.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.76471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.23529F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAllData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSerialConfig, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.32039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.67961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 902F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2550, 1390);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBoxBatteryDataR);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxCadence);
            this.groupBox1.Controls.Add(this.textBoxMpuYaw);
            this.groupBox1.Controls.Add(this.textBoxSpeed);
            this.groupBox1.Controls.Add(this.textBoxMpuRoll);
            this.groupBox1.Controls.Add(this.label_mpuData);
            this.groupBox1.Controls.Add(this.textBoxMpuPitch);
            this.groupBox1.Controls.Add(this.label_batteryDataR);
            this.groupBox1.Controls.Add(this.label_batteryDataL);
            this.groupBox1.Controls.Add(this.textBoxBatteryDataL);
            this.groupBox1.Location = new System.Drawing.Point(1170, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1203, 481);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "センサ詳細情報";
            // 
            // textBoxBatteryDataR
            // 
            this.textBoxBatteryDataR.Location = new System.Drawing.Point(867, 50);
            this.textBoxBatteryDataR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBatteryDataR.Multiline = true;
            this.textBoxBatteryDataR.Name = "textBoxBatteryDataR";
            this.textBoxBatteryDataR.ReadOnly = true;
            this.textBoxBatteryDataR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatteryDataR.Size = new System.Drawing.Size(155, 424);
            this.textBoxBatteryDataR.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(383, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 24);
            this.label15.TabIndex = 41;
            this.label15.Text = "MPURoll";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(549, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 24);
            this.label14.TabIndex = 40;
            this.label14.Text = "MPUYaw";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(720, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cadence";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(1000, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(35, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Speed";
            // 
            // textBoxCadence
            // 
            this.textBoxCadence.Location = new System.Drawing.Point(693, 50);
            this.textBoxCadence.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCadence.Multiline = true;
            this.textBoxCadence.Name = "textBoxCadence";
            this.textBoxCadence.ReadOnly = true;
            this.textBoxCadence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCadence.Size = new System.Drawing.Size(155, 424);
            this.textBoxCadence.TabIndex = 20;
            // 
            // textBoxMpuYaw
            // 
            this.textBoxMpuYaw.Location = new System.Drawing.Point(521, 52);
            this.textBoxMpuYaw.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuYaw.Multiline = true;
            this.textBoxMpuYaw.Name = "textBoxMpuYaw";
            this.textBoxMpuYaw.ReadOnly = true;
            this.textBoxMpuYaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuYaw.Size = new System.Drawing.Size(155, 422);
            this.textBoxMpuYaw.TabIndex = 16;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(5, 50);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpeed.Multiline = true;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSpeed.Size = new System.Drawing.Size(155, 424);
            this.textBoxSpeed.TabIndex = 15;
            // 
            // textBoxMpuRoll
            // 
            this.textBoxMpuRoll.Location = new System.Drawing.Point(352, 52);
            this.textBoxMpuRoll.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuRoll.Multiline = true;
            this.textBoxMpuRoll.Name = "textBoxMpuRoll";
            this.textBoxMpuRoll.ReadOnly = true;
            this.textBoxMpuRoll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuRoll.Size = new System.Drawing.Size(155, 422);
            this.textBoxMpuRoll.TabIndex = 12;
            // 
            // label_mpuData
            // 
            this.label_mpuData.AutoSize = true;
            this.label_mpuData.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_mpuData.Location = new System.Drawing.Point(201, 26);
            this.label_mpuData.Name = "label_mpuData";
            this.label_mpuData.Size = new System.Drawing.Size(110, 24);
            this.label_mpuData.TabIndex = 8;
            this.label_mpuData.Text = "MPUPitch";
            // 
            // textBoxMpuPitch
            // 
            this.textBoxMpuPitch.Location = new System.Drawing.Point(176, 52);
            this.textBoxMpuPitch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuPitch.Multiline = true;
            this.textBoxMpuPitch.Name = "textBoxMpuPitch";
            this.textBoxMpuPitch.ReadOnly = true;
            this.textBoxMpuPitch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuPitch.Size = new System.Drawing.Size(155, 422);
            this.textBoxMpuPitch.TabIndex = 4;
            this.textBoxMpuPitch.Text = "`";
            // 
            // label_batteryDataR
            // 
            this.label_batteryDataR.AutoSize = true;
            this.label_batteryDataR.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_batteryDataR.Location = new System.Drawing.Point(883, 26);
            this.label_batteryDataR.Name = "label_batteryDataR";
            this.label_batteryDataR.Size = new System.Drawing.Size(95, 24);
            this.label_batteryDataR.TabIndex = 11;
            this.label_batteryDataR.Text = "batteryR";
            // 
            // label_batteryDataL
            // 
            this.label_batteryDataL.AutoSize = true;
            this.label_batteryDataL.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_batteryDataL.Location = new System.Drawing.Point(1063, 24);
            this.label_batteryDataL.Name = "label_batteryDataL";
            this.label_batteryDataL.Size = new System.Drawing.Size(93, 24);
            this.label_batteryDataL.TabIndex = 10;
            this.label_batteryDataL.Text = "batteryL";
            // 
            // textBoxBatteryDataL
            // 
            this.textBoxBatteryDataL.Location = new System.Drawing.Point(1043, 50);
            this.textBoxBatteryDataL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBatteryDataL.Multiline = true;
            this.textBoxBatteryDataL.Name = "textBoxBatteryDataL";
            this.textBoxBatteryDataL.ReadOnly = true;
            this.textBoxBatteryDataL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatteryDataL.Size = new System.Drawing.Size(155, 424);
            this.textBoxBatteryDataL.TabIndex = 6;
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2550, 1390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SerialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "シリアルデータ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialForm_FormClosing);
            this.groupBoxAllData.ResumeLayout(false);
            this.groupBoxAllData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNamesBindingSource)).EndInit();
            this.groupBoxSerialConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filePathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCadence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMpuRoll)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLBattery)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRBattery)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRollInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPitchInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrugInput)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAllData;
        private System.Windows.Forms.GroupBox groupBoxAllData;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.GroupBox groupBoxSerialConfig;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.BindingSource bauditemsBindingSource;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRunCsv;
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.Button buttonOpenCsv;
        private System.Windows.Forms.Button buttonStopCsv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AlbaChart chartMpuPitch;
        private AlbaChart chartSpeed;
        private AlbaChart chartMpuRoll;
        private AlbaChart chartMpuYaw;
        private AlbaChart chartCadence;
        private System.Windows.Forms.TabPage tabPage2;
        private AlbaChart chartLBattery;
        private AlbaChart chartRBattery;
        private System.Windows.Forms.TabPage tabPage3;
        private AlbaChart chartRollInput;
        private AlbaChart chartPitchInput;
        private AlbaChart chartDrugInput;
        private VerticalProgressBar pitchVerticalProgressBar;
        private System.Windows.Forms.Button buttonRDrug;
        private System.Windows.Forms.Button buttonLDrug;
        private VerticalProgressBar rollVerticalProgressBar;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.BindingSource portNamesBindingSource;
        private System.Windows.Forms.BindingSource filePathBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBatteryDataR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCadence;
        private System.Windows.Forms.TextBox textBoxMpuYaw;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxMpuRoll;
        private System.Windows.Forms.Label label_mpuData;
        private System.Windows.Forms.TextBox textBoxMpuPitch;
        private System.Windows.Forms.Label label_batteryDataR;
        private System.Windows.Forms.Label label_batteryDataL;
        private System.Windows.Forms.TextBox textBoxBatteryDataL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

