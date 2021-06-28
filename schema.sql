create database QuanLyNhaSach;

use QuanLyNhaSach;

create table NHAPSACH(
	MaSach char(10) primary key,
	NgayNhap datetime,
	SoLuong int,
);
create table SACH(
	MaSach char(10) primary key,
	TenSach char(100),
	TheLoai char(50),
	TacGia char(100),
	SoLuong int,
	DonGiaNhap float,
	FOREIGN KEY (MaSach) REFERENCES NHAPSACH(MASACH)
);
create table KHACHHANG(
	MaKH char(10) primary key,
	TenKH char(100),
	DiaChi char(100),
	DienThoai char(20),
	Email char(50),
	SoTienNo float
)
create table HOADON(
	MaHD char(10) primary key,
	MaKH char(10) foreign key references KHACHHANG(MaKH),
	NgayHoaDon datetime,
	TongTien float,
	SoTienTra float
);
create table PHIEUTHUTIEN(
	MaPhieuThu char(10) primary key,
	MaKH char(10) foreign key references KHACHHANG(MaKH),
	NgayThuTien	datetime,
	SoTienThu float
);
create table BAOCAOCONGNO(
	MaChiTietCongNo char(10) primary key,
	Thang int,
	MaKH char(10) foreign key references KHACHHANG(MaKH),
	NoDau int,
	PhatSinh int,
	NoCuoi int
);
create table CTHD(
	MaHD char(10) primary key 
	foreign key references HOADON(MaHD),
	MaSach char(10) foreign key references SACH(MaSach),
	SoLuongBan int,
	DonGiaBan float,
);
create table BAOCAOTON(
	MaChiTietTon char(10) primary key,
	Thang int,
	MaSach char(10),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
	FOREIGN KEY (MaSach) REFERENCES NHAPSACH(MaSach),
	FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
);
create table THAMSO(
	LuongNhapItNhat int,
	LuongTonToiDa int,
	NoToiDa float,
	LuongTonToiThieu int,
	KiemTraSoTienThu BIT,
);

create table ADMINISTRATORS (
	HOTEN		varchar(40),
	USERNAME	varchar(20) primary key,
	PASSWORD	varchar(20)
);

insert into ADMINISTRATORS values (N'Nguyễn Hữu Long', 'longproks123', 'password');