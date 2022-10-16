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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureAnh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NVdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).BeginInit();
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
            this.NVdataGrid.Size = new System.Drawing.Size(1136, 208);
            this.NVdataGrid.TabIndex = 2;
            this.NVdataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NVdataGrid_CellMouseClick);
            // 
            // TxtMaNV
            // 
            this.TxtMaNV.Location = new System.Drawing.Point(366, 308);
            this.TxtMaNV.Name = "TxtMaNV";
            this.TxtMaNV.Size = new System.Drawing.Size(219, 27);
            this.TxtMaNV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // TxtDC
            // 
            this.TxtDC.Location = new System.Drawing.Point(812, 311);
            this.TxtDC.Name = "TxtDC";
            this.TxtDC.Size = new System.Drawing.Size(235, 27);
            this.TxtDC.TabIndex = 7;
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(366, 352);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(219, 27);
            this.TxtHoTen.TabIndex = 8;
            // 
            // TxtChucVu
            // 
            this.TxtChucVu.Location = new System.Drawing.Point(812, 362);
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
            this.CbGioiTinh.Location = new System.Drawing.Point(366, 405);
            this.CbGioiTinh.Name = "CbGioiTinh";
            this.CbGioiTinh.Size = new System.Drawing.Size(219, 28);
            this.CbGioiTinh.TabIndex = 10;
            // 
            // TxtMaKhu
            // 
            this.TxtMaKhu.Location = new System.Drawing.Point(812, 408);
            this.TxtMaKhu.Name = "TxtMaKhu";
            this.TxtMaKhu.Size = new System.Drawing.Size(235, 27);
            this.TxtMaKhu.TabIndex = 11;
            // 
            // TxtSDT
            // 
            this.TxtSDT.Location = new System.Drawing.Point(366, 468);
            this.TxtSDT.Name = "TxtSDT";
            this.TxtSDT.Size = new System.Drawing.Size(219, 27);
            this.TxtSDT.TabIndex = 12;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngay_Sinh.Location = new System.Drawing.Point(812, 468);
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.Size = new System.Drawing.Size(235, 27);
            this.Ngay_Sinh.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(386, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 31);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(516, 40);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(92, 31);
            this.btnTaiLai.TabIndex = 17;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(168, 551);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 43);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(354, 551);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 43);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(540, 551);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 43);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.label4.Location = new System.Drawing.Point(252, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Họ Tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã Khu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã nhân viên:";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 646);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureAnh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiem);
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
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NVdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).EndInit();
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
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox pictureAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}

