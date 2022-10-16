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
using xls = Microsoft.Office.Interop.Excel.Application;
using Zuby.ADGV;

namespace QuanLyKhuVuiChoi.View
{
    public partial class tro_choi : Form
    {
        tro_choi_controller tro_Choi_Controller;
        public tro_choi()
        {
            InitializeComponent();
            tro_Choi_Controller = new tro_choi_controller();
        }
        public void Show_TC()
        {
            DataTable tb = tro_Choi_Controller.get_TC();
            dtgvTroChoi.DataSource = tb;
            dtgvTroChoi.Refresh();
        }
        public bool Check_data()
        {
            if (string.IsNullOrEmpty(txtMaTroChoi.Text))
            {
                MaTroChoi_ERR.SetError(txtMaTroChoi, "Vui lòng điền mã trò");
                MessageBox.Show("Bạn chưa nhập mã trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTroChoi.Focus();
                return false;
            }
            else
            {
                MaTroChoi_ERR.SetError(txtMaTroChoi, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenTroChoi.Text))
            {
                TenTroChoi_ERR.SetError(txtMaTroChoi, "Vui lòng điền tên");
                MessageBox.Show("Bạn chưa nhập tên trò chơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTroChoi.Focus();
                return false;
            }
            else
            {
                TenTroChoi_ERR.SetError(txtTenTroChoi, string.Empty);
            }
            if (string.IsNullOrEmpty(txtViTri.Text))
            {
                ViTri_ERR.SetError(txtViTri, "Vui lòng điền vị trí");
                MessageBox.Show("Bạn chưa nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtViTri.Focus();
                return false;
            }
            else
            {
                ViTri_ERR.SetError(txtViTri, string.Empty);
            }
            if(cbMaKhu.Text == "--- Vui lòng chọn mã khu ---")
            {
                MaKhu_ERR.SetError(cbMaKhu, "Chọn mã khu");
                MessageBox.Show("Bạn chưa chọn mã khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MaKhu_ERR.SetError(cbMaKhu, string.Empty);
            }
            
            return true;
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

        private void tro_choi_Load(object sender, EventArgs e)
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

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            cbMaKhu.Enabled = true;
            txtMaTroChoi.Enabled = true;
            txtTenTroChoi.Enabled = true;
            txtViTri.Enabled = true;
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaTroChoi.Refresh();
            txtTenTroChoi.Refresh();
            txtViTri.Refresh();
            cbMaKhu.Refresh();
            
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
            obj.ActiveWorkbook.Saved = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ExportExcel(dtgvTroChoi, @"D:\", "Quản lý trò chơi");
            MessageBox.Show("Xuất file thành công");
        }
    }
}
