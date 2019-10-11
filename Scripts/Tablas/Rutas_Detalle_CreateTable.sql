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