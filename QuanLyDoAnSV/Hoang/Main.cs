using System;
using System.Windows.Forms;

namespace QuanLyDoAnSV.Hoang
{
    public partial class Main : Form
    {
        GiangVienSQL dalGV;
        SinhVienSQL dalSV;
        frmQuanLyDoAn frmDoAn = new Hoang.frmQuanLyDoAn();
        frmQuanLyGV frmGiangVien = new Hoang.frmQuanLyGV();
        frmQuanLySV frmSinhVien = new Hoang.frmQuanLySV();
        frmTaoBaoCaoSV frmBaoCaoSV = new Hoang.frmTaoBaoCaoSV();
        frmTaoBaoCaoDA frmBaoCaoDA = new Hoang.frmTaoBaoCaoDA();

        string current;

        public Main(string s)
        {
            InitializeComponent();
            dalGV = new GiangVienSQL();
            if (s == "admin")
            {
                lblMainDir.Text = "Chào mừng quản trị viên!";
                lblUserName.Text = "Administrator";
            }
            else if (s.Substring(0,2) == "gv")
            {
                
                string magv = s.Substring(2);
                string tengv = dalGV.GetTen(magv);
                lblMainDir.Text = "Chào mừng giảng viên " + tengv;
                lblUserName.Text = magv + " - " +tengv;
            }
            else
            {
                dalSV = new SinhVienSQL();
                string tensv = dalSV.getTen(s.Substring(2));
                lblMainDir.Text = "Chào mừng sinh viên " + tensv;
                lblUserName.Text = s.Substring(2) + " - " + tensv;
            }
            //load frm do an
            
            frmDoAn.TopLevel = false;
            frmDoAn.FormBorderStyle = FormBorderStyle.None;
            frmDoAn.Dock = DockStyle.Fill;
            Container.Controls.Add(frmDoAn);
            frmDoAn.Show();
            frmDoAn.Hide();

            frmGiangVien.TopLevel = false;
            frmGiangVien.FormBorderStyle = FormBorderStyle.None;
            frmGiangVien.Dock = DockStyle.Fill;
            Container.Controls.Add(frmGiangVien);
            frmGiangVien.Show();
            frmGiangVien.Hide();

            frmSinhVien.TopLevel = false;
            frmSinhVien.FormBorderStyle = FormBorderStyle.None;
            frmSinhVien.Dock = DockStyle.Fill;
            Container.Controls.Add(frmSinhVien);
            frmSinhVien.Show();
            frmSinhVien.Hide();

            frmBaoCaoSV.TopLevel = false;
            frmBaoCaoSV.FormBorderStyle = FormBorderStyle.None;
            frmBaoCaoSV.Dock = DockStyle.Fill;
            Container.Controls.Add(frmBaoCaoSV);
            frmBaoCaoSV.Show();
            frmBaoCaoSV.Hide();

            frmBaoCaoDA.TopLevel = false;
            frmBaoCaoDA.FormBorderStyle = FormBorderStyle.None;
            frmBaoCaoDA.Dock = DockStyle.Fill;
            Container.Controls.Add(frmBaoCaoDA);
            frmBaoCaoDA.Show();
            frmBaoCaoDA.Hide();


        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void container(object _form)
        {

            if (Container.Controls.Count > 0) Container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            Container.Controls.Add(fm);
            //Container.Tag = fm;
            fm.Show();

        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            /*if (Container.Controls.Count > 0) 
            {
                Container.Controls.Clear();
                container(new Hoang.frmQuanLyDoAn());
                lblMainDir.Text = "ĐỒ ÁN";
            }
            else
            {
                container(new Hoang.frmQuanLyDoAn());
                lblMainDir.Text = "ĐỒ ÁN";
            }*/
            if (current != "DA")
            {
                frmDoAn.Show();
                frmDoAn.BringToFront();
                current = "DA";
            }
            else 
            {
                current = "DA";
            }
            
           
        }
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            /*if (Container.Controls.Count > 0)
            {
                Container.Controls.Clear();
                container(new Hoang.frmQuanLyGV());
                lblMainDir.Text = "GIẢNG VIÊN";

            }
            else
            {
                container(new Hoang.frmQuanLyGV());
                lblMainDir.Text = "GIẢNG VIÊN";
            }*/
            if (current != "GV")
            {
                frmGiangVien.Show();
                frmGiangVien.BringToFront();
                current = "GV";
            }
            else
            {
                current = "GV";
            }

        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            /*if (Container.Controls.Count > 0)
            {
                Container.Controls.Clear();
                container(new Hoang.frmQuanLySV());
                lblMainDir.Text = "SINH VIÊN";

            }
            else
            {
                container(new Hoang.frmQuanLySV());
                lblMainDir.Text = "SINH VIÊN";
            }*/
            if (current != "SV")
            {
                frmSinhVien.Show();
                frmSinhVien.BringToFront();
                current = "SV";
            }
            else
            {
                current = "SV";
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            if  (btnBCDA.Visible == false)
            {
                btnBCDA.Visible = true;
                btnBCSV.Visible = true;
            }
            else
            {
                btnBCSV.Visible = false;
                btnBCDA.Visible = false;
            }
        }

        private void btnBaoCaoDoAn_Click(object sender, EventArgs e)
        {
            if (current != "BCDA")
            {
                frmBaoCaoDA.Show();
                frmBaoCaoDA.BringToFront();
                current = "BCDA";

            }
            else
            {

                current = "BCDA";
            }
        }

        private void lblMainDir_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (current != "BCSV")
            {
                frmBaoCaoSV.Show();
                frmBaoCaoSV.BringToFront();
                current = "BCSV";

            }
            else
            {
                current = "BCSV";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /* if (Container.Controls.Count > 0)
             {
                 Container.Controls.Clear();
                 container(new Hoang.frmTaoBaoCao("đồ án"));

             }
             else
             {
                 container(new Hoang.frmTaoBaoCao("đồ án"));
             }*/
            if (current != "BCDA")
            {
                frmBaoCaoDA.Show();
                frmBaoCaoDA.BringToFront();
                current = "BCDA";

            }
            else
            {
                current = "BCDA";
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Close();
        }

        private void lblMainDir_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
