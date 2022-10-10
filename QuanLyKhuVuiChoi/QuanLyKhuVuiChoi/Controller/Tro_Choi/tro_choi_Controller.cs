using QuanLyKhuVuiChoi.Model.Tro_Choi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.Tro_Choi
{
    internal class tro_choi_controller
    {
        tro_choi_Method tro_choi_Method;
        public tro_choi_controller()
        {
            tro_choi_Method = new tro_choi_Method();
        }
        public DataTable get_TC()
        {
            return tro_choi_Method.get_TC();
        }
        public DataTable get_makhu()
        {
            return tro_choi_Method.get_makhu();
        }
        public bool tao_moi_TC(tbl_tro_choi tc)
        {
            return tro_choi_Method.tao_moi_TC(tc);
        }
        public bool cap_nhat_TC(tbl_tro_choi tc)
        {
            return tro_choi_Method.cap_nhat_TC(tc);
        }
        public bool xoa_TC(tbl_tro_choi tc)
        {
            return tro_choi_Method.xoa_TC(tc);
        }
        public DataTable tim_TC(string tc)
        {
            return tro_choi_Method.tim_TC(tc);
        }
    }
}
