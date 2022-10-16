using QuanLyKhuVuiChoi.Model.Nhan_Vien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi.Controller.Nhan_vien
{
    internal class NhanVienController
    {
        NhanVienMethod nhanVienMethod;
        public NhanVienController()
        {
            nhanVienMethod = new NhanVienMethod();
        }

        public DataTable DanhSachNV()
        {
            return nhanVienMethod.GetNV();
        }

        public int Them_moi_NV(tbl_nhanvien nhanvien)
        {
            return nhanVienMethod.ThemNV(nhanvien);
        }

        public int Sua_NV(tbl_nhanvien nhanvien)
        {
            return nhanVienMethod.SuaNV(nhanvien);
        }

        public int Xoa_NV(string maNV)
        {
            return nhanVienMethod.XoaNV(maNV);
        }

        public DataTable Tim_Kiem_NV(string hoten)
        {
            return nhanVienMethod.TimKiemNV(hoten);
        }
    }
}
