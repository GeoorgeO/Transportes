USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Contacto_Emergencia_Insert')
DROP PROCEDURE SP_Contacto_Emergencia_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Contacto_Emergencia_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Contacto char(6),
	@Nombre_Contacto varchar(80),
	@Telefono varchar(15),
	@Id_Empleado char(6),
	@Calle varchar(100),
	@NoInterior varchar(10),
	@NoExterior varchar(10),
	@Colonia varchar(50),
	@Codigo_Postal char(5),
	@Id_Estado char(3),
	@Id_TipoDomicilio char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(6)
		select @maximo=right(Concat('000000', isnull(max(Id_Contacto),0)+1),6) from dbo.Contacto_Emergencia

		declare @Existe int
		select @Existe = count(Id_Contacto) from dbo.Contacto_Emergencia a where (a.Id_Contacto=@Id_Contacto)

		if @Existe>0 
		
			UPDATE dbo.Contacto_Emergencia
		        SET Nombre_Contacto=@Nombre_Contacto,
				Telefono=@Telefono,
				Id_Empleado=@Id_Empleado,
				Calle=@Calle,
				NoInterior=@NoInterior,
				NoExterior=@NoExterior,
				Colonia=@Colonia,
				Codigo_Postal=@Codigo_Postal,
				Id_Estado=@Id_Estado,
				Id_TipoDomicilio=@Id_TipoDomicilio
		    WHERE
		    	Id_Contacto=@Id_Contacto
				
		else
		
			INSERT INTO dbo.Contacto_Emergencia
	           (Id_Contacto
	           ,Nombre_Contacto
			   ,Telefono
			   ,Id_Empleado
			   ,Calle
			   ,NoInterior
			   ,NoExterior
			   ,Colonia
			   ,Codigo_Postal
			   ,Id_Estado
			   ,Id_TipoDomicilio)
	     	VALUES
	           (@maximo
	           ,@Nombre_Contacto
			   ,@Telefono
			   ,@Id_Empleado
			   ,@Calle
			   ,@NoInterior
			   ,@NoExterior
			   ,@Colonia
			   ,@Codigo_Postal
			   ,@Id_Estado
			   ,@Id_TipoDomicilio)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
