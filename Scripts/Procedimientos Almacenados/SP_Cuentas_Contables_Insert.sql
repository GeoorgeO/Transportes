USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Cuentas_Contables_Insert')
DROP PROCEDURE SP_Cuentas_Contables_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Cuentas_Contables_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_cuenta varchar(16),
	@Id_cuenta_padre varchar(16),
	@Nombre_cuenta varchar(60),
	@Id_tipocuenta char(2),
	@Naturaleza char(1),
	@Activa int
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
		select @Existe = count(Id_cuenta) from dbo.Cuentas_Contables a where (a.Id_cuenta=@Id_cuenta)

		if @Existe>0 
		
			UPDATE dbo.Cuentas_Contables
		        SET Id_cuenta_padre=@Id_cuenta_padre,
				Nombre_cuenta=@Nombre_cuenta,
				Id_tipocuenta=@Id_tipocuenta,
				Naturaleza=@Naturaleza,
				Activa=@Activa
		    WHERE
		    	Id_cuenta=@Id_cuenta
				
			
				
		else
		
			INSERT INTO dbo.Cuentas_Contables
	           (Id_cuenta
	           ,Id_cuenta_padre
			   ,Nombre_cuenta
			   ,Id_tipocuenta
			   ,Naturaleza
			   ,Activa
			   ,Nivel)
	     	VALUES
	           (@Id_cuenta
	           ,@Id_cuenta_padre
			   ,@Nombre_cuenta
			   ,@Id_tipocuenta
			   ,@Naturaleza
			   ,1
			   ,'U')
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
