using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Dich_Vu;
using QuanLyKhuVuiChoi.View;

namespace QuanLyKhuVuiChoi.Controller.Dich_vu
{
    internal class dich_vu_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public dich_vu_Method()
        {
            dc = new DataConnection();
        }
        public DataTable getDV()
        {
            string sql = "select * from tblDichVu";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public DataTable get_makhu()
        {
            string mk = "select maKhu from tblDichVu";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(mk, con);
            con.Open();
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public bool tao_moi_DV(tbl_dich_vu dv)
        {
            string sql = "insert into tblDichVu(tenDichVu, maDichVu, giaDichVu, maKhu) VALUES (@tenDichVu, @maDichVu, @giaDichVu, @maKhu)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maDichVu", SqlDbType.NVarChar, 100).Value = dv.maDichVu;
                cmd.Parameters.Add("@tenDichVu", SqlDbType.NVarChar, 50).Value = dv.tenDichVu;
                cmd.Parameters.Add("@giaDichVu", SqlDbType.NVarChar, 100).Value = dv.giaDichVu;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 100).Value = dv.maKhu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool cap_nhat_DV(tbl_dich_vu dv)
        {
            string sql = "Update tblDichVu SET maDichVu=@maDichVu, tenDichVu=@tenDichVu, giaDichVu=@giaDichVu, maKhu=@maKhu Where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = dv.id;
                cmd.Parameters.Add("@maDichVu", SqlDbType.NVarChar, 100).Value = dv.maDichVu;
                cmd.Parameters.Add("@tenDichVu", SqlDbType.NVarChar, 50).Value = dv.tenDichVu;
                cmd.Parameters.Add("@giaDichVu", SqlDbType.NVarChar, 100).Value = dv.giaDichVu;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 100).Value = dv.maKhu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool xoa_DV(tbl_dich_vu dv)
        {
            string sql = "Delete tblDichVu Where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = dv.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable tim_DV(string dv)
        {
            string sql = "select * from tblDichVu where tenDichVu like N'%" + dv + "%'";
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
