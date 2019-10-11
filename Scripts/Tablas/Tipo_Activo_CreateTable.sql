USE [Transportes]
GO
IF OBJECT_ID('Tipo_Activo') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Activo](
		[Id_Tipo_Activo] [char](4) NOT NULL,
		[Nombre_Tipo_Activo] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Activo] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end