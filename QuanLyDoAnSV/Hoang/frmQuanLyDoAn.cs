using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Diagnostics;
namespace QuanLyDoAnSV.Hoang
{
    public partial class frmQuanLyDoAn : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da_full = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt_full = new DataTable();
        string sql, constr,sql_full;
        int i;
        public frmQuanLyDoAn()
        {
            InitializeComponent();
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
            NapGrd();

        }

        private void NapGrd()
        {
            grdDoAn.Columns.Clear();
            grdDoAnFull.Columns.Clear();
            constr = "Data Source=ONE\\SQLEXPRESS;Initial Catalog=QLDoAn;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select id,TenDoAn,MSV,ChuyenNganh,MGV,Diem from tblDoAn order by id";
            sql_full = "select * from tblDoAn order by id";
            da_full = new SqlDataAdapter(sql_full, conn);
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            da_full.Fill(dt_full);
            grdDoAnFull.DataSource = dt_full;
            grdDoAn.DataSource = dt;
            conn.Close();
            grdDoAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdDoAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            NapCT();
            grdDoAn.Refresh();
            grdDoAnFull.Refresh();
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
            NapCT();
        }
        public void NapCT()
        {
            i = grdDoAn.CurrentRow.Index;
            txtTenDeAn.Text = grdDoAn.Rows[i].Cells["TenDoAn"].Value.ToString();
            txtTenSV.Text = grdDoAn.Rows[i].Cells["TenDoAn"].Value.ToString();
            txtChuDe.Text = grdDoAnFull.Rows[i].Cells["ChuDe"].Value.ToString();
            txtNoiDung.Text = grdDoAnFull.Rows[i].Cells["NoiDung"].Value.ToString();
            txtBanMem.Text = grdDoAnFull.Rows[i].Cells["BanMem"].Value.ToString();
            txtFileDinhKem.Text = grdDoAnFull.Rows[i].Cells["SourceCode"].Value.ToString();
            txtMSV.Text = grdDoAn.Rows[i].Cells["MSV"].Value.ToString();
            txtChuyenNganh.Text = grdDoAn.Rows[i].Cells["ChuyenNganh"].Value.ToString();
            txtMGV.Text = grdDoAn.Rows[i].Cells["MGV"].Value.ToString();
            txtDiem.Text = grdDoAn.Rows[i].Cells["Diem"].Value.ToString();

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


        public void uploadPDF()
        {
            string filetype;
            string filename;

            filename = txtBanMem.Text.Substring(Convert.ToInt32(txtBanMem.Text.LastIndexOf("\\")) + 1, txtBanMem.Text.Length - (Convert.ToInt32(txtBanMem.Text.LastIndexOf("\\")) + 1));
            filetype = txtBanMem.Text.Substring(Convert.ToInt32(txtBanMem.Text.LastIndexOf(".")) + 1, txtBanMem.Text.Length - (Convert.ToInt32(txtBanMem.Text.LastIndexOf(".")) + 1));

            //Validate user upload only specific bytes - un comment below lines if you need to validate only PDF files

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return;
            }

            byte[] FileBytes = null;

            try
            {
                // Open file to read using file path
                FileStream FS = new FileStream(txtBanMem.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // Add filestream to binary reader
                BinaryReader BR = new BinaryReader(FS);

                // get total byte length of the file
                long allbytes = new FileInfo(txtBanMem.Text).Length;

                // read entire file into buffer
                FileBytes = BR.ReadBytes((Int32)allbytes);

                // close all instances
                FS.Close();
                FS.Dispose();
                BR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }

            //Store File Bytes in database image filed 

            conn.Open();
            SqlCommand sqlcmd = new SqlCommand("insert into PDFupload(fname,fcontent) values (@FN, @FB)", conn);
            sqlcmd.Parameters.AddWithValue("@FN", filename);
            sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
            sqlcmd.ExecuteNonQuery();
            conn.Close();
            NapCT();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uploadPDF();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            PanelShowEdit.Visible = true;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            uploadPDF();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PanelShowEdit.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
