using Microsoft.SqlServer.Server;
using QuanLyKhuVuiChoi.Controller.Tro_Choi;
using QuanLyKhuVuiChoi.Model.Tro_Choi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi.View
{
    public partial class Tro_Choi : Form
    {
        tro_choi_controller tro_Choi_Controller;
        public Tro_Choi()
        {
            InitializeComponent();
            tro_Choi_Controller = new tro_choi_controller();
            
        }
        private void Tro_Choi_Load(object sender, EventArgs e)
        {
            cbMaKhu.Enabled = false;
            txtMaTroChoi.Enabled = false;
            txtTenTroChoi.Enabled = false;
            txtViTri.Enabled = false;
            Show_TC();
            cbMaKhu.DataSource = tro_Choi_Controller.get_makhu();
            cbMaKhu.DisplayMember = "maKhu";
            cbMaKhu.ValueMember = "maKhu";
        }
        public void Show_TC()
        {
            DataTable tb = tro_Choi_Controller.get_TC();
            dtgvTroChoi.DataSource = tb;
            dtgvTroChoi.Refresh();
        }
        public bool Check_data()
        {
            if (string.IsNullOrEmpty(txtTenTroChoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTroChoi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaTroChoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTroChoi.Focus();
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
            cbMaKhu.Enabled = true;
            txtMaTroChoi.Enabled = true;
            txtTenTroChoi.Enabled = true;
            txtViTri.Enabled = true;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_tro_choi tc = new tbl_tro_choi();
                tc.id = ID;
                tc.tenTroChoi = txtTenTroChoi.Text;
                tc.maKhu = cbMaKhu.Text;
                tc.viTri = txtViTri.Text;
                tc.maTroChoi = txtMaTroChoi.Text;

                if (tro_Choi_Controller.cap_nhat_TC(tc))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Show_TC();
                }
                    
                else
                    MessageBox.Show("Đã có lỗi xảy ra \n Vui lòng thử lại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_tro_choi tc = new tbl_tro_choi();
                tc.id = ID;
                if (tro_Choi_Controller.xoa_TC(tc))
                {
                    MessageBox.Show("Xóa thành công");
                    Show_TC();
                }
                    
                else
                    MessageBox.Show("Đã có lỗi xảy ra \n Vui lòng thử lại");
            }
        } 
        int ID;
        private void dtgvTroChoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                ID = Convert.ToInt32(dtgvTroChoi.Rows[i].Cells["id"].Value.ToString());
                txtTenTroChoi.Text = dtgvTroChoi.Rows[i].Cells["tenTroChoi"].Value.ToString();
                txtMaTroChoi.Text = dtgvTroChoi.Rows[i].Cells["maTroChoi"].Value.ToString();
                cbMaKhu.Text = dtgvTroChoi.Rows[i].Cells["maKhu"].Value.ToString();
                txtViTri.Text = dtgvTroChoi.Rows[i].Cells["viTri"].Value.ToString();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (Check_data())
            {
                tbl_tro_choi tc = new tbl_tro_choi();
                tc.id = ID;
                tc.tenTroChoi = txtTenTroChoi.Text;
                tc.maTroChoi = txtMaTroChoi.Text;
                tc.maKhu = cbMaKhu.Text;
                tc.viTri = txtViTri.Text;

                if (tro_Choi_Controller.tao_moi_TC(tc))
                {
                    MessageBox.Show("Thêm mới thành công");
                    Show_TC();
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
                DataTable tb = tro_Choi_Controller.tim_TC(value);
                dtgvTroChoi.DataSource = tb;
                dtgvTroChoi.Refresh();
            }
            else
                Show_TC();
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            Show_TC();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "<Nhập tên trò chơi>")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "<Nhập tên trò chơi>";
            }
        }
    }
}
