using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyDoAnSV.Hoang
{
    public partial class frmQuanLyDoAn : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
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
            sql = "Select * from tblDoAn order by id";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDoAn.DataSource = dt;
            grdDoAn.Refresh();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
