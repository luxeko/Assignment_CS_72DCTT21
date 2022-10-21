using QuanLyKhuVuiChoi.Controller.User;
using QuanLyKhuVuiChoi.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi
{
    public partial class User : Form
    {
        UserController userController;
        string flag;
        int ID;
        string filterValue;
        bool clickFilterId = true;
        bool clickFilterUsername = true;
        bool clickFilterEmail = true;
        bool clickFilterTrangThai = true;
        bool clickFilterMaNV = true;
        bool clickFilterCreatedAt = true;
        bool clickFilterUpdateAt = true;

        public User()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void User_Load(object sender, EventArgs e)
        {
            cbTrangThai.Items.Insert(0, " -- Chọn --");
            cbTrangThai.Items.Insert(1, " Active");
            cbTrangThai.Items.Insert(2, " Disable");
            cbMaNv.Items.Insert(0, " -- Chọn --");
            getUser();
            lockControl();

        }

        public void lockControl()
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnLuu.Enabled = false;
            btnCancel.Enabled = false;

            txtUserName.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            cbTrangThai.Enabled = false;
            cbMaNv.Enabled = false;

            cbTrangThai.SelectedIndex = 0;
            cbMaNv.SelectedIndex = 0;
            dataGridViewUser.Enabled = false;
            dataGridViewUser.ClearSelection();
            btnCreate.Focus();
        }

        public void unlockControl()
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnLuu.Enabled = true;
            btnCancel.Enabled = true;

            txtUserName.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            cbTrangThai.Enabled = true;
            cbMaNv.Enabled = true;
            dataGridViewUser.Enabled = true;

            txtUserName.Focus();
        }

        private void getUser()
        {
            DataTable dt = userController.getUser();
            dataGridViewUser.DataSource = dt;
            dataGridViewUser.ClearSelection();
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                errorUserName.SetError(txtUserName, "Bạn chưa nhập Username");
                return false;
            } 
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorEmail.SetError(txtEmail, "Bạn chưa nhập Email");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorPassword.SetError(txtPassword, "Bạn chưa nhập mật khẩu");
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text) || txtConfirmPassword.Text != txtPassword.Text)
            {
                errorConPassword.SetError(txtConfirmPassword, "Mật khẩu nhập lại không đúng");
                txtConfirmPassword.Focus();
                return false;
            }
            if (cbTrangThai.SelectedIndex != 1 && cbTrangThai.SelectedIndex != 2)
            {
                errorStatus.SetError(cbTrangThai, "Vui lòng chọn trạng thái [Active] hoặc [Disable]");
                cbTrangThai.Focus();
                return false;
            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorUserName.SetError(txtUserName, null);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            errorEmail.SetError(txtEmail, null);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorPassword.SetError(txtPassword, null);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errorConPassword.SetError(txtConfirmPassword, null);
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorStatus.SetError(cbTrangThai, null);
        }

        private void cbMaNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorMaNv.SetError(cbMaNv, null);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "create";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "delete";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            lockControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch(flag)
            {
                case "create":
                    if (checkData())
                    {
                        DataTable dtUserName = userController.checkUserName(txtUserName.Text);
                        DataTable dtEmail = userController.checkEmail(txtEmail.Text);
                        if (dtUserName.Rows.Count > 0)
                        {
                            MessageBox.Show("Username đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dtEmail.Rows.Count > 0)
                        {
                            MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tblUser user = new tblUser();
                            user.username = txtUserName.Text;
                            user.email = txtEmail.Text;
                            user.password = txtPassword.Text;
                            user.trangThai = cbTrangThai.SelectedItem.ToString();
                            user.created_at = DateTime.Now;
                            user.updated_at = DateTime.Now;
                            if (userController.create(user))
                            {
                                getUser();
                                txtUserName.Clear();
                                txtEmail.Clear();
                                txtPassword.Clear();
                                txtConfirmPassword.Clear();
                                lockControl();
                                MessageBox.Show("Thêm user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Lỗi khi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case "delete":
                    if(userController.delete(ID))
                    {
                        getUser();
                        txtUserName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        lockControl();
                        MessageBox.Show("Xoá user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xoá dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "update":
                    if(checkData())
                    {
                        DataTable dtUserName = userController.checkUserNameAfterUpdate(ID,txtUserName.Text);
                        DataTable dtEmail = userController.checkEmailAfterUpdate(ID, txtEmail.Text);
                        if (dtUserName.Rows.Count > 0)
                        {
                            MessageBox.Show("Username đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dtEmail.Rows.Count > 0)
                        {
                            MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tblUser user = new tblUser();
                            user.username = txtUserName.Text;
                            user.email = txtEmail.Text;
                            user.password = txtPassword.Text;
                            try
                            {
                                user.trangThai = cbTrangThai.SelectedItem.ToString();
                            }
                            catch
                            {
                                errorStatus.SetError(cbTrangThai, "Vui lòng chọn trạng thái");
                                cbTrangThai.Focus();
                            }
                            user.updated_at = DateTime.Now;
                            if (userController.update(ID, user))
                            {
                                getUser();
                                txtUserName.Clear();
                                txtEmail.Clear();
                                txtPassword.Clear();
                                txtConfirmPassword.Clear();
                                lockControl();
                                MessageBox.Show("Cập nhật user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi khi xoá dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                      
                    }
                  
                    break;
                default:
                    break;
            }
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lockControl();
            getUser();
            txtSearch.Clear();
            filterValue = "";
            clickFilterId = true;
            clickFilterUsername = true;
            clickFilterMaNV = true;
            clickFilterEmail = true;
            clickFilterTrangThai = true;
            clickFilterCreatedAt = true;
            clickFilterUpdateAt = true;
            filterId.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterUsername.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterEmail.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterTrangThai.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterMaNv.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterCreatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            filterUpdatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                DataTable dt = userController.search(keyword); ;
                dataGridViewUser.DataSource = dt;
            }
            else
            {
                getUser();
            }
        }

        private void orderByDESC(string value)
        {
            DataTable dt = userController.orderByDESC(value) ;
            dataGridViewUser.DataSource = dt;
        }
        private void orderByASC(string value)
        {
            DataTable dt = userController.orderByASC(value);
            dataGridViewUser.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = (int)Convert.ToUInt32(dataGridViewUser.Rows[index].Cells["dbId"].Value.ToString());
                txtUserName.Text = dataGridViewUser.Rows[index].Cells["dbUserName"].Value.ToString();
                txtEmail.Text = dataGridViewUser.Rows[index].Cells["dbEmail"].Value.ToString();
                txtPassword.Text = dataGridViewUser.Rows[index].Cells["dbPassword"].Value.ToString();
                txtConfirmPassword.Text = txtPassword.Text;
                cbTrangThai.Text = dataGridViewUser.Rows[index].Cells["dbTrangThai"].Value.ToString();
            }
        }

        private void filterId_Click(object sender, EventArgs e)
        {
            filterValue = "id";
            clickFilterId = !clickFilterId;
            if (clickFilterId == true)
            {
                filterId.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterId.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }

        private void filterTrangThai_Click(object sender, EventArgs e)
        {
            filterValue = "trangThai";
            clickFilterTrangThai = !clickFilterTrangThai;
            if (clickFilterTrangThai == true)
            {
                filterTrangThai.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterTrangThai.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }

        private void filterMaNv_Click(object sender, EventArgs e)
        {
            filterValue = "maNV";
            clickFilterMaNV = !clickFilterMaNV;
            if (clickFilterMaNV == true)
            {
                filterMaNv.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterMaNv.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }

        private void filterUsername_Click(object sender, EventArgs e)
        {
            filterValue = "username";
            clickFilterUsername = !clickFilterUsername;
            if (clickFilterUsername == true)
            {
                filterUsername.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterUsername.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }

        private void filterEmail_Click(object sender, EventArgs e)
        {
            filterValue = "email";
            clickFilterEmail = !clickFilterEmail;
            if (clickFilterEmail == true)
            {
                filterEmail.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterEmail.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }
        private void filterCreatedAt_Click(object sender, EventArgs e)
        {
            filterValue = "created_at";
            clickFilterCreatedAt = !clickFilterCreatedAt;
            if (clickFilterCreatedAt == true)
            {
                filterCreatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterCreatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }


        private void filterUpdatedAt_Click(object sender, EventArgs e)
        {
            filterValue = "updated_at";
            clickFilterUpdateAt = !clickFilterUpdateAt;
            if (clickFilterUpdateAt == true)
            {
                filterUpdatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
                orderByASC(filterValue);
            }
            else
            {
                filterUpdatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
                orderByDESC(filterValue);
            }
        }
    }
}
