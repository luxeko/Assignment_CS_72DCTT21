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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
            string query = "select *, tblNhanVien.hoTen from tblUser, tblNhanVien where username = '" + userName + "' AND password = '" + passWord + "' and tblUser.maNV = tblNhanVien.maNV";
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
                        "from tblUser, tblNhanVien " +
                        "where tblUser.username = '" + userName +
                        "' and tblUser.email = '" + email +
                        "' and tblNhanVien.maNV = '" + maNV +
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
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi truy vấn sql", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool UpdatePassword(int id, string username, string email, string maNV, string password)
        {
            string query = "update tblUser set password = @password where id = @id and username = @username and email = @email and maNV = @maNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = maNV;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool CheckPassword(string password, int id)
        {
            string query = "select count(*) from tblUser where id = @id and password = @password";
            SqlConnection con = dc.getConnect();

            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                return true;

            }
            con.Close();
            return false;
        }

        public bool UpdateProfile(string maNV, string hoTen, string gioiTinh, string ngaySinh, string soDT, string diaChi)
        {



            return false;
        }
    }
}
