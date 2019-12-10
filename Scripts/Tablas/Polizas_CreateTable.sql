USE [Transportes]
GO
IF OBJECT_ID('Polizas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Polizas](
		[Poliza_Seguro] [varchar](20) NOT NULL,
		[Fecha_Inicio] datetime NOT NULL,
		[Fecha_Fin] datetime NOT NULL,
		[Id_Activo] [char](8) NULL,
		[Status] [bit] NOT NULL,
		[Id_Empresa_Aseguradora] [char](4) NOT NULL,
	 CONSTRAINT [PK_Poliza] PRIMARY KEY CLUSTERED 
	(
		[Poliza_Seguro] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end