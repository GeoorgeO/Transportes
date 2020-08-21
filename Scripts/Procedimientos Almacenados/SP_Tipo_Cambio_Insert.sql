USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Cambio_Insert')
DROP PROCEDURE SP_Tipo_Cambio_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Cambio_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha datetime,
	@Tipo_Cambio numeric(12,4)
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
		select @Existe = count(Fecha) from dbo.Tipo_Cambio a where (a.Fecha=@Fecha)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Cambio
		        SET Tipo_Cambio=@Tipo_Cambio
		    WHERE
		    	Fecha=@Fecha
				
		else
		
			INSERT INTO dbo.Tipo_Cambio
	           (Fecha
	           ,Tipo_Cambio)
	     	VALUES
	           (@Fecha
	           ,@Tipo_Cambio)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
