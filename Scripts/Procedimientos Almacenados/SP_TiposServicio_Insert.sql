USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_TiposServicio_Insert')
DROP PROCEDURE SP_TiposServicio_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_TiposServicio_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_TipoServicio char(3),
	@Nombre_TipoServicio varchar(50),
	@Abreviatura varchar(20)
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
		select @maximo=right(Concat('000', isnull(max(Id_TipoServicio),0)+1),3) from dbo.TiposServicio

		declare @Existe int
		select @Existe = count(Id_TipoServicio) from dbo.TiposServicio a where (a.Id_TipoServicio=@Id_TipoServicio)

		if @Existe>0 
		
			UPDATE dbo.TiposServicio
		        SET Nombre_TipoServicio=@Nombre_TipoServicio,
				Abreviatura=@Abreviatura
		    WHERE
		    	Id_TipoServicio=@Id_TipoServicio
				
		else
		
			INSERT INTO dbo.TiposServicio
	           (Id_TipoServicio
	           ,Nombre_TipoServicio
			   ,Abreviatura)
	     	VALUES
	           (@maximo
	           ,@Nombre_TipoServicio
			   ,@Abreviatura)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
