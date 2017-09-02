namespace AlbaAnalysis {
    partial class ConfigDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewConfigAttribute = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusdisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdapt = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigAttribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configEntityBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1543, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 28);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1543, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "名称変更";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.10811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewConfigAttribute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdapt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.34782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1537, 729);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewConfigAttribute
            // 
            this.dataGridViewConfigAttribute.AutoGenerateColumns = false;
            this.dataGridViewConfigAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigAttribute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ordering,
            this.nameDataGridViewTextBoxColumn,
            this.dispnameDataGridViewTextBoxColumn,
            this.statusdisplayDataGridViewTextBoxColumn,
            this.filterlevelDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewConfigAttribute, 4);
            this.dataGridViewConfigAttribute.DataSource = this.configEntityBindingSource;
            this.dataGridViewConfigAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConfigAttribute.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConfigAttribute.Name = "dataGridViewConfigAttribute";
            this.dataGridViewConfigAttribute.RowTemplate.Height = 30;
            this.dataGridViewConfigAttribute.Size = new System.Drawing.Size(1531, 638);
            this.dataGridViewConfigAttribute.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ordering
            // 
            this.ordering.DataPropertyName = "ordering";
            this.ordering.HeaderText = "受信順序";
            this.ordering.Name = "ordering";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名前";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dispnameDataGridViewTextBoxColumn
            // 
            this.dispnameDataGridViewTextBoxColumn.DataPropertyName = "disp_name";
            this.dispnameDataGridViewTextBoxColumn.HeaderText = "表示名";
            this.dispnameDataGridViewTextBoxColumn.Name = "dispnameDataGridViewTextBoxColumn";
            // 
            // statusdisplayDataGridViewTextBoxColumn
            // 
            this.statusdisplayDataGridViewTextBoxColumn.DataPropertyName = "status_display";
            this.statusdisplayDataGridViewTextBoxColumn.HeaderText = "status_display";
            this.statusdisplayDataGridViewTextBoxColumn.Name = "statusdisplayDataGridViewTextBoxColumn";
            // 
            // filterlevelDataGridViewTextBoxColumn
            // 
            this.filterlevelDataGridViewTextBoxColumn.DataPropertyName = "filter_level";
            this.filterlevelDataGridViewTextBoxColumn.HeaderText = "filter_level";
            this.filterlevelDataGridViewTextBoxColumn.Name = "filterlevelDataGridViewTextBoxColumn";
            // 
            // configEntityBindingSource
            // 
            this.configEntityBindingSource.DataSource = typeof(AlbaAnalysis.Database.ConfigEntity);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.Location = new System.Drawing.Point(1092, 647);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(227, 79);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdapt
            // 
            this.buttonAdapt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdapt.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdapt.Location = new System.Drawing.Point(849, 647);
            this.buttonAdapt.Name = "buttonAdapt";
            this.buttonAdapt.Size = new System.Drawing.Size(237, 79);
            this.buttonAdapt.TabIndex = 6;
            this.buttonAdapt.Text = "適用";
            this.buttonAdapt.UseVisualStyleBackColor = true;
            this.buttonAdapt.Click += new System.EventHandler(this.buttonAdapt_Click_1);

            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReset.Location = new System.Drawing.Point(1325, 647);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(209, 79);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1551, 770);
            this.tabControl1.TabIndex = 2;
            // 
            // ConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 770);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigDialog";
            this.Text = "ConfigDialog";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigAttribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configEntityBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewConfigAttribute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource configEntityBindingSource;
        private System.Windows.Forms.Button buttonAdapt;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordering;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filterlevelDataGridViewTextBoxColumn;
    }
}