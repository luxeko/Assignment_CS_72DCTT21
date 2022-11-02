using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Giam_Gia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi.Controller.GiamGia
{
    internal class GiamGia_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public GiamGia_Method()
        {
            dc = new DataConnection();
        }
        public DataTable getLoaiKH()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("loaiKhachHang", typeof(String));
            DataRow row1 = dt.NewRow();
            DataRow row2 = dt.NewRow();
            row1["loaiKhachHang"] = "0 - TE";
            row2["loaiKhachHang"] = "1 - NL";
            dt.Rows.InsertAt(row1, 0);
            dt.Rows.InsertAt(row2, 0);
            return dt;
        }
        public bool checkMave(string mv)
        {

            SqlConnection con = dc.getConnect();
            SqlCommand checkMave = new SqlCommand("SELECT COUNT(maVe) FROM tblGiamGia WHERE ([maVe] = @maVe)", con);
            con.Open();
            checkMave.Parameters.AddWithValue("@maVe", mv);
            int maVeExist = (int)checkMave.ExecuteScalar();

            if (maVeExist > 0)
            {
                return true;
            }
            con.Close();
            return false;
        }
        /*
        public bool checkSoluong(string sl)
        {
            SqlConnection con = dc.getConnect();
            SqlCommand checkMave = new SqlCommand("SELECT C.cnt FROM tblGiamGia  S INNER JOIN(SELECT maKH, count(maKH) as cnt FROM tblGiamGia  GROUP BY maKH) C ON S.age = C.age", con);
            con.Open();
            chec.Parameters.AddWithValue(sl);
            return sl;
        }
        */
        public DataTable getMaKhu()
        {
            string sql = "SELECT maKhu FROM tblKhuVuiChoi";
            //B2: Tạo một kết nối đến sql
            SqlConnection con = dc.getConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: MỞ kết nối - mở đường để lấy, đổ vào sqlsv
            con.Open();
            //B5: Đôẻ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }
        public DataTable getMaKH()
        {
            string sql = "SELECT maKH FROM tblKhachHang";
            //B2: Tạo một kết nối đến sql
            SqlConnection con = dc.getConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: MỞ kết nối - mở đường để lấy, đổ vào sqlsv
            con.Open();
            //B5: Đôẻ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }
        public DataTable getGiamGia()
        {
            //B1: Tạo câu lệnh Sql lấy toàn bộ sinh viên 
            string sql = "SELECT * FROM tblGiamGia";
            //B2: Tạo một kết nối đến sql
            SqlConnection con = dc.getConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: MỞ kết nối - mở đường để lấy, đổ vào sqlsv
            con.Open();
            //B5: Đôẻ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }
        public bool InsertTicKet(tblGiamGia gg)
        {
            string sql = "INSERT INTO tblGiamGia(maVe,maKH,maKhu,giaVe,ngayBan,loaiKhachHang) VALUES(@maVe,@maKH,@maKhu,@giaVe,@ngayBan,@loaiKhachHang)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maVe", SqlDbType.NVarChar, 50).Value = gg.maVe;
                cmd.Parameters.Add("@maKH", SqlDbType.NVarChar, 50).Value = gg.maKH;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 50).Value = gg.maKhu;
                cmd.Parameters.Add("@giaVe", SqlDbType.Decimal, 18).Value = gg.giaVe;
                cmd.Parameters.Add("@ngayBan", SqlDbType.DateTime).Value = gg.ngayBan;
                cmd.Parameters.Add("@loaiKhachHang", SqlDbType.VarChar, 10).Value = gg.loaiKhachHang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        int ID;
        public bool DeleteGiamGia(tblGiamGia gg)
        {
            string sql = "DELETE tblGiamGia WHERE id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = gg.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindGiamGia(string gg)
        {
            string sql = "SELECT * FROM tblGiamGia WHERE maKH LIKE '%" + gg + "%'";
            //B2: Tạo một kết nối đến sql
            SqlConnection con = dc.getConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: MỞ kết nối - mở đường để lấy, đổ vào sqlsv
            con.Open();
            //B5: Đôẻ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }
    }
}
