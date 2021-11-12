using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAnSV.Hoang
{
    class SinhVienDAL
    {
        SqlDataAdapter da;
        SqlConnection conn = DataConnection.getConnect();
        SqlCommand cmd;

        public DataTable getAllSinhVien()
        {
            string sql = "SELECT * FROM tblSinhVien ORDER BY id";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getEmptySinhVien()
        {
            string sql = "SELECT * FROM tblSinhVien WHERE id = 0 ORDER BY id ";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool InsertSinhVien(tblSinhVien sV)
        {
            string sql = "INSERT INTO tblSinhVien (MaSinhVien, HoTenSV, Password, CNganh, NgaySinh, GioiTinh) VALUES (@maSinhVien, @hoTenSV, @Password, @cNganh, @ngaySinh, @gioiTinh)";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maSinhVien", SqlDbType.VarChar).Value = sV.MaSinhVien;
                cmd.Parameters.Add("@hoTenSV", SqlDbType.NVarChar).Value = sV.HoTenSV;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = sV.Password;
                cmd.Parameters.Add("@cNganh", SqlDbType.NVarChar).Value = sV.CNganh;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = sV.NgaySinh;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = sV.GioiTinh;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public bool UpdateSinhVien(tblSinhVien sV)
        {
            string sql = "UPDATE tblSinhVien SET MaSinhVien = @maSinhVien, HoTenSV = @hoTenSV, Password = @password, CNganh = @cNganh, NgaySinh = @ngaySinh, GioiTinh = @gioiTinh " +
                         "WHERE id = @iD";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@iD", SqlDbType.VarChar).Value = sV.id;
                cmd.Parameters.Add("@maSinhVien", SqlDbType.VarChar).Value = sV.MaSinhVien;
                cmd.Parameters.Add("@hoTenSV", SqlDbType.NVarChar).Value = sV.HoTenSV;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = sV.Password;
                cmd.Parameters.Add("@cNganh", SqlDbType.NVarChar).Value = sV.CNganh;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = sV.NgaySinh.Date;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = sV.GioiTinh;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public bool DeleteSinhVien(tblSinhVien sV)
        {
            string sql = "DELETE tblSinhVien WHERE id = @iD";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@iD", SqlDbType.VarChar).Value = sV.id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string getTen(string ms)
        {
            string sql = "SELECT HoTenSV FROM tblSinhVien WHERE MaSinhVien = @maSinhVien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maSinhVien", SqlDbType.NVarChar).Value = ms;
            conn.Open();
            string re = cmd.ExecuteScalar().ToString();
            conn.Close();
            return re;
        }

        public bool CheckUser(tblSinhVien sV)
        {
            string sql = "SELECT * FROM tblSinhVien WHERE MaSinhVien = @maSinhVien AND Password = @password";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maSinhVien", SqlDbType.VarChar).Value = sV.MaSinhVien;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = sV.Password;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);    
                conn.Close();
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    
}
