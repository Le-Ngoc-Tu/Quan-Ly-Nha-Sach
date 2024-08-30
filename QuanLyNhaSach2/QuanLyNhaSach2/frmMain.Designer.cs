using QuanLyNhaSach2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnNSX = new Guna.UI2.WinForms.Guna2Button();
            this.btnCate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.centerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderRadius = 5;
            this.panelLeft.Controls.Add(this.btnUser);
            this.panelLeft.Controls.Add(this.btnNSX);
            this.panelLeft.Controls.Add(this.btnCate);
            this.panelLeft.Controls.Add(this.guna2PictureBox1);
            this.panelLeft.Controls.Add(this.guna2Button8);
            this.panelLeft.Controls.Add(this.btnStatistics);
            this.panelLeft.Controls.Add(this.btnBill);
            this.panelLeft.Controls.Add(this.btnOrder);
            this.panelLeft.Controls.Add(this.btnCustomer);
            this.panelLeft.Controls.Add(this.btnBook);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.guna2HtmlLabel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(244, 698);
            this.panelLeft.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.AutoRoundedCorners = true;
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnUser.BorderRadius = 25;
            this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnUser.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.user_white;
            this.btnUser.CustomizableEdges.BottomRight = false;
            this.btnUser.CustomizableEdges.TopRight = false;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::QuanLyNhaSach2.Properties.Resources.user_256;
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUser.Location = new System.Drawing.Point(12, 619);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(232, 53);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Người dùng";
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.TextOffset = new System.Drawing.Point(27, 0);
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnNSX
            // 
            this.btnNSX.AutoRoundedCorners = true;
            this.btnNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnNSX.BorderRadius = 25;
            this.btnNSX.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNSX.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnNSX.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.factory_white;
            this.btnNSX.CustomizableEdges.BottomRight = false;
            this.btnNSX.CustomizableEdges.TopRight = false;
            this.btnNSX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNSX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNSX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNSX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNSX.FillColor = System.Drawing.Color.Transparent;
            this.btnNSX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNSX.ForeColor = System.Drawing.Color.White;
            this.btnNSX.Image = global::QuanLyNhaSach2.Properties.Resources.factory_256;
            this.btnNSX.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNSX.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnNSX.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNSX.Location = new System.Drawing.Point(9, 560);
            this.btnNSX.Name = "btnNSX";
            this.btnNSX.Size = new System.Drawing.Size(235, 53);
            this.btnNSX.TabIndex = 1;
            this.btnNSX.Text = "Nhà sản xuất";
            this.btnNSX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNSX.TextOffset = new System.Drawing.Point(27, 0);
            this.btnNSX.Click += new System.EventHandler(this.btnNSX_Click);
            // 
            // btnCate
            // 
            this.btnCate.AutoRoundedCorners = true;
            this.btnCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnCate.BorderRadius = 25;
            this.btnCate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCate.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.category_white;
            this.btnCate.CustomizableEdges.BottomRight = false;
            this.btnCate.CustomizableEdges.TopRight = false;
            this.btnCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCate.FillColor = System.Drawing.Color.Transparent;
            this.btnCate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCate.ForeColor = System.Drawing.Color.White;
            this.btnCate.Image = global::QuanLyNhaSach2.Properties.Resources.category;
            this.btnCate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCate.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCate.Location = new System.Drawing.Point(9, 510);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(235, 53);
            this.btnCate.TabIndex = 1;
            this.btnCate.Text = "Danh mục";
            this.btnCate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCate.TextOffset = new System.Drawing.Point(27, 0);
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::QuanLyNhaSach2.Properties.Resources.logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(32, 97);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button8
            // 
            this.guna2Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button8.AutoRoundedCorners = true;
            this.guna2Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button8.BorderRadius = 25;
            this.guna2Button8.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button8.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.bars;
            this.guna2Button8.CustomizableEdges.BottomRight = false;
            this.guna2Button8.CustomizableEdges.TopRight = false;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = global::QuanLyNhaSach2.Properties.Resources.bars;
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button8.ImageSize = new System.Drawing.Size(47, 47);
            this.guna2Button8.Location = new System.Drawing.Point(163, 22);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(81, 53);
            this.guna2Button8.TabIndex = 1;
            this.guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.TextOffset = new System.Drawing.Point(27, 0);
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.AutoRoundedCorners = true;
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnStatistics.BorderRadius = 25;
            this.btnStatistics.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStatistics.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnStatistics.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.statistics_white;
            this.btnStatistics.CustomizableEdges.BottomRight = false;
            this.btnStatistics.CustomizableEdges.TopRight = false;
            this.btnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistics.FillColor = System.Drawing.Color.Transparent;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::QuanLyNhaSach2.Properties.Resources.statistics_256;
            this.btnStatistics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistics.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStatistics.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStatistics.Location = new System.Drawing.Point(6, 451);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(238, 53);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistics.TextOffset = new System.Drawing.Point(27, 0);
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBill
            // 
            this.btnBill.AutoRoundedCorners = true;
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnBill.BorderRadius = 25;
            this.btnBill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnBill.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.banknote_white;
            this.btnBill.CustomizableEdges.BottomRight = false;
            this.btnBill.CustomizableEdges.TopRight = false;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::QuanLyNhaSach2.Properties.Resources.banknotes_256;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBill.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBill.Location = new System.Drawing.Point(6, 394);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(232, 53);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.TextOffset = new System.Drawing.Point(27, 0);
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnOrder.BorderRadius = 25;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnOrder.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.cart_white;
            this.btnOrder.CustomizableEdges.BottomRight = false;
            this.btnOrder.CustomizableEdges.TopRight = false;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::QuanLyNhaSach2.Properties.Resources.cart_69_256;
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnOrder.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOrder.Location = new System.Drawing.Point(12, 335);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(232, 53);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.TextOffset = new System.Drawing.Point(27, 0);
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnCustomer.BorderRadius = 25;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCustomer.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.customer_white;
            this.btnCustomer.CustomizableEdges.BottomRight = false;
            this.btnCustomer.CustomizableEdges.TopRight = false;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::QuanLyNhaSach2.Properties.Resources.customer;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCustomer.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomer.Location = new System.Drawing.Point(15, 287);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(232, 53);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.TextOffset = new System.Drawing.Point(27, 0);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBook
            // 
            this.btnBook.AutoRoundedCorners = true;
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnBook.BorderRadius = 25;
            this.btnBook.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBook.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnBook.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.book_white;
            this.btnBook.CustomizableEdges.BottomRight = false;
            this.btnBook.CustomizableEdges.TopRight = false;
            this.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBook.FillColor = System.Drawing.Color.Transparent;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Image = global::QuanLyNhaSach2.Properties.Resources.books_256;
            this.btnBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBook.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBook.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBook.Location = new System.Drawing.Point(12, 228);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(235, 53);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Sách";
            this.btnBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBook.TextOffset = new System.Drawing.Point(27, 0);
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnHome.BorderRadius = 25;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnHome.CheckedState.Image = global::QuanLyNhaSach2.Properties.Resources.home_white;
            this.btnHome.CustomizableEdges.BottomRight = false;
            this.btnHome.CustomizableEdges.TopRight = false;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyNhaSach2.Properties.Resources.home_5_256;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Location = new System.Drawing.Point(12, 169);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(232, 53);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(27, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(32, 97);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(241, 49);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "   BookStore";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.lbRole);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.lbUser);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.Location = new System.Drawing.Point(244, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1025, 75);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lbRole
            // 
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRole.Location = new System.Drawing.Point(134, 39);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(41, 18);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Admin";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(9, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(78, 18);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Người dùng :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(9, 39);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Quyền : ";
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUser.Location = new System.Drawing.Point(134, 6);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(50, 18);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "trungDo";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(818, 22);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(57, 36);
            this.guna2ControlBox3.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(881, 22);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(57, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(944, 22);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(57, 36);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(244, 75);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1025, 623);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 698);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel centerPanel;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUser;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Button btnCate;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnStatistics;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnNSX;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;

    }
}