USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Honorarios_Insert')
DROP PROCEDURE SP_Salidas_Honorarios_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Honorarios_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@Importe numeric(18, 2),
	@Fecha_Honorario datetime
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit
	
	declare @Id_Honorario numeric(10,0)
	select @Id_Honorario=(isnull(max(Id_Honorario),0)+1) from dbo.Salidas_Honorarios where Id_Salida=@Id_Salida

	begin transaction T1;
	begin try
		
			INSERT INTO dbo.Salidas_Honorarios
	           (Id_Honorario
			   ,Id_Salida
			   ,Concepto
			   ,Importe
			   ,Moneda
			   ,Fecha_Honorario)
	     	VALUES
	           (@Id_Honorario
			   ,@Id_Salida
			   ,'HONORARIOS AL OPERADOR'
			   ,@Importe
			   ,'P'
			   ,@Fecha_Honorario)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
