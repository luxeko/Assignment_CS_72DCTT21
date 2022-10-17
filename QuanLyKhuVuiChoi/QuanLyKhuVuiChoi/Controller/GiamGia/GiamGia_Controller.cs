using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhuVuiChoi.Model.Giam_Gia;

namespace QuanLyKhuVuiChoi.Controller.GiamGia
{
    internal class GiamGia_Controller
    {
        GiamGia_Method GiamGia_Method;
        public GiamGia_Controller()
        {
            GiamGia_Method = new GiamGia_Method();
        }
        public DataTable getMaKH()
        {
            return GiamGia_Method.getMaKH();
        }

        public DataTable getLoaiKH()
        {
            return GiamGia_Method.getLoaiKH();
        }
        public bool checkMave(string mv)
        {
            return GiamGia_Method.checkMave(mv);
        }
        public DataTable getMaKhu()
        {
            return GiamGia_Method.getMaKhu();
        }
        public DataTable getGiamGia()
        {
            return GiamGia_Method.getGiamGia();
        }
        public bool InsertTicKet(tblGiamGia gg)
        {
            return GiamGia_Method.InsertTicKet(gg);
        }
        public bool DeleteGiamGia(tblGiamGia gg)
        {
            return GiamGia_Method.DeleteGiamGia(gg);
        }
        public DataTable FindGiamGia(string gg)
        {
            return GiamGia_Method.FindGiamGia(gg);
        }
        /*public DataTable checkSoluong()
        {
            return GiamGia_Method.checkSoluong();
        }
        */
    }
}
