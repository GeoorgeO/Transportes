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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Gastos_Salidas_Select')
DROP PROCEDURE SP_Gastos_Salidas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Gastos_Salidas_Select 
	-- Add the parameters for the stored procedure here
	@Parametro char(1),
	@F_Del datetime,
	@F_Al datetime,
	@Id_Activo varchar(500),
	@Id_Empresa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @table TABLE ( id VARCHAR(50))
	DECLARE @x INT = 0
	DECLARE @firstcomma INT = 0
	DECLARE @nextcomma INT = 0

	SET @x = LEN(@Id_Activo) - LEN(REPLACE(@Id_Activo, ',', '')) + 1 

	WHILE @x > 0
		BEGIN
			SET @nextcomma = CASE WHEN CHARINDEX(',', @Id_Activo, @firstcomma + 1) = 0
								  THEN LEN(@Id_Activo) + 1
								  ELSE CHARINDEX(',', @Id_Activo, @firstcomma + 1)
							 END
			INSERT  INTO @table
			VALUES  ( SUBSTRING(@Id_Activo, @firstcomma + 1, (@nextcomma - @firstcomma) - 1) )
			SET @firstcomma = CHARINDEX(',', @Id_Activo, @firstcomma + 1)
			SET @x = @x - 1
		END

    -- Insert statements for procedure here
	select s.Id_Salida,
		s.Fecha_Salida,
		a.Nombre_Interno,
		ope.Nombre_Empleado as Operador,
		r.Origen,r.Destino,
		c.Nombre_Cliente,
		isnull(sf.Importe_P,0) as Monto_Factura_P,
		isnull(sf.Importe_D,0) as Monto_Factura_D,
		isnull(sd.Importe,0) as Diesel_P,
		sd.Litros,
		isnull(trans.Importe_P,0) as Transfe_P,
		isnull(trans.Importe_D,0) as Transfe_D,
		isnull(Caseta.Importe_P,0) as Caseta_P,
		isnull(Caseta.Importe_D,0) as Caseta_D,
		isnull(PFP.Importe_P,0) as PFP_P,
		isnull(PFP.Importe_D,0) as PFP_D,
		isnull(tReten1.Importe_P,0) as tReten1_P,
		isnull(tReten1.Importe_D,0) as tReten1_D,
		/*tReten2.Importe_P as tReten2_P,
		tReten2.Importe_D as tReten2_D,*/
		isnull(pens.Importe_P,0) as Pension_P,
		isnull(pens.Importe_D,0) as Pension_D,
		isnull(lav.Importe_P,0) as Lavada_P,
		isnull(lav.Importe_D,0) as Lavada_D,
		isnull(Ther.Importe_P,0) as Thermo_P,
		isnull(Ther.Importe_D,0) as Thermo_D,
		isnull(otro.Importe_P,0) as Otros_P,
		isnull(otro.Importe_D,0) as Otros_D,
		isnull(sv.Importe,0) as Viaticos,
		isnull(sh.Importe,0) as Comision_Chofer,
		isnull(sd.Importe,0)+isnull(trans.Importe_P,0)+isnull(Caseta.Importe_P,0)+isnull(PFP.Importe_P,0)+isnull(tReten1.Importe_P,0)+isnull(pens.Importe_P,0)+isnull(lav.Importe_P,0)+isnull(Ther.Importe_P,0)+isnull(otro.Importe_P,0)+isnull(sv.Importe,0)+isnull(sh.Importe,0) as Gasto_Total, 
		isnull(sf.Importe_P,0)- (isnull(sd.Importe,0)+isnull(trans.Importe_P,0)+isnull(Caseta.Importe_P,0)+isnull(PFP.Importe_P,0)+isnull(tReten1.Importe_P,0)+isnull(pens.Importe_P,0)+isnull(lav.Importe_P,0)+isnull(Ther.Importe_P,0)+isnull(otro.Importe_P,0)+isnull(sv.Importe,0)+isnull(sh.Importe,0)) as Ganancias_Total,
		s.Observaciones from transportes.dbo.Salidas as s
	left join transportes.dbo.Activos as a on a.Id_Activo=s.Id_Activo_Principal
	left join transportes.dbo.Empleado as ope on ope.Id_Empleado=s.Id_Operador
	left join transportes.dbo.Rutas as r on r.Id_Rutas=s.Id_Ruta
	left join transportes.dbo.Clientes as c on c.Id_Cliente=s.Id_Cliente
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from (select Id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_Facturas  ) as T group by Id_Salida) as sf on sf.Id_Salida=s.Id_Salida
	left join (select Id_Salida,sum(Importe) as Importe,sum(Litros) as Litros from transportes.dbo.Salidas_Diesel group by id_Salida) as sd on sd.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0002' ) as T group by Id_Salida) as trans on trans.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0001' ) as T group by Id_Salida) as Caseta on Caseta.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0003' ) as T group by Id_Salida) as PFP on PFP.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0004' or Id_GastoDirecto='0005' ) as T group by Id_Salida) as tReten1 on tReten1.Id_Salida=s.Id_Salida
	/*left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0005' ) as T group by Id_Salida) as tReten2 on tReten2.Id_Salida=s.Id_Salida*/
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0006' ) as T group by Id_Salida) as pens on pens.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0007' ) as T group by Id_Salida) as lav on lav.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0008' ) as T group by Id_Salida) as Ther on Ther.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0009' ) as T group by Id_Salida) as otro on otro.Id_Salida=s.Id_Salida
	left join (select id_Salida,sum(Importe) as Importe from transportes.dbo.Salidas_Viaticos group by id_Salida) as sv on sv.Id_Salida=s.Id_Salida
	left join (select id_Salida,sum(Importe) as Importe from transportes.dbo.Salidas_Honorarios group by id_Salida) as sh on sh.Id_Salida=s.Id_Salida
	where (('F'=@Parametro and Fecha_Salida between @F_Del and @F_Al ) 
		or ('A'=@Parametro and Id_Activo_Principal=@Id_Activo) 
		or ('2'=@Parametro and (Fecha_Salida between @F_Del and @F_Al and Id_Activo_Principal in (select * from @table))))
		and a.Id_Empresa like '%'+@Id_empresa+'%'
	
END
GO