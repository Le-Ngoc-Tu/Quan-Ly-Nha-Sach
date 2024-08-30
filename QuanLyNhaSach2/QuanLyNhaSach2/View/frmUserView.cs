using QuanLyNhaSach2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    public partial class frmUserView : SampleViewcs
    {
        public frmUserView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd());
            frmUserView_Load(sender, e);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgUsers.DataSource = ml.Search("sp_SearchUsers", txtSearch.Text);
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            dgUsers.DataSource = ml.LoadData("sp_SelectUsers");
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsers.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmUserAdd frm = new frmUserAdd();

                frm.id = Convert.ToInt32(dgUsers.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvName"].Value);
                if (dgUsers.CurrentRow.Cells["dgvSex"].Value == "Nữ")
                {
                    frm.btnMale.Checked = true;

                }
                else if (dgUsers.CurrentRow.Cells["dgvSex"].Value == "Nam")
                {
                    frm.btnMale.Checked = false;
                    
                }
                //frm.btnMale.Checked = Convert.ToBoolean(dgUsers.CurrentRow.Cells["dgvSex"].Value);
                frm.txtAddress.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvAddress"].Value);
                frm.txtPhone.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvPhone"].Value);
                frm.roleID = Convert.ToInt32(dgUsers.CurrentRow.Cells["dgvRole"].Value);
                frm.txtIdentifyCard.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvIdetifyCard"].Value);
                frm.txtEmail.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvEmail"].Value);
                frm.txtUser.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvUserName"].Value);
                frm.txtPass.Text = Convert.ToString(dgUsers.CurrentRow.Cells["dgvPass"].Value);
                MainClass.BlurBackground(frm);

                frmUserView_Load(sender, e);
            }
            if (dgUsers.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không!?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgUsers.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DelUsers";
                    ml.message_delete(query, id);

                    frmUserView_Load(sender, e);
                }
            }
        }
    }
}
