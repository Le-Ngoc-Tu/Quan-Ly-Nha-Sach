using QuanLyNhaSach2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    partial class frmCustomerView
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
            dgCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvSex = new DataGridViewTextBoxColumn();
            dgvAddress = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvEmail = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Location = new Point(27, 17);
            guna2HtmlLabel2.Size = new Size(94, 25);
            guna2HtmlLabel2.Text = "Khách hàng";
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgCustomer.ColumnHeadersHeight = 40;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvName, dgvSex, dgvAddress, dgvPhone, dgvEmail, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            dgCustomer.GridColor = Color.FromArgb(231, 229, 255);
            dgCustomer.Location = new Point(56, 195);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersVisible = false;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.Size = new Size(1173, 417);
            dgCustomer.TabIndex = 7;
            dgCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgCustomer.ThemeStyle.BackColor = Color.White;
            dgCustomer.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgCustomer.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            dgCustomer.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgCustomer.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgCustomer.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgCustomer.ThemeStyle.HeaderStyle.Height = 40;
            dgCustomer.ThemeStyle.ReadOnly = true;
            dgCustomer.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgCustomer.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgCustomer.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgCustomer.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgCustomer.ThemeStyle.RowsStyle.Height = 33;
            dgCustomer.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgCustomer.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // dgvId
            // 
            dgvId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvId.DataPropertyName = "ID";
            dgvId.FillWeight = 70F;
            dgvId.HeaderText = "ID";
            dgvId.MinimumWidth = 70;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Width = 70;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvName.DataPropertyName = "Name";
            dgvName.FillWeight = 83.52273F;
            dgvName.HeaderText = "Tên";
            dgvName.MinimumWidth = 8;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            dgvName.Width = 181;
            // 
            // dgvSex
            // 
            dgvSex.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvSex.DataPropertyName = "Sex";
            dgvSex.HeaderText = "Giới tính";
            dgvSex.MinimumWidth = 8;
            dgvSex.Name = "dgvSex";
            dgvSex.ReadOnly = true;
            dgvSex.Width = 216;
            // 
            // dgvAddress
            // 
            dgvAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvAddress.DataPropertyName = "Address";
            dgvAddress.HeaderText = "Địa chỉ";
            dgvAddress.MinimumWidth = 8;
            dgvAddress.Name = "dgvAddress";
            dgvAddress.ReadOnly = true;
            dgvAddress.Width = 217;
            // 
            // dgvPhone
            // 
            dgvPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPhone.DataPropertyName = "Phone";
            dgvPhone.FillWeight = 80F;
            dgvPhone.HeaderText = "Số điện thoại";
            dgvPhone.MinimumWidth = 90;
            dgvPhone.Name = "dgvPhone";
            dgvPhone.ReadOnly = true;
            dgvPhone.Width = 173;
            // 
            // dgvEmail
            // 
            dgvEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmail.DataPropertyName = "Email";
            dgvEmail.HeaderText = "Email";
            dgvEmail.MinimumWidth = 8;
            dgvEmail.Name = "dgvEmail";
            dgvEmail.ReadOnly = true;
            dgvEmail.Width = 216;
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
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = null;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // frmCustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 612);
            Controls.Add(dgCustomer);
            Name = "frmCustomerView";
            Text = "frmCustomerView";
            Load += frmCustomerView_Load;
            Controls.SetChildIndex(guna2HtmlLabel1, 0);
            Controls.SetChildIndex(btnAdd, 0);
            //Controls.SetChildIndex(txtSearch,0);
            Controls.SetChildIndex(guna2HtmlLabel2, 0);
            Controls.SetChildIndex(dgCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgCustomer;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvSex;
        private DataGridViewTextBoxColumn dgvAddress;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewTextBoxColumn dgvEmail;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;

    }
}