using FontAwesome.Sharp;
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
using Color = System.Drawing.Color;

namespace QuanLyKhuVuiChoi
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
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
            //form.Size = panel.Size;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        // Struct
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,71,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
        }
        public void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
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
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }    
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            Dashboard dashboard = new Dashboard();
            navbar(dashboard, content);
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
        }

        private void btnKhuVuiChoi_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color4);
        }

        private void btnTroChoi_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color5);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color6);
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            Tickets tickets = new Tickets();
            navbar(tickets, content);
        }

        private void btnVaiTro_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color3);
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

    }
}
