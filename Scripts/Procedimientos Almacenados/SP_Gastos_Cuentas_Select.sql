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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Gastos_Cuentas_Select')
DROP PROCEDURE SP_Gastos_Cuentas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Gastos_Cuentas_Select 
	-- Add the parameters for the stored procedure here
	@F_Del datetime,
	@F_Al datetime,
	@Id_Empresa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select G.Id_Gasto,
		G.Fecha_Gasto,
		G.Id_GastoIndirecto,
		GI.Nombre_GastoIndirecto,
		(select sum(T.Importe ) from Gastos as T where T.Fecha_Gasto between @F_Del and @F_Al) as Total,
		G.Importe as Importe_P,
	G.Importe/G.Tipo_Cambio as Importe_D,
	(G.Importe) * (Gas.Importe_P/(select count(Id_Activo) from transportes.dbo.activos where Status='ACTIVO' and Activo_Primario=1 and Id_Empresa=@Id_Empresa)) / (select sum(T.Importe ) from Gastos as T where T.Fecha_Gasto between @F_Del and @F_Al) as Prorateo_P,
	(G.Importe/Tipo_Cambio)	* (Gas.Importe_D/(select count(Id_Activo) from transportes.dbo.activos where Status='ACTIVO' and Activo_Primario=1 and Id_Empresa=@Id_Empresa))/(select sum(T.Importe/Tipo_Cambio ) from Gastos as T where T.Fecha_Gasto between @F_Del and @F_Al)  as Prorateo_D
	from Gastos as G 
	left join GastosIndirectos as GI on GI.Id_GastoIndirecto=G.Id_GastoIndirecto
left join (select sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select uno, Importe as Importe_P,  Importe/Tipo_Cambio  as Importe_D,Fecha_Gasto from (select *,1 as uno from  transportes.dbo.Gastos) as X ) as T where Fecha_Gasto between @F_Del and @F_Al group by uno ) as Gas on 1=1
where G.Fecha_Gasto between @F_Del and @F_Al

		
	
END
GO