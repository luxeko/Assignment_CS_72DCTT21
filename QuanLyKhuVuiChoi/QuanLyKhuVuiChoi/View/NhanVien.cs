using QuanLyKhuVuiChoi.Controller.Nhan_vien;
using QuanLyKhuVuiChoi.Model.Nhan_Vien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace btl2
{
    public partial class NhanVien : Form
    {
        NhanVienController controller = new NhanVienController(); //khởi tạo đối tượng controller để thực hiện
        // tương tác giữa form Nhân viên và cơ sở dữ liệu
        string urlAnh = "";
        bool checkLuu = false;
        public NhanVien()
        {
            InitializeComponent();
            TrangThaiButton(false);
        }
        public void showDataGridView()
        {   //tạo các cột dữ liệu trong bảng dataGridView, để hiển thị thông tin về nhân viên khi đọc dữ liệu từ 
            //cơ sở dữ liệu
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "id";
            column.HeaderText = "ID";
            NVdataGrid.Columns.Add(column);
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "avatarSrc";
            column1.HeaderText = "Ảnh nhân viên";
            NVdataGrid.Columns.Add(column1); 
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "maNV";
            column2.HeaderText = "Mã nhân viên";
            NVdataGrid.Columns.Add(column2); 
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "hoTen";
            column3.HeaderText = "Họ và tên";
            NVdataGrid.Columns.Add(column3); 
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "ngaySinh";
            column4.HeaderText = "Ngày sinh";
            NVdataGrid.Columns.Add(column4); 
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "maKhu";
            column5.HeaderText = "Mã khu";
            NVdataGrid.Columns.Add(column5); 
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "soDT";
            column6.HeaderText = "Số điện thoại";
            NVdataGrid.Columns.Add(column6); 
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.DataPropertyName = "diaChi";
            column7.HeaderText = "Địa chỉ";
            NVdataGrid.Columns.Add(column7); 
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.DataPropertyName = "gioiTinh";
            column8.HeaderText = "Giới tính";
            NVdataGrid.Columns.Add(column8); 
            DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
            column9.DataPropertyName = "chucVu";
            column9.HeaderText = "Chức vụ";
            NVdataGrid.Columns.Add(column9); 
            DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
            column10.DataPropertyName = "Luong";
            column10.HeaderText = "Lương";
            NVdataGrid.Columns.Add(column10);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setImageError()
        {
            //đặt trạng thái ban đầu để ẩn đi icon thông báo lỗi của các textbox
            iconMaNV.Visible = false;
            iconHoten.Visible = false;
            iconMakhu.Visible = false;
            iconChucvu.Visible = false;
            iconSDT.Visible = false;
            iconDC.Visible = false;
            iconLuong.Visible = false;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            setImageError(); //gọi hàm set trạng thái để mỗi khi load form sẽ đặt lại trạng thái của các icon
            DataTable data = new DataTable();
            data = controller.DanhSachNV(); //đọc dữ liệu danh sách nhân viên từ cơ sở dữ liệu
            if (data.Rows.Count == 0) //kiểm tra nếu dữ liệu không đọc được dòng nào thì
            {
                NVdataGrid.DataSource = null; //xóa data cũ trong dataGridView
                showDataGridView(); //gọi hàm tạo cột hiển thị cho dataGridView
                NVdataGrid.DataSource = data; //thêm dữ liệu đọc được vào trong dataGridView
            }
            else NVdataGrid.DataSource = data; //nếu đã có dữ liệu sẵn thì thêm luôn phần dữ liệu đọc được
            // vào dataGridView không cần gọi hàm tạo cột hiển thị
        }

        private void pictureAnh_Click(object sender, EventArgs e)
        {   //mở cửa sổ chọn ảnh
            OpenFileDialog open = new OpenFileDialog();
            //định dạng file có thể nhận được để hiển thị ảnh lên picturebox
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureAnh.Image = new Bitmap(open.FileName); //hiển thị ảnh qua tên file ảnh được chọn
                urlAnh = open.FileName;
            }
        }

        private void NVdataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   //khi click vào 1 dòng trong dataGridView thì gán giá trị của các cột trong dòng đó tương ứng với
            //các textbox
            TxtMaNV.Text = NVdataGrid.CurrentRow.Cells[1].Value.ToString(); //currentRow: hàng đang click
            TxtHoTen.Text = NVdataGrid.CurrentRow.Cells[2].Value.ToString();
            if(NVdataGrid.CurrentRow.Cells[3].Value.ToString() != "")
            {
                urlAnh = NVdataGrid.CurrentRow.Cells[3].Value.ToString();
                pictureAnh.Image = new Bitmap(NVdataGrid.CurrentRow.Cells[3].Value.ToString());
            }
            Ngay_Sinh.Text = NVdataGrid.CurrentRow.Cells[4].Value.ToString();
            TxtMaKhu.Text = NVdataGrid.CurrentRow.Cells[5].Value.ToString();
            TxtSDT.Text = NVdataGrid.CurrentRow.Cells[6].Value.ToString();
            TxtDC.Text = NVdataGrid.CurrentRow.Cells[7].Value.ToString();
            CbGioiTinh.Text = NVdataGrid.CurrentRow.Cells[8].Value.ToString();
            TxtChucVu.Text = NVdataGrid.CurrentRow.Cells[9].Value.ToString();
        }

        public void clearText()
        {
            TxtChucVu.Text = "";
            TxtDC.Text = "";
            TxtHoTen.Text = "";
            TxtMaKhu.Text = "";
            TxtMaNV.Text = "";
            TxtSDT.Text = "";
            CbGioiTinh.Text = "";
            pictureAnh.Image = null;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (TxtTimKiem.Text == "")
            {
                MessageBox.Show("Nhập tên nhân viên để tìm kiếm");
            }
            else
            {
                controller.Tim_Kiem_NV(TxtTimKiem.Text);
                NhanVien_Load(sender, e);
            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            checkLuu = true;
            TrangThaiButton(true);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            checkLuu = false;
            TrangThaiButton(true);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (TxtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controller.Xoa_NV(TxtMaNV.Text);
                    NhanVien_Load(sender, e);
                    clearText();
                }
            }
        }

        private void NVdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(checkLuu == true)
            {
                if (TxtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên");
                    iconMaNV.Visible = true;
                }
                else if (TxtHoTen.Text == "")
                {
                    MessageBox.Show("Chưa nhập họ tên");
                    iconHoten.Visible = true;
                }
                else if (TxtMaKhu.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã khu");
                    iconMakhu.Visible = true;
                }
                else if (TxtChucVu.Text == "")
                {
                    MessageBox.Show("Chưa nhập chức vụ");
                    iconChucvu.Visible = true;
                }
                else if (TxtDC.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    iconDC.Visible = true;
                }
                else if (TxtSDT.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    iconSDT.Visible = true;
                }else if (TxtLuong.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương cơ bản cho nhân viên");
                    iconLuong.Visible = true;
                }
                else
                {
                    setImageError();
                    tbl_nhanvien nhanvien = new tbl_nhanvien(); //khởi tạo một đối tượng nhân viên
                                                                //gán giá trị cho các thuộc tính của đối tượng
                    nhanvien.id = 0;
                    if (urlAnh != "")
                    {
                        nhanvien.anhNV = urlAnh;
                    }
                    else
                    {
                        nhanvien.anhNV = "";
                    }
                    nhanvien.maNV = TxtMaNV.Text;
                    nhanvien.hoTen = TxtHoTen.Text;
                    nhanvien.maKhu = TxtMaKhu.Text;
                    nhanvien.ngaySinh = Ngay_Sinh.Text;
                    nhanvien.soDT = TxtSDT.Text;
                    nhanvien.diaChi = TxtDC.Text;
                    if (CbGioiTinh.Text.Equals("Nữ"))
                    {
                        nhanvien.gioiTinh = 1;
                    }
                    else
                    {
                        nhanvien.gioiTinh = 0;
                    }
                    nhanvien.chucVu = TxtChucVu.Text;
                    nhanvien.Luong = int.Parse(TxtLuong.Text);
                    controller.Them_moi_NV(nhanvien); //gọi hàm thêm mới để thực hiện thêm nv vào cơ sở dữ liệu
                    NhanVien_Load(sender, e); // thực hiện load lại form sau khi thêm để cập nhật dữ liệu trên dataGridView
                    clearText();
                    TrangThaiButton(false);
                }
            }
            else {
                if (TxtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa chọn nhân viên cần sửa");
                    iconMaNV.Visible = true;
                }
                else if (TxtHoTen.Text == "")
                {
                    MessageBox.Show("Chưa nhập họ tên");
                    iconHoten.Visible = true;
                }
                else if (TxtMaKhu.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã khu");
                    iconMakhu.Visible = true;
                }
                else if (TxtChucVu.Text == "")
                {
                    MessageBox.Show("Chưa nhập chức vụ");
                    iconChucvu.Visible = true;
                }
                else if (TxtDC.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    iconDC.Visible = true;
                }
                else if (TxtSDT.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    iconSDT.Visible = true;
                }
                else if (TxtLuong.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương cho nhân viên");
                    iconLuong.Visible = true;
                }
                else
                {
                    setImageError();
                    tbl_nhanvien nhanvien = new tbl_nhanvien();
                    nhanvien.id = 0;
                    if (urlAnh != "")
                    {
                        nhanvien.anhNV = urlAnh;
                    }
                    else
                    {
                        nhanvien.anhNV = "";
                    }
                    nhanvien.maNV = TxtMaNV.Text;
                    nhanvien.hoTen = TxtHoTen.Text;
                    nhanvien.maKhu = TxtMaKhu.Text;
                    nhanvien.ngaySinh = Ngay_Sinh.Text;
                    nhanvien.soDT = TxtSDT.Text;
                    nhanvien.diaChi = TxtDC.Text;
                    if (CbGioiTinh.Text.Equals("Nữ"))
                    {
                        nhanvien.gioiTinh = 1;
                    }
                    else
                    {
                        nhanvien.gioiTinh = 0;
                    }
                    nhanvien.chucVu = TxtChucVu.Text;
                    nhanvien.Luong = int.Parse(TxtLuong.Text);
                    controller.Sua_NV(nhanvien);
                    NhanVien_Load(sender, e);
                    clearText();
                    TrangThaiButton(false);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiButton(false);
            clearText();
        }

        private void TrangThaiButton(bool b)
        {
            TxtMaNV.Enabled = b;
            TxtChucVu.Enabled = b;
            TxtDC.Enabled = b;
            TxtHoTen.Enabled = b;
            TxtSDT.Enabled = b;
            TxtMaKhu.Enabled = b;
            CbGioiTinh.Enabled = b;
            Ngay_Sinh.Enabled = b;
            TxtLuong.Enabled = b;

            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btThem.Enabled = !b;
            btSua.Enabled = !b;
            btXoa.Enabled = !b;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            controller.InExcel();
        }
    }
}
