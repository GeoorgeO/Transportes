USE [Transportes]
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Cuentas_Padre_Select')
DROP PROCEDURE SP_Cuentas_Padre_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Cuentas_Padre_Select
	-- Add the parameters for the stored procedure here
	@Id_cuenta varchar(14)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select C.Id_cuenta
	      ,C.Id_cuenta_padre
	      ,C.Nombre_cuenta
	      ,C.Id_tipocuenta
		  ,TC.Nombre_tipocuenta
	      ,C.Naturaleza
		from Cuentas_Contables as C
		left join Tipos_Cuentas as TC on TC.Id_tipocuenta=C.Id_tipocuenta
		where C.Activa=1 and c.Id_cuenta!=@Id_cuenta

END
GO
