USE [Transportes]
GO
IF OBJECT_ID('Salidas_Cruces') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Cruces](
		[Id_Salida] [char](10) NOT NULL,
		[Importe] [numeric](18, 2) NULL,
		[Moneda] [char](1) NOT NUll,
		[FacturaPDF] [varbinary](max) NULL,
		[FacturaPDFNombre] [varchar](80) NULL,
		[FacturaXML] [varbinary](max) NULL,
		[FacturaXMLNombre] [varchar](80) NULL,
		[Fecha_Cruce][datetime] NULL,
		[Id_Archivo] [numeric](10,0) NOT NULL,
	 CONSTRAINT [PK_SalidasCruces] PRIMARY KEY CLUSTERED 
	(
		[Id_Archivo] ASC,
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end