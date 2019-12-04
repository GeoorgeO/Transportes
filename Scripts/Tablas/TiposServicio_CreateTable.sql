USE [Transportes]
GO
IF OBJECT_ID('TiposServicio') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[TiposServicio](
		[Id_TipoServicio] [char](3) NOT NULL,
		[Nombre_TipoServicio] [varchar](50)NOT NULL,
		[Abreviatura] [varchar](20) NULL,
	 CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED 
	(
		[Id_TipoServicio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end