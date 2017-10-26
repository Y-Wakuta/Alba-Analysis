namespace AlbaAnalysis {
    partial class Detail {
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
            this.textBoxYValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXValue = new System.Windows.Forms.TextBox();
            this.bindingSourceX = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceY = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceY)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxYValue
            // 
            this.textBoxYValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxYValue.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.textBoxYValue.Location = new System.Drawing.Point(106, 93);
            this.textBoxYValue.Name = "textBoxYValue";
            this.textBoxYValue.ReadOnly = true;
            this.textBoxYValue.Size = new System.Drawing.Size(549, 77);
            this.textBoxYValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 90);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxXValue
            // 
            this.textBoxXValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxXValue.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.textBoxXValue.Location = new System.Drawing.Point(106, 3);
            this.textBoxXValue.Name = "textBoxXValue";
            this.textBoxXValue.ReadOnly = true;
            this.textBoxXValue.Size = new System.Drawing.Size(549, 77);
            this.textBoxXValue.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.22939F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxXValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYValue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.62337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.37663F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 176);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Detail";
            this.Text = "詳細表示";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceY)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXValue;
        private System.Windows.Forms.BindingSource bindingSourceX;
        private System.Windows.Forms.BindingSource bindingSourceY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}