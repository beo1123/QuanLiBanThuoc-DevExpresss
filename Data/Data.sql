USE [master]
GO
/****** Object:  Database [DrugSalesManager]    Script Date: 1/13/2022 01:16:53 PM ******/
CREATE DATABASE [DrugSalesManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrugSalesManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.QUOCBAO1123\MSSQL\DATA\DrugSalesManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DrugSalesManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.QUOCBAO1123\MSSQL\DATA\DrugSalesManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DrugSalesManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrugSalesManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrugSalesManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrugSalesManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrugSalesManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrugSalesManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrugSalesManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrugSalesManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrugSalesManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrugSalesManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrugSalesManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrugSalesManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrugSalesManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrugSalesManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrugSalesManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrugSalesManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrugSalesManager] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DrugSalesManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrugSalesManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrugSalesManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrugSalesManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrugSalesManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrugSalesManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DrugSalesManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrugSalesManager] SET RECOVERY FULL 
GO
ALTER DATABASE [DrugSalesManager] SET  MULTI_USER 
GO
ALTER DATABASE [DrugSalesManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrugSalesManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrugSalesManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrugSalesManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DrugSalesManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DrugSalesManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DrugSalesManager', N'ON'
GO
ALTER DATABASE [DrugSalesManager] SET QUERY_STORE = OFF
GO
USE [DrugSalesManager]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID_Account] [int] IDENTITY(1,1) NOT NULL,
	[Code_Account] [varchar](10) NOT NULL,
	[DisplayName_Account] [nvarchar](200) NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[PhoneNumber] [nvarchar](200) NULL,
	[PassWord_Account] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID_Customer] [int] IDENTITY(1,1) NOT NULL,
	[Code_Customer] [varchar](10) NOT NULL,
	[Name_Customer] [nvarchar](200) NOT NULL,
	[PhoneNumber] [nvarchar](200) NULL,
	[Address_Customer] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ID_Invoice] [int] IDENTITY(1,1) NOT NULL,
	[Code_Invoice] [varchar](10) NOT NULL,
	[CreateDay] [datetime] NOT NULL,
	[ID_Account] [int] NULL,
	[ID_Customer] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Invoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[ID_InvoiceDetails] [int] NOT NULL,
	[ID_Medicine] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Sale_Pirce] [float] NOT NULL,
	[Bill_Status] [bit] NOT NULL,
	[Id_Unit] [int] NULL,
	[toTalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_InvoiceDetails] ASC,
	[ID_Medicine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[ID_Medicine] [int] IDENTITY(1,1) NOT NULL,
	[Name_Medicine] [nvarchar](200) NOT NULL,
	[Code_MEdicine] [varchar](10) NOT NULL,
	[Exprired_Day] [datetime] NOT NULL,
	[Amount] [int] NOT NULL,
	[ID_Unit] [int] NULL,
	[ID_Supplier] [int] NULL,
	[Import_Price] [float] NOT NULL,
	[Sale_Price] [float] NOT NULL,
	[Note] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Medicine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[ID_Receipt] [int] IDENTITY(1,1) NOT NULL,
	[Code_Reciept] [varchar](10) NOT NULL,
	[CreateDay] [datetime] NOT NULL,
	[ID_Account] [int] NULL,
	[ID_Supplier] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Receipt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptDetails]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptDetails](
	[ID_ReceiptDetails] [int] NOT NULL,
	[ID_Medicine] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Import_Pirce] [float] NOT NULL,
	[Bill_Status] [bit] NULL,
	[Id_Unit] [int] NULL,
	[toTalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ReceiptDetails] ASC,
	[ID_Medicine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID_Supplier] [int] IDENTITY(1,1) NOT NULL,
	[Name_Supplier] [nvarchar](200) NOT NULL,
	[Code_Supplier] [varchar](10) NULL,
	[PhoneNumber] [nvarchar](200) NULL,
	[Address_Supplier] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[id_Unit] [int] IDENTITY(1,1) NOT NULL,
	[Code_Unit] [varchar](10) NOT NULL,
	[Name_Unit] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID_Account], [Code_Account], [DisplayName_Account], [DateOfBirth], [PhoneNumber], [PassWord_Account]) VALUES (1, N'NV01', N'Võ Minh Quốc Bảo', CAST(N'2001-04-19T00:00:00.000' AS DateTime), N'0948-890-652', N'123')
