USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_OtrosGastos_Insert')
DROP PROCEDURE SP_Salidas_OtrosGastos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_OtrosGastos_Insert] 
	-- Add the parameters for the stored procedure here
	@Ticket varchar(15),
	@Id_Salida char(10),
	@Id_GastoDirecto char(4),
	@Importe numeric(18, 2),
	@PagoOperador bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
		
			INSERT INTO dbo.Salidas_OtrosGastos
	           (Ticket
	           ,Id_Salida
			   ,Id_GastoDirecto
			   ,Importe
			   ,PagoOperador)
	     	VALUES
	           (@Ticket
	           ,@Id_Salida
			   ,@Id_GastoDirecto
			   ,@Importe
			   ,@PagoOperador)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
