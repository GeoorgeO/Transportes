USE [Transportes]
GO
IF OBJECT_ID('Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Licencia](
		[Id_Licencia] [char](6) NOT NULL,
		[Id_Tipo_Licencia] [char](3) NULL,
		[Vigencia] [datetime] NULL,
		[No_Licencia] [varchar](20) NULL,
	 CONSTRAINT [PK_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end