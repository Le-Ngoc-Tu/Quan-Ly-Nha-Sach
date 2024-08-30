using QuanLyNhaSach2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaSach2.View
{
    partial class frmCategoryView
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
            dgCatalog = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)dgCatalog).BeginInit();
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
            guna2HtmlLabel2.Location = new Point(37, 17);
            guna2HtmlLabel2.Size = new Size(82, 25);
            guna2HtmlLabel2.Text = "Danh Mục";
            // 
            // dgCatalog
            // 
            dgCatalog.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgCatalog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgCatalog.ColumnHeadersHeight = 40;
            dgCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgCatalog.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvName, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgCatalog.DefaultCellStyle = dataGridViewCellStyle3;
            dgCatalog.GridColor = Color.FromArgb(231, 229, 255);
            dgCatalog.Location = new Point(56, 195);
            dgCatalog.Name = "dgCatalog";
            dgCatalog.RowHeadersVisible = false;
            dgCatalog.RowHeadersWidth = 62;
            dgCatalog.RowTemplate.Height = 33;
            dgCatalog.Size = new Size(1171, 421);
            dgCatalog.TabIndex = 5;
            dgCatalog.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgCatalog.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgCatalog.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgCatalog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgCatalog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgCatalog.ThemeStyle.BackColor = Color.White;
            dgCatalog.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgCatalog.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            dgCatalog.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgCatalog.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgCatalog.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgCatalog.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgCatalog.ThemeStyle.HeaderStyle.Height = 40;
            dgCatalog.ThemeStyle.ReadOnly = false;
            dgCatalog.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgCatalog.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgCatalog.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgCatalog.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgCatalog.ThemeStyle.RowsStyle.Height = 33;
            dgCatalog.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgCatalog.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgCatalog.CellClick += dgCatalog_CellClick;
            // 
            // dgvId
            // 
            dgvId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvId.DataPropertyName = "ID";
            dgvId.FillWeight = 70F;
            dgvId.HeaderText = "ID";
            dgvId.MinimumWidth = 70;
            dgvId.Name = "dgvId";
            dgvId.Width = 70;
            // 
            // dgvName
            // 
            dgvName.DataPropertyName = "CateName";
            dgvName.FillWeight = 83.52273F;
            dgvName.HeaderText = "Tên danh mục";
            dgvName.MinimumWidth = 8;
            dgvName.Name = "dgvName";
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
            // frmCategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 660);
            Controls.Add(dgCatalog);
            Name = "frmCategoryView";
            Text = "frmCategoryView";
            Load += frmCategoryView_Load;
            Controls.SetChildIndex(guna2HtmlLabel1, 0);
            Controls.SetChildIndex(btnAdd, 0);
            //Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(guna2HtmlLabel2, 0);
            Controls.SetChildIndex(dgCatalog, 0);
            ((System.ComponentModel.ISupportInitialize)dgCatalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgCatalog;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}