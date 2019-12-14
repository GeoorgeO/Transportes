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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_RevisionUnidad_Select')
DROP PROCEDURE SP_Salidas_RevisionUnidad_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Salidas_RevisionUnidad_Select
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Salida
	           ,AceiteMotor
			   ,LiqDireccionHidraulica
			   ,Anticongelante
			   ,TCirculacion
			   ,TCombustible
			   ,TLicencia
			   ,LimpiezaInterior
			   ,PresionLlantas
			   ,Luces
			   ,CajaCampo
			   ,Combustible
		from Salidas_RevisionUnidad
		where Id_Salida=@Id_Salida

END
GO
