USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_HistorialOperadores_Insert')
DROP PROCEDURE SP_HistorialOperadores_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_HistorialOperadores_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Operador char(6),
	@Id_Activo char(8),
	@Tipo char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
			INSERT INTO dbo.HistorialOperadores
	           (Id_Operador
	           ,Id_Activo
			   ,FechaAsignada
			   ,Tipo)
	     	VALUES
	           (@Id_Operador
	           ,@Id_Activo
			   ,getdate()
			   ,@Tipo)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
