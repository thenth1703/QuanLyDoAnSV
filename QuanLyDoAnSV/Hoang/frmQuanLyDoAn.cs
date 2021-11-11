using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            grdDoAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdDoAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
