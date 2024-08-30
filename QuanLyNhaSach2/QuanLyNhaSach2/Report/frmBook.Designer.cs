namespace QuanLyNhaSach2.Report
{
    partial class frmBook
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
            this.rptBook = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptBook
            // 
            this.rptBook.ActiveViewIndex = -1;
            this.rptBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBook.Location = new System.Drawing.Point(0, 0);
            this.rptBook.Name = "rptBook";
            this.rptBook.Size = new System.Drawing.Size(800, 450);
            this.rptBook.TabIndex = 0;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBook);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptBook;
    }
}