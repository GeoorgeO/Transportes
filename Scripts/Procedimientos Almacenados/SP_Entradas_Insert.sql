USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Entradas_Insert')
DROP PROCEDURE SP_Entradas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Entradas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Entrada char(10),
	@Id_Salida char(10),
	@Fecha_Entrada datetime,
	@Fecha_Cruce datetime,
	@Id_Activo_P char(8),
	@Id_Activo_1 char(8),
	@Id_Activo_2 char(8)
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
		select @maximo=right(Concat('0000000000', isnull(max(Id_Entrada),0)+1),10) from dbo.Entradas

		declare @Existe int
		select @Existe = count(Id_Entrada) from dbo.Entradas a where (a.Id_Entrada=@Id_Entrada)

		if @Existe>0 
		
			UPDATE dbo.Entradas
		        SET Id_Salida=@Id_Salida,
				Fecha_Entrada=@Fecha_Entrada,
				Fecha_Cruce=@Fecha_Cruce
		    WHERE
		    	Id_Entrada=@Id_Entrada
				
		else
		
			INSERT INTO dbo.Entradas
	           (Id_Entrada
	           ,Id_Salida
			   ,Fecha_Entrada
			   ,Fecha_Cruce
			   ,Id_Activo_P
			   ,Id_Activo_1
			   ,Id_Activo_2)
	     	VALUES
	           (@Id_Entrada
	           ,@Id_Salida
			   ,@Fecha_Entrada
			   ,@Fecha_Cruce
			   ,@Id_Activo_P
			   ,@Id_Activo_1
			   ,@Id_Activo_2)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
