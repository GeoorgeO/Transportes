USE [Transportes]
GO
IF OBJECT_ID('Contacto_Emergencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Contacto_Emergencia](
		[Id_Contacto] [char](6) NOT NULL,
		[Nombre_Contacto] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empleado] [char](6) NULL,
		[Calle] [varchar](100) NULL,
		[NoInterior] [varchar](10) NULL,
		[NoExterior] [varchar](10) NULL,
		[Colonia] [varchar](50) NULL,
		[Codigo_Postal] [char](5) NULL,
		[Id_Estado] [char](3) NULL,
		[Id_TipoDomicilio] [char](4) NULL,
	 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
	(
		[Id_Contacto] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end