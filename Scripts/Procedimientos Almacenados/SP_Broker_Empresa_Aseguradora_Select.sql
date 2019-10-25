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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Broker_Empresa_Aseguradora_Select')
DROP PROCEDURE SP_Broker_Empresa_Aseguradora_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Broker_Empresa_Aseguradora_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select A.Id_Broker_Empresa_Aseguradora
	      ,A.Nombre_Broker_Empresa_Aseguradora
		  ,A.Telefono
		  ,A.Id_Empresa_Aseguradora
		  ,E.Nombre_Empresa_Aseguradora
		from Broker_Empresa_Aseguradora as A
		left join Empresa_Aseguradora as E on E.Id_Empresa_Aseguradora=A.Id_Empresa_Aseguradora
END
GO
