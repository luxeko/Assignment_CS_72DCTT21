namespace QuanLyKhuVuiChoi.View
{
    partial class Tickets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmakhu = new System.Windows.Forms.ComboBox();
            this.dtpngayban = new System.Windows.Forms.DateTimePicker();
            this.cbbloaikh = new System.Windows.Forms.ComboBox();
            this.txgiave = new System.Windows.Forms.TextBox();
            this.txmave = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btrefresh = new FontAwesome.Sharp.IconButton();
            this.btntimkiem = new FontAwesome.Sharp.IconButton();
            this.txtimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bthuy = new FontAwesome.Sharp.IconButton();
            this.btluu = new FontAwesome.Sharp.IconButton();
            this.btxoa = new FontAwesome.Sharp.IconButton();
            this.btcapnhat = new FontAwesome.Sharp.IconButton();
            this.bttaomoi = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbmakhu);
            this.groupBox1.Controls.Add(this.dtpngayban);
            this.groupBox1.Controls.Add(this.cbbloaikh);
            this.groupBox1.Controls.Add(this.txgiave);
            this.groupBox1.Controls.Add(this.txmave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1489, 730);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ VÉ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(767, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã khu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(767, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(767, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã vé";
            // 
            // cbbmakhu
            // 
            this.cbbmakhu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbmakhu.FormattingEnabled = true;
            this.cbbmakhu.Location = new System.Drawing.Point(905, 520);
            this.cbbmakhu.Name = "cbbmakhu";
            this.cbbmakhu.Size = new System.Drawing.Size(461, 38);
            this.cbbmakhu.TabIndex = 4;
            // 
            // dtpngayban
            // 
            this.dtpngayban.CustomFormat = "dd/MM/yy hh:mm:ss";
            this.dtpngayban.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpngayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngayban.Location = new System.Drawing.Point(905, 674);
            this.dtpngayban.Name = "dtpngayban";
            this.dtpngayban.Size = new System.Drawing.Size(360, 37);
            this.dtpngayban.TabIndex = 5;
            // 
            // cbbloaikh
            // 
            this.cbbloaikh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbloaikh.FormattingEnabled = true;
            this.cbbloaikh.Location = new System.Drawing.Point(905, 596);
            this.cbbloaikh.Name = "cbbloaikh";
            this.cbbloaikh.Size = new System.Drawing.Size(461, 38);
            this.cbbloaikh.TabIndex = 3;
            // 
            // txgiave
            // 
            this.txgiave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txgiave.Location = new System.Drawing.Point(153, 598);
            this.txgiave.Name = "txgiave";
            this.txgiave.Size = new System.Drawing.Size(461, 37);
            this.txgiave.TabIndex = 2;
            // 
            // txmave
            // 
            this.txmave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txmave.Location = new System.Drawing.Point(153, 522);
            this.txmave.Name = "txmave";
            this.txmave.Size = new System.Drawing.Size(461, 37);
            this.txmave.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btrefresh);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.txtimkiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1452, 463);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách vé";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1438, 364);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btrefresh
            // 
            this.btrefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btrefresh.ForeColor = System.Drawing.Color.Black;
            this.btrefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btrefresh.IconColor = System.Drawing.Color.DodgerBlue;
            this.btrefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btrefresh.IconSize = 25;
            this.btrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrefresh.Location = new System.Drawing.Point(656, 36);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(158, 38);
            this.btrefresh.TabIndex = 11;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntimkiem.ForeColor = System.Drawing.Color.Black;
            this.btntimkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btntimkiem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btntimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntimkiem.IconSize = 25;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(519, 36);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(128, 39);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtimkiem
            // 
            this.txtimkiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtimkiem.Location = new System.Drawing.Point(152, 38);
            this.txtimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtimkiem.Name = "txtimkiem";
            this.txtimkiem.Size = new System.Drawing.Size(342, 37);
            this.txtimkiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bthuy.ForeColor = System.Drawing.Color.Black;
            this.bthuy.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.bthuy.IconColor = System.Drawing.Color.Red;
            this.bthuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bthuy.IconSize = 25;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(1300, 752);
            this.bthuy.Margin = new System.Windows.Forms.Padding(4);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(142, 43);
            this.bthuy.TabIndex = 10;
            this.bthuy.Text = "Huỷ";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btluu.IconColor = System.Drawing.Color.LimeGreen;
            this.btluu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btluu.IconSize = 25;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(1151, 752);
            this.btluu.Margin = new System.Windows.Forms.Padding(4);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(142, 43);
            this.btluu.TabIndex = 9;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btxoa.ForeColor = System.Drawing.Color.Black;
            this.btxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btxoa.IconColor = System.Drawing.Color.Red;
            this.btxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btxoa.IconSize = 25;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(352, 752);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(142, 43);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btcapnhat.ForeColor = System.Drawing.Color.Black;
            this.btcapnhat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btcapnhat.IconColor = System.Drawing.Color.SteelBlue;
            this.btcapnhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btcapnhat.IconSize = 25;
            this.btcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcapnhat.Location = new System.Drawing.Point(203, 752);
            this.btcapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(142, 43);
            this.btcapnhat.TabIndex = 7;
            this.btcapnhat.Text = "Cập nhật";
            this.btcapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // bttaomoi
            // 
            this.bttaomoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttaomoi.ForeColor = System.Drawing.Color.Black;
            this.bttaomoi.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bttaomoi.IconColor = System.Drawing.Color.LimeGreen;
            this.bttaomoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttaomoi.IconSize = 25;
            this.bttaomoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttaomoi.Location = new System.Drawing.Point(52, 752);
            this.bttaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.bttaomoi.Name = "bttaomoi";
            this.bttaomoi.Size = new System.Drawing.Size(142, 43);
            this.bttaomoi.TabIndex = 6;
            this.bttaomoi.Text = "Tạo mới";
            this.bttaomoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttaomoi.UseVisualStyleBackColor = true;
            this.bttaomoi.Click += new System.EventHandler(this.bttaomoi_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1519, 804);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.bttaomoi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btrefresh;
        private FontAwesome.Sharp.IconButton btntimkiem;
        private System.Windows.Forms.TextBox txtimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txmave;
        private System.Windows.Forms.ComboBox cbbmakhu;
        private System.Windows.Forms.DateTimePicker dtpngayban;
        private System.Windows.Forms.ComboBox cbbloaikh;
        private System.Windows.Forms.TextBox txgiave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton bthuy;
        private FontAwesome.Sharp.IconButton btluu;
        private FontAwesome.Sharp.IconButton btxoa;
        private FontAwesome.Sharp.IconButton btcapnhat;
        private FontAwesome.Sharp.IconButton bttaomoi;
    }
}