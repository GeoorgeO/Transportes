USE [Transportes]
GO
IF OBJECT_ID('Salidas_OtrosGastos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_OtrosGastos](
		[Ticket] [varchar](15) NOT NULL,
		[Id_Salida] [char](10) NOT NULL,
		[Id_GastoDirecto] [char](4) NOT NULL,
		[Importe] [numeric](18, 2) NULL,
		[PagoOperador] [bit] NOT NULL,
		[Otros_Gastos] [varchar](80) NULL,
		[Moneda] [char](1) NOT NUll,
		[FacturaPDF] [varbinary](max) NULL,
		[FacturaPDFNombre] [varchar](80) NULL,
		[FacturaXML] [varbinary](max) NULL,
		[FacturaXMLNombre] [varchar](80) NULL,
	 CONSTRAINT [PK_SalidasOtrosGastos] PRIMARY KEY CLUSTERED 
	(
		[Ticket] ASC,
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end