using System;
using System.Windows.Forms;

namespace QuanLyDoAnSV.Hoang
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
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
            Container.Tag = fm;
            fm.Show();

        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            if (Container.Controls.Count > 0) return;
            else
            {
                container(new Hoang.frmQuanLyDoAn());
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
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
