USE [master]
GO
/****** Object:  Database [ItemsDB_38]    Script Date: 2017-03-08 02:02:50 AM ******/
CREATE DATABASE [ItemsDB_38]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ItemsDB_38', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ItemsDB_38.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ItemsDB_38_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ItemsDB_38_log.ldf' , SIZE = 560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ItemsDB_38] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ItemsDB_38].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ItemsDB_38] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ItemsDB_38] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ItemsDB_38] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ItemsDB_38] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ItemsDB_38] SET ARITHABORT OFF 
GO
ALTER DATABASE [ItemsDB_38] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ItemsDB_38] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ItemsDB_38] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ItemsDB_38] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ItemsDB_38] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ItemsDB_38] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ItemsDB_38] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ItemsDB_38] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ItemsDB_38] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ItemsDB_38] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ItemsDB_38] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ItemsDB_38] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ItemsDB_38] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ItemsDB_38] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ItemsDB_38] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ItemsDB_38] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ItemsDB_38] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ItemsDB_38] SET RECOVERY FULL 
GO
ALTER DATABASE [ItemsDB_38] SET  MULTI_USER 
GO
ALTER DATABASE [ItemsDB_38] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ItemsDB_38] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ItemsDB_38] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ItemsDB_38] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ItemsDB_38] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ItemsDB_38', N'ON'
GO
USE [ItemsDB_38]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2017-03-08 02:02:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 2017-03-08 02:02:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ItemWithCategory]    Script Date: 2017-03-08 02:02:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ItemWithCategory] AS
SELECT Items.Id ItemId, Items.Name ItemName, Items.Price ItemPrice, Categories.Id CategoryId, Categories.Name CategoryName 
FROM Items,Categories
WHERE Items.CategoryId = Categories.Id
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'First Food')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Fruit')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Snacks')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Soft Drinks')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1, N'JackFruit', CAST(100.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (2, N'Mango', CAST(180.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (3, N'Banana', CAST(25.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (4, N'Lichi', CAST(100.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1002, N'Chiken Fry', CAST(250.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1003, N'Pizza', CAST(150.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1004, N'Zeera Pani', CAST(20.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1005, N'Chicken Chap', CAST(80.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1006, N'Chicken Roll', CAST(45.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1007, N'Orange', CAST(120.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1008, N'Lemonade Juice', CAST(25.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[Items] ([Id], [Name], [Price], [CategoryId]) VALUES (1009, N'Somucha', CAST(10.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Categories]    Script Date: 2017-03-08 02:02:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories] ON [dbo].[Categories]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Items]    Script Date: 2017-03-08 02:02:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Items] ON [dbo].[Items]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories]
GO
USE [master]
GO
ALTER DATABASE [ItemsDB_38] SET  READ_WRITE 
GO
