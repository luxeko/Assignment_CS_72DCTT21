using QuanLyKhuVuiChoi.Controller.Tickets;
using QuanLyKhuVuiChoi.Model.Tickets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi.View
{
    public partial class Tickets : Form
    {
        Tickets_Controller ticketsController;
        public Tickets()
        {
            InitializeComponent();
            //Khởi tạo 
            ticketsController = new Tickets_Controller();
            dtpngayban.Format = DateTimePickerFormat.Time;
        }
        public void ShowTickets()
        {
            //Khai báo đội tượng lớp DataTbl
            DataTable dt = ticketsController.getTickets();
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void Tickets_Load(object sender, EventArgs e)
        {
            ShowTickets();
            btcapnhat.Enabled = false;
            bthuy.Enabled = false;
            btluu.Enabled = false;
            btxoa.Enabled = false;
            txmave.Enabled = false;
            cbbmakhu.DataSource = ticketsController.getMaKhu();
            cbbmakhu.DisplayMember = "maKhu";
            cbbmakhu.ValueMember = "maKhu";
            cbbloaikh.DataSource = ticketsController.getLoaiKH();
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

            if (string.IsNullOrEmpty(txgiave.Text))
            {
                MessageBox.Show("Chưa nhập giá vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmave.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbmakhu.Text))
            {
                MessageBox.Show("Chưa nhập mã khu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmave.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbloaikh.Text))
            {
                MessageBox.Show("Chưa nhập loại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmave.Focus();
                return false;
            }
            return true;
        }

        private void bttaomoi_Click(object sender, EventArgs e)
        {
            Random();
            txmave.Text = Convert.ToString(value);
            btcapnhat.Enabled = true;
            bthuy.Enabled = true;
            btluu.Enabled = true;
            btxoa.Enabled = true;
        }
        int ID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[index].Cells["id"].Value.ToString());
                txmave.Text = dataGridView1.Rows[index].Cells["maVe"].Value.ToString();
                txgiave.Text = dataGridView1.Rows[index].Cells["giaVe"].Value.ToString();
                cbbmakhu.SelectedValue = dataGridView1.Rows[index].Cells["maKhu"].Value.ToString();
                dtpngayban.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells["ngayBan"].Value);
                if (dataGridView1.Rows[index].Cells["loaiKhachHang"].Value.ToString() == "NL")
                    cbbloaikh.Text = "1";
                else
                    cbbloaikh.Text = "0";
            }
        }
        int value;
        public int Random()
        {
            Random rd = new Random();
            value = rd.Next(1, 100);
            return value;
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tbTickets tk = new tbTickets();
                tk.id = ID;
                tk.maVe = "NQ"+txmave.Text;
                tk.maKhu = cbbmakhu.SelectedValue.ToString();
                tk.loaiKhachHang = cbbloaikh.SelectedValue.ToString() == "1" ? "NL" : "TE";
                tk.giaVe = Convert.ToDecimal(txgiave.Text);
                tk.ngayBan = dtpngayban.Value.Date + dtpngayban.Value.TimeOfDay;
                if (ticketsController.UpdateTickets(tk))
                    ShowTickets();
                else
                    MessageBox.Show("Cập nhật không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa vé không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tbTickets tk = new tbTickets();
                tk.id = ID;
                if (ticketsController.DeleteTickets(tk))
                    ShowTickets();
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string value = txtimkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = ticketsController.FindTickets(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowTickets();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            ShowTickets();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tbTickets tk = new tbTickets();
                tk.maVe = txmave.Text;
                tk.maKhu = cbbmakhu.SelectedValue.ToString();
                tk.loaiKhachHang = cbbloaikh.SelectedValue.ToString() == "1" ? "NL" : "TE";
                tk.giaVe = Convert.ToDecimal(txgiave.Text);
                tk.ngayBan = dtpngayban.Value.Date + dtpngayban.Value.TimeOfDay;
                if (ticketsController.InsertTicKet(tk))
                    ShowTickets();
                else
                    MessageBox.Show("Thêm mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            txgiave.Clear();
            txmave.Clear();
            txtimkiem.Clear();
            cbbloaikh.Text = "";
            cbbmakhu.Text = "";
            dtpngayban.Text = "";
        }
    }
}
    //DateTime.Now.ToString("yyyyMMddHHmmss");