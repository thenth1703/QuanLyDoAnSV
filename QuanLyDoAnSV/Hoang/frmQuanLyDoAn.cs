using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Text;


namespace QuanLyDoAnSV.Hoang
{
   

    public partial class frmQuanLyDoAn : Form
    {
        

        DoAnSQL dalDA;
        SinhVienSQL dalSV;
        GiangVienSQL dalGV;
        string maGV, maSV;
        int ID;
        static string temp = Globals.ID;

        public frmQuanLyDoAn()
        {
            InitializeComponent();
            dalDA = new DoAnSQL();
            dalSV = new SinhVienSQL();
            dalGV = new GiangVienSQL();


            if (Globals.ID.Substring(0,2) == "sv")
            {
                btnDeleteDoAn.Visible = false;
                btnAddDoAn.Visible = false;
                btnSaveDoAn.Visible = false;
                txtDiem.Visible = false;
                lblDiem.Visible = false;
            }
            
        }

        
        public void reloadDA()
        {
            
        }
        
        public void showAllDA()
        {
            //reload gridview
            grdDoAn.DataSource = null;
            DataTable dt = dalDA.GetAllDA();
            grdDoAn.DataSource = dt;
        }
        private void addGV()
        {
            comfGV.Items.Clear();
            DataTable dt = new DataTable();
            dt = dalGV.GetAllGV();
            List<string> temp = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp.Add(dt.Rows[i].ItemArray[1] + " - " + dt.Rows[i].ItemArray[2]);
            }
            foreach (var item in temp)
            {
                comfGV.Items.Add(item);
            }
        }
        private void addSV()
        {
            comfSV.Items.Clear();
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
            //open pdf
            if (txtBanMem.Text != "")
            {

                axAcroPDF1.Visible = true;
                txtTimKiem.Visible = false;
                lblSinhVienThucHien.Visible = true;
                lblTenDoAn.Visible = true;
                lblSVTH.Visible = true;
                lblDA.Visible = true;
                btnBack.Visible = true;
                label1.Visible = false;
                lblCount.Visible = false;
                lblCount1.Visible = false;
                label3.Visible = false;
                lblGVHD.Visible = true;
                lblGVHDtxt.Visible = true;

                lblSinhVienThucHien.Text = comfSV.Text;
                lblTenDoAn.Text = txtTenDoAn.Text;
                lblGVHDtxt.Text = comfGV.Text;
                axAcroPDF1.src = txtBanMem.Text;
            }

        }

        private void frmMainGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDoAnDataSet.tblDoAn' table. You can move, or remove it, as needed.
            // this.tblDoAnTableAdapter.Fill(this.qLDoAnDataSet.tblDoAn);
            
