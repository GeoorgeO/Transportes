USE [Transportes]
GO
IF OBJECT_ID('GastosDirectos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[GastosDirectos](
		[Id_GastoDirecto] [char](4) NOT NULL,
		[Nombre_GastoDirecto] [varchar](40) NULL,
	 CONSTRAINT [PK_GastoDirecto] PRIMARY KEY CLUSTERED 
	(
		[Id_GastoDirecto] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end