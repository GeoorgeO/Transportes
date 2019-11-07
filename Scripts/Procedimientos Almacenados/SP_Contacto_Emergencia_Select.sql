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
		  ,CE.Calle
		  ,CE.NoInterior
		  ,CE.NoExterior
		  ,CE.Colonia
		  ,CE.Codigo_Postal
		  ,CE.Id_Estado
		  ,EST.Nombre_Estado
		  ,CE.Id_TipoDomicilio
		  ,TD.Nombre_TipoDomicilio
		from Contacto_Emergencia as CE
		left join Estado as EST on EST.Id_Estado=CE.Id_Estado
		left join Tipo_Domicilio as TD on TD.Id_TipoDomicilio=CE.Id_TipoDomicilio
		where CE.Id_Empleado=@Id_Empleado
END
GO