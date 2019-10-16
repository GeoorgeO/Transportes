USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Transportes'))
BEGIN
	create Database Transportes
END

GO
USE [Transportes]
GO
IF OBJECT_ID('Activos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Activos](
		[Id_Activo] [char](8) NOT NULL,
		[Nombre_Interno] [varchar](150) NULL,
		[Costo_Unidad] [numeric](18, 2) NULL,
		[Fecha_Alta] [datetime] NULL,
		[Fecha_Baja] [datetime] NULL,
		[Serie] [varchar](20) NULL,
		[Tarjeta_Circulacion] [varchar](15) NULL,
		[Placas] [varchar](10) NULL,
		[Id_Tipo_Placa] [char](4) NULL,
		[Id_Tipo_Activo] [char](4) NULL,
		[Color] [varchar](15) NULL,
		[Modelo] [varchar](20) NULL,
		[Id_Marca] [char](4) NULL,
		[Descripcion] [varchar](250) NULL,
		[Id_Tipo_Transporte] [char](4) NULL,
		[Poliza_Seguro] [varchar](20) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
		[Status] [char](5) NULL,
		[Asignado] [bit] NULL,
		[Id_Empleado] [char](4) NULL,
		[Id_Empresa] [char](4) NULL,
	 CONSTRAINT [PK_Activos] PRIMARY KEY CLUSTERED 
	(
		[Id_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Agente_Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Agente_Empresa_Aseguradora](
		[Id_Agente_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
	 CONSTRAINT [PK_Agente_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Agente_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Broker_Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Broker_Empresa_Aseguradora](
		[Id_Broker_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Broker_Empresa_Aseguradora] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
	 CONSTRAINT [PK_Broker_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Broker_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Clientes') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Clientes](
		[Id_Cliente] [char](6) NOT NULL,
		[Nombre_Cliente] [varchar](80) NULL,
		[RFC_Cliente] [varchar](15) NULL,
		[Telefono] [varchar](15) NULL,
	 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
	(
		[Id_Cliente] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Domicilios') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Domicilios](
		[Id_Domicilio] [char](4) NOT NULL,
		[Calle] [varchar](100) NULL,
		[NoInterior] [varchar](10) NULL,
		[NoExterior] [varchar](10) NULL,
		[Colonia] [varchar](50) NULL,
		[Codigo_Postal] [char](5) NULL,
		[Id_Estado] [char](3) NULL,
		[Id_TipoDomicilio] [char](3) NULL,
		[Id_LigaDomicilio] [char](4) NULL,
		[Id_Persona] [char](6) NULL,
		[id_TipoPersona] [char](4) NULL,
	 CONSTRAINT [PK_Domicilios] PRIMARY KEY CLUSTERED 
	(
		[Id_Domicilio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empleado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empleado](
		[Id_Empleado] [char](6) NOT NULL,
		[Id_Tipo_Empleado] [char](3) NULL,
		[Nombre_Empleado] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[RFC] [varchar](20) NULL,
		[CURP] [char](18) NULL,
		[No_Identificacion] [varchar](15) NULL,
		[Id_Licencia] [char](6) NULL,
	 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
	(
		[Id_Empleado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empresa_Aseguradora](
		[Id_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](50) NULL,
		[Telefono] [varchar](15) NULL,
		[Telefono_Siniestros] [varchar](15) NULL,
	 CONSTRAINT [PK_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empresa') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empresa](
	[Id_Empresa] [char](4) NOT NULL,
	[Nombre_Empresa] [varchar](50) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id_Empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Estado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Estado](
		[Id_Estado] [char](3) NOT NULL,
		[Nombre_Estado] [varchar](20) NULL,
		[Id_Pais] [varchar](20) NULL,
	 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
	(
		[Id_Estado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Licencia](
		[Id_Licencia] [char](6) NOT NULL,
		[Id_Tipo_Licencia] [char](3) NULL,
		[Vigencia] [datetime] NULL,
		[No_Licencia] [varchar](20) NULL,
	 CONSTRAINT [PK_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Mantenimiento') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Mantenimiento](
		[Id_Mantenimiento] [char](10) NOT NULL,
		[Nombre_Mantenimiento] [varchar](100) NULL,
		[Id_Tipo_Mantenimiento] [char](3) NULL,
		[Fecha_Programacion] [datetime] NULL,
		[KM_Programacion] [numeric](18, 2) NULL,
	 CONSTRAINT [PK_Mantenimiento] PRIMARY KEY CLUSTERED 
	(
		[Id_Mantenimiento] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Marcas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Marcas](
		[Id_Marca] [char](4) NOT NULL,
		[Nombre_Marca] [varchar](70) NULL,
	 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
	(
		[Id_Marca] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Pais') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Pais](
		[Id_Pais] [char](3) NOT NULL,
		[Nombre_Pais] [varchar](30) NULL,
	 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
	(
		[Id_Pais] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Proveedores') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Proveedores](
	[Id_Proveedor] [char](6) NOT NULL,
	[Nombre_Proveedor] [varchar](80) NULL,
	[RFC_Proveedor] [varchar](15) NULL,
	[Telefono] [varchar](15) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Rutas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Rutas](
		[Id_Rutas] [char](4) NOT NULL,
		[Nombre_Ruta] [varchar](80) NULL,
	 CONSTRAINT [PK_Rutas] PRIMARY KEY CLUSTERED 
	(
		[Id_Rutas] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Rutas_Detalle') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Rutas_Detalle](
		[Id_Rutas] [char](4) NOT NULL,
		[Nombre_Rutas_Detalle] [varchar](100) NULL,
		[Secuencia] [char](3) NULL,
	 CONSTRAINT [PK_Rutas_Detalle] PRIMARY KEY CLUSTERED 
	(
		[Id_Rutas] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('TipoPersona') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[TipoPersona](
		[Id_TipoPersona] [char](4) NOT NULL,
		[TipoPersona] [varbinary](50) NULL,
	 CONSTRAINT [PK_TipoPersona] PRIMARY KEY CLUSTERED 
	(
		[Id_TipoPersona] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Activo') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Activo](
		[Id_Tipo_Activo] [char](4) NOT NULL,
		[Nombre_Tipo_Activo] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Activo] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Domicilio') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Domicilio](
		[Id_TipoDomicilio] [char](4) NOT NULL,
		[Nombre_TipoDomilio] [varchar](50) NULL,
	 CONSTRAINT [PK_Tipo_Domicilio] PRIMARY KEY CLUSTERED 
	(
		[Id_TipoDomicilio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Empleado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Empleado](
		[Id_Tipo_Empleado] [char](3) NOT NULL,
		[Nombre_Tipo_Empleado] [varchar](25) NULL,
	 CONSTRAINT [PK_Tipo_Empleado] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Empleado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Licencia](
		[Id_Tipo_Licencia] [char](3) NOT NULL,
		[Nombre_Tipo_Licencia] [varchar](10) NULL,
		[Serie] [varchar](20) NULL,
	 CONSTRAINT [PK_Tipo_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Mantenimiento') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Mantenimiento](
		[Id_Tipo_Mantenimiento] [char](3) NOT NULL,
		[Nombre_Tipo_Mantenimiento] [varchar](50) NULL,
	 CONSTRAINT [PK_Tipo_Mantenimiento] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Mantenimiento] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Placa') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Placa](
		[Id_Tipo_Placa] [char](4) NOT NULL,
		[Nombre_Tipo_Placa] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Placa] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Placa] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Transporte') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Transporte](
		[Id_Tipo_Transporte] [char](4) NOT NULL,
		[Nombre_Tipo_Transporte] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Transporte] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Transporte] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
