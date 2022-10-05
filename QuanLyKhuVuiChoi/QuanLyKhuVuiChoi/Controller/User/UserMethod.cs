using Microsoft.VisualBasic.ApplicationServices;
using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.User
{
    class UserMethod
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public UserMethod ()
        {
            dc = new DataConnection();
        }

        public DataTable getUser()
        {
            // b1: Tạo câu lệnh lấy toàn bộ dữ liệu điểm
            string sql = "select * from tblUser";
            // b2: Tạo kết nối đến Sql
            SqlConnection con = dc.getConnect();
            // b3: Khởi tạo đối tượng của lớp DataAdapter
            da = new SqlDataAdapter(sql, con);
            // b4: Mở kết nối
            con.Open();
            // b5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // b6: Đóng kết nối
            con.Close();
            return dt;
        }

        public bool create(tblUser user)
        {
            string sql = "insert into tblUser(email, passworđ, status) values(@email, @passworđ, @status)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = user.email;
                cmd.Parameters.Add("@passworđ", SqlDbType.NVarChar).Value = user.password;
                cmd.Parameters.Add("@status", SqlDbType.Decimal).Value = user.status;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
