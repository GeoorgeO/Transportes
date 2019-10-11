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