USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Insert')
DROP PROCEDURE SP_Salidas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Salida char(10),
	@Fecha_Salida datetime,
	@Id_Activo_Principal char(8),
	@Id_Operador char(6),
	@Id_Ayudante char(6),
	@Id_Activo_Secundario char(8), 
	@Id_Activo_Adicional char(8),
	@Id_Ruta char(4),
	@Id_MotivoSalida char(3),
	@Id_Cliente char(6),
	@km_Inicio numeric(18,2),
	@km_Fin numeric(18,2),
	@Dias_Viaje numeric(18,2),
	@Lts_Km numeric(18,2),
	@Id_Huerta char(5),
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
		select @maximo=right(Concat('0000000000', isnull(max(Id_Salida),0)+1),10) from dbo.Salidas

		declare @Existe int
		select @Existe = count(Id_Salida) from dbo.Salidas a where (a.Id_Salida=@Id_Salida)

		if @Existe>0 
		
			UPDATE dbo.Salidas
		    SET Fecha_Salida=@Fecha_Salida,
				Id_Activo_Principal=@Id_Activo_Principal,
				Id_Operador=@Id_Operador,
				Id_Ayudante=@Id_Ayudante,
				Id_Activo_Secundario=@Id_Activo_Secundario,
				Id_Activo_Adicional=@Id_Activo_Adicional,
				Id_Ruta=@Id_Ruta,
				Id_MotivoSalida=@Id_MotivoSalida,
				Id_Cliente=@Id_Cliente,
				km_Inicio=@km_Inicio,
				km_Fin=@km_Fin,
				Id_Huerta=@Id_Huerta,
				Observaciones=@Observaciones
		    WHERE
		    	Id_Salida=@Id_Salida
				
		else
		
			INSERT INTO dbo.Salidas
	           (Id_Salida
	           ,Fecha_Salida
			   ,Id_Activo_Principal
			   ,Id_Operador
			   ,Id_Ayudante
			   ,Id_Activo_Secundario
			   ,Id_Activo_Adicional
			   ,Id_Ruta
			   ,Id_MotivoSalida
			   ,Id_Cliente
			   ,km_Inicio
			   ,km_Fin
			   ,Id_Huerta
			   ,Observaciones)
	     	VALUES
	           (@maximo
	           ,@Fecha_Salida
			   ,@Id_Activo_Principal
			   ,@Id_Operador
			   ,@Id_Ayudante
			   ,@Id_Activo_Secundario
			   ,@Id_Activo_Adicional
			   ,@Id_Ruta
			   ,@Id_MotivoSalida
			   ,@Id_Cliente
			   ,@km_Inicio
			   ,@km_Fin
			   ,@Id_Huerta
			   ,@Observaciones)
			   
		if @Existe>0 
			set @correcto=@Id_Salida
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
