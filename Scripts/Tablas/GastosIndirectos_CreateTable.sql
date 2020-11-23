USE [Transportes]
GO
IF OBJECT_ID('GastosIndirectos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[GastosIndirectos](
		[Id_GastoIndirecto] [char](4) NOT NULL,
		[Nombre_GastoIndirecto] [varchar](40) NULL,
		[Id_cuenta] [varchar](14) NULL,
		[Activo] [int] NULL,
	 CONSTRAINT [PK_GastoIndirecto] PRIMARY KEY CLUSTERED 
	(
		[Id_GastoIndirecto] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end