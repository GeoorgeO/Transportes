USE [Transportes]
GO
IF OBJECT_ID('Tipo_Transporte') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Transporte](
		[Id_Tipo_Transporte] [char](4) NOT NULL,
		[Nombre_Tipo_Transporte] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Transporte] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Transporte] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end