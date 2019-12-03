USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Carga_Combustible_Insert')
DROP PROCEDURE SP_Carga_Combustible_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Carga_Combustible_Insert] 
	-- Add the parameters for the stored procedure here
	@Folio char(8),
	@FechaCarga datetime,
	@Kilometraje numeric(18,2),
	@Litros numeric(18,2),
	@PrecioLitro numeric(18,2),
	@PrecioTotal numeric(18,2),
	@Kilometraje numeric(18,2),
	@Id_Activo char(8),
	@Id_Proveedor char(6),
	@Id_Factura varchar(50),
	@Comprador char(6),
	@Observaciones varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(8)
		select @maximo=right(Concat('00000000', isnull(max(Folio),0)+1),8) from dbo.Carga_Combustible

		declare @Existe int
		select @Existe = count(Folio) from dbo.Carga_Combustible a where (a.Folio=@Folio)

		if @Existe>0 
		
			UPDATE dbo.Carga_Combustible
		    SET FechaCarga=@FechaCarga,
				Kilometraje=@Kilometraje,
				Litros=@Litros,
				PrecioLitro=@PrecioLitro,
				PrecioTotal=@PrecioTotal,
				Kilometraje=@Kilometraje,
				Id_Activo=@Id_Activo,
				Id_Proveedor=@Id_Proveedor,
				Id_Factura=@Id_Factura,
				Comprador=@Comprador,
				Observaciones=@Observaciones
		    WHERE
		    	Folio=@Folio
				
		else
		
			INSERT INTO dbo.Carga_Combustible
	           (Folio
	           ,FechaCarga
			   ,Kilometraje
			   ,Litros
			   ,PrecioLitro
			   ,PrecioTotal
			   ,Kilometraje
			   ,Id_Activo
			   ,Id_Proveedor
			   ,Id_Factura
			   ,Comprador
			   ,Observaciones)
	     	VALUES
	           (@maximo
	           ,@FechaCarga
			   ,@Kilometraje
			   ,@Litros
			   ,@PrecioLitro
			   ,@PrecioTotal
			   ,@Kilometraje
			   ,@Id_Activo
			   ,@Id_Proveedor
			   ,@Id_Factura
			   ,@Comprador
			   ,@Observaciones)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
