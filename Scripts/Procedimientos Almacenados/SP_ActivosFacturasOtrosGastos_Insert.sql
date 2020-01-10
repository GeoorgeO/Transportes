USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_ActivosFacturasOtrosGastos_Insert')
DROP PROCEDURE SP_ActivosFacturasOtrosGastos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_ActivosFacturasOtrosGastos_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Activo char(8),
	@Id_Factura Int,
	@NombreArchivoPDF	varchar(100),	
	@ArchivoPDF	varbinary(MAX),
	@NombreArchivoXML	varchar(100),	
	@ArchivoXML	varbinary(MAX)	
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
		select @Existe = count(Id_Activo) from dbo.ActivosFacturasOtrosGastos  where (Id_Activo=@Id_Activo and Id_Factura=@Id_Factura)
		
		declare @maximo int
		select @maximo=max(Id_Factura)+1 from dbo.ActivosFacturasOtrosGastos where Id_Activo=@Id_Activo

		if len(@NombreArchivoPDF)=0 
			set @NombreArchivoPDF=NULL
		if len(@NombreArchivoPDF)=0 
			set @ArchivoPDF=NULL
		if len(@NombreArchivoXML)=0 
			set @NombreArchivoXML=NULL
		if len(@NombreArchivoXML)=0 
			set @ArchivoXML=NULL

		if @Existe>0 
		
			UPDATE dbo.ActivosFacturasOtrosGastos
		        SET NombreArchivoPDF=@NombreArchivoPDF,
				ArchivoPDF=@ArchivoPDF,
				NombreArchivoXML=@NombreArchivoXML,
				ArchivoXML=@ArchivoXML
		    WHERE
		    	Id_Activo=@Id_Activo and Id_Factura=@Id_Factura
				
		else
		
			INSERT INTO dbo.ActivosFacturasOtrosGastos
	           (Id_Activo
	           ,Id_Factura
			   ,NombreArchivoPDF
			   ,ArchivoPDF
			   ,NombreArchivoXML
			   ,ArchivoXML)
	     	VALUES
	           (@Id_Activo
	           ,@maximo
			   ,@NombreArchivoPDF
			   ,@ArchivoPDF
			   ,@NombreArchivoXML
			   ,@ArchivoXML)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END