using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAnSV.Hoang
{
    class GiangVienSQL
    {
        SqlDataAdapter da;
        SqlConnection conn = DataConnection.getConnect();
        SqlCommand cmd;

        public DataTable GetAllGV()
        {
            string sql = "SELECT id ,MaGiangVien, HoTenGV, Password, ChuyenN, Email, KhoaVien FROM tblGiangVien";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool insertGV(tblGiangVien gV)
        {
            string sql = "INSERT INTO tblGiangVien (MaGiangVien, HoTenGV, Password, ChuyenN, Email, KhoaVien) VALUES (@maGiangVien, @hoTenGV, @password,@chuyennganh,@email,@khoavien)";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@hoTenGV", SqlDbType.NVarChar).Value = gV.HoTenGV;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = gV.Password;
                cmd.Parameters.Add("@chuyennganh", SqlDbType.NVarChar).Value = gV.ChuyenN;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = gV.Email;
                cmd.Parameters.Add("@khoavien", SqlDbType.NVarChar).Value = gV.KhoaVien;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public bool updateGV(tblGiangVien gV)
        {
            string sql = "UPDATE tblGiangVien SET HoTenGV = @hoTenGV,  Password = @password, ChuyenN = @chuyennganh, Email = @email, KhoaVien = @khoavien" +
                         " WHERE id = @id";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = gV.id;
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@hoTenGV", SqlDbType.NVarChar).Value = gV.HoTenGV;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = gV.Password;
                cmd.Parameters.Add("@chuyennganh", SqlDbType.NVarChar).Value = gV.ChuyenN;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = gV.Email;
                cmd.Parameters.Add("@khoavien", SqlDbType.NVarChar).Value = gV.KhoaVien;
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public bool deleteGV(tblGiangVien gV)
        {
            string sql = "DELETE tblGiangVien WHERE id = @id";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = gV.id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public string GetTen(string ms)
        {
            string sql = "SELECT HoTenGV FROM tblGiangVien WHERE MaGiangVien = @maGiangVien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maGiangVien", SqlDbType.NVarChar).Value = ms;
            conn.Open();
            string re = cmd.ExecuteScalar().ToString();
            conn.Close();
            return re;
        }

        public bool CheckUser(tblGiangVien gV)
        {
            string sql = "SELECT * FROM tblGiangVien WHERE MaGiangVien = @maGiangVien AND Password = @password";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = gV.Password;
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

        public bool UpdatePassGV(tblGiangVien gV)
        {
            string sql = "UPDATE tblGiangVien SET Password = @password " +
                         "WHERE MaGiangVien = @maGiangVien";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = gV.Password;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }
    }
}
