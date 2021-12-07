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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Kilometraje_Fin_Select')
DROP PROCEDURE SP_Kilometraje_Fin_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Kilometraje_Fin_Select
	-- Add the parameters for the stored procedure here
	@Id_Activo char(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select isnull(S.km_Fin,0) as Km_Fin 
		from Transportes.dbo.Salidas as S
		where S.Id_Activo_Principal = @Id_Activo  
		and S.Fecha_Salida = (
			select max(Fecha_Salida) 
			from Transportes.dbo.Salidas 
			where Id_Activo_Principal = @Id_Activo)
		
END
GO