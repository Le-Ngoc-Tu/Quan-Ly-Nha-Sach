namespace QuanLyNhaSach2.Report
{
    partial class frmPrintBill
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
            this.RptPrintBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptPrintBill
            // 
            this.RptPrintBill.ActiveViewIndex = -1;
            this.RptPrintBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptPrintBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptPrintBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptPrintBill.Location = new System.Drawing.Point(0, 0);
            this.RptPrintBill.Name = "RptPrintBill";
            this.RptPrintBill.Size = new System.Drawing.Size(1050, 455);
            this.RptPrintBill.TabIndex = 0;
            // 
            // frmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 455);
            this.Controls.Add(this.RptPrintBill);
            this.Name = "frmPrintBill";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frmPrintBill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptPrintBill;
    }
}