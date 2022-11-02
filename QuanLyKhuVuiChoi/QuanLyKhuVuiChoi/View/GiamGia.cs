using QuanLyKhuVuiChoi.Controller.GiamGia;
using QuanLyKhuVuiChoi.Model.Giam_Gia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel;

namespace QuanLyKhuVuiChoi.View
{
    public partial class GiamGia : Form
    {
        GiamGia_Controller giamGiaController;
        public GiamGia()
        {
            InitializeComponent();
            giamGiaController = new GiamGia_Controller();
            dtpngayban.Format = DateTimePickerFormat.Time;
        }
        public void ShowGiamGia()
        {
            //Khai báo đối tượng DataTable
            DataTable dt = giamGiaController.getGiamGia();
            advancedDataGridView1.DataSource = dt;
        }

        private void GiamGia_Load(object sender, EventArgs e)
        {
            ShowGiamGia();
            btnhienthi.Enabled = false;
            bthuy.Enabled = false;
            btnluu.Enabled = false;
            btnhienthi.Enabled = false;
            btnxoa.Enabled = false;
            txgiave.Visible = false;
            cbbmakh.Visible = false;
            cbbloaikh.Visible = false;
            cbbloaikh.Visible = false;
            cbbmakhu.Visible = false;
            dtpngayban.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            cbbmakhu.DataSource = giamGiaController.getMaKhu();
            cbbmakhu.DisplayMember = "maKhu";
            cbbmakhu.ValueMember = "maKhu";
            cbbloaikh.DataSource = giamGiaController.getLoaiKH();
            cbbloaikh.DisplayMember = "loaiKhachHang";
            cbbloaikh.ValueMember = "loaiKhachHang";
            cbbmakh.DataSource = giamGiaController.getMaKH();
            cbbmakh.DisplayMember = "maKH";
            cbbmakh.ValueMember = "maKH";
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(cbbmakh.Text))
            {
                MessageBox.Show("Chưa chọn mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbmakhu.Text))
            {
                MessageBox.Show("Chưa chọn mã khu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakhu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbloaikh.Text))
            {
                MessageBox.Show("Chưa chọn mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbloaikh.Focus();
                return false;
            }
            return true;
        }
        public int Rd()
        {
            int value;
            Random rd = new Random();
            value = rd.Next(100000, 999999);
            return value;
        }
        string mave;
        int ID;
        private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                ID = Convert.ToInt32(advancedDataGridView1.Rows[index].Cells["id"].Value.ToString());
                cbbmakh.SelectedValue = advancedDataGridView1.Rows[index].Cells["maKH"].Value.ToString();
                cbbmakhu.SelectedValue = advancedDataGridView1.Rows[index].Cells["maKhu"].Value.ToString();
                txgiave.Text = advancedDataGridView1.Rows[index].Cells["giaVe"].Value.ToString();
                dtpngayban.Value = Convert.ToDateTime(advancedDataGridView1.Rows[index].Cells["ngayBan"].Value);
                if (advancedDataGridView1.Rows[index].Cells["loaiKhachHang"].Value.ToString() == "NL")
                    cbbloaikh.Text = "1 - NL";
                else
                    cbbloaikh.Text = "0 - TE";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa vé không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblGiamGia tk = new tblGiamGia();
                tk.id = ID;
                if (giamGiaController.DeleteGiamGia(tk))
                    ShowGiamGia();
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            ShowGiamGia();
            txtimkiem.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblGiamGia tk = new tblGiamGia();
                tk.maVe = mave;
                tk.maKH = cbbmakh.SelectedValue.ToString();
                tk.maKhu = cbbmakhu.SelectedValue.ToString();
                tk.loaiKhachHang = cbbloaikh.SelectedValue.ToString() == "1 - NL" ? "NL" : "TE";
                tk.giaVe = Convert.ToDecimal(txgiave.Text);
                tk.ngayBan = dtpngayban.Value.Date + dtpngayban.Value.TimeOfDay;
                if (giamGiaController.InsertTicKet(tk))
                {
                    ShowGiamGia();
                }
                else
                    MessageBox.Show("Thêm mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            txgiave.Clear();
            cbbmakh.Text = "";
            cbbloaikh.Text = "";
            cbbmakhu.Text = "";
            dtpngayban.Text = "";
        }

        private void cbbloaikh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txgiave.Text = cbbloaikh.SelectedValue.ToString() == "0 - TE" ? "30000" : "50000";
        }

        private void bttaomoi_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a == 0)
            {
                mave = Convert.ToString(Rd());
                if (giamGiaController.checkMave(mave) == false)
                {
                    a = 1;
                    break;
                }
            }
            cbbmakh.Text = "";
            cbbloaikh.Text = "";
            cbbmakhu.Text = "";
            txgiave.Clear();
            btnhienthi.Enabled = true;
            bthuy.Enabled = true;
            btnluu.Enabled = true;
            btnhienthi.Enabled = true;
            btnxoa.Enabled = true;
            txgiave.Visible = true;
            cbbloaikh.Visible = true;
            cbbmakh.Visible = true;
            cbbmakhu.Visible = true;
            dtpngayban.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
        }

        private void txtimkiem_Enter(object sender, EventArgs e)
        {
            if (txtimkiem.Text == "<Nhập mã KH>")
            {
                txtimkiem.Text = "";
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string value = txtimkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = giamGiaController.FindGiamGia(value);
                advancedDataGridView1.DataSource = dt;
            }
            else
                ShowGiamGia();
        }
        private void ExportExcel(DataGridView dg, string duongDan, string name)
        {
            //app obj = new app();
            //obj.Application.Workbooks.Add(Type.Missing);
            ////Laays header(id, maKH,...)
            //for (int i = 1; i < dg.Columns.Count + 1; i++)
            //{
            //    obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            //}
            ////Lấy nội dung bên trong
            ////Chạy từng hàng cuả Dtgrview
            //for (int i = 0; i < dg.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dg.Columns.Count; j++)
            //    {
            //        if (dg.Rows[i].Cells[j].Value != null)
            //        {
            //            obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //}
            //obj.ActiveWorkbook.SaveCopyAs(duongDan + name + ".xlsx");
            //obj.ActiveWorkbook.Saved = true;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            ExportExcel(advancedDataGridView1, @"D:\", "Quản lý giảm giá");
        }
    }
}