            addGV();
            addSV();
            showAllDA();
            Count();
            
        }
        
        public void Count()
        {
            var count = grdDoAn.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value))
                .Count();
            var count1 = grdDoAn.Rows.Cast<DataGridViewRow>()
                .Where(row => !(row.Cells["BanMem"].Value == null || row.Cells["BanMem"].Value == DBNull.Value))
                .Count();
            lblCount.Text = count.ToString();
            lblCount1.Text = (count - count1 + 1).ToString();

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
            if (grdDoAn.Width == 620)
            {
                if (Globals.ID.Substring(0,2) == "sv")
                {
                    if (Globals.ID.Substring(2) == maSV)
                    {
                        btnDeleteDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnSaveDoAn.Visible = true;
                        //btnClear.Visible = true;
                    }
                    else
                    {
                        btnDeleteDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnSaveDoAn.Visible = false;
                        btnClear.Visible = false;
                    }
                }
                else
                {
                    btnDeleteDoAn.Visible = true;
                    btnAddDoAn.Visible = true;
                    btnSaveDoAn.Visible = true;
                    btnClear.Visible = true;
                }
            }

            if (grdDoAn.Width == 1060)
            {
                if (Globals.ID.Substring(0,2) == "sv")
                {
                    if (Globals.ID.Substring(2) == maSV)
                    {
                        btnDeleteDoAn.Visible = true;
                        btnAddDoAn.Visible = false;
                        btnSaveDoAn.Visible = false;
                        btnClear.Visible = false;
                    }
                    else
                    {
                        btnDeleteDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnSaveDoAn.Visible = false;
                        btnClear.Visible = false;
                    }
                }
                else
                {
                    btnDeleteDoAn.Visible = true;
                    btnAddDoAn.Visible = false;
                    btnSaveDoAn.Visible = false;
                    btnClear.Visible = false;
                }
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
                if (txtDiem.Text != "")
                {
                    doAn.Diem = int.Parse(txtDiem.Text);
                }
                
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
                Count();
            }    

            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //nút huỷ
            this.grdDoAn.Size = new Size(1060, 514);
            btnCancelDoAn.Visible = false;
            btnSaveDoAn.Visible = false;
            btnAddDoAn.Visible = false;
            btnClear.Visible = false; ;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            //lưu
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
                    MessageBox.Show("Đã xảy ra lỗi khi update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Count();
            }

            

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // click vào nút sửa
            addGV();
            addSV();
            // nếu nút Huỷ không xuất hiện
            if (btnCancelDoAn.Visible==false)
            {
                // hiện bảng sửa
                this.grdDoAn.Size = new Size(620, 514);
                //nếu là sinh viên
                if (Globals.ID.Substring(0,2) == "sv")
                {
                    // nếu sinh viên sửa đồ án của mình
                    if (Globals.ID.Substring(2) == txtMSV.Text)
                    {
                        btnDeleteDoAn.Visible = false;
                        btnCancelDoAn.Visible = true;
                        btnSaveDoAn.Visible = true;
                        btnAddDoAn.Visible = false; 
                        btnClear.Visible = true;
                    }
                    else
                    {
                        btnCancelDoAn.Visible = true;
                        btnSaveDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnClear.Visible = false;
                    }
                }
                else
                {
                    btnCancelDoAn.Visible = true;
                    btnSaveDoAn.Visible = true;
                    btnAddDoAn.Visible = true;
                    btnClear.Visible = true;
                }
                
            }
            else
            {
                // nếu nút huỷ đã show
                this.grdDoAn.Size = new Size(1060, 514);
                if (temp.Substring(0,2) == "sv")
                {
                    if (temp.Substring(2) == txtMSV.Text)
                    {

                        btnCancelDoAn.Visible = false;
                        btnSaveDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnClear.Visible = false; ;
                    }
                    else
                    {
                        btnCancelDoAn.Visible = false;
                        btnSaveDoAn.Visible = false;
                        btnAddDoAn.Visible = false;
                        btnClear.Visible = false;
                    }
                }
                else
                {
                    btnCancelDoAn.Visible = false;
                    btnSaveDoAn.Visible = false;
                    btnAddDoAn.Visible = false;
                    btnClear.Visible = false;
                }
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
            txtMSV.Text = maSV;
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

        private void grdDoAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            // tìm kiếm tất cả các cột
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewColumn column in grdDoAn.Columns)
            {
                sb.AppendFormat("CONVERT({0}, System.String) LIKE '%{1}%' OR ", column.Name, txtTimKiem.Text);
            }
            sb.Remove(sb.Length - 3, 3);
            (grdDoAn.DataSource as DataTable).DefaultView.RowFilter = sb.ToString();
            
            
        }

        private void comFName_SelectionChangeCommitted(object sender, EventArgs e)
        {

               
            
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtTimKiem.Visible = true;
            axAcroPDF1.Visible = false;
            btnBack.Visible = false;
            label1.Visible = true;
            lblCount.Visible = true;
            lblCount1.Visible = true;
            label3.Visible = true;
            lblSinhVienThucHien.Visible = false;
            lblTenDoAn.Visible = false;
            lblSVTH.Visible = false;
            lblDA.Visible = false;
            lblGVHD.Visible = false;
            lblGVHDtxt.Visible = false;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBanMem.Text = "";
            txtChuDe.Text = "";
            txtChuyenNganh.Text = "";
            txtDiem.Text = "";
            txtFileDinhKem.Text = "";
            txtMSV.Text = "";
            txtNoiDung.Text = "";
            txtTenDoAn.Text = "";
            comfGV.Text = "";
            comfSV.Text = "";

        }

        private void comfSV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
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
        public int PDFid { get; set; }

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
        
        public string ChuyenN { get; set; }
        public string Email { get; set; }
        public string KhoaVien { get; set; }
        public int id { get; set; }

    }
    class tblUploadPDF
    {
        public int id { get; set; }
        public string fname { get; set; }
        public byte[] fcontent { get; set; }

    }
    class tblAdmin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
