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
    public partial class SampleViewcs : Form
    {
        
        public SampleViewcs()
        {
            InitializeComponent();
        }
        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
        }
    }
}
