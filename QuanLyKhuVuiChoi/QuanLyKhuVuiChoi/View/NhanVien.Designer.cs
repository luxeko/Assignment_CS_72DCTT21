namespace btl2
{
    partial class NhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.DirectoryServices.SortOption sortOption3 = new System.DirectoryServices.SortOption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.NVdataGrid = new System.Windows.Forms.DataGridView();
            this.TxtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDC = new System.Windows.Forms.TextBox();
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.TxtChucVu = new System.Windows.Forms.TextBox();
            this.CbGioiTinh = new System.Windows.Forms.ComboBox();
            this.TxtMaKhu = new System.Windows.Forms.TextBox();
            this.TxtSDT = new System.Windows.Forms.TextBox();
            this.Ngay_Sinh = new System.Windows.Forms.DateTimePicker();
            this.pictureAnh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.iconMaNV = new System.Windows.Forms.PictureBox();
            this.iconHoten = new System.Windows.Forms.PictureBox();
            this.iconSDT = new System.Windows.Forms.PictureBox();
            this.iconDC = new System.Windows.Forms.PictureBox();
            this.iconChucvu = new System.Windows.Forms.PictureBox();
            this.iconMakhu = new System.Windows.Forms.PictureBox();
            this.btTimKiem = new FontAwesome.Sharp.IconButton();
            this.btTaiLai = new FontAwesome.Sharp.IconButton();
            this.btThem = new FontAwesome.Sharp.IconButton();
            this.btSua = new FontAwesome.Sharp.IconButton();
            this.btXoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.NVdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHoten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMakhu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(130, 54);
            this.TxtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(300, 31);
            this.TxtTimKiem.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.Sort = sortOption3;
            // 
            // NVdataGrid
            // 
            this.NVdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVdataGrid.Location = new System.Drawing.Point(14, 96);
            this.NVdataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.NVdataGrid.Name = "NVdataGrid";
            this.NVdataGrid.RowHeadersWidth = 62;
            this.NVdataGrid.RowTemplate.Height = 28;
            this.NVdataGrid.Size = new System.Drawing.Size(1420, 260);
            this.NVdataGrid.TabIndex = 2;
            this.NVdataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NVdataGrid_CellMouseClick);
            // 
            // TxtMaNV
            // 
            this.TxtMaNV.Location = new System.Drawing.Point(458, 385);
            this.TxtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaNV.Name = "TxtMaNV";
            this.TxtMaNV.Size = new System.Drawing.Size(273, 31);
            this.TxtMaNV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // TxtDC
            // 
            this.TxtDC.Location = new System.Drawing.Point(1015, 389);
            this.TxtDC.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDC.Name = "TxtDC";
            this.TxtDC.Size = new System.Drawing.Size(293, 31);
            this.TxtDC.TabIndex = 7;
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(458, 440);
            this.TxtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(273, 31);
            this.TxtHoTen.TabIndex = 8;
            // 
            // TxtChucVu
            // 
            this.TxtChucVu.Location = new System.Drawing.Point(1015, 452);
            this.TxtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtChucVu.Name = "TxtChucVu";
            this.TxtChucVu.Size = new System.Drawing.Size(293, 31);
            this.TxtChucVu.TabIndex = 9;
            // 
            // CbGioiTinh
            // 
            this.CbGioiTinh.FormattingEnabled = true;
            this.CbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CbGioiTinh.Location = new System.Drawing.Point(458, 506);
            this.CbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.CbGioiTinh.Name = "CbGioiTinh";
            this.CbGioiTinh.Size = new System.Drawing.Size(273, 33);
            this.CbGioiTinh.TabIndex = 10;
            // 
            // TxtMaKhu
            // 
            this.TxtMaKhu.Location = new System.Drawing.Point(1015, 510);
            this.TxtMaKhu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaKhu.Name = "TxtMaKhu";
            this.TxtMaKhu.Size = new System.Drawing.Size(293, 31);
            this.TxtMaKhu.TabIndex = 11;
            // 
            // TxtSDT
            // 
            this.TxtSDT.Location = new System.Drawing.Point(458, 585);
            this.TxtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Size = new System.Drawing.Size(273, 31);
            this.TxtSDT.TabIndex = 12;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngay_Sinh.Location = new System.Drawing.Point(1015, 585);
            this.Ngay_Sinh.Margin = new System.Windows.Forms.Padding(4);
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.Size = new System.Drawing.Size(293, 31);
            this.Ngay_Sinh.TabIndex = 14;
            // 
            // pictureAnh
            // 
            this.pictureAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAnh.Location = new System.Drawing.Point(36, 385);
            this.pictureAnh.Margin = new System.Windows.Forms.Padding(4);
            this.pictureAnh.Name = "pictureAnh";
            this.pictureAnh.Size = new System.Drawing.Size(186, 253);
            this.pictureAnh.TabIndex = 21;
            this.pictureAnh.TabStop = false;
            this.pictureAnh.Click += new System.EventHandler(this.pictureAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Họ Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 515);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 590);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(871, 585);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(871, 456);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(871, 519);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã Khu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 389);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã nhân viên:";
            // 
            // iconMaNV
            // 
            this.iconMaNV.Enabled = false;
            this.iconMaNV.Image = ((System.Drawing.Image)(resources.GetObject("iconMaNV.Image")));
            this.iconMaNV.Location = new System.Drawing.Point(738, 385);
            this.iconMaNV.Name = "iconMaNV";
            this.iconMaNV.Size = new System.Drawing.Size(24, 24);
            this.iconMaNV.TabIndex = 32;
            this.iconMaNV.TabStop = false;
            // 
            // iconHoten
            // 
            this.iconHoten.Enabled = false;
            this.iconHoten.Image = ((System.Drawing.Image)(resources.GetObject("iconHoten.Image")));
            this.iconHoten.Location = new System.Drawing.Point(738, 440);
            this.iconHoten.Name = "iconHoten";
            this.iconHoten.Size = new System.Drawing.Size(24, 24);
            this.iconHoten.TabIndex = 33;
            this.iconHoten.TabStop = false;
            // 
            // iconSDT
            // 
            this.iconSDT.Image = ((System.Drawing.Image)(resources.GetObject("iconSDT.Image")));
            this.iconSDT.Location = new System.Drawing.Point(738, 585);
            this.iconSDT.Name = "iconSDT";
            this.iconSDT.Size = new System.Drawing.Size(24, 24);
            this.iconSDT.TabIndex = 35;
            this.iconSDT.TabStop = false;
            this.iconSDT.Visible = false;
            // 
            // iconDC
            // 
            this.iconDC.Enabled = false;
            this.iconDC.Image = ((System.Drawing.Image)(resources.GetObject("iconDC.Image")));
            this.iconDC.Location = new System.Drawing.Point(1315, 390);
            this.iconDC.Name = "iconDC";
            this.iconDC.Size = new System.Drawing.Size(24, 24);
            this.iconDC.TabIndex = 36;
            this.iconDC.TabStop = false;
            // 
            // iconChucvu
            // 
            this.iconChucvu.Enabled = false;
            this.iconChucvu.Image = ((System.Drawing.Image)(resources.GetObject("iconChucvu.Image")));
            this.iconChucvu.Location = new System.Drawing.Point(1315, 452);
            this.iconChucvu.Name = "iconChucvu";
            this.iconChucvu.Size = new System.Drawing.Size(24, 24);
            this.iconChucvu.TabIndex = 37;
            this.iconChucvu.TabStop = false;
            // 
            // iconMakhu
            // 
            this.iconMakhu.Enabled = false;
            this.iconMakhu.Image = ((System.Drawing.Image)(resources.GetObject("iconMakhu.Image")));
            this.iconMakhu.Location = new System.Drawing.Point(1315, 510);
            this.iconMakhu.Name = "iconMakhu";
            this.iconMakhu.Size = new System.Drawing.Size(24, 24);
            this.iconMakhu.TabIndex = 38;
            this.iconMakhu.TabStop = false;
            // 
            // btTimKiem
            // 
            this.btTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btTimKiem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btTimKiem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btTimKiem.IconSize = 24;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(458, 52);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btTimKiem.TabIndex = 39;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btTaiLai
            // 
            this.btTaiLai.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btTaiLai.IconColor = System.Drawing.Color.DodgerBlue;
            this.btTaiLai.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btTaiLai.IconSize = 24;
            this.btTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiLai.Location = new System.Drawing.Point(604, 53);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(112, 34);
            this.btTaiLai.TabIndex = 40;
            this.btTaiLai.Text = "Tải Lại";
            this.btTaiLai.UseVisualStyleBackColor = true;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // btThem
            // 
            this.btThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btThem.IconColor = System.Drawing.Color.LimeGreen;
            this.btThem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btThem.IconSize = 24;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(203, 699);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(120, 40);
            this.btThem.TabIndex = 41;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btSua.IconColor = System.Drawing.Color.DodgerBlue;
            this.btSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btSua.IconSize = 24;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(440, 699);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(120, 40);
            this.btSua.TabIndex = 42;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btXoa.IconColor = System.Drawing.Color.Red;
            this.btXoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btXoa.IconSize = 24;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(650, 699);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 40);
            this.btXoa.TabIndex = 43;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 808);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.iconMakhu);
            this.Controls.Add(this.iconChucvu);
            this.Controls.Add(this.iconDC);
            this.Controls.Add(this.iconSDT);
            this.Controls.Add(this.iconHoten);
            this.Controls.Add(this.iconMaNV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureAnh);
            this.Controls.Add(this.Ngay_Sinh);
            this.Controls.Add(this.TxtSDT);
            this.Controls.Add(this.TxtMaKhu);
            this.Controls.Add(this.CbGioiTinh);
            this.Controls.Add(this.TxtChucVu);
            this.Controls.Add(this.TxtHoTen);
            this.Controls.Add(this.TxtDC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMaNV);
            this.Controls.Add(this.NVdataGrid);
            this.Controls.Add(this.TxtTimKiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NVdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHoten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMakhu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView NVdataGrid;
        private System.Windows.Forms.TextBox TxtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDC;
        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.TextBox TxtChucVu;
        private System.Windows.Forms.ComboBox CbGioiTinh;
        private System.Windows.Forms.TextBox TxtMaKhu;
        private System.Windows.Forms.TextBox TxtSDT;
        private System.Windows.Forms.DateTimePicker Ngay_Sinh;
        private System.Windows.Forms.PictureBox pictureAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox iconMaNV;
        private System.Windows.Forms.PictureBox iconHoten;
        private System.Windows.Forms.PictureBox iconSDT;
        private System.Windows.Forms.PictureBox iconDC;
        private System.Windows.Forms.PictureBox iconChucvu;
        private System.Windows.Forms.PictureBox iconMakhu;
        private FontAwesome.Sharp.IconButton btTimKiem;
        private FontAwesome.Sharp.IconButton btTaiLai;
        private FontAwesome.Sharp.IconButton btThem;
        private FontAwesome.Sharp.IconButton btSua;
        private FontAwesome.Sharp.IconButton btXoa;
    }
}

