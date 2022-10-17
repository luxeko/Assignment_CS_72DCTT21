create table tblKhuVuiChoi (
	id int IDENTITY(1,1), -- IDENTITY(1,1) - Gán tăng dần
  	maDV nvarchar(50) not null unique,
  	maKhu nvarchar(50) not null unique, --chỉ cóa duy nhât 1 colum maKhu
    tenKhu nvarchar(100) not null unique,
    viTri nvarchar(100) not null unique,
    dienTich nvarchar(100),
    gioDong DATETIME,
    gioMo DATETIME,
    giaNL decimal(18,0),
    giaTE decimal(18,0)
	PRIMARY KEY(maKhu)
);

create table  tblNhanVien(
	id int IDENTITY(1,1),
  	maNV nvarchar(50) not null unique,
  	hoTen nvarchar(50) not null,
  	avatarSrc nvarchar(255),
  	ngaySinh date,
  	maKhu nvarchar(50) FOREIGN KEY REFERENCES tblKhuVuiChoi(maKhu), --Khóa ngoại
  	soDT nvarchar(20) not null unique,
  	diaChi nvarchar not null unique,
  	gioiTinh enum("Male", "Famale"),
  	chucVu enum("TN", "DV", "LC", "BV"),
  	luong decimal(18,0),
	PRIMARY KEY(maNV)
);