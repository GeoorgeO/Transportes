USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Proveedores_Insert')
DROP PROCEDURE SP_Proveedores_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Proveedores_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Proveedor char(6),
	@Nombre_Proveedor varchar(80),
	@RFC_Proveedor varchar(15),
	@Telefono varchar(15),
	@Dias_Credito numeric(18,0)
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
		select @maximo=right(Concat('000000', isnull(max(Id_Proveedor),0)+1),6) from dbo.Proveedores

		declare @Existe int
		select @Existe = count(Id_Proveedor) from dbo.Proveedores a where (a.Id_Proveedor=@Id_Proveedor)

		if @Existe>0 
		
			UPDATE dbo.Proveedores
		        SET Nombre_Proveedor=@Nombre_Proveedor,
				Telefono=@Telefono,
				RFC_Proveedor=@RFC_Proveedor,
				Dias_Credito=@Dias_Credito
		    WHERE
		    	Id_Proveedor=@Id_Proveedor
				
		else
		
			INSERT INTO dbo.Proveedores
	           (Id_Proveedor
	           ,Nombre_Proveedor
			   ,RFC_Proveedor
			   ,Telefono
			   ,Dias_Credito)
	     	VALUES
	           (@maximo
	           ,@Nombre_Proveedor
			   ,@RFC_Proveedor
			   ,@Telefono
			   ,@Dias_Credito)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
