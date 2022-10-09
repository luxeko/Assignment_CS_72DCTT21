using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Tro_Choi;
using QuanLyKhuVuiChoi.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi.Controller.Tro_Choi
{
    class tro_choi_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public tro_choi_Method()
        {
            dc = new DataConnection();
        }

        public DataTable get_TC()
        {
            string sql = "select * from tblTroChoi";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }

        public DataTable get_makhu()
        {
            string mk = "select maKhu from tblKhuVuiChoi";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(mk, con);
            con.Open();
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public bool tao_moi_TC(tbl_tro_choi tc)      
        {
            string sql = "insert into tblTroChoi(tenTroChoi, maTroChoi, maKhu, viTri) VALUES (@tenTroChoi, @maTroChoi, @maKhu, @viTri)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@tenTroChoi", SqlDbType.NVarChar, 50).Value = tc.tenTroChoi;
                cmd.Parameters.Add("@maTroChoi", SqlDbType.NVarChar, 100).Value = tc.maTroChoi;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 100).Value = tc.maKhu;
                cmd.Parameters.Add("@viTri", SqlDbType.NVarChar, 100).Value = tc.viTri;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool cap_nhat_TC(tbl_tro_choi tc)
        {
            string sql = "Update tblTroChoi SET tenTroChoi=@tenTroChoi, maTroChoi=@maTroChoi, maKhu=@maKhu, viTri=@viTri Where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tc.id;
                cmd.Parameters.Add("@tenTroChoi", SqlDbType.NVarChar, 50).Value = tc.tenTroChoi;
                cmd.Parameters.Add("@maTroChoi", SqlDbType.NVarChar, 100).Value = tc.maTroChoi;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 100).Value = tc.maKhu;
                cmd.Parameters.Add("@viTri", SqlDbType.NVarChar, 100).Value = tc.viTri;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool xoa_TC(tbl_tro_choi tc)
        {
            string sql = "Delete tblTroChoi Where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tc.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable tim_TC (string tc)
        {
            string sql = "select * from tblTroChoi where tenTroChoi like N'%"+tc+"%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
    }
   
}
