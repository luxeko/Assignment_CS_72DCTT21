namespace QuanLyKhuVuiChoi.View
{
    partial class Khu_Vui_Choi
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
            this.btTimKiem = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioDongCua = new System.Windows.Forms.TextBox();
            this.txtGioMoCua = new System.Windows.Forms.TextBox();
            this.txtGiaTE = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtGiaNL = new System.Windows.Forms.TextBox();
            this.txtMaKhu = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtTenKhu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvKhuVuiChoi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btRefesh = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTaoMoi = new FontAwesome.Sharp.IconButton();
            this.btCapNhat = new FontAwesome.Sharp.IconButton();
            this.btXoa = new FontAwesome.Sharp.IconButton();
            this.btLuu = new FontAwesome.Sharp.IconButton();
            this.btHuy = new FontAwesome.Sharp.IconButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuVuiChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btTimKiem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTimKiem.IconSize = 25;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(474, 47);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(131, 38);
            this.btTimKiem.TabIndex = 0;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtGioDongCua);
            this.groupBox1.Controls.Add(this.txtGioMoCua);
            this.groupBox1.Controls.Add(this.txtGiaTE);
            this.groupBox1.Controls.Add(this.txtViTri);
            this.groupBox1.Controls.Add(this.txtGiaNL);
            this.groupBox1.Controls.Add(this.txtMaKhu);
            this.groupBox1.Controls.Add(this.txtDienTich);
            this.groupBox1.Controls.Add(this.txtTenKhu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 746);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ KHU VUI CHƠI";
            // 
            // txtGioDongCua
            // 
            this.txtGioDongCua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioDongCua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGioDongCua.Location = new System.Drawing.Point(860, 683);
            this.txtGioDongCua.Name = "txtGioDongCua";
            this.txtGioDongCua.Size = new System.Drawing.Size(296, 34);
            this.txtGioDongCua.TabIndex = 8;
            // 
            // txtGioMoCua
            // 
            this.txtGioMoCua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioMoCua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGioMoCua.Location = new System.Drawing.Point(177, 681);
            this.txtGioMoCua.Name = "txtGioMoCua";
            this.txtGioMoCua.Size = new System.Drawing.Size(296, 34);
            this.txtGioMoCua.TabIndex = 8;
            // 
            // txtGiaTE
            // 
            this.txtGiaTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTE.Enabled = false;
            this.txtGiaTE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTE.Location = new System.Drawing.Point(860, 614);
            this.txtGiaTE.Name = "txtGiaTE";
            this.txtGiaTE.Size = new System.Drawing.Size(296, 34);
            this.txtGiaTE.TabIndex = 7;
            this.txtGiaTE.Text = "20000";
            // 
            // txtViTri
            // 
            this.txtViTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtViTri.Location = new System.Drawing.Point(177, 613);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(296, 34);
            this.txtViTri.TabIndex = 7;
            // 
            // txtGiaNL
            // 
            this.txtGiaNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaNL.Enabled = false;
            this.txtGiaNL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaNL.Location = new System.Drawing.Point(860, 543);
            this.txtGiaNL.Name = "txtGiaNL";
            this.txtGiaNL.Size = new System.Drawing.Size(296, 34);
            this.txtGiaNL.TabIndex = 6;
            this.txtGiaNL.Text = "50000";
            // 
            // txtMaKhu
            // 
            this.txtMaKhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaKhu.Location = new System.Drawing.Point(177, 542);
            this.txtMaKhu.Name = "txtMaKhu";
            this.txtMaKhu.Size = new System.Drawing.Size(296, 34);
            this.txtMaKhu.TabIndex = 6;
            // 
            // txtDienTich
            // 
            this.txtDienTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienTich.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDienTich.Location = new System.Drawing.Point(860, 477);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(296, 34);
            this.txtDienTich.TabIndex = 6;
            // 
            // txtTenKhu
            // 
            this.txtTenKhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenKhu.Location = new System.Drawing.Point(177, 476);
            this.txtTenKhu.Name = "txtTenKhu";
            this.txtTenKhu.Size = new System.Drawing.Size(296, 34);
            this.txtTenKhu.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(708, 687);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "Giờ đóng cửa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 689);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giờ mở cửa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(708, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giá TE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vị trí:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(708, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá NL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(708, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Diện tích:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvKhuVuiChoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btRefesh);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 396);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khu vui chơi";
            // 
            // dtgvKhuVuiChoi
            // 
            this.dtgvKhuVuiChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhuVuiChoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maKhu,
            this.tenKhu,
            this.viTri,
            this.dienTich,
            this.gioMo,
            this.gioDong,
            this.giaNL,
            this.giaTE});
            this.dtgvKhuVuiChoi.Location = new System.Drawing.Point(24, 113);
            this.dtgvKhuVuiChoi.Name = "dtgvKhuVuiChoi";
            this.dtgvKhuVuiChoi.RowHeadersWidth = 62;
            this.dtgvKhuVuiChoi.RowTemplate.Height = 33;
            this.dtgvKhuVuiChoi.Size = new System.Drawing.Size(1198, 262);
            this.dtgvKhuVuiChoi.TabIndex = 2;
            this.dtgvKhuVuiChoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhuVuiChoi_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "maKhu";
            this.maKhu.HeaderText = "Mã Khu";
            this.maKhu.MinimumWidth = 8;
            this.maKhu.Name = "maKhu";
            this.maKhu.Width = 150;
            // 
            // tenKhu
            // 
            this.tenKhu.DataPropertyName = "tenKhu";
            this.tenKhu.HeaderText = "Tên Khu";
            this.tenKhu.MinimumWidth = 8;
            this.tenKhu.Name = "tenKhu";
            this.tenKhu.Width = 150;
            // 
            // viTri
            // 
            this.viTri.DataPropertyName = "viTri";
            this.viTri.HeaderText = "Vị Trí";
            this.viTri.MinimumWidth = 8;
            this.viTri.Name = "viTri";
            this.viTri.Width = 150;
            // 
            // dienTich
            // 
            this.dienTich.DataPropertyName = "dienTich";
            this.dienTich.HeaderText = "Diện Tích";
            this.dienTich.MinimumWidth = 8;
            this.dienTich.Name = "dienTich";
            this.dienTich.Width = 150;
            // 
            // gioMo
            // 
            this.gioMo.DataPropertyName = "gioMo";
            this.gioMo.HeaderText = "Giờ Mở Cửa";
            this.gioMo.MinimumWidth = 8;
            this.gioMo.Name = "gioMo";
            this.gioMo.Width = 150;
            // 
            // gioDong
            // 
            this.gioDong.DataPropertyName = "gioDong";
            this.gioDong.HeaderText = "Giờ Đóng Cửa";
            this.gioDong.MinimumWidth = 8;
            this.gioDong.Name = "gioDong";
            this.gioDong.Width = 150;
            // 
            // giaNL
            // 
            this.giaNL.DataPropertyName = "giaNL";
            this.giaNL.HeaderText = "Giá Người Lớn";
            this.giaNL.MinimumWidth = 8;
            this.giaNL.Name = "giaNL";
            this.giaNL.Width = 150;
            // 
            // giaTE
            // 
            this.giaTE.DataPropertyName = "giaTE";
            this.giaTE.HeaderText = "Giá Trẻ Em";
            this.giaTE.MinimumWidth = 8;
            this.giaTE.Name = "giaTE";
            this.giaTE.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // btRefesh
            // 
            this.btRefesh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRefesh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btRefesh.IconColor = System.Drawing.Color.DodgerBlue;
            this.btRefesh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRefesh.IconSize = 25;
            this.btRefesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefesh.Location = new System.Drawing.Point(628, 47);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(131, 38);
            this.btRefesh.TabIndex = 0;
            this.btRefesh.Text = "Refesh";
            this.btRefesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefesh.UseVisualStyleBackColor = true;
            this.btRefesh.Click += new System.EventHandler(this.btRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(134, 49);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(296, 34);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "<Nhập tên khu>";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTaoMoi.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btTaoMoi.IconColor = System.Drawing.Color.LimeGreen;
            this.btTaoMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTaoMoi.IconSize = 25;
            this.btTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoMoi.Location = new System.Drawing.Point(39, 776);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(118, 38);
            this.btTaoMoi.TabIndex = 0;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCapNhat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btCapNhat.IconColor = System.Drawing.Color.SteelBlue;
            this.btCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCapNhat.IconSize = 25;
            this.btCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCapNhat.Location = new System.Drawing.Point(194, 778);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(118, 36);
            this.btCapNhat.TabIndex = 0;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btXoa.IconColor = System.Drawing.Color.Red;
            this.btXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btXoa.IconSize = 25;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(357, 778);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(118, 36);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btLuu.IconColor = System.Drawing.Color.LimeGreen;
            this.btLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLuu.IconSize = 25;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(888, 776);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(118, 36);
            this.btLuu.TabIndex = 0;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btHuy.IconColor = System.Drawing.Color.Red;
            this.btHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHuy.IconSize = 25;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(1040, 776);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(118, 36);
            this.btHuy.TabIndex = 0;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(514, 658);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(188, 37);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Khu_Vui_Choi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 848);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btTaoMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Khu_Vui_Choi";
            this.Text = "Khu_Vui_Choi";
            this.Load += new System.EventHandler(this.Khu_Vui_Choi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhuVuiChoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtGiaTE;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btRefesh;
        private FontAwesome.Sharp.IconButton btTaoMoi;
        private FontAwesome.Sharp.IconButton btCapNhat;
        private FontAwesome.Sharp.IconButton btXoa;
        private FontAwesome.Sharp.IconButton btLuu;
        private FontAwesome.Sharp.IconButton btHuy;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtMaKhu;
        private System.Windows.Forms.TextBox txtTenKhu;
        private System.Windows.Forms.TextBox txtGiaNL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGioDongCua;
        private System.Windows.Forms.TextBox txtGioMoCua;
        private System.Windows.Forms.DataGridView dtgvKhuVuiChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTE;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}