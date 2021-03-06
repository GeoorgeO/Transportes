USE [Transportes]
GO
IF OBJECT_ID('Clientes') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Clientes](
		[Id_Cliente] [char](6) NOT NULL,
		[Nombre_Cliente] [varchar](80) NULL,
		[RFC_Cliente] [varchar](15) NULL,
		[Telefono] [varchar](15) NULL,
		[Dias_Credito] [numeric](18,0) NULL,
	 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
	(
		[Id_Cliente] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end