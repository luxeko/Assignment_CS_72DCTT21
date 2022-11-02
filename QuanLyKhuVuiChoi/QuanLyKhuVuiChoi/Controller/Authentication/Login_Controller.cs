using QuanLyKhuVuiChoi.Model.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.Authentication
{
    class Login_Controller
    {
        Login_Method loginMethod;

        public Login_Controller()
        {
            loginMethod = new Login_Method();
        }

        public DataTable login(string userName, string passWord)
        {
            return loginMethod.login(userName, passWord);
        }

        public DataTable CheckAccount(string userName, string email, string cccd, string maNV)
        {
            return loginMethod.CheckAccount(userName, email, cccd, maNV);
        }

        public bool UpdatePassword(int id, string username, string email, string maNV, string password)
        {
            return loginMethod.UpdatePassword(id, username, email, maNV, password);
        }

        public bool CheckPassword(string password, int id)
        {
            return loginMethod.CheckPassword(password, id);
        }

        public bool UpdateProfile(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string soDT, string diaChi)
        {
            return loginMethod.UpdateProfile(maNV, hoTen, gioiTinh, ngaySinh, soDT, diaChi);
        }
    }
}
