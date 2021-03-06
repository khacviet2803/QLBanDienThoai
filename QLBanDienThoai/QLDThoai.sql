USE [QLDienTh]
GO
/****** Object:  Table [dbo].[DDiem]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DDiem](
	[MaDD] [nchar](10) NOT NULL,
	[TenDD] [nvarchar](50) NOT NULL,
	[Thongtinchung] [nvarchar](100) NOT NULL,
	[Chucnangcoban] [nvarchar](100) NOT NULL,
	[Thongsochung] [nvarchar](100) NOT NULL,
	[CauHinh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDonBan]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDonBan](
	[MaHDB] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaBan] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
	[TienDTT] [float] NOT NULL,
	[NgayCuoiTT] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDonMua]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDonMua](
	[MaHDM] [nchar](10) NOT NULL,
	[MaNSX] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaNhap] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
	[Ngaynhap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hinh]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hinh](
	[MaMH] [nchar](10) NOT NULL,
	[Hinhanh] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHang]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MHang]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MHang](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
	[MaNSX] [nchar](10) NOT NULL,
	[TenNSX] [nvarchar](50) NOT NULL,
	[MADD] [nchar](10) NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[GiaNhap] [float] NOT NULL,
	[GiaXuat] [float] NOT NULL,
	[NgayThang] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ngdung]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ngdung](
	[Username] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[Gioitinh] [nchar](10) NOT NULL,
	[DT] [int] NOT NULL,
	[Quyen] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaNSX]    Script Date: 14/12/2015 11:50:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaNSX](
	[MaNSX] [nchar](10) NOT NULL,
	[TenNSX] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AP069E    ', N'Ap 6S', N'Bảo hành 12 tháng ,TT:mới'',N''Camera sau:12MP ,camera trước: 5MP ,xem phim \nghe nhạc ,1 sim', N'Camera sau:12MP ,camera trước: 5MP ,xem phim \nghe nhạc ,1 sim', N'Màn hình Retina 4.7in 3D Touch ,Wifi/Bluetooth/GPS/ 3G/ 4G LTE/ EDGE , 13.8 x 6.7 x 0.71 ,1715 mAh', N'iOS 9, RAM: 2GB; ROM: 64GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AP236W    ', N'Ap 5 ', N'Bảo hành 12 tháng ,TT:mới ', N'Camera sau:8.0MP ,camera trước: 1.2MP ,xem phim \Không thẻ nhớ , 1 sim', N'Màn hình DVGA: 4.0 ,Wifi/Bluetooth/GPS/ 3G/ LTE/ GPRS ,20x10x05 ,1560 mAh', N'iOS 8.0, RAM: 1GB; ROM: 16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AP345Y    ', N'Ap 5S ', N'Bảo hành 12 tháng ,TT:mới', N'Camera sau:8.0MP ,camera trước: 1.2MP ,xem phim \nghe nhạc ,1 sim', N'Màn hình DVGA: 4.0 ,Wifi/Bluetooth/GPS/ 3G/ LTE/ GPRS ,12.3 x 5.8 x 0.71 ,1560 mAh', N'iOS 8.0, RAM: 1GB; ROM: 32GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AP643R    ', N'Ap 6S Plus', N'Bảo hành 12 tháng ,TT:mới', N'Camera sau:12MP ,camera trước: 5MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình Retina 5.5in 3DTouch ,Wifi/Bluetooth/GPS/ 3G/ 4G LTE/ EDGE ,15.8 x 7.8 x 0.73 ,2915 mAh', N'iOS 9.0, RAM: 2GB; ROM: 16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AS082E    ', N'As Z5', N'Bảo hành 12 tháng ,TT:mới', N'Camera:8MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình 5.0 ,Wifi/Bluetooth/GPS/ 3G ,14.82 x 7.28 x 1.034,2050 mAh', N'Android 4.3 Asus Zenphone ZenUI ,RAM: 1GB; ROM: 8GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AS233Q    ', N'As Z2', N'Bảo hành 12 tháng ,TT:mới ', N'Camera sau:13MP ,camera trước: 5MP ,xem phim nghe nhạc, 1sim', N'Màn hình 5.5 ,Wifi/Bluetooth/GPS/ 3G ,14.82x7.28x0.55, 2050 mAh', N'Android v5.0 (Lollipop) ,RAM: 1GB; ROM: 64GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AS234T    ', N'As Selfie', N'Bảo hành 12 tháng ,TT:mới', N'Camera sau:13MP ,camera trước: 13MP ,xem phim, nghe nhạc,1 sim', N'Màn hình HD 5.5 ,Wifi/Bluetooth/GPS/ 3G ,15x7x1.5, 3000 mAh', N'Android 5.0 (Lollipop) ,RAM: 3GB; ROM: 32GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'AS756H    ', N'As 2 ZE551ML', N'Bảo hành 12 tháng ,TT:mới ', N'Camera sau:13MP ,camera trước: 5MP ,xem phim ,nnghe nhạc, 1 sim', N'Màn hình HD 5.5 ,Wifi/Bluetooth/GPS/ 3G ,15.25x7.72x1.09, 3000 mAh', N'Android 5.0 (Lollipop) ,RAM: 2GB; ROM: 16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'e         ', N'jjjj', N'hhh', N'hbhh', N'hjhjk', N'hjhj')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'f         ', N'hjj', N'jhjj', N'jhjj', N'jhjj', N'hjhj')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'HT343D    ', N'HTC526G', N'Bảo hành 12 tháng ,TT:mới  ', N'Camera sau:8MP ,camera trước: 2MP ,xem phim \nghe nhạc, 2 sim', N'Màn hình HD 4.7 ,Wifi/Bluetooth/GPS/ 3G ,13.98 x 6.98 x 0.99 ,2000 mAh', N'Android 4.4 (KitKat) ,RAM: 1GB; ROM:8GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'HT499E    ', N'HTCM7', N'Bảo hành 24 tháng ,TT:mới ', N'Camera sau:5MP ,camera trước: 4MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình HD 4.7 ,Wifi/Bluetooth/GPS/ 3G , 14 x 7 x 1, 2300 mAh', N'Android 4.1.2 jelly bean ,RAM: 2GB; ROM: 32GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'HT557G    ', N'HTCM9 ', N'Bảohành 24tháng ,TT:mới ', N'Camera sau:21MP, camera trước: 4MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình HD5.0 ,Wifi/Bluetooth/GPS/ 3G , 14.46x6.97x0.96, 3000mAh', N'Android 5.1  ,RAM: 3GB; ROM:32GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'HT566F    ', N'HTCM8', N'Bảo hành 24 tháng ,TT:mới ', N'Camera sau:Dual 4.0 UltraPixel ,camera trước: 5MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình HD 5.0 ,Wifi/Bluetooth/GPS/ 3G ,20x20x5, 2600 mAh', N'Android 4.4 (KitKat) ,RAM: 2GB; ROM:16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SA452R    ', N'SS V Plus', N'Bảo hành 12 tháng ,TT:mới', N'Camera sau:3MP ,camera trước: 0.3MP ,xem phim ,nghe nhạc ,2 sim', N'Màn hình 4.0 ,Wifi,Bluetooth, 12.15 x 6.31 x 1.06,1500 mAh', N'Android 4.4, RAM: 512 MB; ROM: 4GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SA45T7    ', N'SS GNote 5 ', N'Bảo hành 12 tháng ,TT:mới ', N'Camera sau:16MP ,camera trước: 5MP ,xem phim \nnghe nhạc ,1 sim', N'Màn hình HD 5.0 ,Wifi/3G/4GBluetooth ,15.32 x 7.61 x 0.76 , 3000 mAh', N'Android 5.0(Lollipop), RAM: 4GB; ROM: 32GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SA4H67    ', N'SS GS6 Edge ', N'Bảo hành 24 tháng ,TT:mới', N'Camera sau:16MP ,camera trước: 5MP ,xem phim \nnghe nhạc ,1 sim', N'Màn hình HD 5.1 ,Wifi/3G/Bluetooth ,15 x 8 x 1, 2600 mAh', N'Android 5.0(Lollipop), RAM: 3GB; ROM: 128GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SA937E    ', N'SS GA5', N'Bảo hành 12 tháng ,TT:mới', N'Camera sau:13MP ,camera trước: 5MP ,xem phim ,nghe nhạc ,1 sim', N'Màn hình HD 5.0 ,Wifi/3G/Bluetooth, 139.3 x 69.7 x 6.7, 2300 mAh', N'Android 4.4(KitKat), RAM: 2GB; ROM: 16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SK7465T   ', N'Sk A900 ', N'Bảohành 12 tháng ,TT:mới ', N'Camera sau:13MP, camera trước: 2.1MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình IPS-LCD 5.6 ,Wifi/Bluetooth/GPS/ 2G , 15.14 X 7.64 X 0.95, 3140mAh', N'Android 4.4  ,RAM: 2GB; ROM:16GB')
INSERT [dbo].[DDiem] ([MaDD], [TenDD], [Thongtinchung], [Chucnangcoban], [Thongsochung], [CauHinh]) VALUES (N'SK7563M   ', N'Sk A910 ', N'Bảohành 12 tháng ,TT:mới ', N'Camera sau:13MP, camera trước: 3MP ,xem phim \nghe nhạc, 1 sim', N'Màn hình HD 5.3 ,Wifi/Bluetooth/GPS/ 3G , 13.39 x 6.97 x 0.67, 3220mAh', N'Android 4.4  ,RAM: 3GB; ROM:32GB')
INSERT [dbo].[HDonBan] ([MaHDB], [MaMH], [MaKH], [SoLuong], [GiaBan], [TongTien], [TienDTT], [NgayCuoiTT]) VALUES (N'Hd3       ', N'LP        ', N'KH01      ', 3, 5000000, 15000000, 15000000, CAST(0x0000A56D00000000 AS DateTime))
INSERT [dbo].[HDonBan] ([MaHDB], [MaMH], [MaKH], [SoLuong], [GiaBan], [TongTien], [TienDTT], [NgayCuoiTT]) VALUES (N'hf        ', N'yygy      ', N'KH03      ', 3, 444, 1332, 1332, CAST(0x0000A56D00000000 AS DateTime))
INSERT [dbo].[HDonBan] ([MaHDB], [MaMH], [MaKH], [SoLuong], [GiaBan], [TongTien], [TienDTT], [NgayCuoiTT]) VALUES (N'jh        ', N'tgh       ', N'KH01      ', 2, 444, 888, 888, CAST(0x0000A56D00000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM01     ', N'HTC       ', N'125G5     ', 33, 3490000, 115170000, CAST(0x000092DF00000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM02     ', N'Apple     ', N'549R2     ', 40, 3654000, 146160000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM03     ', N'HTC       ', N'125G5     ', 33, 3490000, 115170000, CAST(0x000092DF00000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM04     ', N'Sky       ', N'423A2     ', 42, 2290000, 96180000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM05     ', N'Apple     ', N'eree      ', 10, 3555, 35550, CAST(0x0000917100000000 AS DateTime))
INSERT [dbo].[HDonMua] ([MaHDM], [MaNSX], [MaMH], [SoLuong], [GiaNhap], [TongTien], [Ngaynhap]) VALUES (N'HDM06     ', N'a         ', N'LP        ', 6, 2000000, 12000000, CAST(0x0000913400000000 AS DateTime))
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'123D3     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Samsung-Galaxy-V-Plus.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'125G5     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\HTC-One-M8.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'132T3     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Asus-Zenphone-Zenfone-2.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'143A5     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\HTC-One-M9.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'313W3     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Asus-Zenphone-Zenfone-2-ZE551ML.png')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'324R5     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Samsung-Galaxy-A5.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'423A2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Sky-Vega-Secret-Up-A900.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'424N5     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\HTC-Desire-526G.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'434R4     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Apple-iPhone-6S.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'445J6     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Sky-Vega-Iron-2-A910.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'535F5     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Samsung-Galaxy-S6-Edge.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'545L2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Asus-Zenphone-Zenfone-Selfie.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'549R2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Apple-iPhone5.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'588G3     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Samsung-Galaxy-Note-5.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'656J2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Apple-iPhone-6S-Plus.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'657S2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Asus-Zenphone-Zenfone-5.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'667E2     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\HTC-One-M7.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'678E6     ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\Apple-iPhone-5S.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'eree      ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\iphone_3GS_b.jpg')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'jjk       ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\120.png')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'LP        ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\gnome_phone.png')
INSERT [dbo].[Hinh] ([MaMH], [Hinhanh]) VALUES (N'yygy      ', N'F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\images\call_mobile_icon.jpg')
INSERT [dbo].[KHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email]) VALUES (N'KH01      ', N'ly vo', N'4grg', 89899, N'thgh.gr')
INSERT [dbo].[KHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email]) VALUES (N'KH02      ', N'KH2', N'5 ggyy', 99998, N'ghj.jjhj')
INSERT [dbo].[KHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email]) VALUES (N'KH03      ', N'hoa', N'6 jhj', 898888, N'th.jk.kl')
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'123D3     ', N'Samsung Galaxy V Plus', N'SS        ', N'SamSung', N'SA452R    ', 50, 610000, 1622000, CAST(0x00008FFD00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'125G5     ', N'HTC One M8', N'HTC       ', N'HTC One', N'HT566F    ', 2043, 3490000, 6490000, CAST(0x00009E2B00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'132T3     ', N'Asus Zenphone Zenfone 2 ', N'Asus      ', N'Asus Zenphone', N'AS233Q    ', 37, 3647000, 7400000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'143A5     ', N'HTC One M9', N'HTC       ', N'HTC One', N'HT557G    ', 39, 6290000, 11990000, CAST(0x0000906000000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'313W3     ', N'Asus Zenphone Zenfone 2 ZE551ML', N'Asus      ', N'Asus Zenphone', N'AS756H    ', 43, 1231000, 4990000, CAST(0x0000A11D00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'324R5     ', N'Samsung Galaxy A5', N'SS        ', N'SamSung', N'SA937E    ', 38, 3390000, 6390000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'423A2     ', N'Sky Vega Secret Up A900', N'Sky       ', N'Sky Vega', N'SK7465T   ', 45, 2290000, 4889000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'424N5     ', N'HTC Desire 526G', N'HTC       ', N'HTC One', N'HT343D    ', 37, 1090000, 2879000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'434R4     ', N'Apple iPhone 6S  ', N'Apple     ', N'Iphone', N'AP069E    ', 52, 8465000, 18940000, CAST(0x00009F9800000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'445J6     ', N'Sky Vega Iron 2 A910', N'Sky       ', N'Sky Vega', N'SK7563M   ', 41, 3590000, 6899000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'535F5     ', N'Samsung Galaxy S6 Edge ', N'SS        ', N'SamSung', N'SA4H67    ', 39, 3565000, 12990000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'545L2     ', N'Asus Zenphone Zenfone Selfie', N'Asus      ', N'Asus Zenphone', N'AS234T    ', 42, 3231000, 5990000, CAST(0x0000917200000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'549R2     ', N'Apple iPhone5 ', N'Apple     ', N'Iphone', N'AP236W    ', 54, 3654000, 5399000, CAST(0x00008FE700000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'588G3     ', N'Samsung Galaxy Note 5', N'SS        ', N'SamSung', N'SA45T7    ', 40, 8345000, 15960000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'656J2     ', N'Apple iPhone 6S Plus ', N'Apple     ', N'Iphone', N'AP643R    ', 41, 10647000, 19390000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'657S2     ', N'Asus Zenphone Zenfone 5 ', N'Asus      ', N'Asus Zenphone', N'AS082E    ', 40, 1647000, 3990000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'667E2     ', N'HTC One M7', N'HTC       ', N'HTC One', N'HT499E    ', 42, 1967000, 4100000, CAST(0x00008ECD00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'678E6     ', N'Apple iPhone 5S ', N'Apple     ', N'Iphone', N'AP345Y    ', 38, 4465000, 9459000, CAST(0x0000916A00000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'eree      ', N'ly', N'Apple     ', N'Iphone', N'AS082E    ', 7, 3555, 4555, CAST(0x0000917100000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'jjk       ', N'hhh', N'l         ', N'lycute', N'AP236W    ', 4, 2000000, 3330000, CAST(0x0000915500000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'LP        ', N'KH', N'a         ', N'aa', N'AP643R    ', 3, 2000000, 5000000, CAST(0x0000913400000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'tgh       ', N'ghh', N'a         ', N'aa', N'AP236W    ', 27, 333, 444, CAST(0x00008FE800000000 AS DateTime))
INSERT [dbo].[MHang] ([MaMH], [TenMH], [MaNSX], [TenNSX], [MADD], [SoLuongTon], [GiaNhap], [GiaXuat], [NgayThang]) VALUES (N'yygy      ', N'yyu', N'a         ', N'aa', N'AP236W    ', 5, 333, 444, CAST(0x0000900600000000 AS DateTime))
INSERT [dbo].[Ngdung] ([Username], [Password], [Hoten], [Gioitinh], [DT], [Quyen]) VALUES (N'quyly     ', N'hoquyly   ', N'Võ Thị Bích Ly', N'Nữ        ', 963193061, N'Khách hàng')
INSERT [dbo].[Ngdung] ([Username], [Password], [Hoten], [Gioitinh], [DT], [Quyen]) VALUES (N'trieu     ', N'binkhung  ', N'Nguyễn Vương Triều', N'Nam       ', 1636378848, N'Quản lý   ')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'a         ', N'aa', N'aa', 999, N'aa')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'Apple     ', N'Iphone', N'80 Lê Trọng Tấn', 91403402, N'www.apple.com')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'Asus      ', N'Asus Zenphone', N'545 Lê Hồng Phong', 8334996, N'www.asus.com')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'HTC       ', N'HTC One', N'140 Lý Thường Kiệt', 2958973, N'www.htc.vn')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'l         ', N'lycute', N'hoho', 99, N'hoho')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'Sky       ', N'Sky Vega', N'55 Lý Thường Kiệt', 8345332, N'www.sky.com')
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [Diachi], [DienThoai], [Email]) VALUES (N'SS        ', N'SamSung', N'28 Phan Ðang Luu', 8389765, N'www.samsung.com')
ALTER TABLE [dbo].[HDonBan]  WITH CHECK ADD  CONSTRAINT [HDonban_MH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MHang] ([MaMH])
GO
ALTER TABLE [dbo].[HDonBan] CHECK CONSTRAINT [HDonban_MH]
GO
ALTER TABLE [dbo].[HDonBan]  WITH CHECK ADD  CONSTRAINT [HDonMua_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHang] ([MaKH])
GO
ALTER TABLE [dbo].[HDonBan] CHECK CONSTRAINT [HDonMua_KH]
GO
ALTER TABLE [dbo].[HDonMua]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MHang] ([MaMH])
GO
ALTER TABLE [dbo].[HDonMua]  WITH CHECK ADD FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaNSX] ([MaNSX])
GO
ALTER TABLE [dbo].[Hinh]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MHang] ([MaMH])
GO
ALTER TABLE [dbo].[MHang]  WITH CHECK ADD FOREIGN KEY([MADD])
REFERENCES [dbo].[DDiem] ([MaDD])
GO
ALTER TABLE [dbo].[MHang]  WITH CHECK ADD FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaNSX] ([MaNSX])
GO
