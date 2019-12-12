USE [Transportes]
GO
IF OBJECT_ID('MotivosSalida') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[MotivosSalida](
		[Id_MotivoSalida] [char](3) NOT NULL,
		[Nombre_MotivoSalida] [varchar](80) NOT NULL,
	 CONSTRAINT [PK_MotivosSalida] PRIMARY KEY CLUSTERED 
	(
		[Id_MotivoSalida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end