USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Empleado_Insert')
DROP PROCEDURE SP_Tipo_Empleado_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Empleado_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Empleado char(4),
	@Nombre_Tipo_Empleado varchar(70)
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
		select @maximo=right(concat('0000', isnull(max(Id_Tipo_Empleado),0)+1),4) from dbo.Tipo_Empleado

		declare @Existe int
		select @Existe = count(Id_Tipo_Empleado) from dbo.Tipo_Empleado a where (a.Id_Tipo_Empleado=@Id_Tipo_Empleado)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Empleado
		        SET Nombre_Tipo_Empleado=@Nombre_Tipo_Empleado
		    WHERE
		    	Id_Tipo_Empleado=@Id_Tipo_Empleado
				
		else
		
			INSERT INTO dbo.Tipo_Empleado
	           (Id_Tipo_Empleado
	           ,Nombre_Tipo_Empleado)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Empleado)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
