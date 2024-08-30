using QuanLyNhaSach2.View;
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
    public partial class frmCategoryAdd : SampleAdd
    {
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public int id = 0;

        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ml.message("sp_Category", txtName.Text);
                txtName.Text = "";

            }
            else
            {
                ml.message_edit("sp_EditCategory", id, txtName.Text);
            }
        }

        public override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {
            txtName.Select();
            this.ActiveControl = txtName;
            txtName.Focus();
        }

        private void frmCategoryAdd_Load_1(object sender, EventArgs e)
        {

        }
    }
}
