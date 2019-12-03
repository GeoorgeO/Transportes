USE [Transportes]
GO
IF OBJECT_ID('Carga_Combustible') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Carga_Combustible](
		[Folio] [char](8) NOT NULL,
		[FechaCarga] [datetime]NOT NULL,
		[Kilometraje] [numeric](18,2) NULL,
		[Litros] [numeric](18,2) NULL,
		[PrecioLitro] [numeric](18,2) NULL,
		[PrecioTotal] [numeric](18,2) NULL,
		[Id_Activo] [char](8) NOT NULL,
		[Id_Proveedor] [char](6) NULL,
		[Id_Factura] [varchar](50) NULL,
		[Comprador][char](6) NULL,
		[Observaciones][varchar](100) NULL,
	 CONSTRAINT [PK_Folio] PRIMARY KEY CLUSTERED 
	(
		[Folio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end