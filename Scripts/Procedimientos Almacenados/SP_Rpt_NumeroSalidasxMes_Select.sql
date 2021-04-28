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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Rpt_NumeroSalidasxMes_Select')
DROP PROCEDURE SP_Rpt_NumeroSalidasxMes_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Rpt_NumeroSalidasxMes_Select 
	-- Add the parameters for the stored procedure here
	@Anio char(4),
	@Id_Empresa varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select * from (
		select DATENAME (MONTH, DATEADD(MONTH, mes - 1, '1900-01-01')) as Meses,
			Nombre_Interno,
			S.Id_Salida as Salidas
		from (select 1 as mes union select 2 union select 3 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9 union select 10 union select 11 union select 12) as M
		left join Transportes.dbo.activos as A on M.mes!=-1
		left join Transportes.dbo.Salidas as S on (S.Id_Activo_Principal =A.Id_Activo or S.Id_Activo_Secundario =A.Id_Activo or S.Id_Activo_Adicional =A.Id_Activo) and  DATEPART(MONTH ,S.Fecha_Salida)=M.mes
		where datepart(year,S.Fecha_Salida)=@Anio and A.Id_Empresa like '%'+@Id_Empresa+'%'
	) S
	pivot (
		 count(S.Salidas)
		 for [Meses] in ([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December])
	) P
	
END
GO