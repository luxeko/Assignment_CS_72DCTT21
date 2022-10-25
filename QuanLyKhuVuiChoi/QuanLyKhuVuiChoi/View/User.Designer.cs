namespace QuanLyKhuVuiChoi
{
    partial class User
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbMaNv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterUpdatedAt = new FontAwesome.Sharp.IconButton();
            this.filterCreatedAt = new FontAwesome.Sharp.IconButton();
            this.filterTrangThai = new FontAwesome.Sharp.IconButton();
            this.filterMaNv = new FontAwesome.Sharp.IconButton();
            this.filterUsername = new FontAwesome.Sharp.IconButton();
            this.filterEmail = new FontAwesome.Sharp.IconButton();
            this.filterId = new FontAwesome.Sharp.IconButton();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.dbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaNv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaNv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.cbMaNv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý user";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(597, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(139, 577);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 31);
            this.label12.TabIndex = 19;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(641, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 31);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(138, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(531, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(138, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(189, 575);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(143, 33);
            this.cbTrangThai.TabIndex = 17;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // cbMaNv
            // 
            this.cbMaNv.FormattingEnabled = true;
            this.cbMaNv.Location = new System.Drawing.Point(680, 575);
            this.cbMaNv.Name = "cbMaNv";
            this.cbMaNv.Size = new System.Drawing.Size(141, 33);
            this.cbMaNv.TabIndex = 16;
            this.cbMaNv.SelectedIndexChanged += new System.EventHandler(this.cbMaNv_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 578);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(480, 578);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã nhân viên";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(680, 523);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(243, 32);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 523);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 32);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(680, 467);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 32);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(480, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 526);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(480, 470);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(189, 467);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 32);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterUpdatedAt);
            this.groupBox2.Controls.Add(this.filterCreatedAt);
            this.groupBox2.Controls.Add(this.filterTrangThai);
            this.groupBox2.Controls.Add(this.filterMaNv);
            this.groupBox2.Controls.Add(this.filterUsername);
            this.groupBox2.Controls.Add(this.filterEmail);
            this.groupBox2.Controls.Add(this.filterId);
            this.groupBox2.Controls.Add(this.dataGridViewUser);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(11, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 405);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách user";
            // 
            // filterUpdatedAt
            // 
            this.filterUpdatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterUpdatedAt.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterUpdatedAt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterUpdatedAt.IconSize = 25;
            this.filterUpdatedAt.Location = new System.Drawing.Point(821, 77);
            this.filterUpdatedAt.Name = "filterUpdatedAt";
            this.filterUpdatedAt.Size = new System.Drawing.Size(151, 31);
            this.filterUpdatedAt.TabIndex = 25;
            this.filterUpdatedAt.Text = "Updated_at";
            this.filterUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterUpdatedAt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterUpdatedAt.UseVisualStyleBackColor = true;
            this.filterUpdatedAt.Click += new System.EventHandler(this.filterUpdatedAt_Click);
            // 
            // filterCreatedAt
            // 
            this.filterCreatedAt.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterCreatedAt.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterCreatedAt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterCreatedAt.IconSize = 25;
            this.filterCreatedAt.Location = new System.Drawing.Point(672, 77);
            this.filterCreatedAt.Name = "filterCreatedAt";
            this.filterCreatedAt.Size = new System.Drawing.Size(143, 31);
            this.filterCreatedAt.TabIndex = 24;
            this.filterCreatedAt.Text = "Created_at";
            this.filterCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterCreatedAt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterCreatedAt.UseVisualStyleBackColor = true;
            this.filterCreatedAt.Click += new System.EventHandler(this.filterCreatedAt_Click);
            // 
            // filterTrangThai
            // 
            this.filterTrangThai.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterTrangThai.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterTrangThai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterTrangThai.IconSize = 25;
            this.filterTrangThai.Location = new System.Drawing.Point(426, 77);
            this.filterTrangThai.Name = "filterTrangThai";
            this.filterTrangThai.Size = new System.Drawing.Size(118, 31);
            this.filterTrangThai.TabIndex = 23;
            this.filterTrangThai.Text = "Status";
            this.filterTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterTrangThai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterTrangThai.UseVisualStyleBackColor = true;
            this.filterTrangThai.Click += new System.EventHandler(this.filterTrangThai_Click);
            // 
            // filterMaNv
            // 
            this.filterMaNv.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterMaNv.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterMaNv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterMaNv.IconSize = 25;
            this.filterMaNv.Location = new System.Drawing.Point(550, 77);
            this.filterMaNv.Name = "filterMaNv";
            this.filterMaNv.Size = new System.Drawing.Size(116, 31);
            this.filterMaNv.TabIndex = 23;
            this.filterMaNv.Text = "Mã NV";
            this.filterMaNv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterMaNv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterMaNv.UseVisualStyleBackColor = true;
            this.filterMaNv.Click += new System.EventHandler(this.filterMaNv_Click);
            // 
            // filterUsername
            // 
            this.filterUsername.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterUsername.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterUsername.IconSize = 25;
            this.filterUsername.Location = new System.Drawing.Point(100, 77);
            this.filterUsername.Name = "filterUsername";
            this.filterUsername.Size = new System.Drawing.Size(134, 31);
            this.filterUsername.TabIndex = 22;
            this.filterUsername.Text = "Username";
            this.filterUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterUsername.UseVisualStyleBackColor = true;
            this.filterUsername.Click += new System.EventHandler(this.filterUsername_Click);
            // 
            // filterEmail
            // 
            this.filterEmail.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterEmail.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterEmail.IconSize = 25;
            this.filterEmail.Location = new System.Drawing.Point(240, 77);
            this.filterEmail.Name = "filterEmail";
            this.filterEmail.Size = new System.Drawing.Size(180, 31);
            this.filterEmail.TabIndex = 21;
            this.filterEmail.Text = "Email";
            this.filterEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterEmail.UseVisualStyleBackColor = true;
            this.filterEmail.Click += new System.EventHandler(this.filterEmail_Click);
            // 
            // filterId
            // 
            this.filterId.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.filterId.IconColor = System.Drawing.Color.DodgerBlue;
            this.filterId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterId.IconSize = 25;
            this.filterId.Location = new System.Drawing.Point(6, 77);
            this.filterId.Name = "filterId";
            this.filterId.Size = new System.Drawing.Size(88, 31);
            this.filterId.TabIndex = 20;
            this.filterId.Text = "ID";
            this.filterId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterId.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterId.UseVisualStyleBackColor = true;
            this.filterId.Click += new System.EventHandler(this.filterId_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbId,
            this.dbUsername,
            this.dbEmail,
            this.dbTrangThai,
            this.dbMaNV,
            this.created_at,
            this.updated_at,
            this.dbPassword});
            this.dataGridViewUser.Location = new System.Drawing.Point(7, 114);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 29;
            this.dataGridViewUser.Size = new System.Drawing.Size(966, 285);
            this.dataGridViewUser.TabIndex = 19;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbId
            // 
            this.dbId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dbId.DataPropertyName = "id";
            this.dbId.FillWeight = 8.776232F;
            this.dbId.HeaderText = "ID";
            this.dbId.MinimumWidth = 6;
            this.dbId.Name = "dbId";
            this.dbId.Width = 40;
            // 
            // dbUsername
            // 
            this.dbUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dbUsername.DataPropertyName = "username";
            this.dbUsername.FillWeight = 25.88988F;
            this.dbUsername.HeaderText = "Username";
            this.dbUsername.MinimumWidth = 6;
            this.dbUsername.Name = "dbUsername";
            this.dbUsername.Width = 140;
            // 
            // dbEmail
            // 
            this.dbEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dbEmail.DataPropertyName = "email";
            this.dbEmail.FillWeight = 84.55116F;
            this.dbEmail.HeaderText = "Email";
            this.dbEmail.MinimumWidth = 6;
            this.dbEmail.Name = "dbEmail";
            // 
            // dbTrangThai
            // 
            this.dbTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dbTrangThai.DataPropertyName = "trangThai";
            this.dbTrangThai.FillWeight = 37.61242F;
            this.dbTrangThai.HeaderText = "Status";
            this.dbTrangThai.MinimumWidth = 40;
            this.dbTrangThai.Name = "dbTrangThai";
            this.dbTrangThai.Width = 125;
            // 
            // dbMaNV
            // 
            this.dbMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dbMaNV.DataPropertyName = "maNV";
            this.dbMaNV.FillWeight = 262.032F;
            this.dbMaNV.HeaderText = "Mã NV";
            this.dbMaNV.MinimumWidth = 70;
            this.dbMaNV.Name = "dbMaNV";
            this.dbMaNV.Width = 125;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.FillWeight = 159.5036F;
            this.created_at.HeaderText = "Created_at";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            this.created_at.Width = 150;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.FillWeight = 121.6345F;
            this.updated_at.HeaderText = "Updated_at";
            this.updated_at.MinimumWidth = 6;
            this.updated_at.Name = "updated_at";
            this.updated_at.Width = 150;
            // 
            // dbPassword
            // 
            this.dbPassword.DataPropertyName = "password";
            this.dbPassword.HeaderText = "Password";
            this.dbPassword.MinimumWidth = 6;
            this.dbPassword.Name = "dbPassword";
            this.dbPassword.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnExport.IconColor = System.Drawing.Color.LimeGreen;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 25;
            this.btnExport.Location = new System.Drawing.Point(840, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 31);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Xuất excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRefresh.IconColor = System.Drawing.Color.Crimson;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.Location = new System.Drawing.Point(337, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 31);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 36);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 31);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnCreate
            // 
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCreate.IconColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreate.IconSize = 25;
            this.btnCreate.Location = new System.Drawing.Point(17, 637);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 29);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnUpdate.IconColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(122, 637);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Crimson;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(238, 637);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 25;
            this.btnLuu.Location = new System.Drawing.Point(789, 637);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Crimson;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(889, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorConPassword
            // 
            this.errorConPassword.ContainerControl = this;
            // 
            // errorStatus
            // 
            this.errorStatus.ContainerControl = this;
            // 
            // errorMaNv
            // 
            this.errorMaNv.ContainerControl = this;
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn1.HeaderText = "Password";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 677);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaNv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox5;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.Label conPassword;
        //private System.Windows.Forms.Label passWord;
        //private System.Windows.Forms.Label email;
        //private System.Windows.Forms.Label userName;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.ComboBox comboBox2;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Label trangThai;
        //private System.Windows.Forms.Label maNV;
        //private FontAwesome.Sharp.IconButton iconButton5;
        //private FontAwesome.Sharp.IconButton iconButton6;
        //private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbMaNv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorConPassword;
        private System.Windows.Forms.ErrorProvider errorStatus;
        private System.Windows.Forms.ErrorProvider errorMaNv;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private FontAwesome.Sharp.IconButton btnExport;
  
        //private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private FontAwesome.Sharp.IconButton filterUpdatedAt;
        private FontAwesome.Sharp.IconButton filterCreatedAt;
        private FontAwesome.Sharp.IconButton filterTrangThai;
        private FontAwesome.Sharp.IconButton filterMaNv;
        private FontAwesome.Sharp.IconButton filterUsername;
        private FontAwesome.Sharp.IconButton filterEmail;
        private FontAwesome.Sharp.IconButton filterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPassword;
    }
}