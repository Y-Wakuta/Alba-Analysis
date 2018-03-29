namespace AlbaAnalysis {
    partial class AlbaChart {
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbaChart
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Click += new System.EventHandler(this.AlbaChart_Click_1);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.AlbaChart_Layout);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AlbaChart_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
