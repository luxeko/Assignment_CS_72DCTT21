using QuanLyKhuVuiChoi.Model.Ticketss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Gọi các hàm bên Tickets_Method

namespace QuanLyKhuVuiChoi.Controller.Tickets
{
    internal class Ticketss_Controller
    {
        Ticketss_Method Ticketss_Method;
        public Ticketss_Controller()
        {
            Ticketss_Method = new Ticketss_Method();
        }
        public DataTable getTickets()
        {
            return Ticketss_Method.getTickets();
        }
        public DataTable getMaKhu()
        {
            return Ticketss_Method.getMaKhu();
        }
        public DataTable getLoaiKH()
        {
            return Ticketss_Method.getLoaiKH();
        }
        public bool InsertTicKet(tblTicketss tk)
        {
            return Ticketss_Method.InsertTicKet(tk);
        }
        public bool DeleteTickets(tblTicketss tk)
        {
            return Ticketss_Method.DeleteTickets(tk);
        }
        public DataTable FindTickets(string tk)
        {
            return Ticketss_Method.FindTickets(tk);
        }
        public bool checkMave(string mv)
        {
            return Ticketss_Method.checkMave(mv);
        }
    }
}
