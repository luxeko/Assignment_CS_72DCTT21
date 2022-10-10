using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.User
{
    class UserController
    {
        UserMethod userMethod;

        public UserController()
        {
            userMethod = new UserMethod();
        }

        public DataTable getUser()
        {
            return userMethod.getUser();
        }
    }
}
