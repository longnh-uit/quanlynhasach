create database QLNS
go
use QLNS
set dateformat DMY

create table SACH (
	IDSACH		char(5) primary key,
	TENSACH		varchar(30),
	THELOAI		varchar(20),
	TACGIA		varchar(40),
	SL			int,
	DONGIANHAP	money
)

create table KHACHHANG (
	IDKH		char(5) primary key,
	HOTEN		varchar(40),
	DCHI		varchar(50),
	DTHOAI		varchar(10),
	EMAIL		varchar(20),
)

create table THUTIEN (
	IDKH		char(5) primary key,
	NGTHUTIEN	datetime,
	SOTIENTHU	money
)

create table BAOCAOTON (
	IDSACH		char(5) primary key,
	THANG		int,
	TONDAU		int,
	PHATSINH	int,
	TONCUOI		int
)

create table BAOCAONO (
	IDKH		char(5)	primary key,
	THANG		int,
	NODAU		money,
	PHATSINH	money,
	NOCUOI		money
)

create table ADMINISTRATORS (
	HOTEN		varchar(40),
	USERNAME	varchar(20) primary key,
	PASSWORD	varchar(20)
)

insert into ADMINISTRATORS values (N'Nguyễn Hữu Long', 'longproks123', 'password')