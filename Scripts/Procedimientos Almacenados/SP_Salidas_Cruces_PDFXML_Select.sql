USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Cruces_PDFXML_Select')
DROP PROCEDURE SP_Salidas_Cruces_PDFXML_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Cruces_PDFXML_Select] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
		
			Select Id_Salida
	           ,FacturaPDF
			   ,FacturaPDFNombre
			   ,FacturaXML
			   ,FacturaXMLNombre
			   ,Importe
			   ,Moneda
			   ,Fecha_Cruce
			   ,Id_Archivo
			   ,Diferido
			from dbo.Salidas_Cruces
			where Id_Salida=@Id_Salida
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
