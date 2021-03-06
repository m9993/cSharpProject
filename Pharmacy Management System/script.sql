USE [master]
GO
/****** Object:  Database [pharmacydb]    Script Date: 17-May-20 1:04:14 AM ******/
CREATE DATABASE [pharmacydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pharmacydb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\pharmacydb.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pharmacydb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\pharmacydb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pharmacydb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pharmacydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pharmacydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pharmacydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pharmacydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pharmacydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pharmacydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [pharmacydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pharmacydb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [pharmacydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pharmacydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pharmacydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pharmacydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pharmacydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pharmacydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pharmacydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pharmacydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pharmacydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pharmacydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pharmacydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pharmacydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pharmacydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pharmacydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pharmacydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pharmacydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pharmacydb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pharmacydb] SET  MULTI_USER 
GO
ALTER DATABASE [pharmacydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pharmacydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pharmacydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pharmacydb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [pharmacydb]
GO
/****** Object:  Table [dbo].[medicine]    Script Date: 17-May-20 1:04:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine](
	[id] [nvarchar](10) NOT NULL,
	[name] [nvarchar](30) NULL,
	[company] [nvarchar](30) NULL,
	[quantity] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_medicine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sale]    Script Date: 17-May-20 1:04:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale](
	[id] [nvarchar](10) NOT NULL,
	[name] [nvarchar](30) NULL,
	[company] [nvarchar](30) NULL,
	[quantity] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_sale] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 17-May-20 1:04:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [nvarchar](15) NOT NULL,
	[password] [nvarchar](20) NULL,
	[role] [nvarchar](15) NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[medicine] ([id], [name], [company], [quantity], [price]) VALUES (N'm-0001', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 6880, 2)
INSERT [dbo].[medicine] ([id], [name], [company], [quantity], [price]) VALUES (N'm-0002', N'Napa', N'Beximco Pharmaceuticals Ltd.', 9500, 0.8)
INSERT [dbo].[medicine] ([id], [name], [company], [quantity], [price]) VALUES (N'm-0003', N'Histasin 4mg', N'Jayson Pharma Ltd.', 8999, 0.29)
INSERT [dbo].[medicine] ([id], [name], [company], [quantity], [price]) VALUES (N'm-0004', N'Seclo 20 mg', N'Square Pharmaceuticals Ltd.', 5980, 6)
INSERT [dbo].[medicine] ([id], [name], [company], [quantity], [price]) VALUES (N'm-0005', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 4964, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0001', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 0, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0002', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 0, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0003', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 3, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0004', N'Histasin 4mg', N'Jayson Pharma Ltd.', 1, 0.29)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0005', N'Seclo 20 mg', N'Square Pharmaceuticals Ltd.', 1, 6)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0006', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 2, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0007', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 3, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0008', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 4, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0009', N'Seclo 20 mg', N'Square Pharmaceuticals Ltd.', 10, 6)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0010', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 10, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0011', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 10, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0012', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 10, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0013', N'Seclo 20 mg', N'Square Pharmaceuticals Ltd.', 5, 6)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0014', N'Entacyd Plus', N'Square Pharmaceuticals Ltd.', 4, 2)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0015', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 5, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0016', N'Napa Extend', N'Beximco Pharmaceuticals Ltd.', 5, 3)
INSERT [dbo].[sale] ([id], [name], [company], [quantity], [price]) VALUES (N's-0017', N'Seclo 20 mg', N'Square Pharmaceuticals Ltd.', 4, 6)
INSERT [dbo].[users] ([id], [password], [role], [name]) VALUES (N'bruce789', N'789', N'salesman', N'Bruce')
INSERT [dbo].[users] ([id], [password], [role], [name]) VALUES (N'mina456', N'456', N'salesman', N'Mina')
INSERT [dbo].[users] ([id], [password], [role], [name]) VALUES (N'rafi123', N'123', N'admin', N'Rafi')
INSERT [dbo].[users] ([id], [password], [role], [name]) VALUES (N'raju123', N'123', N'admin', N'Raju')
USE [master]
GO
ALTER DATABASE [pharmacydb] SET  READ_WRITE 
GO
