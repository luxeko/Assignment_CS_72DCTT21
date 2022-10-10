using QuanLyKhuVuiChoi.Model.Khu_Vui_Choi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.Khu_Vui_Choi
{
    class khu_vui_choi_Controller
    {
        khu_vui_choi_Method khu_vui_choi_Method;
        public khu_vui_choi_Controller()
        {
            khu_vui_choi_Method = new khu_vui_choi_Method();
        }

        public DataTable get_KVC()
        {
            return khu_vui_choi_Method.get_KVC();
        }
        public bool tao_moi_KVC(tbl_khu_vui_choi kvc)
        {
            return khu_vui_choi_Method.tao_moi_KVC(kvc);
        }
        public bool cap_nhat_KVC(tbl_khu_vui_choi kvc)
        {
            return khu_vui_choi_Method.cap_nhat_KVC(kvc);
        }
        public bool xoa_KVC(tbl_khu_vui_choi kvc)
        {
            return khu_vui_choi_Method.xoa_KVC(kvc);
        }
        public DataTable tim_KVC(string kvc)
        {
            return khu_vui_choi_Method.tim_KVC(kvc);
        }

    }
}
