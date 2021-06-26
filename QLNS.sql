use master
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
	DienThoai nvarchar(20),
	Email nvarchar(50),
	SoTienNo int,
	primary key(MaKH)
)
go
create table HOADON(
	MaHD int identity(1,1) not null,
	TenKH nvarchar(100),
	DienThoai nvarchar(20),
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



----------------------------------------
go
create procedure InsertNhapSach
@NgayNhap datetime, @TenSach nvarchar(100),@TheLoai nvarchar(50),@TacGia nvarchar(100),@SoLuong int,@DonGiaNhap int
as
begin
	declare @LuongNhapItNhat int
	set @LuongNhapItNhat = (select LuongNhapItNhat from THAMSO )
	if @SoLuong < @LuongNhapItNhat 
	begin
		print N'Số lượng sách nhập phải lớn hơn hoặc bằng ' + CAST(@LuongNhapItNhat as varchar)
		return
	end
	declare @MaSach int 
	set @MaSach = (select MaSach from SACH where TenSach =@TenSach and TheLoai= @TheLoai and TacGia=@TacGia)
	if @MaSach is NULL
	begin
		insert into SACH (TenSach,TacGia,TheLoai,SoLuong,DonGiaNhap) values (@TenSach,@TacGia,@TheLoai,@SoLuong,@DonGiaNhap)
		set @MaSach = (select MaSach from SACH where TenSach =@TenSach and TheLoai= @TheLoai and TacGia=@TacGia)
		insert into NHAPSACH (MaSach,NgayNhap,SoLuong) values (@MaSach,@NgayNhap,@SoLuong)
		print N'Nhập sách thành công'

	end
	else
	begin
		declare @LuongTonToiDa int
		set @LuongTonToiDa = (select LuongTonToiDa from THAMSO )
		declare @SoLuongSach int
		set @SoLuongSach = (select SoLuong from SACH where MaSach=@MaSach)
		if @SoLuongSach <= @LuongTonToiDa
			begin
				if exists(select * from NHAPSACH where MaSach = @MaSach and NgayNhap = @NgayNhap) 
					update NHAPSACH set SoLuong = SoLuong + @SoLuong where MaSach = @MaSach and NgayNhap = @NgayNhap
				else
					insert into NHAPSACH (MaSach,NgayNhap,SoLuong) values (@MaSach,@NgayNhap,@SoLuong)
				update SACH
				set SoLuong = SoLuong + @SoLuong , DonGiaNhap = @DonGiaNhap
				where MaSach=@MaSach
				print N'Nhập sách thành công'
			end
		else 
		begin
		print N'Không thể nhập sách có lượng tồn nhiều hơn ' + CAST(@LuongTonToiDa as varchar)
		return
		end
	end
end
go

insert into THAMSO values(150, 300, 20000, 20, 1)

insert into ADMINISTRATORS values (N'Nguyễn Hữu Long', 'longproks123', 'password', N'Quản lý') 
exec InsertNhapSach '25/6/2021', N'Cho tôi xin một vé đi tuổi thơ', N'Thiếu nhi', N'Nguyễn Nhật Ánh', 180, 9000
insert into ADMINISTRATORS values(N'Phan Đại Dương', 'duonghcb', 'abc', N'Nhân viên bán hàng')
exec InsertNhapSach '25/6/2021', N'Mắt biếc', N'Truyện dài', N'Nguyễn Nhật Ánh', 180, 9000
exec InsertNhapSach '25/6/2021', N'Harry Porter và Hòn đá Phù thuỷ', N'Tiểu thuyết', N'J. K. Rowling', 180, 9000

