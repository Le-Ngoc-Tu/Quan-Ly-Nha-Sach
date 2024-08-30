using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2.Model
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;
        private int initialQuantity; // Thêm biến để lưu số lượng ban đầu
        private int currentQuantity;
        public int Id { get; set; }

        public string PQuantity
        {
            get { return lblSoLuong.Text; }
            set { lblSoLuong.Text = value; }
        }

        public string PQty
        {
            get { return btnQty.Text; }
            set { btnQty.Text = value; }
        }

       

        public string PPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string PCateName
        {
            get { return lblCateName.Text; }
            set { lblCateName.Text = value; }
        }
        public string PCate
        {
            get;
            set;
        }
        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        public double TotalAmount()
        {
            double qty = Convert.ToDouble(PQty);
            double price = Convert.ToDouble(PPrice);
            return qty * price;
        }
        // Khởi tạo giá trị ban đầu
        public void Initialize(int quantity)
        {
            initialQuantity = quantity;
            currentQuantity = quantity; // Số lượng hiện tại ban đầu cũng là số lượng ban đầu
            PQuantity = quantity.ToString();
        }
        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
            // Sau khi thêm sản phẩm vào giỏ hàng, cập nhật lblSoLuong
            int selectedQuantity = Convert.ToInt32(btnQty.Text);
            currentQuantity -= selectedQuantity;
            PQuantity = currentQuantity.ToString();
            btnQty.Value = 0;
        }
        public void IncreaseQuantity(int quantityToAdd)
        {
            int soluong = int.Parse(lblSoLuong.Text);
            soluong += quantityToAdd;
            currentQuantity = soluong;
            lblSoLuong.Text = currentQuantity.ToString();
            btnQty.Text = "0";
        }
    }
}
