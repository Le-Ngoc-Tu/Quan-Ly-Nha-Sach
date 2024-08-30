using QuanLyNhaSach2.Properties;
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
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        MainClass ml = new MainClass();
        public int id = 0;
        public int cID = 0;
        public int nsxID = 0;

        DataTable InsertBook(string title, int cateID, string author, int NSXID, string desc, byte[] image, int quantity, int cost, int price, DateTime createDate)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateBook", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@cateID", cateID);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@nsxID", NSXID);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@createdate", createDate);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        DataTable EditBook(int id, int quantity, int cost, int price)
        {
            SqlCommand cmd = new SqlCommand("sp_EditBook", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@price", price);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        DataTable GetBookByID(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_selectBookID", kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string filePath;
        byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Xử lý hình ảnh
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            string cateID = cbbCategory.SelectedValue.ToString();
            string NSXID = cbNSX.SelectedValue.ToString();
            DateTime createDate = DateTime.Now;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text) || cbbCategory.SelectedIndex == -1 || cbNSX.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (id == 0)
                {
                    DataTable dt = new DataTable();
                    dt = InsertBook(txtTitle.Text, int.Parse(cateID), txtAuthor.Text, int.Parse(NSXID), txtDesc.Text, imageByteArray, int.Parse(txtQuantity.Text), int.Parse(txtCost.Text), int.Parse(txtPrice.Text), createDate);
                    MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                    txtTitle.Text = txtAuthor.Text = txtQuantity.Text = txtQuantity.Text = txtCost.Text = txtPrice.Text = txtDesc.Text = "";
                    cbbCategory.SelectedIndex = cbNSX.SelectedIndex = 0;
                    cbbCategory.SelectedIndex = cbNSX.SelectedIndex = -1;
                    id = 0;
                    cID = 0;
                    nsxID = 0;
                    txtImage.Image = Resources.product;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = EditBook(id, int.Parse(txtQuantity.Text), int.Parse(txtCost.Text), int.Parse(txtPrice.Text));
                    MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
                }
            }
        }

        private void ForUpdateLoadData()
        {
            DataTable dt = new DataTable();
            dt = GetBookByID(id);

            if (dt.Rows.Count > 0)
            {
                txtTitle.Text = dt.Rows[0]["Title"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["Image"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            cbbCategory.DisplayMember = "CateName";
            cbbCategory.ValueMember = "ID";
            cbbCategory.DataSource = ml.ComboboxFill("sp_SelectCategory", cbbCategory);
            cbbCategory.SelectedIndex = -1;

            cbNSX.DisplayMember = "Name";
            cbNSX.ValueMember = "ID";
            cbNSX.DataSource = ml.ComboboxFill("sp_SelectNSX", cbNSX);
            cbNSX.SelectedIndex = -1;

            if (cID > 0)
            {
                cbbCategory.SelectedValue = cID;                
            }

            if(nsxID > 0)
            {
                cbNSX.SelectedValue = nsxID;
            }

            ForUpdateLoadData();
        }
    }
}
