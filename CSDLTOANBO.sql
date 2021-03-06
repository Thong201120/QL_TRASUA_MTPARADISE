USE [master]
GO
/****** Object:  Database [QL_TRASUA]    Script Date: 01/08/2020 4:42:32 CH ******/
CREATE DATABASE [QL_TRASUA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_TRASUA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_TRASUA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_TRASUA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_TRASUA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QL_TRASUA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_TRASUA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_TRASUA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_TRASUA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_TRASUA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_TRASUA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_TRASUA] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_TRASUA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_TRASUA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_TRASUA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_TRASUA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_TRASUA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_TRASUA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_TRASUA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_TRASUA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_TRASUA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_TRASUA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_TRASUA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_TRASUA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_TRASUA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_TRASUA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_TRASUA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_TRASUA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_TRASUA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_TRASUA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_TRASUA] SET  MULTI_USER 
GO
ALTER DATABASE [QL_TRASUA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_TRASUA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_TRASUA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_TRASUA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_TRASUA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_TRASUA] SET QUERY_STORE = OFF
GO
USE [QL_TRASUA]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 01/08/2020 4:42:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[userpassword] [nvarchar](1000) NOT NULL,
	[displayName] [nvarchar](100) NOT NULL,
	[username] [nvarchar](100) NOT NULL,
	[cmnd] [nvarchar](50) NULL,
	[diachi] [nvarchar](500) NULL,
	[sodienthoai] [nvarchar](50) NULL,
	[typeuser] [int] NOT NULL,
 CONSTRAINT [PK__ACCOUNT__F3DBC5734915799D] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILLDRINKS]    Script Date: 01/08/2020 4:42:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILLDRINKS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[timecheckin] [datetime] NULL,
	[timecheckout] [datetime] NULL,
	[idtable] [int] NOT NULL,
	[billstatus] [int] NOT NULL,
	[giamgia] [int] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK__BILLDRIN__3213E83F04F53DFD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILLINFO]    Script Date: 01/08/2020 4:42:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILLINFO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idbill] [int] NOT NULL,
	[iddrink] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DRINK]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DRINK](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[drinkname] [nvarchar](100) NOT NULL,
	[iddrinklist] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DRINKLIST]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DRINKLIST](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[drinklistname] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DRINKTABLE]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DRINKTABLE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tablename] [nvarchar](100) NOT NULL,
	[tablestatus] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewTable]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewTable](
	[id] [int] NULL,
	[idbill] [int] NOT NULL,
	[iddrink] [int] NOT NULL,
	[count] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[stuffname] [nvarchar](100) NULL,
	[stuffamount] [int] NULL,
	[stuffprice] [int] NULL,
 CONSTRAINT [PK__STOCK__3213E83F73254882] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temptable]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temptable](
	[id] [int] NULL,
	[idbill] [int] NOT NULL,
	[iddrink] [int] NOT NULL,
	[count] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'1', N'Minh Trọng', N'1', N'456975312', N'0909978879', N'số 21, Long Hòa, Dầu Tiếng, Bình Dương', 1)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'0', N'Võ Thị C', N'3', N'124563441', N'ấp Đồng Bà Ba, Long Hòa, Dầu Tiếng, Bình Dương', N'0123654987', 1)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'1', N'Nguyễn Văn A', N'A', N'974569741', N'số 29, ấp Chợ, xã Mỹ An, huyện Mang Thít, Vĩnh Long', N'0321456789', 0)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'87654321', N'Trần Thị Mỹ B', N'B123', N'655122213', N'Số 45, Bắc Tân Uyên, Bình Dương', N'0854236942', 0)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'16021999', N'Bích Liên', N'LienGau123', N'281188699', N'Số 113/29/60, đường 30/4, P.Phú Hòa, Thủ Dầu Một, Bình Dương', N'0582529913', 1)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'20112000', N'Minh Thông', N'Thong2011', N'331904415', N'số 29, ấp Chợ, xã Mỹ An, huyện Mang Thít, Vĩnh Long', N'0999999999', 1)
INSERT [dbo].[ACCOUNT] ([userpassword], [displayName], [username], [cmnd], [diachi], [sodienthoai], [typeuser]) VALUES (N'19052000', N'Trí Trung', N'Trung1906', N'125467578', N'Phú Giáo', N'0657654543', 0)
SET IDENTITY_INSERT [dbo].[BILLDRINKS] ON 

INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (70, CAST(N'2020-06-14T08:51:03.980' AS DateTime), CAST(N'2020-06-14T08:51:07.860' AS DateTime), 3, 1, 1, 50490)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (71, CAST(N'2020-06-14T08:51:09.857' AS DateTime), CAST(N'2020-06-14T08:51:12.890' AS DateTime), 1, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (72, CAST(N'2020-06-14T08:51:18.283' AS DateTime), CAST(N'2020-06-14T08:51:22.553' AS DateTime), 4, 1, 1, 19800)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (73, CAST(N'2020-06-14T08:51:28.643' AS DateTime), CAST(N'2020-06-14T08:51:36.060' AS DateTime), 2, 1, 1, 44550)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (74, CAST(N'2020-06-14T08:51:43.640' AS DateTime), CAST(N'2020-06-14T08:51:57.003' AS DateTime), 2, 1, 15, 57817)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (75, CAST(N'2020-06-14T08:52:02.990' AS DateTime), CAST(N'2020-06-14T08:52:18.360' AS DateTime), 6, 1, 20, 80000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (76, CAST(N'2020-06-14T08:52:25.980' AS DateTime), CAST(N'2020-06-14T08:52:36.803' AS DateTime), 7, 1, 12, 35200)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (77, CAST(N'2020-06-14T08:52:43.600' AS DateTime), CAST(N'2020-06-14T08:53:24.527' AS DateTime), 20, 1, 50, 69000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (78, CAST(N'2020-06-14T08:53:27.637' AS DateTime), CAST(N'2020-06-14T08:53:35.153' AS DateTime), 16, 1, 50, 42000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (79, CAST(N'2020-06-14T13:01:52.713' AS DateTime), CAST(N'2020-06-14T13:02:00.080' AS DateTime), 4, 1, 1, 31680)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (80, CAST(N'2020-06-14T13:51:00.990' AS DateTime), CAST(N'2020-06-14T13:51:06.873' AS DateTime), 3, 1, 1, 50490)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (81, CAST(N'2020-06-14T16:06:08.153' AS DateTime), CAST(N'2020-06-14T22:23:17.910' AS DateTime), 2, 1, 1, 84150)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (82, CAST(N'2020-06-14T16:06:26.093' AS DateTime), CAST(N'2020-06-14T16:08:36.597' AS DateTime), 20, 1, 0, 105020)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (83, CAST(N'2020-06-14T16:07:01.163' AS DateTime), CAST(N'2020-06-14T16:07:07.620' AS DateTime), 3, 1, 1, 39600)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (84, CAST(N'2020-06-14T16:07:11.380' AS DateTime), CAST(N'2020-06-14T16:07:25.330' AS DateTime), 3, 1, 1, 81180)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (85, CAST(N'2020-06-14T16:08:49.317' AS DateTime), CAST(N'2020-06-14T16:08:58.360' AS DateTime), 11, 1, 7, 93000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (86, CAST(N'2020-06-14T16:40:47.223' AS DateTime), CAST(N'2020-06-14T16:41:13.910' AS DateTime), 20, 1, 15, 71400)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (87, CAST(N'2020-06-14T17:32:10.783' AS DateTime), CAST(N'2020-06-14T17:32:56.210' AS DateTime), 15, 1, 1, 21780)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (88, CAST(N'2020-06-14T17:32:46.600' AS DateTime), CAST(N'2020-06-14T21:02:12.500' AS DateTime), 10, 1, 10, 24300)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (89, CAST(N'2020-06-14T17:34:51.430' AS DateTime), CAST(N'2020-06-14T17:34:56.983' AS DateTime), 5, 1, 1, 9900)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (90, CAST(N'2020-06-14T21:01:20.203' AS DateTime), CAST(N'2020-06-14T21:57:29.577' AS DateTime), 1, 1, 1, 29700)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (91, CAST(N'2020-06-14T21:01:43.407' AS DateTime), CAST(N'2020-06-14T21:01:57.740' AS DateTime), 13, 1, 20, 45600)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (92, CAST(N'2020-06-14T21:57:55.330' AS DateTime), CAST(N'2020-06-14T21:06:00.000' AS DateTime), 6, 0, 0, NULL)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (93, CAST(N'2020-06-14T22:23:34.710' AS DateTime), CAST(N'2020-06-19T11:39:44.053' AS DateTime), 2, 1, 1, 117810)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (94, CAST(N'2020-06-15T07:08:43.863' AS DateTime), CAST(N'2020-06-15T07:08:46.823' AS DateTime), 3, 1, 1, 50490)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (95, CAST(N'2020-06-15T07:08:50.383' AS DateTime), CAST(N'2020-06-15T07:08:53.867' AS DateTime), 4, 1, 1, 50490)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (96, CAST(N'2020-06-15T07:09:11.490' AS DateTime), CAST(N'2020-06-15T07:09:20.140' AS DateTime), 8, 1, 25, 15000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (97, CAST(N'2020-06-16T21:53:33.623' AS DateTime), CAST(N'2020-06-16T21:53:43.073' AS DateTime), 4, 1, 1, 77220)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (98, CAST(N'2020-06-16T21:53:40.667' AS DateTime), CAST(N'2020-06-16T21:53:49.813' AS DateTime), 1, 1, 1, 77220)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (99, CAST(N'2020-06-18T07:34:09.850' AS DateTime), CAST(N'2020-06-18T07:38:09.403' AS DateTime), 4, 1, 1, 142560)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (100, CAST(N'2020-06-18T07:39:10.917' AS DateTime), CAST(N'2020-06-18T07:40:15.157' AS DateTime), 4, 1, 50, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (101, CAST(N'2020-06-19T11:39:36.807' AS DateTime), CAST(N'2020-06-19T11:39:54.857' AS DateTime), 14, 1, 1, 117810)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (102, CAST(N'2020-06-19T13:02:15.527' AS DateTime), CAST(N'2020-06-19T13:07:23.930' AS DateTime), 4, 1, 1, 84150)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (103, CAST(N'2020-06-19T13:07:31.170' AS DateTime), CAST(N'2020-07-06T09:18:44.430' AS DateTime), 1, 1, 1, 84150)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (104, CAST(N'2020-06-19T13:07:40.177' AS DateTime), CAST(N'2020-06-19T13:07:45.740' AS DateTime), 11, 1, 1, 100980)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (105, CAST(N'2020-06-19T13:18:43.877' AS DateTime), CAST(N'2020-06-19T13:19:32.450' AS DateTime), 20, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (106, CAST(N'2020-06-26T12:16:20.837' AS DateTime), CAST(N'2020-06-26T12:16:25.530' AS DateTime), 10, 1, 1, 33660)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (107, CAST(N'2020-07-06T14:27:36.943' AS DateTime), CAST(N'2020-07-06T14:27:47.477' AS DateTime), 11, 1, 1, 84150)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (108, CAST(N'2020-07-06T14:28:08.080' AS DateTime), CAST(N'2020-07-06T14:28:18.330' AS DateTime), 12, 1, 1, 108900)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (109, CAST(N'2020-07-06T14:29:24.887' AS DateTime), CAST(N'2020-07-06T14:29:34.300' AS DateTime), 12, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (110, CAST(N'2020-07-06T14:35:20.720' AS DateTime), CAST(N'2020-07-06T14:35:32.223' AS DateTime), 3, 1, 1, 84150)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (111, CAST(N'2020-07-06T14:36:13.020' AS DateTime), CAST(N'2020-07-06T14:36:17.980' AS DateTime), 19, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (112, CAST(N'2020-07-06T14:36:28.433' AS DateTime), CAST(N'2020-07-06T14:36:34.467' AS DateTime), 14, 1, 0, 102000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (113, CAST(N'2020-07-06T14:36:43.700' AS DateTime), CAST(N'2020-07-06T14:36:59.840' AS DateTime), 14, 1, 0, 20000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (114, CAST(N'2020-07-06T14:41:14.350' AS DateTime), CAST(N'2020-07-06T14:41:31.947' AS DateTime), 11, 1, 1, 70290)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (115, CAST(N'2020-07-06T14:41:48.020' AS DateTime), CAST(N'2020-07-06T14:42:19.400' AS DateTime), 11, 1, 1, 146520)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (116, CAST(N'2020-07-06T14:43:23.693' AS DateTime), CAST(N'2020-07-06T14:43:38.603' AS DateTime), 11, 1, 0, 68000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (117, CAST(N'2020-07-06T14:44:55.060' AS DateTime), CAST(N'2020-07-06T14:44:58.497' AS DateTime), 12, 1, 1, 100980)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (118, CAST(N'2020-07-06T14:45:01.330' AS DateTime), CAST(N'2020-07-06T14:45:06.973' AS DateTime), 13, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (119, CAST(N'2020-07-06T14:49:30.430' AS DateTime), CAST(N'2020-07-06T14:50:19.130' AS DateTime), 11, 1, 50, 19500)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (120, CAST(N'2020-07-06T14:51:53.467' AS DateTime), CAST(N'2020-07-06T14:52:00.120' AS DateTime), 11, 1, 1, 67320)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (121, CAST(N'2020-07-06T14:57:02.470' AS DateTime), CAST(N'2020-07-06T14:57:26.150' AS DateTime), 11, 1, 1, 50490)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (122, CAST(N'2020-07-06T14:57:36.343' AS DateTime), CAST(N'2020-07-06T14:58:18.700' AS DateTime), 11, 1, 50, 25000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (123, CAST(N'2020-07-06T15:13:37.127' AS DateTime), CAST(N'2020-07-06T15:14:05.873' AS DateTime), 11, 1, 1, 61380)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (124, CAST(N'2020-07-06T15:14:49.897' AS DateTime), CAST(N'2020-07-06T15:15:18.460' AS DateTime), 5, 1, 1, 126720)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (125, CAST(N'2020-07-06T15:15:38.680' AS DateTime), CAST(N'2020-07-06T15:15:59.557' AS DateTime), 11, 1, 1, 181170)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (126, CAST(N'2020-07-06T15:16:53.760' AS DateTime), CAST(N'2020-07-06T15:18:04.220' AS DateTime), 11, 1, 1, 110880)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (127, CAST(N'2020-07-06T15:19:09.870' AS DateTime), CAST(N'2020-07-06T15:19:25.057' AS DateTime), 10, 1, 1, 16830)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (128, CAST(N'2020-07-06T15:47:06.330' AS DateTime), CAST(N'2020-07-06T15:47:13.537' AS DateTime), 12, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (129, CAST(N'2020-07-07T08:41:25.540' AS DateTime), CAST(N'2020-07-07T08:43:05.907' AS DateTime), 10, 1, 20, 53600)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (130, CAST(N'2020-07-08T15:02:49.850' AS DateTime), CAST(N'2020-07-08T15:03:25.413' AS DateTime), 4, 1, 0, 96000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (131, CAST(N'2020-07-08T15:10:03.987' AS DateTime), CAST(N'2020-07-08T15:11:22.140' AS DateTime), 12, 1, 0, 161000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (132, CAST(N'2020-07-08T15:15:59.097' AS DateTime), CAST(N'2020-07-08T15:17:14.763' AS DateTime), 21, 1, 50, 57000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (133, CAST(N'2020-07-08T15:21:58.570' AS DateTime), CAST(N'2020-07-08T15:22:52.093' AS DateTime), 10, 1, 0, 76000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (134, CAST(N'2020-07-12T20:41:02.890' AS DateTime), CAST(N'2020-07-12T20:43:01.680' AS DateTime), 12, 1, 0, 79000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (135, CAST(N'2020-07-16T15:02:37.260' AS DateTime), CAST(N'2020-07-16T15:28:13.060' AS DateTime), 21, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (136, CAST(N'2020-07-16T15:28:03.513' AS DateTime), CAST(N'2020-07-16T15:28:08.850' AS DateTime), 19, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (137, CAST(N'2020-07-16T15:28:56.870' AS DateTime), CAST(N'2020-07-16T15:29:37.030' AS DateTime), 4, 1, 0, 127000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (138, CAST(N'2020-07-16T15:29:42.573' AS DateTime), CAST(N'2020-07-16T15:29:53.467' AS DateTime), 5, 1, 0, 25000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (139, CAST(N'2020-07-16T15:32:13.127' AS DateTime), CAST(N'2020-07-16T16:03:59.777' AS DateTime), 1, 1, 0, 50000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (140, CAST(N'2020-07-16T16:05:00.890' AS DateTime), CAST(N'2020-07-16T16:05:40.927' AS DateTime), 16, 1, 0, 89000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (141, CAST(N'2020-07-16T16:26:49.700' AS DateTime), CAST(N'2020-07-16T16:28:04.167' AS DateTime), 17, 1, 0, 153000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (142, CAST(N'2020-07-16T16:29:28.750' AS DateTime), CAST(N'2020-07-16T16:29:43.070' AS DateTime), 11, 1, 0, 85000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (143, CAST(N'2020-07-16T16:34:44.000' AS DateTime), CAST(N'2020-07-16T16:48:28.780' AS DateTime), 3, 1, 0, 85000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (144, CAST(N'2020-07-16T16:45:41.060' AS DateTime), CAST(N'2020-07-16T16:48:09.477' AS DateTime), 19, 1, 0, 85000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (145, CAST(N'2020-07-16T16:49:21.157' AS DateTime), CAST(N'2020-07-16T16:49:26.823' AS DateTime), 12, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (146, CAST(N'2020-07-16T17:07:47.860' AS DateTime), CAST(N'2020-07-16T17:08:10.747' AS DateTime), 12, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (147, CAST(N'2020-07-16T17:07:55.943' AS DateTime), CAST(N'2020-07-16T17:08:06.180' AS DateTime), 20, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (148, CAST(N'2020-07-16T17:08:48.167' AS DateTime), CAST(N'2020-07-16T17:18:40.770' AS DateTime), 12, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (149, CAST(N'2020-07-16T17:18:44.720' AS DateTime), CAST(N'2020-07-16T17:18:59.867' AS DateTime), 20, 1, 0, 87000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (150, CAST(N'2020-07-16T17:19:52.440' AS DateTime), CAST(N'2020-07-16T17:19:57.767' AS DateTime), 12, 1, 0, 68000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (151, CAST(N'2020-07-16T17:22:09.097' AS DateTime), CAST(N'2020-07-16T17:22:33.290' AS DateTime), 21, 1, 5, 126350)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (152, CAST(N'2020-07-16T17:22:44.493' AS DateTime), CAST(N'2020-07-16T20:27:06.847' AS DateTime), 19, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (153, CAST(N'2020-07-16T17:22:53.147' AS DateTime), CAST(N'2020-07-16T17:28:18.307' AS DateTime), 3, 1, 0, 20000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (154, CAST(N'2020-07-16T19:31:38.717' AS DateTime), CAST(N'2020-07-16T19:37:36.943' AS DateTime), 5, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (155, CAST(N'2020-07-16T19:37:31.513' AS DateTime), CAST(N'2020-07-16T19:37:40.360' AS DateTime), 12, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (156, CAST(N'2020-07-16T19:48:57.583' AS DateTime), CAST(N'2020-07-16T20:11:02.030' AS DateTime), 11, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (157, CAST(N'2020-07-16T20:10:51.983' AS DateTime), CAST(N'2020-07-16T20:10:56.957' AS DateTime), 10, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (158, CAST(N'2020-07-16T20:13:59.547' AS DateTime), CAST(N'2020-07-16T20:25:22.463' AS DateTime), 11, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (159, CAST(N'2020-07-16T20:15:08.227' AS DateTime), CAST(N'2020-07-16T20:15:15.330' AS DateTime), 12, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (160, CAST(N'2020-07-16T20:23:37.377' AS DateTime), CAST(N'2020-07-16T20:25:26.013' AS DateTime), 12, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (161, CAST(N'2020-07-16T20:25:12.757' AS DateTime), CAST(N'2020-07-16T20:25:30.880' AS DateTime), 13, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (162, CAST(N'2020-07-16T20:26:27.573' AS DateTime), CAST(N'2020-07-16T20:27:12.963' AS DateTime), 20, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (163, CAST(N'2020-07-16T20:26:33.103' AS DateTime), CAST(N'2020-07-16T20:26:53.497' AS DateTime), 21, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (164, CAST(N'2020-07-16T20:32:50.120' AS DateTime), CAST(N'2020-07-16T20:33:57.133' AS DateTime), 12, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (165, CAST(N'2020-07-16T20:32:53.990' AS DateTime), CAST(N'2020-07-16T20:34:07.000' AS DateTime), 13, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (166, CAST(N'2020-07-16T20:33:03.327' AS DateTime), CAST(N'2020-07-16T20:33:52.450' AS DateTime), 3, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (167, CAST(N'2020-07-16T20:33:32.020' AS DateTime), CAST(N'2020-07-16T20:34:01.900' AS DateTime), 10, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (168, CAST(N'2020-07-16T20:34:13.247' AS DateTime), CAST(N'2020-07-16T20:34:47.187' AS DateTime), 11, 1, 0, 59000)
GO
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (169, CAST(N'2020-07-16T20:34:29.230' AS DateTime), CAST(N'2020-07-16T20:34:42.477' AS DateTime), 13, 1, 0, 56000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (170, CAST(N'2020-07-16T20:36:24.110' AS DateTime), CAST(N'2020-07-16T20:40:22.597' AS DateTime), 11, 1, 0, 153000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (171, CAST(N'2020-07-16T20:43:43.287' AS DateTime), CAST(N'2020-07-17T16:58:46.420' AS DateTime), 5, 1, 0, 168000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (172, CAST(N'2020-07-16T20:45:32.313' AS DateTime), CAST(N'2020-07-31T15:52:44.830' AS DateTime), 12, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (173, CAST(N'2020-07-16T21:53:41.947' AS DateTime), CAST(N'2020-07-17T09:31:18.133' AS DateTime), 1, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (174, CAST(N'2020-07-17T09:30:41.130' AS DateTime), CAST(N'2020-07-31T22:02:57.920' AS DateTime), 21, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (175, CAST(N'2020-07-17T09:31:24.300' AS DateTime), CAST(N'2020-07-17T09:31:47.127' AS DateTime), 1, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (176, CAST(N'2020-07-17T12:32:07.850' AS DateTime), CAST(N'2020-07-17T12:32:28.853' AS DateTime), 11, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (177, CAST(N'2020-07-17T15:56:52.940' AS DateTime), CAST(N'2020-07-19T09:14:01.707' AS DateTime), 10, 1, 0, 71000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (178, CAST(N'2020-07-19T09:21:04.957' AS DateTime), CAST(N'2020-07-19T09:24:54.140' AS DateTime), 4, 1, 0, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (179, CAST(N'2020-07-19T09:25:58.987' AS DateTime), CAST(N'2020-07-25T09:44:08.323' AS DateTime), 11, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (180, CAST(N'2020-07-19T09:38:48.463' AS DateTime), CAST(N'2020-07-25T13:19:19.723' AS DateTime), 10, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (181, CAST(N'2020-07-25T09:51:25.113' AS DateTime), CAST(N'2020-07-29T11:38:05.137' AS DateTime), 9, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (182, CAST(N'2020-07-29T11:41:54.703' AS DateTime), CAST(N'2020-07-29T12:23:21.007' AS DateTime), 11, 1, 0, 37000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (183, CAST(N'2020-07-29T14:17:16.290' AS DateTime), CAST(N'2020-07-31T15:49:59.250' AS DateTime), 10, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (184, CAST(N'2020-07-31T15:52:15.417' AS DateTime), CAST(N'2020-07-31T15:52:18.407' AS DateTime), 11, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (185, CAST(N'2020-07-31T15:53:40.173' AS DateTime), CAST(N'2020-07-31T23:23:30.570' AS DateTime), 11, 1, 12, 74800)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (186, CAST(N'2020-07-31T15:53:43.417' AS DateTime), CAST(N'2020-07-31T18:57:22.653' AS DateTime), 1, 1, 0, 34000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (187, CAST(N'2020-07-31T18:08:06.463' AS DateTime), CAST(N'2020-08-01T10:55:54.330' AS DateTime), 2, 1, 0, 56000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (188, CAST(N'2020-07-31T18:15:42.223' AS DateTime), CAST(N'2020-07-31T19:53:49.147' AS DateTime), 7, 1, 0, 20000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (189, CAST(N'2020-07-31T18:53:29.743' AS DateTime), CAST(N'2020-07-31T19:53:55.747' AS DateTime), 3, 1, 0, 81000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (190, CAST(N'2020-07-31T22:14:14.863' AS DateTime), CAST(N'2020-07-31T22:14:31.800' AS DateTime), 12, 1, 0, 44000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (191, CAST(N'2020-08-01T10:51:23.923' AS DateTime), CAST(N'2020-08-01T10:51:39.267' AS DateTime), 10, 1, 0, 17000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (192, CAST(N'2020-08-01T10:51:49.417' AS DateTime), CAST(N'2020-08-01T10:51:54.683' AS DateTime), 11, 1, 0, 68000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (193, CAST(N'2020-08-01T11:12:17.297' AS DateTime), NULL, 1, 0, 0, NULL)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (194, CAST(N'2020-08-01T11:38:44.160' AS DateTime), CAST(N'2020-08-01T11:43:42.560' AS DateTime), 2, 1, 50, 51000)
INSERT [dbo].[BILLDRINKS] ([id], [timecheckin], [timecheckout], [idtable], [billstatus], [giamgia], [TongTien]) VALUES (195, CAST(N'2020-08-01T14:54:00.513' AS DateTime), CAST(N'2020-08-01T14:54:10.647' AS DateTime), 12, 1, 0, 51000)
SET IDENTITY_INSERT [dbo].[BILLDRINKS] OFF
SET IDENTITY_INSERT [dbo].[BILLINFO] ON 

INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (97, 70, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (98, 71, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (99, 72, 35, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (100, 73, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (101, 73, 35, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (102, 73, 36, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (103, 74, 17, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (104, 74, 42, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (105, 74, 13, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (106, 75, 21, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (107, 75, 37, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (108, 76, 20, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (109, 76, 36, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (110, 77, 20, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (111, 77, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (112, 77, 2, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (113, 77, 30, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (114, 77, 29, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (115, 77, 28, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (116, 77, 17, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (117, 78, 17, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (118, 78, 22, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (119, 79, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (120, 79, 39, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (121, 80, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (122, 82, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (123, 82, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (124, 82, 43, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (125, 83, 5, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (126, 84, 5, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (127, 84, 4, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (128, 84, 13, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (129, 84, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (130, 85, 25, 4)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (131, 86, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (132, 86, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (133, 86, 2, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (134, 86, 41, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (135, 88, 13, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (136, 88, 30, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (137, 89, 30, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (138, 91, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (139, 91, 25, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (140, 91, 40, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (141, 90, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (145, 81, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (147, 94, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (148, 95, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (149, 96, 32, 4)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (150, 98, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (151, 98, 8, 5)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (152, 99, 8, 5)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (153, 99, 24, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (154, 100, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (155, 101, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (156, 102, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (157, 104, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (158, 105, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (159, 106, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (160, 103, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (161, 107, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (162, 108, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (163, 108, 6, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (164, 108, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (165, 109, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (166, 110, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (167, 111, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (168, 112, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (169, 113, 28, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (170, 113, 33, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (171, 114, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (172, 114, 11, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (173, 115, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (174, 115, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (175, 115, 11, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (176, 116, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (177, 116, 13, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (178, 117, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (179, 118, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (180, 119, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (181, 119, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (182, 120, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (183, 121, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (184, 121, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (185, 122, 25, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (186, 123, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (187, 123, 27, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (188, 124, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (189, 124, 6, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (190, 124, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (191, 124, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (192, 124, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (193, 125, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (194, 125, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (195, 125, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (196, 126, 9, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (197, 126, 25, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (198, 126, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (199, 126, 22, 1)
GO
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (200, 126, 17, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (201, 127, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (202, 128, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (203, 129, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (204, 129, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (205, 129, 25, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (206, 130, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (207, 130, 10, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (208, 130, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (209, 131, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (210, 131, 11, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (211, 131, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (212, 132, 35, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (213, 132, 21, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (214, 132, 23, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (215, 132, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (216, 132, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (217, 132, 3, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (218, 133, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (219, 133, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (220, 133, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (221, 133, 24, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (222, 134, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (223, 134, 5, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (224, 134, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (225, 135, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (226, 136, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (227, 137, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (228, 137, 7, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (229, 137, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (230, 137, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (231, 138, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (232, 139, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (233, 139, 20, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (234, 140, 24, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (235, 140, 42, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (236, 140, 25, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (237, 140, 27, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (238, 141, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (239, 142, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (240, 143, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (241, 144, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (242, 145, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (243, 146, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (244, 147, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (245, 148, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (246, 149, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (247, 149, 7, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (248, 149, 12, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (249, 150, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (250, 151, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (251, 151, 5, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (252, 151, 10, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (253, 151, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (254, 151, 9, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (255, 153, 7, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (256, 154, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (257, 155, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (258, 156, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (259, 157, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (260, 158, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (261, 159, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (262, 160, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (263, 161, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (264, 152, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (265, 162, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (266, 163, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (267, 164, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (268, 165, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (269, 166, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (270, 167, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (271, 168, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (272, 168, 9, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (273, 168, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (274, 169, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (275, 169, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (276, 169, 2, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (277, 170, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (278, 170, 10, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (279, 170, 9, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (280, 171, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (281, 173, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (282, 174, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (283, 175, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (284, 176, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (285, 171, 8, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (286, 171, 14, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (287, 171, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (288, 177, 26, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (289, 177, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (290, 178, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (291, 179, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (293, 180, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (294, 181, 24, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (295, 182, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (296, 182, 11, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (297, 183, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (298, 184, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (299, 172, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (300, 186, 1, 3)
GO
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (301, 188, 5, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (302, 189, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (303, 189, 6, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (304, 189, 12, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (305, 190, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (306, 190, 30, 2)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (307, 185, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (308, 191, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (309, 192, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (310, 187, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (311, 187, 6, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (312, 187, 13, 1)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (313, 194, 1, 3)
INSERT [dbo].[BILLINFO] ([id], [idbill], [iddrink], [count]) VALUES (314, 195, 1, 3)
SET IDENTITY_INSERT [dbo].[BILLINFO] OFF
SET IDENTITY_INSERT [dbo].[DRINK] ON 

INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (1, N'Trà Sữa Thái Xanh', 1, 17000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (2, N'Trà Sữa Thái Đỏ', 1, 17000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (3, N'Trà Sữa Truyền Thống', 1, 15000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (4, N'TS Truyền Thống Trân Châu Trắng', 1, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (5, N'TS Truyền Thống Trân Châu Đen', 1, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (6, N'Trà Sữa Trân Châu Đường Đen', 1, 22000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (7, N'Trà Sữa MatCha ', 1, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (8, N'Trà Sữa MatCha Đậu Đỏ', 1, 22000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (9, N'Trà Sữa Bánh Plan', 1, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (10, N'Trà Sữa Khoai Môn', 1, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (11, N'Trà Sữa Các Vị Trái Cây', 1, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (12, N'Trà Sữa Kem Béo', 1, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (13, N'Trà Sữa Cà Phê', 1, 17000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (14, N'Trà Sữa Sương Sáo', 1, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (16, N'Trà Sữa Thập Cẩm', 1, 45000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (17, N'Trà Lipton Chanh', 2, 17000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (18, N'Trà Đào ', 2, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (20, N'Trà Đào Cam Sả', 2, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (21, N'Trà Chanh Mật Ong', 2, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (22, N'Hồng Trà', 2, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (23, N'Trà Hoa Hồng', 2, 27000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (24, N'Trà Lipton Nóng', 3, 17000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (25, N'Hồng Trà Nóng', 3, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (26, N'Trà Gừng', 3, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (27, N'Sữa Nóng', 3, 20000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (28, N'Chân Trâu Đen Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (29, N'Chân Trâu Trắng Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (30, N'Thạch Củ Năng Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (31, N'Thạch Phô Mai Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (32, N'Khúc Bạch Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (33, N'Thạch Khoai Môn Thêm', 4, 5000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (35, N'Bánh Su Kem (Cái)', 5, 10000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (36, N'Bánh Tráng Bùi Nhùi (Phân)', 5, 15000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (37, N'Bánh Quy Kem Sữa (Phần)', 5, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (38, N'Cá Viên Chiên (Phần)', 5, 15000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (39, N'Bò Viên Chiên (Phần)', 5, 15000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (40, N'Xúc Xích Chiên (Phần)', 5, 15000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (41, N'Xúc Xích Phô Mai', 5, 25000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (42, N'SIZE L', 6, 10000)
INSERT [dbo].[DRINK] ([id], [drinkname], [iddrinklist], [price]) VALUES (43, N'SIZE KHỔNG LỒ', 6, 20000)
SET IDENTITY_INSERT [dbo].[DRINK] OFF
SET IDENTITY_INSERT [dbo].[DRINKLIST] ON 

INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (1, N'TRÀ SỮA')
INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (2, N'TRÀ LẠNH')
INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (3, N'TRÀ NÓNG')
INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (4, N'TOPPING')
INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (5, N'ĐỒ ĂN VẶT')
INSERT [dbo].[DRINKLIST] ([id], [drinklistname]) VALUES (6, N'Size')
SET IDENTITY_INSERT [dbo].[DRINKLIST] OFF
SET IDENTITY_INSERT [dbo].[DRINKTABLE] ON 

INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (1, N'Bàn 1', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (2, N'Bàn 2', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (3, N'Bàn 3', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (4, N'Bàn 4', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (5, N'Bàn 5', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (6, N'Bàn 6', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (7, N'Bàn 7', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (8, N'Bàn 8', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (9, N'Bàn 9', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (10, N'Bàn 10', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (11, N'Bàn 11', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (12, N'Bàn 12', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (13, N'Bàn 13', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (14, N'Bàn 14', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (15, N'Bàn 15', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (16, N'Bàn 16', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (17, N'Bàn 17', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (18, N'Bàn 18', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (19, N'Bàn 19', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (20, N'Bàn 20', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (21, N'Bàn 21', N'Chưa Đặt')
INSERT [dbo].[DRINKTABLE] ([id], [tablename], [tablestatus]) VALUES (23, N'Bàn 22', N'Chưa Đặt')
SET IDENTITY_INSERT [dbo].[DRINKTABLE] OFF
SET IDENTITY_INSERT [dbo].[STOCK] ON 

INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (1, N'Trân Châu Trắng (gói 1kg)', 50, 25000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (2, N'Trân Châu Đen (gói 1kg)', 45, 25000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (3, N'Thạch Củ Năng (gói 1kg)', 30, 30000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (4, N'Thạch Phô Mai (hộp 2kg)', 35, 50000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (5, N'Cà Phê Trung Nguyên (gói 1kg)', 10, 105000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (6, N'Nước Lọc (Bình)', 15, 10000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (7, N'Sữa Tươi Vinamilk (Hộp 1 lít)', 50, 58000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (8, N'Sữa Đặc Vinamilk (Hộp 1 lít)', 60, 70000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (9, N'Đường (gói 1kg)', 15, 15000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (10, N'Trà khô (gói 2kg)', 57, 15000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (11, N'Hồng Trà (gói 500g)', 45, 35000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (12, N'Cam (kg)', 2, 35000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (13, N'Dâu (kg)', 1, 70000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (14, N'Gừng(kg)', 1, 12000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (15, N'Chanh (kg)', 2, 20000)
INSERT [dbo].[STOCK] ([id], [stuffname], [stuffamount], [stuffprice]) VALUES (16, N'Tắc', 2, 20000)
SET IDENTITY_INSERT [dbo].[STOCK] OFF
ALTER TABLE [dbo].[ACCOUNT] ADD  CONSTRAINT [DF__ACCOUNT__userpas__4D94879B]  DEFAULT ((0)) FOR [userpassword]
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  CONSTRAINT [DF__ACCOUNT__display__4E88ABD4]  DEFAULT (N'Nguyễn Minh Thông') FOR [displayName]
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  CONSTRAINT [DF__ACCOUNT__typeuse__4F7CD00D]  DEFAULT ((0)) FOR [typeuser]
GO
ALTER TABLE [dbo].[BILLDRINKS] ADD  CONSTRAINT [DF__BILLDRINK__timec__59063A47]  DEFAULT (getdate()) FOR [timecheckin]
GO
ALTER TABLE [dbo].[BILLDRINKS] ADD  CONSTRAINT [DF_BILLDRINKS_timecheckout]  DEFAULT (getdate()) FOR [timecheckout]
GO
ALTER TABLE [dbo].[BILLDRINKS] ADD  CONSTRAINT [DF__BILLDRINK__bills__59FA5E80]  DEFAULT ((0)) FOR [billstatus]
GO
ALTER TABLE [dbo].[BILLINFO] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[DRINK] ADD  DEFAULT (N'Chưa đặt tên món!!!') FOR [drinkname]
GO
ALTER TABLE [dbo].[DRINKLIST] ADD  DEFAULT (N'Chưa đặt tên') FOR [drinklistname]
GO
ALTER TABLE [dbo].[DRINKTABLE] ADD  DEFAULT (N'Bàn chưa đặt tên') FOR [tablename]
GO
ALTER TABLE [dbo].[DRINKTABLE] ADD  CONSTRAINT [DF__DRINKTABL__table__4AB81AF0]  DEFAULT (N'Chưa Đặt') FOR [tablestatus]
GO
ALTER TABLE [dbo].[BILLDRINKS]  WITH CHECK ADD  CONSTRAINT [FK__BILLDRINK__bills__5AEE82B9] FOREIGN KEY([idtable])
REFERENCES [dbo].[DRINKTABLE] ([id])
GO
ALTER TABLE [dbo].[BILLDRINKS] CHECK CONSTRAINT [FK__BILLDRINK__bills__5AEE82B9]
GO
ALTER TABLE [dbo].[BILLINFO]  WITH CHECK ADD  CONSTRAINT [FK__BILLINFO__count__5EBF139D] FOREIGN KEY([idbill])
REFERENCES [dbo].[BILLDRINKS] ([id])
GO
ALTER TABLE [dbo].[BILLINFO] CHECK CONSTRAINT [FK__BILLINFO__count__5EBF139D]
GO
ALTER TABLE [dbo].[BILLINFO]  WITH CHECK ADD FOREIGN KEY([iddrink])
REFERENCES [dbo].[DRINK] ([id])
GO
ALTER TABLE [dbo].[DRINK]  WITH CHECK ADD FOREIGN KEY([iddrinklist])
REFERENCES [dbo].[DRINKLIST] ([id])
GO
/****** Object:  StoredProcedure [dbo].[CAPNHATTAIKHOAN]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CAPNHATTAIKHOAN]
@username nvarchar(100), @displayName nvarchar(100), @userpassword nvarchar(100), @passwordmoi nvarchar(100), @cmnd nvarchar(50), @diachi nvarchar(500), @sodienthoai nvarchar(50)
AS
BEGIN
	DECLARE @dungmk  INT = 0
	SELECT @dungmk = COUNT(*) FROM DBO.ACCOUNT WHERE username = @username AND userpassword = @userpassword

	IF(@dungmk = 1)
	BEGIN
		IF(@passwordmoi = NULL OR @passwordmoi = '')
		BEGIN
			UPDATE dbo.ACCOUNT SET displayName = @displayName, cmnd = @cmnd, diachi = @diachi, sodienthoai = @sodienthoai WHERE username = @username
		END
		ELSE
			UPDATE dbo.ACCOUNT SET displayName = @displayName, cmnd = @cmnd, diachi = @diachi, sodienthoai = @sodienthoai,  userpassword = @passwordmoi WHERE username = @username
	END
END
GO
/****** Object:  StoredProcedure [dbo].[DANGNHAP]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DANGNHAP]
@username nvarchar(100),
@password nvarchar(100)
AS
BEGIN
	select * from dbo.ACCOUNT where username = @username and userpassword = @password
END
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetTableList]
as select * from DRINKTABLE	
GO
/****** Object:  StoredProcedure [dbo].[GOPBAN]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  Proc [dbo].[GOPBAN]
@firstBill int, @secondBill int
As
Begin
 Declare @tableSecond int
 --Xac dinh id cua Ban thu 2
 Select @tableSecond=idTable from BILLDRINKS where id=@firstBill
 -- Doi toan bo data ban thu 2 vao ban thu 1
 Update BillInfo set idBill=@firstBill where id in (select id from billInfo where idbill=@secondBill)
 -- Xoa Bill cua ban thu 2
 Delete  BILLINFO where id=@secondBill
 -- Cap nhat la Status cho ban thu 2
 Update DRINKTABLE Set tablestatus=N'Chưa Đặt' where id=@tableSecond
 -- Chon cac Item giong nhau thi gop lai roi day vao mot bang data trung gian moi
 Select min(id) id, idbill, iddrink, sum(count) count into tabletemp
   From BillInfo where idbill=@firstBill
   Group by idbill, iddrink Order by id Asc
 --Xoa data cua ban da gop
 Delete BillInfo where idbill=@firstBill
 --Do lai data tu bang tam thoi vao BillInfo
 SET IDENTITY_INSERT BillInfo ON;
 Insert BillInfo ([id], [idbill], [iddrink], [count])  (select id, idbill, iddrink, count from tabletemp)
 SET IDENTITY_INSERT BillInfo OFF;
--Xoa bo bang tam thoi
 Drop Table  tabletemp
End
GO
/****** Object:  StoredProcedure [dbo].[GOPBAN_THEOID]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  Proc [dbo].[GOPBAN_THEOID]
@secondBill int, @firstBill int
As
Begin
	Declare @tableSecond int

	--Xác định id của bàn thứ 2
	Select @tableSecond= idTable from Billdrinks where id=@secondBill

	--Đổ toàn bộ dữ liệu của bàn thứ 2 vào bàn 1
	Update BillInfo set idBill=@firstBill where id in (select id from billInfo where idbill=@secondBill)

	-- Xóa bill của bàn thứ 2
	Delete  BILLDRINKS where id = @secondBill

	-- Cập nhật lại status cho bàn thứ 2
	Update DRINKTABLE Set tablestatus = N'Chưa Đặt' where id = @tableSecond

	--  Chọn các loại thức uống giống nhau gộp lại rồi đẩy vào bảng trung gian mới
	Select min(id) id, idbill, iddrink, sum(count) count into NewTable
	From BillInfo where idbill=@firstBill
	Group by idbill, iddrink Order by id Asc

	--Xóa dữ liệu của bàn đã gộp
	Delete BillInfo where idbill=@firstBill

	--Đổ lại dữ liệu từ bảng trung gian vào BillInfo
	Insert BillInfo  select * from NewTable

	--Xóa đi bảng tạm
	Drop Table  NewTable
End
GO
/****** Object:  StoredProcedure [dbo].[LAYBANG_ID]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LAYBANG_ID]
@idbanlamgoc INT, @idbanditheo int
AS BEGIN

	DECLARE @idbilldau int
	DECLARE @idbillhai INT
	
	DECLARE @bantrong1 INT = 1
	DECLARE @bantrong2 INT = 1
	
	
	SELECT @idbillhai = id FROM dbo.BILLDRINKS WHERE idTable = @idbanditheo AND billstatus = 0
	SELECT @idbilldau = id FROM dbo.BILLDRINKS WHERE idTable = @idbanlamgoc AND billstatus = 0
	
	IF (@idbilldau IS NULL)
	BEGIN
		INSERT dbo.BILLDRINKS
		        ( timecheckin ,
		          timecheckout ,
		          idTable ,
		          billstatus
		        )
		VALUES  ( GETDATE(),
		          GETDATE(),
		          @idbanlamgoc, 
		          0  
		        )
		        
		SELECT @idbilldau = MAX(id) FROM dbo.BILLDRINKS WHERE idTable = @idbanlamgoc AND billstatus = 0
		
	END
	
	SELECT @bantrong1 = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idbilldau
	
	
	IF (@idbillhai IS NULL)
	BEGIN
				INSERT dbo.BILLDRINKS
		        ( timecheckin ,
		          timecheckout ,
		          idTable ,
		          billstatus
		        )
		VALUES  ( GETDATE(),
		          GETDATE(),
		          @idbanditheo, 
		          0  
		        )
		SELECT @idbillhai = MAX(id) FROM dbo.BILLDRINKS WHERE idTable = @idbanditheo AND billstatus = 0
		
	END
	
	SELECT @bantrong2 = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idbillhai

	SELECT id INTO LAYBANGHOANVI FROM dbo.BillInfo WHERE idBill = @idbillhai
	
	UPDATE dbo.BillInfo SET idBill = @idbillhai WHERE idBill = @idbilldau
	
	UPDATE dbo.BillInfo SET idBill = @idbilldau WHERE id IN (SELECT * FROM LAYBANGHOANVI)
	
	DROP TABLE LAYBANGHOANVI
	
	IF (@bantrong1 = 0)
		UPDATE dbo.DRINKTABLE SET tablestatus = N'Chưa Đặt' WHERE id = @idbanditheo
		
	IF (@bantrong2= 0)
		UPDATE dbo.DRINKTABLE SET tablestatus = N'Chưa Đặt' WHERE id = @idbanlamgoc
end
GO
/****** Object:  StoredProcedure [dbo].[LAYGIOVAO]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LAYGIOVAO]
@idtable int
AS
BEGIN
	SELECT timecheckin 
	FROM dbo.BILLDRINKS as bk, dbo.DRINKTABLE as dt
	WHERE @idtable = dt.id AND bk.billstatus = 0 AND dt.id = bk.idtable 
END
GO
/****** Object:  StoredProcedure [dbo].[THEMBILL]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMBILL]
@idtable int
AS
BEGIN
	INSERT dbo.BILLDRINKS
		( timecheckin,
		  timecheckout,
		  idtable,
		  billstatus,
		  giamgia
		  )
	VALUES
		( GETDATE() ,
		  NULL,
		  @idtable,
		  0,
		  0
		)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMTHONGTINBILL]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMTHONGTINBILL]
@idbill int, @iddrink int, @count int
AS
BEGIN

	DECLARE @datontai INT
	DECLARE @drinkcount INT = 1

	SELECT @datontai  = id, @drinkcount = dbo.BILLINFO.count FROM dbo.BILLINFO where idbill = @idbill and iddrink = @iddrink;

	IF (@datontai > 0)
	BEGIN
		DECLARE @minuscount INT = @drinkcount + @count
		IF (@minuscount > 0)
			UPDATE dbo.BILLINFO SET count = @drinkcount + @count	where iddrink = @iddrink
		ELSE
			DELETE dbo.BILLINFO WHERE idbill = @idbill and iddrink = @iddrink
		
	END
	else
	begin
		insert dbo.BILLINFO (idbill, iddrink, count)
		values
		(@idbill, @iddrink, @count)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[THONGKEHOADON]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THONGKEHOADON]
@timeckeckin datetime, @timecheckout datetime
AS
BEGIN
	SELECT tablename as [TÊN BÀN], timecheckin AS [GIỜ VÀO], timecheckout AS [GIỜ RA], giamgia AS[GIẢM GIÁ (%)], TongTien AS [TỔNG TIỀN (VNĐ)]
	FROM dbo.BILLDRINKS as bk, dbo.DRINKTABLE as dt
	WHERE timecheckin >= @timeckeckin AND timecheckout <= @timecheckout AND bk.billstatus = 1 AND dt.id = bk.idtable 
END
GO
/****** Object:  StoredProcedure [dbo].[TONGTIENTHEOTHOIGIAN]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TONGTIENTHEOTHOIGIAN]
@timeckeckin datetime, @timecheckout datetime
AS
BEGIN
	SELECT count(bk.id) as N'Tổng số hóa đơn', sum(bk.TongTien) as N'Tổng Tiền'
	FROM dbo.BILLDRINKS as bk, dbo.DRINKTABLE as dt
	WHERE timecheckin >= @timeckeckin AND timecheckout <= @timecheckout AND bk.billstatus = 1 AND dt.id = bk.idtable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GETACCOUNTBYUSERNAME]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GETACCOUNTBYUSERNAME]
@username nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GETACCOUNTBYUSERNAMEvsDISPLAYNAME]    Script Date: 01/08/2020 4:42:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GETACCOUNTBYUSERNAMEvsDISPLAYNAME]
@username nvarchar(100),
@displayname nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE username = @username and displayName = @displayname
END
GO
USE [master]
GO
ALTER DATABASE [QL_TRASUA] SET  READ_WRITE 
GO
