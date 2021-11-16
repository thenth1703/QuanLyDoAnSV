using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAnSV.Hoang
{
    class DoAnSQL
    {
        SqlDataAdapter da;
        SqlConnection conn = DataConnection.getConnect();
        SqlCommand cmd;
        public DataTable GetAllDA()
        {
            string sql = "SELECT tblDoAn.id, TenDoAn, MSV, HoTenSV, MGV, HoTenGV, ChuyenNganh, Diem,ChuDe,NoiDung,BanMem,SourceCode " +
                "FROM tblDoAn JOIN tblSinhVien on tblDoAn.MSV = tblSinhVien.MaSinhVien " +
                "JOIN tblGiangVien on tblDoAn.MGV = tblGiangVien.MaGiangVien";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool InsertDA(tblDoAn doAn)
        {
            string sql = "INSERT INTO tblDoAn (TenDoAn, MSV, MGV, ChuyenNganh, Diem, ChuDe, NoiDung, BanMem, SourceCode)" +
                "VALUES (@tenDoAn, @mSV, @mGV, @chuyenNganh, @diem, @chude, @noidung,@banmem,@source)";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@tenDoAn", SqlDbType.NVarChar).Value = doAn.TenDoAn;
                cmd.Parameters.Add("@mSV", SqlDbType.VarChar).Value = doAn.MSV;
                cmd.Parameters.Add("@mGV", SqlDbType.VarChar).Value = doAn.MGV;
                cmd.Parameters.Add("@chuyenNganh", SqlDbType.NVarChar).Value = doAn.ChuyenNganh;
                cmd.Parameters.Add("@diem", SqlDbType.Float).Value = doAn.Diem;
                cmd.Parameters.Add("@chude", SqlDbType.NVarChar).Value = doAn.ChuDe;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = doAn.NoiDung;
                cmd.Parameters.Add("@banmem", SqlDbType.NVarChar).Value = doAn.BanMem;
                cmd.Parameters.Add("@source", SqlDbType.NVarChar).Value = doAn.SourceCode;
                cmd.ExecuteNonQuery();
                conn.Close();
        }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public bool UpdateDA(tblDoAn doAn)
        {
            string sql = "UPDATE tblDoAn SET TenDoAn = @tenDoAn, ChuDe = @chude , NoiDung = @noidung, BanMem = @banmem, SourceCode = @source, MSV = @mSV, MGV = @mGV, ChuyenNganh = @chuyenNganh, Diem = @diem" +
                " WHERE id = @id";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = doAn.id;
                cmd.Parameters.Add("@tenDoAn", SqlDbType.NVarChar).Value = doAn.TenDoAn;
                cmd.Parameters.Add("@mSV", SqlDbType.VarChar).Value = doAn.MSV;
                cmd.Parameters.Add("@mGV", SqlDbType.VarChar).Value = doAn.MGV;
                cmd.Parameters.Add("@chuyenNganh", SqlDbType.NVarChar).Value = doAn.ChuyenNganh;
                cmd.Parameters.Add("@diem", SqlDbType.Int).Value = doAn.Diem;
                cmd.Parameters.Add("@chude", SqlDbType.NVarChar).Value = doAn.ChuDe;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = doAn.NoiDung;
                cmd.Parameters.Add("@banmem", SqlDbType.NVarChar).Value = doAn.BanMem;
                cmd.Parameters.Add("@source", SqlDbType.NVarChar).Value = doAn.SourceCode;
                

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;

        }

        public bool DeleteDA(tblDoAn doAn)
        {
            string sql = "DELETE tblDoAn WHERE id = @id";
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = doAn.id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

        public DataTable getEmptyDA()
        {
            string sql = "SELECT tblDoAn.id, TenDoAn, ChuDe, NoiDung, MSV, HoTenSV, MGV, HoTenGV, ChuyenNganh, Diem, BanMem, SourceCode " +
                "FROM tblDoAn JOIN tblSinhVien on tblDoAn.MSV = tblSinhVien.MaSinhVien " +
                "JOIN tblGiangVien on tblDoAn.MGV = tblGiangVien.MaGiangVien " +
                "WHERE tblDoAn.id = 0";

            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
