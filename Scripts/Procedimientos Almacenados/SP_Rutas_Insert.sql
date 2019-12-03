USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Rutas_Insert')
DROP PROCEDURE SP_Rutas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Rutas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Rutas char(4),
	@Nombre_Ruta varchar(80),
	@Kilometros numeric(18,2),
	@Origen varchar(80),
	@Destino varchar(80)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(4)

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right(Concat('0000', isnull(max(Id_Rutas),0)+1),4) from dbo.Rutas

		declare @Existe int
		select @Existe = count(Id_Rutas) from dbo.Rutas a where (a.Id_Rutas=@Id_Rutas)

		if @Existe>0 
		
			UPDATE dbo.Rutas
		        SET Nombre_Ruta=@Nombre_Ruta,
					Kilometros=@Kilometros,
					Origen=@Origen,
					Destino=@Destino
		    WHERE
		    	Id_Rutas=@Id_Rutas
				
				
		else
			INSERT INTO dbo.Rutas
	           (Id_Rutas
	           ,Nombre_Ruta
			   ,Kilometros
			   ,Origen
			   ,Destino)
	     	VALUES
	           (@maximo
	           ,@Nombre_Ruta
			   ,@Kilometros
			   ,@Origen
			   ,@Destino)
			

		if @Existe>0 
			 set @correcto=@Id_Rutas
		else
			 set @correcto=@maximo
		
		commit transaction T1;
		
	end try
	begin catch
		rollback transaction T1;
		set @correcto='-0'
	end catch

	select @correcto resultado
END
