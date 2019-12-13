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
		[Status] [char](8) NULL,
		[Asignado] [bit] NULL,
		[Id_Empleado] [char](6) NULL,
		[Id_Empresa] [char](4) NULL,
		[Id_Factura] [varchar](50) NULL,
		[IAVE] [varchar](50) NULL,
		[Folio_Tarjeta_Circulacion] [varchar](20) NULL,
		[Id_Tarjeta_Combustible] [varchar](20) NULL,
		[EnRuta] [bit] NULL,
	 CONSTRAINT [PK_Activos] PRIMARY KEY CLUSTERED 
	(
		[Id_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end