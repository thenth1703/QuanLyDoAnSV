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

        public DataTable getGV()
        {
            string sql = "SELECT * FROM tblGiangVien";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool insertGV(tblGiangVien gV)
        {
            string sql = "INSERT INTO tblGiangVien VALUES (@maGiangVien, @hoTenGV)";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@hoTenGV", SqlDbType.NVarChar).Value = gV.HoTenGV;
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
            string sql = "UPDATE tblGiangVien SET HoTenGV = @hoTenGV" +
                         "WHERE MaGiangVien = @maGiangVien";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.Parameters.Add("@hoTenGV", SqlDbType.NVarChar).Value = gV.HoTenGV;
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
            string sql = "DELETE tblSinhVien WHERE MaGiangVien = @maGiangVien";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maGiangVien", SqlDbType.VarChar).Value = gV.MaGiangVien;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
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
