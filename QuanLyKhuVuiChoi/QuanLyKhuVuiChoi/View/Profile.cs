using FontAwesome.Sharp;
using QuanLyKhuVuiChoi.Cache;
using QuanLyKhuVuiChoi.Controller.Authentication;
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
    public partial class Profile : Form
    {
        Login_Controller login_Controller;
        string flag = "profile";
        bool resultCheck = false;

        public Profile()
        {
            InitializeComponent();
            login_Controller = new Login_Controller();
        }

        private void activeButton(IconButton currentBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.MenuHighlight;
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }
        public void DisableButton(IconButton currentBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Gainsboro;
                currentBtn.ForeColor = Color.Black;
                currentBtn.IconColor = Color.Black;
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            cbcGioiTinh.Items.Insert(0, " -- Chọn --");
            cbcGioiTinh.Items.Insert(1, " Nam");
            cbcGioiTinh.Items.Insert(2, " Nữ");
            lockControl();
            activeButton(btnProfile);

            txtHoTen.Text = UserLoginCache.hoTen;
            txtDiaChi.Text = UserLoginCache.diaChi;
            txtSoDT.Text = UserLoginCache.soDT;
            dateTimeBirthDay.Value = UserLoginCache.ngaySinh;
            username.Text = UserLoginCache.username;
            maNV.Text = UserLoginCache.maNV;
            if (UserLoginCache.chucVu == "TN")
            {
                txtChucVu.Text = "Thu ngân";
            }
            else if (UserLoginCache.chucVu == "DV")
            {
                txtChucVu.Text = "Dịch vụ";
            }
            else if (UserLoginCache.chucVu == "LC")
            {
                txtChucVu.Text = "Lao công";
            }
            else if (UserLoginCache.chucVu == "BV")
            {
                txtChucVu.Text = "Bảo vệ";
            }
            if (UserLoginCache.gioiTinh == "Male")
            {
                cbcGioiTinh.SelectedIndex = 1;
            }
            else if (UserLoginCache.gioiTinh == "Famale")
            {
                cbcGioiTinh.SelectedIndex = 2;
            }

        }

        private void lockControl()
        {
            txtHoTen.ReadOnly = true;
            dateTimeBirthDay.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtChucVu.ReadOnly = true;
            cbcGioiTinh.Enabled = false;
            txtSoDT.ReadOnly = true;
            if (UserLoginCache.gioiTinh == "Male")
            {
                cbcGioiTinh.SelectedIndex = 1;
            }
            else if (UserLoginCache.gioiTinh == "Famale")
            {
                cbcGioiTinh.SelectedIndex = 2;
            }
            btnChinhSua.Focus();

            txtCurrentPassword.ReadOnly = true;
            txtNewPassword.ReadOnly = true;
            txtConfPassword.ReadOnly = true;
            showCurrentPass.Enabled = false;
            showNewpass.Enabled = false;
            showConfPass.Enabled = false;

        }

        private void unlockControl()
        {
            txtHoTen.ReadOnly = false;
            dateTimeBirthDay.Enabled = true;
            txtDiaChi.ReadOnly = false;
            cbcGioiTinh.Enabled = true;
            txtSoDT.ReadOnly = false;

            txtHoTen.Focus();
            txtCurrentPassword.ReadOnly = false;
            txtNewPassword.ReadOnly = false;
            txtConfPassword.ReadOnly = false;
            showCurrentPass.Enabled = true;
            showNewpass.Enabled = true;
            showConfPass.Enabled = true;
        }

        private bool checkDataProfile()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                errHoTen.Text = "Vui lòng nhập họ và tên";
                return false;
            }
            if (string.IsNullOrEmpty(txtSoDT.Text))
            {
                errSoDT.Text = "Vui lòng nhập số điện thoại";
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                errDiaChi.Text = "Vui lòng nhập địa chỉ";
                return false;
            }
            if (cbcGioiTinh.SelectedIndex != 1 && cbcGioiTinh.SelectedIndex != 2)
            {
                errGioiTinh.Text = "Vui lòng chọn giới tính";
                cbcGioiTinh.Focus();
                return false;
            }
            return true;
        }
        private bool checkDataPassword()
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                errCurrentPassword.Text = "Vui lòng nhập mật khẩu";
                txtCurrentPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errNewPassword.Text = "Vui lòng nhập mật khẩu mới";
                txtNewPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtConfPassword.Text))
            {
                errConfPassword.Text = "Vui lòng nhập lại mật khẩu";
                txtConfPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            unlockControl();
            btnChinhSua.Visible = false;
            btnLuuProfile.Visible = true;
        }

        private void btnLuuProfile_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case "profile":
                    if (checkDataProfile())
                    {
                        string hoTen = txtHoTen.Text, diaChi = txtDiaChi.Text, soDT = txtSoDT.Text;
                        string gioiTinh;
                        DateTime birthDay = dateTimeBirthDay.Value;

                        if (cbcGioiTinh.SelectedItem.ToString().Trim() == "Nam")
                        {
                            gioiTinh = "Male";
                        }
                        else
                        {
                            gioiTinh = "Famale";
                        }

                        if (login_Controller.UpdateProfile(UserLoginCache.maNV, hoTen, gioiTinh, birthDay, soDT, diaChi))
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserLoginCache.hoTen = txtHoTen.Text;
                            UserLoginCache.gioiTinh = cbcGioiTinh.Text;
                            UserLoginCache.ngaySinh = birthDay;
                            UserLoginCache.soDT = txtSoDT.Text;
                            UserLoginCache.diaChi = txtDiaChi.Text;
                            lockControl();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    break;
                case "password":
                    if (resultCheck == false)
                    {
                        MessageBox.Show("Vui lòng kiểm tra mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkDataPassword() && txtConfPassword.Text == txtNewPassword.Text)
                        {
                            string password = txtNewPassword.Text;
                            if (login_Controller.UpdatePassword(UserLoginCache.Id, UserLoginCache.username, UserLoginCache.email, UserLoginCache.maNV, password))
                            {
                                txtNewPassword.Clear();
                                txtConfPassword.Clear();
                                txtCurrentPassword.Clear();
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                default:
                    break;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            btnChinhSua.Visible = true;
            btnLuuProfile.Visible = false;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            errHoTen.Visible = false;
            errHoTen.Text = "";
        }

        private void mskBirthDay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errBirthDay.Visible = false;
            errBirthDay.Text = "";
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            errSoDT.Visible = false;
            errSoDT.Text = "";
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            errDiaChi.Visible = false;
            errDiaChi.Text = "";
        }

        private void cbcGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            errGioiTinh.Visible = false;
            errGioiTinh.Text = "";
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            activeButton(btnProfile);
            DisableButton(btnPassword);
            flag = "profile";
            groupBox4.Visible = false;
        }

        private void btnPassword_Click_1(object sender, EventArgs e)
        {
            activeButton(btnPassword);
            DisableButton(btnProfile);
            flag = "password";
            groupBox4.Visible = true;
        }

        private void checkPassword_Click(object sender, EventArgs e)
        {
            string password = txtCurrentPassword.Text;
            bool check = login_Controller.CheckPassword(password, UserLoginCache.Id);
            if (check)
            {
                errCurrentPassword.Visible = true;
                errCurrentPassword.Text = "Mật khẩu chính xác";
                errCurrentPassword.ForeColor = Color.LimeGreen;
                resultCheck = true;
            }
            else
            {
                errCurrentPassword.Visible = true;
                errCurrentPassword.Text = "Mật khẩu không đúng";
                errCurrentPassword.ForeColor = Color.Red;
                txtCurrentPassword.Focus();
                resultCheck = false;
                return;
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            errCurrentPassword.Visible = false;
            errCurrentPassword.Text = "";
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            errNewPassword.Visible = false;
            errNewPassword.Text = "";
        }

        private void txtConfPassword_TextChanged(object sender, EventArgs e)
        {
            errConfPassword.Visible = false;
            errConfPassword.Text = "";
        }

        private void showCurrentPass_Click(object sender, EventArgs e)
        {
            if (this.txtCurrentPassword.PasswordChar == '*')
            {
                this.txtCurrentPassword.PasswordChar = '\0';
                this.showCurrentPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.txtCurrentPassword.PasswordChar = '*';
                this.showCurrentPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void showNewpass_Click(object sender, EventArgs e)
        {
            if (this.txtNewPassword.PasswordChar == '*')
            {
                this.txtNewPassword.PasswordChar = '\0';
                this.showNewpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.txtNewPassword.PasswordChar = '*';
                this.showNewpass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void showConfPass_Click(object sender, EventArgs e)
        {
            if (this.txtConfPassword.PasswordChar == '*')
            {
                this.txtConfPassword.PasswordChar = '\0';
                this.showConfPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.txtConfPassword.PasswordChar = '*';
                this.showConfPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
    }
}
