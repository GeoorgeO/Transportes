USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_MotivoSalida_Insert')
DROP PROCEDURE SP_MotivoSalida_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_MotivoSalida_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_MotivoSalida char(3),
	@Nombre_MotivoSalida varchar(80)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(3)
		select @maximo=right(Concat('000', isnull(max(Id_MotivoSalida),0)+1),3) from dbo.MotivoSalida

		declare @Existe int
		select @Existe = count(Id_MotivoSalida) from dbo.MotivoSalida a where (a.Id_MotivoSalida=@Id_MotivoSalida)

		if @Existe>0 
		
			UPDATE dbo.MotivoSalida
		        SET Nombre_MotivoSalida=@Nombre_MotivoSalida
		    WHERE
		    	Id_MotivoSalida=@Id_MotivoSalida
				
		else
		
			INSERT INTO dbo.MotivoSalida
	           (Id_MotivoSalida
	           ,Nombre_MotivoSalida)
	     	VALUES
	           (@maximo
	           ,@Nombre_MotivoSalida)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
