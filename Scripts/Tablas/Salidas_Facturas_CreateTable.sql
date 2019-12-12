USE [Transportes]
GO
IF OBJECT_ID('Salidas_Facturas') IS NOT NULL
	begin
		select 0
	end	
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Facturas](
		[Id_Salida] [char](10) NOT NULL,
		[FacturaPDF] [varbinary](max) NULL,
		[FacturaXML] [varbinary](max) NULL,
		[Importe] [numeric](18, 2) NULL
	)

	end