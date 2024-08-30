
using QuanLyNhaSach2.Report;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaSach2.View
{
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void frmReportView_Load(object sender, EventArgs e)
        {
           
            dtstart.Value = dtstart.MinDate;
            dtend.Value = dtend.MaxDate;
            LoadBieuDo();
        }
        public void LoadBieuDo()
        {
            // Truy vấn dữ liệu từ cơ sở dữ liệu
            string query = "SELECT createdate, SUM(total) AS total FROM Orders GROUP BY createdate";
            SqlCommand command = new SqlCommand(query, kn.connection());
            SqlDataReader reader = command.ExecuteReader();
            List<DateTime> dateList = new List<DateTime>();
            List<double> totalList = new List<double>();

            while (reader.Read())
            {
                DateTime date = reader.GetDateTime(0);
                double total = Convert.ToDouble(reader.GetInt32(1));
                dateList.Add(date);
                totalList.Add(total);
            }

            reader.Close();


            // Tạo một từ điển để ánh xạ từ DateTime ban đầu sang giá trị int
            Dictionary<DateTime, int> dateToIndex = new Dictionary<DateTime, int>();
            for (int i = 0; i < dateList.Count; i++)
            {
                dateToIndex[dateList[i]] = i + 1;
            }

            // Chuyển các giá trị DateTime thành giá trị int dựa trên từ điển dateToIndex
            double[] dateArray = dateList.Select(date => (double)dateToIndex[date]).ToArray();
            double[] totalArray = totalList.ToArray();

            // Đưa dữ liệu vào biểu đồ
            var plt = formDoanhThu.Plot.AddScatter(dateArray, totalArray);
            plt.LineStyle = LineStyle.Solid;
            plt.MarkerSize = 0;
            plt.Color = System.Drawing.Color.FromArgb(255, 105, 105);
            formDoanhThu.Plot.Title("Biểu đồ danh giá doanh thu của cửa hàng");
            formDoanhThu.Render();
            formDoanhThu.Refresh();
        }

        private void btnRptDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frmdoanhthu = new frmDoanhThu();
            frmdoanhthu.datestart = dtstart.Value;
            frmdoanhthu.dateend = dtend.Value;
            frmdoanhthu.ShowDialog();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            frm.ShowDialog();
        }
    }
}
