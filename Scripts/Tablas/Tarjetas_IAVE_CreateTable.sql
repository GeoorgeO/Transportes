USE [Transportes]
GO
IF OBJECT_ID('Tarjetas_IAVE') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tarjetas_IAVE](
		[IAVE] [varchar](50) not NULL,
		[Vigencia] [datetime] Not NULL,
		[Id_Empresa] [char](4) NOT NULL,
		[Monto_Min] [numeric](18,2) NULL,
		[Monto_Max] [numeric](18,2) NULL,
	 CONSTRAINT [PK_Tarjetas_IAVE] PRIMARY KEY CLUSTERED 
	(
		[IAVE] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end