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
    public partial class frmQuanLyGV : Form
    {

        GiangVienSQL dalGV;
        string maGV;
        int ID;
        public void showAllGV()
        {
            grdGiangVien.DataSource = null;
            DataTable dt = dalGV.GetAllGV();
            grdGiangVien.DataSource = dt;
        }
        public frmQuanLyGV()
        {
            InitializeComponent();
            dalGV = new GiangVienSQL();
        }

        private void frmQuanLyGV_Load(object sender, EventArgs e)
        {
            showAllGV();
        }
        private void btnSaveDoAn_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblGiangVien giangVien = new tblGiangVien();
                giangVien.id = ID;
                Point temp = grdGiangVien.CurrentCellAddress;
                if (dalGV.deleteGV(giangVien))
                {
                    showAllGV();
                }    
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            if (btnSaveGV.Visible == false)
            {
                
                btnCancelGV.Visible = true;
                btnSaveGV.Visible = true;
                btnAddGV.Visible = true;
                this.grdGiangVien.Size = new Size(620, 514);
            }
            else
            {
               
                this.grdGiangVien.Size = new Size(1060, 514);
                btnCancelGV.Visible = false;
                btnSaveGV.Visible = false;
                btnAddGV.Visible = false;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelGV_Click(object sender, EventArgs e)
        {
            this.grdGiangVien.Size = new Size(1060, 514);
            btnCancelGV.Visible = false;
            btnSaveGV.Visible = false;
            btnAddGV.Visible = false;
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            int rows = grdGiangVien.Rows.Count;
            tblGiangVien giangVien = new tblGiangVien();

            giangVien.HoTenGV = txtHoTenGV.Text;
            giangVien.MaGiangVien = txtMaGV.Text;
            giangVien.KhoaVien = txtKhoaVienGV.Text;
            giangVien.Password = txtPasswordGV.Text;
            giangVien.Email = txtEmailGV.Text;
            giangVien.ChuyenN = txtChuyenNganhGV.Text;

            if (dalGV.insertGV(giangVien))
            {
                showAllGV();
                
            }    
            else
            {
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void grdGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < grdGiangVien.RowCount && i >= 0)
            {
                ID = Int32.Parse(grdGiangVien.Rows[i].Cells["id"].Value.ToString());
                txtHoTenGV.Text = grdGiangVien.Rows[i].Cells["HoTenGV"].Value?.ToString();
                txtMaGV.Text = grdGiangVien.Rows[i].Cells["MaGiangVien"].Value?.ToString();
                txtChuyenNganhGV.Text = grdGiangVien.Rows[i].Cells["ChuyenN"].Value?.ToString();
                txtPasswordGV.Text = grdGiangVien.Rows[i].Cells["Password"].Value?.ToString();
                txtEmailGV.Text = grdGiangVien.Rows[i].Cells["Email"].Value?.ToString();
                txtKhoaVienGV.Text = grdGiangVien.Rows[i].Cells["KhoaVien"].Value?.ToString();
            }    
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtHoTenGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTenGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPasswordGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmailGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập email giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailGV.Focus();
                return false;
            }
           
            return true;
        }
        private void btnSaveGV_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Point temp = grdGiangVien.CurrentCellAddress;
                tblGiangVien gV = new tblGiangVien();
                gV.id = ID;
                gV.HoTenGV = txtHoTenGV.Text;
                gV.MaGiangVien = txtMaGV.Text;
                gV.Password = txtPasswordGV.Text;
                gV.Email = txtEmailGV.Text;
                gV.ChuyenN = txtChuyenNganhGV.Text;
                gV.KhoaVien = txtKhoaVienGV.Text;


                if (dalGV.updateGV(gV))
                {
                    showAllGV();
                    grdGiangVien.CurrentCell = grdGiangVien.Rows[temp.Y].Cells[temp.X];

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    
        }
    }
}
