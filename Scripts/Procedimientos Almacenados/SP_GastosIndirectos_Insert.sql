USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_GastosIndirectos_Insert')
DROP PROCEDURE SP_GastosIndirectos_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_GastosIndirectos_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_GastoIndirecto char(4),
	@Nombre_GastoIndirecto varchar(40)
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
		select @maximo=right(Concat('0000', isnull(max(Id_GastoIndirecto),0)+1),4) from dbo.GastosIndirectos

		declare @Existe int
		select @Existe = count(Id_GastoIndirecto) from dbo.GastosIndirectos a where (a.Id_GastoIndirecto=@Id_GastoIndirecto)

		if @Existe>0 
		
			UPDATE dbo.GastosIndirectos
		        SET Nombre_GastoIndirecto=@Nombre_GastoIndirecto
		    WHERE
		    	Id_GastoIndirecto=@Id_GastoIndirecto
				
		else
		
			INSERT INTO dbo.GastosIndirectos
	           (Id_GastoIndirecto
	           ,Nombre_GastoIndirecto)
	     	VALUES
	           (@maximo
	           ,@Nombre_GastoIndirecto)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
