USE [Transportes]
GO
IF OBJECT_ID('Tipo_Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Licencia](
		[Id_Tipo_Licencia] [char](3) NOT NULL,
		[Nombre_Tipo_Licencia] [varchar](10) NULL,
		[Serie] [varchar](20) NULL,
	 CONSTRAINT [PK_Tipo_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end