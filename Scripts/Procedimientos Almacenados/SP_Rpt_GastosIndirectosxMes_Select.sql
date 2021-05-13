USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_Gastos_Cuentas_Select]    Script Date: 30/04/2021 01:34:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Rpt_GastosIndirectosxMes_Select')
DROP PROCEDURE SP_Rpt_GastosIndirectosxMes_Select
GO
CREATE PROCEDURE SP_Rpt_GastosIndirectosxMes_Select 
	-- Add the parameters for the stored procedure here
	@Anio char(4),
	@Id_Empresa varchar(4),
	@Cuentas varchar(500),
	@Moneda char(4)
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

	select * from (
	select 
		GI.Nombre_Cuenta,
		DATENAME (MONTH, DATEADD(MONTH, mes - 1, '1900-01-01')) as Meses,
		case @Moneda when 'P' then
			G.Importe
		when 'D' then 
			G.Importe/G.Tipo_Cambio 
		else 0 end as Importe
	from (select 1 as mes union select 2 union select 3 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9 union select 10 union select 11 union select 12) as M
	left join Gastos as G on  DATEPART(MONTH,G.Fecha_Gasto)=M.mes and DATEPART(YEAR,G.Fecha_Gasto)=@Anio
	left join Cuentas_Contables as GI on GI.Id_cuenta=G.Id_Cuenta
left join (select sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select uno, Importe as Importe_P,  Importe/Tipo_Cambio  as Importe_D,Fecha_Gasto from (select *,1 as uno from  transportes.dbo.Gastos) as X ) as T where datepart(YEAR,Fecha_Gasto)=@Anio  group by uno ) as Gas on 1=1
where datepart(Year,G.Fecha_Gasto)=@Anio
	and G.Id_Cuenta not in (select id from @table)
		) S
		pivot (
		sum(S.Importe)
		 for [Meses] in ([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December])

		) P
		
	
END
GO