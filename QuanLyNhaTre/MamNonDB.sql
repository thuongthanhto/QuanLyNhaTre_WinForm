create database QUANLYMAMNON
go
use QUANLYMAMNON
go 
create table HOCSINH
(
	MaHS varchar(7) NOT NULL,
	HoTen nvarchar(100) NOT NULL,
	NgaySinh smalldatetime NOT NULL,
	NoiSinh nvarchar(100) NULL,
	GioiTinh nvarchar(5) NULL,
	DiaChi nvarchar(100) NULL,
	DanToc nvarchar(100) NULL,
	TonGiao nvarchar(30) NULL,
	HoTen_Cha nvarchar(100) NULL,
	NgheNghiep_Cha nvarchar(100) NULL,
	HoTen_Me nvarchar(100) NULL,
	NgheNghiep_Me nvarchar(100) NULL,
Primary Key (MaHS)
) 
go

create table KETQUA_THANG
(
	NamThang varchar(7) NOT NULL,
	HocTap nvarchar(100) NULL,
	AnNgu nvarchar(100) NULL,
	GiaiTri nvarchar(100) NULL,
	ChieuCao nvarchar(10) NULL,
	CanNang nvarchar(10) NULL,
	NhanXetChung nvarchar(100) NULL,
	TTSucKhoe nvarchar(100) NULL,
	PhieuBN varchar(5) NULL,
	MaLop varchar(5) NOT NULL,
	MaHS varchar(7) NOT NULL,
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (NamThang)
) 
go

create table LOP
(
	MaLop varchar(5) NOT NULL,
	TenLop nvarchar(20) NULL,
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (MaLop,NamHoc,TenKhoi)
) 
go

create table NAM_HOC
(
	NamHoc varchar(9) NOT NULL,
	TenNamHoc nvarchar(50) NULL,
	NgayKG smalldatetime NULL,
	NgayKT smalldatetime NULL,
Primary Key (NamHoc)
) 
go

create table NHAN_VIEN
(
	MaNV varchar(5) NOT NULL,
	HoTenNV nvarchar(100) NULL,
	NgaySinh smalldatetime NULL,
	DiaChi nvarchar(100) NULL,
	GioiTinh nvarchar(100) NULL,
	TrinhDo nvarchar(100) NULL,
	TotNghiepTruong nvarchar(100) NULL,
	ChucVu nvarchar(100) NULL,
Primary Key (MaNV)
) 
go

create table THUC_DON
(
	Ngay smalldatetime NOT NULL,
	Thu nvarchar(200) NULL,
	Sang nvarchar(200) NULL,
	Trua nvarchar(200) NULL,
	Chieu nvarchar(200) NULL,
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (Ngay,NamHoc,TenKhoi)
) 
go

create table KHOI_NAMHOC
(
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (NamHoc,TenKhoi)
) 
go

create table HS_LOP
(
	MaLop varchar(5) NOT NULL,
	MaHS varchar(7) NOT NULL,
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (MaLop,MaHS,NamHoc,TenKhoi)
) 
go

create table LOP_NAM_GV
(
	MaNV varchar(5) NOT NULL,
	MaLop varchar(5) NOT NULL,
	NamHoc varchar(9) NOT NULL,
	TenKhoi nvarchar(10) NOT NULL,
Primary Key (MaNV,MaLop,NamHoc,TenKhoi)
) 
go


Alter table HS_LOP add  foreign key(MaHS) references HOCSINH (MaHS)  on update CASCADE on delete CASCADE 
go
Alter table HS_LOP add  foreign key(MaLop,NamHoc,TenKhoi) references LOP (MaLop,NamHoc,TenKhoi)  on update CASCADE on delete CASCADE
go
Alter table LOP_NAM_GV add  foreign key(MaLop,NamHoc,TenKhoi) references LOP (MaLop,NamHoc,TenKhoi)  on update CASCADE on delete CASCADE 
GO

Alter table KHOI_NAMHOC add  foreign key(NamHoc) references NAM_HOC (NamHoc)  on update CASCADE on delete CASCADE
go
Alter table LOP_NAM_GV add  foreign key(MaNV) references NHAN_VIEN (MaNV)  on update CASCADE on delete CASCADE 
go
Alter table LOP add  foreign key(NamHoc,TenKhoi) references KHOI_NAMHOC (NamHoc,TenKhoi)  on update CASCADE on delete CASCADE 
go
Alter table THUC_DON add  foreign key(NamHoc,TenKhoi) references KHOI_NAMHOC (NamHoc,TenKhoi)  on update CASCADE on delete CASCADE 
go
Alter table KETQUA_THANG add  foreign key(MaLop,MaHS,NamHoc,TenKhoi) references HS_LOP (MaLop,MaHS,NamHoc,TenKhoi)  on update CASCADE on delete CASCADE 
go

set dateformat dmy
go

create proc ThucDon_Them
(
	@Ngay smalldatetime,
	@Nam varchar(9),
	@Khoi nvarchar(10),
	@Sang nvarchar(MAX),
	@Trua nvarchar(MAX),
	@Chieu nvarchar(MAX)
)
as
	begin
		insert into Thuc_don (Ngay, Sang, Trua, Chieu, NamHoc, TenKhoi)
				 values (@Ngay, @Sang, @Trua, @Chieu, @Nam, @Khoi)
	end
go

create proc ThucDon_Sua
(
	
	@Ngay smalldatetime,
	@Nam varchar(10),
	@Khoi nvarchar(10),
	@Sang nvarchar(MAX),
	@Trua nvarchar(MAX),
	@Chieu nvarchar(MAX)
)
as
	begin	
		update Thuc_Don set Sang =@Sang, Trua = @Trua, Chieu = @Chieu
						where Ngay = @Ngay and NamHoc = @Nam and TenKhoi = @Khoi
	end
	
go

create proc ThucDon_Xoa
(
	@Ngay smalldatetime,
	@Nam varchar(10),
	@Khoi nvarchar(10)	
)
as
	begin
		Delete From Thuc_Don Where Ngay = @Ngay and NamHoc= @Nam and TenKhoi = @Khoi
	end
	
go

Set quoted_identifier on
go


Set quoted_identifier off
go
create table QUYEN
(
	MaQuyen int not null, 
	TenQuyen nvarchar(50),

	constraint PK_QUYEN primary key(MaQuyen)
)
go
create table NGUOIDUNG
(
	TaiKhoan nvarchar(50) not null,
	MatKhau nvarchar(50),	
	MaQuyen int,

	constraint PK_NGUOIDUNG primary key(TaiKhoan),
	constraint FK_NGUOIDUNG_QUYEN foreign key(MaQuyen) references QUYEN(MaQuyen)
)
go
insert into QUYEN values(1,N'Quản lý nhà sách')
insert into QUYEN values(2,N'Thủ kho')
insert into QUYEN values(3,N'Nhân viên bán hàng')
insert into NGUOIDUNG values('Admin',123456,1)

