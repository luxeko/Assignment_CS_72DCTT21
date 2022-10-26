using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Model.Ticketss
{
    internal class tblTicketss
    {
        public int id { get; set; }
        public string maVe { get; set; }
        public string maKhu { get; set; }
        public string loaiKhachHang { get; set; }
        public decimal giaVe { get; set; }
        public DateTime ngayBan { get; set; }
    }
}
