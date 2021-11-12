using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
namespace QuanLyDoAnSV.Hoang
{
    

    public partial class frmQuanLyDoAn : Form
    {
        DoAnDAL dalDA;
        SinhVienDAL dalSV;
        GiangVienDAL dalGV;
        string maGV, maSV;
        public frmQuanLyDoAn()
        {
            InitializeComponent();
            dalDA = new DoAnDAL();
            dalSV = new SinhVienDAL();
            dalGV = new GiangVienDAL();
        }

        public void showAllDoAn()
        {
            DataTable dt = dalDA.getAllDoAn();
            grdDoAn.DataSource = dt;
        }
        private void addGV()
        {
            DataTable dt = new DataTable();
            dt = dalGV.getAllGiangVien();
            List<string> temp = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp.Add(dt.Rows[i].ItemArray[0] + " - " + dt.Rows[i].ItemArray[1]);
            }
            foreach (var item in temp)
            {
                comfGV.Items.Add(item);
            }
        }
        private void addSV()
        {
            DataTable dt = new DataTable();
            dt = dalSV.getAllSinhVien();
            List<string> temp = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp.Add(dt.Rows[i].ItemArray[0] + " - " + dt.Rows[i].ItemArray[1]);
            }
            foreach (var item in temp)
            {
                comfSV.Items.Add(item);
            }
        }
        private void lblProgramName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMainGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDoAnDataSet.tblDoAn' table. You can move, or remove it, as needed.
            // this.tblDoAnTableAdapter.Fill(this.qLDoAnDataSet.tblDoAn);
            addGV();
            addSV();
            showAllDoAn();
            Count();
        }
        
        public void Count()
        {
            var count = grdDoAn.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                .Count();
            var count1 = grdDoAnFull.Rows.Cast<DataGridViewRow>()
                .Where(row => (row.Cells[6].Value == null || row.Cells[6].Value == DBNull.Value))
                .Count();
            lblCount.Text = count.ToString();
            lblCount1.Text = (count - count1).ToString();


        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < grdDoAn.RowCount && i >= 0)
            {
                txtTenDoAn.Text = grdDoAn.Rows[i].Cells["TenDoAn"].Value?.ToString();
                txtChuDe.Text = grdDoAn.Rows[i].Cells["ChuDe"].Value?.ToString();
                txtNoiDung.Text = grdDoAn.Rows[i].Cells["NoiDung"].Value?.ToString();
                txtBanMem.Text = grdDoAn.Rows[i].Cells["BanMem"].Value?.ToString();
                txtFileDinhKem.Text = grdDoAn.Rows[i].Cells["SourceCode"].Value?.ToString();
                txtMSV.Text = grdDoAn.Rows[i].Cells["MSV"].Value?.ToString();
                txtChuyenNganh.Text = grdDoAn.Rows[i].Cells["ChuyenNganh"].Value?.ToString();
                maGV = grdDoAn.Rows[i].Cells["MGV"].Value.ToString();
                maSV = grdDoAn.Rows[i].Cells["MSV"].Value.ToString();
                txtDiem.Text = grdDoAn.Rows[i].Cells["Diem"].Value?.ToString();
                comfSV.SelectedIndex = getIndex(maSV, comfSV.Items);
                comfGV.SelectedIndex = getIndex(maGV, comfGV.Items);
            }

        }

        private int getIndex(string data, ComboBox.ObjectCollection a)
        {
            int i = 0;
            foreach (var item in a)
            {
                if (item.ToString().Contains(data))
                {
                    return i;
                }
                i++;
            }
            return 0;
        }
        public void NapCT()
        {
    
        }
        private void btnUploadBanMem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select file to be upload";
            //fDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            fDialog.Filter = "PDF Files|*.pdf";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                txtBanMem.Text = fDialog.FileName.ToString();
            }
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtTenDoAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đồ án", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDoAn.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(comfSV.Text))
            {
                MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comfSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(comfGV.Text))
            {
                MessageBox.Show("Bạn chưa chọn giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comfGV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtChuyenNganh.Text))
            {
                MessageBox.Show("Bạn chưa nhập chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChuyenNganh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;

            }
            int a;
            if (!int.TryParse(txtDiem.Text, out a))
            {
                MessageBox.Show("Ban đã nhập sai định dạng điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBanMem.Text))
            {
                MessageBox.Show("Bạn chưa nhập đường dẫn đến file báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBanMem.Focus();
                return false;
            }
            return true;
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            grdDoAn.CurrentCell = grdDoAn[0, grdDoAn.RowCount - 1];
            NapCT();
            txtTenDoAn.Focus();


            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            PanelShowEdit.Visible = true;

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
                //thêm
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PanelShowEdit.Visible = false; 
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comfSV_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp = comfSV.Text;
            maSV = temp.Substring(0, temp.IndexOf(" "));
        }

        private void comfGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string temp = comfGV.Text;
            maGV = temp.Substring(0, temp.IndexOf(" "));
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    class DataConnection
    {
        static readonly string conStr = "Data Source=ONE\\SQLEXPRESS;Initial Catalog=QLDoAn;Integrated Security=True";

        public static SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }

    }
    class tblDoAn
    {
        public int id { set; get; }
        public string TenDoAn { get; set; }
        public string ChuDe { get; set; }
        public string NoiDung { get; set; }
        public string BanMem { get; set; }
        public string SourceCode { get; set; }
        public string MSV { get; set; }
        public string ChuyenNganh { get; set; }
        public string MGV { get; set; }
        public int Diem { get; set; }
    }

    class tblSinhVien
    {
        public int id { get; set; }
        public string MaSinhVien { get; set; }
        public string HoTenSV { get; set; }
        public string Password { get; set; }
        public string CNganh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
    }
    class tblGiangVien
    {
        public string MaGiangVien { get; set; }
        public string HoTenGV { get; set; }
        public string Password { get; set; }
    }
}
