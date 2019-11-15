USE [Transportes]
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_AccesosPermisos_Select')
DROP PROCEDURE SP_AccesosPermisos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_AccesosPermisos_Select
	-- Add the parameters for the stored procedure here
	@Id_Perfil char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Nombre_Pantalla
		from Perfiles_Pantallas as P
		inner join Pantallas as A on A.Id_Pantalla=P.Id_Pantalla
		where P.Id_Perfil=@Id_Perfil
END
GO
