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
        DoAnSQL dalDA;
        SinhVienSQL dalSV;
        GiangVienSQL dalGV;
        string maGV, maSV;
        int ID;
        bool daPanelShow = false;
        public frmQuanLyDoAn()
        {
            InitializeComponent();
            dalDA = new DoAnSQL();
            dalSV = new SinhVienSQL();
            dalGV = new GiangVienSQL();
        }
        
        public void reloadDA()
        {
            
        }
        
        public void showAllDA()
        {
            grdDoAn.DataSource = null;
            DataTable dt = dalDA.GetAllDA();
            grdDoAn.DataSource = dt;
        }
        private void addGV()
        {
            DataTable dt = new DataTable();
            dt = dalGV.GetAllGV();
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
            dt = dalSV.getAllSV();
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
            if (daPanelShow == false)
            {
                addGV();
                addSV();
                showAllDA();
                Count();
                daPanelShow = true;
            }
            else
            {
                
                daPanelShow = true;
            }
        }
        
        public void Count()
        {
            var count = grdDoAn.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                .Count();
            var count1 = grdDoAnFull.Rows.Cast<DataGridViewRow>()
                .Where(row => (row.Cells[10].Value == null || row.Cells[10].Value == DBNull.Value))
                .Count();
            lblCount.Text = count.ToString();
            lblCount1.Text = (count - count1).ToString();


        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < grdDoAn.RowCount && i >= 0)
            {
                ID = Int32.Parse(grdDoAn.Rows[i].Cells["id"].Value.ToString());
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
            fDialog.Title = "Chọn file để tải lên";
            
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
            int a;
            if (!int.TryParse(txtDiem.Text, out a))
            {
                MessageBox.Show("Ban đã nhập sai định dạng điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;
            }
            return true;
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // thêm
            
            if (checkData())
            {
                int rows = grdDoAn.Rows.Count;
                tblDoAn doAn = new tblDoAn();
                
                doAn.TenDoAn = txtTenDoAn.Text;
                doAn.ChuDe = txtChuDe.Text;
                doAn.NoiDung = txtNoiDung.Text;
                doAn.MSV = maSV;
                doAn.MGV = maGV;
                doAn.ChuyenNganh = txtChuyenNganh.Text;
                doAn.Diem = int.Parse(txtDiem.Text);
                doAn.BanMem = txtBanMem.Text;
                doAn.SourceCode = txtFileDinhKem.Text;

                if (dalDA.InsertDA(doAn))
                {
                    showAllDA();
                    grdDoAn.CurrentCell = grdDoAn.Rows[rows].Cells[1];
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }    

            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            PanelShowEdit.Visible = false;
            this.grdDoAn.Size = new Size(1060, 514);
            btnCancelDoAn.Visible = false;
            btnSaveDoAn.Visible = false;
            btnAddDoAn.Visible = false;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            //update
            if (checkData())
            {
                Point temp = grdDoAn.CurrentCellAddress;
                tblDoAn doAn = new tblDoAn();
                doAn.id = ID;
                doAn.TenDoAn = txtTenDoAn.Text;
                doAn.ChuDe = txtChuDe.Text;
                doAn.NoiDung = txtNoiDung.Text;
                doAn.MSV = maSV;
                doAn.MGV = maGV;
                doAn.ChuyenNganh = txtChuyenNganh.Text;
                doAn.Diem = int.Parse(txtDiem.Text);
                doAn.BanMem = txtBanMem.Text;
                doAn.SourceCode = txtFileDinhKem.Text;
               
                
                if (dalDA.UpdateDA(doAn))
                {
                    showAllDA();
                    grdDoAn.CurrentCell = grdDoAn.Rows[temp.Y].Cells[temp.X];
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            // upload
            string filetype;
            string filename;
            filename = txtBanMem.Text.Substring(Convert.ToInt32(txtBanMem.Text.LastIndexOf("\\")) + 1, txtBanMem.Text.Length - (Convert.ToInt32(txtBanMem.Text.LastIndexOf("\\")) + 1));
            filetype = txtBanMem.Text.Substring(Convert.ToInt32(txtBanMem.Text.LastIndexOf(".")) + 1, txtBanMem.Text.Length - (Convert.ToInt32(txtBanMem.Text.LastIndexOf(".")) + 1));

            if (filetype.ToUpper() != "PDF")
            {
                
                return;
            }

            byte[] FileBytes = null;

            try
            {
                FileStream FS = new FileStream(txtBanMem.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                BinaryReader BR = new BinaryReader(FS);
                long allbytes = new FileInfo(txtBanMem.Text).Length;
                FileBytes = BR.ReadBytes((Int32)allbytes);

                FS.Close();
                FS.Dispose();
                BR.Close();

            }
            catch (Exception ex)
            {
                return;
            }


            

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (btnSaveDoAn.Visible==false)
            {
                PanelShowEdit.Visible = true;
                btnCancelDoAn.Visible = true;
                btnSaveDoAn.Visible = true;
                btnAddDoAn.Visible = true;
                this.grdDoAn.Size = new Size(620, 514);
            }
            else
            {
                PanelShowEdit.Visible = false;
                this.grdDoAn.Size = new Size(1060, 514);
                btnCancelDoAn.Visible = false;
                btnSaveDoAn.Visible = false;
                btnAddDoAn.Visible = false;
            }
            

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

        private void btnDeleteDoAn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblDoAn doAn = new tblDoAn();
                doAn.id = ID;
                Point temp = grdDoAn.CurrentCellAddress;
                if (dalDA.DeleteDA(doAn))
                {
                    showAllDA();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnUploadSourceCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Chọn file để tải lên";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileDinhKem.Text = fDialog.FileName.ToString();
            }
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
        public int id { get; set; }
        public string ChuyenN { get; set; }
        public string Email { get; set; }
        public string KhoaVien { get; set; }

    }
    class tblUploadPDF
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string data { get; set; }
    }
    class tblAdmin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
