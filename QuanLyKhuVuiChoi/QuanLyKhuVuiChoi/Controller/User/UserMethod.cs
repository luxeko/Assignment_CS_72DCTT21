using Microsoft.VisualBasic.ApplicationServices;
using QuanLyKhuVuiChoi.Database;
using QuanLyKhuVuiChoi.Model.User;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public DataTable chekUserName(string username)
        {
            string query = "select * from tblUser where username = '" + username + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
                return dt;
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi check username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }
        public DataTable checkEmail(string email)
        {
            string query = "select * from tblUser where email = '" + email + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi check Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }
        public bool create(tblUser user)
        {
            string query = "insert into tblUser (username, password, trangThai, email, created_at, updated_at) values (@username, @password, @trangThai, @email, @created_at, @updated_at)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = user.username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = user.password;
                cmd.Parameters.Add("@trangThai", SqlDbType.VarChar, 10).Value = user.trangThai;
                //cmd.Parameters.Add("@maNV", SqlDbType.NVarChar, 50).Value = user.maNV;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = user.email;
                cmd.Parameters.Add("@created_at", SqlDbType.DateTime).Value = user.created_at;
                cmd.Parameters.Add("@updated_at", SqlDbType.DateTime).Value = user.updated_at;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool delete(int id)
        {
            string query = "delete tblUser where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable checkUserNameAfterUpdate(int id, string username)
        {
            string query = "select * from tblUser where username = '" + username + "' and id != '" + id + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi check username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable checkEmailAfterUpdate(int id, string email)
        {
            string query = "select * from tblUser where username = '" + email + "' and id != '" + id + "'";
            SqlConnection con = dc.getConnect();
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi check username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool update(int id, tblUser user)
        {
            string query = "update tblUser set username = @username, password = @password, trangThai = @trangThai, email = @email, updated_at = @updated_at where id = @id";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = user.username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = user.password;
                cmd.Parameters.Add("@trangThai", SqlDbType.VarChar, 10).Value = user.trangThai;
                //cmd.Parameters.Add("@maNV", SqlDbType.NVarChar, 50).Value = user.maNV;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = user.email;
                cmd.Parameters.Add("@updated_at", SqlDbType.DateTime).Value = user.updated_at;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable search (string keyword)
        {
            string query = "select * FROM tblUser WHERE username LIKE '%" + keyword + "%' OR email LIKE '%" + keyword + "%' OR trangThai LIKE '%" + keyword + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable orderByASC(string value)
        {
            string query = "select * from tblUser order by " + value +" ASC ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable orderByDESC(string value)
        {
            string query = "select * from tblUser order by " + value + " DESC ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
