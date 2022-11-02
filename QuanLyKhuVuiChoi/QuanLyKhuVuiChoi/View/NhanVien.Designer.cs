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
            System.DirectoryServices.SortOption sortOption1 = new System.DirectoryServices.SortOption();
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
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtLuong = new System.Windows.Forms.TextBox();
            this.iconLuong = new System.Windows.Forms.PictureBox();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.NVdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHoten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMakhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(104, 43);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(241, 27);
            this.TxtTimKiem.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.Sort = sortOption1;
            // 
            // NVdataGrid
            // 
            this.NVdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVdataGrid.Location = new System.Drawing.Point(11, 77);
            this.NVdataGrid.Name = "NVdataGrid";
            this.NVdataGrid.RowHeadersWidth = 62;
            this.NVdataGrid.RowTemplate.Height = 28;
            this.NVdataGrid.Size = new System.Drawing.Size(1039, 208);
            this.NVdataGrid.TabIndex = 2;
            this.NVdataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVdataGrid_CellContentClick);
            this.NVdataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NVdataGrid_CellMouseClick);
            // 
            // TxtMaNV
            // 
            this.TxtMaNV.Location = new System.Drawing.Point(338, 308);
            this.TxtMaNV.Name = "TxtMaNV";
            this.TxtMaNV.Size = new System.Drawing.Size(219, 27);
            this.TxtMaNV.TabIndex = 4;
            this.TxtMaNV.TextChanged += new System.EventHandler(this.TxtMaNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // TxtDC
            // 
            this.TxtDC.Location = new System.Drawing.Point(763, 305);
            this.TxtDC.Name = "TxtDC";
            this.TxtDC.Size = new System.Drawing.Size(235, 27);
            this.TxtDC.TabIndex = 7;
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(338, 352);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(219, 27);
            this.TxtHoTen.TabIndex = 8;
            // 
            // TxtChucVu
            // 
            this.TxtChucVu.Location = new System.Drawing.Point(763, 356);
            this.TxtChucVu.Name = "TxtChucVu";
            this.TxtChucVu.Size = new System.Drawing.Size(235, 27);
            this.TxtChucVu.TabIndex = 9;
            // 
            // CbGioiTinh
            // 
            this.CbGioiTinh.FormattingEnabled = true;
            this.CbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CbGioiTinh.Location = new System.Drawing.Point(338, 405);
            this.CbGioiTinh.Name = "CbGioiTinh";
            this.CbGioiTinh.Size = new System.Drawing.Size(219, 28);
            this.CbGioiTinh.TabIndex = 10;
            // 
            // TxtMaKhu
            // 
            this.TxtMaKhu.Location = new System.Drawing.Point(763, 402);
            this.TxtMaKhu.Name = "TxtMaKhu";
            this.TxtMaKhu.Size = new System.Drawing.Size(235, 27);
            this.TxtMaKhu.TabIndex = 11;
            // 
            // TxtSDT
            // 
            this.TxtSDT.Location = new System.Drawing.Point(338, 468);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Size = new System.Drawing.Size(219, 27);
            this.TxtSDT.TabIndex = 12;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngay_Sinh.Location = new System.Drawing.Point(763, 462);
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.Size = new System.Drawing.Size(235, 27);
            this.Ngay_Sinh.TabIndex = 14;
            this.Ngay_Sinh.ValueChanged += new System.EventHandler(this.Ngay_Sinh_ValueChanged);
            // 
            // pictureAnh
            // 
            this.pictureAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAnh.Location = new System.Drawing.Point(29, 308);
            this.pictureAnh.Name = "pictureAnh";
            this.pictureAnh.Size = new System.Drawing.Size(149, 203);
            this.pictureAnh.TabIndex = 21;
            this.pictureAnh.TabStop = false;
            this.pictureAnh.Click += new System.EventHandler(this.pictureAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Họ Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã Khu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã nhân viên:";
            // 
            // iconMaNV
            // 
            this.iconMaNV.Enabled = false;
            this.iconMaNV.Image = ((System.Drawing.Image)(resources.GetObject("iconMaNV.Image")));
            this.iconMaNV.Location = new System.Drawing.Point(562, 308);
            this.iconMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.iconMaNV.Name = "iconMaNV";
            this.iconMaNV.Size = new System.Drawing.Size(19, 19);
            this.iconMaNV.TabIndex = 32;
            this.iconMaNV.TabStop = false;
            // 
            // iconHoten
            // 
            this.iconHoten.Enabled = false;
            this.iconHoten.Image = ((System.Drawing.Image)(resources.GetObject("iconHoten.Image")));
            this.iconHoten.Location = new System.Drawing.Point(562, 352);
            this.iconHoten.Margin = new System.Windows.Forms.Padding(2);
            this.iconHoten.Name = "iconHoten";
            this.iconHoten.Size = new System.Drawing.Size(19, 19);
            this.iconHoten.TabIndex = 33;
            this.iconHoten.TabStop = false;
            // 
            // iconSDT
            // 
            this.iconSDT.Image = ((System.Drawing.Image)(resources.GetObject("iconSDT.Image")));
            this.iconSDT.Location = new System.Drawing.Point(562, 468);
            this.iconSDT.Margin = new System.Windows.Forms.Padding(2);
            this.iconSDT.Name = "iconSDT";
            this.iconSDT.Size = new System.Drawing.Size(19, 19);
            this.iconSDT.TabIndex = 35;
            this.iconSDT.TabStop = false;
            this.iconSDT.Visible = false;
            // 
            // iconDC
            // 
            this.iconDC.Enabled = false;
            this.iconDC.Image = ((System.Drawing.Image)(resources.GetObject("iconDC.Image")));
            this.iconDC.Location = new System.Drawing.Point(1003, 306);
            this.iconDC.Margin = new System.Windows.Forms.Padding(2);
            this.iconDC.Name = "iconDC";
            this.iconDC.Size = new System.Drawing.Size(19, 19);
            this.iconDC.TabIndex = 36;
            this.iconDC.TabStop = false;
            // 
            // iconChucvu
            // 
            this.iconChucvu.Enabled = false;
            this.iconChucvu.Image = ((System.Drawing.Image)(resources.GetObject("iconChucvu.Image")));
            this.iconChucvu.Location = new System.Drawing.Point(1003, 356);
            this.iconChucvu.Margin = new System.Windows.Forms.Padding(2);
            this.iconChucvu.Name = "iconChucvu";
            this.iconChucvu.Size = new System.Drawing.Size(19, 19);
            this.iconChucvu.TabIndex = 37;
            this.iconChucvu.TabStop = false;
            // 
            // iconMakhu
            // 
            this.iconMakhu.Enabled = false;
            this.iconMakhu.Image = ((System.Drawing.Image)(resources.GetObject("iconMakhu.Image")));
            this.iconMakhu.Location = new System.Drawing.Point(1003, 402);
            this.iconMakhu.Margin = new System.Windows.Forms.Padding(2);
            this.iconMakhu.Name = "iconMakhu";
            this.iconMakhu.Size = new System.Drawing.Size(19, 19);
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
            this.btTimKiem.Location = new System.Drawing.Point(366, 42);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 27);
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
            this.btTaiLai.Location = new System.Drawing.Point(483, 42);
            this.btTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(98, 27);
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
            this.btThem.Location = new System.Drawing.Point(27, 631);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 32);
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
            this.btSua.Location = new System.Drawing.Point(176, 631);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 32);
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
            this.btXoa.Location = new System.Drawing.Point(328, 631);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 32);
            this.btXoa.TabIndex = 43;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLuu.IconSize = 24;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(812, 631);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 32);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnHuy.IconColor = System.Drawing.Color.Red;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHuy.IconSize = 24;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(944, 631);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 32);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Lương cơ bản:";
            // 
            // TxtLuong
            // 
            this.TxtLuong.Location = new System.Drawing.Point(338, 517);
            this.TxtLuong.Name = "TxtLuong";
            this.TxtLuong.Size = new System.Drawing.Size(219, 27);
            this.TxtLuong.TabIndex = 47;
            // 
            // iconLuong
            // 
            this.iconLuong.Image = ((System.Drawing.Image)(resources.GetObject("iconLuong.Image")));
            this.iconLuong.Location = new System.Drawing.Point(562, 522);
            this.iconLuong.Margin = new System.Windows.Forms.Padding(2);
            this.iconLuong.Name = "iconLuong";
            this.iconLuong.Size = new System.Drawing.Size(19, 19);
            this.iconLuong.TabIndex = 48;
            this.iconLuong.TabStop = false;
            this.iconLuong.Visible = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnXuatExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnXuatExcel.IconSize = 24;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(950, 39);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(101, 27);
            this.btnXuatExcel.TabIndex = 49;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 695);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.iconLuong);
            this.Controls.Add(this.TxtLuong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.iconLuong)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtLuong;
        private System.Windows.Forms.PictureBox iconLuong;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
    }
}

