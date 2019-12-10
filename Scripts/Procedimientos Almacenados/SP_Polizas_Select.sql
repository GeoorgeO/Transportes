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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Polizas_Select')
DROP PROCEDURE SP_Polizas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Polizas_Select
	-- Add the parameters for the stored procedure here
	@Estatus bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select P.Poliza_Seguro,
			P.Fecha_Inicio,
			P.Fecha_Fin,
			P.Id_Activo,
			A.Nombre_Interno,
			P.Estatus,
			P.Id_Empresa_Aseguradora,
			EA.Nombre_Empresa_Aseguradora
		from Polizas as P
		left join Activos as A on A.Id_Activo=P.Id_Activo
		left join Empresa_Aseguradora as EA on EA.Id_Empresa_Aseguradora=P.Id_Empresa_Aseguradora
		where P.Estatus=@Estatus
END
GO
