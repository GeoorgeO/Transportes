USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Gastos_Insert')
DROP PROCEDURE SP_Gastos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Gastos_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Gasto char(9),
	@Fecha_Gasto datetime,
	@Id_GastoIndirecto char(4),
	@Importe numeric(18,2),
	@Tipo_Cambio numeric(5,2),
	@Factura varchar(30),
	@Concepto varchar(60),
	@Id_Cuenta varchar(16)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		
			INSERT INTO dbo.Gastos
	           (Id_Gasto
	           ,Fecha_Gasto
			   ,Id_GastoIndirecto
			   ,Importe
			   ,Tipo_Cambio
			   ,Factura
			   ,Concepto
			   ,Id_Cuenta)
	     	VALUES
	           (@Id_Gasto
	           ,@Fecha_Gasto
			   ,@Id_GastoIndirecto
			   ,@Importe
			   ,@Tipo_Cambio
			   ,@Factura
			   ,@Concepto
			   ,@Id_Cuenta)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
