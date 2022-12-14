USE [master]
GO
/****** Object:  Database [byteshark]    Script Date: 4/11/2022 20:36:22 ******/
CREATE DATABASE [byteshark]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'byteshark', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\byteshark.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'byteshark_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\byteshark_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [byteshark] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [byteshark].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [byteshark] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [byteshark] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [byteshark] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [byteshark] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [byteshark] SET ARITHABORT OFF 
GO
ALTER DATABASE [byteshark] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [byteshark] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [byteshark] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [byteshark] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [byteshark] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [byteshark] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [byteshark] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [byteshark] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [byteshark] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [byteshark] SET  ENABLE_BROKER 
GO
ALTER DATABASE [byteshark] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [byteshark] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [byteshark] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [byteshark] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [byteshark] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [byteshark] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [byteshark] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [byteshark] SET RECOVERY FULL 
GO
ALTER DATABASE [byteshark] SET  MULTI_USER 
GO
ALTER DATABASE [byteshark] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [byteshark] SET DB_CHAINING OFF 
GO
ALTER DATABASE [byteshark] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [byteshark] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [byteshark] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [byteshark] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'byteshark', N'ON'
GO
ALTER DATABASE [byteshark] SET QUERY_STORE = OFF
GO
USE [byteshark]
GO
/****** Object:  Table [dbo].[Deposits]    Script Date: 4/11/2022 20:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposits](
	[operation] [varchar](40) NULL,
	[amount] [int] NULL,
	[receptor] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactions]    Script Date: 4/11/2022 20:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactions](
	[cbu_emisor] [varchar](50) NULL,
	[valor] [int] NULL,
	[cbu_receptor] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 4/11/2022 20:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[lastname] [varchar](30) NOT NULL,
	[email] [varchar](45) NOT NULL,
	[pass] [varchar](80) NOT NULL,
	[dni] [int] NOT NULL,
	[cel] [int] NULL,
	[cbu] [int] NULL,
	[saldo] [int] NULL,
	[cardnumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Deposits] ([operation], [amount], [receptor]) VALUES (N'Deposito', 1, 456)
INSERT [dbo].[Deposits] ([operation], [amount], [receptor]) VALUES (N'Deposito', 2000, 456)
GO
INSERT [dbo].[transactions] ([cbu_emisor], [valor], [cbu_receptor]) VALUES (N'456', 1, N'1')
INSERT [dbo].[transactions] ([cbu_emisor], [valor], [cbu_receptor]) VALUES (N'456', 3000, N'456')
INSERT [dbo].[transactions] ([cbu_emisor], [valor], [cbu_receptor]) VALUES (N'456', 4000, N'456')
INSERT [dbo].[transactions] ([cbu_emisor], [valor], [cbu_receptor]) VALUES (N'456', 1, N'123')
INSERT [dbo].[transactions] ([cbu_emisor], [valor], [cbu_receptor]) VALUES (N'456', 1, N'456')
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [lastname], [email], [pass], [dni], [cel], [cbu], [saldo], [cardnumber]) VALUES (1, N'leandro', N'tateossian', N'leanjtateo@gmail.com', N'03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4', 43631096, 1126189500, 456, 7002, 234567689)
INSERT [dbo].[users] ([id], [username], [lastname], [email], [pass], [dni], [cel], [cbu], [saldo], [cardnumber]) VALUES (2, N'juan', N'garcia', N'juangarcia@gmail.com', N'F6CCB3E8D609012238C0B39E60B2C9632B3CDEDE91E035DAD1DE43469768F4CC', 43633987, 1126189600, 123, 4324, 234565626)
INSERT [dbo].[users] ([id], [username], [lastname], [email], [pass], [dni], [cel], [cbu], [saldo], [cardnumber]) VALUES (4, N'lean2', N'lean2', N'lean2@gmail.com', N'5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5', 43434343, 121212121, 261126751, 2050, 834234713)
INSERT [dbo].[users] ([id], [username], [lastname], [email], [pass], [dni], [cel], [cbu], [saldo], [cardnumber]) VALUES (13, N'leandrito', N'tateossiani', N'leantateo@mail.com', N'6C94E35CCC352D4E9EF0B99562CFF995A5741CE8DE8AD11B568892934DAEE366', 45, 56, 861948389, 2000, 901337693)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__8320F63E71F8F7B9]    Script Date: 4/11/2022 20:36:22 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[pass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__users__D83671A9420E575D]    Script Date: 4/11/2022 20:36:22 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[cel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__users__D87608A7A4934C0A]    Script Date: 4/11/2022 20:36:22 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Deposit]    Script Date: 4/11/2022 20:36:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Deposit] @amount int ,@cbu int as update users set saldo += @amount where cbu=@cbu;
GO
USE [master]
GO
ALTER DATABASE [byteshark] SET  READ_WRITE 
GO
