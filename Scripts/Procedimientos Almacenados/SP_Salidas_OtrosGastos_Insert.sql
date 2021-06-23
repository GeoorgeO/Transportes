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
	@Ticket varchar(20),
	@Id_Salida char(10),
	@Id_GastoDirecto char(4),
	@Importe numeric(18, 2),
	@PagoOperador bit,
	@Otros_Gastos varchar(80),
	@Moneda char(1),
	@FacturaPDF varbinary(max),
	@FacturaPDFNombre varchar(80),
	@FacturaXML varbinary(max),
	@FacturaXMLNombre varchar(80),
	@Fecha_Factura varchar(15),
	@Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit
	
	declare @Existe int
	select @Existe = count(Id_Salida) from dbo.Salidas_OtrosGastos  where (Id_Salida=@Id_Salida and Ticket=@Ticket)

	if len(@FacturaPDFNombre)=0 
		set @FacturaPDFNombre=NULL
	if len(@FacturaPDFNombre)=0 
		set @FacturaPDF=NULL
	if len(@FacturaXMLNombre)=0 
		set @FacturaXMLNombre=NULL
	if len(@FacturaXMLNombre)=0 
		set @FacturaXML=NULL
		
	if len(@Fecha_Factura)=0 
			set @Fecha_Factura=NULL

	begin transaction T1;
	begin try
		
		if @Existe>0 
		
			UPDATE dbo.Salidas_OtrosGastos
		        SET Id_GastoDirecto=@Id_GastoDirecto,
				Importe=@Importe,
				PagoOperador=@PagoOperador,
				Otros_Gastos=@Otros_Gastos,
				Moneda=@Moneda,
				FacturaPDFNombre=@FacturaPDFNombre,
				FacturaPDF=@FacturaPDF,
				FacturaXMLNombre=@FacturaXMLNombre,
				FacturaXML=@FacturaXML,
				Fecha_Factura=@Fecha_Factura,
				Modificador=@Usuario,
				Fecha_Modificador=getdate()
		    WHERE
		    	Id_Salida=@Id_Salida and Ticket=@Ticket
				
		else
			INSERT INTO dbo.Salidas_OtrosGastos
	           (Ticket
	           ,Id_Salida
			   ,Id_GastoDirecto
			   ,Importe
			   ,PagoOperador
			   ,Otros_Gastos,
				Moneda,
				FacturaPDF,
				FacturaPDFNombre,
				FacturaXML,
				FacturaXMLNombre,
				Fecha_Factura,
				Creador,
				Fecha_Creador)
	     	VALUES
	           (@Ticket
	           ,@Id_Salida
			   ,@Id_GastoDirecto
			   ,@Importe
			   ,@PagoOperador
			   ,@Otros_Gastos,
				@Moneda,
				@FacturaPDF,
				@FacturaPDFNombre,
				@FacturaXML,
				@FacturaXMLNombre,
				@Fecha_Factura,
				@Usuario,
				getdate())
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
