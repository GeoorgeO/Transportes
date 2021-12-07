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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Huerta_New_Select')
DROP PROCEDURE SP_Huerta_New_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Huerta_New_Select
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Hue.c_codigo_hue as Id_Huerta, 
			Hue.v_nombre_hue as Nombre_Huerta, 
			Hue.v_registro_hue as Registro_Huerta, 
			Hue.c_codigo_dno as Id_Duenio, 
			Due.v_nombre_dno as Nombre_Duenio, 
			Hue.c_codigo_est as Id_Estado, 
			Est.v_nombre_est as Nombre_Estado, 
			'' as  Id_Ciudad, 
			Hue.v_ciudad_est as Nombre_Ciudad, 
			Hue.c_calidad_hue as Id_Calidad, 
		    Cal.v_nombre_cld as Nombre_Calidad, 
			'' as Id_Cultivo, 
			'' as Nombre_Cultivo, 
			Hue.n_utm_zona_hue as zona_Huerta, 
			Hue.c_utm_banda_hue as banda_Huerta, 
			Hue.n_utm_este_hue as este_Huerta, 
			Hue.n_utm_norte_hue as norte_Huerta, 
			Hue.n_geo_asnm_hue as asnm_Huerta, 
			Hue.v_geo_lat_hue as latitud_Huerta, 
			Hue.v_geo_lon_hue as longitud_Huerta, 
		    Hue.c_activo_hue as Activa_Huerta 
		from GrupoExportador.dbo.t_huerto as Hue
		left join GrupoExportador.dbo.NomEstado as Est on Est.c_codigo_est=Hue.c_codigo_est
		left join GrupoExportador.dbo.t_duenio as Due on Due.c_codigo_dno=Hue.c_codigo_dno
		left join GrupoExportador.dbo.t_calidad as Cal on Cal.c_codigo_cld=Hue.c_calidad_hue
		where Hue.c_activo_hue='1'

END
GO
