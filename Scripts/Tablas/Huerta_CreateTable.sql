USE [Transportes]
GO
IF OBJECT_ID('Huerta') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Huerta](
	[Id_Huerta] [char](5) NOT NULL,
	[Nombre_Huerta] [varchar](100) NULL,
	[Registro_Huerta] [varchar](20) NULL,
	[Id_Duenio] [char](4) NULL,
	[Id_Estado] [char](3) NULL,
	[Id_Ciudad] [char](3) NULL,
	[Id_Calidad] [char](3) NULL,
	[Id_Cultivo] [char](2) NULL,
	[zona_Huerta] [numeric](18, 5) NULL,
	[banda_Huerta] [char](1) NULL,
	[este_Huerta] [numeric](18, 5) NULL,
	[norte_Huerta] [numeric](18, 5) NULL,
	[asnm_Huerta] [numeric](18, 5) NULL,
	[latitud_Huerta] [numeric](18, 5) NULL,
	[longitud_Huerta] [numeric](18, 5) NULL,
	[Activa_Huerta] [bit] NULL,
 CONSTRAINT [PK_Huerta] PRIMARY KEY CLUSTERED 
(
	[Id_Huerta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

	end