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
            
            container(new Hoang.frmMainGV());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
