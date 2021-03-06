USE [Transportes]
GO
IF OBJECT_ID('Salidas_Diesel') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Diesel](
		[Ticket] [varchar](15) NOT NULL,
		[Id_Salida] [char](10) NOT NULL,
		[Importe] [numeric](18, 2) NULL,
		[Litros] [numeric](18,2) NULL,
	 CONSTRAINT [PK_SalidasDiesel] PRIMARY KEY CLUSTERED 
	(
		[Ticket] ASC,
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end