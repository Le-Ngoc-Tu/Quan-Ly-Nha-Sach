namespace QuanLyNhaSach2.Report
{
    partial class frmDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RptDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptDoanhThu
            // 
            this.RptDoanhThu.ActiveViewIndex = -1;
            this.RptDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.RptDoanhThu.Name = "RptDoanhThu";
            this.RptDoanhThu.Size = new System.Drawing.Size(800, 450);
            this.RptDoanhThu.TabIndex = 0;
            this.RptDoanhThu.Load += new System.EventHandler(this.RptDoanhThu_Load);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RptDoanhThu);
            this.Name = "frmDoanhThu";
            this.Text = "Báo cáo doanh thu";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptDoanhThu;
    }
}