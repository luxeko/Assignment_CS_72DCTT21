namespace QuanLyKhuVuiChoi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnGiamGia = new FontAwesome.Sharp.IconButton();
            this.btnVaiTro = new FontAwesome.Sharp.IconButton();
            this.btnVe = new FontAwesome.Sharp.IconButton();
            this.btnDichVu = new FontAwesome.Sharp.IconButton();
            this.btnTroChoi = new FontAwesome.Sharp.IconButton();
            this.btnKhuVuiChoi = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.content = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 782);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 78);
            this.panel2.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 32;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 78);
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Controls.Add(this.btnGiamGia);
            this.panel1.Controls.Add(this.btnVaiTro);
            this.panel1.Controls.Add(this.btnVe);
            this.panel1.Controls.Add(this.btnDichVu);
            this.panel1.Controls.Add(this.btnTroChoi);
            this.panel1.Controls.Add(this.btnKhuVuiChoi);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 574);
            this.panel1.TabIndex = 0;
            // 
            // profileBtn
            // 
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.profileBtn.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.profileBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.profileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileBtn.IconSize = 32;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 500);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(220, 50);
            this.profileBtn.TabIndex = 22;
            this.profileBtn.Text = "Hồ sơ cá nhân";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.btnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.IconSize = 32;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 450);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(220, 50);
            this.btnKhachHang.TabIndex = 21;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiamGia.FlatAppearance.BorderSize = 0;
            this.btnGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiamGia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGiamGia.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnGiamGia.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGiamGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGiamGia.IconSize = 32;
            this.btnGiamGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiamGia.Location = new System.Drawing.Point(0, 400);

            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(220, 50);
            this.btnGiamGia.TabIndex = 20;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiamGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnVaiTro
            // 
            this.btnVaiTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVaiTro.FlatAppearance.BorderSize = 0;
            this.btnVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaiTro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVaiTro.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
            this.btnVaiTro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVaiTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVaiTro.IconSize = 32;
            this.btnVaiTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaiTro.Location = new System.Drawing.Point(0, 350);

            this.btnVaiTro.Name = "btnVaiTro";
            this.btnVaiTro.Size = new System.Drawing.Size(220, 50);
            this.btnVaiTro.TabIndex = 19;
            this.btnVaiTro.Text = "Vai trò";
            this.btnVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaiTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVaiTro.UseVisualStyleBackColor = true;
            // 
            // btnVe
            // 
            this.btnVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVe.FlatAppearance.BorderSize = 0;
            this.btnVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVe.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnVe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVe.IconSize = 32;
            this.btnVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVe.Location = new System.Drawing.Point(0, 300);

            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(220, 50);
            this.btnVe.TabIndex = 18;
            this.btnVe.Text = "Vé ";
            this.btnVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVe.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDichVu.IconChar = FontAwesome.Sharp.IconChar.Award;
            this.btnDichVu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDichVu.IconSize = 32;
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(0, 250);

            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(220, 50);
            this.btnDichVu.TabIndex = 17;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // btnTroChoi
            // 
            this.btnTroChoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTroChoi.FlatAppearance.BorderSize = 0;
            this.btnTroChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroChoi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTroChoi.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnTroChoi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTroChoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroChoi.IconSize = 32;
            this.btnTroChoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroChoi.Location = new System.Drawing.Point(0, 200);

            this.btnTroChoi.Name = "btnTroChoi";
            this.btnTroChoi.Size = new System.Drawing.Size(220, 50);
            this.btnTroChoi.TabIndex = 16;
            this.btnTroChoi.Text = "Trò chơi";
            this.btnTroChoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroChoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTroChoi.UseVisualStyleBackColor = true;
            // 
            // btnKhuVuiChoi
            // 
            this.btnKhuVuiChoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhuVuiChoi.FlatAppearance.BorderSize = 0;
            this.btnKhuVuiChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuVuiChoi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhuVuiChoi.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.btnKhuVuiChoi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhuVuiChoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhuVuiChoi.IconSize = 32;
            this.btnKhuVuiChoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuVuiChoi.Location = new System.Drawing.Point(0, 150);

            this.btnKhuVuiChoi.Name = "btnKhuVuiChoi";
            this.btnKhuVuiChoi.Size = new System.Drawing.Size(220, 50);
            this.btnKhuVuiChoi.TabIndex = 15;
            this.btnKhuVuiChoi.Text = "Khu vui chơi";
            this.btnKhuVuiChoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuVuiChoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhuVuiChoi.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 32;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 100);

            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(220, 50);
            this.btnNhanVien.TabIndex = 14;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 50);

            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(220, 50);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "Người dùng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);

            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 125);
            this.panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(216, 65);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "User";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(220, 0);

            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1062, 782);
            this.content.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.btnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.IconSize = 32;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 706);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(275, 62);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 782);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khu vui chơi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnGiamGia;
        private FontAwesome.Sharp.IconButton btnVaiTro;
        private FontAwesome.Sharp.IconButton btnVe;
        private FontAwesome.Sharp.IconButton btnDichVu;
        private FontAwesome.Sharp.IconButton btnTroChoi;
        private FontAwesome.Sharp.IconButton btnKhuVuiChoi;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton profileBtn;
    }
}