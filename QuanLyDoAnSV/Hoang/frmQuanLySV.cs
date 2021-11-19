using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAnSV.Hoang
{
    public partial class frmQuanLySV : Form
    {
        SinhVienSQL dalSV;
        int ID;
        public frmQuanLySV()
        {
            InitializeComponent();
            dalSV = new SinhVienSQL();
        }
        public void showAllSV()
        {
            grdSinhVien.DataSource = null;
            DataTable dt = dalSV.getAllSV();
            grdSinhVien.DataSource = dt;
        }
        private void frmQuanLySV_Load(object sender, EventArgs e)
        {
            showAllSV();
            
        }
        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblSinhVien sinhVien = new tblSinhVien();
                sinhVien.id = ID;
                Point temp = grdSinhVien.CurrentCellAddress;
                if (dalSV.DeleteSV(sinhVien))
                {
                    showAllSV();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            if (btnSaveSV.Visible == false)
            {

                btnCancelSV.Visible = true;
                btnSaveSV.Visible = true;
                btnAddSV.Visible = true;
                this.grdSinhVien.Size = new Size(620, 514);
            }
            else
            {

                this.grdSinhVien.Size = new Size(1060, 514);
                btnCancelSV.Visible = false;
                btnSaveSV.Visible = false;
                btnAddSV.Visible = false;
            }
        }

        private void btnCancelSV_Click(object sender, EventArgs e)
        {
            this.grdSinhVien.Size = new Size(1060, 514);
            btnCancelSV.Visible = false;
            btnSaveSV.Visible = false;
            btnAddSV.Visible = false;
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            int rows = grdSinhVien.Rows.Count;
            tblSinhVien sinhVien = new tblSinhVien();

            sinhVien.HoTenSV = txtHoTenSV.Text;
            sinhVien.MaSinhVien = txtMaSV.Text;
            sinhVien.GioiTinh = comGT.Text;
            sinhVien.Password = txtPasswordSV.Text;
            sinhVien.CNganh = txtChuyenNganhSV.Text;
            sinhVien.NgaySinh = (DateTime)comNS.Value;

            if (dalSV.InsertSV(sinhVien))
            {
                showAllSV();
                grdSinhVien.CurrentCell = grdSinhVien.Rows[rows].Cells[1];
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtHoTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTenSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPasswordSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(comNS.Value.ToString()))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comNS.Focus();
                return false;
            }

            return true;
        }
        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Point temp = grdSinhVien.CurrentCellAddress;
                tblSinhVien sinhVien = new tblSinhVien();
                sinhVien.id = ID;
                sinhVien.HoTenSV = txtHoTenSV.Text;
                sinhVien.MaSinhVien = txtMaSV.Text;
                sinhVien.GioiTinh = comGT.Text;
                sinhVien.Password = txtPasswordSV.Text;
                sinhVien.CNganh = txtChuyenNganhSV.Text;
                sinhVien.NgaySinh = (DateTime)comNS.Value;


                if (dalSV.UpdateSV(sinhVien))
                {
                    showAllSV();
                    grdSinhVien.CurrentCell = grdSinhVien.Rows[temp.Y].Cells[temp.X];
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void grdSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < grdSinhVien.RowCount && i >= 0)
            {
                ID = Int32.Parse(grdSinhVien.Rows[i].Cells["id"].Value.ToString());
                txtHoTenSV.Text = grdSinhVien.Rows[i].Cells["HoTenSV"].Value?.ToString();
                txtMaSV.Text = grdSinhVien.Rows[i].Cells["MaSinhVien"].Value?.ToString();
                txtChuyenNganhSV.Text = grdSinhVien.Rows[i].Cells["CNganh"].Value?.ToString();
                txtPasswordSV.Text = grdSinhVien.Rows[i].Cells["Password"].Value?.ToString();
                if (grdSinhVien.Rows[i].Cells["GioiTinh"].Value.ToString().Equals("Nam"))
                {
                    comGT.SelectedIndex = 0;
                }
                else
                {
                    comGT.SelectedIndex = 1;
                }

                comNS.Value = (DateTime)grdSinhVien.Rows[i].Cells["NgaySinh"].Value;

            }
        }

        private void grdSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comFName_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
