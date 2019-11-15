USE [Transportes]
GO
IF OBJECT_ID('Perfiles') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Perfiles](
		[Id_Perfil] [char](3) NOT NULL,
		[Nombre_Perfil] [varchar](30) NULL,
	 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
	(
		[Id_Perfil] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end