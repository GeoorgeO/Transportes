USE [Transportes]
GO
IF OBJECT_ID('Entradas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Entradas](
		[Id_Entrada] [char](10) NOT NULL,
		[Id_Salida] [char](10) NULL,
		[Fecha_Entrada] [datetime] NOT NULL,
		[Fecha_Cruce] [datetime] NULL,
		[Id_Activo_P] char(8) NOT NULL,
		[Id_Activo_1] char(8) NULL,
		[Id_Activo_2] char(8) NULL,
	 CONSTRAINT [PK_Entradas] PRIMARY KEY CLUSTERED 
	(
		[Id_Entrada] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end