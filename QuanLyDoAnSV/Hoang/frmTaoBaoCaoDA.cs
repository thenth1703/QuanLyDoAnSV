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
    public partial class frmTaoBaoCaoDA : Form
    {
        
        DoAnSQL dalDA;
        
        public frmTaoBaoCaoDA()
        {
            InitializeComponent();
            
        }

        private void frmTaoBaoCaoDA_Load(object sender, EventArgs e)
        {
            comCrit.Items.Add("Chuyên ngành");
            comCrit.Items.Add("Điểm");
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

            Dictionary<string, string> dicCrit = new Dictionary<string, string>();
            dicCrit.Add("Chuyên ngành", "ChuyenNganh");
            dicCrit.Add("Điểm", "Diem");
            DataTable dt = new DataTable();
            dalDA = new DoAnSQL();
            dt = dalDA.GetAllDA();
            var items = dt.AsEnumerable().Select(r => r[dicCrit[comCrit.Text]]).Distinct().ToList();
            comDetail.DataSource = items;

        }

        private void comDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comDetail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnCT.Enabled = true;
        }
        private void container(object _form)
        {

            if (panelView.Controls.Count > 0)
            { panelView.Controls.Clear(); }

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelView.Controls.Add(fm);
            //Container.Tag = fm;
            fm.Show();

        }
        private void btnTH_Click(object sender, EventArgs e)
        {
            if (comCrit.SelectedItem.ToString().Equals("Chuyên ngành"))
            {
                xuatDACNTH();
            }
            if (comCrit.SelectedItem.ToString().Equals("Điểm"))
            {
                xuatDADTH();
            }
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            if (comCrit.SelectedItem.ToString().Equals("Chuyên ngành"))
            {
                xuatDaCNCT();
            }
            if (comCrit.SelectedItem.ToString().Equals("Điểm"))
            {
                xuatDaDCT();
            }
        }

        void xuatDaCNCT()
        {
            BaoCao.rptDaChuyenNganh rpt = new BaoCao.rptDaChuyenNganh();
            dalDA = new DoAnSQL();
            DataTable dt = dalDA.GetAllDA().AsEnumerable().Where(r => r["ChuyenNganh"].Equals(comDetail.Text)).CopyToDataTable();
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Nganh"].Text = "'" + comDetail.SelectedItem.ToString() + "'";
            Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
            //f.Show();
            container(f);
        }

        void xuatDaDCT()
        {
            BaoCao.rptDaDiem rpt = new BaoCao.rptDaDiem();
            dalDA = new DoAnSQL();
            DataTable dt = dalDA.GetAllDA().AsEnumerable().Where(r => r["Diem"].ToString().Equals(comDetail.Text)).CopyToDataTable();
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Diem"].Text = "'" + comDetail.SelectedItem.ToString() + "'";
            Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
            container(f);
        }

        void xuatDACNTH()
        {
            BaoCao.rptDaChuyenNganhTH rpt = new BaoCao.rptDaChuyenNganhTH();
            dalDA = new DoAnSQL();
            rpt.SetDataSource(dalDA.GetAllDA());
            Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
            container(f);
        }
        void xuatDADTH()
        {
            BaoCao.rptDaDiemTH rpt = new BaoCao.rptDaDiemTH();
            dalDA = new DoAnSQL();
            rpt.SetDataSource(dalDA.GetAllDA());
            Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
            container(f);
        }
    }
}
