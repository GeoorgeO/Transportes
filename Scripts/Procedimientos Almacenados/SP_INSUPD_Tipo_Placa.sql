USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_INSUPD_Tipo_Placa')
DROP PROCEDURE SP_INSUPD_Tipo_Placa
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_INSUPD_Tipo_Placa] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Placa char(4),
	@Nombre_Tipo_Placa varchar(70)
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
		select @maximo=right('0000'+ isnull(max(Id_Tipo_Placa),0)+1,4) from dbo.Tipo_Placa

		declare @Existe int
		select @Existe = count(Id_Tipo_Placa) from dbo.Tipo_Placa a where (a.Id_Tipo_Placa=@Id_Tipo_Placa)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Placa
		        SET Nombre_Tipo_Placa=@Nombre_Tipo_Placa
		    WHERE
		    	Id_Tipo_Placa=@Id_Tipo_Placa
				
		else
		
			INSERT INTO dbo.Tipo_Placa
	           (Id_Tipo_Placa
	           ,Nombre_Tipo_Placa)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Placa)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
