USE [master]
GO
/****** Object:  Database [UniversityDB-Batch38]    Script Date: 1/31/2017 5:24:42 PM ******/
CREATE DATABASE [UniversityDB-Batch38]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityDB-Batch38', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\UniversityDB-Batch38.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityDB-Batch38_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\UniversityDB-Batch38_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityDB-Batch38] SET COMPATIBILITY_LEVEL = 110
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
ALTER DATABASE [UniversityDB-Batch38] SET AUTO_CREATE_STATISTICS ON 
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
ALTER DATABASE [UniversityDB-Batch38] SET  DISABLE_BROKER 
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
ALTER DATABASE [UniversityDB-Batch38] SET RECOVERY SIMPLE 
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
USE [UniversityDB-Batch38]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 1/31/2017 5:24:42 PM ******/
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
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [RegistrationNo], [Name], [ContactNo], [Email], [Department]) VALUES (4, N'789546                                            ', N'Dhrubo                                                                                              ', N'012457896      ', N'annan@golapi.com                                                                                    ', N'CSE       ')
INSERT [dbo].[Students] ([Id], [RegistrationNo], [Name], [ContactNo], [Email], [Department]) VALUES (5, N'789546                                            ', N'Annan                                                                                               ', N'012457896      ', N'annan@mail.com                                                                                      ', N'CSE       ')
INSERT [dbo].[Students] ([Id], [RegistrationNo], [Name], [ContactNo], [Email], [Department]) VALUES (6, N'1202310200478                                     ', N'Jabed                                                                                               ', N'01674859234    ', N'jabed@mail.com                                                                                      ', N'CSE       ')
INSERT [dbo].[Students] ([Id], [RegistrationNo], [Name], [ContactNo], [Email], [Department]) VALUES (7, N'12345                                             ', N'Jabed                                                                                               ', N'102457         ', N'jbd@jbd.com                                                                                         ', N'CSE       ')
SET IDENTITY_INSERT [dbo].[Students] OFF
USE [master]
GO
ALTER DATABASE [UniversityDB-Batch38] SET  READ_WRITE 
GO
