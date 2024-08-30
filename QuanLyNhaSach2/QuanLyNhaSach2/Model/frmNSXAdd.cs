using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2.Model
{
    public partial class frmNSXAdd : SampleAdd
    {
        public frmNSXAdd()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public int id = 0;
        DataTable InsertNSX(string name, string address, string phone, string email)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateNSX", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        DataTable EditNSX(int id, string name, string address, string phone, string email)
        {
            SqlCommand cmd = new SqlCommand("sp_EditNSX", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Phương thức kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            // Biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^(?!\.)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailPattern);
        }

        public override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (id == 0)
                {
                    DataTable dt = new DataTable();
                    dt = InsertNSX(txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
                    MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                    txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = "";
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = EditNSX(id, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
                    MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu ký tự không phải là số và không phải là ký tự control (như backspace),
                // thì ngăn không cho nó được nhập và hiển thị thông báo.
                e.Handled = true;

                // Hiển thị thông báo
                MessageBox.Show("Vui lòng chỉ nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmNSXAdd_Load(object sender, EventArgs e)
        {
            txtName.Select();
            this.ActiveControl = txtName;
            txtName.Focus();

            // Kiểm tra email hợp lệ
            emailErrorProvider = new ErrorProvider();
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Ngăn chớp lỗi
            emailErrorProvider.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight); // Đặt vị trí của biểu tượng lỗi
            emailErrorProvider.SetIconPadding(txtEmail, 2); // Đặt khoảng cách giữa TextBox và biểu tượng lỗi

            // Kiểm tra SDT hợp lệ
            SDTErrorProvider = new ErrorProvider();
            SDTErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Ngăn chớp lỗi
            SDTErrorProvider.SetIconAlignment(txtPhone, ErrorIconAlignment.MiddleRight); // Đặt vị trí của biểu tượng lỗi
            SDTErrorProvider.SetIconPadding(txtPhone, 2); // Đặt khoảng cách giữa TextBox và biểu tượng lỗi
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!IsValidEmail(email))
            {
                emailErrorProvider.SetError(txtEmail, "Email không hợp lệ. Vui lòng kiểm tra lại.");
            }
            else
            {
                emailErrorProvider.SetError(txtEmail, ""); // Xóa thông báo lỗi nếu email hợp lệ
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            if (phoneNumber.Length != 10)
            {
                SDTErrorProvider.SetError(txtPhone, "Số điện thoại không hợp lệ. Vui lòng kiểm tra lại.");
            }
            else
            {
                SDTErrorProvider.SetError(txtPhone, ""); // Xóa thông báo lỗi nếu số điện thoại hợp lệ
            }
        }
    }
}
