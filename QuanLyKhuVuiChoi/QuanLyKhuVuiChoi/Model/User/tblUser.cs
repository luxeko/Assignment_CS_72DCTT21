using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Model.User
{
    class tblUser
    {
        public int id { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string trangThai { get; set; }

        public string maNV { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }
    }
}
