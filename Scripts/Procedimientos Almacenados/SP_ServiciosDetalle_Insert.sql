USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_ServiciosDetalle_Insert')
DROP PROCEDURE SP_ServiciosDetalle_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_ServiciosDetalle_Insert] 
	-- Add the parameters for the stored procedure here
	@Folio char(10),
	@Nombre_ServicioDetalle varchar(80),
	@Secuencia numeric(10,0),
	@Costo numeric(18,2),
	@Piezas numeric(18,2),
	@Total numeric(18,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
	
		
			INSERT INTO dbo.ServiciosDetalle
	           (Folio
			   ,Nombre_ServicioDetalle
	           ,Secuencia
			   ,Costo
			   ,Piezas
			   ,Total)
	     	VALUES
	           (@Folio
			   ,@Nombre_ServicioDetalle
	           ,@Secuencia
			   ,@Costo
			   ,@Piezas
			   ,@Total)
			   
		
		set @correcto=1	
		commit transaction T1;
		
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
