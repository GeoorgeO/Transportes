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
	@Fecha_Gasto datetime,
	@Importe numeric(18,2),
	@Tipo_Cambio numeric(5,2),
	@Factura varchar(30),
	@Concepto varchar(60),
	@Id_Cuenta varchar(16),
	@Referencia varchar(50),
	@Poliza int,
	@Moneda varchar(10),
	@TipoPoliza varchar(10)
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
		select @Existe = count(Poliza) from dbo.Gastos a where (a.Poliza=@Poliza and a.Id_Cuenta=@Id_Cuenta)

		if @Existe>0 
			update dbo.Gastos set
				Tipo_Cambio=@Tipo_Cambio,
				Factura= @Factura,
				Referencia=@Referencia,
				Poliza=@Poliza,
				Moneda=@Moneda,
				TipoPoliza=@TipoPoliza
			where Poliza=@Poliza and Id_Cuenta=@Id_Cuenta
		else
			INSERT INTO dbo.Gastos
	           (Fecha_Gasto
			   ,Importe
			   ,Tipo_Cambio
			   ,Factura
			   ,Concepto
			   ,Id_Cuenta
			   ,Referencia
			   ,Poliza
			   ,Moneda
			   ,TipoPoliza)
	     	VALUES
	           (@Fecha_Gasto
			   ,@Importe
			   ,@Tipo_Cambio
			   ,@Factura
			   ,@Concepto
			   ,@Id_Cuenta
			   ,@Referencia
			   ,@Poliza
			   ,@Moneda
			   ,@TipoPoliza)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
