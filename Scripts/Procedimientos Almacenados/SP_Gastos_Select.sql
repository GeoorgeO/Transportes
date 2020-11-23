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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Gastos_Select')
DROP PROCEDURE SP_Gastos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Gastos_Select
	-- Add the parameters for the stored procedure here
	@Fecha_Gasto datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select G.Id_Gasto
	      ,G.Fecha_Gasto
	      ,G.Id_GastoIndirecto
	      ,G.Importe
	      ,G.Tipo_Cambio
		  ,I.Nombre_GastoIndirecto
		from Gastos as G
		left join GastosIndirectos as I on I.Id_GastoIndirecto=G.Id_GastoIndirecto
		where G.Fecha_Gasto=@Fecha_Gasto
		
END
GO
