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
            string query = "SELECT * FROM tblUser WHERE username = '" + userName + "' AND password = '" + passWord + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
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
       
        public DataTable CheckAccount(string userName, string email, string cccd, string maNV)
        {
            string query = "select tblUser.id, " +
                        "tblUser.email, " +
                        "tblUser.username, " +
                        "tblNhanVien.maNV, " +
                        "tblNhanVien.hoTen " +
                        "from tblUser, tblNhanVien" +
                        "where username = '" + userName + 
                        "' and email = '" + email + 
                        "' and maNV = '" + maNV +
                        "' and tblUser.maNV = tblNhanVien.maNV and trangThai = ' Active'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
                return dt;
            } 
            catch(Exception)
            {
                MessageBox.Show("Lỗi khi truy vấn sql", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool UpdatePassword(string username, string email, tblUser user)
        {
            string query = "update tblUser set password = @password where id = @id, username = @username, email = @email";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = user.id;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = user.username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = user.password;
                cmd.Parameters.Add("@trangThai", SqlDbType.VarChar, 10).Value = user.trangThai;
                //cmd.Parameters.Add("@maNV", SqlDbType.NVarChar, 50).Value = user.maNV;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = user.email;
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
