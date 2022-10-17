using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Khu_Vui_Choi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi.Controller.Khu_Vui_Choi
{
    class khu_vui_choi_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public khu_vui_choi_Method()        
        {
            dc = new DataConnection();
        }

        public DataTable get_KVC()      
        {
            //b1: Tạo câu lệnh sql để lấy toàn bộ dữ liệu
            string sql = "select * from tblKhuVuiChoi";
            //b2: Tạo kết nối đến sql
            SqlConnection con = dc.getConnect();
            //b3: Khởi tạo đối tượng của lớp sqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //b4: Mở kết nối
            con.Open();
            //b5: Đổ dữ liệu từ sqlDataAdapter vào DataTable
            DataTable tb = new DataTable();
            da.Fill(tb);
            //b6: Đóng kết nối
            con.Close();
            return tb;
        }

        public bool tao_moi_KVC(tbl_khu_vui_choi kvc)       //Nếu thêm thành công thì trả về true không thì false
        {

            string sql = "insert into tblKhuVuiChoi(maKhu,tenKhu,viTri,dienTich,gioMo,gioDong,giaNL,giaTE) values(@maKhu,@tenKhu,@viTri,@dienTich,@gioMo,@gioDong,@giaNL,@giaTE)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar).Value = kvc.maKhu;
                cmd.Parameters.Add("@tenKhu", SqlDbType.NVarChar).Value = kvc.tenKhu;
                cmd.Parameters.Add("@viTri", SqlDbType.NVarChar).Value = kvc.viTri;
                cmd.Parameters.Add("@dienTich", SqlDbType.NVarChar).Value = kvc.dienTich;
                cmd.Parameters.Add("@gioMo", SqlDbType.NVarChar).Value = kvc.gioMo;
                cmd.Parameters.Add("@gioDong", SqlDbType.NVarChar).Value = kvc.gioDong;
                cmd.Parameters.Add("@giaNL", SqlDbType.Decimal).Value = kvc.giaNL;
                cmd.Parameters.Add("@giaTE", SqlDbType.Decimal).Value = kvc.giaTE;
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool cap_nhat_KVC(tbl_khu_vui_choi kvc)     
        {
            string sql = "Update tblKhuVuiChoi SET maKhu=@maKhu, tenKhu=@tenKhu, viTri=@viTri, dienTich=@dienTich, gioMo=@gioMo, gioDong=@gioDong, giaNL=@giaNL, giaTE=@giaTE Where id =@id ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kvc.id;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar).Value = kvc.maKhu;
                cmd.Parameters.Add("@tenKhu", SqlDbType.NVarChar).Value = kvc.tenKhu;
                cmd.Parameters.Add("@viTri", SqlDbType.NVarChar).Value = kvc.viTri;
                cmd.Parameters.Add("@dienTich", SqlDbType.NVarChar).Value = kvc.dienTich;
                cmd.Parameters.Add("@gioMo", SqlDbType.NVarChar).Value = kvc.gioMo;
                cmd.Parameters.Add("@gioDong", SqlDbType.NVarChar).Value = kvc.gioDong;
                cmd.Parameters.Add("@giaNL", SqlDbType.Decimal).Value = kvc.giaNL;
                cmd.Parameters.Add("@giaTE", SqlDbType.Decimal).Value = kvc.giaTE;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool xoa_KVC(tbl_khu_vui_choi kvc)
        {
            string sql = "Delete tblKhuVuiChoi Where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kvc.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable tim_KVC (string kvc)
        {
            string sql = "select * from tblKhuVuiChoi where tenKhu like N'%" + kvc + "%'";
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
       

