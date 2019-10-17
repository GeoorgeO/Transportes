USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_INSUPD_Tipo_Activo')
DROP PROCEDURE SP_INSUPD_Tipo_Activo
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_INSUPD_Tipo_Activo] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Activo char(4),
	@Nombre_Tipo_Activo varchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right('0000'+ isnull(max(Id_Tipo_Activo),0)+1,4) from dbo.Tipo_Activo

		declare @Existe int
		select @Existe = count(Id_Tipo_Activo) from dbo.Tipo_Activo a where (a.Id_Tipo_Activo=@Id_Tipo_Activo)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Activo
		        SET Nombre_Tipo_Activo=@Nombre_Tipo_Activo
		    WHERE
		    	Id_Tipo_Activo=@Id_Tipo_Activo
				
		else
		
			INSERT INTO dbo.Tipo_Activo
	           (Id_Tipo_Activo
	           ,Nombre_Tipo_Activo)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Activo)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
