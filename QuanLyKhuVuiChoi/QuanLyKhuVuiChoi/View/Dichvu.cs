using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhuVuiChoi.Controller.Dich_vu;
using QuanLyKhuVuiChoi.Model.Dich_Vu;

namespace QuanLyKhuVuiChoi.View
{
    public partial class Dichvu : Form
    {
        dich_vu_Controller dich_Vu_Controller;
        int ID;
        public Dichvu()
        {
            InitializeComponent();
            dich_Vu_Controller = new dich_vu_Controller();
        }
        private void Dich_Vu_Load(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = false;
            txtTenDichVu.Enabled = false;
            cbMaKhuDV.Enabled = false;
            Show_DV();
            cbMaKhuDV.DataSource = dich_Vu_Controller.get_makhu();
            cbMaKhuDV.DisplayMember = "maKhu";
            cbMaKhuDV.ValueMember = "maKhu";
        }
        public void Show_DV()
        {
            DataTable tb = dich_Vu_Controller.get_DV();
            gvDichVu.DataSource = tb;
            gvDichVu.Refresh();
        }
        public bool Check_data()
        {
            if (string.IsNullOrEmpty(txtTenDichVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDichVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaDichVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDichVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaDichVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaDichVu.Focus();
                return false;
            }
            return true;
        }


        private void Dichvu_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtGiaDichVu.Enabled = true;
            cbMaKhuDV.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_dich_vu dv = new tbl_dich_vu();
                dv.id = ID;
                dv.maDichVu = txtMaDichVu.Text;
                dv.tenDichVu = txtTenDichVu.Text;
                dv.giaDichVu = txtGiaDichVu.Text;
                dv.maKhu = cbMaKhuDV.Text;

                if (dich_Vu_Controller.cap_nhat_DV(dv))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    Show_DV();
                }

                else
                    MessageBox.Show("Vui lòng thử lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_dich_vu dv = new tbl_dich_vu();
                dv.id = ID;
                if (dich_Vu_Controller.xoa_DV(dv))
                {
                    MessageBox.Show("Xóa thành công!");
                    Show_DV();
                }

                else
                    MessageBox.Show("Vui lòng thử lại");
            }
        }

        private void gvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                ID = Convert.ToInt32(gvDichVu.Rows[i].Cells["id"].Value.ToString());
                txtMaDichVu.Text = gvDichVu.Rows[i].Cells["maDichVu"].Value.ToString();
                txtTenDichVu.Text = gvDichVu.Rows[i].Cells["tenDichVu"].Value.ToString();
                txtGiaDichVu.Text = gvDichVu.Rows[i].Cells["giaDichVu"].Value.ToString();
                cbMaKhuDV.Text = gvDichVu.Rows[i].Cells["maKhu"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_dich_vu dv = new tbl_dich_vu();
                dv.id = ID;
                dv.maDichVu = txtMaDichVu.Text;
                dv.tenDichVu = txtTenDichVu.Text;
                dv.giaDichVu = txtGiaDichVu.Text;
                dv.maKhu = cbMaKhuDV.Text;

                if (dich_Vu_Controller.tao_moi_DV(dv))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    Show_DV();
                }
                else
                    MessageBox.Show("Vui lòng thử lại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string value = txtTKdv.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable tb = dich_Vu_Controller.tim_DV(value);
                gvDichVu.DataSource = tb;
                gvDichVu.Refresh();
            }
            else
                Show_DV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTKdv.Clear();
            Show_DV();
        }
        private void txtTKdv_Enter(object sender, EventArgs e)
        {
            if (txtTKdv.Text == "<Nhập tên dịch vụ>")
            {
                txtTKdv.Text = "";
            }
        }
        private void txtTKdv_Leave(object sender, EventArgs e)
        {
            if (txtTKdv.Text == "")
            {
                txtTKdv.Text = "<Nhập tên dịch vụ>";
            }
        }
    }
}

