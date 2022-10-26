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


           
            //connection: Giao
            //conStr = "Data Source=GLAPTOPO\\SQLEXPRESS;Initial Catalog=BT_Big;Integrated Security=True";
        
            //conStr = "Data Source=DESKTOP-KFGVGP3\\SQLEXPRESS;Initial Catalog=QLKhuTroChoi;Integrated Security=True";
            // connection: Đức Anh
            //conStr = "Data Source=DESKTOP-G82NOOM;Initial Catalog=QuanLyKhuVuiChoi;Persist Security Info=True;User ID=ducanh;Password=ducanh";

             //connection: Dương
             conStr = "Data Source=DESKTOP-8A4JN2V\\DUONGPC;Initial Catalog=72DCTT21;Integrated Security=True";

        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
        
    }
}
