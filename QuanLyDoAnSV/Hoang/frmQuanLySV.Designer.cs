
namespace QuanLyDoAnSV.Hoang
{
    partial class frmQuanLySV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.grdSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSV = new Guna.UI2.WinForms.Guna2Button();
            this.txtChuyenNganhSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTenSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comNS = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comGT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.comFDetail = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comFName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnReset);
            this.guna2Panel1.Controls.Add(this.btnLoc);
            this.guna2Panel1.Controls.Add(this.comFDetail);
            this.guna2Panel1.Controls.Add(this.comFName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1078, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // grdSinhVien
            // 
            this.grdSinhVien.AllowUserToAddRows = false;
            this.grdSinhVien.AllowUserToDeleteRows = false;
            this.grdSinhVien.AllowUserToOrderColumns = true;
            this.grdSinhVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.grdSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.grdSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdSinhVien.ColumnHeadersHeight = 40;
            this.grdSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.HoTenSV,
            this.NgaySinh,
            this.GioiTinh,
            this.CNganh,
            this.Password});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSinhVien.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdSinhVien.EnableHeadersVisualStyles = false;
            this.grdSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSinhVien.Location = new System.Drawing.Point(12, 95);
            this.grdSinhVien.Name = "grdSinhVien";
            this.grdSinhVien.ReadOnly = true;
            this.grdSinhVien.RowHeadersVisible = false;
            this.grdSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSinhVien.Size = new System.Drawing.Size(1052, 514);
            this.grdSinhVien.TabIndex = 1;
            this.grdSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdSinhVien.ThemeStyle.HeaderStyle.Height = 40;
            this.grdSinhVien.ThemeStyle.ReadOnly = true;
            this.grdSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdSinhVien.ThemeStyle.RowsStyle.Height = 22;
            this.grdSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSinhVien_CellClick);
            this.grdSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSinhVien_CellContentClick);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.FillWeight = 50F;
            this.MaSinhVien.HeaderText = "Mã sinh viên";
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.ReadOnly = true;
            this.MaSinhVien.Width = 124;
            // 
            // HoTenSV
            // 
            this.HoTenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTenSV.DataPropertyName = "HoTenSV";
            this.HoTenSV.HeaderText = "Họ và tên";
            this.HoTenSV.Name = "HoTenSV";
            this.HoTenSV.ReadOnly = true;
            this.HoTenSV.Width = 102;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // CNganh
            // 
            this.CNganh.DataPropertyName = "CNganh";
            this.CNganh.HeaderText = "Chuyên ngành";
            this.CNganh.Name = "CNganh";
            this.CNganh.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnDeleteSV.BorderThickness = 2;
            this.btnDeleteSV.CheckedState.Parent = this.btnDeleteSV;
            this.btnDeleteSV.CustomImages.Parent = this.btnDeleteSV;
            this.btnDeleteSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSV.DisabledState.Parent = this.btnDeleteSV;
            this.btnDeleteSV.FillColor = System.Drawing.Color.White;
            this.btnDeleteSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSV.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSV.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteSV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSV.HoverState.Parent = this.btnDeleteSV;
            this.btnDeleteSV.Location = new System.Drawing.Point(400, 632);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.ShadowDecoration.Parent = this.btnDeleteSV;
            this.btnDeleteSV.Size = new System.Drawing.Size(72, 38);
            this.btnDeleteSV.TabIndex = 34;
            this.btnDeleteSV.Text = "Xoá";
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnEditSV
            // 
            this.btnEditSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditSV.BorderThickness = 2;
            this.btnEditSV.CheckedState.Parent = this.btnEditSV;
            this.btnEditSV.CustomImages.Parent = this.btnEditSV;
            this.btnEditSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditSV.DisabledState.Parent = this.btnEditSV;
            this.btnEditSV.FillColor = System.Drawing.Color.White;
            this.btnEditSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditSV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditSV.HoverState.Parent = this.btnEditSV;
            this.btnEditSV.Location = new System.Drawing.Point(480, 632);
            this.btnEditSV.Name = "btnEditSV";
            this.btnEditSV.ShadowDecoration.Parent = this.btnEditSV;
            this.btnEditSV.Size = new System.Drawing.Size(72, 38);
            this.btnEditSV.TabIndex = 38;
            this.btnEditSV.Text = "Sửa";
            this.btnEditSV.Click += new System.EventHandler(this.btnEditSV_Click);
            // 
            // btnCancelSV
            // 
            this.btnCancelSV.BorderColor = System.Drawing.Color.LightCoral;
            this.btnCancelSV.BorderThickness = 2;
            this.btnCancelSV.CheckedState.Parent = this.btnCancelSV;
            this.btnCancelSV.CustomImages.Parent = this.btnCancelSV;
            this.btnCancelSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelSV.DisabledState.Parent = this.btnCancelSV;
            this.btnCancelSV.FillColor = System.Drawing.Color.White;
            this.btnCancelSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelSV.ForeColor = System.Drawing.Color.Red;
            this.btnCancelSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelSV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelSV.HoverState.Parent = this.btnCancelSV;
            this.btnCancelSV.Location = new System.Drawing.Point(832, 632);
            this.btnCancelSV.Name = "btnCancelSV";
            this.btnCancelSV.ShadowDecoration.Parent = this.btnCancelSV;
            this.btnCancelSV.Size = new System.Drawing.Size(72, 38);
            this.btnCancelSV.TabIndex = 41;
            this.btnCancelSV.Text = "Huỷ";
            this.btnCancelSV.Visible = false;
            this.btnCancelSV.Click += new System.EventHandler(this.btnCancelSV_Click);
            // 
            // btnSaveSV
            // 
            this.btnSaveSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSaveSV.BorderThickness = 2;
            this.btnSaveSV.CheckedState.Parent = this.btnSaveSV;
            this.btnSaveSV.CustomImages.Parent = this.btnSaveSV;
            this.btnSaveSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveSV.DisabledState.Parent = this.btnSaveSV;
            this.btnSaveSV.FillColor = System.Drawing.Color.White;
            this.btnSaveSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSaveSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSaveSV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveSV.HoverState.Parent = this.btnSaveSV;
            this.btnSaveSV.Location = new System.Drawing.Point(992, 632);
            this.btnSaveSV.Name = "btnSaveSV";
            this.btnSaveSV.ShadowDecoration.Parent = this.btnSaveSV;
            this.btnSaveSV.Size = new System.Drawing.Size(72, 38);
            this.btnSaveSV.TabIndex = 40;
            this.btnSaveSV.Text = "Lưu";
            this.btnSaveSV.Visible = false;
            this.btnSaveSV.Click += new System.EventHandler(this.btnSaveSV_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddSV.BorderThickness = 2;
            this.btnAddSV.CheckedState.Parent = this.btnAddSV;
            this.btnAddSV.CustomImages.Parent = this.btnAddSV;
            this.btnAddSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSV.DisabledState.Parent = this.btnAddSV;
            this.btnAddSV.FillColor = System.Drawing.Color.White;
            this.btnAddSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddSV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSV.HoverState.Parent = this.btnAddSV;
            this.btnAddSV.Location = new System.Drawing.Point(912, 632);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.ShadowDecoration.Parent = this.btnAddSV;
            this.btnAddSV.Size = new System.Drawing.Size(72, 38);
            this.btnAddSV.TabIndex = 39;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.Visible = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // txtChuyenNganhSV
            // 
            this.txtChuyenNganhSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChuyenNganhSV.DefaultText = "";
            this.txtChuyenNganhSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChuyenNganhSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChuyenNganhSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenNganhSV.DisabledState.Parent = this.txtChuyenNganhSV;
            this.txtChuyenNganhSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenNganhSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenNganhSV.FocusedState.Parent = this.txtChuyenNganhSV;
            this.txtChuyenNganhSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChuyenNganhSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenNganhSV.HoverState.Parent = this.txtChuyenNganhSV;
            this.txtChuyenNganhSV.Location = new System.Drawing.Point(784, 264);
            this.txtChuyenNganhSV.Name = "txtChuyenNganhSV";
            this.txtChuyenNganhSV.PasswordChar = '\0';
            this.txtChuyenNganhSV.PlaceholderText = "";
            this.txtChuyenNganhSV.SelectedText = "";
            this.txtChuyenNganhSV.ShadowDecoration.Parent = this.txtChuyenNganhSV;
            this.txtChuyenNganhSV.Size = new System.Drawing.Size(272, 36);
            this.txtChuyenNganhSV.TabIndex = 48;
            // 
            // txtPasswordSV
            // 
            this.txtPasswordSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordSV.DefaultText = "";
            this.txtPasswordSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSV.DisabledState.Parent = this.txtPasswordSV;
            this.txtPasswordSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSV.FocusedState.Parent = this.txtPasswordSV;
            this.txtPasswordSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSV.HoverState.Parent = this.txtPasswordSV;
            this.txtPasswordSV.Location = new System.Drawing.Point(784, 208);
            this.txtPasswordSV.Name = "txtPasswordSV";
            this.txtPasswordSV.PasswordChar = '\0';
            this.txtPasswordSV.PlaceholderText = "";
            this.txtPasswordSV.SelectedText = "";
            this.txtPasswordSV.ShadowDecoration.Parent = this.txtPasswordSV;
            this.txtPasswordSV.Size = new System.Drawing.Size(272, 36);
            this.txtPasswordSV.TabIndex = 47;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenSV.DefaultText = "";
            this.txtHoTenSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTenSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTenSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenSV.DisabledState.Parent = this.txtHoTenSV;
            this.txtHoTenSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenSV.FocusedState.Parent = this.txtHoTenSV;
            this.txtHoTenSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTenSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenSV.HoverState.Parent = this.txtHoTenSV;
            this.txtHoTenSV.Location = new System.Drawing.Point(784, 152);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.PasswordChar = '\0';
            this.txtHoTenSV.PlaceholderText = "";
            this.txtHoTenSV.SelectedText = "";
            this.txtHoTenSV.ShadowDecoration.Parent = this.txtHoTenSV;
            this.txtHoTenSV.Size = new System.Drawing.Size(272, 36);
            this.txtHoTenSV.TabIndex = 46;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSV.DefaultText = "";
            this.txtMaSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSV.DisabledState.Parent = this.txtMaSV;
            this.txtMaSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSV.FocusedState.Parent = this.txtMaSV;
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSV.HoverState.Parent = this.txtMaSV;
            this.txtMaSV.Location = new System.Drawing.Point(784, 96);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PasswordChar = '\0';
            this.txtMaSV.PlaceholderText = "";
            this.txtMaSV.SelectedText = "";
            this.txtMaSV.ShadowDecoration.Parent = this.txtMaSV;
            this.txtMaSV.Size = new System.Drawing.Size(272, 36);
            this.txtMaSV.TabIndex = 45;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(696, 104);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 15);
            this.guna2HtmlLabel1.TabIndex = 51;
            this.guna2HtmlLabel1.Text = "Mã sinh viên:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(680, 160);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(83, 15);
            this.guna2HtmlLabel2.TabIndex = 52;
            this.guna2HtmlLabel2.Text = "Họ tên sinh viên:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(712, 216);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 15);
            this.guna2HtmlLabel3.TabIndex = 53;
            this.guna2HtmlLabel3.Text = "Password:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(688, 272);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel4.TabIndex = 54;
            this.guna2HtmlLabel4.Text = "Chuyên ngành:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(712, 328);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(46, 15);
            this.guna2HtmlLabel5.TabIndex = 55;
            this.guna2HtmlLabel5.Text = "Giới tính:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(704, 384);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(53, 15);
            this.guna2HtmlLabel6.TabIndex = 56;
            this.guna2HtmlLabel6.Text = "Ngày sinh:";
            // 
            // comNS
            // 
            this.comNS.Checked = true;
            this.comNS.CheckedState.Parent = this.comNS;
            this.comNS.FillColor = System.Drawing.Color.White;
            this.comNS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comNS.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.comNS.HoverState.Parent = this.comNS;
            this.comNS.Location = new System.Drawing.Point(784, 376);
            this.comNS.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.comNS.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.comNS.Name = "comNS";
            this.comNS.ShadowDecoration.Parent = this.comNS;
            this.comNS.Size = new System.Drawing.Size(272, 36);
            this.comNS.TabIndex = 57;
            this.comNS.Value = new System.DateTime(2021, 11, 18, 14, 15, 23, 494);
            // 
            // comGT
            // 
            this.comGT.BackColor = System.Drawing.Color.Transparent;
            this.comGT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGT.FocusedState.Parent = this.comGT;
            this.comGT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comGT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comGT.HoverState.Parent = this.comGT;
            this.comGT.ItemHeight = 30;
            this.comGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comGT.ItemsAppearance.Parent = this.comGT;
            this.comGT.Location = new System.Drawing.Point(784, 320);
            this.comGT.Name = "comGT";
            this.comGT.ShadowDecoration.Parent = this.comGT;
            this.comGT.Size = new System.Drawing.Size(272, 36);
            this.comGT.TabIndex = 58;
            // 
            // btnReset
            // 
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.DisabledState.Parent = this.btnReset;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(832, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(64, 32);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Nạp lại";
            // 
            // btnLoc
            // 
            this.btnLoc.CheckedState.Parent = this.btnLoc;
            this.btnLoc.CustomImages.Parent = this.btnLoc;
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.DisabledState.Parent = this.btnLoc;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.HoverState.Parent = this.btnLoc;
            this.btnLoc.Location = new System.Drawing.Point(760, 16);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.ShadowDecoration.Parent = this.btnLoc;
            this.btnLoc.Size = new System.Drawing.Size(64, 32);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Lọc";
            // 
            // comFDetail
            // 
            this.comFDetail.BackColor = System.Drawing.Color.Transparent;
            this.comFDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comFDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFDetail.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comFDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comFDetail.FocusedState.Parent = this.comFDetail;
            this.comFDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comFDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comFDetail.HoverState.Parent = this.comFDetail;
            this.comFDetail.ItemHeight = 30;
            this.comFDetail.ItemsAppearance.Parent = this.comFDetail;
            this.comFDetail.Location = new System.Drawing.Point(544, 16);
            this.comFDetail.Name = "comFDetail";
            this.comFDetail.ShadowDecoration.Parent = this.comFDetail;
            this.comFDetail.Size = new System.Drawing.Size(192, 36);
            this.comFDetail.TabIndex = 12;
            // 
            // comFName
            // 
            this.comFName.BackColor = System.Drawing.Color.Transparent;
            this.comFName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comFName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comFName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comFName.FocusedState.Parent = this.comFName;
            this.comFName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comFName.HoverState.Parent = this.comFName;
            this.comFName.ItemHeight = 30;
            this.comFName.ItemsAppearance.Parent = this.comFName;
            this.comFName.Location = new System.Drawing.Point(336, 16);
            this.comFName.Name = "comFName";
            this.comFName.ShadowDecoration.Parent = this.comFName;
            this.comFName.Size = new System.Drawing.Size(192, 36);
            this.comFName.TabIndex = 11;
            this.comFName.SelectionChangeCommitted += new System.EventHandler(this.comFName_SelectionChangeCommitted);
            // 
            // frmQuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1078, 683);
            this.ControlBox = false;
            this.Controls.Add(this.grdSinhVien);
            this.Controls.Add(this.comNS);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtChuyenNganhSV);
            this.Controls.Add(this.txtPasswordSV);
            this.Controls.Add(this.txtHoTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnCancelSV);
            this.Controls.Add(this.btnSaveSV);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.btnEditSV);
            this.Controls.Add(this.btnDeleteSV);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.comGT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySV";
            this.Text = "frmQuanLySV";
            this.Load += new System.EventHandler(this.frmQuanLySV_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView grdSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSV;
        private Guna.UI2.WinForms.Guna2Button btnEditSV;
        private Guna.UI2.WinForms.Guna2Button btnCancelSV;
        private Guna.UI2.WinForms.Guna2Button btnSaveSV;
        private Guna.UI2.WinForms.Guna2Button btnAddSV;
        private Guna.UI2.WinForms.Guna2TextBox txtChuyenNganhSV;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordSV;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTenSV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker comNS;
        private Guna.UI2.WinForms.Guna2ComboBox comGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private Guna.UI2.WinForms.Guna2ComboBox comFDetail;
        private Guna.UI2.WinForms.Guna2ComboBox comFName;
    }
}