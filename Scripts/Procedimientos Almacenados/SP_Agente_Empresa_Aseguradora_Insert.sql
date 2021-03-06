USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Agente_Empresa_Aseguradora_Insert')
DROP PROCEDURE SP_Agente_Empresa_Aseguradora_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Agente_Empresa_Aseguradora_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Agente_Empresa_Aseguradora char(4),
	@Nombre_Agente_Empresa_Aseguradora varchar(80),
	@Telefono varchar(15),
	@Id_Empresa_Aseguradora char(4)
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
		select @maximo=right(Concat('0000', isnull(max(Id_Agente_Empresa_Aseguradora),0)+1),4) from dbo.Agente_Empresa_Aseguradora

		declare @Existe int
		select @Existe = count(Id_Agente_Empresa_Aseguradora) from dbo.Agente_Empresa_Aseguradora a where (a.Id_Agente_Empresa_Aseguradora=@Id_Agente_Empresa_Aseguradora)

		if @Existe>0 
		
			UPDATE dbo.Agente_Empresa_Aseguradora
		        SET Nombre_Agente_Empresa_Aseguradora=@Nombre_Agente_Empresa_Aseguradora,
				Telefono=@Telefono,
				Id_Empresa_Aseguradora=@Id_Empresa_Aseguradora
		    WHERE
		    	Id_Agente_Empresa_Aseguradora=@Id_Agente_Empresa_Aseguradora
				
		else
		
			INSERT INTO dbo.Agente_Empresa_Aseguradora
	           (Id_Agente_Empresa_Aseguradora
	           ,Nombre_Agente_Empresa_Aseguradora
			   ,Telefono
			   ,Id_Empresa_Aseguradora)
	     	VALUES
	           (@maximo
	           ,@Nombre_Agente_Empresa_Aseguradora
			   ,@Telefono
			   ,@Id_Empresa_Aseguradora)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
