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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Rpt_GastosDirectosxMes_Select')
DROP PROCEDURE SP_Rpt_GastosDirectosxMes_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Rpt_GastosDirectosxMes_Select 
	-- Add the parameters for the stored procedure here
	@Moneda char(1),
	@Id_Empresa varchar(4),
	@Cuentas varchar(500),
	@Anio char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
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
	
    -- Insert statements for procedure here
	select * from (
	select a.Nombre_Interno,
		DATENAME (MONTH, DATEADD(MONTH, mes - 1, '1900-01-01')) as Meses,
		case @moneda when 'P' then sum(isnull(sd.Importe_P,0))+sum(isnull(trans.Importe_P,0))+sum(isnull(Caseta.Importe_P,0))+sum(isnull(PFP.Importe_P,0))+sum(isnull(tReten1.Importe_P,0))+sum(isnull(pens.Importe_P,0))+sum(isnull(lav.Importe_P,0))+sum(isnull(Ther.Importe_P,0))+sum(isnull(otro.Importe_P,0))+sum(isnull(sh.Importe_P,0)) 
		when 'D'  then sum(isnull(sd.Importe_D,0))+sum(isnull(trans.Importe_D,0))+sum(isnull(Caseta.Importe_D,0))+sum(isnull(PFP.Importe_D,0))+sum(isnull(tReten1.Importe_D,0))+sum(isnull(pens.Importe_D,0))+sum(isnull(lav.Importe_D,0))+sum(isnull(Ther.Importe_D,0))+sum(isnull(otro.Importe_D,0))+sum(isnull(sh.Importe_D,0))  else 0 end as Gasto_Total
	from (select 1 as mes union select 2 union select 3 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9 union select 10 union select 11 union select 12) as M
	left join Transportes.dbo.activos as A on M.mes!=-1
	left join transportes.dbo.Salidas as s on A.Id_Activo=s.Id_Activo_Principal and DATEPART(MONTH,S.Fecha_Salida)=M.mes and DATEPART(YEAR,S.Fecha_Salida)=@Anio
	left join transportes.dbo.Empleado as ope on ope.Id_Empleado=s.Id_Operador
	left join transportes.dbo.Rutas as r on r.Id_Rutas=s.Id_Ruta
	left join transportes.dbo.Clientes as c on c.Id_Cliente=s.Id_Cliente
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select Id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_Facturas  ) as T group by Id_Salida) as sf on sf.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select Id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Diesel) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Diesel) else Importe end as Importe_D from transportes.dbo.Salidas_Diesel  ) as T group by Id_Salida) as sd on sd.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0002'  ) as T group by Id_Salida) as trans on trans.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0001' ) as T group by Id_Salida) as Caseta on Caseta.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0003' ) as T group by Id_Salida) as PFP on PFP.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0004' or Id_GastoDirecto='0005' ) as T group by Id_Salida) as tReten1 on tReten1.Id_Salida=s.Id_Salida
	/*left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0005' ) as T group by Id_Salida) as tReten2 on tReten2.Id_Salida=s.Id_Salida*/
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0006' ) as T group by Id_Salida) as pens on pens.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0007' ) as T group by Id_Salida) as lav on lav.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0008' ) as T group by Id_Salida) as Ther on Ther.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0009') as T group by Id_Salida) as otro on otro.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select Id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Honorario) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Honorario) else Importe end as Importe_D from transportes.dbo.Salidas_Honorarios where Concepto!='GASTOS PAGADOS POR OPERADOR'  ) as T group by Id_Salida) as sh on sh.Id_Salida=s.Id_Salida
	--left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Honorario) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Honorario) else Importe end as Importe_D from transportes.dbo.Salidas_Honorarios where Concepto='GASTOS PAGADOS POR OPERADOR' ) as T group by Id_Salida) as sv on sv.Id_Salida=s.Id_Salida
	--left join (select sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select  Importe as Importe_P,  Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Gasto)  as Importe_D,Fecha_Gasto from transportes.dbo.Gastos where Id_Cuenta not in (select id from @table) ) as T where Fecha_Gasto between @F_Del and @F_Al  ) as Gas on 1=1
	left join Transportes.dbo.Empresa as E on E.Id_Empresa=A.Id_Empresa
	where datepart(year,s.Fecha_Salida)=@Anio
		and a.Id_Empresa like '%'+@Id_empresa+'%'
		and a.Activo_Primario=1 and Status='ACTIVO'
		
	group by  a.Nombre_Interno,M.mes
	) S
	pivot (
	sum(S.Gasto_Total)
		 for [Meses] in ([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December])
	) P
	
END
GO