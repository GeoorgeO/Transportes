USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empleado_Insert')
DROP PROCEDURE SP_Empleado_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Empleado_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Empleado char(6),
	@Id_Tipo_Empleado char(3),
	@Nombre_Empleado varchar(80),
	@Telefono varchar(15),
	@RFC varchar(20),
	@CURP char(18),
	@No_Identificacion varchar(15),
	@Id_Licencia char(6),
	@Id_Empresa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(6)
		select @maximo=right(Concat('000000', isnull(max(Id_Empleado),0)+1),6) from dbo.Empleado

		declare @Existe int
		select @Existe = count(Id_Empleado) from dbo.Empleado a where (a.Id_Empleado=@Id_Empleado)

		if @Existe>0 
		
			UPDATE dbo.Empleado
		        SET Id_Tipo_Empleado=@Id_Tipo_Empleado,
				Nombre_Empleado=@Nombre_Empleado,
				Telefono=@Telefono,
				RFC=@RFC,
				CURP=@CURP,
				No_Identificacion=@No_Identificacion,
				Id_Licencia=@Id_Licencia,
				Id_Empresa=@Id_Empresa
		    WHERE
		    	Id_Empleado=@Id_Empleado
				
		else
		
			INSERT INTO dbo.Empleado
	           (Id_Empleado
	           ,Id_Tipo_Empleado
			   ,Nombre_Empleado
			   ,Telefono
			   ,RFC
			   ,CURP
			   ,No_Identificacion
			   ,Id_Licencia
			   ,Id_Empresa)
	     	VALUES
	           (@maximo
	           ,@Id_Tipo_Empleado
			   ,@Nombre_Empleado
			   ,@Telefono
			   ,@RFC
			   ,@CURP
			   ,@No_Identificacion
			   ,@Id_Licencia
			   ,@Id_Empresa)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
