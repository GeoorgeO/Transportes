USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_Gastos_Cuentas_Select]    Script Date: 30/04/2021 01:34:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Gastos_Cuentas_xMes_Select')
DROP PROCEDURE SP_Gastos_Cuentas_xMes_Select
GO
CREATE PROCEDURE SP_Gastos_Cuentas_xMes_Select 
	-- Add the parameters for the stored procedure here
	@Anio char(4),
	@Id_Empresa varchar(4),
	@Cuentas varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @table TABLE ( id VARCHAR(60))
	DECLARE @x INT = 0
	DECLARE @firstcomma INT = 0
	DECLARE @nextcomma INT = 0

	SET @x = LEN(@Cuentas) - LEN(REPLACE(@Cuentas, ',', '')) + 1 

	WHILE @x > 0
		BEGIN
			SET @nextcomma = CASE WHEN CHARINDEX(',', @Cuentas, @firstcomma + 1) = 0
								  THEN LEN(@Cuentas) + 1
								  ELSE CHARINDEX(',', @Cuentas, @firstcomma + 1)
							 END
			INSERT  INTO @table
			VALUES  ( SUBSTRING(@Cuentas, @firstcomma + 1, (@nextcomma - @firstcomma) - 1) )
			SET @firstcomma = CHARINDEX(',', @Cuentas, @firstcomma + 1)
			SET @x = @x - 1
		END


	select G.Poliza,
	G.Fecha_Gasto,
		G.Id_Cuenta,
		GI.Nombre_Cuenta,
		(select sum(T.Importe ) from Gastos as T where datepart(Year,T.Fecha_Gasto)=@Anio) as Total,
		G.Importe as Importe_P,
	G.Importe/G.Tipo_Cambio as Importe_D,
	(G.Importe) * (Gas.Importe_P/(select count(Id_Activo) from transportes.dbo.activos where Status='ACTIVO' and Activo_Primario=1 and Id_Empresa like '%'+@Id_empresa+'%')) / (select sum(T.Importe ) from Gastos as T where datepart(YEAR,T.Fecha_Gasto)=@Anio ) as Prorateo_P,
	(G.Importe/Tipo_Cambio)	* (Gas.Importe_D/(select count(Id_Activo) from transportes.dbo.activos where Status='ACTIVO' and Activo_Primario=1 and Id_Empresa like '%'+@Id_empresa+'%'))/(select sum(T.Importe/Tipo_Cambio ) from Gastos as T where datepart(YEAR,T.Fecha_Gasto)=@Anio)  as Prorateo_D
	from Gastos as G 
	left join Cuentas_Contables as GI on GI.Id_cuenta=G.Id_Cuenta
left join (select sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select uno, Importe as Importe_P,  Importe/Tipo_Cambio  as Importe_D,Fecha_Gasto from (select *,1 as uno from  transportes.dbo.Gastos) as X ) as T where datepart(YEAR,Fecha_Gasto)=@Anio  group by uno ) as Gas on 1=1
where datepart(Year,G.Fecha_Gasto)=@Anio
	and G.Id_Cuenta not in (select id from @table)
		
	
END
GO