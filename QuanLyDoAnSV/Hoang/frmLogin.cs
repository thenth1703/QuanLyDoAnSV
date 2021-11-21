using System;
using System.Windows.Forms;

namespace QuanLyDoAnSV.Hoang
{
    public partial class frmLogin : Form
    {

        int soLanThu;
        
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
            if (soLanThu < 6)
            {
                soLanThu++;
                tblAdmin adm = new tblAdmin();
                adm.Username = txtUsername.Text;
                adm.Password = txtPassword.Text;
                if (GvDAL.CheckAdminUser(adm))
                {
                   // MessageBox.Show("Admin đăng nhập thành công", "Thông báo");
                    MS = adm.Username;
                    lblWrongpass.Visible = false;
                    //this.DialogResult = DialogResult.OK;
                    Hoang.Main f1 = new Hoang.Main("admin");

                    f1.ShowDialog();
                    this.Close();

                }
                else
                {
                    tblGiangVien gv = new tblGiangVien();
                    gv.MaGiangVien = txtUsername.Text;
                    gv.Password = txtPassword.Text;
                    if (GvDAL.CheckUser(gv))
                    {
                        //MessageBox.Show("Giảng viên đăng nhập thành công", "Thông báo");
                        lblWrongpass.Visible = false;
                        //this.DialogResult = DialogResult.OK;

                        Hoang.Main f1 = new Hoang.Main("gv" + gv.MaGiangVien);
                        f1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        tblSinhVien sv = new tblSinhVien();
                        sv.MaSinhVien = txtUsername.Text;
                        sv.Password = txtPassword.Text;
                        if (SvDAL.CheckUser(sv))
                        {
                           // MessageBox.Show("Sinh viên đăng nhập thành công", "Thông báo");
                            lblWrongpass.Visible = false;
                           // this.DialogResult = DialogResult.OK;

                            Hoang.Main f1 = new Hoang.Main("sv" + sv.MaSinhVien);
                            f1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            lblWrongpass.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập sai quá số lần cho phép!", "Thông báo");
            }
        }
    }
}
