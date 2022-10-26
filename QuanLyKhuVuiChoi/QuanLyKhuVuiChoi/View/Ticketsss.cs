using QuanLyKhuVuiChoi.Controller.Tickets;
using QuanLyKhuVuiChoi.Model.Ticketss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyKhuVuiChoi.View
{
    public partial class Ticketsss : Form
    {
        Ticketss_Controller ticketssController;
        public Ticketsss()
        {
            InitializeComponent();
            ticketssController = new Ticketss_Controller();
            dtpngayban.Format = DateTimePickerFormat.Time;
        }
        public void ShowTickets()
        {
            //Khai báo đội tượng lớp DataTbl
            DataTable dt = ticketssController.getTickets();
            advancedDataGridView1.DataSource = dt;
        }
        private void Ticketsss_Load(object sender, EventArgs e)
        {
            ShowTickets();
            btnhienthi.Enabled = false;
            bthuy.Enabled = false;
            iconButton2.Enabled = false;
            iconButton1.Enabled = false;
            txgiave.Visible = false;
            cbbloaikh.Visible = false;
            cbbmakhu.Visible = false;
            dtpngayban.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            cbbmakhu.DataSource = ticketssController.getMaKhu();
            cbbmakhu.DisplayMember = "maKhu";
            cbbmakhu.ValueMember = "maKhu";
            cbbloaikh.DataSource = ticketssController.getLoaiKH();
            cbbloaikh.DisplayMember = "loaiKhachHang";
            cbbloaikh.ValueMember = "loaiKhachHang";
        }
        public bool CheckData()
        {
            /*
            if (string.IsNullOrEmpty(txmave.Text))
            {
                MessageBox.Show("Chưa nhập mã vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmave.Focus();
                return false;
            }
            */

            if (string.IsNullOrEmpty(cbbmakhu.Text))
            {
                MessageBox.Show("Chưa nhập mã khu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakhu.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbloaikh.Text))
            {
                MessageBox.Show("Chưa nhập loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void bttaomoi_Click(object sender, EventArgs e)
        {

        }
        int ID;

        private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Convert.ToInt32(advancedDataGridView1.Rows[index].Cells["id"].Value.ToString());
                txgiave.Text = advancedDataGridView1.Rows[index].Cells["giaVe"].Value.ToString();
                cbbmakhu.SelectedValue = advancedDataGridView1.Rows[index].Cells["maKhu"].Value.ToString();
                dtpngayban.Value = Convert.ToDateTime(advancedDataGridView1.Rows[index].Cells["ngayBan"].Value);
                if (advancedDataGridView1.Rows[index].Cells["loaiKhachHang"].Value.ToString() == "NL")
                    cbbloaikh.Text = "1";
                else
                    cbbloaikh.Text = "0";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa vé không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblTicketss tk = new tblTicketss();
                tk.id = ID;
                if (ticketssController.DeleteTickets(tk))
                    ShowTickets();
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btrefresh_Click(object sender, EventArgs e)
        {
            ShowTickets();
            txtimkiem.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblTicketss tk = new tblTicketss();
                tk.maVe = mave;
                tk.maKhu = cbbmakhu.SelectedValue.ToString();
                tk.loaiKhachHang = cbbloaikh.SelectedValue.ToString() == "1" ? "NL" : "TE";
                tk.giaVe = Convert.ToDecimal(txgiave.Text);
                tk.ngayBan = dtpngayban.Value.Date + dtpngayban.Value.TimeOfDay;
                if (ticketssController.InsertTicKet(tk))
                    ShowTickets();
                else
                    MessageBox.Show("Thêm mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            txgiave.Clear();
            txtimkiem.Clear();
            cbbloaikh.Text = "";
            cbbmakhu.Text = "";
            dtpngayban.Text = "";
        }

        private void cbbloaikh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txgiave.Text = cbbloaikh.SelectedValue.ToString() == "0" ? "50000" : "60000";
        }

        private void bttaomoi_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            while (a == 0)
            {
                mave = Convert.ToString(Rd());
                if (ticketssController.checkMave(mave) == false)
                {
                    a = 1;
                    break;
                }
            }
            cbbmakhu.Text = "";
            cbbloaikh.Text = "";
            txgiave.Clear();
            btnhienthi.Enabled = true;
            bthuy.Enabled = true;
            iconButton2.Enabled = true;
            iconButton1.Enabled = true;
            txgiave.ReadOnly = true;
            txgiave.Visible = true;
            cbbloaikh.Visible = true;
            cbbmakhu.Visible = true;
            dtpngayban.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
        }
        private void ExportExcel(DataGridView dg, string duongDan, string name)
        {
            app obj = new app();
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

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            ExportExcel(advancedDataGridView1, @"D:\", "QL_Ve");
        }

        private void txtimkiem_Enter(object sender, EventArgs e)
        {
            if (txtimkiem.Text == "<Nhập mã vé>")
            {
                txtimkiem.Text = "";
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string value = txtimkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = ticketssController.FindTickets(value);
                advancedDataGridView1.DataSource = dt;
            }
            else
                ShowTickets();
        }
    }
}
