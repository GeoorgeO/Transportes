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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Carga_Combustible_Select')
DROP PROCEDURE SP_Carga_Combustible_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Carga_Combustible_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Folio,
			FechaCarga,
			Kilometraje,
			Litros,
			PrecioLitro,
			PrecioTotal,
			CC.Id_Activo,
			A.Nombre_Interno,
			CC.Id_Proveedor,
			P.Nombre_Proveedor,
			CC.Id_Factura,
			Comprador,
			E.Nombre_Empleado,
			Observaciones 
		from Carga_Combustible as CC
		left join Activos as A on CC.Id_Activo=A.Id_Activo
		left join Proveedores as P on CC.Id_Proveedor=P.Id_Proveedor
		left join Empleado as E on CC.Comprador=E.Id_Empleado
		

END
GO
