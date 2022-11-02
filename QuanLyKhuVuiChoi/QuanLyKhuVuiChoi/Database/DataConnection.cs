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
            // connection: Hiền
            // conStr = "Data Source=DESKTOP-KFGVGP3\\SQLEXPRESS;Initial Catalog=QLKhuTroChoi;Integrated Security=True";

            // connection: Giao
            // conStr = "Data Source=DESKTOP-6RN79CK;Initial Catalog=QuanLyKhuVuiChoi;Integrated Security=True";

            // connection: Đức Anh
            // conStr = "Data Source=DESKTOP-G82NOOM;Initial Catalog=QuanLyKhuVuiChoi;User ID=ducanh;Password=ducanh";

            // connection: Dương
            // conStr = "data...."
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
        
    }
}
