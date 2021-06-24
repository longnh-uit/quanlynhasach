drop database QLNS
create database QLNS
go
use QLNS
set dateformat DMY

create table SACH (
	MaSach int identity(1,1) not null,
	TenSach nvarchar(100) ,
	TheLoai nvarchar(50),
	TacGia nvarchar(100),
	SoLuong int,
	DonGiaNhap int,
	Primary key (MaSach)
)
go
create table NHAPSACH(
	MaSach int not null,
	NgayNhap datetime not null,
	SoLuong int
	CONSTRAINT PK_NHAPSACH PRIMARY KEY (MaSach,NgayNhap)
	CONSTRAINT FK_SACH_NHAPSACH FOREIGN KEY (MaSach)
    REFERENCES SACH(MaSach)
)
go
create table KHACHHANG(
	MaKH int identity(1,1) not null,
	TenKH nvarchar(100) ,
	DiaChi nvarchar(100),
	DienThoai char(20),
	Email char(50),
	SoTienNo int,
	primary key(MaKH)
)
go
create table HOADON(
	MaHD int identity(1,1) not null,
	TenKH nvarchar(100),
	DienThoai char(20),
	NgayHoaDon datetime,
	TongTien int,
	SoTienTra int,
	primary key (MaHD),
)
go
create table CTHD(
	MaHD int not null,
	MaSach int not null,
	SoLuongBan int,
	DonGiaBan int,
	constraint PK_CTHD primary key (MaHD,MaSach),
	constraint FK_HOADON_CTHD foreign key (MaHD) 
	references HOADON(MaHD),
	constraint FK_SACH_CTHD foreign key (MaSach) 
	references SACH(MaSach),
)
go
create table PHIEUTHUTIEN(
	MaPhieuThu int identity(1,1) not null,
	MaKH int,
	NgayThuTien datetime,
	SoTienThu int,
	primary key (MaPhieuThu),
	constraint FK_KHACHHANG_PHIEUTHUTIEN foreign key (MaKH)
	references KHACHHANG(MaKH)
)
go
create table BAOCAOTON(
	MaChiTietTon int identity(1,1) not null,
	Thang int,
	MaSach int,
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
	primary key (MaChiTietTon),
	constraint FK_SACH_BAOCAOTON foreign key (MaSach) 
	references SACH(MaSach),
)
go
create table BAOCAOCONGNO(
	MaChiTietCongNo int identity(1,1) not null ,
	Thang int,
	MaKH int,
	NoDau int,
	PhatSinh int,
	NoCuoi int,
	primary key (MaChiTietCongNo),
	constraint FK_KHACHHANG_BAOCAOCONGNO foreign key (MaKH) 
	references KHACHHANG(MaKH),
)
go
create table THAMSO(
	LuongNhapItNhat int,
	LuongTonToiDa int,
	NoToiDa int,
	LuongTonToiThieu int,
	KiemTraSoTienThu bit,
)
create table ADMINISTRATORS (
	HOTEN		nvarchar(100),
	USERNAME	varchar(20) primary key,
	PASSWORD	varchar(20),
	CHUCVU		nvarchar(50)
)

insert into ADMINISTRATORS values (N'Nguyễn Hữu Long', 'longproks123', 'password', N'Quản lý') 
insert into SACH values (N'Cho tôi xin một vé đi tuổi thơ', N'Thiếu nhi', N'Nguyễn Nhật Ánh', 90, 9000)
insert into ADMINISTRATORS values(N'Phan Đại Dương', 'duonghcb', 'abc', N'Nhân viên bán hàng')
insert into SACH values (N'Mắt biếc', N'Truyện dài', N'Nguyễn Nhật Ánh', 90, 9000)
insert into SACH values (N'Harry Porter và Hòn đá Phù thuỷ', N'Tiểu thuyết', N'J. K. Rowling', 90, 9000)

insert into THAMSO values(150, 300, 20000, 20, 1)
