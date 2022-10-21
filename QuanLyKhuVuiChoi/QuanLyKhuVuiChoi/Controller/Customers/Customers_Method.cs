using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using xls = Microsoft.Office.Interop.Excel;

namespace QuanLyKhuVuiChoi.Controller.Customers
{
    internal class Customers_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd; 

        public Customers_Method()
        {
            dc = new DataConnection();
        }

        //Thư viện của DataTable - System.Data
        public DataTable getCustomers()
        {
            //B1: Tạo câu lệnh Sql lấy toàn bộ sinh viên 
            string sql = "SELECT * FROM tblKhachHang";
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

        public DataTable getGioiTinh()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("gioiTinh", typeof(String));
            DataRow row1 = dt.NewRow();
            DataRow row2 = dt.NewRow();
            row1["gioiTinh"] = "Nam";
            row2["gioiTinh"] = "Nu";
            dt.Rows.InsertAt(row1, 0);
            dt.Rows.InsertAt(row2, 0);
            return dt;
        }

        public bool InsertCustomers(tblCustomers cts)
        {
            string sql = "INSERT INTO tblKhachHang(maKH,sdt,hoTen,ngaySinh,diaChi,gioiTinh) VALUES(@maKH,@sdt,@hoTen,@ngaySinh,@diaChi,@gioiTinh)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maKH", SqlDbType.NVarChar, 50).Value = cts.maKH;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 20).Value = cts.sdt;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 100).Value = cts.hoTen;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.NVarChar,50).Value = cts.ngaySinh;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar, 200).Value = cts.diaChi;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 10).Value = cts.gioiTinh;
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
        public bool DeleteCustomers(tblCustomers cts)
        {
            string sql = "DELETE tblKhachHang WHERE id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cts.id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateCustomers(tblCustomers cts)
        {
            string sql = "Update tblKhachHang SET maKH=@maKH, sdt=@sdt, hoTen=@hoTen, ngaySinh=@ngaySinh, diaChi=@diaChi, gioiTinh=@gioiTinh WHERE id=@id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cts.id;
                cmd.Parameters.Add("@maKH", SqlDbType.NVarChar, 50).Value = cts.maKH;
                cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 20).Value = cts.sdt;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 100).Value = cts.hoTen;
                cmd.Parameters.Add("@ngaySinh", SqlDbType.NVarChar, 50).Value = cts.ngaySinh;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar, 200).Value = cts.diaChi;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 10).Value = cts.gioiTinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindCustomers(string cts)
        {
            string sql = "SELECT * FROM tblKhachHang WHERE sdt LIKE '%" + cts + "%'";
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
        public DataTable ExcelCustomers(tblCustomers cts)
        {
            string sql = "INSERT INTO tblKhachHang(maKH,sdt,hoTen,ngaySinh,diaChi,gioiTinh) VALUES(@maKH,@sdt,@hoTen,@ngaySinh,@diaChi,@gioiTinh)";
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
