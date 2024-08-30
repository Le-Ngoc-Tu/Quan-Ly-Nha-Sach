using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    partial class frmReportView
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
            this.btnRptDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapSach = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formDoanhThu = new ScottPlot.FormsPlot();
            this.dtstart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRptDoanhThu
            // 
            this.btnRptDoanhThu.AutoRoundedCorners = true;
            this.btnRptDoanhThu.BorderRadius = 31;
            this.btnRptDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRptDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRptDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRptDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRptDoanhThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnRptDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRptDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnRptDoanhThu.Location = new System.Drawing.Point(3, 186);
            this.btnRptDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRptDoanhThu.Name = "btnRptDoanhThu";
            this.btnRptDoanhThu.Size = new System.Drawing.Size(319, 65);
            this.btnRptDoanhThu.TabIndex = 4;
            this.btnRptDoanhThu.Text = "Báo cáo doanh thu";
            this.btnRptDoanhThu.Click += new System.EventHandler(this.btnRptDoanhThu_Click);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.AutoRoundedCorners = true;
            this.btnNhapSach.BorderRadius = 32;
            this.btnNhapSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnNhapSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhapSach.ForeColor = System.Drawing.Color.White;
            this.btnNhapSach.Location = new System.Drawing.Point(3, 316);
            this.btnNhapSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(319, 67);
            this.btnNhapSach.TabIndex = 6;
            this.btnNhapSach.Text = "Thống kê số lượng sách trong kho";
            this.btnNhapSach.Click += new System.EventHandler(this.btnNhapSach_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRptDoanhThu);
            this.panel1.Controls.Add(this.btnNhapSach);
            this.panel1.Location = new System.Drawing.Point(659, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 543);
            this.panel1.TabIndex = 7;
            // 
            // formDoanhThu
            // 
            this.formDoanhThu.Location = new System.Drawing.Point(14, 89);
            this.formDoanhThu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formDoanhThu.Name = "formDoanhThu";
            this.formDoanhThu.Size = new System.Drawing.Size(637, 464);
            this.formDoanhThu.TabIndex = 8;
            // 
            // dtstart
            // 
            this.dtstart.AutoRoundedCorners = true;
            this.dtstart.BorderRadius = 17;
            this.dtstart.Checked = true;
            this.dtstart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.dtstart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtstart.ForeColor = System.Drawing.Color.White;
            this.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtstart.Location = new System.Drawing.Point(47, 27);
            this.dtstart.MaxDate = new System.DateTime(2029, 1, 1, 0, 0, 0, 0);
            this.dtstart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtstart.Name = "dtstart";
            this.dtstart.Size = new System.Drawing.Size(250, 36);
            this.dtstart.TabIndex = 7;
            this.dtstart.Value = new System.DateTime(2023, 10, 22, 10, 40, 27, 842);
            // 
            // dtend
            // 
            this.dtend.AutoRoundedCorners = true;
            this.dtend.BorderRadius = 17;
            this.dtend.Checked = true;
            this.dtend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.dtend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtend.ForeColor = System.Drawing.Color.White;
            this.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtend.Location = new System.Drawing.Point(376, 27);
            this.dtend.MaxDate = new System.DateTime(2029, 1, 1, 0, 0, 0, 0);
            this.dtend.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtend.Name = "dtend";
            this.dtend.Size = new System.Drawing.Size(250, 36);
            this.dtend.TabIndex = 8;
            this.dtend.Value = new System.DateTime(2023, 10, 22, 10, 40, 27, 842);
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 558);
            this.Controls.Add(this.dtend);
            this.Controls.Add(this.formDoanhThu);
            this.Controls.Add(this.dtstart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportView";
            this.Text = "frmReportView";
            this.Load += new System.EventHandler(this.frmReportView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRptDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnNhapSach;
        private Panel panel1;
        private ScottPlot.FormsPlot formDoanhThu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtend;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtstart;
    }
}