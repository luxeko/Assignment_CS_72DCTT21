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
    public partial class Login : Form
    {
        Login_Controller loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new Login_Controller();
            this.ActiveControl = userName;
            userName.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(200,255, 255, 255);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.userName.ForeColor = Color.Black;
                this.errorUsername.Visible = false;
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
                errorPassword.Visible = false;
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
            if(this.userName.Text == "")
            {
                this.errorUsername.Visible = true;
                this.userName.Focus();
                return;
            }
            
            if (this.passWord.Text == "")
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
                    if (row["trangThai"].ToString() == " Active")
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản chưa được cấp quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.passWord.Clear();
                    }
                }
            } 
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.passWord.Clear();
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
    }
}
