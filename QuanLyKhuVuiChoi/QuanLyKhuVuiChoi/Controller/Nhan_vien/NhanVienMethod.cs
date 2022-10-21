using btl2;
using QuanLyKhuVuiChoi.Model.Nhan_Vien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace QuanLyKhuVuiChoi.Controller.Nhan_vien
{
    internal class NhanVienMethod
    {
        app_config config = new app_config();
        
        public DataTable GetNV()
        {
            DataTable table = new DataTable();
            string sql = "select id,maNV,hoTen,avatarSrc,ngaySinh,maKhu,soDT,diachi,case when gioiTinh='1' then N'Nữ' when gioiTinh='0' then 'Nam'end as gioiTinh,chucVu,luong from tblNhanVien";
            table = app_config.GetDataTable(sql);
            return table;
        }

        public int ThemNV(tbl_nhanvien nhanvien)
        {
            string sql = "insert into tblNhanVien (maNV,hoTen,avatarSrc,ngaySinh,maKhu,soDT,diachi,gioiTinh,chucVu,luong)" +
                " values('"+nhanvien.maNV+"',N'" + nhanvien.hoTen+ "','" + nhanvien.anhNV+ "','" + nhanvien.ngaySinh+"'" +
                ",'"+nhanvien.maKhu+"','"+nhanvien.soDT+"',N'"+nhanvien.diaChi+"','"+nhanvien.gioiTinh+"'" +
                ",N'"+nhanvien.chucVu+"','"+nhanvien.Luong+"')";
            int sosanh = config.insertSql(sql);
            if (sosanh == 0)
            {
                MessageBox.Show("Thêm mới không thành công");
            }
            else if (sosanh == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL");
            }
            else
            {
                MessageBox.Show("Thêm mới thành công");
            }
            return sosanh;
        }
        public int SuaNV(tbl_nhanvien nhanvien)
        {
            string sql = "Update tblNhanVien set avatarSrc='" + nhanvien.anhNV+ "' , hoTen= N'" + nhanvien.hoTen+ "' , ngaySinh= '" + nhanvien.ngaySinh+ "'," +
                "maKhu= '" + nhanvien.maKhu+ "',soDT= '"+nhanvien.soDT+ "',diachi= N'" + nhanvien.diaChi+ "',gioiTinh= '" + nhanvien.gioiTinh+ "'" +
                ",chucVu= N'" + nhanvien.chucVu+ "',luong='" + nhanvien.Luong+ "' where maNV = '"+nhanvien.maNV+ "'";
            int sosanh = config.updateSql(sql);
            if (sosanh == 0)
            {
                MessageBox.Show("Sửa không thành công");
            }
            else if (sosanh == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
            }
            return sosanh;
        }

        public int XoaNV(string  maNV)
        {
            string sql = "Delete from tblNhanVien where maNV = '" + maNV + "'";
            int sosanh = config.deleteSql(sql);
            if (sosanh == 0)
            {
                MessageBox.Show("Xóa không thành công");
            }
            else if (sosanh == -1)
            {
                MessageBox.Show("Lỗi kết nối CSDL");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
            }
            return sosanh;
        }

        public DataTable TimKiemNV(string hoten)
        {
            DataTable tableTK = new DataTable();
            string sql = "select * from tblNhanVien where hoTen like N'%" + hoten+"%' ";
            tableTK = app_config.GetDataTable(sql);
            return tableTK;
        }

        
    }
}
