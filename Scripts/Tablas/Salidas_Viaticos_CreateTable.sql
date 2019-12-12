USE [Transportes]
GO
IF OBJECT_ID('Salidas_Viaticos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Viaticos](
		[Id_Salida] [char](10) NOT NULL,
		[PagadoPor] [varchar](80) NOT NULL,
		[FechaPago] [datetime] NOT NULL,
		[Importe] [numeric](18, 2)NOT NULL
	) 

	end