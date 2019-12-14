USE [Transportes]
GO
IF OBJECT_ID('Salidas_Honorarios') IS NOT NULL
	begin
		select 0
	end	
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_Honorarios](
		[Id_Salida] [char](10) NOT NULL,
		[Concepto] [varchar](40) NOT NULL,
		[Importe] [numeric](18, 2) NULL,
		[Id_Honorario] [numeric](10,0) NOT NULL,
	CONSTRAINT [PK_SalidasHonorarios] PRIMARY KEY CLUSTERED 
	(
		[Id_Honorario] ASC,
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end