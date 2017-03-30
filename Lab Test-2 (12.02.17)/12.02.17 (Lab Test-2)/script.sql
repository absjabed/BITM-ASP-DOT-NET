USE [master]
GO
/****** Object:  Database [MobileStore]    Script Date: 2/12/2017 5:17:41 PM ******/
CREATE DATABASE [MobileStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobileStore', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MobileStore.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MobileStore_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MobileStore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MobileStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobileStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobileStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobileStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobileStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobileStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobileStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobileStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MobileStore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MobileStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobileStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobileStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobileStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobileStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobileStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobileStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobileStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobileStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MobileStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobileStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobileStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobileStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobileStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobileStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MobileStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobileStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MobileStore] SET  MULTI_USER 
GO
ALTER DATABASE [MobileStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobileStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobileStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobileStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MobileStore]
GO
/****** Object:  Table [dbo].[t_Handsets]    Script Date: 2/12/2017 5:17:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Handsets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [varchar](150) NOT NULL,
	[IMEI] [nchar](15) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_t_Handsets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [MobileStore] SET  READ_WRITE 
GO
