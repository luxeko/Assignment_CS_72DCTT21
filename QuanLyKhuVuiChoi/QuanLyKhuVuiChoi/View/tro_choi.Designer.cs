namespace QuanLyKhuVuiChoi.View
{
    partial class Tro_Choi
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
            this.dtgvTroChoi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTroChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTroChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btRefesh = new FontAwesome.Sharp.IconButton();
            this.btTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btHuy = new FontAwesome.Sharp.IconButton();
            this.btLuu = new FontAwesome.Sharp.IconButton();
            this.btXoa = new FontAwesome.Sharp.IconButton();
            this.btCapNhat = new FontAwesome.Sharp.IconButton();
            this.btTaoMoi = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTroChoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(997, 597);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ TRÒ CHƠI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMaKhu
            // 
            this.cbMaKhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMaKhu.FormattingEnabled = true;
            this.cbMaKhu.Location = new System.Drawing.Point(688, 413);
            this.cbMaKhu.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaKhu.Name = "cbMaKhu";
            this.cbMaKhu.Size = new System.Drawing.Size(238, 31);
            this.cbMaKhu.TabIndex = 8;
            // 
            // txtViTri
            // 
            this.txtViTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtViTri.Location = new System.Drawing.Point(688, 512);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(2);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(237, 30);
            this.txtViTri.TabIndex = 7;
            // 
            // txtTenTroChoi
            // 
            this.txtTenTroChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTroChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenTroChoi.Location = new System.Drawing.Point(154, 514);
            this.txtTenTroChoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTroChoi.Name = "txtTenTroChoi";
            this.txtTenTroChoi.Size = new System.Drawing.Size(237, 30);
            this.txtTenTroChoi.TabIndex = 6;
            // 
            // txtMaTroChoi
            // 
            this.txtMaTroChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTroChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaTroChoi.Location = new System.Drawing.Point(154, 414);
            this.txtMaTroChoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTroChoi.Name = "txtMaTroChoi";
            this.txtMaTroChoi.Size = new System.Drawing.Size(237, 30);
            this.txtMaTroChoi.TabIndex = 6;
            this.txtMaTroChoi.TextChanged += new System.EventHandler(this.txtMaTroChoi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(590, 514);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vị trí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(590, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên trò chơi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(5, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(987, 317);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin trò chơi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtgvTroChoi
            // 
            this.dtgvTroChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTroChoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.maTroChoi,
            this.tenTroChoi,
            this.maKhu,
            this.viTri});
            this.dtgvTroChoi.Location = new System.Drawing.Point(14, 82);
            this.dtgvTroChoi.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTroChoi.Name = "dtgvTroChoi";
            this.dtgvTroChoi.RowHeadersWidth = 62;
            this.dtgvTroChoi.RowTemplate.Height = 33;
            this.dtgvTroChoi.Size = new System.Drawing.Size(968, 212);
            this.dtgvTroChoi.TabIndex = 2;
            this.dtgvTroChoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTroChoi_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // maTroChoi
            // 
            this.maTroChoi.DataPropertyName = "maTroChoi";
            this.maTroChoi.HeaderText = "Mã Trò Chơi";
            this.maTroChoi.MinimumWidth = 8;
            this.maTroChoi.Name = "maTroChoi";
            this.maTroChoi.ReadOnly = true;
            this.maTroChoi.Width = 250;
            // 
            // tenTroChoi
            // 
            this.tenTroChoi.DataPropertyName = "tenTroChoi";
            this.tenTroChoi.HeaderText = "Tên Trò Chơi";
            this.tenTroChoi.MinimumWidth = 8;
            this.tenTroChoi.Name = "tenTroChoi";
            this.tenTroChoi.Width = 250;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "maKhu";
            this.maKhu.HeaderText = "Mã Khu";
            this.maKhu.MinimumWidth = 8;
            this.maKhu.Name = "maKhu";
            this.maKhu.Width = 250;
            // 
            // viTri
            // 
            this.viTri.DataPropertyName = "viTri";
            this.viTri.HeaderText = "Vị Trí";
            this.viTri.MinimumWidth = 8;
            this.viTri.Name = "viTri";
            this.viTri.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
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
            this.btRefesh.Location = new System.Drawing.Point(502, 38);
            this.btRefesh.Margin = new System.Windows.Forms.Padding(2);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(105, 30);
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
            this.btTimKiem.Location = new System.Drawing.Point(379, 38);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(105, 30);
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
            this.txtTimKiem.Location = new System.Drawing.Point(107, 39);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(237, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "<Nhập tên trò chơi>";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btHuy.IconColor = System.Drawing.Color.Red;
            this.btHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHuy.IconSize = 25;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(830, 622);
            this.btHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(94, 29);
            this.btHuy.TabIndex = 3;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btLuu.IconColor = System.Drawing.Color.LimeGreen;
            this.btLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLuu.IconSize = 25;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(709, 622);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(94, 29);
            this.btLuu.TabIndex = 4;
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
            this.btXoa.Location = new System.Drawing.Point(284, 623);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 29);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCapNhat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btCapNhat.IconColor = System.Drawing.Color.SteelBlue;
            this.btCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCapNhat.IconSize = 25;
            this.btCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCapNhat.Location = new System.Drawing.Point(154, 623);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btCapNhat.TabIndex = 6;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTaoMoi.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btTaoMoi.IconColor = System.Drawing.Color.LimeGreen;
            this.btTaoMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btTaoMoi.IconSize = 25;
            this.btTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoMoi.Location = new System.Drawing.Point(30, 622);
            this.btTaoMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(94, 30);
            this.btTaoMoi.TabIndex = 7;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tro_Choi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 678);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btTaoMoi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tro_Choi";
            this.Text = "Tro_Choi";
            this.Load += new System.EventHandler(this.Tro_Choi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTroChoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtTenTroChoi;
        private System.Windows.Forms.TextBox txtMaTroChoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvTroChoi;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btRefesh;
        private FontAwesome.Sharp.IconButton btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btHuy;
        private FontAwesome.Sharp.IconButton btLuu;
        private FontAwesome.Sharp.IconButton btXoa;
        private FontAwesome.Sharp.IconButton btCapNhat;
        private FontAwesome.Sharp.IconButton btTaoMoi;
        private System.Windows.Forms.ComboBox cbMaKhu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTroChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTroChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTri;
    }
}