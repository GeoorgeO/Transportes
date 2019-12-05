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
		[Total] [numeric](18,2) NOT NULL,
		
	 CONSTRAINT [PK_FolioServicioDetalle] PRIMARY KEY CLUSTERED 
	(
		[Folio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end