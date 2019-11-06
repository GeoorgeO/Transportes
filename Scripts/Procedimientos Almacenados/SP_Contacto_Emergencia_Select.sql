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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Contacto_Emergencia_Select')
DROP PROCEDURE SP_Contacto_Emergencia_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Contacto_Emergencia_Select
	-- Add the parameters for the stored procedure here
	@Id_Empleado char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select CE.Id_Contacto
	      ,CE.Nombre_Contacto
		  ,CE.Telefono
		  ,CE.Id_Empleado
		from Contacto_Emergencia as CE
		where CE.Id_Empleado=@Id_Empleado
END
GO