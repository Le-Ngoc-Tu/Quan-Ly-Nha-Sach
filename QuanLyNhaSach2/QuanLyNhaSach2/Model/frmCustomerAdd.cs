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
    public partial class frmCustomerAdd : SampleAdd
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public int id = 0;

        DataTable InsertCustomer(string name, bool male, string address, string phone, string email)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateCustomer", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", SqlDbType.Bit).Value = male ? 1 : 0;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        DataTable EditCustomer(int id, string name, bool male, string address, string phone, string email)
        {
            SqlCommand cmd = new SqlCommand("sp_EditCustomer", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", SqlDbType.Bit).Value = male ? 1 : 0;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || (btnMale.Checked == false && btnMale.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                bool male = btnMale.Checked;
                if (id == 0)
                {
                    DataTable dt = new DataTable();
                    dt = InsertCustomer(txtName.Text, male, txtAddress.Text, txtPhone.Text, txtEmail.Text);
                    MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                    txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = "";
                    btnMale.Checked = btnFemale.Checked = false;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = EditCustomer(id, txtName.Text, male, txtAddress.Text, txtPhone.Text, txtEmail.Text);
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

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            txtName.Select();
            this.ActiveControl = txtName;
            txtName.Focus();
        }
    }
}
