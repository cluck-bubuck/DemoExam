USE [master]
GO
/****** Object:  Database [Terna_SportShop]    Script Date: 27.04.2024 19:58:41 ******/
CREATE DATABASE [Terna_SportShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Terna_SportShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Terna_SportShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Terna_SportShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Terna_SportShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Terna_SportShop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Terna_SportShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Terna_SportShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Terna_SportShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Terna_SportShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Terna_SportShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Terna_SportShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Terna_SportShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Terna_SportShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Terna_SportShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Terna_SportShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Terna_SportShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Terna_SportShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Terna_SportShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Terna_SportShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Terna_SportShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Terna_SportShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Terna_SportShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Terna_SportShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Terna_SportShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Terna_SportShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Terna_SportShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Terna_SportShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Terna_SportShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Terna_SportShop] SET RECOVERY FULL 
GO
ALTER DATABASE [Terna_SportShop] SET  MULTI_USER 
GO
ALTER DATABASE [Terna_SportShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Terna_SportShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Terna_SportShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Terna_SportShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Terna_SportShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Terna_SportShop', N'ON'
GO
ALTER DATABASE [Terna_SportShop] SET QUERY_STORE = OFF
GO
USE [Terna_SportShop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Terna_SportShop]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27.04.2024 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[product_article] [nvarchar](20) NOT NULL,
	[product_name] [nvarchar](255) NOT NULL,
	[product_unit] [nvarchar](10) NOT NULL,
	[product_price] [float] NOT NULL,
	[product_discountMax] [int] NOT NULL,
	[product_manufacturer] [nvarchar](30) NOT NULL,
	[product_provider] [nvarchar](30) NOT NULL,
	[product_category] [nvarchar](20) NOT NULL,
	[product_discount] [int] NOT NULL,
	[product_count] [int] NOT NULL,
	[product_discription] [nvarchar](max) NOT NULL,
	[product_image] [nvarchar](255) NULL,
 CONSTRAINT [PK_Product$] PRIMARY KEY CLUSTERED 
(
	[product_article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ProductView]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create View [dbo].[ProductView]
as

select p.[product_article] as 'Артикуль', p.[product_name] as 'Название', p.product_price as 'Цена', p.product_discount as 'Скидка', p.product_count as 'Количество', p.product_manufacturer as 'Производитель', p.product_discription as 'Описание', p.product_discountMax as 'Максимальная скидка', p.product_image as 'Фото'
from Products p
GO
/****** Object:  Table [dbo].[Order]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_startdate] [datetime] NOT NULL,
	[order_enddate] [datetime] NULL,
	[point_id] [int] NOT NULL,
	[user_id] [int] NULL,
	[order_code] [int] NOT NULL,
	[order_status] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[order_id] [int] NOT NULL,
	[product_article] [nvarchar](20) NOT NULL,
	[orderProd_count] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PointOfIssue]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointOfIssue](
	[point_id] [int] IDENTITY(1,1) NOT NULL,
	[point_index] [int] NOT NULL,
	[point_city] [nvarchar](30) NOT NULL,
	[point_street] [nvarchar](30) NOT NULL,
	[point_streetNumb] [int] NOT NULL,
 CONSTRAINT [PK_PointOfIssue] PRIMARY KEY CLUSTERED 
(
	[point_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](20) NOT NULL,
	[user_surname] [nvarchar](30) NOT NULL,
	[user_patronymic] [nvarchar](30) NOT NULL,
	[user_login] [nvarchar](30) NOT NULL,
	[user_pass] [nvarchar](30) NOT NULL,
	[role_id] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PointOfIssue] FOREIGN KEY([point_id])
REFERENCES [dbo].[PointOfIssue] ([point_id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_PointOfIssue]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Users]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([order_id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Products] FOREIGN KEY([product_article])
REFERENCES [dbo].[Products] ([product_article])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Products]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  StoredProcedure [dbo].[Enter]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PRocedure [dbo].[Enter]
@log nvarchar(30),
@pass nvarchar(30)

as

select * 
from Users 
where user_login = @log and user_pass = @pass
GO
/****** Object:  StoredProcedure [dbo].[ProductAdd]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductAdd]
@article nvarchar(20), 
@name nvarchar(max),
@price float,
@discountMax int,
@manufacturer nvarchar(30),
@provider nvarchar(30),
@category nvarchar(20),
@discount int,
@count int,
@discription nvarchar(max),
@image nvarchar(max)

as
set @article = (select Convert(varchar(5), Right(newid(),5)) as id)
set @price = @price -(@price * @discount/100)

insert into Products([product_article],[product_name],[product_unit],[product_price],[product_discountMax],[product_manufacturer],[product_provider],[product_category],[product_discount], [product_count],[product_discription], [product_image])
values(@article, @name, 'шт', @price, @discountMax, @manufacturer, @provider, @category, @discount, @count, @discription, @image)
GO
/****** Object:  StoredProcedure [dbo].[RegUser]    Script Date: 27.04.2024 19:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PRocedure [dbo].[RegUser]
@name nvarchar(20),
@surname nvarchar(30),
@patron nvarchar(30),
@log nvarchar(30),
@pass nvarchar(30)

as

insert into Users([user_name], [user_surname], [user_patronymic], [user_login], [user_pass], [role_id])
Values(@name, @surname, @patron, @log, @pass, 3)
GO
USE [master]
GO
ALTER DATABASE [Terna_SportShop] SET  READ_WRITE 
GO
