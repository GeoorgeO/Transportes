USE [Transportes]
GO
IF OBJECT_ID('Activos_TCombustible') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Activos_TCombustible](
		[Id_Activo] [char](8) NOT NULL,
		[Id_Tarjeta_Combustible] [varchar](20) not NULL,
	 CONSTRAINT [PK_Activos_TCombustible] PRIMARY KEY CLUSTERED 
	(
		[Id_Activo] ASC,
		[Id_Tarjeta_Combustible] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end