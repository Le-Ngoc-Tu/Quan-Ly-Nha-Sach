using Guna.UI2.WinForms;
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
using System.Xml.Linq;

namespace QuanLyNhaSach2.View
{
    public partial class frmNSXView : SampleViewcs
    {
        public frmNSXView()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmNSXAdd());
            frmNSXView_Load(sender, e);
        }

        private void frmNSXView_Load(object sender, EventArgs e)
        {
            dgNSX.DataSource = ml.LoadData("sp_SelectNSX");
        }

        private void dgNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgNSX.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmNSXAdd frm = new frmNSXAdd();

                frm.id = Convert.ToInt32(dgNSX.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dgNSX.CurrentRow.Cells["dgvName"].Value);
                frm.txtAddress.Text = Convert.ToString(dgNSX.CurrentRow.Cells["dgvAddress"].Value);
                frm.txtPhone.Text = Convert.ToString(dgNSX.CurrentRow.Cells["dgvPhone"].Value);
                frm.txtEmail.Text = Convert.ToString(dgNSX.CurrentRow.Cells["dgvEmail"].Value);
                MainClass.BlurBackground(frm);

                frmNSXView_Load(sender, e);
            }
            if (dgNSX.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Bạn có muốn xóa không!?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgNSX.CurrentRow.Cells["dgvId"].Value);
                    string query = "sp_DelNSX";
                    ml.message_delete(query, id);

                    frmNSXView_Load(sender, e);
                }
            }
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgNSX.DataSource = ml.Search("sp_SearchNSX", txtSearch.Text);
        }      
    }
}
