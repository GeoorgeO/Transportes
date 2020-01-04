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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Activos_Select')
DROP PROCEDURE SP_Activos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Activos_Select
	-- Add the parameters for the stored procedure here
	@Status char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Activo,
			Nombre_Interno,
			Costo_Unidad,
			Fecha_Alta,
			Fecha_Baja,
			Serie,
			Tarjeta_Circulacion,
			Placas,
			A.Id_Tipo_Placa,
			TP.Nombre_Tipo_Placa,
			A.Id_Tipo_Activo,
			TA.Nombre_Tipo_Activo,
			Color,
			Modelo,
			A.Id_Marca,
			M.Nombre_Marca,
			Descripcion,
			A.Id_Tipo_Transporte,
			T.Nombre_Tipo_Transporte,
			Poliza_Seguro,
			A.Id_Empresa_Aseguradora,
			EA.Nombre_Empresa_Aseguradora,
			Status,
			Asignado,
			A.Id_Empleado,
			P.Nombre_Empleado,
			A.Id_Empresa,
			E.Nombre_Empresa,
			A.Id_Factura,
			A.Folio_Tarjeta_Circulacion
		from Activos as A
		left join Marcas as M on M.Id_Marca=A.Id_Marca
		left join Tipo_Transporte as T on T.Id_Tipo_Transporte=A.Id_Tipo_Transporte
		left join Tipo_Activo as TA on TA.Id_Tipo_Activo=A.Id_Tipo_Activo
		left join Empresa as E on E.Id_Empresa=A.Id_Empresa
		left join Tipo_Placa as TP on TP.Id_Tipo_Placa=A.Id_Tipo_Placa
		left join Empleado as P on P.Id_Empleado=A.Id_Empleado
		left join Empresa_Aseguradora as EA on EA.Id_Empresa_Aseguradora=A.Id_Empresa_Aseguradora
		where Status=@Status
END
GO
