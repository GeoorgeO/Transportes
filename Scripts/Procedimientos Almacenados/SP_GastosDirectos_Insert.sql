USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_GastosDirectos_Insert')
DROP PROCEDURE SP_GastosDirectos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_GastosDirectos_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_GastoDirecto char(4),
	@Nombre_GastoDirecto varchar(40)
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
		select @maximo=right(Concat('0000', isnull(max(Id_GastoDirecto),0)+1),4) from dbo.GastosDirectos

		declare @Existe int
		select @Existe = count(Id_GastoDirecto) from dbo.GastosDirectos a where (a.Id_GastoDirecto=@Id_GastoDirecto)

		if @Existe>0 
		
			UPDATE dbo.GastosDirectos
		        SET Nombre_GastoDirecto=@Nombre_GastoDirecto
		    WHERE
		    	Id_GastoDirecto=@Id_GastoDirecto
				
		else
		
			INSERT INTO dbo.GastosDirectos
	           (Id_GastoDirecto
	           ,Nombre_GastoDirecto)
	     	VALUES
	           (@maximo
	           ,@Nombre_GastoDirecto)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
