using AlbaAnalysis.Entity;
namespace AlbaAnalysis {

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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.bauditemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRunCsv = new System.Windows.Forms.Button();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.filePathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOpenCsv = new System.Windows.Forms.Button();
            this.buttonStopCsv = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AirSpeedChart = new AlbaAnalysis.AlbaChart();
            this.MpuRollChart = new AlbaAnalysis.AlbaChart();
            this.MpuPitchChart = new AlbaAnalysis.AlbaChart();
            this.MpuYawChart = new AlbaAnalysis.AlbaChart();
            this.CadenceChart = new AlbaAnalysis.AlbaChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RBatteryChart = new AlbaAnalysis.AlbaChart();
            this.LBatteryChart = new AlbaAnalysis.AlbaChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRDrug = new System.Windows.Forms.Button();
            this.buttonLDrug = new System.Windows.Forms.Button();
            this.rollVerticalProgressBar = new AlbaAnalysis.VerticalProgressBar();
            this.pitchVerticalProgressBar = new AlbaAnalysis.VerticalProgressBar();
            this.PitchInputChart = new AlbaAnalysis.AlbaChart();
            this.RollInputChart = new AlbaAnalysis.AlbaChart();
            this.DrugInputChart = new AlbaAnalysis.AlbaChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBatteryDataR = new System.Windows.Forms.TextBox();
            this.label_batteryDataR = new System.Windows.Forms.Label();
            this.textBoxBatteryDataL = new System.Windows.Forms.TextBox();
            this.textBoxMpuPitch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMpuYaw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_mpuData = new System.Windows.Forms.Label();
            this.textBoxMpuRoll = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCadence = new System.Windows.Forms.TextBox();
            this.label_batteryDataL = new System.Windows.Forms.Label();
            this.groupBoxAllData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNamesBindingSource)).BeginInit();
            this.groupBoxSerialConfig.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePathBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirSpeedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuRollChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuPitchChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuYawChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadenceChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RBatteryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBatteryChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PitchInputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollInputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugInputChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 2500000;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAllData.Location = new System.Drawing.Point(3, 21);
            this.textBoxAllData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.ReadOnly = true;
            this.textBoxAllData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllData.Size = new System.Drawing.Size(1039, 195);
            this.textBoxAllData.TabIndex = 27;
            // 
            // groupBoxAllData
            // 
            this.groupBoxAllData.AutoSize = true;
            this.groupBoxAllData.Controls.Add(this.textBoxAllData);
            this.groupBoxAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAllData.Location = new System.Drawing.Point(3, 123);
            this.groupBoxAllData.Name = "groupBoxAllData";
            this.groupBoxAllData.Size = new System.Drawing.Size(1045, 219);
            this.groupBoxAllData.TabIndex = 27;
            this.groupBoxAllData.TabStop = false;
            this.groupBoxAllData.Text = "受信データ";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPort.DataSource = this.portNamesBindingSource;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(2, 2);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(281, 26);
            this.comboBoxPort.TabIndex = 2;
            // 
            // portNamesBindingSource
            // 
            this.portNamesBindingSource.DataSource = typeof(AlbaAnalysis.Entity.portNames);
            // 
            // groupBoxSerialConfig
            // 
            this.groupBoxSerialConfig.AutoSize = true;
            this.groupBoxSerialConfig.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxSerialConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSerialConfig.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSerialConfig.Name = "groupBoxSerialConfig";
            this.groupBoxSerialConfig.Size = new System.Drawing.Size(1045, 114);
            this.groupBoxSerialConfig.TabIndex = 13;
            this.groupBoxSerialConfig.TabStop = false;
            this.groupBoxSerialConfig.Text = "シリアル設定";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.60518F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.39482F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel6.Controls.Add(this.comboBoxBaud, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxPort, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonClose, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonConnect, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.button1, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonNext, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonRunCsv, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxFiles, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonOpenCsv, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonStopCsv, 3, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1039, 90);
            this.tableLayoutPanel6.TabIndex = 39;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.comboBoxBaud, 2);
            this.comboBoxBaud.DataSource = this.bauditemsBindingSource;
            this.comboBoxBaud.DisplayMember = "NAME";
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(287, 2);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(336, 26);
            this.comboBoxBaud.TabIndex = 3;
            this.comboBoxBaud.ValueMember = "RATE";
            // 
            // bauditemsBindingSource
            // 
            this.bauditemsBindingSource.DataSource = typeof(AlbaAnalysis.Entity.BaudRateEntity);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(758, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(126, 39);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConnect.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(628, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(124, 39);
            this.buttonConnect.TabIndex = 29;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(890, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(890, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(146, 39);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // buttonRunCsv
            // 
            this.buttonRunCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRunCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRunCsv.Location = new System.Drawing.Point(498, 48);
            this.buttonRunCsv.Name = "buttonRunCsv";
            this.buttonRunCsv.Size = new System.Drawing.Size(124, 39);
            this.buttonRunCsv.TabIndex = 48;
            this.buttonRunCsv.Text = "Run Csv";
            this.buttonRunCsv.UseVisualStyleBackColor = true;
            this.buttonRunCsv.Click += new System.EventHandler(this.buttonRunCsv_Click);
            // 
            // comboBoxFiles
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.comboBoxFiles, 2);
            this.comboBoxFiles.DataSource = this.filePathBindingSource;
            this.comboBoxFiles.DisplayMember = "pathName";
            this.comboBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(3, 48);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(489, 26);
            this.comboBoxFiles.TabIndex = 34;
            this.comboBoxFiles.ValueMember = "pathName";
            this.comboBoxFiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiles_SelectedIndexChanged);
            // 
            // filePathBindingSource
            // 
            this.filePathBindingSource.DataSource = typeof(AlbaAnalysis.Entity.filePath);
            // 
            // buttonOpenCsv
            // 
            this.buttonOpenCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOpenCsv.Location = new System.Drawing.Point(758, 48);
            this.buttonOpenCsv.Name = "buttonOpenCsv";
            this.buttonOpenCsv.Size = new System.Drawing.Size(126, 39);
            this.buttonOpenCsv.TabIndex = 36;
            this.buttonOpenCsv.Text = "Open Csv";
            this.buttonOpenCsv.UseVisualStyleBackColor = true;
            this.buttonOpenCsv.Click += new System.EventHandler(this.buttonOpenCsv_Click);
            // 
            // buttonStopCsv
            // 
            this.buttonStopCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStopCsv.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStopCsv.Location = new System.Drawing.Point(628, 48);
            this.buttonStopCsv.Name = "buttonStopCsv";
            this.buttonStopCsv.Size = new System.Drawing.Size(124, 39);
            this.buttonStopCsv.TabIndex = 50;
            this.buttonStopCsv.Text = "Stop Csv";
            this.buttonStopCsv.UseVisualStyleBackColor = true;
            this.buttonStopCsv.Click += new System.EventHandler(this.buttonStopCsv_Click);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 348);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2312, 868);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2304, 836);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Core";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.79258F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.87409F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.AirSpeedChart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MpuRollChart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MpuPitchChart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MpuYawChart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CadenceChart, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23365F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.76635F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2298, 830);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // AirSpeedChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AirSpeedChart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel2.SetColumnSpan(this.AirSpeedChart, 2);
            this.AirSpeedChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.AirSpeedChart.Legends.Add(legend1);
            this.AirSpeedChart.Location = new System.Drawing.Point(779, 3);
            this.AirSpeedChart.Name = "AirSpeedChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.AirSpeedChart.Series.Add(series1);
            this.AirSpeedChart.Size = new System.Drawing.Size(1516, 410);
            this.AirSpeedChart.TabIndex = 28;
            this.AirSpeedChart.Text = "chart1";
            // 
            // MpuRollChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MpuRollChart.ChartAreas.Add(chartArea2);
            this.MpuRollChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.MpuRollChart.Legends.Add(legend2);
            this.MpuRollChart.Location = new System.Drawing.Point(3, 3);
            this.MpuRollChart.Name = "MpuRollChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "MpuRoll";
            this.MpuRollChart.Series.Add(series2);
            this.MpuRollChart.Size = new System.Drawing.Size(770, 410);
            this.MpuRollChart.TabIndex = 29;
            this.MpuRollChart.Text = "albaChart1";
            this.MpuRollChart.Click += new System.EventHandler(this.MpuRollChart_Click);
            // 
            // MpuPitchChart
            // 
            chartArea3.Name = "ChartArea1";
            this.MpuPitchChart.ChartAreas.Add(chartArea3);
            this.MpuPitchChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.MpuPitchChart.Legends.Add(legend3);
            this.MpuPitchChart.Location = new System.Drawing.Point(3, 419);
            this.MpuPitchChart.Name = "MpuPitchChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "MpuPitch";
            this.MpuPitchChart.Series.Add(series3);
            this.MpuPitchChart.Size = new System.Drawing.Size(770, 408);
            this.MpuPitchChart.TabIndex = 30;
            this.MpuPitchChart.Text = "albaChart1";
            // 
            // MpuYawChart
            // 
            chartArea4.Name = "ChartArea1";
            this.MpuYawChart.ChartAreas.Add(chartArea4);
            this.MpuYawChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.MpuYawChart.Legends.Add(legend4);
            this.MpuYawChart.Location = new System.Drawing.Point(779, 419);
            this.MpuYawChart.Name = "MpuYawChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "MpuYaw";
            this.MpuYawChart.Series.Add(series4);
            this.MpuYawChart.Size = new System.Drawing.Size(749, 408);
            this.MpuYawChart.TabIndex = 31;
            this.MpuYawChart.Text = "albaChart2";
            // 
            // CadenceChart
            // 
            chartArea5.Name = "ChartArea1";
            this.CadenceChart.ChartAreas.Add(chartArea5);
            this.CadenceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.CadenceChart.Legends.Add(legend5);
            this.CadenceChart.Location = new System.Drawing.Point(1534, 419);
            this.CadenceChart.Name = "CadenceChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Cadence";
            this.CadenceChart.Series.Add(series5);
            this.CadenceChart.Size = new System.Drawing.Size(761, 408);
            this.CadenceChart.TabIndex = 32;
            this.CadenceChart.Text = "albaChart3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2304, 836);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WingEdge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3004F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6996F));
            this.tableLayoutPanel3.Controls.Add(this.RBatteryChart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LBatteryChart, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2298, 830);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // RBatteryChart
            // 
            chartArea6.Name = "ChartArea1";
            this.RBatteryChart.ChartAreas.Add(chartArea6);
            this.RBatteryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.RBatteryChart.Legends.Add(legend6);
            this.RBatteryChart.Location = new System.Drawing.Point(3, 3);
            this.RBatteryChart.Name = "RBatteryChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "RBattery";
            this.RBatteryChart.Series.Add(series6);
            this.RBatteryChart.Size = new System.Drawing.Size(1103, 824);
            this.RBatteryChart.TabIndex = 18;
            this.RBatteryChart.Text = "albaChart1";
            this.RBatteryChart.Click += new System.EventHandler(this.RBatteryChart_Click);
            // 
            // LBatteryChart
            // 
            chartArea7.Name = "ChartArea1";
            this.LBatteryChart.ChartAreas.Add(chartArea7);
            this.LBatteryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.LBatteryChart.Legends.Add(legend7);
            this.LBatteryChart.Location = new System.Drawing.Point(1112, 3);
            this.LBatteryChart.Name = "LBatteryChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "LBatteryChart";
            this.LBatteryChart.Series.Add(series7);
            this.LBatteryChart.Size = new System.Drawing.Size(1183, 824);
            this.LBatteryChart.TabIndex = 19;
            this.LBatteryChart.Text = "albaChart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2304, 836);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.66673F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48148F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.92181F));
            this.tableLayoutPanel4.Controls.Add(this.buttonRDrug, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonLDrug, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.rollVerticalProgressBar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pitchVerticalProgressBar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PitchInputChart, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.RollInputChart, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.DrugInputChart, 4, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29656F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.56459F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(2304, 836);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // buttonRDrug
            // 
            this.buttonRDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRDrug.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRDrug.Location = new System.Drawing.Point(797, 122);
            this.buttonRDrug.Name = "buttonRDrug";
            this.buttonRDrug.Size = new System.Drawing.Size(429, 96);
            this.buttonRDrug.TabIndex = 5;
            this.buttonRDrug.Text = "右ドラッグラダー";
            this.buttonRDrug.UseVisualStyleBackColor = true;
            // 
            // buttonLDrug
            // 
            this.buttonLDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLDrug.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonLDrug.Location = new System.Drawing.Point(277, 122);
            this.buttonLDrug.Name = "buttonLDrug";
            this.buttonLDrug.Size = new System.Drawing.Size(514, 96);
            this.buttonLDrug.TabIndex = 3;
            this.buttonLDrug.Text = "左ドラッグラダー";
            this.buttonLDrug.UseVisualStyleBackColor = true;
            // 
            // rollVerticalProgressBar
            // 
            this.rollVerticalProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollVerticalProgressBar.Location = new System.Drawing.Point(140, 3);
            this.rollVerticalProgressBar.Name = "rollVerticalProgressBar";
            this.tableLayoutPanel4.SetRowSpan(this.rollVerticalProgressBar, 4);
            this.rollVerticalProgressBar.Size = new System.Drawing.Size(131, 830);
            this.rollVerticalProgressBar.TabIndex = 20;
            // 
            // pitchVerticalProgressBar
            // 
            this.pitchVerticalProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pitchVerticalProgressBar.Location = new System.Drawing.Point(3, 3);
            this.pitchVerticalProgressBar.Name = "pitchVerticalProgressBar";
            this.tableLayoutPanel4.SetRowSpan(this.pitchVerticalProgressBar, 4);
            this.pitchVerticalProgressBar.Size = new System.Drawing.Size(131, 830);
            this.pitchVerticalProgressBar.TabIndex = 9;
            // 
            // PitchInputChart
            // 
            chartArea8.Name = "ChartArea1";
            this.PitchInputChart.ChartAreas.Add(chartArea8);
            this.tableLayoutPanel4.SetColumnSpan(this.PitchInputChart, 2);
            this.PitchInputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.PitchInputChart.Legends.Add(legend8);
            this.PitchInputChart.Location = new System.Drawing.Point(277, 224);
            this.PitchInputChart.Name = "PitchInputChart";
            this.tableLayoutPanel4.SetRowSpan(this.PitchInputChart, 2);
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "PitchInput";
            this.PitchInputChart.Series.Add(series8);
            this.PitchInputChart.Size = new System.Drawing.Size(949, 609);
            this.PitchInputChart.TabIndex = 21;
            this.PitchInputChart.Text = "albaChart2";
            // 
            // RollInputChart
            // 
            chartArea9.Name = "ChartArea1";
            this.RollInputChart.ChartAreas.Add(chartArea9);
            this.RollInputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.RollInputChart.Legends.Add(legend9);
            this.RollInputChart.Location = new System.Drawing.Point(1232, 3);
            this.RollInputChart.Name = "RollInputChart";
            this.tableLayoutPanel4.SetRowSpan(this.RollInputChart, 3);
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "RollInput";
            this.RollInputChart.Series.Add(series9);
            this.RollInputChart.Size = new System.Drawing.Size(1069, 423);
            this.RollInputChart.TabIndex = 22;
            this.RollInputChart.Text = "albaChart2";
            // 
            // DrugInputChart
            // 
            chartArea10.Name = "ChartArea1";
            this.DrugInputChart.ChartAreas.Add(chartArea10);
            this.DrugInputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.DrugInputChart.Legends.Add(legend10);
            this.DrugInputChart.Location = new System.Drawing.Point(1232, 432);
            this.DrugInputChart.Name = "DrugInputChart";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "DrugInput";
            this.DrugInputChart.Series.Add(series10);
            this.DrugInputChart.Size = new System.Drawing.Size(1069, 401);
            this.DrugInputChart.TabIndex = 23;
            this.DrugInputChart.Text = "albaChart2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.37255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.62745F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAllData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSerialConfig, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 874F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2318, 1191);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1054, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1261, 339);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "センサ詳細情報";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(908, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 37;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.08101F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91899F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxBatteryDataR, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.label_batteryDataR, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxBatteryDataL, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMpuPitch, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxSpeed, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMpuYaw, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_mpuData, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMpuRoll, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxCadence, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label_batteryDataL, 6, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.1674F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.8326F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1255, 315);
            this.tableLayoutPanel5.TabIndex = 42;
            // 
            // textBoxBatteryDataR
            // 
            this.textBoxBatteryDataR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBatteryDataR.Location = new System.Drawing.Point(897, 21);
            this.textBoxBatteryDataR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBatteryDataR.Multiline = true;
            this.textBoxBatteryDataR.Name = "textBoxBatteryDataR";
            this.textBoxBatteryDataR.ReadOnly = true;
            this.textBoxBatteryDataR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatteryDataR.Size = new System.Drawing.Size(175, 292);
            this.textBoxBatteryDataR.TabIndex = 7;
            // 
            // label_batteryDataR
            // 
            this.label_batteryDataR.AutoSize = true;
            this.label_batteryDataR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_batteryDataR.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_batteryDataR.Location = new System.Drawing.Point(898, 0);
            this.label_batteryDataR.Name = "label_batteryDataR";
            this.label_batteryDataR.Size = new System.Drawing.Size(173, 19);
            this.label_batteryDataR.TabIndex = 11;
            this.label_batteryDataR.Text = "batteryR";
            this.label_batteryDataR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBatteryDataL
            // 
            this.textBoxBatteryDataL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBatteryDataL.Location = new System.Drawing.Point(1076, 21);
            this.textBoxBatteryDataL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBatteryDataL.Multiline = true;
            this.textBoxBatteryDataL.Name = "textBoxBatteryDataL";
            this.textBoxBatteryDataL.ReadOnly = true;
            this.textBoxBatteryDataL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatteryDataL.Size = new System.Drawing.Size(177, 292);
            this.textBoxBatteryDataL.TabIndex = 6;
            // 
            // textBoxMpuPitch
            // 
            this.textBoxMpuPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMpuPitch.Location = new System.Drawing.Point(175, 21);
            this.textBoxMpuPitch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuPitch.Multiline = true;
            this.textBoxMpuPitch.Name = "textBoxMpuPitch";
            this.textBoxMpuPitch.ReadOnly = true;
            this.textBoxMpuPitch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuPitch.Size = new System.Drawing.Size(181, 292);
            this.textBoxMpuPitch.TabIndex = 4;
            this.textBoxMpuPitch.Text = "`";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(719, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cadence";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSpeed.Location = new System.Drawing.Point(2, 21);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpeed.Multiline = true;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSpeed.Size = new System.Drawing.Size(169, 292);
            this.textBoxSpeed.TabIndex = 15;
            // 
            // textBoxMpuYaw
            // 
            this.textBoxMpuYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMpuYaw.Location = new System.Drawing.Point(539, 21);
            this.textBoxMpuYaw.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuYaw.Multiline = true;
            this.textBoxMpuYaw.Name = "textBoxMpuYaw";
            this.textBoxMpuYaw.ReadOnly = true;
            this.textBoxMpuYaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuYaw.Size = new System.Drawing.Size(175, 292);
            this.textBoxMpuYaw.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Speed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mpuData
            // 
            this.label_mpuData.AutoSize = true;
            this.label_mpuData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_mpuData.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_mpuData.Location = new System.Drawing.Point(176, 0);
            this.label_mpuData.Name = "label_mpuData";
            this.label_mpuData.Size = new System.Drawing.Size(179, 19);
            this.label_mpuData.TabIndex = 8;
            this.label_mpuData.Text = "MPUPitch";
            this.label_mpuData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMpuRoll
            // 
            this.textBoxMpuRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMpuRoll.Location = new System.Drawing.Point(360, 21);
            this.textBoxMpuRoll.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMpuRoll.Multiline = true;
            this.textBoxMpuRoll.Name = "textBoxMpuRoll";
            this.textBoxMpuRoll.ReadOnly = true;
            this.textBoxMpuRoll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMpuRoll.Size = new System.Drawing.Size(175, 292);
            this.textBoxMpuRoll.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(361, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "MPURoll";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(540, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 19);
            this.label14.TabIndex = 40;
            this.label14.Text = "MPUYaw";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCadence
            // 
            this.textBoxCadence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCadence.Location = new System.Drawing.Point(718, 21);
            this.textBoxCadence.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCadence.Multiline = true;
            this.textBoxCadence.Name = "textBoxCadence";
            this.textBoxCadence.ReadOnly = true;
            this.textBoxCadence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCadence.Size = new System.Drawing.Size(175, 292);
            this.textBoxCadence.TabIndex = 20;
            // 
            // label_batteryDataL
            // 
            this.label_batteryDataL.AutoSize = true;
            this.label_batteryDataL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_batteryDataL.Font = new System.Drawing.Font("MS UI Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_batteryDataL.Location = new System.Drawing.Point(1077, 0);
            this.label_batteryDataL.Name = "label_batteryDataL";
            this.label_batteryDataL.Size = new System.Drawing.Size(175, 19);
            this.label_batteryDataL.TabIndex = 10;
            this.label_batteryDataL.Text = "batteryL";
            this.label_batteryDataL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2318, 1191);
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
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bauditemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePathBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AirSpeedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuRollChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuPitchChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MpuYawChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadenceChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RBatteryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBatteryChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PitchInputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollInputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugInputChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonRunCsv;
        private System.Windows.Forms.Button buttonOpenCsv;
        private System.Windows.Forms.Button buttonStopCsv;
        private AlbaChart AirSpeedChart;
        private AlbaChart MpuRollChart;
        private AlbaChart MpuPitchChart;
        private AlbaChart MpuYawChart;
        private AlbaChart CadenceChart;
        private AlbaChart RBatteryChart;
        private AlbaChart LBatteryChart;
        private AlbaChart PitchInputChart;
        private AlbaChart RollInputChart;
        private AlbaChart DrugInputChart;
    }
}

