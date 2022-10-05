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

        public string email { get; set; }

        public string password { get; set; }

        public bool status { get; set; }
    }
}
