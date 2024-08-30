using QuanLyNhaSach2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2.Report
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        public  DateTime datestart = DateTime.MinValue;
        public  DateTime dateend = DateTime.MaxValue;
        private void RptDoanhThu_Load(object sender, EventArgs e)
        {
            rptDoanhThu rptdoanhthu = new rptDoanhThu();
            rptdoanhthu.Refresh();
            rptdoanhthu.SetParameterValue("@datestart", datestart);
            rptdoanhthu.SetParameterValue("@dateend", dateend);
            RptDoanhThu.ReportSource = rptdoanhthu;
        }
    }
}
