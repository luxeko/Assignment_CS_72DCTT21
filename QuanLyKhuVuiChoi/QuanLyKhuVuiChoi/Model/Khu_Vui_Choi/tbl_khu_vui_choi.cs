using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi.Model.Khu_Vui_Choi
{
    internal class tbl_khu_vui_choi
    {
        public int id { get; set; }
        public string maKhu { get; set; }
        public string tenKhu { get; set; }
        public string viTri { get; set; }
        public string dienTich { get; set; }
        public string gioMo { get; set; }
        public string gioDong { get; set; }
        public decimal giaNL { get; set; }
        public decimal giaTE { get; set; }

    }
}
