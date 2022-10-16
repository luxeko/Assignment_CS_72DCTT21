namespace QuanLyKhuVuiChoi.View
{
    partial class tro_choi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaKhu = new System.Windows.Forms.ComboBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtTenTroChoi = new System.Windows.Forms.TextBox();
            this.txtMaTroChoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvTroChoi = new Zuby.ADGV.AdvancedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTroChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTroChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btRefesh = new FontAwesome.Sharp.IconButton();
            this.btTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btHuy = new FontAwesome.Sharp.IconButton();
            this.btLuu = new FontAwesome.Sharp.IconButton();
            this.btXoa = new FontAwesome.Sharp.IconButton();
            this.btTaoMoi = new FontAwesome.Sharp.IconButton();
            this.btCapNhat = new FontAwesome.Sharp.IconButton();
            this.MaTroChoi_ERR = new System.Windows.Forms.ErrorProvider(this.components);
            this.TenTroChoi_ERR = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaKhu_ERR = new System.Windows.Forms.ErrorProvider(this.components);
            this.ViTri_ERR = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTroChoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaTroChoi_ERR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTroChoi_ERR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhu_ERR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViTri_ERR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaKhu);
            this.groupBox1.Controls.Add(this.txtViTri);
            this.groupBox1.Controls.Add(this.txtTenTroChoi);
            this.groupBox1.Controls.Add(this.txtMaTroChoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 746);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ TRÒ CHƠI";
            // 
            // cbMaKhu
            // 
            this.cbMaKhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMaKhu.FormattingEnabled = true;
            this.cbMaKhu.Location = new System.Drawing.Point(860, 516);
            this.cbMaKhu.Name = "cbMaKhu";
            this.cbMaKhu.Size = new System.Drawing.Size(296, 36);
            this.cbMaKhu.TabIndex = 8;
            // 
            // txtViTri
            // 
            this.txtViTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtViTri.Location = new System.Drawing.Point(860, 640);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(296, 34);
            this.txtViTri.TabIndex = 7;
            // 
            // txtTenTroChoi
            // 
            this.txtTenTroChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTroChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenTroChoi.Location = new System.Drawing.Point(192, 642);
            this.txtTenTroChoi.Name = "txtTenTroChoi";
            this.txtTenTroChoi.Size = new System.Drawing.Size(296, 34);
            this.txtTenTroChoi.TabIndex = 6;
            // 
            // txtMaTroChoi
            // 
            this.txtMaTroChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTroChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaTroChoi.Location = new System.Drawing.Point(192, 518);
            this.txtMaTroChoi.Name = "txtMaTroChoi";
            this.txtMaTroChoi.Size = new System.Drawing.Size(296, 34);
            this.txtMaTroChoi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(738, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vị trí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(738, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên trò chơi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã trò chơi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvTroChoi);
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
            this.groupBox2.Text = "Thông tin trò chơi";
            // 
            // dtgvTroChoi
            // 
            this.dtgvTroChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTroChoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maTroChoi,
            this.tenTroChoi,
            this.maKhu,
            this.viTri});
            this.dtgvTroChoi.FilterAndSortEnabled = true;
            this.dtgvTroChoi.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dtgvTroChoi.Location = new System.Drawing.Point(24, 101);
            this.dtgvTroChoi.Name = "dtgvTroChoi";
            this.dtgvTroChoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgvTroChoi.RowHeadersWidth = 62;
            this.dtgvTroChoi.RowTemplate.Height = 33;
            this.dtgvTroChoi.Size = new System.Drawing.Size(1183, 268);
            this.dtgvTroChoi.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dtgvTroChoi.TabIndex = 2;
            this.dtgvTroChoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTroChoi_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 22;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 200;
            // 
            // maTroChoi
            // 
            this.maTroChoi.DataPropertyName = "maTroChoi";
            this.maTroChoi.HeaderText = "Mã Trò Chơi";
            this.maTroChoi.MinimumWidth = 22;
            this.maTroChoi.Name = "maTroChoi";
            this.maTroChoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maTroChoi.Width = 250;
            // 
            // tenTroChoi
            // 
            this.tenTroChoi.DataPropertyName = "tenTroChoi";
            this.tenTroChoi.HeaderText = "Tên Trò Chơi";
            this.tenTroChoi.MinimumWidth = 22;
            this.tenTroChoi.Name = "tenTroChoi";
            this.tenTroChoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tenTroChoi.Width = 250;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "maKhu";
            this.maKhu.HeaderText = "Mã Khu";
            this.maKhu.MinimumWidth = 22;
            this.maKhu.Name = "maKhu";
            this.maKhu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maKhu.Width = 250;
            // 
            // viTri
            // 
            this.viTri.DataPropertyName = "viTri";
            this.viTri.HeaderText = "Vị Trí";
            this.viTri.MinimumWidth = 22;
            this.viTri.Name = "viTri";
            this.viTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.viTri.Width = 250;
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
            this.btRefesh.Text = "Refresh";
            this.btRefesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefesh.UseVisualStyleBackColor = true;
            this.btRefesh.Click += new System.EventHandler(this.btRefesh_Click);
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
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(134, 49);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(296, 34);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "<Nhập tên trò chơi>";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(725, 784);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(118, 36);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.Text = "Hiển thị";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btHuy.IconColor = System.Drawing.Color.Red;
            this.btHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHuy.IconSize = 25;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(1055, 782);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(118, 36);
            this.btHuy.TabIndex = 15;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btLuu.IconColor = System.Drawing.Color.LimeGreen;
            this.btLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLuu.IconSize = 25;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(903, 782);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(118, 36);
            this.btLuu.TabIndex = 16;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btXoa.IconColor = System.Drawing.Color.Red;
            this.btXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btXoa.IconSize = 25;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(372, 784);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(118, 36);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTaoMoi.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btTaoMoi.IconColor = System.Drawing.Color.LimeGreen;
            this.btTaoMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTaoMoi.IconSize = 25;
            this.btTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoMoi.Location = new System.Drawing.Point(54, 782);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(118, 38);
            this.btTaoMoi.TabIndex = 19;
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
            this.btCapNhat.Location = new System.Drawing.Point(209, 784);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(118, 36);
            this.btCapNhat.TabIndex = 18;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // MaTroChoi_ERR
            // 
            this.MaTroChoi_ERR.ContainerControl = this;
            // 
            // TenTroChoi_ERR
            // 
            this.TenTroChoi_ERR.ContainerControl = this;
            // 
            // MaKhu_ERR
            // 
            this.MaKhu_ERR.ContainerControl = this;
            // 
            // ViTri_ERR
            // 
            this.ViTri_ERR.ContainerControl = this;
            // 
            // tro_choi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 848);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTaoMoi);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tro_choi";
            this.Text = "tro_choi";
            this.Load += new System.EventHandler(this.tro_choi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTroChoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaTroChoi_ERR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTroChoi_ERR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhu_ERR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViTri_ERR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaKhu;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtTenTroChoi;
        private System.Windows.Forms.TextBox txtMaTroChoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btRefesh;
        private FontAwesome.Sharp.IconButton btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btHuy;
        private FontAwesome.Sharp.IconButton btLuu;
        private FontAwesome.Sharp.IconButton btXoa;
        private FontAwesome.Sharp.IconButton btTaoMoi;
        private FontAwesome.Sharp.IconButton btCapNhat;
        private Zuby.ADGV.AdvancedDataGridView dtgvTroChoi;
        private System.Windows.Forms.ErrorProvider MaTroChoi_ERR;
        private System.Windows.Forms.ErrorProvider TenTroChoi_ERR;
        private System.Windows.Forms.ErrorProvider MaKhu_ERR;
        private System.Windows.Forms.ErrorProvider ViTri_ERR;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTroChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTroChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTri;
    }
}