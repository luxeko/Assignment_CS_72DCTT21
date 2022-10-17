using QuanLyKhuVuiChoi.Controller.Customers;
using QuanLyKhuVuiChoi.Model.Customers;
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
    public partial class Customer : Form
    {
        Customers_Controller customersController;
        public Customer()
        {
            InitializeComponent();
            customersController = new Customers_Controller();
        }
        public void ShowCustomers()
        {
            //Khai báo đội tượng lớp DataTbl
            DataTable dt = customersController.getCustomers();
            advancedDataGridView1.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ShowCustomers();
            cbbgioitinh.Text = "";
            btnhienthi.Enabled = false;
            mtkngaysinh.Enabled = false;
            btncapnhat.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            txsdt.Enabled = false;
            txmakh.Enabled = false;
            txhoten.Enabled = false;
            txdiachi.Enabled = false;
            txtimkiem.Enabled = false;
            cbbgioitinh.Enabled = false;
            cbbgioitinh.DataSource = customersController.getGioiTinh();
            cbbgioitinh.DisplayMember = "gioiTinh";
            cbbgioitinh.ValueMember = "gioiTinh";
        }
        public bool is_number(string p_so)
        {
            int kq;
            return int.TryParse(p_so, out kq);
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txhoten.Text))
            {
                if (string.IsNullOrEmpty(txhoten.Text.ToString()))
                {
                    errorhoten.SetError(txhoten, "Yêu cầu điền tên");
                    return false;
                }
                else
                {
                    errorhoten.SetError(txhoten, string.Empty);
                }
                MessageBox.Show("Chưa nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txhoten.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbgioitinh.Text))
            {
                MessageBox.Show("Chưa chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbgioitinh.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txdiachi.Text))
            {
                if (string.IsNullOrEmpty(txdiachi.Text.ToString()))
                {
                    errordiachi.SetError(txdiachi, "Yêu cầu điền địa chỉ");
                    return false;
                }
                else
                {
                    errordiachi.SetError(txdiachi, string.Empty);
                }
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txdiachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txmakh.Text))
            {
                if (string.IsNullOrEmpty(txmakh.Text.ToString()))
                {
                    errormakh.SetError(txmakh, "Yêu cầu điền mã khách hàng");
                    return false;
                }
                else
                {
                    errormakh.SetError(txmakh, string.Empty);
                }
                MessageBox.Show("Chưa nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmakh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txsdt.Text))
            {
                if (string.IsNullOrEmpty(txsdt.Text.ToString()))
                {
                    errorsdt.SetError(txsdt, "Yêu cầu điền SDT");
                    return false;
                }
                else
                {
                    errorsdt.SetError(txsdt, string.Empty);
                }
                MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txsdt.Focus();
                return false;
            }
            return true;
        }
        private void btntaomoi_Click(object sender, EventArgs e)
        {
            btnhienthi.Enabled = true;
            mtkngaysinh.Enabled = true;
            btncapnhat.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            txsdt.Enabled = true;
            txmakh.Enabled = true;
            txhoten.Enabled = true;
            txdiachi.Enabled = true;
            txtimkiem.Enabled = true;
            cbbgioitinh.Enabled = true;
            txmakh.Enabled = true;
            txsdt.Enabled = true;   
        }

        private void txtimkiem_Enter(object sender, EventArgs e)
        {
            if (txtimkiem.Text == "(Nhập SĐT)")
            {
                txtimkiem.Text = "";
            }
        }
        int ID;

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa vé không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                tblCustomers tk = new tblCustomers();
                tk.id = ID;
                if (customersController.DeleteCustomers(tk))
                    ShowCustomers();
                else
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblCustomers cts = new tblCustomers();
                cts.maKH = txmakh.Text;
                cts.hoTen = txhoten.Text;
                cts.sdt = txsdt.Text;
                cts.ngaySinh = mtkngaysinh.Text;
                cts.diaChi = txdiachi.Text;
                cts.gioiTinh = cbbgioitinh.SelectedValue.ToString();
                if (customersController.InsertCustomers(cts))
                    ShowCustomers();
                else
                    MessageBox.Show("Thêm mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txmakh.Clear();
            txhoten.Clear();
            txsdt.Clear();
            txdiachi.Clear();
            cbbgioitinh.Text = "";
            mtkngaysinh.Text = null;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtimkiem.Clear();
            ShowCustomers();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblCustomers cts = new tblCustomers();
                cts.id = ID;
                cts.maKH = txmakh.Text;
                cts.hoTen = txhoten.Text;
                cts.sdt = txsdt.Text;
                cts.diaChi = txdiachi.Text;
                cts.ngaySinh = mtkngaysinh.Text;
                cts.gioiTinh = cbbgioitinh.SelectedValue.ToString();

                if (customersController.UpdateCustomers(cts))
                {
                    MessageBox.Show("Cập nhật thành công.");
                    ShowCustomers();
                }
                else
                    MessageBox.Show("Cập nhật không thành công \n Vui lòng thử lại","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            ExportExcel(advancedDataGridView1, @"D:\", "Quản lý khách hàng");
        }
        private void advancedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Convert.ToInt32(advancedDataGridView1.Rows[index].Cells["id"].Value.ToString());
                txmakh.Text = advancedDataGridView1.Rows[index].Cells["maKH"].Value.ToString();
                txhoten.Text = advancedDataGridView1.Rows[index].Cells["hoTen"].Value.ToString();
                txdiachi.Text = advancedDataGridView1.Rows[index].Cells["diaChi"].Value.ToString();
                txsdt.Text = advancedDataGridView1.Rows[index].Cells["sdt"].Value.ToString();
                mtkngaysinh.Text = advancedDataGridView1.Rows[index].Cells["ngaySinh"].Value.ToString();
                cbbgioitinh.Text = advancedDataGridView1.Rows[index].Cells["gioiTinh"].Value.ToString();
            }
        }
        private void txsdt_TextChanged(object sender, EventArgs e)
        {
            long n;
            if(!(long.TryParse(txsdt.Text, out n)))
            {
                errormakh.SetError(txsdt, "Yêu cầu nhập bằng số");
                return;
            }
            else
            {
                errormakh.SetError(txsdt, string.Empty);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string value = txtimkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = customersController.FindCustomers(value);
                advancedDataGridView1.DataSource = dt;
            }
            else
                ShowCustomers();
        }

        private void txtimkiem_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (!(long.TryParse(txtimkiem.Text, out n)))
            {
                errorsdt.SetError(txtimkiem, "Yêu cầu nhập bằng số");
                return;
            }
            else
            {
                errorsdt.SetError(txtimkiem, string.Empty);
            }
        }
    }
}
