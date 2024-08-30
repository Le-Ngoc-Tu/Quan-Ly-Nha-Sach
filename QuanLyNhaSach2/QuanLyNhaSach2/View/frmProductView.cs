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
    public partial class frmProductView : SampleViewcs
    {
        public frmProductView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmProductAdd());
            frmProductView_Load(sender, e);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgProduct.DataSource = ml.Search("sp_SearchBook", txtSearch.Text);
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            dgProduct.DataSource = ml.LoadData("sp_SelectBook");
            if (frmDangNhap.role == "Nhân Viên")
            {
                dgProduct.Columns["dgvEdit"].Visible = false;
                dgProduct.Columns["dgvDel"].Visible = false;
            }
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProduct.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmProductAdd frm = new frmProductAdd();

                frm.id = Convert.ToInt32(dgProduct.CurrentRow.Cells["dgvId"].Value);
                frm.txtTitle.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvTitle"].Value);
                frm.cID = Convert.ToInt32(dgProduct.CurrentRow.Cells["dgvCategory"].Value);
                frm.txtAuthor.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvAuthor"].Value);
                frm.nsxID = Convert.ToInt32(dgProduct.CurrentRow.Cells["dgvNSX"].Value);
                frm.txtDesc.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvDesc"].Value);
                frm.txtQuantity.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvQuantity"].Value);
                frm.txtCost.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvCost"].Value);
                frm.txtPrice.Text = Convert.ToString(dgProduct.CurrentRow.Cells["dgvPrice"].Value);
                MainClass.BlurBackground(frm);

                frmProductView_Load(sender, e);
            }
            if (dgProduct.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không!?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgProduct.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DelBook";
                    ml.message_delete(query, id);

                    frmProductView_Load(sender, e);
                }
            }
        }
    }
}
