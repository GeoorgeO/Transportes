USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipos_Cuentas_Insert')
DROP PROCEDURE SP_Tipos_Cuentas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipos_Cuentas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_tipocuenta char(2),
	@Nombre_tipocuenta varchar(50)
	
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
		select @Existe = count(Id_tipocuenta) from dbo.Tipos_Cuentas a where (a.Id_tipocuenta=@Id_tipocuenta)

		if @Existe>0 
		
			UPDATE dbo.Tipos_Cuentas
		        SET Id_tipocuenta=@Id_tipocuenta,
				Nombre_tipocuenta=@Nombre_tipocuenta
		    WHERE
		    	Id_tipocuenta=@Id_tipocuenta
				
		else
		
			INSERT INTO dbo.Tipos_Cuentas
	           (Id_tipocuenta
	           ,Nombre_tipocuenta)
	     	VALUES
	           (@Id_tipocuenta
	           ,@Nombre_tipocuenta)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
