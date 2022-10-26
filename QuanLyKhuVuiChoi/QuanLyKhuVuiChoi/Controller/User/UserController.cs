using QuanLyKhuVuiChoi.Model.User;
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

        public bool create(tblUser user)
        {
            return userMethod.create(user);
        }

        public bool delete(int id)
        {
            return userMethod.delete(id);
        }

        public bool update(int id, tblUser user)
        {
            return userMethod.update(id, user);
        }

        public DataTable checkUserName(string username)
        {
            return userMethod.chekUserName(username);
        }

        public DataTable checkEmail(string email)
        {
            return userMethod.checkEmail(email);
        }

        public DataTable checkUserNameAfterUpdate(int id, string username)
        {
            return userMethod.checkUserNameAfterUpdate(id, username);
        }

        public DataTable checkEmailAfterUpdate(int id, string email)
        {
            return userMethod.checkEmailAfterUpdate(id, email);
        }

        public DataTable search(string keyword)
        {
            return userMethod.search(keyword);
        }

        public DataTable orderByASC(string value)
        {
            return userMethod.orderByASC(value);
        } 
        
        public DataTable orderByDESC(string value)
        {
            return userMethod.orderByDESC(value);
        }
    }
}
