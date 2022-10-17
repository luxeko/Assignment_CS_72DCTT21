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

namespace QuanLyKhuVuiChoi.View
{
    public partial class Khu_Vui_Choi : Form
    {
        khu_vui_choi_Controller khu_vui_choi_Controller;
        public Khu_Vui_Choi()
        {
            InitializeComponent();
            khu_vui_choi_Controller = new khu_vui_choi_Controller();
            
        }

        public bool Check_data()
        {
            if (string.IsNullOrEmpty(txtTenKhu.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaKhu.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtViTri.Text))
            {
                MessageBox.Show("Bạn chưa nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtViTri.Focus();
                return false;
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
            txtGioMoCua.Enabled = true;
            txtGioDongCua.Enabled = true;
        }

        public void Show_KVC()
        {
            DataTable tb = khu_vui_choi_Controller.get_KVC();
            dtgvKhuVuiChoi.DataSource = tb;
            dtgvKhuVuiChoi.Refresh();
        }

        private void Khu_Vui_Choi_Load(object sender, EventArgs e)
        {
            Show_KVC();
            txtMaKhu.Enabled = false;
            txtTenKhu.Enabled = false;
            txtViTri.Enabled = false;
            txtDienTich.Enabled = false;
            txtGiaNL.Enabled = false;
            txtGiaTE.Enabled = false;
            txtGioMoCua.Enabled = false;
            txtGioDongCua.Enabled = false;
        }
       

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                kvc.gioMo = txtGioMoCua.Text;
                kvc.gioDong = txtGioDongCua.Text;
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            if (Check_data())
            {
                tbl_khu_vui_choi kvc = new tbl_khu_vui_choi();
                kvc.tenKhu = txtTenKhu.Text.Trim();
                kvc.maKhu = txtMaKhu.Text.Trim();
                kvc.viTri = txtViTri.Text.Trim();
                kvc.dienTich = txtDienTich.Text.Trim();
                kvc.gioMo = txtGioMoCua.Text.Trim();
                kvc.gioDong = txtGioDongCua.Text.Trim();
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
            if(i >= 0)
            {
                ID = Convert.ToInt32(dtgvKhuVuiChoi.Rows[i].Cells["id"].Value.ToString());
                txtMaKhu.Text = dtgvKhuVuiChoi.Rows[i].Cells["maKhu"].Value.ToString();
                txtTenKhu.Text = dtgvKhuVuiChoi.Rows[i].Cells["tenKhu"].Value.ToString();
                txtViTri.Text = dtgvKhuVuiChoi.Rows[i].Cells["viTri"].Value.ToString();
                txtDienTich.Text = dtgvKhuVuiChoi.Rows[i].Cells["dienTich"].Value.ToString();
                txtGioMoCua.Text = dtgvKhuVuiChoi.Rows[i].Cells["gioMo"].Value.ToString();
                txtGioDongCua.Text = dtgvKhuVuiChoi.Rows[i].Cells["gioDong"].Value.ToString();
                txtGiaNL.Text = dtgvKhuVuiChoi.Rows[i].Cells["giaNL"].Value.ToString();
                txtGiaTE.Text = dtgvKhuVuiChoi.Rows[i].Cells["giaTE"].Value.ToString();
            }   
                
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
         
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
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
    }
}
