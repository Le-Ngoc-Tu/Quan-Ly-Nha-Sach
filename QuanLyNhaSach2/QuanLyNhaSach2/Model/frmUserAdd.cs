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
    public partial class frmUserAdd : SampleAdd

    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public int id = 0;
        public int roleID = 0;

        DataTable InsertUsers(string name, bool male, string address, string phone, string roleID, string identityCard, string email, string userName, string passWord)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateUsers", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", SqlDbType.Bit).Value = male ? 1 : 0;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("roleID", roleID);
            cmd.Parameters.AddWithValue("IdentityCard", identityCard);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("UserName", userName);
            cmd.Parameters.AddWithValue("PassWord", passWord);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        DataTable EditUsers(int id, string name, bool male, string address, string phone, string roleID, string identityCard, string email, string userName, string passWord)
        {
            SqlCommand cmd = new SqlCommand("sp_EditUsers", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", SqlDbType.Bit).Value = male ? 1 : 0;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("roleID", roleID);
            cmd.Parameters.AddWithValue("IdentityCard", identityCard);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("UserName", userName);
            cmd.Parameters.AddWithValue("PassWord", passWord);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            //cb fill
            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "ID";
            cbbRole.DataSource = ml.ComboboxFill("sp_SelectRole", cbbRole);
            cbbRole.SelectedIndex = 0;

            if(roleID > 0)
            {
                cbbRole.SelectedValue = roleID;
            }

            // focus form
            txtName.Select();
            this.ActiveControl = txtName;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roleID = cbbRole.SelectedValue.ToString();
            bool male = btnMale.Checked;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtIdentifyCard.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtUser.Text) || cbbRole.SelectedIndex == -1 ||(btnMale.Checked = false) && (btnFemale.Checked = false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            if (id == 0)
            {
                DataTable dt = new DataTable();
                dt = InsertUsers(txtName.Text, male, txtAddress.Text, txtPhone.Text,
roleID, txtIdentifyCard.Text, txtEmail.Text, txtUser.Text, txtPass.Text);
                MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                id = 0;
                txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = txtIdentifyCard.Text = txtUser.Text = txtPass.Text = "";
                cbbRole.SelectedIndex = 0;
                cbbRole.SelectedIndex = -1;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = EditUsers(id, txtName.Text, male, txtAddress.Text, txtPhone.Text,
roleID, txtIdentifyCard.Text, txtEmail.Text, txtUser.Text, txtPass.Text);
                MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
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

        private void txtIdentifyCard_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
