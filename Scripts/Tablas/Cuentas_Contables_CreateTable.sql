USE [Transportes]
GO
IF OBJECT_ID('Cuentas_Contables') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Cuentas_Contables](
		[Id_cuenta] [varchar](14) NULL,
		[Id_cuenta_padre] [varchar](10) NULL,
		[Nombre_cuenta] [varchar](60) NULL,
		[Id_tipocuenta] [char](2) NULL,
		[Naturaleza] [char](1) NULL,
		[Activa] [int] NULL
	) ON [PRIMARY]

	end