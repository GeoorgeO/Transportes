USE [Transportes]
GO
IF OBJECT_ID('Tipo_Placa') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Placa](
		[Id_Tipo_Placa] [char](4) NOT NULL,
		[Nombre_Tipo_Placa] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Placa] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Placa] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end