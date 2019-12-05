USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Servicios_Insert')
DROP PROCEDURE SP_Servicios_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Servicios_Insert] 
	-- Add the parameters for the stored procedure here
	@Folio char(10),
	@Id_Activo char(8),
	@Id_TipoServicio char(3),
	@PrecioTotal numeric(18,2),
	@Kilometraje numeric(18,2),
	@FechaServicio datetime,
	@Id_Proveedor char(6),
	@Id_Factura varchar(50),
	@Comprador char(6),
	@Observaciones varchar(100)
as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto varchar(10)

	begin transaction T1;
	begin try

		declare @maximo char(10)
		select @maximo=right(Concat('0000000000', isnull(max(Folio),0)+1),10) from dbo.Servicios

		declare @Existe int
		select @Existe = count(Folio) from dbo.Servicios a where (a.Folio=@Folio)

		if @Existe>0 
		
			UPDATE dbo.Servicios
		    SET Id_Activo=@Id_Activo,
				Id_TipoServicio=@Id_TipoServicio,
				PrecioTotal=@PrecioTotal,
				Kilometraje=@Kilometraje,
				FechaServicio=@FechaServicio,
				Id_Proveedor=@Id_Proveedor,
				Id_Factura=@Id_Factura,
				Comprador=@Comprador,
				Observaciones=@Observaciones
		    WHERE
		    	Folio=@Folio
				
		else
		
			INSERT INTO dbo.Servicios
	           (Folio
	           ,Id_Activo
			   ,Id_TipoServicio
			   ,PrecioTotal
			   ,Kilometraje
			   ,FechaServicio
			   ,Id_Proveedor
			   ,Id_Factura
			   ,Comprador
			   ,Observaciones)
	     	VALUES
	           (@maximo
	           ,@Id_Activo
			   ,@Id_TipoServicio
			   ,@PrecioTotal
			   ,@Kilometraje
			   ,@FechaServicio
			   ,@Id_Proveedor
			   ,@Id_Factura
			   ,@Comprador
			   ,@Observaciones)
			   
		if @Existe>0 
			set @correcto=@Folio
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
