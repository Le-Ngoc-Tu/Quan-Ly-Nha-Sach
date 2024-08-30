using QuanLyNhaSach2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    public partial class frmCustomerView : SampleViewcs
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerAdd());
            frmCustomerView_Load(sender, e);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgCustomer.DataSource = ml.Search("sp_SearchCustomer", txtSearch.Text);
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            dgCustomer.DataSource = ml.LoadData("sp_SelectCustomer");
            if (frmDangNhap.role == "Nhân Viên")
            {
                dgCustomer.Columns["dgvEdit"].Visible = false;
                dgCustomer.Columns["dgvDel"].Visible = false;
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCustomer.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmCustomerAdd frm = new frmCustomerAdd();

                frm.id = Convert.ToInt32(dgCustomer.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgCustomer.CurrentRow.Cells["dgvName"].Value);
                if (dgCustomer.CurrentRow.Cells["dgvSex"].Value == "Nữ")
                {
                    frm.btnMale.Checked = true;

                }
                else if (dgCustomer.CurrentRow.Cells["dgvSex"].Value == "Nam")
                {
                    frm.btnMale.Checked = false;

                }
                //frm.btnMale.Checked = Convert.ToBoolean(dgCustomer.CurrentRow.Cells["dgvSex"].Value);
                frm.txtAddress.Text = Convert.ToString(dgCustomer.CurrentRow.Cells["dgvAddress"].Value);
                frm.txtPhone.Text = Convert.ToString(dgCustomer.CurrentRow.Cells["dgvPhone"].Value);
                frm.txtEmail.Text = Convert.ToString(dgCustomer.CurrentRow.Cells["dgvEmail"].Value);
                MainClass.BlurBackground(frm);

                frmCustomerView_Load(sender, e);
            }
            if (dgCustomer.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không!?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgCustomer.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DelCustomer";
                    ml.message_delete(query, id);

                    frmCustomerView_Load(sender, e);
                }
            }
        }
    }
}
