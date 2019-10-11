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