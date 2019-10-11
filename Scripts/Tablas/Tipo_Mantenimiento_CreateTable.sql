USE [Transportes]
GO
IF OBJECT_ID('Tipo_Mantenimiento') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Mantenimiento](
		[Id_Tipo_Mantenimiento] [char](3) NOT NULL,
		[Nombre_Tipo_Mantenimiento] [varchar](50) NULL,
	 CONSTRAINT [PK_Tipo_Mantenimiento] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Mantenimiento] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end