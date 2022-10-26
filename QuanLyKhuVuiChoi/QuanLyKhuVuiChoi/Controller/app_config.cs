using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhuVuiChoi.Database;

namespace QuanLyKhuVuiChoi.Controller
{
    class app_config
    {
        static DataConnection connection;
        public app_config()
        {
            connection = new DataConnection();
        }
        public static DataTable GetDataTable(String sql)
        {
            SqlConnection connect = connection.getConnect();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql,connect);
            adapter.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        } 
        public DataTable selectSql(String sql)
        {
            SqlConnection connect = connection.getConnect();
            SqlCommand command = new SqlCommand(sql, connect);
            DataTable table = new DataTable();
            try
            {
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader, LoadOption.OverwriteChanges);
                if (table.Rows == null)
                    return null;
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
            return table;
        }
        public int insertSql(String sql)
        {
            SqlConnection connect = connection.getConnect();
            SqlCommand command = new SqlCommand(sql,connect);
            int i = -1;
            try
            {
                connect.Open();
                i = command.ExecuteNonQuery();
            }
            catch
            {
                i = -1;
            }
            finally
            {
                connect.Close();
            }
            return i;
        }
        public int updateSql(String sql)
        {
            SqlConnection connect = connection.getConnect();
            SqlCommand command = new SqlCommand(sql, connect);
            int i = -1;
            try
            {
                connect.Open();
                i = command.ExecuteNonQuery();
            }
            catch
            {
                i = -1;
            }
            finally
            {
                connect.Close();
            }
            return i;
        }
        public int deleteSql(String sql)
        {
            SqlConnection connect = connection.getConnect();
            SqlCommand command = new SqlCommand(sql, connect);
            int i = -1;
            try
            {
                connect.Open();
                i = command.ExecuteNonQuery();
            }
            catch
            {
                i = -1;
            }
            finally
            {
                connect.Close();
            }
            return i;
        }
    }
}
