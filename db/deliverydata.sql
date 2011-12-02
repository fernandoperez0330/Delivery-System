USE [master]
GO
/****** Object:  Database [deliverydata]    Script Date: 11/29/2011 08:33:56 ******/
CREATE DATABASE [deliverydata];

GO
ALTER DATABASE [deliverydata] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [deliverydata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [deliverydata] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [deliverydata] SET ANSI_NULLS OFF
GO
ALTER DATABASE [deliverydata] SET ANSI_PADDING OFF
GO
ALTER DATABASE [deliverydata] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [deliverydata] SET ARITHABORT OFF
GO
ALTER DATABASE [deliverydata] SET AUTO_CLOSE ON
GO
ALTER DATABASE [deliverydata] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [deliverydata] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [deliverydata] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [deliverydata] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [deliverydata] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [deliverydata] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [deliverydata] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [deliverydata] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [deliverydata] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [deliverydata] SET  DISABLE_BROKER
GO
ALTER DATABASE [deliverydata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [deliverydata] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [deliverydata] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [deliverydata] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [deliverydata] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [deliverydata] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [deliverydata] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [deliverydata] SET  READ_WRITE
GO
ALTER DATABASE [deliverydata] SET RECOVERY SIMPLE
GO
ALTER DATABASE [deliverydata] SET  MULTI_USER
GO
ALTER DATABASE [deliverydata] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [deliverydata] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'deliverydata', N'ON'
GO
USE [deliverydata]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGOSUPERVISOR] [int] NULL,
	[NOMBRE] [nvarchar](25) NOT NULL,
	[DIRECCION] [nvarchar](100) NOT NULL,
	[CIUDAD] [nvarchar](50) NOT NULL,
	[TELEFONO] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](60) NOT NULL,
	[DIRECCION1] [text] NOT NULL,
	[DIRECCION2] [text] NULL,
	[CIUDAD] [nvarchar](60) NOT NULL,
	[TELEFONO] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](50) NOT NULL,
	[DESCRIPCION] [nvarchar](100) NULL,
	[ZIPCODE] [nvarchar](10) NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camiones]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camiones](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](60) NOT NULL,
	[DESCRIPCION] [text] NOT NULL,
 CONSTRAINT [PK_Camiones] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajes]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[FECHAVIAJE] [datetime] NOT NULL,
	[ESTATUS] [int] NOT NULL,
 CONSTRAINT [PK_Viajes] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [nvarchar](60) NOT NULL,
	[CLAVE] [nvarchar](70) NOT NULL,
	[TIPOUSUARIO] [nvarchar](1) NOT NULL,
	[SINCRONIZA] [int] NOT NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suplidores]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suplidores](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](60) NOT NULL,
	[CIUDAD] [nvarchar](60) NOT NULL,
	[ESTADO] [nvarchar](60) NOT NULL,
	[TELEFONO] [nvarchar](14) NOT NULL,
	[DIRECCION1] [text] NOT NULL,
	[NOMBRECORTO] [nvarchar](10) NULL,
 CONSTRAINT [PK_Suplidores] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ordenes](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGOSUPLIDOR] [int] NOT NULL,
	[CODIGOVIAJE] [int] NOT NULL,
	[FECHAORDEN] [datetime] NOT NULL,
	[ESTATUS] [int] NOT NULL,
	[MENSAJE] [text] NULL,
	[PO_NOMBRE] [nvarchar](60) NOT NULL,
	[CANTIDADCAJAS] [int] NOT NULL,
	[PESOORDEN] [decimal](18, 2) NOT NULL,
	[NOMBRERECIBIDOR] [nvarchar](60) NOT NULL,
	[FECHAENTREGA] [datetime] NOT NULL,
	[FIRMAENTREGA] [binary](50) NOT NULL,
 CONSTRAINT [Ordenes_PK] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transacciones_Camiones]    Script Date: 11/29/2011 08:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transacciones_Camiones](
	[CODIGOVIAJE] [int] NOT NULL,
	[CODIGOCAMION] [int] NOT NULL,
	[ODOMETRO] [numeric](18, 0) NOT NULL,
	[FECHATRANSACCION] [datetime] NOT NULL,
	[CODIGOEMPLEADO] [int] NOT NULL,
	[FIRMA] [binary](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Ordenes_Suplidores]    Script Date: 11/29/2011 08:33:57 ******/
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Suplidores] FOREIGN KEY([CODIGOSUPLIDOR])
REFERENCES [dbo].[Suplidores] ([CODIGO])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Suplidores]
GO
/****** Object:  ForeignKey [FK_Ordenes_Viajes]    Script Date: 11/29/2011 08:33:57 ******/
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Viajes] FOREIGN KEY([CODIGOVIAJE])
REFERENCES [dbo].[Viajes] ([CODIGO])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Viajes]
GO
/****** Object:  ForeignKey [FK_Transacciones_Camiones_Camiones]    Script Date: 11/29/2011 08:33:57 ******/
ALTER TABLE [dbo].[Transacciones_Camiones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Camiones_Camiones] FOREIGN KEY([CODIGOCAMION])
REFERENCES [dbo].[Camiones] ([CODIGO])
GO
ALTER TABLE [dbo].[Transacciones_Camiones] CHECK CONSTRAINT [FK_Transacciones_Camiones_Camiones]
GO
/****** Object:  ForeignKey [FK_Transacciones_Camiones_Empleados]    Script Date: 11/29/2011 08:33:57 ******/
ALTER TABLE [dbo].[Transacciones_Camiones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Camiones_Empleados] FOREIGN KEY([CODIGOEMPLEADO])
REFERENCES [dbo].[Empleados] ([CODIGO])
GO
ALTER TABLE [dbo].[Transacciones_Camiones] CHECK CONSTRAINT [FK_Transacciones_Camiones_Empleados]
GO
/****** Object:  ForeignKey [FK_Transacciones_Camiones_Viajes]    Script Date: 11/29/2011 08:33:57 ******/
ALTER TABLE [dbo].[Transacciones_Camiones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Camiones_Viajes] FOREIGN KEY([CODIGOVIAJE])
REFERENCES [dbo].[Viajes] ([CODIGO])
GO
ALTER TABLE [dbo].[Transacciones_Camiones] CHECK CONSTRAINT [FK_Transacciones_Camiones_Viajes]
GO
