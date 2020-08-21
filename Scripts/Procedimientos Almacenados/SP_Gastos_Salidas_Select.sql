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
	@Id_Activo char(8)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select s.Id_Salida,
		s.Fecha_Salida,
		a.Nombre_Interno,
		ope.Nombre_Empleado as Operador,
		r.Origen,r.Destino,
		c.Nombre_Cliente,
		sf.Importe_P as Monto_Factura_P,
		sf.Importe_D as Monto_Factura_D,
		sd.Importe as Diesel_P,
		sd.Litros,
		trans.Importe_P as Transfe_P,
		trans.Importe_D as Transfe_D,
		Caseta.Importe_P as Caseta_P,
		Caseta.Importe_D as Caseta_D,
		PFP.Importe_P as PFP_P,
		PFP.Importe_D as PFP_D,
		tReten1.Importe_P as tReten1_P,
		tReten1.Importe_D as tReten1_D,
		tReten2.Importe_P as tReten2_P,
		tReten2.Importe_D as tReten2_D,
		pens.Importe_P as Pension_P,
		pens.Importe_D as Pension_D,
		lav.Importe_P as Lavada_P,
		lav.Importe_D as Lavada_D,
		Ther.Importe_P as Thermo_P,
		Ther.Importe_D as Thermo_D,
		otro.Importe_P as Otros_P,
		otro.Importe_D as Otros_D,
		sv.Importe as Viaticos,
		sh.Importe as Comision_Chofer,
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
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0004' ) as T group by Id_Salida) as tReten1 on tReten1.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0005' ) as T group by Id_Salida) as tReten2 on tReten2.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0006' ) as T group by Id_Salida) as pens on pens.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0007' ) as T group by Id_Salida) as lav on lav.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0008' ) as T group by Id_Salida) as Ther on Ther.Id_Salida=s.Id_Salida
	left join (select Id_Salida, sum(Importe_P) as Importe_P,sum(Importe_D) as Importe_D from(select id_Salida,case Moneda when 'D' then Importe*(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_P,case Moneda when 'P' then Importe/(select TC.Tipo_Cambio from Transportes.dbo.Tipo_Cambio as TC where TC.Fecha=Fecha_Factura) else Importe end as Importe_D from transportes.dbo.Salidas_OtrosGastos where Id_GastoDirecto='0009' ) as T group by Id_Salida) as otro on otro.Id_Salida=s.Id_Salida
	left join (select id_Salida,sum(Importe) as Importe from transportes.dbo.Salidas_Viaticos group by id_Salida) as sv on sv.Id_Salida=s.Id_Salida
	left join (select id_Salida,sum(Importe) as Importe from transportes.dbo.Salidas_Honorarios group by id_Salida) as sh on sh.Id_Salida=s.Id_Salida
	where ('F'=@Parametro and Fecha_Salida between @F_Del and @F_Al, ) 
		or ('A'=@Parametro and Id_Activo_Principal=@Id_Activo) 
		or ('2'=@Parametro and (Fecha_Salida between @F_Del and @F_Al, and Id_Activo_Principal=@Id_Activo))
	
END
GO
