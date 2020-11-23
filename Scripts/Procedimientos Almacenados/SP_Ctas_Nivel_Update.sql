USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Ctas_Nivel_Update')
DROP PROCEDURE SP_Ctas_Nivel_Update
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Ctas_Nivel_Update] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		update Cuentas_Contables set Nivel='P' where len(isnull(Id_cuenta_padre,''))=0 and  (select count(Id_cuenta) from Cuentas_Contables where Id_cuenta in (select distinct Id_cuenta_padre from Cuentas_Contables))>0
		
		update Cuentas_Contables set Nivel='U' from Cuentas_Contables where Id_cuenta not in (select distinct Id_cuenta_padre from Cuentas_Contables)

		update Cuentas_Contables set Nivel='M' where len(isnull(Id_cuenta_padre,''))>0 and Id_cuenta in (select distinct Id_cuenta_padre from Cuentas_Contables)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
