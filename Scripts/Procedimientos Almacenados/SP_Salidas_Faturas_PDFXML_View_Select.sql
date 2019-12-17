USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Faturas_PDFXML_View_Select')
DROP PROCEDURE SP_Salidas_Faturas_PDFXML_View_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Faturas_PDFXML_View_Select] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@Id_Archivo numeric(10,0)
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
			   ,Id_Archivo
			from dbo.Salidas_Facturas 
			where Id_Salida=@Id_Salida
			and Id_Archivo=@Id_Archivo
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
