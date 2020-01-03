USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Activos_IAVES_Insert')
DROP PROCEDURE SP_Activos_IAVES_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Activos_IAVES_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Activo char(8),
	@IAVE varchar(50)
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
		select @Existe = count(IAVE) from dbo.Activos_IAVES  where (Id_Activo=@Id_Activo and IAVE=@IAVE)

		if @Existe>0 
		
			UPDATE dbo.Activos_IAVES
		        SET IAVE=@IAVE
		    WHERE
		    	Id_Activo=@Id_Activo and IAVE=@IAVE
				
		else
		
			INSERT INTO dbo.Activos_IAVES
	           (Id_Activo
	           ,IAVE)
	     	VALUES
	           (@Id_Activo
	           ,@IAVE)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END