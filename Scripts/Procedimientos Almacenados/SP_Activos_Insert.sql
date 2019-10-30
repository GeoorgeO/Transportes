USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Activos_Insert')
DROP PROCEDURE SP_Activos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Activos_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Activo char(8),
	@Nombre_Interno varchar(150),
	@Costo_Unidad numeric(18,2),
	@Fecha_Alta datetime,
	@Fecha_Baja datetime,
	@Serie varchar(20),
	@Tarjeta_Circulacion varchar(15),
	@Placas varchar(10),
	@Id_Tipo_Placa char(4),
	@Id_Tipo_Activo char(4),
	@Color varchar(15),
	@Modelo varchar(20),
	@Id_Marca char(4),
	@Descripcion varchar(250),
	@Id_Tipo_Transporte char(4),
	@Poliza_Seguro varchar(20),
	@Id_Empresa_Aseguradora char(4),
	@Status char(8),
	@Asignado bit,
	@Id_Empleado char(6),
	@Id_Empresa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		if @Fecha_Baja='1900-01-01 00:00:00.000'
			select @Fecha_Baja=null
		else
			select getdate()

		declare @maximo char(8)
		select @maximo=right(Concat('00000000', isnull(max(Id_Activo),0)+1),8) from dbo.Activos

		declare @Existe int
		select @Existe = count(Id_Activo) from dbo.Activos a where (a.Id_Activo=@Id_Activo)

		if @Existe>0 
		
			UPDATE dbo.Activos
		        SET Nombre_Interno=@Nombre_Interno,
				Costo_Unidad=@Costo_Unidad,
				Fecha_Alta=@Fecha_Alta,
				Fecha_Baja=@Fecha_Baja,
				Serie=@Serie,
				Tarjeta_Circulacion=@Tarjeta_Circulacion,
				Placas=@Placas,
				Id_Tipo_Placa=@Id_Tipo_Placa,
				Id_Tipo_Activo=@Id_Tipo_Activo,
				Color=@Color,
				Modelo=@Modelo,
				Id_Marca=@Id_Marca,
				Descripcion=@Descripcion,
				Id_Tipo_Transporte=@Id_Tipo_Transporte,
				Poliza_Seguro=@Poliza_Seguro,
				Id_Empresa_Aseguradora=@Id_Empresa_Aseguradora,
				Status=@Status,
				Asignado=@Asignado,
				Id_Empleado=@Id_Empleado,
				Id_Empresa=@Id_Empresa
		    WHERE
		    	Id_Activo=@Id_Activo
				
		else
		
			INSERT INTO dbo.Activos
	           (Id_Activo
	           ,Nombre_Interno
			   ,Costo_Unidad
			   ,Fecha_Alta
			   ,Fecha_Baja
			   ,Serie
			   ,Tarjeta_Circulacion
			   ,Placas
			   ,Id_Tipo_Placa
			   ,Id_Tipo_Activo
			   ,Color
			   ,Modelo
			   ,Id_Marca
			   ,Descripcion
			   ,Id_Tipo_Transporte
			   ,Poliza_Seguro
			   ,Id_Empresa_Aseguradora
			   ,Status
			   ,Asignado
			   ,Id_Empleado
			   ,Id_Empresa)
	     	VALUES
	           (@maximo
	           ,@Nombre_Interno
			   ,@Costo_Unidad
			   ,@Fecha_Alta
			   ,@Fecha_Baja
			   ,@Serie
			   ,@Tarjeta_Circulacion
			   ,@Placas
			   ,@Id_Tipo_Placa
			   ,@Id_Tipo_Activo
			   ,@Color
			   ,@Modelo
			   ,@Id_Marca
			   ,@Descripcion
			   ,@Id_Tipo_Transporte
			   ,@Poliza_Seguro
			   ,@Id_Empresa_Aseguradora
			   ,@Status
			   ,@Asignado
			   ,@Id_Empleado
			   ,@Id_Empresa)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
