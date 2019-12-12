USE [Transportes]
GO
IF OBJECT_ID('Salidas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas](
		[Id_Salida] [char](10) NOT NULL,
		[Fecha_Salida] [datetime]NOT NULL,
		[Id_Activo_Principal] [char](8) NOT NULL,
		[Id_Operador] [char](6) NOT NULL,
		[Id_Ayudante] [char](6) NOT NULL,
		[Id_Activo_Secundario] [char](8) NULL,
		[Id_Activo_Adicional] [char](8) NULL,
		[Id_Ruta] [char](4) NOT NULL,
		[Id_MotivoSalida] [char](3) NOT NULL,
		[Id_Cliente] [char](6) NULL,
		[km_Inicio] [numeric](18,2) NULL,
		[km_Fin] [numeric](18,2) NULL,
		[Dias_Viaje] [numeric](18,2) NULL,
		[Lts_Km] [numeric](18,2) NULL,
		[Id_Huerta] [char](5) NULL,
		[Observaciones] [varchar](100) NULL,
	 CONSTRAINT [PK_Salidas] PRIMARY KEY CLUSTERED 
	(
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end