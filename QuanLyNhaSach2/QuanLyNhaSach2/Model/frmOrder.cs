using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNhaSach2.Model
{
    public partial class frmOrder : Form
    {
        public struct Product
        {
            public string ProductID { get; set; }
            public int Quantity { get; set; }
        }
        public frmOrder()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();

        private void btnBill_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmBillAdd());
        }

        public void LoadCbCustomer()
        {
            cbbCustomer.DisplayMember = "Name";
            cbbCustomer.ValueMember = "ID";
            cbbCustomer.DataSource = ml.ComboboxFill("sp_SelectCustomer", cbbCustomer);
            cbbCustomer.SelectedIndex = -1;
        }

        DataTable InsertCustomer(string name, bool male, string address, string phone, string email)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateCustomer", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", SqlDbType.Bit).Value = male ? 1 : 0;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dgOrder.BorderStyle = BorderStyle.FixedSingle;
            addCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();

            cbbCustomer.DisplayMember = "Name";
            cbbCustomer.ValueMember = "ID";
            cbbCustomer.DataSource = ml.ComboboxFill("sp_SelectCustomer", cbbCustomer);
            cbbCustomer.SelectedIndex = -1;
            dtpCreateDate.Format = DateTimePickerFormat.Custom;
            dtpCreateDate.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dtpCreateDate.Value = DateTime.Now;
        }
        private string selectedCategoryName = ""; // Lưu tên của nút danh mục đã chọn
        private bool categoryButtonSelected = false; // Trạng thái nút danh mục đã được chọn hay chưa
        private void addCategory()
        {
            DataTable dt = new DataTable();
            dt = ml.LoadData("sp_SelectCategory");

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                    btn.FillColor = Color.FromArgb(50, 55, 89);
                    btn.Size = new Size(149, 43);
                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.Text = row["CateName"].ToString();

                    CategoryPanel.Controls.Add(btn);

                    // Đặt sự kiện Click cho nút
                    btn.Click += (sender, e) =>
                    {

                        // Lấy ra CateName từ nút được nhấn
                        string selectedCateName = btn.Text;

                        // Kiểm tra trạng thái của nút, nếu đã được chọn trước đó thì load lại dữ liệu
                        if (categoryButtonSelected && selectedCateName == selectedCategoryName)
                        {

                            LoadProducts();
                        }
                        else
                        {
                            // Duyệt qua tất cả sản phẩm trong ProductPanel và ẩn hiện dựa trên CateName
                            foreach (Control productControl in ProductPanel.Controls)
                            {
                                if (productControl is ucProduct product)
                                {
                                    // So sánh CateName của sản phẩm với CateName đã chọn
                                    if (product.PCateName.Equals(selectedCateName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        product.Visible = true; // Hiển thị sản phẩm
                                    }
                                    else
                                    {
                                        product.Visible = false; // Ẩn sản phẩm không phù hợp
                                    }
                                }
                            }
                        }

                        // Cập nhật trạng thái của nút và tên nút đã chọn
                        categoryButtonSelected = true;

                        selectedCategoryName = selectedCateName;
                    };
                }
            }
        }

        private void addItems(string id, string name, string cate, string catename, string quantity, string price, Image image)
        {
            var product = new ucProduct()
            {
                Id = Convert.ToInt32(id),
                PName = name,
                PCate = cate,
                PCateName = catename,
                PPrice = price,
                PQuantity = quantity,
                PImage = image
            };
            // Khởi tạo số lượng ban đầu
            int initialQuantity = Convert.ToInt32(quantity);
            product.Initialize(initialQuantity);
            //....
            ProductPanel.Controls.Add(product);

            product.onSelect += (ss, ee) =>
            {
                var productDg = (ucProduct)ss;

                // Thêm sản phẩm vào DataGridView (dgOrder)
                dgOrder.Rows.Add(new object[] { productDg.Id, productDg.PName, productDg.PQty, productDg.PPrice, productDg.TotalAmount() });
                // Giảm số lượng mỗi khi chọn thêm vào giỏ hàng

                // Cập nhật tổng
                decimal total = CalculateTotal();
                txtTotal.Text = total.ToString("N0"); // Cập nhật giá trị vào TextBox txtTotal
            };

        }

        private void LoadProducts()
        {
            DataTable dt = new DataTable();
            dt = ml.LoadData("sp_LoadProduct");
            //định dạng lại giá tiền
            foreach (DataRow item in dt.Rows)
            {
                //Định dạng giá tiền
                string priceString = item["Price"].ToString(); // Lấy giá tiền dưới dạng chuỗi
                double priceDouble;

                Byte[] imageArray = (byte[])item["Image"];
                byte[] imageByteArray = imageArray;

                if (double.TryParse(priceString, out priceDouble)) // Chuyển đổi chuỗi thành kiểu double
                {
                    string formattedPrice = priceDouble.ToString("N0"); // Định dạng giá tiền
                    addItems(item["BookID"].ToString(), item["Title"].ToString(), item["CategoryID"].ToString(), item["CateName"].ToString(), item["Quantity"].ToString(), formattedPrice, Image.FromStream(new MemoryStream(imageArray)));
                }
                else
                {
                    // Gán giá trị mặc định (ví dụ: 0) khi xảy ra lỗi
                    string defaultPrice = "0";
                    addItems(item["BookID"].ToString(), item["Title"].ToString(), item["CategoryID"].ToString(), item["CateName"].ToString(), item["Quantity"].ToString(), defaultPrice, Image.FromStream(new MemoryStream(imageArray)));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var product = (ucProduct)item;
                product.Visible = product.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerAdd());

            LoadCbCustomer();
            cbbCustomer.SelectedIndex = cbbCustomer.Items.Count - 1;
        }

        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgOrder.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                // Đặt nội dung thông báo thông qua phương thức Show
                DialogResult result = guna2MessageDialog1.Show("Bạn có muốn xóa không?");

                if (result == DialogResult.Yes)
                {
                    // Xóa dòng như đã mô tả trong câu trả lời trước
                    DataGridViewRow selectedRow = dgOrder.Rows[e.RowIndex];
                    // Lấy số lượng từ cột "SL" và ID sản phẩm tương ứng
                    int productID = int.Parse(selectedRow.Cells["dgvId"].Value.ToString());
                    int quantityToAdd = int.Parse(selectedRow.Cells["dgvQuantity"].Value.ToString());
                    // Gọi phương thức IncreaseQuantity trong UserControl Product tương ứng
                    // Tìm UserControl có ID tương ứng trong ProductPanel và gọi IncreaseQuantity
                    foreach (Control productControl in ProductPanel.Controls)
                    {
                        if (productControl is ucProduct product)
                        {
                            if (product.Id == productID)
                            {
                                product.IncreaseQuantity(quantityToAdd);
                            }
                        }
                    }
                    // Xóa dòng
                    dgOrder.Rows.Remove(selectedRow);
                    // Cập nhật tổng
                    decimal total = CalculateTotal();
                    txtTotal.Text = total.ToString(); // Cập nhật giá trị vào TextBox txtTotal
                }
            }
        }
        // Hàm tính tổng giá trị từ DataGridView
        private decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                if (row.Cells["dgvAmount"].Value != null)
                {
                    total += decimal.Parse(row.Cells["dgvAmount"].Value.ToString());
                }
            }

            return total;
        }
        private void dgOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        //test
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int userID = frmDangNhap.userID;
            int CustomerID = (int)cbbCustomer.SelectedValue;
            DateTime createDate = dtpCreateDate.Value;
            int quantity = CalculateTotalQuantity();
            string noidung = GetOrderDetails(); // Hàm này cần được triển khai để lấy thông tin cụ thể từ dgOrder
            decimal total = decimal.Parse(txtTotal.Text);
            // Tạo một danh sách để lưu thông tin sản phẩm đã thêm vào hóa đơn
            List<Product> products = new List<Product>();
            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                string productID = Convert.ToString(row.Cells["dgvTitle"].Value);
                int Quantity = Convert.ToInt32(row.Cells["dgvQuantity"].Value);

                // Thêm sản phẩm và số lượng tương ứng vào danh sách
                products.Add(new Product { ProductID = productID, Quantity = Quantity });
            }
            // Thực hiện cập nhật số lượng sản phẩm trong cơ sở dữ liệu
            UpdateProductQuantities(products);
            // Mở kết nối đến cơ sở dữ liệu
            SqlCommand cmd = new SqlCommand("sp_InsertOrder", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userid", userID);
            cmd.Parameters.AddWithValue("@customer", CustomerID);
            cmd.Parameters.AddWithValue("@createdate", createDate);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@noidung", noidung);
            cmd.Parameters.AddWithValue("@total", total);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0]["errmsg"].ToString() == "Thêm dữ liệu thành công")
            {
                frmSuccess frm = new frmSuccess();
                frm.ShowDialog();
            }
            // Xóa tất cả các dòng trong DataGridView
            dgOrder.Rows.Clear();

            // Đặt lại giá trị tổng về 0
            txtTotal.Text = "0";
            // Sau khi thêm dữ liệu, bạn có thể làm một số công việc khác, ví dụ: xóa dữ liệu trong dgOrder, làm mới giao diện, vv.
        }

        private int CalculateTotalQuantity()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                if (row.Cells["dgvQuantity"].Value != null)
                {
                    total += int.Parse(row.Cells["dgvQuantity"].Value.ToString());
                }
            }

            return total;
        }
        private string GetOrderDetails()
        {
            StringBuilder orderDetails = new StringBuilder();

            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                if (row.Cells["dgvTitle"].Value != null && row.Cells["dgvQuantity"].Value != null && row.Cells["dgvAmount"].Value != null)
                {
                    orderDetails.Append(row.Cells["dgvTitle"].Value.ToString());
                    orderDetails.Append("- số lượng: x");
                    orderDetails.Append(row.Cells["dgvQuantity"].Value.ToString());
                    orderDetails.Append("- Số tiền: ");
                    orderDetails.Append(row.Cells["dgvAmount"].Value.ToString());
                    orderDetails.Append(", "); // Sử dụng dấu phẩy để ngăn cách giữa các tiêu đề
                }
            }

            return orderDetails.ToString();
        }
        private void UpdateProductQuantities(List<Product> products)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-TGDRMFOH;Initial Catalog=QuanLyNhaSach1;Integrated Security=True"))
            {
                connection.Open();

                foreach (var product in products)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateProductQuantity", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", product.ProductID); // Sử dụng tên hoặc ID sản phẩm để xác định sản phẩm cần giảm số lượng
                        cmd.Parameters.AddWithValue("@Quantity", product.Quantity);

                        cmd.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }

    }
}
