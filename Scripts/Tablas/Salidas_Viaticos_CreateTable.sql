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
		[Importe] [numeric](18, 2)NOT NULL,
		[Id_Viatico] [numeric](10,0) NOT NULL,
	CONSTRAINT [PK_SalidasViaticos] PRIMARY KEY CLUSTERED 
	(
		[Id_Viatico] ASC,
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end