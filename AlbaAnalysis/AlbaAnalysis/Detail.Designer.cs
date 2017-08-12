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
            this.textBoxYValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxYValue
            // 
            this.textBoxYValue.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.textBoxYValue.Location = new System.Drawing.Point(102, 139);
            this.textBoxYValue.Name = "textBoxYValue";
            this.textBoxYValue.ReadOnly = true;
            this.textBoxYValue.Size = new System.Drawing.Size(307, 77);
            this.textBoxYValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // textBoxXValue
            // 
            this.textBoxXValue.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.textBoxXValue.Location = new System.Drawing.Point(102, 25);
            this.textBoxXValue.Name = "textBoxXValue";
            this.textBoxXValue.ReadOnly = true;
            this.textBoxXValue.Size = new System.Drawing.Size(307, 77);
            this.textBoxXValue.TabIndex = 3;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 268);
            this.Controls.Add(this.textBoxXValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYValue);
            this.Name = "Detail";
            this.Text = "Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXValue;
    }
}