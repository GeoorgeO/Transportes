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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Servicios_Select')
DROP PROCEDURE SP_Servicios_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Servicios_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Folio,
			
			Kilometraje,
			S.Id_TipoServicio,
			TS.Nombre_TipoServicio,
			PrecioTotal,
			S.Id_Activo,
			A.Nombre_Interno,
			FechaServicio,
			S.Id_Proveedor,
			P.Nombre_Proveedor,
			S.Id_Factura,
			Comprador,
			E.Nombre_Empleado,
			Observaciones 
		from Carga_Combustible as S
		left join Activos as A on S.Id_Activo=A.Id_Activo
		left join Proveedores as P on S.Id_Proveedor=P.Id_Proveedor
		left join Empleado as E on S.Comprador=E.Id_Empleado
		left join TiposServicio as TS on S.Id_TipoServicio=TS.Id_TipoServicio
		

END
GO
