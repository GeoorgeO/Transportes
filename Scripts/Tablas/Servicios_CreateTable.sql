USE [Transportes]
GO
IF OBJECT_ID('Servicios') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Servicios](
		[Folio] [char](10) NOT NULL,
		[Id_Activo] [char](8)NOT NULL,
		[Id_TipoServicio] [char](3) NULL,
		[PrecioTotal] [numeric](18,2) NOT NULL,
		[Kilometraje] [numeric](18,2) NOT NULL,
		[FechaServicio] [datetime] NOT NULL,
		[Id_Proveedor] [char](6) NULL,
		[Id_Factura] [varchar](50) NULL,
		[Comprador] [char](6) NULL,
		[Observaciones][varchar](100) NULL,
	 CONSTRAINT [PK_FolioServicio] PRIMARY KEY CLUSTERED 
	(
		[Folio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end