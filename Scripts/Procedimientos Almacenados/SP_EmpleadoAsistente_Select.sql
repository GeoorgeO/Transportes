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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_EmpleadoAsistente_Select')
DROP PROCEDURE SP_EmpleadoAsistente_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_EmpleadoAsistente_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select E.Id_Empleado
	      ,E.Id_Tipo_Empleado
		  ,TE.Nombre_Tipo_Empleado
		  ,E.Nombre_Empleado
		  ,E.Telefono
		  ,E.RFC
		  ,E.CURP
		  ,E.No_Identificacion
		  ,E.Id_Licencia
		  ,TL.No_Licencia
		  ,E.Id_Empresa
		  ,EPS.Nombre_Empresa
		from Empleado as E
		left join Tipo_Empleado as TE on E.Id_Tipo_Empleado=TE.Id_Tipo_Empleado
		left join Licencia as TL on E.Id_Licencia=TL.Id_Licencia
		left join Empresa as EPS on EPS.Id_Empresa=E.Id_Empresa
		where TE.Nombre_Tipo_Empleado like '%ayudante%'
			or TE.Nombre_Tipo_Empleado like '%chalan%'
			or TE.Nombre_Tipo_Empleado like '%auxiliar%'
			or TE.Nombre_Tipo_Empleado like '%asistente%'
END
GO
