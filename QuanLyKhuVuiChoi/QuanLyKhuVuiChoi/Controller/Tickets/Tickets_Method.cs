using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi.Controller.Tickets
{
    class Tickets_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd; // Thêm sửa xóa được

        public Tickets_Method()
        {
            dc = new DataConnection();
        }

        public DataTable getLoaiKH()
        {
           DataTable dt = new DataTable();
            dt.Columns.Add("loaiKhachHang", typeof(String));
            DataRow row1 = dt.NewRow();
            DataRow row2 = dt.NewRow();
            row1["loaiKhachHang"] = "0";
            row2["loaiKhachHang"] = "1";
            dt.Rows.InsertAt(row1, 0);
            dt.Rows.InsertAt(row2, 0);
            return dt;
        }
        
        public bool checkMave(string mv)
        {

            SqlConnection con = dc.getConnect();
            SqlCommand checkMave = new SqlCommand("SELECT COUNT(maVe) FROM tblVe WHERE ([maVe] = @maVe)", con);
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


        //Thư viện của DataTable - System.Data
        public DataTable getTickets()
        {
            //B1: Tạo câu lệnh Sql lấy toàn bộ sinh viên 
            string sql = "SELECT * FROM tblVe";
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


        public bool InsertTicKet(tbTickets tk)
        {
            string sql = "INSERT INTO tblVe(maVe,maKhu,giaVe,ngayBan,loaiKhachHang) VALUES(@maVe,@maKhu,@giaVe,@ngayBan,@loaiKhachHang)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maVe", SqlDbType.NVarChar, 50).Value = tk.maVe;
                cmd.Parameters.Add("@maKhu", SqlDbType.NVarChar, 50).Value = tk.maKhu;
                cmd.Parameters.Add("@giaVe", SqlDbType.Decimal,18).Value = tk.giaVe;
                cmd.Parameters.Add("@ngayBan", SqlDbType.DateTime).Value = tk.ngayBan;
                cmd.Parameters.Add("@loaiKhachHang", SqlDbType.NVarChar,10).Value = tk.loaiKhachHang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        int ID;
        public bool DeleteTickets(tbTickets tk)
        {
            string sql = "DELETE tblVe WHERE id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tk.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindTickets(string tk)
        {
            string sql = "SELECT * FROM tblVe WHERE maKhu LIKE '%" + tk + "%' OR ngayBan LIKE '%" + tk + "%' OR loaiKhachHang LIKE '%" + tk + "%'";
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
