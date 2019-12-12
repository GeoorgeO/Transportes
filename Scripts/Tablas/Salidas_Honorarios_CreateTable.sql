USE [Transportes]
GO
IF OBJECT_ID('Salidas_Honorarios') IS NOT NULL
	begin
		select 0
	end	
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Honorarios](
		[Id_Salida] [char](10) NOT NULL,
		[Concepto] [varchar](40) NOT NULL,
		[Importe] [numeric](18, 2) NULL
	)

	end