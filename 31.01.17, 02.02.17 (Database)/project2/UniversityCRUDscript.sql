USE [master]
GO
/****** Object:  Database [UniversityDB-Batch38]    Script Date: 2017-02-03 09:48:20 PM ******/
CREATE DATABASE [UniversityDB-Batch38]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityDB-Batch38', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\UniversityDB-Batch38.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityDB-Batch38_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\UniversityDB-Batch38_log.ldf' , SIZE = 560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityDB-Batch38] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityDB-Batch38].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityDB-Batch38] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityDB-Batch38] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityDB-Batch38] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UniversityDB-Batch38] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityDB-Batch38] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET RECOVERY FULL 
GO
ALTER DATABASE [UniversityDB-Batch38] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityDB-Batch38] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityDB-Batch38] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityDB-Batch38] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityDB-Batch38] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [UniversityDB-Batch38] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UniversityDB-Batch38', N'ON'
GO
USE [UniversityDB-Batch38]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2017-02-03 09:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RegistrationNo] [nchar](50) NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[ContactNo] [nchar](15) NULL,
	[Email] [nchar](100) NOT NULL,
	[Department] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Students_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Students]    Script Date: 2017-02-03 09:48:20 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Students] ON [dbo].[Students]
(
	[RegistrationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [UniversityDB-Batch38] SET  READ_WRITE 
GO
