USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Honorarios_PagoOperador_Insert')
DROP PROCEDURE SP_Salidas_Honorarios_PagoOperador_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Honorarios_PagoOperador_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@Importe numeric(18, 2)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit
	
	
	declare @Existe int
		select @Existe = count(Id_Honorario) from dbo.Salidas_Honorarios a where (a.Id_Salida=@Id_Salida and Id_Honorario=1)

	begin transaction T1;
	begin try
	
	if @Existe>0 
		Update dbo.Salidas_Honorarios
		set Importe=@Importe
		where Id_Salida=@Id_Salida and Id_Honorario=1
	else
		INSERT INTO dbo.Salidas_Honorarios
           (Id_Honorario
		   ,Id_Salida
		   ,Concepto
		   ,Importe)
     	VALUES
           (1
		   ,@Id_Salida
		   ,'GASTOS PAGADOS POR OPERADOR'
		   ,@Importe)
			   
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
