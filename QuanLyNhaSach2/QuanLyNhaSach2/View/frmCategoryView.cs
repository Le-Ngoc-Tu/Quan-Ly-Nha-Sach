using Guna.UI2.WinForms;
using QuanLyNhaSach2;
using QuanLyNhaSach2.Model;
using System;
using System.Collections;
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
    public partial class frmCategoryView : SampleViewcs
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCategoryAdd());
            frmCategoryView_Load(sender, e);

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgCatalog.DataSource = ml.Search("sp_CategorySearch", txtSearch.Text);
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            dgCatalog.DataSource = ml.LoadData("sp_SelectCategory");
        }

        private void dgCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCatalog.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmCategoryAdd frm = new frmCategoryAdd();

                frm.id = Convert.ToInt32(dgCatalog.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgCatalog.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackground(frm);           
                frmCategoryView_Load(sender, e);
            }
            if (dgCatalog.CurrentCell.OwningColumn.Name == "dgvDel")
            {

                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không!?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgCatalog.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_CategoryDel";
                    ml.message_delete(query, id);

                    frmCategoryView_Load(sender, e);
                }
            }
        }
    }
}
