USE [Transportes]
GO
IF OBJECT_ID('Agente_Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Agente_Empresa_Aseguradora](
		[Id_Agente_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
	 CONSTRAINT [PK_Agente_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Agente_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end