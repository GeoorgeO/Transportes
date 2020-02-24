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
		[FacturaPDFNombre] [varchar](80) NULL,
		[FacturaXML] [varbinary](max) NULL,
		[FacturaXMLNombre] [varchar](80) NULL,
		[Importe] [numeric](18, 2) NULL,
		[Id_Archivo] [numeric](10,0) NOT NULL,
		[Moneda] [char](1) NOT NUll,
		[Fecha_Factura] [datetime] NULL,
		[Fecha_Cobro] [datetime] NULL,
		[Diferido] [bit] NULL,
		[Fecha_Pago] [datetime] NULL
	)

	end