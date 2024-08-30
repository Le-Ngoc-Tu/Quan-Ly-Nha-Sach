using QuanLyNhaSach2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.Model
{
    partial class frmOrder
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpCreateDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            cbbCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            btnBill = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            CategoryPanel = new FlowLayoutPanel();
            ProductPanel = new FlowLayoutPanel();
            dgOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvTitle = new DataGridViewTextBoxColumn();
            dgvQuantity = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvAmount = new DataGridViewTextBoxColumn();
            dgvDel = new DataGridViewImageColumn();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgOrder).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(guna2Button2);
            guna2Panel2.Controls.Add(guna2HtmlLabel2);
            guna2Panel2.Controls.Add(txtTotal);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.FromArgb(50, 55, 89);
            guna2Panel2.Location = new Point(0, 581);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(1277, 82);
            guna2Panel2.TabIndex = 0;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BackColor = Color.FromArgb(50, 55, 89);
            guna2Button2.BorderRadius = 28;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(255, 105, 105);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(821, 8);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(166, 59);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "Thanh Toán";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(1089, 25);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(82, 22);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Thành Tiền :";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.BackColor = Color.Transparent;
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(1212, 25);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(31, 22);
            txtTotal.TabIndex = 0;
            txtTotal.Text = "Tien";
            // 
            // dtpCreateDate
            // 
            dtpCreateDate.AutoRoundedCorners = true;
            dtpCreateDate.BackColor = SystemColors.Control;
            dtpCreateDate.BorderRadius = 28;
            dtpCreateDate.Checked = true;
            dtpCreateDate.CustomizableEdges = customizableEdges5;
            dtpCreateDate.FillColor = Color.FromArgb(255, 105, 105);
            dtpCreateDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCreateDate.ForeColor = Color.White;
            dtpCreateDate.Format = DateTimePickerFormat.Long;
            dtpCreateDate.Location = new Point(584, 97);
            dtpCreateDate.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpCreateDate.MinDate = new DateTime(2003, 1, 1, 0, 0, 0, 0);
            dtpCreateDate.Name = "dtpCreateDate";
            dtpCreateDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpCreateDate.Size = new Size(228, 59);
            dtpCreateDate.TabIndex = 10;
            dtpCreateDate.TextAlign = HorizontalAlignment.Center;
            dtpCreateDate.Value = new DateTime(2023, 10, 21, 10, 40, 5, 895);
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Panel1.BorderRadius = 9;
            guna2Panel1.Controls.Add(btnAdd);
            guna2Panel1.Controls.Add(cbbCustomer);
            guna2Panel1.Controls.Add(guna2HtmlLabel3);
            guna2Panel1.CustomizableEdges = customizableEdges10;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(818, 101);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2Panel1.Size = new Size(457, 53);
            guna2Panel1.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(68, 68);
            btnAdd.Image = Resources.add_icon_1;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.IndicateFocus = true;
            btnAdd.Location = new Point(387, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnAdd.Size = new Size(44, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbbCustomer
            // 
            cbbCustomer.BackColor = Color.Transparent;
            cbbCustomer.CustomizableEdges = customizableEdges8;
            cbbCustomer.DrawMode = DrawMode.OwnerDrawFixed;
            cbbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCustomer.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbCustomer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCustomer.ForeColor = Color.FromArgb(68, 88, 112);
            cbbCustomer.ItemHeight = 30;
            cbbCustomer.Location = new Point(89, 8);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.ShadowDecoration.CustomizableEdges = customizableEdges9;
            cbbCustomer.Size = new Size(276, 36);
            cbbCustomer.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Location = new Point(3, 8);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(80, 22);
            guna2HtmlLabel3.TabIndex = 0;
            guna2HtmlLabel3.Text = "Khách hàng";
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(btnBill);
            guna2Panel3.Controls.Add(guna2HtmlLabel1);
            guna2Panel3.Controls.Add(guna2PictureBox1);
            guna2Panel3.CustomizableEdges = customizableEdges16;
            guna2Panel3.Dock = DockStyle.Top;
            guna2Panel3.FillColor = Color.FromArgb(50, 55, 89);
            guna2Panel3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Panel3.Location = new Point(0, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges17;
            guna2Panel3.Size = new Size(1277, 95);
            guna2Panel3.TabIndex = 0;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.FromArgb(50, 55, 89);
            btnBill.BorderRadius = 10;
            btnBill.BorderThickness = 2;
            btnBill.CustomizableEdges = customizableEdges12;
            btnBill.DisabledState.BorderColor = Color.DarkGray;
            btnBill.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBill.FillColor = Color.FromArgb(255, 105, 105);
            btnBill.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBill.ForeColor = Color.White;
            btnBill.Image = Resources.bill_white;
            btnBill.Location = new Point(1133, 12);
            btnBill.Name = "btnBill";
            btnBill.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnBill.Size = new Size(123, 63);
            btnBill.TabIndex = 2;
            btnBill.Text = "Hóa đơn";
            btnBill.Click += btnBill_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(98, 36);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(51, 22);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "ORDER";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges14;
            guna2PictureBox1.Image = Resources.cart_69_256;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(12, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2PictureBox1.Size = new Size(64, 66);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // CategoryPanel
            // 
            CategoryPanel.AutoScroll = true;
            CategoryPanel.Location = new Point(12, 164);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(152, 411);
            CategoryPanel.TabIndex = 1;
            // 
            // ProductPanel
            // 
            ProductPanel.AutoScroll = true;
            ProductPanel.Location = new Point(170, 161);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(649, 414);
            ProductPanel.TabIndex = 1;
            // 
            // dgOrder
            // 
            dgOrder.AllowUserToAddRows = false;
            dgOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgOrder.ColumnHeadersHeight = 40;
            dgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgOrder.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvTitle, dgvQuantity, dgvPrice, dgvAmount, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgOrder.DefaultCellStyle = dataGridViewCellStyle3;
            dgOrder.GridColor = Color.FromArgb(231, 229, 255);
            dgOrder.Location = new Point(825, 161);
            dgOrder.Name = "dgOrder";
            dgOrder.ReadOnly = true;
            dgOrder.RowHeadersVisible = false;
            dgOrder.RowHeadersWidth = 62;
            dgOrder.RowTemplate.Height = 33;
            dgOrder.Size = new Size(450, 414);
            dgOrder.TabIndex = 6;
            dgOrder.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgOrder.ThemeStyle.BackColor = Color.White;
            dgOrder.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgOrder.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            dgOrder.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgOrder.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgOrder.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgOrder.ThemeStyle.HeaderStyle.Height = 40;
            dgOrder.ThemeStyle.ReadOnly = true;
            dgOrder.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgOrder.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgOrder.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgOrder.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgOrder.ThemeStyle.RowsStyle.Height = 33;
            dgOrder.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgOrder.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgOrder.CellClick += dgOrder_CellClick;
            dgOrder.CellValueChanged += dgOrder_CellValueChanged;
            // 
            // dgvId
            // 
            dgvId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvId.FillWeight = 70F;
            dgvId.HeaderText = "ID";
            dgvId.MinimumWidth = 70;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 70;
            // 
            // dgvTitle
            // 
            dgvTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTitle.FillWeight = 83.52273F;
            dgvTitle.HeaderText = "Tiêu đề";
            dgvTitle.MinimumWidth = 8;
            dgvTitle.Name = "dgvTitle";
            dgvTitle.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            dgvQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvQuantity.FillWeight = 30F;
            dgvQuantity.HeaderText = "SL";
            dgvQuantity.MinimumWidth = 30;
            dgvQuantity.Name = "dgvQuantity";
            dgvQuantity.ReadOnly = true;
            dgvQuantity.Width = 54;
            // 
            // dgvPrice
            // 
            dgvPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPrice.FillWeight = 70F;
            dgvPrice.HeaderText = "Giá";
            dgvPrice.MinimumWidth = 70;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            dgvPrice.Width = 70;
            // 
            // dgvAmount
            // 
            dgvAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvAmount.FillWeight = 60F;
            dgvAmount.HeaderText = "Tổng";
            dgvAmount.MinimumWidth = 60;
            dgvAmount.Name = "dgvAmount";
            dgvAmount.ReadOnly = true;
            dgvAmount.Width = 60;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = Resources.delete;
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 50;
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges18;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Resources.search_9_256;
            txtSearch.Location = new Point(170, 109);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges19;
            txtSearch.Size = new Size(369, 47);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = null;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // frmOrder
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1277, 663);
            Controls.Add(dtpCreateDate);
            Controls.Add(guna2Panel1);
            Controls.Add(txtSearch);
            Controls.Add(dgOrder);
            Controls.Add(ProductPanel);
            Controls.Add(CategoryPanel);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FlowLayoutPanel CategoryPanel;
        private FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgOrder;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvTitle;
        private DataGridViewTextBoxColumn dgvQuantity;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvAmount;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotal;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCreateDate;
    }
}