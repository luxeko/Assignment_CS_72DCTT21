using QuanLyKhuVuiChoi.Model.Nhan_Vien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using COMExcel = Microsoft.Office.Interop.Excel;


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

        public DataTable layThongTinNhanVien(string maNV)
        {
            return nhanVienMethod.layThongTinNhanVien(maNV);
        }

        public void InExcel()
        {
            COMExcel.Application application = new COMExcel.Application();
            COMExcel.Workbook workbook;
            COMExcel.Worksheet worksheet;
            COMExcel.Range exrange;
            int hang = 0, cot = 0;
            workbook = application.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            worksheet = workbook.Worksheets[1];

            //Định dạng chung
            exrange = worksheet.Cells[1, 1];
            exrange.Range["A1:Z300"].Font.Name = "Times new roman"; // định dạng font chữ cho file excel
            exrange.Range["A1:B3"].Font.Size = 13; //định dạng cỡ chữ từ cột A1 đến B3
            exrange.Range["A1:B3"].Font.Bold = true; //định dạng chữ đậm
            exrange.Range["A1:B3"].Font.ColorIndex = 5; //định dạng màu chữ, màu xanh da trời
            exrange.Range["A1:A1"].ColumnWidth = 7; //định dạng độ rộng của ô
            exrange.Range["A1:A1"].ColumnWidth = 7; //định dạng độ rộng của ô
            exrange.Range["A1:B1"].MergeCells = true; //gộp 2 cột vào thành 1
            exrange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; //chỉnh căn lề cho chữ hiển thị
            exrange.Range["A1:B1"].Value = "Tên Khu Vui Chơi"; //đặt giá trị cho ô hiển thị

            exrange.Range["A2:B2"].MergeCells = true; //gộp 2 cột vào thành 1
            exrange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; //chỉnh căn lề cho chữ hiển thị
            exrange.Range["A2:B2"].Value = "Địa chỉ khu vui chơi"; //đặt giá trị cho ô hiển thị

            exrange.Range["A3:B3"].MergeCells = true;
            exrange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; //chỉnh căn lề cho chữ hiển thị
            exrange.Range["A3:B3"].Value = "SĐT khu vui chơi"; //đặt giá trị cho ô hiển thị

            exrange.Range["D2:F2"].Font.Size = 18;
            exrange.Range["D2:F2"].Font.Bold = true;
            exrange.Range["D2:F2"].Font.ColorIndex = 3; //màu đỏ
            exrange.Range["D2:F2"].MergeCells = true;
            exrange.Range["D2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exrange.Range["D2:F2"].Value = "THÔNG TIN NHÂN VIÊN";

            string sql = "select maNV,hoTen,avatarSrc,ngaySinh,maKhu,soDT,diachi,case when gioiTinh='1' then N'Nữ' when gioiTinh='0' then 'Nam'end as gioiTinh,chucVu,luong from tblNhanVien";
            DataTable data = app_config.GetDataTable(sql); 
            //tạo dòng tiêu đề
            exrange.Range["A6:K6"].Font.Bold = true;
            exrange.Range["A6:K6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exrange.Range["A6:K6"].ColumnWidth = 12;
            exrange.Range["A6:A6"].Value = "STT";
            exrange.Range["B6:B6"].Value = "Mã nhân viên";
            exrange.Range["C6:C6"].Value = "Họ Tên";
            exrange.Range["D6:D6"].Value = "Ảnh";
            exrange.Range["E6:E6"].Value = "Ngày sinh";
            exrange.Range["E6:E6"].ColumnWidth = 18;
            exrange.Range["F6:F6"].Value = "Mã Khu";
            exrange.Range["G6:G6"].Value = "Số điện thoại";
            exrange.Range["H6:H6"].Value = "Địa chỉ";
            exrange.Range["I6:I6"].Value = "Giới tính";
            exrange.Range["J6:J6"].Value = "Chức vụ";
            exrange.Range["K6:K6"].Value = "Lương";

            for (hang = 0; hang < data.Rows.Count; hang++)
            {
                worksheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot < data.Columns.Count; cot++)
                {   //điền thông tin nhân viên lấy từ CSDL bắt đầu từ cột thứ 2 dòng 7
                    worksheet.Cells[cot + 2][hang + 7] = data.Rows[hang][cot].ToString();
                }
            }
            worksheet.Name = "Thông tin nhân viên";
            application.Visible = true;
        }
    }
}
