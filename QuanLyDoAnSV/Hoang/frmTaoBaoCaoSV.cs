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
    public partial class frmTaoBaoCaoSV : Form
    {
        
        
        SinhVienSQL dalSV;

        public frmTaoBaoCaoSV()
        {
            InitializeComponent();
            
        }

        private void frmTaoBaoCao_Load(object sender, EventArgs e)
        {

            comCrit.Items.Add("Chuyên ngành");
            
            comCrit.SelectedIndex = 0;
            getindex();
        }

        private void comCrit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getindex();
        }

        private void getindex()
        {
            btnTH.Enabled = true;
            
            DataTable dt = new DataTable();
            dalSV = new SinhVienSQL();
            dt = dalSV.getAllSV();
            var items = dt.AsEnumerable().Select(r => r["CNganh"]).Distinct().ToList();
            comDetail.DataSource = items;
            
        }

        private void comDetail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnCT.Enabled = true;
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            
                xuatSvCNTH();
            
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            
                xuatSvCNCT();
            
        }

        private void comCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void container(object _form)
        {

            if (panelView.Controls.Count > 0) panelView.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelView.Controls.Add(fm);
            //Container.Tag = fm;
            fm.Show();

        }

        void xuatSvCNCT()
        {
           BaoCao.rptSVChuyenNganh rpt = new BaoCao.rptSVChuyenNganh();
           dalSV = new SinhVienSQL();
           DataTable dt = dalSV.getAllSV().AsEnumerable().Where(r => r["CNganh"].Equals(comDetail.Text)).CopyToDataTable();
           rpt.SetDataSource(dt);
           rpt.DataDefinition.FormulaFields["Nganh"].Text = "'" + comDetail.SelectedItem.ToString().ToUpper() + "'";
           Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
           //f.Show();
           container(f);
        }
        void xuatSvCNTH()
        {
           BaoCao.rptSVChuyenNganhTH rpt = new BaoCao.rptSVChuyenNganhTH();
           dalSV = new SinhVienSQL();
           rpt.SetDataSource(dalSV.getAllSV());
           Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
            //f.Show();
            container(f);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {

        }
    }
}
