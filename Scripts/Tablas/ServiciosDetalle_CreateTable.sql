USE [Transportes]
GO
IF OBJECT_ID('ServiciosDetalle') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[ServiciosDetalle](
		[Folio] [char](10) NOT NULL,
		[Nombre_ServicioDetalle] [varchar](80)NOT NULL,
		[Secuencia][numeric](10,0),
		[Costo] [numeric](18,2)NOT NULL,
		[Piezas] [numeric](18,2)NOT NULL,
		[Total] [numeric](18,2) NOT NULL
	) 

	end