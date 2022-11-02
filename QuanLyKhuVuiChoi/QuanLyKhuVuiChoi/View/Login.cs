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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyKhuVuiChoi.View
{
    public partial class Login : Form
    {
        Login_Controller loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new Login_Controller();
            this.ActiveControl = userName;
            this.userName.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.userName.ForeColor = Color.Black;
                this.errorUsername.Visible = false;
                this.errorMessage.Visible = false;
            }
            catch
            {

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.passWord.ForeColor = Color.Black;
                this.errorPassword.Visible = false;
                this.errorMessage.Visible = false;
            }
            catch
            {

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.userName.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.passWord.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.userName.Text.Trim() == "")
            {
                this.errorUsername.Visible = true;
                this.userName.Focus();
                return;
            }

            if (this.passWord.Text.Trim() == "")
            {
                this.errorPassword.Visible = true;
                this.passWord.Focus();
                return;
            }

            string userName = this.userName.Text, passWord = this.passWord.Text;
            DataTable dt = loginController.login(userName, passWord);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["trangThai"].ToString().Trim() == "Active")
                    {
                        Main main = new Main();
                        UserLoginCache.Id = Convert.ToInt32(row["id"]);
                        UserLoginCache.username = row["username"].ToString().Trim();
                        UserLoginCache.email = row["email"].ToString().Trim();
                        UserLoginCache.maNV = row["maNV"].ToString().Trim();
                        UserLoginCache.hoTen = row["hoTen"].ToString().Trim();
                        UserLoginCache.ngaySinh = Convert.ToDateTime(row["ngaySinh"]);
                        UserLoginCache.chucVu = row["chucVu"].ToString().Trim();
                        UserLoginCache.soDT = row["soDT"].ToString().Trim();
                        UserLoginCache.gioiTinh = row["gioiTinh"].ToString().Trim();
                        UserLoginCache.diaChi = row["diaChi"].ToString().Trim();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.errorMessage.Visible = true;
                        this.errorMessage.Text = "Tài khoản chưa được cấp quyền truy cập";
                    }
                }
            }
            else
            {
                this.errorMessage.Text = "Tài khoản hoặc mật khẩu không chính xác";
                this.errorMessage.Visible = true;
            }
        }

        private void passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (this.passWord.PasswordChar == '*')
            {
                this.passWord.PasswordChar = '\0';
                this.showPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.passWord.PasswordChar = '*';
                this.showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
