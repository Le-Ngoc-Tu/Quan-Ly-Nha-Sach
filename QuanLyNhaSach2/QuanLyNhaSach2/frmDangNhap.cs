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

namespace QuanLyNhaSach2
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public static string username = "";
        public static string role = "";
        public static int userID = 0;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            checkpass.Checked = false;
            txtUserName.Focus();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_Login", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassWord.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (int.Parse(dt.Rows[0]["errcode"].ToString()) == 1)
            {
                userID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                username = dt.Rows[0]["Name"].ToString();
                role = dt.Rows[0]["RoleName"].ToString();
                frmMain frm = new frmMain();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công! Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
                txtPassWord.PasswordChar = '\0';
            else
                txtPassWord.PasswordChar = '*';
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                Login_Click(sender, e);
            }
        }
    }
}
