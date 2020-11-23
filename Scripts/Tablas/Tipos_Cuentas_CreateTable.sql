USE [Transportes]
GO
IF OBJECT_ID('Tipos_Cuentas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipos_Cuentas](
		[Id_tipocuenta] [char](2) NULL,
		[Nombre_tipocuenta] [varchar](50) NULL
	) ON [PRIMARY]

	end