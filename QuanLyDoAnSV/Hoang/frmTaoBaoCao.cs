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
    public partial class frmTaoBaoCao : Form
    {
        string loaiBaoCao;
        DoAnSQL dalDA;
        SinhVienSQL dalSV;
        public frmTaoBaoCao(string loaiBaoCao)
        {
            InitializeComponent();
         
            this.loaiBaoCao = loaiBaoCao;
            label1.Text += " " + loaiBaoCao;
        }

        private void frmTaoBaoCao_Load(object sender, EventArgs e)
        {
            if (loaiBaoCao.Equals("đồ án"))
            {
                comCrit.Items.Add("Chuyên ngành");
                comCrit.Items.Add("Điểm");
            }    
            if (loaiBaoCao.Equals("sinh viên"))
            {
                comCrit.Items.Add("Chuyên ngành");
            }    
        }

        private void comCrit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnTH.Enabled = true;
            if (loaiBaoCao.Equals("đồ án"))
            {
                Dictionary<string, string> dicCrit = new Dictionary<string, string>();
                dicCrit.Add("Chuyên ngành", "ChuyenNganh");
                dicCrit.Add("Điểm", "Diem");

                DataTable dt = new DataTable();
                dalDA = new DoAnSQL();
                dt = dalDA.GetAllDA();
                var items = dt.AsEnumerable().Select(r => r[dicCrit[comCrit.Text]]).Distinct().ToList();
                comDetail.DataSource = items;
            }
            if (loaiBaoCao.Equals("sinh viên"))
            {
                DataTable dt = new DataTable();
                dalSV = new SinhVienSQL();
                dt = dalSV.getAllSV();
                var items = dt.AsEnumerable().Select(r => r["CNganh"]).Distinct().ToList();
                comDetail.DataSource = items;
            }
        }

        private void comDetail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnCT.Enabled = true;
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            if (loaiBaoCao.Equals("đồ án"))
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
            if (loaiBaoCao.Equals("sinh viên"))
            {
                xuatSvCNTH();
            } 
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            if (loaiBaoCao.Equals("đồ án"))
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
            if (loaiBaoCao.Equals("sinh viên"))
            {
                xuatSvCNCT();
            }
        }

        private void comCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
void xuatDaCNCT()
{
   BaoCao.rptDaChuyenNganh rpt = new BaoCao.rptDaChuyenNganh();
   dalDA = new DoAnSQL();
   DataTable dt = dalDA.GetAllDA().AsEnumerable().Where(r => r["ChuyenNganh"].Equals(comDetail.Text)).CopyToDataTable();
   rpt.SetDataSource(dt);
   rpt.DataDefinition.FormulaFields["Nganh"].Text = "'" + comDetail.SelectedItem.ToString() + "'";
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}

void xuatDaDCT()
{
   BaoCao.rptDaDiem rpt = new BaoCao.rptDaDiem();
   dalDA = new DoAnSQL();
   DataTable dt = dalDA.GetAllDA().AsEnumerable().Where(r => r["Diem"].ToString().Equals(comDetail.Text)).CopyToDataTable();
   rpt.SetDataSource(dt);
   rpt.DataDefinition.FormulaFields["Diem"].Text = "'" + comDetail.SelectedItem.ToString() + "'";
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}

void xuatDACNTH()
{
   BaoCao.rptDaChuyenNganhTH rpt = new BaoCao.rptDaChuyenNganhTH();
   dalDA = new DoAnSQL();
   rpt.SetDataSource(dalDA.GetAllDA());
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}
void xuatDADTH()
{
   BaoCao.rptDaDiemTH rpt = new BaoCao.rptDaDiemTH();
   dalDA = new DoAnSQL();
   rpt.SetDataSource(dalDA.GetAllDA());
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}

void xuatSvCNCT()
{
   BaoCao.rptSVChuyenNganh rpt = new BaoCao.rptSVChuyenNganh();
   dalSV = new SinhVienSQL();
   DataTable dt = dalSV.getAllSV().AsEnumerable().Where(r => r["CNganh"].Equals(comDetail.Text)).CopyToDataTable();
   rpt.SetDataSource(dt);
   rpt.DataDefinition.FormulaFields["Nganh"].Text = "'" + comDetail.SelectedItem.ToString().ToUpper() + "'";
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}
void xuatSvCNTH()
{
   BaoCao.rptSVChuyenNganhTH rpt = new BaoCao.rptSVChuyenNganhTH();
   dalSV = new SinhVienSQL();
   rpt.SetDataSource(dalSV.getAllSV());
   Hoang.frmBaoCao f = new Hoang.frmBaoCao(rpt);
   f.Show();
}
    }
}
