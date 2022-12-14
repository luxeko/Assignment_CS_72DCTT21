using btl2;
using FontAwesome.Sharp;
using QuanLyKhuVuiChoi.Cache;
using QuanLyKhuVuiChoi.Controller.Authentication;
using QuanLyKhuVuiChoi.Controller.Nhan_vien;
using QuanLyKhuVuiChoi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;

namespace QuanLyKhuVuiChoi
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        NhanVienController nhanVienController = new NhanVienController();

        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
        }
       
        private void navbar(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        // Struct
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 71, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        public void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void logoBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color4);
            Customer customer = new Customer();
            navbar(customer, content);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnKhuVuiChoi_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color4);
            Khu_Vui_Choi KhuVuiChoi = new Khu_Vui_Choi();
            navbar(KhuVuiChoi, content);
        }

        private void btnTroChoi_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color5);
            Tro_Choi TroChoi = new Tro_Choi();
            navbar(TroChoi, content);
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color6);
            Dichvu DichVu = new Dichvu();
            navbar(DichVu, content);
        }

        private void btnVe_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            Ticketsss tickets = new Ticketsss();
            navbar(tickets, content);
        }

        private void btnVaiTro_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
        }

        private void btnGiamGia_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color3);
            GiamGia markDown = new GiamGia();
            navbar(markDown, content);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            Dashboard dashboard = new Dashboard();
            navbar(dashboard, content);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color4);
            Profile profile = new Profile();
            navbar(profile, content);
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            lbHoTen.Text = UserLoginCache.email ;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
            User user = new User();
            navbar(user, content);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color3);
            NhanVien nhanVien = new NhanVien();
            navbar(nhanVien, content);
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {

        }
    }
}
