using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Database
{
    class DataConnection
    {
        string conStr;

        public DataConnection()
        {
            conStr = "Data Source=DESKTOP-G82NOOM;Initial Catalog=QuanLyKhuVuiChoi;User ID=ducanh;Password=ducanh";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
        
    }
}
