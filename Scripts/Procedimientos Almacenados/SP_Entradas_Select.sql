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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Entradas_Select')
DROP PROCEDURE SP_Entradas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Entradas_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Entrada
	      ,Id_Salida
		  ,Fecha_Entrada
		  ,Id_Activo_P=(select Id_Activo_P from Activos where Id_Activo=E.Id_Activo_P)
		  ,Nombre_Activo_P=(select Nombre_Interno from Activos where Id_Activo=E.Id_Activo_P)
		  ,Id_Activo_1=(select Id_Activo_P from Activos where Id_Activo=E.Id_Activo_1)
		  ,Nombre_Activo_1=(select Nombre_Interno from Activos where Id_Activo=E.Id_Activo_1)
		  ,Id_Activo_2=(select Id_Activo_P from Activos where Id_Activo=E.Id_Activo_2)  
		  ,Nombre_Activo_2=(select Nombre_Interno from Activos where Id_Activo=E.Id_Activo_2)
		from Entradas as E

END
GO
