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
    public partial class frmDoiMatKhau : Form
    {
        
        GiangVienSQL dalgv;
        SinhVienSQL dalsv;
        
        
        public frmDoiMatKhau()
        {
            InitializeComponent();
            
        }
        private bool checkData()
        {
            if (string.IsNullOrEmpty(txtOldPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPassComfirm.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtNewPass.Text.Equals(txtOldPass.Text))
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!txtNewPass.Text.Equals(txtNewPassComfirm.Text))
            {
                MessageBox.Show("Sai mật khẩu nhập lại! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (Globals.ID == "admin")
                {
                    dalgv = new GiangVienSQL();
                    tblAdmin adm = new tblAdmin();
                    adm.Username = "admin";
                    adm.Password = txtNewPass.Text;
                    if (dalgv.UpdatePassAdmin(adm))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Globals.ID.Substring(0, 2) == "gv")
                {
                    dalgv = new GiangVienSQL();
                    tblGiangVien gV = new tblGiangVien();
                    gV.MaGiangVien = Globals.ID.Substring(2);
                    gV.Password = txtNewPass.Text;
                    if (dalgv.UpdatePassGV(gV))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Globals.ID.Substring(0, 2) == "sv")
                {
                    dalsv = new SinhVienSQL();
                    tblSinhVien sV = new tblSinhVien();
                    sV.MaSinhVien = Globals.ID.Substring(2);
                    sV.Password = txtNewPass.Text;
                    if (dalsv.UpdatePassSV(sV))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
