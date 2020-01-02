USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tarjetas_Combustible_Insert')
DROP PROCEDURE SP_Tarjetas_Combustible_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tarjetas_Combustible_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tarjeta_Combustible varchar(20),
	@Vigencia datetime,
	@Id_Empresa char(4),
	@Monto_Min numeric(18,2),
	@Monto_Max numeric(18,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try


		declare @Existe int
		select @Existe = count(Id_Tarjeta_Combustible) from dbo.Tarjetas_Combustible as a where (a.Id_Tarjeta_Combustible=@Id_Tarjeta_Combustible)

		if @Existe>0 
		
			UPDATE dbo.Tarjetas_Combustible
		        SET Vigencia=@Vigencia,
				Id_Empresa=@Id_Empresa,
				Monto_Min=@Monto_Min,
				Monto_Max=@Monto_Max
		    WHERE
		    	Id_Tarjeta_Combustible=@Id_Tarjeta_Combustible
				
		else
		
			INSERT INTO dbo.Tarjetas_Combustible
	           (Id_Tarjeta_Combustible
	           ,Vigencia
			   ,Id_Empresa
			   ,Monto_Min
			   ,Monto_Max)
	     	VALUES
	           (@Id_Tarjeta_Combustible
	           ,@Vigencia
			   ,@Id_Empresa
			   ,@Monto_Min
			   ,@Monto_Max)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END