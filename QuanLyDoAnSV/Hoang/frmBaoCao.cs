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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao(object rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
