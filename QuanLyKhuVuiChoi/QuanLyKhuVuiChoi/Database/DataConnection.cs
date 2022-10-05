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
            // connection: Đức Anh
            // conStr = "Data Source=DESKTOP-G82NOOM;Initial Catalog=72DCTT21;User ID=ducanh;Password=ducanh";

            // connection: Dương
            //conStr = "data...."
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
