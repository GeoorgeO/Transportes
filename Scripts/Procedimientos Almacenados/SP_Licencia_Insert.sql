USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Licencia_Insert')
DROP PROCEDURE SP_Licencia_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Licencia_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Licencia char(6),
	@Id_Tipo_Licencia char(3),
	@Vigencia datetime,
	@No_Licencia varchar(20)
	
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
		select @maximo=right(Concat('0000', isnull(max(Id_Licencia),0)+1),4) from dbo.Licencia

		declare @Existe int
		select @Existe = count(Id_Licencia) from dbo.Licencia a where (a.Id_Licencia=@Id_Licencia)

		if @Existe>0 
		
			UPDATE dbo.Licencia
		        SET Id_Tipo_Licencia=@Id_Tipo_Licencia,
					Vigencia=@Vigencia,
					No_Licencia=@No_Licencia
		    WHERE
		    	Id_Licencia=@Id_Licencia
				
		else
		
			INSERT INTO dbo.Licencia
	           (Id_Licencia
	           ,Id_Tipo_Licencia
			   ,Vigencia
			   ,No_Licencia)
	     	VALUES
	           (@maximo
	           ,@Id_Tipo_Licencia
			   ,@Vigencia
			   ,@No_Licencia)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
