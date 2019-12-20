USE [Transportes]
GO
IF OBJECT_ID('HistorialOperadores') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[HistorialOperadores](
		[Id_Operador] [char](6) NOT NULL,
		[Id_Activo] [char](8) NOT NULL,
		[FechaAsignada] [datetime]NOT NULL,
		[Tipo] [char](1) NOT NULL
	) 

	end