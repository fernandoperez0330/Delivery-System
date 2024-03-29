USE [master]
GO
/****** Object:  Database [deliverydata]    Script Date: 12/04/2011 21:19:05 ******/
CREATE DATABASE [deliverydata] ON  PRIMARY 
( NAME = N'deliverydata', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\deliverydata.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'deliverydata_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\deliverydata_log.LDF' , SIZE = 512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
USE [deliverydata]
GO
/****** Object:  Table [dbo].[Viajes]    Script Date: 12/04/2011 21:19:08 ******/
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
/****** Object:  Table [dbo].[Ciudades]    Script Date: 12/04/2011 21:19:08 ******/
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
SET IDENTITY_INSERT [dbo].[Ciudades] ON
INSERT [dbo].[Ciudades] ([CODIGO], [NOMBRE], [DESCRIPCION], [ZIPCODE]) VALUES (1, N'Santo Domingo', N'', N'')
INSERT [dbo].[Ciudades] ([CODIGO], [NOMBRE], [DESCRIPCION], [ZIPCODE]) VALUES (2, N'Santiago', N'', N'')
INSERT [dbo].[Ciudades] ([CODIGO], [NOMBRE], [DESCRIPCION], [ZIPCODE]) VALUES (3, N'Puerto Plata', N'', N'')
INSERT [dbo].[Ciudades] ([CODIGO], [NOMBRE], [DESCRIPCION], [ZIPCODE]) VALUES (4, N'La Romana', N'', N'')
INSERT [dbo].[Ciudades] ([CODIGO], [NOMBRE], [DESCRIPCION], [ZIPCODE]) VALUES (5, N'Higuey', N'', N'')
SET IDENTITY_INSERT [dbo].[Ciudades] OFF
/****** Object:  Table [dbo].[Camiones]    Script Date: 12/04/2011 21:19:08 ******/
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/04/2011 21:19:08 ******/
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
	[TIPO] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON
INSERT [dbo].[Empleados] ([CODIGO], [CODIGOSUPERVISOR], [NOMBRE], [DIRECCION], [CIUDAD], [TELEFONO], [TIPO]) VALUES (1, NULL, N'Adminsitrador 1', N'Direccion', N'Santo Domingo', N'(809) 000-00000', 1)
INSERT [dbo].[Empleados] ([CODIGO], [CODIGOSUPERVISOR], [NOMBRE], [DIRECCION], [CIUDAD], [TELEFONO], [TIPO]) VALUES (2, NULL, N'carrero 2', N'direccion del carrero 2', N'Santo Domingo', N'(000) 000-0000', 2)
INSERT [dbo].[Empleados] ([CODIGO], [CODIGOSUPERVISOR], [NOMBRE], [DIRECCION], [CIUDAD], [TELEFONO], [TIPO]) VALUES (3, NULL, N'carrero 4', N'direccion', N'Santo Domingo', N'(000) 000-0000', 2)
INSERT [dbo].[Empleados] ([CODIGO], [CODIGOSUPERVISOR], [NOMBRE], [DIRECCION], [CIUDAD], [TELEFONO], [TIPO]) VALUES (4, NULL, N'carrero 3', N'direccion de carrero 3', N'Santo Domingo', N'(000) 000-0000', 2)
INSERT [dbo].[Empleados] ([CODIGO], [CODIGOSUPERVISOR], [NOMBRE], [DIRECCION], [CIUDAD], [TELEFONO], [TIPO]) VALUES (5, NULL, N'carrero5', N'direccion del carrero 5', N'Santo Domingo', N'(000) 000-0000', 2)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
/****** Object:  Table [dbo].[Viajes_Camion]    Script Date: 12/04/2011 21:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes_Camion](
	[CODIGOVIAJE] [int] NOT NULL,
	[CODIGOCAMION] [int] NOT NULL,
	[CODIGOEMPLEADO] [int] NOT NULL,
 CONSTRAINT [PK_Viajes_Camion_1] PRIMARY KEY CLUSTERED 
(
	[CODIGOVIAJE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/04/2011 21:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](60) NOT NULL,
	[DIRECCION1] [text] NOT NULL,
	[DIRECCION2] [text] NULL,
	[CIUDAD] [int] NOT NULL,
	[TELEFONO] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/04/2011 21:19:08 ******/
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
	[CODIGOEMPLEADO] [int] NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([CODIGO], [USUARIO], [CLAVE], [TIPOUSUARIO], [SINCRONIZA], [CODIGOEMPLEADO]) VALUES (1, N'admin', N'123456', N'C', 1, 1)
INSERT [dbo].[Usuarios] ([CODIGO], [USUARIO], [CLAVE], [TIPOUSUARIO], [SINCRONIZA], [CODIGOEMPLEADO]) VALUES (2, N'carrero2', N'123456', N'C', 1, 2)
INSERT [dbo].[Usuarios] ([CODIGO], [USUARIO], [CLAVE], [TIPOUSUARIO], [SINCRONIZA], [CODIGOEMPLEADO]) VALUES (3, N'carrero3', N'123456', N'C', 1, 3)
INSERT [dbo].[Usuarios] ([CODIGO], [USUARIO], [CLAVE], [TIPOUSUARIO], [SINCRONIZA], [CODIGOEMPLEADO]) VALUES (4, N'carrero 5', N'123456', N'C', 1, 5)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Suplidores]    Script Date: 12/04/2011 21:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suplidores](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](60) NOT NULL,
	[CIUDAD] [int] NOT NULL,
	[ESTADO] [nvarchar](50) NOT NULL,
	[TELEFONO] [nvarchar](14) NOT NULL,
	[DIRECCION1] [text] NOT NULL,
	[NOMBRECORTO] [nvarchar](10) NULL,
 CONSTRAINT [PK_Suplidores] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 12/04/2011 21:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ordenes](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGOSUPLIDOR] [int] NOT NULL,
	[CODIGOCLIENTE] [int] NOT NULL,
	[CODIGOVIAJE] [int] NOT NULL,
	[FECHAORDEN] [datetime] NOT NULL,
	[ESTATUS] [int] NOT NULL,
	[MENSAJE] [text] NULL,
	[PO_NOMBRE] [nvarchar](60) NOT NULL,
	[CANTIDADCAJAS] [int] NOT NULL,
	[PESOORDEN] [decimal](18, 2) NOT NULL,
	[NOMBRERECIBIDOR] [nvarchar](60) NOT NULL,
	[FECHAENTREGA] [datetime] NOT NULL,
	[FIRMAENTREGA] [binary](50) NULL,
 CONSTRAINT [Ordenes_PK] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transacciones_Camiones]    Script Date: 12/04/2011 21:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transacciones_Camiones](
	[CODIGOORDEN] [int] NOT NULL,
	[CODIGOVIAJE] [int] NOT NULL,
	[ODOMETRO] [numeric](18, 0) NOT NULL,
	[FECHATRANSACCION] [datetime] NOT NULL,
	[FIRMA] [binary](50) NOT NULL,
 CONSTRAINT [PK_Transacciones_Camiones] PRIMARY KEY CLUSTERED 
(
	[CODIGOORDEN] ASC,
	[CODIGOVIAJE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Empleados_TIPO]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF_Empleados_TIPO]  DEFAULT ((2)) FOR [TIPO]
GO
/****** Object:  ForeignKey [FK_Viajes_Camion_Camiones]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Viajes_Camion]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Camion_Camiones] FOREIGN KEY([CODIGOCAMION])
REFERENCES [dbo].[Camiones] ([CODIGO])
GO
ALTER TABLE [dbo].[Viajes_Camion] CHECK CONSTRAINT [FK_Viajes_Camion_Camiones]
GO
/****** Object:  ForeignKey [FK_Viajes_Camion_Empleados]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Viajes_Camion]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Camion_Empleados] FOREIGN KEY([CODIGOEMPLEADO])
REFERENCES [dbo].[Empleados] ([CODIGO])
GO
ALTER TABLE [dbo].[Viajes_Camion] CHECK CONSTRAINT [FK_Viajes_Camion_Empleados]
GO
/****** Object:  ForeignKey [FK_Viajes_Camion_Viajes]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Viajes_Camion]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Camion_Viajes] FOREIGN KEY([CODIGOVIAJE])
REFERENCES [dbo].[Viajes] ([CODIGO])
GO
ALTER TABLE [dbo].[Viajes_Camion] CHECK CONSTRAINT [FK_Viajes_Camion_Viajes]
GO
/****** Object:  ForeignKey [FK_Clientes_Ciudades]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Ciudades] FOREIGN KEY([CIUDAD])
REFERENCES [dbo].[Ciudades] ([CODIGO])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Ciudades]
GO
/****** Object:  ForeignKey [FK_Usuarios_Empleados]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([CODIGOEMPLEADO])
REFERENCES [dbo].[Empleados] ([CODIGO])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
/****** Object:  ForeignKey [FK_Suplidores_Ciudades]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Suplidores]  WITH CHECK ADD  CONSTRAINT [FK_Suplidores_Ciudades] FOREIGN KEY([CIUDAD])
REFERENCES [dbo].[Ciudades] ([CODIGO])
GO
ALTER TABLE [dbo].[Suplidores] CHECK CONSTRAINT [FK_Suplidores_Ciudades]
GO
/****** Object:  ForeignKey [FK_Ordenes_Suplidores]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Suplidores] FOREIGN KEY([CODIGOSUPLIDOR])
REFERENCES [dbo].[Suplidores] ([CODIGO])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Suplidores]
GO
/****** Object:  ForeignKey [FK_Transacciones_Camiones_Viajes]    Script Date: 12/04/2011 21:19:08 ******/
ALTER TABLE [dbo].[Transacciones_Camiones]  WITH NOCHECK ADD  CONSTRAINT [FK_Transacciones_Camiones_Viajes] FOREIGN KEY([CODIGOORDEN])
REFERENCES [dbo].[Ordenes] ([CODIGO])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Transacciones_Camiones] NOCHECK CONSTRAINT [FK_Transacciones_Camiones_Viajes]
GO
