USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Polizas_Delete')
DROP PROCEDURE SP_Polizas_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Polizas_Delete] 
	-- Add the parameters for the stored procedure here
	@Poliza_Seguro varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
	
		declare @Estado bit
		select @Estado=Estatus from dbo.Polizas where Poliza_Seguro=@Poliza_Seguro
		
		if @Estado=1
			Update  dbo.Polizas set Estatus=0 where Poliza_Seguro=@Poliza_Seguro
		else
			Update  dbo.Polizas set Estatus=1 where Poliza_Seguro=@Poliza_Seguro

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END
