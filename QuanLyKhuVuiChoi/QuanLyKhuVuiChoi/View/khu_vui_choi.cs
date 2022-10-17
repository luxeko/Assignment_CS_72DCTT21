using Microsoft.SqlServer.Server;
using QuanLyKhuVuiChoi.Controller.Khu_Vui_Choi;
using QuanLyKhuVuiChoi.Model.Khu_Vui_Choi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;
using xls = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyKhuVuiChoi.View
{
    public partial class khu_vui_choi : Form
    {
        khu_vui_choi_Controller khu_vui_choi_Controller;
        public khu_vui_choi()
        {
            InitializeComponent();
            khu_vui_choi_Controller = new khu_vui_choi_Controller();
        }

        public bool Check_data()
        {
            if (string.IsNullOrEmpty(txtMaKhu.Text))
            {
                MaKhu_ERR.SetError(txtMaKhu, "Vui lòng điền mã trò");
                MessageBox.Show("Bạn chưa nhập tên khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhu.Focus();
                return false;
            }
            else
            {
                MaKhu_ERR.SetError(txtMaKhu, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenKhu.Text))
            {
                TenKhu_ERR.SetError(txtTenKhu, "Điền mã khu");
                MessageBox.Show("Bạn chưa nhập tên khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhu.Focus();
                return false;
            }
            else
            {
                TenKhu_ERR.SetError(txtTenKhu, string.Empty);
            }
            if (string.IsNullOrEmpty(txtViTri.Text))
            {
                ViTri_ERR.SetError(txtViTri, "Điền vị trí");
                MessageBox.Show("Bạn chưa nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtViTri.Focus();
                return false;
            }
            else
            {
                ViTri_ERR.SetError(txtViTri, string.Empty);
            }
            if (string.IsNullOrEmpty(txtDienTich.Text))
            {
                DienTich_ERR.SetError(txtViTri, "Điền diện tích");
                MessageBox.Show("Bạn chưa nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienTich.Focus();
                return false;
            }
            else
            {
                DienTich_ERR.SetError(txtDienTich, string.Empty);
            }
            if (string.IsNullOrEmpty(txtDienTich.Text))
            {
                MessageBox.Show("Bạn chưa nhập diện tích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienTich.Focus();
                return false;
            }
            else
            {
                DienTich_ERR.SetError(txtDienTich, string.Empty);
            }
            if (string.IsNullOrEmpty(txtGiaNL.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaNL.Focus();
                return false;
            }
            else
            {
                GiaNL_ERR.SetError(txtGiaNL, string.Empty);
            }
            if (string.IsNullOrEmpty(txtGiaTE.Text))
            {
                MessageBox.Show("Bạn chưa nhập gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaTE.Focus();
                return false;
            }
            else
            {
                GiaTE_ERR.SetError(txtGiaTE, string.Empty);
            }

            return true;
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKhu.Enabled = true;
            txtTenKhu.Enabled = true;
            txtViTri.Enabled = true;
            txtDienTich.Enabled = true;
            txtGiaNL.Enabled = true;
            txtGiaTE.Enabled = true;
            mtxtGioMo.Enabled = true;
            mtxtGioDong.Enabled = true;
        }
        public void Show_KVC()
        {
            DataTable tb = khu_vui_choi_Controller.get_KVC();
            dtgvKhuVuiChoi.DataSource = tb;
            dtgvKhuVuiChoi.Refresh();
        }
        private void khu_vui_choi_Load(object sender, EventArgs e)
        {
            Show_KVC();
            txtMaKhu.Enabled = false;
            txtTenKhu.Enabled = false;
            txtViTri.Enabled = false;
            txtDienTich.Enabled = false;
            txtGiaNL.Enabled = false;
            txtGiaTE.Enabled = false;
            mtxtGioMo.Enabled = false;
            mtxtGioDong.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_khu_vui_choi kvc = new tbl_khu_vui_choi();
                kvc.tenKhu = txtTenKhu.Text.Trim();
                kvc.maKhu = txtMaKhu.Text.Trim();
                kvc.viTri = txtViTri.Text.Trim();
                kvc.dienTich = txtDienTich.Text.Trim();
                kvc.gioMo = mtxtGioMo.Text.Trim();
                kvc.gioDong = mtxtGioDong.Text.Trim();
                kvc.giaNL = Convert.ToDecimal(txtGiaNL.Text.Trim());
                kvc.giaTE = Convert.ToDecimal(txtGiaTE.Text.Trim());

                if (khu_vui_choi_Controller.tao_moi_KVC(kvc))
                {
                    MessageBox.Show("Thêm mới thành công");
                    Show_KVC();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
                }
            }
        }
        int ID;
        private void dtgvKhuVuiChoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                ID = Convert.ToInt32(dtgvKhuVuiChoi.Rows[i].Cells["id"].Value.ToString());
                txtMaKhu.Text = dtgvKhuVuiChoi.Rows[i].Cells["maKhu"].Value.ToString();
                txtTenKhu.Text = dtgvKhuVuiChoi.Rows[i].Cells["tenKhu"].Value.ToString();
                txtViTri.Text = dtgvKhuVuiChoi.Rows[i].Cells["viTri"].Value.ToString();
                txtDienTich.Text = dtgvKhuVuiChoi.Rows[i].Cells["dienTich"].Value.ToString();
                mtxtGioMo.Text = dtgvKhuVuiChoi.Rows[i].Cells["gioMo"].Value.ToString();
                mtxtGioDong.Text = dtgvKhuVuiChoi.Rows[i].Cells["gioDong"].Value.ToString();
                txtGiaNL.Text = dtgvKhuVuiChoi.Rows[i].Cells["giaNL"].Value.ToString();
                txtGiaTE.Text = dtgvKhuVuiChoi.Rows[i].Cells["giaTE"].Value.ToString();
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_khu_vui_choi kvc = new tbl_khu_vui_choi();
                kvc.id = ID;
                kvc.tenKhu = txtTenKhu.Text;
                kvc.maKhu = txtMaKhu.Text;
                kvc.viTri = txtViTri.Text;
                kvc.dienTich = txtDienTich.Text;
                kvc.gioMo = mtxtGioMo.Text;
                kvc.gioDong = mtxtGioDong.Text;
                kvc.giaTE = Convert.ToDecimal(txtGiaTE.Text);
                kvc.giaNL = Convert.ToDecimal(txtGiaNL.Text);

                if (khu_vui_choi_Controller.cap_nhat_KVC(kvc))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Show_KVC();
                }

                else
                    MessageBox.Show("Đã có lỗi xảy ra \n Vui lòng thử lại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_khu_vui_choi kvc = new tbl_khu_vui_choi();
                kvc.id = ID;
                if (khu_vui_choi_Controller.xoa_KVC(kvc))
                {
                    MessageBox.Show("Xóa thành công");
                    Show_KVC();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra \n Vui lòng thử lại");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = khu_vui_choi_Controller.tim_KVC(value);
                dtgvKhuVuiChoi.DataSource = tb;
                dtgvKhuVuiChoi.Refresh();
            }
            else
                Show_KVC();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "<Nhập tên khu>")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "<Nhập tên khu>";
            }
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Show_KVC();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaKhu.Clear();
            txtTenKhu.Clear();
            txtViTri.Clear();
            txtDienTich.Clear();
            txtGiaNL.Clear();
            txtGiaTE.Clear();
            mtxtGioMo.Clear();
            mtxtGioDong.Clear();
        }

        private void txtDienTich_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (!(long.TryParse(txtDienTich.Text, out n)))
            {
                DienTich_ERR.SetError(txtDienTich, "Yêu cầu nhập bằng số");
                return;
            }
            else
            {
                DienTich_ERR.SetError(txtDienTich, string.Empty);
            }
        }

        private void txtGiaNL_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (!(long.TryParse(txtGiaNL.Text, out n)))
            {
                GiaNL_ERR.SetError(txtGiaNL, "Yêu cầu nhập bằng số");
                return;
            }
            else
            {
                GiaNL_ERR.SetError(txtGiaNL, string.Empty);
            }
        }

        private void txtGiaTE_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (!(long.TryParse(txtGiaTE.Text, out n)))
            {
                GiaTE_ERR.SetError(txtGiaTE, "Yêu cầu nhập bằng số");
                return;
            }
            else
            {
                GiaTE_ERR.SetError(txtGiaTE, string.Empty);
            }
        }
        private void ExportExcel(DataGridView dg, string duongDan, string name)
        {
            xls obj = new xls();
            obj.Application.Workbooks.Add(Type.Missing);
            //Laays header(id, maKH,...)
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            //Lấy nội dung bên trong
            //Chạy từng hàng cuả Dtgrview
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + name + ".xlsx");
            obj.Columns.AutoFit();
            obj.ActiveWorkbook.Saved = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ExportExcel(dtgvKhuVuiChoi, @"D:\", "Quản lý khu vui chơi");
            MessageBox.Show("Xuất file thành công");
        }
    }
}
