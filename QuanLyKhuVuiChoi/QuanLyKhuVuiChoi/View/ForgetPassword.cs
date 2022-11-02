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
    public partial class ForgetPassword : Form
    {
        Login_Controller loginController = new Login_Controller();
        public ForgetPassword()
        {
            InitializeComponent();
            this.ActiveControl = this.userName;
            this.userName.Focus();
        }

        private void userName_TextChanged(object sender, EventArgs e)
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

        private void email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.email.ForeColor = Color.Black;
                this.errorEmail.Visible = false;
                this.errorMessage.Visible = false;
            }
            catch
            {

            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtCCCD.ForeColor = Color.Black;
                this.errorCCCD.Visible = false;
                this.errorMessage.Visible = false;
            }
            catch
            {

            }
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMaNv.ForeColor = Color.Black;
                this.errorMaNV.Visible = false;
                this.errorMessage.Visible = false;
            }
            catch
            {

            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

  
        private void userName_Click(object sender, EventArgs e)
        {
            this.userName.SelectAll();
        }

        private void email_Click(object sender, EventArgs e)
        {
            this.email.SelectAll();
        }

        private void txtCCCD_Click(object sender, EventArgs e)
        {
            this.txtCCCD.SelectAll();
        }

        private void txtMaNv_Click(object sender, EventArgs e)
        {
            this.txtMaNv.SelectAll();
        }

        private void btnCheckAccount_Click(object sender, EventArgs e)
        {
            if (this.userName.Text.Trim() == "")
            {
                this.errorUsername.Visible = true;
                this.userName.Focus();
                return;
            }

            if (this.email.Text.Trim() == "")
            {
                this.errorEmail.Visible = true;
                this.email.Focus();
                return;
            }

            if (this.txtMaNv.Text.Trim() == "")
            {
                this.errorMaNV.Visible = true;
                this.txtMaNv.Focus();
                return;
            }

            if (this.txtCCCD.Text.Trim() == "")
            {
                this.errorCCCD.Visible = true;
                this.txtCCCD.Focus();
            }

            string userName = this.userName.Text,
                    email = this.email.Text,
                    cccd = this.txtCCCD.Text,
                    maNV = this.txtMaNv.Text;
            DataTable dt = loginController.CheckAccount(userName, email, cccd, maNV);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    UserLoginCache.Id = Convert.ToInt32(row["id"]);
                    UserLoginCache.maNV = row["maNV"].ToString();
                    UserLoginCache.username = row["username"].ToString();
                    UserLoginCache.email = row["email"].ToString();
                    
                }
                this.Hide();
                ChangePassword changePassword = new ChangePassword();
                changePassword.Show();
            }
            else
            {
                this.errorMessage.Text = "Thông tin không chính xác";
                this.errorMessage.Visible = true;
            }
        }

        private void btnChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckAccount.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckAccount.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckAccount.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtMaNv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckAccount.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
