using QuanLyNhaSach2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    partial class frmProductView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            dgvId = new DataGridViewTextBoxColumn();
            dgvTitle = new DataGridViewTextBoxColumn();
            dgvCategory = new DataGridViewTextBoxColumn();
            dgvAuthor = new DataGridViewTextBoxColumn();
            dgvNSX = new DataGridViewTextBoxColumn();
            dgvDesc = new DataGridViewTextBoxColumn();
            dgvQuantity = new DataGridViewTextBoxColumn();
            dgvCost = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvCreateDate = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Location = new Point(902, 61);
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.HoverState.ImageSize = new Size(68, 68);
            btnAdd.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // txtSearch
            // 
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(902, 89);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Size = new Size(39, 25);
            guna2HtmlLabel2.Text = "Sách";
            // 
            // dgProduct
            // 
            dgProduct.AllowUserToAddRows = false;
            dgProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgProduct.ColumnHeadersHeight = 40;
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgProduct.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvTitle, dgvCategory, dgvAuthor, dgvNSX, dgvDesc, dgvQuantity, dgvCost, dgvPrice, dgvCreateDate, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgProduct.GridColor = Color.FromArgb(231, 229, 255);
            dgProduct.Location = new Point(56, 195);
            dgProduct.Name = "dgProduct";
            dgProduct.ReadOnly = true;
            dgProduct.RowHeadersVisible = false;
            dgProduct.RowHeadersWidth = 62;
            dgProduct.RowTemplate.Height = 33;
            dgProduct.Size = new Size(1185, 421);
            dgProduct.TabIndex = 6;
            dgProduct.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgProduct.ThemeStyle.BackColor = Color.White;
            dgProduct.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgProduct.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            dgProduct.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgProduct.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgProduct.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgProduct.ThemeStyle.HeaderStyle.Height = 40;
            dgProduct.ThemeStyle.ReadOnly = true;
            dgProduct.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgProduct.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgProduct.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgProduct.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgProduct.ThemeStyle.RowsStyle.Height = 33;
            dgProduct.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgProduct.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgProduct.CellClick += dgProduct_CellClick;
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
            // dgvId
            // 
            dgvId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvId.DataPropertyName = "BookID";
            dgvId.FillWeight = 70F;
            dgvId.HeaderText = "ID";
            dgvId.MinimumWidth = 70;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 70;
            // 
            // dgvTitle
            // 
            dgvTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTitle.DataPropertyName = "Title";
            dgvTitle.FillWeight = 83.52273F;
            dgvTitle.HeaderText = "Tên sách";
            dgvTitle.MinimumWidth = 8;
            dgvTitle.Name = "dgvTitle";
            dgvTitle.ReadOnly = true;
            dgvTitle.Width = 98;
            // 
            // dgvCategory
            // 
            dgvCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCategory.DataPropertyName = "CategoryID";
            dgvCategory.HeaderText = "Danh mục";
            dgvCategory.MinimumWidth = 8;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.Width = 118;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvAuthor.DataPropertyName = "Author";
            dgvAuthor.HeaderText = "Tác giả";
            dgvAuthor.MinimumWidth = 8;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.ReadOnly = true;
            dgvAuthor.Width = 117;
            // 
            // dgvNSX
            // 
            dgvNSX.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNSX.DataPropertyName = "NSXID";
            dgvNSX.FillWeight = 80F;
            dgvNSX.HeaderText = "NSX";
            dgvNSX.MinimumWidth = 90;
            dgvNSX.Name = "dgvNSX";
            dgvNSX.ReadOnly = true;
            dgvNSX.Width = 94;
            // 
            // dgvDesc
            // 
            dgvDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDesc.DataPropertyName = "Description";
            dgvDesc.HeaderText = "Mô tả";
            dgvDesc.MinimumWidth = 8;
            dgvDesc.Name = "dgvDesc";
            dgvDesc.ReadOnly = true;
            dgvDesc.Width = 118;
            // 
            // dgvQuantity
            // 
            dgvQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvQuantity.DataPropertyName = "Quantity";
            dgvQuantity.HeaderText = "Số lượng";
            dgvQuantity.MinimumWidth = 8;
            dgvQuantity.Name = "dgvQuantity";
            dgvQuantity.ReadOnly = true;
            dgvQuantity.Width = 117;
            // 
            // dgvCost
            // 
            dgvCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCost.DataPropertyName = "Cost";
            dgvCost.HeaderText = "Giá Nhập";
            dgvCost.MinimumWidth = 8;
            dgvCost.Name = "dgvCost";
            dgvCost.ReadOnly = true;
            dgvCost.Width = 118;
            // 
            // dgvPrice
            // 
            dgvPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPrice.DataPropertyName = "Price";
            dgvPrice.HeaderText = "Giá bán";
            dgvPrice.MinimumWidth = 8;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            dgvPrice.Width = 117;
            // 
            // dgvCreateDate
            // 
            dgvCreateDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCreateDate.DataPropertyName = "CreateDate";
            dgvCreateDate.HeaderText = "Ngày tạo";
            dgvCreateDate.MinimumWidth = 8;
            dgvCreateDate.Name = "dgvCreateDate";
            dgvCreateDate.ReadOnly = true;
            dgvCreateDate.Width = 118;
            // 
            // dgvEdit
            // 
            dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEdit.FillWeight = 50F;
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Resources.edit;
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.MinimumWidth = 50;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 50;
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
            // frmProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 665);
            Controls.Add(dgProduct);
            Name = "frmProductView";
            Text = "frmProductView";
            Load += frmProductView_Load;
            Controls.SetChildIndex(guna2HtmlLabel1, 0);
            Controls.SetChildIndex(btnAdd, 0);
            //Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(guna2HtmlLabel2, 0);
            Controls.SetChildIndex(dgProduct, 0);
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgProduct;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvTitle;
        private DataGridViewTextBoxColumn dgvCategory;
        private DataGridViewTextBoxColumn dgvAuthor;
        private DataGridViewTextBoxColumn dgvNSX;
        private DataGridViewTextBoxColumn dgvDesc;
        private DataGridViewTextBoxColumn dgvQuantity;
        private DataGridViewTextBoxColumn dgvCost;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvCreateDate;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}