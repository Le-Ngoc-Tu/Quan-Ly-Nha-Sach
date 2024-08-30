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
    public partial class frmSuccess : Form
    {
        public frmSuccess()
        {
            InitializeComponent();
        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;

            if (startpoint > 30)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
