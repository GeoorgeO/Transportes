USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_RevisionUnidad_Insert')
DROP PROCEDURE SP_Salidas_RevisionUnidad_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_RevisionUnidad_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@AceiteMotor bit,
	@LiqDireccionHidraulica bit ,
	@Anticongelante bit,
	@TCirculacion bit,
	@TCombustible bit,
	@TLicencia bit,
	@LimpiezaInterior bit,
	@PresionLlantas bit,
	@Luces bit,
	@CajaCampo bit,
	@Combustible numeric(18,0)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		
		declare @Existe int
		select @Existe = count(Id_Salida) from dbo.Salidas_RevisionUnidad a where (a.Id_Salida=@Id_Salida)

		if @Existe>0 
		
			UPDATE dbo.Salidas_RevisionUnidad
		        SET AceiteMotor=@AceiteMotor,
					LiqDireccionHidraulica=@LiqDireccionHidraulica,
					Anticongelante=@Anticongelante,
					TCirculacion=@TCirculacion,
					TCombustible=@TCombustible,
					TLicencia=@TLicencia,
					LimpiezaInterior=@LimpiezaInterior,
					PresionLlantas=@PresionLlantas,
					Luces=@Luces,
					CajaCampo=@CajaCampo,
					Combustible=@Combustible
					
		    WHERE
		    	Id_Salida=@Id_Salida
				
		else
		
			INSERT INTO dbo.Salidas_RevisionUnidad
	           (Id_Salida
	           ,AceiteMotor
			   ,LiqDireccionHidraulica
			   ,Anticongelante
			   ,TCirculacion
			   ,TCombustible
			   ,TLicencia
			   ,LimpiezaInterior
			   ,PresionLlantas
			   ,Luces
			   ,CajaCampo
			   ,Combustible)
	     	VALUES
	           (@Id_Salida
	           ,@AceiteMotor
			   ,@LiqDireccionHidraulica
			   ,@Anticongelante
			   ,@TCirculacion
			   ,@TCombustible
			   ,@TLicencia
			   ,@LimpiezaInterior
			   ,@PresionLlantas
			   ,@Luces
			   ,@CajaCampo
			   ,@Combustible)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
