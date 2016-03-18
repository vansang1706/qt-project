create table SanPham
(
Id int identity(1,1) primary key,
TenSanPham nvarchar(255),
DonViTinh nvarchar(20),
SoLuongTon float
);

create table GiaBan
(
Id int identity(1,1) primary key,
SanPhamId int,
KhachHangId int,
Gia float,
NgayThayDoi datetime
);

create table KhachHang
(
Id int identity(1,1) primary key,
HoTen nvarchar(255),
DiaChi nvarchar(255),
SoDienThoai varchar(20)
);

create table HoaDon
(
Id int identity(1,1) primary key,
KhachHangId int,
TongTien float,
NgayLap datetime
);

create table ChiTietHoaDon
(
Id int identity(1,1) primary key,
HoaDonId int,
SanPhamId int,
SoLuong float,
Gia float,
ThanhTien float
);

create table PhieuNhap
(
Id int identity(1,1) primary key,
NhaPhanPhoi nvarchar(255),
TongTien float,
NgayLap datetime
);

create table ChiTietPhieuNhap
(
Id int identity(1,1) primary key,
PhieuNhapId int,
SanPhamId int,
SoLuong float,
Gia float,
ThanhTien float
);