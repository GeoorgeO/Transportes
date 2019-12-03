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
		[Secuencia] [char](3)NOT NULL
	
	) 

	end