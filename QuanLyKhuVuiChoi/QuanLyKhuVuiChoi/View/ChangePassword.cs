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
    public partial class ChangePassword : Form
    {
        Login_Controller login_Controller = new Login_Controller();
        public ChangePassword()
        {
            InitializeComponent();
            this.ActiveControl = txtNewPassword;
            this.txtNewPassword.Focus();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            this.txtNewPassword.ForeColor = Color.Black;
            this.errorNewPassword.Visible = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.txtConfirmPassword.ForeColor = Color.Black;
            this.errorConfirmPassword.Visible = false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            this.txtNewPassword.SelectAll();
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            this.txtConfirmPassword.SelectAll();
        }

        private void btnShowNewPassword_Click(object sender, EventArgs e)
        {
            if(this.txtNewPassword.PasswordChar == '*')
            {
                this.txtNewPassword.PasswordChar = '\0';
                this.btnShowNewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }    
            else
            {
                this.txtNewPassword.PasswordChar = '*';
                this.btnShowNewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnShowConfPassword_Click(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.PasswordChar == '*')
            {
                this.txtConfirmPassword.PasswordChar = '\0';
                this.btnShowConfPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.txtConfirmPassword.PasswordChar = '*';
                this.btnShowConfPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(this.txtNewPassword.Text.Trim() == "")
            {
                this.errorNewPassword.Visible = true;
                this.txtNewPassword.Focus();
                return;
            }
            if (this.txtConfirmPassword.Text.Trim() == "" || this.txtConfirmPassword.Text.Trim() != this.txtNewPassword.Text.Trim())
            {
                this.errorConfirmPassword.Visible = true;
                this.txtConfirmPassword.Focus();
                return;
            }
            int id = UserLoginCache.Id;
            string username = UserLoginCache.username, email = UserLoginCache.email, maNV = UserLoginCache.maNV, password = this.txtNewPassword.Text.Trim();
            if(login_Controller.UpdatePassword(id, username, email, maNV, password))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
