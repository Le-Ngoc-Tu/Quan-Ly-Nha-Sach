using QuanLyNhaSach2.Report;
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

namespace QuanLyNhaSach2.Model
{
    public partial class frmBillAdd : Form
    {
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public static int id = 0;
        public frmBillAdd()
        {
            InitializeComponent();
        }

        private void frmBillAdd_Load(object sender, EventArgs e)
        {
            dgOrder.DataSource = LoadData();
        }
        public DataTable LoadData()
        {
            SqlCommand cmd = new SqlCommand("sp_LoadDetail", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgOrder.DataSource = ml.Search("sp_SearchOrder", txtSearch.Text);
        }

        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOrder.CurrentCell.OwningColumn.Name == "dgvPrint")
            {
                id = Convert.ToInt32(dgOrder.CurrentRow.Cells["dgvID"].Value); ;
                frmPrintBill frmPrint = new frmPrintBill();
                frmPrint.ShowDialog();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
