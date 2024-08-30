using QuanLyNhaSach2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    partial class frmNSXView
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
            dgNSX = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvAddress = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvEmail = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)dgNSX).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Location = new Point(674, 76);
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
            txtSearch.Location = new Point(674, 111);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Size = new Size(104, 25);
            guna2HtmlLabel2.Text = "Nhà sản xuất";
            // 
            // dgNSX
            // 
            dgNSX.AllowUserToAddRows = false;
            dgNSX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgNSX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgNSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgNSX.ColumnHeadersHeight = 40;
            dgNSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgNSX.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvName, dgvAddress, dgvPhone, dgvEmail, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgNSX.DefaultCellStyle = dataGridViewCellStyle3;
            dgNSX.GridColor = Color.FromArgb(231, 229, 255);
            dgNSX.Location = new Point(56, 199);
            dgNSX.Name = "dgNSX";
            dgNSX.ReadOnly = true;
            dgNSX.RowHeadersVisible = false;
            dgNSX.RowHeadersWidth = 62;
            dgNSX.RowTemplate.Height = 33;
            dgNSX.Size = new Size(961, 239);
            dgNSX.TabIndex = 8;
            dgNSX.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgNSX.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgNSX.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgNSX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgNSX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgNSX.ThemeStyle.BackColor = Color.White;
            dgNSX.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgNSX.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            dgNSX.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgNSX.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgNSX.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgNSX.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgNSX.ThemeStyle.HeaderStyle.Height = 40;
            dgNSX.ThemeStyle.ReadOnly = true;
            dgNSX.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgNSX.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgNSX.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgNSX.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgNSX.ThemeStyle.RowsStyle.Height = 33;
            dgNSX.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgNSX.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgNSX.CellClick += dgNSX_CellClick;
            // 
            // dgvId
            // 
            dgvId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvId.DataPropertyName = "id";
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
            // frmNSXView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 450);
            Controls.Add(dgNSX);
            Name = "frmNSXView";
            Text = "frmNSXView";
            Load += frmNSXView_Load;
            Controls.SetChildIndex(guna2HtmlLabel1, 0);
            Controls.SetChildIndex(btnAdd, 0);
            //Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(guna2HtmlLabel2, 0);
            Controls.SetChildIndex(dgNSX, 0);
            ((System.ComponentModel.ISupportInitialize)dgNSX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgNSX;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvAddress;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewTextBoxColumn dgvEmail;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}