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
    public partial class frmLogin : Form
    {

        int soLanThu;
        bool laGV;
        public string MS;
        SinhVienSQL SvDAL;
        GiangVienSQL GvDAL;
        public frmLogin()
        {
            InitializeComponent();
            SvDAL = new SinhVienSQL();
            GvDAL = new GiangVienSQL();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            soLanThu = 0;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tblAdmin adm = new tblAdmin();
            adm.Username = txtUsername.Text;
            adm.Password = txtPassword.Text;
            if (GvDAL.CheckAdminUser(adm))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                MS = adm.Username;
                this.DialogResult = DialogResult.OK;
                Hoang.Main f1 = new Hoang.Main();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
