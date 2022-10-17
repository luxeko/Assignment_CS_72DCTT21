using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Model.Giam_Gia
{
    internal class tblGiamGia
    {       
        public int id { get; set; }
        public string maVe { get; set; }
        public string maKH { get; set; }
        public string maKhu { get; set; }
        public Decimal giaVe { get; set; }
        public DateTime ngayBan { get; set; }
        public string loaiKhachHang { get; set; }
    }
}
