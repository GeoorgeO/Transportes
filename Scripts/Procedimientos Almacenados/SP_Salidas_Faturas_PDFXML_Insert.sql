USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Faturas_PDFXML_Insert')
DROP PROCEDURE SP_Salidas_Faturas_PDFXML_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Faturas_PDFXML_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@FacturaPDF varbinary(max),
	@FacturaPDFNombre varchar(80),
	@FacturaXML varbinary(max),
	@FacturaXMLNombre varchar(80),
	@Importe numeric(18, 2),
	@Id_Archivo numeric(10,0),
	@Moneda char(1),
	@Diferido bit,
	@Fecha_Factura varchar(15),
	@Fecha_Cobro varchar(15),
	@Fecha_Pago varchar(15),
	@Importe_Viaje numeric(18, 2),
	@Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
	
	declare @maximo numeric(10,0)
		select @maximo= isnull(max(Id_Archivo),0)+1 from dbo.Salidas_Facturas where Id_Salida=@Id_Salida

		declare @Existe int
		select @Existe = count(Id_Archivo) from dbo.Salidas_Facturas  where (Id_Salida=@Id_Salida and Id_Archivo=@Id_Archivo)
		
		if len(@Fecha_Factura)=0 
			set @Fecha_Factura=NULL
		if len(@Fecha_Cobro)=0 
			set @Fecha_Cobro=NULL
		if len(@Fecha_Pago)=0 
			set @Fecha_Pago=NULL

		if @Existe>0 
		
			update Salidas_Facturas
			set FacturaPDF=@FacturaPDF,
				FacturaPDFNombre=@FacturaPDFNombre,
				FacturaXML=@FacturaXML,
				FacturaXMLNombre=@FacturaXMLNombre,
				Importe=@Importe,
				Moneda=@Moneda,
				Diferido=@Diferido,
				Fecha_Factura=@Fecha_Factura,
				Fecha_Cobro=@Fecha_Cobro,
				Fecha_Pago=@Fecha_Pago,
				Importe_Viaje=@Importe_Viaje,
				Modificador=@Usuario,
				Fecha_Modificador=getdate()
			where Id_Salida=@Id_Salida and Id_Archivo=@Id_Archivo
			
		else
		
			INSERT INTO dbo.Salidas_Facturas
	           (Id_Salida
	           ,FacturaPDF
			   ,FacturaPDFNombre
			   ,FacturaXML
			   ,FacturaXMLNombre
			   ,Importe
			   ,Id_Archivo
			   ,Moneda
			   ,Diferido
			   ,Fecha_Factura
			   ,Fecha_Cobro
			   ,Fecha_Pago
			   ,Importe_Viaje
			   ,Creador
			   ,Fecha_Creador)
	     	VALUES
	           (@Id_Salida
	           ,@FacturaPDF
			   ,@FacturaPDFNombre
			   ,@FacturaXML
			   ,@FacturaXMLNombre
			   ,@Importe
			   ,@maximo
			   ,@Moneda
			   ,@Diferido
			   ,@Fecha_Factura
			   ,@Fecha_Cobro
			   ,@Fecha_Pago
			   ,@Importe_Viaje
			   ,@Usuario
			   ,getdate())
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
