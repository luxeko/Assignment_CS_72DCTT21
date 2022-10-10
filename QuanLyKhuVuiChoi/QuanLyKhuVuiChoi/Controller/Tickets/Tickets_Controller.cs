using QuanLyKhuVuiChoi.Model.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Gọi các hàm bên Tickets_Method

namespace QuanLyKhuVuiChoi.Controller.Tickets
{
    class Tickets_Controller
    {
        Tickets_Method Tickets_Method;
        public Tickets_Controller()
        {
            Tickets_Method = new Tickets_Method();
        }
        public DataTable getTickets()
        {
            return Tickets_Method.getTickets();
        }
        public DataTable getMaKhu()
        {
            return Tickets_Method.getMaKhu();
        }
        public DataTable getLoaiKH()
        {
            return Tickets_Method.getLoaiKH();
        }
        public bool InsertTicKet(tbTickets tk)
        {
            return Tickets_Method.InsertTicKet(tk);
        }
        public bool DeleteTickets(tbTickets tk)
        {
            return Tickets_Method.DeleteTickets(tk);
        }
        public DataTable FindTickets(string tk)
        {
            return Tickets_Method.FindTickets(tk);
        }
        public bool checkMave(string mv)
        {
            return Tickets_Method.checkMave(mv);
        }
        }
}
