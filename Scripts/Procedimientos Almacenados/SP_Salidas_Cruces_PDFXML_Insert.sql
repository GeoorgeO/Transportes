USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Cruces_PDFXML_Insert')
DROP PROCEDURE SP_Salidas_Cruces_PDFXML_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Cruces_PDFXML_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@FacturaPDF varbinary(max),
	@FacturaPDFNombre varchar(80),
	@FacturaXML varbinary(max),
	@FacturaXMLNombre varchar(80),
	@Importe numeric(18, 2),
	@Moneda char(1),
	@Fecha_Cruce datetime,
	@Id_Archivo numeric(10,0),
	@Diferido bit
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
		select @maximo= isnull(max(Id_Archivo),0)+1 from dbo.Salidas_Cruces where Id_Salida=@Id_Salida

		declare @Existe int
		select @Existe = count(Id_Archivo) from dbo.Salidas_Cruces  where (Id_Salida=@Id_Salida and Id_Archivo=@Id_Archivo)

		if @Existe>0 
		
			update Salidas_Cruces
			set FacturaPDF=@FacturaPDF,
				FacturaPDFNombre=@FacturaPDFNombre,
				FacturaXML=@FacturaXML,
				FacturaXMLNombre=@FacturaXMLNombre,
				Importe=@Importe,
				Moneda=@Moneda,
				Fecha_Cruce=@Fecha_Cruce,
				Diferido=@Diferido
			where Id_Salida=@Id_Salida and Id_Archivo=@Id_Archivo
			
		else
		
			INSERT INTO dbo.Salidas_Cruces
	           (Id_Salida
	           ,FacturaPDF
			   ,FacturaPDFNombre
			   ,FacturaXML
			   ,FacturaXMLNombre
			   ,Importe
			   ,Fecha_Cruce
			   ,Moneda
			   ,Id_Archivo
			   ,Diferido)
	     	VALUES
	           (@Id_Salida
	           ,@FacturaPDF
			   ,@FacturaPDFNombre
			   ,@FacturaXML
			   ,@FacturaXMLNombre
			   ,@Importe
			   ,@Fecha_Cruce
			   ,@Moneda
			   ,@maximo
			   ,@Diferido)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