INSERT [dbo].[Account] ([ID_Account], [Code_Account], [DisplayName_Account], [DateOfBirth], [PhoneNumber], [PassWord_Account]) VALUES (2, N'NV02', N'Trần Cát Vũ', CAST(N'2001-06-27T00:00:00.000' AS DateTime), N'0987-265-180', N'123')
INSERT [dbo].[Account] ([ID_Account], [Code_Account], [DisplayName_Account], [DateOfBirth], [PhoneNumber], [PassWord_Account]) VALUES (3, N'NV03', N'Nguyễn Thế Phước', CAST(N'2001-08-12T00:00:00.000' AS DateTime), N'0920-461-821', N'123')
INSERT [dbo].[Account] ([ID_Account], [Code_Account], [DisplayName_Account], [DateOfBirth], [PhoneNumber], [PassWord_Account]) VALUES (6, N'NV04', N'Nguyễn Thế Phước Gà', CAST(N'2001-08-23T00:00:00.000' AS DateTime), N'0920-461-821', N'123')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (1, N'KH01', N'Nguyễn Văn Bá', N'0989-336-636', N'254 Âu Cơ, phường 9, Quận Tân Bình, Thành phố Hồ Chí Minh')
INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (2, N'KH02', N'Lưu Xuân Quỳnh', N'0932-625-698', N'72 Nguyễn Thị Minh Khai, Phường 6, Quận 3, Thành phố Hồ Chí Minh')
INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (3, N'KH03', N'Mạc Văn Đinh', N'0699-232-932', N'740 Sư Vạn Hạnh, Phường 12, Quận 10, Thành phố Hồ Chí Minh')
INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (4, N'KH04', N'Dương Thịnh', N'0152-123-652', N'254 Hòa Hảo, Phường 4, Quận 10, Thành phố Hồ Chí Minh')
INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (5, N'KH05', N'Ngọc Minh Tinh', N'0155-452-336', N'525 Tô Hiến Thành, Phường 14, Quận 10, Thành phố Hồ Chí Minh')
INSERT [dbo].[Customer] ([ID_Customer], [Code_Customer], [Name_Customer], [PhoneNumber], [Address_Customer]) VALUES (1007, N'kh06', N'dsaddasas', N'3523-323-223', N'dasdasdasdasdas')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (1, N'HD01', CAST(N'2021-12-12T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (6, N'HD02', CAST(N'2022-01-07T23:01:30.410' AS DateTime), 3, 2)
INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (9, N'HD03', CAST(N'2022-01-08T23:18:37.000' AS DateTime), 2, 3)
INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (10, N'HD04', CAST(N'2022-01-09T16:17:31.000' AS DateTime), 2, 5)
INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (11, N'HD05', CAST(N'2022-01-09T16:32:45.070' AS DateTime), 3, 4)
INSERT [dbo].[Invoice] ([ID_Invoice], [Code_Invoice], [CreateDay], [ID_Account], [ID_Customer]) VALUES (1011, N'HD06', CAST(N'2022-01-09T16:32:45.000' AS DateTime), 1, 4)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 2, 30, 3050, 0, 2, 91500)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 3, 2, 2300, 0, 3, 4600)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 11, 100, 2369, 0, 1, 236900)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (6, 3, 10, 2300, 0, 3, 23000)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (6, 6, 30, 1185, 0, 6, 35550)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (6, 7, 10, 300, 0, 4, 3000)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 5, 25, 2736, 0, 5, 68400)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 8, 10, 6980, 0, 5, 69800)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 9, 10, 17794, 0, 1, 177940)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 10, 10, 525, 0, 6, 5250)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (10, 1, 100, 1000, 0, 2, 100000)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (10, 4, 10, 875, 0, 5, 8750)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (10, 5, 20, 2736, 0, 5, 54720)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (11, 4, 5, 875, 0, 5, 4375)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (11, 6, 50, 1185, 0, 6, 59250)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1011, 3, 10, 2300, 0, 3, 23000)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1011, 6, 30, 1185, 0, 6, 35550)
INSERT [dbo].[InvoiceDetails] ([ID_InvoiceDetails], [ID_Medicine], [Amount], [Sale_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1011, 11, 10, 2369, 0, 1, 23690)
GO
SET IDENTITY_INSERT [dbo].[Medicine] ON 

INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (1, N'Panadol Extraaaa', N'PE01', CAST(N'2022-12-27T00:00:00.000' AS DateTime), 10000, 2, 2, 500, 1000, N'Giảm mạnh cơn đau , tác dụng nhanh , không gây buồn ngủ')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (2, N'Abivina', N'AB01', CAST(N'2023-01-31T00:00:00.000' AS DateTime), 2500, 2, 2, 1500, 3050, N'Chữa viêm gan virut, nhuận gan mật')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (3, N'Boganic', N'BO01', CAST(N'2022-04-30T00:00:00.000' AS DateTime), 5500, 3, 3, 1350, 2300, N'Nhuận gan , lợi mật')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (4, N'Panadol', N'PA01', CAST(N'2023-02-27T00:00:00.000' AS DateTime), 10000, 5, 1, 500, 875, N'Giảm đau , hạ sốt')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (5, N'Efferalgan', N'EF02', CAST(N'2022-05-19T00:00:00.000' AS DateTime), 7000, 5, 4, 1500, 2736, N'Giảm đau , hạ sốt , chỉ dùng đường uống ')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (6, N'Decolgen ND', N'DE01', CAST(N'2024-07-10T00:00:00.000' AS DateTime), 4000, 6, 2, 600, 1185, N'Trị các triệu chứng cảm , nhức đầu , nghẹt mũi , đau, sốta')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (7, N'Paracetamol', N'PA02', CAST(N'2022-06-23T00:00:00.000' AS DateTime), 4250, 4, 2, 150, 300, N'Giảm đau , hạ sốt')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (8, N'Beroccca Performance', N'BE01', CAST(N'2023-03-12T00:00:00.000' AS DateTime), 5500, 5, 1, 3350, 6980, N'Viên sủi tăng sức đề kháng ')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (9, N'Fugacar ', N'FU01', CAST(N'2022-12-12T00:00:00.000' AS DateTime), 2500, 1, 2, 10000, 17794, N'Tẩy giun ')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (10, N'Hoạt Huyết Dưỡng Não ACP', N'HH01', CAST(N'2022-01-03T00:00:00.000' AS DateTime), 3500, 6, 3, 250, 525, N'Giảm các biểu hiện của suy tuần hoàn não như ù tai, đau đầu, chóng mặt, rối loạn tiền đình.')
INSERT [dbo].[Medicine] ([ID_Medicine], [Name_Medicine], [Code_MEdicine], [Exprired_Day], [Amount], [ID_Unit], [ID_Supplier], [Import_Price], [Sale_Price], [Note]) VALUES (11, N'Hoạt Huyết Nhất Nhất', N'HH02', CAST(N'2023-09-16T00:00:00.000' AS DateTime), 3500, 1, 4, 1700, 2369, N'Hoạt huyết, trị thiểu năng tuần hoàn')
SET IDENTITY_INSERT [dbo].[Medicine] OFF
GO
SET IDENTITY_INSERT [dbo].[Receipt] ON 

INSERT [dbo].[Receipt] ([ID_Receipt], [Code_Reciept], [CreateDay], [ID_Account], [ID_Supplier]) VALUES (1, N'HN01', CAST(N'2021-12-02T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Receipt] ([ID_Receipt], [Code_Reciept], [CreateDay], [ID_Account], [ID_Supplier]) VALUES (8, N'HN02', CAST(N'2021-12-02T00:00:00.000' AS DateTime), 3, 3)
INSERT [dbo].[Receipt] ([ID_Receipt], [Code_Reciept], [CreateDay], [ID_Account], [ID_Supplier]) VALUES (9, N'HN03', CAST(N'2021-12-02T00:00:00.000' AS DateTime), 2, 2)
INSERT [dbo].[Receipt] ([ID_Receipt], [Code_Reciept], [CreateDay], [ID_Account], [ID_Supplier]) VALUES (2007, N'HD04', CAST(N'2022-01-12T22:14:57.073' AS DateTime), 3, 4)
SET IDENTITY_INSERT [dbo].[Receipt] OFF
GO
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 2, 10, 1500, 0, 2, 15000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 3, 30, 1350, 0, 3, 40500)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (1, 6, 35, 600, 0, 6, 21000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (8, 4, 30, 500, 0, 5, 15000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (8, 5, 10, 1500, 0, 5, 15000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 4, 60, 500, 0, 5, 30000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (9, 10, 100, 250, 0, 6, 25000)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (2007, 3, 230, 1350, 0, 3, 310500)
INSERT [dbo].[ReceiptDetails] ([ID_ReceiptDetails], [ID_Medicine], [Amount], [Import_Pirce], [Bill_Status], [Id_Unit], [toTalPrice]) VALUES (2007, 4, 501, 500, 0, 5, 250500)
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([ID_Supplier], [Name_Supplier], [Code_Supplier], [PhoneNumber], [Address_Supplier]) VALUES (1, N'Công Ty TNHH Lê Hào', N'NCC01', N'0623-263-266', N'26 Ngõ 36 Đường Thượng Hội, X. Tân Hội, H. Đan Phượng, Hà Nội')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name_Supplier], [Code_Supplier], [PhoneNumber], [Address_Supplier]) VALUES (2, N'Công Ty Cổ Phần Neemtree', N'NCC02', N'0632-325-665', N'37/5B Trung Mỹ Tây, Trung Chánh, Hóc Môn, Tp. Hồ Chí Minh')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name_Supplier], [Code_Supplier], [PhoneNumber], [Address_Supplier]) VALUES (3, N'Doanh Nghiệp Tư Nhân Trọng Đức', N'NCC03', N'0936-212-533', N'Số 127, Tổ 1, Khu 1, Phường Hùng Thắng, Tp Hạ Long, Quảng Ninh')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name_Supplier], [Code_Supplier], [PhoneNumber], [Address_Supplier]) VALUES (4, N'Eva Shop', N'NCC04', N'0329-565-965', N'475 Đoàn Văn Bơ, Phường 14, Quận 4, Tp. Hồ Chí Minh')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (1, N'VIEN', N'Viên ')
INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (2, N'CHAI', N'Chai')
INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (3, N'LO', N'Lọ ')
INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (4, N'GOI', N'Gói')
INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (5, N'ONG', N'Ống')
INSERT [dbo].[Unit] ([id_Unit], [Code_Unit], [Name_Unit]) VALUES (6, N'TUYP', N'Tuýp')
SET IDENTITY_INSERT [dbo].[Unit] OFF
GO
ALTER TABLE [dbo].[InvoiceDetails] ADD  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[InvoiceDetails] ADD  DEFAULT ((0)) FOR [Sale_Pirce]
GO
ALTER TABLE [dbo].[InvoiceDetails] ADD  DEFAULT ((0)) FOR [toTalPrice]
GO
ALTER TABLE [dbo].[Medicine] ADD  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Medicine] ADD  DEFAULT ((0)) FOR [Import_Price]
GO
ALTER TABLE [dbo].[Medicine] ADD  DEFAULT ((0)) FOR [Sale_Price]
GO
ALTER TABLE [dbo].[ReceiptDetails] ADD  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[ReceiptDetails] ADD  DEFAULT ((0)) FOR [Import_Pirce]
GO
ALTER TABLE [dbo].[ReceiptDetails] ADD  DEFAULT ((0)) FOR [Bill_Status]
GO
ALTER TABLE [dbo].[ReceiptDetails] ADD  DEFAULT ((0)) FOR [toTalPrice]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([ID_Account])
REFERENCES [dbo].[Account] ([ID_Account])
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([ID_Customer])
REFERENCES [dbo].[Customer] ([ID_Customer])
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([ID_InvoiceDetails])
REFERENCES [dbo].[Invoice] ([ID_Invoice])
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[Medicine] ([ID_Medicine])
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([Id_Unit])
REFERENCES [dbo].[Unit] ([id_Unit])
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[Supplier] ([ID_Supplier])
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD FOREIGN KEY([ID_Unit])
REFERENCES [dbo].[Unit] ([id_Unit])
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD FOREIGN KEY([ID_Account])
REFERENCES [dbo].[Account] ([ID_Account])
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[Supplier] ([ID_Supplier])
GO
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD FOREIGN KEY([ID_Medicine])
REFERENCES [dbo].[Medicine] ([ID_Medicine])
GO
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD FOREIGN KEY([ID_ReceiptDetails])
REFERENCES [dbo].[Receipt] ([ID_Receipt])
GO
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD FOREIGN KEY([Id_Unit])
REFERENCES [dbo].[Unit] ([id_Unit])
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 1/13/2022 01:16:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(max)
as
begin
	select * from dbo.Account where Account.Code_Account = @userName and Account.PassWord_Account = @passWord
end
GO
USE [master]
GO
ALTER DATABASE [DrugSalesManager] SET  READ_WRITE 
GO
