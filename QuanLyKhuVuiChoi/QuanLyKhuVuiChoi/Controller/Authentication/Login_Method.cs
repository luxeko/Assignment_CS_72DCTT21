using QuanLyKhuVuiChoi.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace QuanLyKhuVuiChoi.Controller.Authentication
{
    class Login_Method
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public Login_Method()
        {
            dc = new DataConnection();
        }

        public DataTable login(string userName, string passWord)
        {
            string sql = "SELECT * FROM tblUser WHERE username = '" + userName + "' AND password = '" + passWord + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(sql, con);
                con.Open();
                da.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
