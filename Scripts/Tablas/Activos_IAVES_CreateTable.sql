USE [Transportes]
GO
IF OBJECT_ID('Activos_IAVES') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Activos_IAVES](
		[Id_Activo] [char](8) NOT NULL,
		[IAVE] [varchar](50) NOT NULL,
	 CONSTRAINT [PK_Activos_IAVES] PRIMARY KEY CLUSTERED 
	(
		[Id_Activo] ASC,
		[IAVE] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end