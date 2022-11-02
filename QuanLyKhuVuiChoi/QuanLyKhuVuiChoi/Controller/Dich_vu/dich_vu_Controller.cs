using QuanLyKhuVuiChoi.Model.Dich_Vu;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyKhuVuiChoi.Controller.Dich_vu
{
    internal class dich_vu_Controller
    {
        dich_vu_Method dich_vu_Method;
        public dich_vu_Controller()
        {
            dich_vu_Method = new dich_vu_Method();
        }
        public DataTable get_DV()
        {
            return dich_vu_Method.getDV();
        }
        public DataTable get_makhu()
        {
            return dich_vu_Method.get_makhu();
        }
        public bool tao_moi_DV(tbl_dich_vu dv)
        {
            return dich_vu_Method.tao_moi_DV(dv);
        }
        public bool cap_nhat_DV(tbl_dich_vu dv)
        {
            return dich_vu_Method.cap_nhat_DV(dv);
        }
        public bool xoa_DV(tbl_dich_vu dv)
        {
            return dich_vu_Method.xoa_DV(dv);
        }
        public DataTable tim_DV(string dv)
        {
            return dich_vu_Method.tim_DV(dv);
        }
    }
}

