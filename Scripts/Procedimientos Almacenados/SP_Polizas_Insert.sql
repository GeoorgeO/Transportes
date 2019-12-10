USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Polizas_Insert')
DROP PROCEDURE SP_Polizas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Polizas_Insert] 
	-- Add the parameters for the stored procedure here
	@Poliza_Seguro varchar(20),
	@Fecha_Inicio datetime,
	@Fecha_Fin datetime,
	@Id_Activo char(8),
	@Estatus bit
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
		select @Existe = count(Poliza_Seguro) from dbo.Polizas a where (a.Poliza_Seguro=@Poliza_Seguro)

		if @Existe>0 
		
			UPDATE dbo.Polizas
		        SET Fecha_Inicio=@Fecha_Inicio,
				Fecha_Fin=@Fecha_Fin,
				Id_Activo=@Id_Activo
		    WHERE
		    	Poliza_Seguro=@Poliza_Seguro
				
		else
		
			INSERT INTO dbo.Polizas
	           (Poliza_Seguro
	           ,Fecha_Inicio
			   ,Fecha_Fin
			   ,Id_Activo
			   ,Estatus)
	     	VALUES
	           (@Poliza_Seguro
	           ,@Fecha_Inicio
			   ,@Fecha_Fin
			   ,@Id_Activo
			   ,1)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
