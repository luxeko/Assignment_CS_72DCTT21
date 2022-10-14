using QuanLyKhuVuiChoi.Controller.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public User()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void User_Load(object sender, EventArgs e)
        {
            getUser();
        }

       private void getUser()
       {
            DataTable dt = userController.getUser();
            dataGridView1.DataSource = dt;
        }    
    }
}
