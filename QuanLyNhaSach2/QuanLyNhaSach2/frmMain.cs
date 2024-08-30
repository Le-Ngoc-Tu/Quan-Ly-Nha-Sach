using QuanLyNhaSach2.Model;
using QuanLyNhaSach2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2
{
    public partial class frmMain : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public frmMain()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        static frmMain _obj;
        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 90)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            lbUser.Text = frmDangNhap.username;
            lbRole.Text = frmDangNhap.role;
            if (lbRole.Text == "Nhân Viên")
            {
                btnCate.Visible = false;
                btnUser.Visible = false;
                btnNSX.Visible = false;
            }
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddControls(new frmCustomerView());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddControls(new frmUserView());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            AddControls(new frmOrder());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            AddControls(new frmBillAdd());
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            AddControls(new frmNSXView());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            AddControls(new frmReportView());
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
