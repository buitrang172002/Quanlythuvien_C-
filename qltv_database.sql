USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUMUON]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUMUON](
	[MaPhieuMuon] [varchar](20) NOT NULL,
	[MaSach] [varchar](20) NOT NULL,
	[TinhTrang] [bit] NULL,
	[NgayTraSach] [date] NULL,
	[TienPhat] [float] NULL,
	[MaNhanVienNhanSachTra] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](20) NOT NULL,
	[TenDocGia] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[LopHoc] [nvarchar](50) NULL,
	[NgayTaoThe] [date] NULL,
	[MaNhanVienTaoThe] [varchar](20) NULL,
	[TenDangNhap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](100) NULL,
	[LoaiNguoiDung] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SoDienThoai] [int] NULL,
	[TenDangNhap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNhaXuatBan] [varchar](20) NOT NULL,
	[TenNhaXuatBan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieuMuon] [varchar](20) NOT NULL,
	[MaNhanVienLapPhieu] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[MaDocGia] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](20) NOT NULL,
	[TenSach] [nvarchar](100) NULL,
	[LoaiSach] [nvarchar](100) NULL,
	[MaTacGia] [varchar](20) NULL,
	[MaNhaXuatBan] [varchar](20) NULL,
	[NgayXuatBan] [date] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/1/2023 4:17:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [varchar](20) NOT NULL,
	[TenTacGia] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM01', N'MS01', 1, CAST(N'2022-07-18' AS Date), 864000, N'NV4')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM02', N'MS02', 1, CAST(N'2022-12-13' AS Date), 62000, N'NV5')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM03', N'MS10', 1, CAST(N'2022-07-18' AS Date), NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM04', N'MS09', 1, CAST(N'2022-03-10' AS Date), NULL, N'NV1')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM05', N'MS20', 1, CAST(N'2022-04-16' AS Date), NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM06', N'MS11', 1, CAST(N'2023-12-01' AS Date), 0, N'NV3')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM07', N'MS15', 1, CAST(N'2023-03-25' AS Date), NULL, N'NV4')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM08', N'MS30', 1, CAST(N'2022-05-02' AS Date), NULL, N'NV3')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM09', N'MS22', 0, NULL, NULL, N'NV1')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM10', N'MS06', 1, CAST(N'2023-10-20' AS Date), NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM11', N'MS07', 1, CAST(N'2023-08-05' AS Date), NULL, N'NV4')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM12', N'MS15', 0, NULL, NULL, N'NV5')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM13', N'MS29', 0, NULL, NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM14', N'MS16', 1, CAST(N'2023-01-10' AS Date), NULL, N'NV5')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM15', N'MS31', 0, NULL, NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM16', N'MS35', 0, NULL, NULL, N'NV1')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM17', N'MS19', 1, CAST(N'2023-05-10' AS Date), NULL, N'NV5')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM18', N'MS33', 1, CAST(N'2022-04-20' AS Date), NULL, N'NV2')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM19', N'MS07', 1, CAST(N'2023-12-01' AS Date), 0, N'NV3')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM20', N'MS26', 1, CAST(N'2023-09-05' AS Date), 0, N'NV3')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM21', N'MS33', 1, CAST(N'2023-04-10' AS Date), NULL, N'NV1')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM22', N'MS28', 0, CAST(N'2022-03-30' AS Date), NULL, N'NV4')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM23', N'MS39', 0, CAST(N'2023-12-14' AS Date), 0, N'NV4')
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPhieuMuon], [MaSach], [TinhTrang], [NgayTraSach], [TienPhat], [MaNhanVienNhanSachTra]) VALUES (N'MPM25', N'MS39', 0, CAST(N'1900-01-01' AS Date), 0, N'NV4')
GO
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG01', N'Vũ Nam Phong', CAST(N'2002-06-02' AS Date), N'Nam', N'Thái Bình', N'DHTI14A12HN', CAST(N'2022-11-11' AS Date), N'NV1', N'NamPhong')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG02', N'Tạ Kim Tuyến', CAST(N'2000-10-31' AS Date), N'Nam', N'Thái Bình', N'DHTD13A2HN', CAST(N'2021-01-01' AS Date), N'NV2', N'KimTuyen')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG03', N'Vũ Thanh Huyền', CAST(N'2001-01-26' AS Date), N'Nữ', N'Hà Nội', N'DHMA14A2HN', CAST(N'2022-03-06' AS Date), N'NV3', N'ThanhHuyen')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG04', N'Bùi Thị Thanh Tuyền', CAST(N'2002-10-22' AS Date), N'Nữ', N'Hà Nam', N'DHTI14A11HN', CAST(N'2023-02-07' AS Date), N'NV1', N'ThanhTuyen')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG05', N'Trần Thái Sơn', CAST(N'2000-03-06' AS Date), N'Nam', N'Nam Định', N'DHDT13A2HN', CAST(N'2022-02-02' AS Date), N'NV2', N'ThaiSon')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG06', N'Nguyễn Quốc Đạt', CAST(N'2004-02-13' AS Date), N'Nam', N'Thái Bình', N'DHKT15A12HN', CAST(N'2023-02-04' AS Date), N'NV3', N'QuocDat')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG07', N'Tạ Quốc Trí', CAST(N'2002-03-05' AS Date), N'Nam', N'Hưng Yên', N'DHTD14A3HN', CAST(N'2023-06-04' AS Date), N'NV4', N'QuocTri')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG08', N'Phạm Hồng Đức', CAST(N'2003-03-09' AS Date), N'Nam', N'Nghệ An', N'DHTI142HN', CAST(N'2022-04-06' AS Date), N'NV2', N'HongDuc')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG09', N'Đoàn Minh Thắng', CAST(N'2002-06-06' AS Date), N'Nam', N'Thái Bình', N'DHKT14A13HN', CAST(N'2023-02-06' AS Date), N'NV1', N'MinhThang')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG10', N'Nguyễn Chung Thủy', CAST(N'2003-02-06' AS Date), N'Nữ', N'Hà Nội', N'DHMT142HN', CAST(N'2022-12-16' AS Date), N'NV2', N'ChungThuy')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG11', N'Nguyễn Minh Đức', CAST(N'2000-03-08' AS Date), N'Nam', N'Hải Phòng', N'DHTD13A2HN', CAST(N'2020-01-06' AS Date), N'NV3', N'MinhDuc')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG12', N'Nguyễn Cẩm Tú', CAST(N'2002-05-07' AS Date), N'Nữ', N'Hải Dương', N'DHMA14A3HN', CAST(N'2021-05-04' AS Date), N'NV1', N'CamTu')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG13', N'Nhâm Thị Trang', CAST(N'2002-11-29' AS Date), N'Nữ', N'Thái Bình', N'DHKT14A2HN', CAST(N'2022-11-02' AS Date), N'NV2', N'TrangNham')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG14', N'Nguyễn Quỳnh Hương', CAST(N'2002-06-23' AS Date), N'Nữ', N'Thái Bình', N'DHQT14A3HN', CAST(N'2022-03-06' AS Date), N'NV3', N'QuynhHuong')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG15', N'Vũ Quang Vinh', CAST(N'2002-07-02' AS Date), N'Nam', N'Hà Tĩnh', N'DHXD14A3N', CAST(N'2023-05-07' AS Date), N'NV4', N'QuangVinh')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG16', N'Trần Trung Dũng', CAST(N'2002-05-08' AS Date), N'Nam', N'Điện Biên', N'DHD14A3HN', CAST(N'2022-06-07' AS Date), N'NV2', N'TrungDung')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG17', N'Tạ Văn Tiến', CAST(N'2002-04-11' AS Date), N'Nam', N'Hải Phòng', N'DHTI14A3HN', CAST(N'2023-04-06' AS Date), N'NV4', N'VanTien')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG18', N'Vũ Hồng Thi', CAST(N'2002-09-24' AS Date), N'Nữ', N'Thái Bình', N'DHMA14A2HN', CAST(N'2022-01-14' AS Date), N'NV1', N'HongThi')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG19', N'Nguyễn Hữu Nam', CAST(N'2000-06-18' AS Date), N'Nam', N'Thái Nguyên', N'DHTD14A3HN', CAST(N'2023-04-06' AS Date), N'NV4', N'HuuNam')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG20', N'Lê Duy Thành', CAST(N'2002-11-27' AS Date), N'Nam', N'Hà Nam', N'DHTD14A6HN', CAST(N'2022-06-09' AS Date), N'NV4', N'ThanhLe')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG21', N'Bùi Mai Anh', CAST(N'2007-11-09' AS Date), N'Nam', N'Ninh Bình', N'MANGMTA13', CAST(N'2023-11-15' AS Date), N'NV2', N'MaiAnh')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG23', N'Trần Lan Hương', CAST(N'1998-11-06' AS Date), N'Nữ', N'Hà Nội', N'DHTI14A1', CAST(N'2023-11-09' AS Date), N'NV2', N'LanHuong')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG24', N'Trần Mai Hương', CAST(N'2006-11-04' AS Date), N'Nữ', N'Nam Định', N'DHTI17A12', CAST(N'2023-11-10' AS Date), N'NV2', N'MaiHuong')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG27', N'Nguyễn Thành', CAST(N'2000-11-11' AS Date), N'Nam', N'Thái Bình', N'DHTI14A12HN', CAST(N'2023-11-14' AS Date), N'NV1', N'thanh1')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG28', N'Bùi Ngọc Anh', CAST(N'1999-11-13' AS Date), N'Nữ', N'Ninh Bình', N'DHTI17A12', CAST(N'2023-11-09' AS Date), N'NV3', N'NgocAnh')
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [DiaChi], [LopHoc], [NgayTaoThe], [MaNhanVienTaoThe], [TenDangNhap]) VALUES (N'DG29', N'Nguyễn Thùy Chi', CAST(N'2006-11-04' AS Date), N'Nữ', N'Hà Nam', N'DHTI18A1', CAST(N'2023-11-03' AS Date), N'NV1', N'ThuyChi')
GO
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'', N'', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'1', N'1', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'12', N'12', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'33', N'33', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'5', N'5', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'6', N'6', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'7', N'7', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'8', N'8', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'9', N'9', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'An123', N'234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Anh12', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'c5', N'2', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'CamTu', N'12656898', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ChungThuy', N'26051999', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Dat123', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'DinhVu', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'DinhVu123', N'', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'DinhVu1234', N'456', N'NhanVien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ee', N'1111', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'HoaiNam', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'HongDuc', N'21565252', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'HongThi', N'24092002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Huong123', N'234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'HuuNam', N'12335652', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'KimTuyen', N'31102000', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Lan12', N'3456', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Lan123', N'234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'LanHuong', N'3456', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Mai1', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MaiAnh', N'1234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MaiHuong', N'345', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MaiLan12', N'3456', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MaiPhuong123', N'', N'NhanVien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MinhDuc', N'12456326', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MinhThang', N'12538643', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'MinhVan', N'5678', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'NamPhong', N'02062002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'NgocAnh', N'567', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'PhuongDung', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'QuangVinh', N'02072002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'QuocDat', N'23545823', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'QuocTri', N'13250242', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'QuynhHuong', N'13062002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThaiSon', N'13012000', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'thanh1', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThanhDat', N'54542335', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThanhHuyen', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThanhLe', N'27112002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThanhNguyen', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThanhTuyen', N'22102002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThuyChi', N'1234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThuyChi1', N'1234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'ThuyenNguyen', N'12345', N'Nhanvien')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'Tien112', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'TienDat', N'123', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'TrangBui', N'12345', N'Admin')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'TrangNham', N'29112002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'TrinhVu', N'12345', N'Admin')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'TrungDung', N'08052002', N'Docgia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'VanCong', N'1234', N'DocGia')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [LoaiNguoiDung]) VALUES (N'VanTien', N'11042002', N'Docgia')
GO
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [TenDangNhap]) VALUES (N'NV1', N'Nguyễn Thị Thuyên', CAST(N'1997-05-01' AS Date), N'Nữ', 859548331, N'ThuyenNguyen')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [TenDangNhap]) VALUES (N'NV2', N'Nguyễn Văn Thành', CAST(N'1997-05-31' AS Date), N'Nam', 988310502, N'ThanhNguyen')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [TenDangNhap]) VALUES (N'NV3', N'Vũ Thị Phương Dung', CAST(N'1998-02-13' AS Date), N'Nữ', 987521607, N'PhuongDung')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [TenDangNhap]) VALUES (N'NV4', N'Nguyễn Hoài Nam', CAST(N'1999-03-26' AS Date), N'Nam', 346555454, N'HoaiNam')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [TenDangNhap]) VALUES (N'NV5', N'Nguyen Đình Vũ', CAST(N'1997-02-06' AS Date), N'Nam', 344562353, N'DinhVu123')
GO
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBDA', N'Đông A')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBHCM', N'Hồ Chí Minh')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBHN', N'Hà Nội')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBKD', N'Kim Đồng')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBLD', N'Lao Động')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBNN', N'Nhã Nam')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBT', N'Trẻ')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBTN', N'Thanh niên')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBTT', N'Tuổi trẻ')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (N'NXBVH', N'Văn học')
GO
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM01', N'NV2', CAST(N'2023-09-23' AS Date), N'DG01')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM02', N'NV1', CAST(N'2022-11-12' AS Date), N'DG01')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM03', N'NV3', CAST(N'2022-07-10' AS Date), N'DG20')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM04', N'NV4', CAST(N'2022-03-06' AS Date), N'DG02')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM05', N'NV2', CAST(N'2022-04-10' AS Date), N'DG03')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM06', N'NV2', CAST(N'2023-06-08' AS Date), N'DG03')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM07', N'NV5', CAST(N'2023-03-17' AS Date), N'DG04')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM08', N'NV1', CAST(N'2022-03-02' AS Date), N'DG05')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM09', N'NV3', CAST(N'2023-02-05' AS Date), N'DG06')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM10', N'NV2', CAST(N'2023-10-12' AS Date), N'DG07')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM11', N'NV5', CAST(N'2023-06-05' AS Date), N'DG07')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM12', N'NV4', CAST(N'2023-01-06' AS Date), N'DG08')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM13', N'NV1', CAST(N'2023-03-06' AS Date), N'DG09')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM14', N'NV5', CAST(N'2023-01-06' AS Date), N'DG10')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM15', N'NV2', CAST(N'2021-03-17' AS Date), N'DG11')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM16', N'NV3', CAST(N'2022-03-17' AS Date), N'DG12')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM17', N'NV1', CAST(N'2023-05-07' AS Date), N'DG13')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM18', N'NV5', CAST(N'2022-03-18' AS Date), N'DG14')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM19', N'NV4', CAST(N'2023-05-08' AS Date), N'DG15')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM20', N'NV2', CAST(N'2023-09-01' AS Date), N'DG16')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM21', N'NV1', CAST(N'2023-04-07' AS Date), N'DG17')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM22', N'NV3', CAST(N'2022-01-30' AS Date), N'DG18')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM23', N'NV2', CAST(N'2023-04-16' AS Date), N'DG19')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM24', N'NV5', CAST(N'2023-06-07' AS Date), N'DG16')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM25', N'NV1', CAST(N'2023-11-01' AS Date), N'DG16')
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaNhanVienLapPhieu], [NgayLap], [MaDocGia]) VALUES (N'MPM26', N'NV5', CAST(N'2023-11-30' AS Date), N'DG12')
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS02', N'Truyện Kiều', N'Văn học', N'TG02', N'NXBHN', CAST(N'2021-08-23' AS Date), 45)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS03', N'Dám mơ lớn đừng hoài phí tuổi trẻ', N'Văn học', N'TG27', N'NXBTT', CAST(N'2020-07-16' AS Date), 25)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS04', N'Chồng Xứ Lạ', N'Tiểu thuyết', N'TG09', N'NXBNN', CAST(N'2018-05-31' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS05', N'Chí phèo', N'Văn học', N'TG03', N'NXBDA', CAST(N'2023-09-23' AS Date), 25)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS06', N'Chuyên luận về Tam giác Số học', N'Toán học', N'TG05', N'NXBHN', CAST(N'2015-02-13' AS Date), 10)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS07', N'Bếp Lửa', N'Văn học', N'TG06', N'NXBTN', CAST(N'2022-11-29' AS Date), 40)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS08', N'Số đỏ', N'Văn học', N'TG07', N'NXBLD', CAST(N'2020-10-22' AS Date), 60)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS09', N'Gió lộng', N'Văn học', N'TG04', N'NXBVH', CAST(N'2017-05-26' AS Date), 50)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS10', N'Bag of Bones', N'Kinh dị', N'TG08', N'NXBNN', CAST(N'2021-06-02' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS11', N'Tôi và chúng ta', N'Thơ ca', N'TG10', N'NXBVH', CAST(N'2020-03-26' AS Date), 22)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS12', N'Chúa tể của những chiếc nhẫn', N'Tiểu thuyết', N'TG11', N'NXBKD', CAST(N'2019-09-02' AS Date), 41)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS13', N'Trăm năm cô đơn', N'Tiểu thuyết', N'TG12', N'NXBHCM', CAST(N'2020-02-14' AS Date), 15)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS14', N'Đáp án của thời gian', N'Văn học', N'TG27', N'NXBTT', CAST(N'2018-09-24' AS Date), 50)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS15', N'Romeo Và Juliet', N'Kịch', N'TG13', N'NXBT', CAST(N'2015-11-28' AS Date), 22)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS16', N'Nhật ký người điên', N'Truyện', N'TG14', N'NXBNN', CAST(N'2018-07-20' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS17', N'Tôi thấy hoa vàng trên cỏ xanh', N'Truyện', N'TG15', N'NXBTT', CAST(N'2014-07-01' AS Date), 25)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS18', N'Từ ấy', N'Văn học', N'TG04', N'NXBVH', CAST(N'2022-03-20' AS Date), 51)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS19', N'Mưa Nhã Nam', N'Truyện ngắn', N'TG16', N'NXBT', CAST(N'2021-11-01' AS Date), 14)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS20', N'Buồn làm sao buông', N'Tản văn', N'TG17', N'NXBHCM', CAST(N'2020-04-16' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS21', N'Sợi Dây Tình Yêu', N'Tiểu thuyết', N'TG09', N'NXBVH', CAST(N'2022-01-20' AS Date), 25)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS22', N'Doreamon', N'Truyện tranh', N'TG18', N'NXBKD', CAST(N'2021-01-11' AS Date), 16)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS23', N'Cửa sông', N'Văn học', N'TG19', N'NXBVH', CAST(N'2016-06-02' AS Date), 25)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS24', N'Đợi đi… vết thương nào rồi cũng sẽ lành', N'Văn học', N'TG27', N'NXBT', CAST(N'2021-01-26' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS25', N'Ai rồi cũng sẽ khác', N'Tự truyện', N'TG20', N'NXBDA', CAST(N'2023-01-23' AS Date), 21)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS26', N'Việt Bắc', N'Văn học', N'TG04', N'NXBLD', CAST(N'2018-12-02' AS Date), 50)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS27', N'Mỉm cười cho qua', N'Tự truyện', N'TG21', N'NXBNN', CAST(N'2018-02-14' AS Date), 23)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS28', N'Tuổi trẻ dáng giá bao nhiêu', N'Truyện ngắn', N'TG22', N'NXBHCM', CAST(N'2017-09-16' AS Date), 10)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS29', N'Hai mươi dặm dưới biển', N'Tiểu thuyết', N'TG23', N'NXBTT', CAST(N'2020-08-09' AS Date), 36)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS30', N'Cánh đồng bất tận', N'Truyện ngắn', N'TG24', N'NXBT', CAST(N'2023-06-23' AS Date), 35)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS31', N'Chuyện thơ', N'Trữ tình', N'TG25', N'NXBVH', CAST(N'2020-03-26' AS Date), 15)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS32', N'Chuyện kể dưới ngọc đèn đường', N'Tiểu thuyết', N'TG09', N'NXBDA', CAST(N'2021-07-26' AS Date), 30)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS33', N'Thơ Xuân Diệu', N'Thơ ca', N'TG26', N'NXBVH', CAST(N'2023-09-23' AS Date), 20)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS34', N'Nhật ký trong tù', N'Thơ ca', N'TG28', N'NXBTT', CAST(N'2021-04-14' AS Date), 36)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS35', N'Gió sông Hồng', N'Thơ ca', N'TG29', N'NXBDA', CAST(N'2018-11-23' AS Date), 16)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS36', N'Đất nước', N'Thơ ', N'TG30', N'NXBHCM', CAST(N'2014-08-16' AS Date), 41)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS37', N'Pensées', N'Toán học', N'TG05', N'NXBNN', CAST(N'2015-07-13' AS Date), 31)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS38', N'Miến ngon Hà Nội', N'Văn học', N'TG06', N'NXBVH', CAST(N'2021-09-05' AS Date), 10)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS39', N'The Silmarillion', N'Tiểu thuyết', N'TG11', N'NXBT', CAST(N'2020-07-20' AS Date), 13)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS40', N'Mắt biếc', N'Truyện ngắn', N'TG15', N'NXBKD', CAST(N'2023-07-06' AS Date), 20)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS41', N'Vừng ơi ', N'truyện ngắn', N'TG01', N'NXBKD', CAST(N'2023-11-01' AS Date), 10)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS412', N'Vừng ơi ', N'truyện ngắn', N'TG01', N'NXBKD', CAST(N'2023-11-01' AS Date), 10)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [LoaiSach], [MaTacGia], [MaNhaXuatBan], [NgayXuatBan], [SoLuong]) VALUES (N'MS42', N'Gió sông Hồng', N'Thơ ca', N'TG29', N'NXBDA', CAST(N'2018-11-23' AS Date), 16)
GO
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG01', N'Trần Văn An2')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG02', N'Nguyễn Du')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG03', N'Nam Cao')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG04', N'Tố Hữu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG05', N'Blaise Pascal')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG06', N'Vũ Bằng')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG07', N'Vũ Trọng Phụng')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG08', N'Stephen King')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG09', N'Trang Hạ')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG10', N'Lưu Quang Vu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG11', N'J.R.R.Tolkien')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG12', N'Gabriel Garcia Marquez')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG13', N'William Shakespear')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG14', N'Lỗ Tấn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG15', N'Nguyễn Nhật Ánh')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG16', N'Nguyễn Huy Thiệp')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG17', N'Anh Khang')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG18', N' Fujiko Fujio')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG19', N'Nguyễn Minh Châu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG20', N'Hamlet Truong')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG21', N'Iris Cao')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG22', N'Rosie Nguyễn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG23', N'Jules Verne
')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG24', N'Nguyễn Ngọc Tú')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG25', N'Hoài Thanh')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG26', N'Xuân Diệu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG27', N'Lư Tư Hạo')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG28', N'Quách Tấn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG29', N'Xuân Quý')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG30', N'Nguyên Ðình Thi')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG31', N'Trần Việt An')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG33', N'Nguyễn Tấn')
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD FOREIGN KEY([MaNhanVienNhanSachTra])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NGUOIDUNG] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NGUOIDUNG] ([TenDangNhap])
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD FOREIGN KEY([MaNhanVienLapPhieu])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD FOREIGN KEY([MaNhaXuatBan])
REFERENCES [dbo].[NHAXUATBAN] ([MaNhaXuatBan])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TACGIA] ([MaTacGia])
GO
