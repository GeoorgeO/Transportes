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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Select')
DROP PROCEDURE SP_Salidas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Salidas_Select
	-- Add the parameters for the stored procedure here
	@filtro numeric(5,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		if @filtro=0

		select Id_Salida,
			Fecha_Salida,
			S.Id_Activo_Principal,
			Nombre_Activo_Principal=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Principal),''),
			S.Id_Operador,
			Nombre_Operador=isnull((select Nombre_empleado from Empleado where Id_empleado=S.Id_Operador),''),
			S.Id_Ayudante,
			Nombre_Ayudante=isnull((select Nombre_empleado from Empleado where Id_empleado=S.Id_Ayudante),''),
			S.Id_Activo_Secundario,
			Nombre_Activo_Secundario=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Secundario),''), 
			S.Id_Activo_Adicional,
			Nombre_Activo_Adicional=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Adicional), ''),
			S.Id_Ruta,
			R.Nombre_Ruta,
			R.Origen,
			R.Destino,
			S.Id_MotivoSalida,
			isnull(M.Nombre_MotivoSalida,'') as Nombre_MotivoSalida,
			S.Id_Cliente,
			isnull(C.Nombre_Cliente,'') as Nombre_Cliente,
			isnull(km_Inicio,0) as km_Inicio,
			isnull(km_Fin,0) as km_Fin,
			isnull(Dias_Viaje,0) as Dias_Viaje,
			isnull(Lts_Km,0) as Lts_Km,
			S.Id_Huerta,
			case  when S.Fecha_Salida>'20210923' then (select v_nombre_hue from GrupoExportador.dbo.t_huerto as hue where hue.c_codigo_hue=S.Id_Huerta) else isnull(H.Nombre_Huerta,'') end as Nombre_Huerta,
			Observaciones,
			isnull(EsNacional,0) as EsNacional,
			isnull(Id_ClienteAd,'') as Id_ClienteAd,
			Nombre_ClienteAd=(select TC.Nombre_Cliente from Clientes as TC where TC.Id_Cliente=S.Id_ClienteAd)
		from Salidas as S
		left join Rutas as R on R.Id_Rutas=S.Id_Ruta
		left join MotivoSalida as M on M.Id_MotivoSalida=S.Id_MotivoSalida
		left join Clientes as C on C.Id_Cliente=S.Id_Cliente
		left join Huerta as H on H.Id_Huerta=S.Id_Huerta
	if @filtro=1 
		select Id_Salida,
			Fecha_Salida,
			S.Id_Activo_Principal,
			Nombre_Activo_Principal=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Principal),''),
			S.Id_Operador,
			Nombre_Operador=isnull((select Nombre_empleado from Empleado where Id_empleado=S.Id_Operador),''),
			S.Id_Ayudante,
			Nombre_Ayudante=isnull((select Nombre_empleado from Empleado where Id_empleado=S.Id_Ayudante),''),
			S.Id_Activo_Secundario,
			Nombre_Activo_Secundario=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Secundario),''), 
			S.Id_Activo_Adicional,
			Nombre_Activo_Adicional=isnull((select Nombre_interno from Activos where Id_Activo=S.Id_Activo_Adicional), ''),
			S.Id_Ruta,
			R.Nombre_Ruta,
			R.Origen,
			R.Destino,
			S.Id_MotivoSalida,
			isnull(M.Nombre_MotivoSalida,'') as Nombre_MotivoSalida,
			S.Id_Cliente,
			isnull(C.Nombre_Cliente,'') as Nombre_Cliente,
			isnull(km_Inicio,0) as km_Inicio,
			isnull(km_Fin,0) as km_Fin,
			isnull(Dias_Viaje,0) as Dias_Viaje,
			isnull(Lts_Km,0) as Lts_Km,
			S.Id_Huerta,
			case  when S.Fecha_Salida>'20210923' then (select v_nombre_hue from GrupoExportador.dbo.t_huerto as hue where hue.c_codigo_hue=S.Id_Huerta) else isnull(H.Nombre_Huerta,'') end as Nombre_Huerta,
			Observaciones,
			isnull(EsNacional,0) as EsNacional,
			isnull(Id_ClienteAd,'') as Id_ClienteAd,
			Nombre_ClienteAd=(select TC.Nombre_Cliente from Clientes as TC where TC.Id_Cliente=S.Id_ClienteAd)
		from Salidas as S
		left join Rutas as R on R.Id_Rutas=S.Id_Ruta
		left join MotivoSalida as M on M.Id_MotivoSalida=S.Id_MotivoSalida
		left join Clientes as C on C.Id_Cliente=S.Id_Cliente
		left join Huerta as H on H.Id_Huerta=S.Id_Huerta
		where Id_Salida not in (select Id_salida from Entradas)
		
END
GO