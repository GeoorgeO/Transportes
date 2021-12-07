USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Carga_Combustible_Delete_New')
DROP PROCEDURE SP_Carga_Combustible_Delete_New
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Carga_Combustible_Delete_New] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@Ticket varchar(20),
	@Id_Activo char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Carga_Combustible where Id_Salida=@Id_Salida and Ticket=@Ticket and Id_Activo=@Id_Activo

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END