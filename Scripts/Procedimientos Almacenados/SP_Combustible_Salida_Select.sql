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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Combustible_Salida_Select')
DROP PROCEDURE SP_Combustible_Salida_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Combustible_Salida_Select
	-- Add the parameters for the stored procedure here
	@Fecha char(8),
	@Id_Activo char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select  Id_Salida,
			Fecha_Salida,
			A.Nombre_Interno,
			S.Observaciones 
		from Transportes.dbo.Salidas as S
		left join Transportes.dbo.Activos as A on A.Id_Activo=S.Id_Activo_Principal
		where Fecha_Salida between dateadd(day,-5,@Fecha) and dateadd(day,5,@Fecha) and S.Id_Activo_Principal=@Id_Activo and Id_salida not in (select isnull(Id_Salida,'') from Transportes.dbo.Carga_Combustible)
		
END
GO