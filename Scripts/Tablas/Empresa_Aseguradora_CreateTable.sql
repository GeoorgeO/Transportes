USE [Transportes]
GO
IF OBJECT_ID('Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empresa_Aseguradora](
		[Id_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](50) NULL,
		[Telefono] [varchar](15) NULL,
		[Telefono_Siniestros] [varchar](15) NULL,
	 CONSTRAINT [PK_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end