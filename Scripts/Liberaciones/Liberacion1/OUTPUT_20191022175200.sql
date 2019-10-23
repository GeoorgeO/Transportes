USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Transportes'))
BEGIN
	create Database Transportes
END

GO
USE [Transportes]
GO
IF OBJECT_ID('Activos') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Activos](
		[Id_Activo] [char](8) NOT NULL,
		[Nombre_Interno] [varchar](150) NULL,
		[Costo_Unidad] [numeric](18, 2) NULL,
		[Fecha_Alta] [datetime] NULL,
		[Fecha_Baja] [datetime] NULL,
		[Serie] [varchar](20) NULL,
		[Tarjeta_Circulacion] [varchar](15) NULL,
		[Placas] [varchar](10) NULL,
		[Id_Tipo_Placa] [char](4) NULL,
		[Id_Tipo_Activo] [char](4) NULL,
		[Color] [varchar](15) NULL,
		[Modelo] [varchar](20) NULL,
		[Id_Marca] [char](4) NULL,
		[Descripcion] [varchar](250) NULL,
		[Id_Tipo_Transporte] [char](4) NULL,
		[Poliza_Seguro] [varchar](20) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
		[Status] [char](5) NULL,
		[Asignado] [bit] NULL,
		[Id_Empleado] [char](4) NULL,
		[Id_Empresa] [char](4) NULL,
	 CONSTRAINT [PK_Activos] PRIMARY KEY CLUSTERED 
	(
		[Id_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Agente_Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Agente_Empresa_Aseguradora](
		[Id_Agente_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
	 CONSTRAINT [PK_Agente_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Agente_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Broker_Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Broker_Empresa_Aseguradora](
		[Id_Broker_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Broker_Empresa_Aseguradora] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[Id_Empresa_Aseguradora] [char](4) NULL,
	 CONSTRAINT [PK_Broker_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Broker_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Clientes') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Clientes](
		[Id_Cliente] [char](6) NOT NULL,
		[Nombre_Cliente] [varchar](80) NULL,
		[RFC_Cliente] [varchar](15) NULL,
		[Telefono] [varchar](15) NULL,
	 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
	(
		[Id_Cliente] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Domicilios') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Domicilios](
		[Id_Domicilio] [char](4) NOT NULL,
		[Calle] [varchar](100) NULL,
		[NoInterior] [varchar](10) NULL,
		[NoExterior] [varchar](10) NULL,
		[Colonia] [varchar](50) NULL,
		[Codigo_Postal] [char](5) NULL,
		[Id_Estado] [char](3) NULL,
		[Id_TipoDomicilio] [char](3) NULL,
		[Id_Persona] [char](6) NULL,
		[id_TipoPersona] [char](4) NULL,
	 CONSTRAINT [PK_Domicilios] PRIMARY KEY CLUSTERED 
	(
		[Id_Domicilio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empleado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empleado](
		[Id_Empleado] [char](6) NOT NULL,
		[Id_Tipo_Empleado] [char](3) NULL,
		[Nombre_Empleado] [varchar](80) NULL,
		[Telefono] [varchar](15) NULL,
		[RFC] [varchar](20) NULL,
		[CURP] [char](18) NULL,
		[No_Identificacion] [varchar](15) NULL,
		[Id_Licencia] [char](6) NULL,
	 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
	(
		[Id_Empleado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empresa_Aseguradora') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empresa_Aseguradora](
		[Id_Empresa_Aseguradora] [char](4) NOT NULL,
		[Nombre_Empresa_Aseguradora] [varchar](50) NULL,
		[Telefono] [varchar](15) NULL,
		[Telefono_Siniestros] [varchar](15) NULL,
	 CONSTRAINT [PK_Empresa_Aseguradora] PRIMARY KEY CLUSTERED 
	(
		[Id_Empresa_Aseguradora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Empresa') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Empresa](
	[Id_Empresa] [char](4) NOT NULL,
	[Nombre_Empresa] [varchar](50) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id_Empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Estado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Estado](
		[Id_Estado] [char](3) NOT NULL,
		[Nombre_Estado] [varchar](20) NULL,
		[Id_Pais] [varchar](20) NULL,
	 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
	(
		[Id_Estado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Licencia](
		[Id_Licencia] [char](6) NOT NULL,
		[Id_Tipo_Licencia] [char](3) NULL,
		[Vigencia] [datetime] NULL,
		[No_Licencia] [varchar](20) NULL,
	 CONSTRAINT [PK_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Mantenimiento') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Mantenimiento](
		[Id_Mantenimiento] [char](10) NOT NULL,
		[Nombre_Mantenimiento] [varchar](100) NULL,
		[Id_Tipo_Mantenimiento] [char](3) NULL,
		[Fecha_Programacion] [datetime] NULL,
		[KM_Programacion] [numeric](18, 2) NULL,
	 CONSTRAINT [PK_Mantenimiento] PRIMARY KEY CLUSTERED 
	(
		[Id_Mantenimiento] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Marcas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Marcas](
		[Id_Marca] [char](4) NOT NULL,
		[Nombre_Marca] [varchar](70) NULL,
	 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
	(
		[Id_Marca] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Pais') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Pais](
		[Id_Pais] [char](3) NOT NULL,
		[Nombre_Pais] [varchar](30) NULL,
	 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
	(
		[Id_Pais] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Proveedores') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Proveedores](
	[Id_Proveedor] [char](6) NOT NULL,
	[Nombre_Proveedor] [varchar](80) NULL,
	[RFC_Proveedor] [varchar](15) NULL,
	[Telefono] [varchar](15) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Rutas') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Rutas](
		[Id_Rutas] [char](4) NOT NULL,
		[Nombre_Ruta] [varchar](80) NULL,
	 CONSTRAINT [PK_Rutas] PRIMARY KEY CLUSTERED 
	(
		[Id_Rutas] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Rutas_Detalle') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Rutas_Detalle](
		[Id_Rutas] [char](4) NOT NULL,
		[Nombre_Rutas_Detalle] [varchar](100) NULL,
		[Secuencia] [char](3) NULL,
	 CONSTRAINT [PK_Rutas_Detalle] PRIMARY KEY CLUSTERED 
	(
		[Id_Rutas] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('TipoPersona') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[TipoPersona](
		[Id_TipoPersona] [char](4) NOT NULL,
		[TipoPersona] [varchar](50) NULL,
	 CONSTRAINT [PK_TipoPersona] PRIMARY KEY CLUSTERED 
	(
		[Id_TipoPersona] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Activo') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Activo](
		[Id_Tipo_Activo] [char](4) NOT NULL,
		[Nombre_Tipo_Activo] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Activo] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Activo] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Domicilio') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Domicilio](
		[Id_TipoDomicilio] [char](4) NOT NULL,
		[Nombre_TipoDomilio] [varchar](50) NULL,
	 CONSTRAINT [PK_Tipo_Domicilio] PRIMARY KEY CLUSTERED 
	(
		[Id_TipoDomicilio] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Empleado') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Empleado](
		[Id_Tipo_Empleado] [char](3) NOT NULL,
		[Nombre_Tipo_Empleado] [varchar](25) NULL,
	 CONSTRAINT [PK_Tipo_Empleado] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Empleado] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Licencia') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Licencia](
		[Id_Tipo_Licencia] [char](3) NOT NULL,
		[Nombre_Tipo_Licencia] [varchar](10) NULL,
		[Serie] [varchar](20) NULL,
	 CONSTRAINT [PK_Tipo_Licencia] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Licencia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Mantenimiento') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Mantenimiento](
		[Id_Tipo_Mantenimiento] [char](3) NOT NULL,
		[Nombre_Tipo_Mantenimiento] [varchar](50) NULL,
	 CONSTRAINT [PK_Tipo_Mantenimiento] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Mantenimiento] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Placa') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Placa](
		[Id_Tipo_Placa] [char](4) NOT NULL,
		[Nombre_Tipo_Placa] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Placa] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Placa] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
IF OBJECT_ID('Tipo_Transporte') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Tipo_Transporte](
		[Id_Tipo_Transporte] [char](4) NOT NULL,
		[Nombre_Tipo_Transporte] [varchar](70) NULL,
	 CONSTRAINT [PK_Tipo_Transporte] PRIMARY KEY CLUSTERED 
	(
		[Id_Tipo_Transporte] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empleado_Delete')
DROP PROCEDURE SP_Empleado_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Empleado_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Empleado char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Empleado where Id_Empleado=@Id_Empleado

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empleado_Insert')
DROP PROCEDURE SP_Empleado_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Empleado_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Empleado char(6),
	@Id_Tipo_Empleado char(3),
	@Nombre_Empleado varchar(80),
	@Telefono varchar(15),
	@RFC varchar(20),
	@CURP char(18),
	@No_Identificacion varchar(15),
	@Id_Licencia char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(6)
		select @maximo=right(Concat('000000', isnull(max(Id_Empleado),0)+1),6) from dbo.Empleado

		declare @Existe int
		select @Existe = count(Id_Empleado) from dbo.Empleado a where (a.Id_Empleado=@Id_Empleado)

		if @Existe>0 
		
			UPDATE dbo.Empleado
		        SET Id_Tipo_Empleado=@Id_Tipo_Empleado,
				Nombre_Empleado=@Nombre_Empleado,
				Telefono=@Telefono,
				RFC=@RFC,
				CURP=@CURP,
				No_Identificacion=@No_Identificacion,
				Id_Licencia=@Id_Licencia
		    WHERE
		    	Id_Empleado=@Id_Empleado
				
		else
		
			INSERT INTO dbo.Empleado
	           (Id_Empleado
	           ,Id_Tipo_Empleado
			   ,Nombre_Empleado
			   ,Telefono
			   ,RFC
			   ,CURP
			   ,No_Identificacion
			   ,Id_Licencia)
	     	VALUES
	           (@maximo
	           ,@Id_Tipo_Empleado
			   ,@Nombre_Empleado
			   ,@Telefono
			   ,@RFC
			   ,@CURP
			   ,@No_Identificacion
			   ,@Id_Licencia)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empleado_Select')
DROP PROCEDURE SP_Empleado_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Empleado_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select E.Id_Empleado
	      ,E.Id_Tipo_Empleado
		  ,TE.Nombre_Tipo_Empleado
		  ,E.Nombre_Empleado
		  ,E.Telefono
		  ,E.RFC
		  ,E.CURP
		  ,E.No_Identificacion
		  ,E.Id_Licencia
		  ,TL.No_Licencia
		from Empleado as E
		left join Tipo_Empleado as TE on E.Id_Tipo_Empleado=TE.Id_Tipo_Empleado
		left join Licencia as TL on E.Id_Licencia=TL.Id_Licencia

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empresa_Delete')
DROP PROCEDURE SP_Empresa_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Empresa_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Empresa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Empresa where Id_Empresa=@Id_Empresa

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empresa_Insert')
DROP PROCEDURE SP_Empresa_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Empresa_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Empresa char(4),
	@Nombre_Empresa varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right(Concat('0000', isnull(max(Id_Empresa),0)+1),4) from dbo.Empresa

		declare @Existe int
		select @Existe = count(Id_Empresa) from dbo.Empresa a where (a.Id_Empresa=@Id_Empresa)

		if @Existe>0 
		
			UPDATE dbo.Empresa
		        SET Nombre_Empresa=@Nombre_Empresa
		    WHERE
		    	Id_Empresa=@Id_Empresa
				
		else
		
			INSERT INTO dbo.Empresa
	           (Id_Empresa
	           ,Nombre_Empresa)
	     	VALUES
	           (@maximo
	           ,@Nombre_Empresa)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Empresa_Select')
DROP PROCEDURE SP_Empresa_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Empresa_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Empresa
	      ,Nombre_Empresa 
		from Empresa

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Estado_Delete')
DROP PROCEDURE SP_Estado_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Estado_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Estado char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Estado where Id_Estado=@Id_Estado

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Estado_Insert')
DROP PROCEDURE SP_Estado_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Estado_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Estado char(3),
	@Nombre_Estado varchar(20),
	@Id_Pais varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(3)
		select @maximo=right(Concat('000', isnull(max(Id_Estado),0)+1),3) from dbo.Estado

		declare @Existe int
		select @Existe = count(Id_Estado) from dbo.Estado a where (a.Id_Estado=@Id_Estado)

		if @Existe>0 
		
			UPDATE dbo.Estado
		        SET Nombre_Estado=@Nombre_Estado
		    WHERE
		    	Id_Estado=@Id_Estado
				
		else
		
			INSERT INTO dbo.Estado
	           (Id_Estado
	           ,Nombre_Estado
			   ,Id_Pais)
	     	VALUES
	           (@maximo
	           ,@Nombre_Estado,
			   @Id_Pais)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Estado_Select')
DROP PROCEDURE SP_Estado_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Estado_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select est.Id_Estado
	      ,est.Nombre_Estado
		  ,est.Id_Pais
		  ,P.Nombre_Pais 
		from Estado as est
		left join Pais as P on P.Id_Pais=est.Id_Pais

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Licencia_Delete')
DROP PROCEDURE SP_Licencia_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Licencia_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Licencia char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Licencia where Id_Licencia=@Id_Licencia

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Licencia_Insert')
DROP PROCEDURE SP_Licencia_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Licencia_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Licencia char(6),
	@Id_Tipo_Licencia char(3),
	@Vigencia datetime,
	@No_Licencia varchar(20)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right(Concat('0000', isnull(max(Id_Licencia),0)+1),4) from dbo.Licencia

		declare @Existe int
		select @Existe = count(Id_Licencia) from dbo.Licencia a where (a.Id_Licencia=@Id_Licencia)

		if @Existe>0 
		
			UPDATE dbo.Licencia
		        SET Id_Tipo_Licencia=@Id_Tipo_Licencia,
					Vigencia=@Vigencia,
					No_Licencia=@No_Licencia
		    WHERE
		    	Id_Licencia=@Id_Licencia
				
		else
		
			INSERT INTO dbo.Licencia
	           (Id_Licencia
	           ,Id_Tipo_Licencia
			   ,Vigencia
			   ,No_Licencia)
	     	VALUES
	           (@maximo
	           ,@Id_Tipo_Licencia
			   ,@Vigencia
			   ,@No_Licencia)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Licencia_Select')
DROP PROCEDURE SP_Licencia_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Licencia_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select lic.Id_Licencia
	      ,lic.Id_Tipo_Licencia
		  ,TL.Nombre_Tipo_Licencia
		  ,lic.Vigencia
		  ,lic.No_Licencia 
		from Licencia as lic
		left join Tipo_Licencia as TL on lic.Id_Tipo_Licencia=TL.Id_Tipo_Licencia

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Marcas_Delete')
DROP PROCEDURE SP_Marcas_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Marcas_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Marca char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Marcas where Id_Marca=@Id_Marca

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Marcas_Insert')
DROP PROCEDURE SP_Marcas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Marcas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Marca char(4),
	@Nombre_Marca varchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right('0000'+ isnull(max(Id_Marca),0)+1,4) from dbo.Marcas

		declare @Existe int
		select @Existe = count(Id_Marca) from dbo.Marcas a where (a.Id_Marca=@Id_Marca)

		if @Existe>0 
		
			UPDATE dbo.Marcas
		        SET Nombre_Marca=@Nombre_Marca
		    WHERE
		    	Id_Marca=@Id_Marca
				
		else
		
			INSERT INTO dbo.Marcas
	           (Id_Marca
	           ,Nombre_Marca)
	     	VALUES
	           (@maximo
	           ,@Nombre_Marca)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Marcas_Select')
DROP PROCEDURE SP_Marcas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Marcas_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Marca
	      ,Nombre_Marca 
		from Marcas

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Pais_Delete')
DROP PROCEDURE SP_Pais_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Pais_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Pais char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Pais where Id_Pais=@Id_Pais

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Pais_Insert')
DROP PROCEDURE SP_Pais_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Pais_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Pais char(3),
	@Nombre_Pais varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right(Concat('000', isnull(max(Id_Pais),0)+1),3) from dbo.Pais

		declare @Existe int
		select @Existe = count(Id_Pais) from dbo.Pais a where (a.Id_Pais=@Id_Pais)

		if @Existe>0 
		
			UPDATE dbo.Pais
		        SET Nombre_Pais=@Nombre_Pais
		    WHERE
		    	Id_Pais=@Id_Pais
				
		else
		
			INSERT INTO dbo.Pais
	           (Id_Pais
	           ,Nombre_Pais)
	     	VALUES
	           (@maximo
	           ,@Nombre_Pais)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Pais_Select')
DROP PROCEDURE SP_Pais_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Pais_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Pais
	      ,Nombre_Pais 
		from Pais

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Activo_Delete')
DROP PROCEDURE SP_Tipo_Activo_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Activo_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Activo char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Tipo_Activo where Id_Tipo_Activo=@Id_Tipo_Activo

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Activo_Insert')
DROP PROCEDURE SP_Tipo_Activo_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Activo_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Activo char(4),
	@Nombre_Tipo_Activo varchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right('0000'+ isnull(max(Id_Tipo_Activo),0)+1,4) from dbo.Tipo_Activo

		declare @Existe int
		select @Existe = count(Id_Tipo_Activo) from dbo.Tipo_Activo a where (a.Id_Tipo_Activo=@Id_Tipo_Activo)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Activo
		        SET Nombre_Tipo_Activo=@Nombre_Tipo_Activo
		    WHERE
		    	Id_Tipo_Activo=@Id_Tipo_Activo
				
		else
		
			INSERT INTO dbo.Tipo_Activo
	           (Id_Tipo_Activo
	           ,Nombre_Tipo_Activo)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Activo)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Activo_Select')
DROP PROCEDURE SP_Tipo_Activo_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipo_Activo_Select 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Activo char(4)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id_Tipo_Activo
	      ,Nombre_Tipo_Activo
	FROM dbo.Tipo_Activo
	where Id_Tipo_Activo=@Id_Tipo_Activo
END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Empleado_Delete')
DROP PROCEDURE SP_Tipo_Empleado_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Empleado_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Empleado char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Tipo_Empleado where Id_Tipo_Empleado=@Id_Tipo_Empleado

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Empleado_Insert')
DROP PROCEDURE SP_Tipo_Empleado_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Empleado_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Empleado char(3),
	@Nombre_Tipo_Empleado varchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right(concat('000', isnull(max(Id_Tipo_Empleado),0)+1),3) from dbo.Tipo_Empleado

		declare @Existe int
		select @Existe = count(Id_Tipo_Empleado) from dbo.Tipo_Empleado a where (a.Id_Tipo_Empleado=@Id_Tipo_Empleado)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Empleado
		        SET Nombre_Tipo_Empleado=@Nombre_Tipo_Empleado
		    WHERE
		    	Id_Tipo_Empleado=@Id_Tipo_Empleado
				
		else
		
			INSERT INTO dbo.Tipo_Empleado
	           (Id_Tipo_Empleado
	           ,Nombre_Tipo_Empleado)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Empleado)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Empleado_Select')
DROP PROCEDURE SP_Tipo_Empleado_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipo_Empleado_Select 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id_Tipo_Empleado
	      ,Nombre_Tipo_Empleado
	FROM dbo.Tipo_Empleado
	
END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Licencia_Delete')
DROP PROCEDURE SP_Tipo_Licencia_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Licencia_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Licencia char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Tipo_Licencia where Id_Tipo_Licencia=@Id_Tipo_Licencia

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Licencia_Insert')
DROP PROCEDURE SP_Tipo_Licencia_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Licencia_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Licencia char(3),
	@Nombre_Tipo_Licencia varchar(10),
	@Serie varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(3)
		select @maximo=right(Concat('000', isnull(max(Id_Tipo_Licencia),0)+1),3) from dbo.Tipo_Licencia

		declare @Existe int
		select @Existe = count(Id_Tipo_Licencia) from dbo.Tipo_Licencia a where (a.Id_Tipo_Licencia=@Id_Tipo_Licencia)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Licencia
		        SET Nombre_Tipo_Licencia=@Nombre_Tipo_Licencia,
					Serie=@Serie
		    WHERE
		    	Id_Tipo_Licencia=@Id_Tipo_Licencia
				
		else
		
			INSERT INTO dbo.Tipo_Licencia
	           (Id_Tipo_Licencia
	           ,Nombre_Tipo_Licencia,
			   Serie)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Licencia,
			   @Serie)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Licencia_Select')
DROP PROCEDURE SP_Tipo_Licencia_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipo_Licencia_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Tipo_Licencia
	      ,Nombre_Tipo_Licencia,
		  Serie
		from Tipo_Licencia

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Placa_Delete')
DROP PROCEDURE SP_Tipo_Placa_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Placa_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Placa char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Tipo_Placa where Id_Tipo_Placa=@Id_Tipo_Placa

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Placa_Insert')
DROP PROCEDURE SP_Tipo_Placa_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Placa_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Placa char(4),
	@Nombre_Tipo_Placa varchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right('0000'+ isnull(max(Id_Tipo_Placa),0)+1,4) from dbo.Tipo_Placa

		declare @Existe int
		select @Existe = count(Id_Tipo_Placa) from dbo.Tipo_Placa a where (a.Id_Tipo_Placa=@Id_Tipo_Placa)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Placa
		        SET Nombre_Tipo_Placa=@Nombre_Tipo_Placa
		    WHERE
		    	Id_Tipo_Placa=@Id_Tipo_Placa
				
		else
		
			INSERT INTO dbo.Tipo_Placa
	           (Id_Tipo_Placa
	           ,Nombre_Tipo_Placa)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Placa)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Placa_Select')
DROP PROCEDURE SP_Tipo_Placa_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipo_Placa_Select 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Placa char(4)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id_Tipo_Placa
	      ,Nombre_Tipo_Placa
	FROM dbo.Tipo_Placa
	where Id_Tipo_Placa=@Id_Tipo_Placa
END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Transporte_Delete')
DROP PROCEDURE SP_Tipo_Transporte_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Transporte_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Transporte char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.Tipo_Transporte where Id_Tipo_Transporte=@Id_Tipo_Transporte

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Transporte_Insert')
DROP PROCEDURE SP_Tipo_Transporte_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Tipo_Transporte_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Tipo_Transporte char(4),
	@Nombre_Tipo_Transporte varchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(4)
		select @maximo=right('0000'+ isnull(max(Id_Tipo_Transporte),0)+1,4) from dbo.Tipo_Transporte

		declare @Existe int
		select @Existe = count(Id_Tipo_Transporte) from dbo.Tipo_Transporte a where (a.Id_Tipo_Transporte=@Id_Tipo_Transporte)

		if @Existe>0 
		
			UPDATE dbo.Tipo_Transporte
		        SET Nombre_Tipo_Transporte=@Nombre_Tipo_Transporte
		    WHERE
		    	Id_Tipo_Transporte=@Id_Tipo_Transporte
				
		else
		
			INSERT INTO dbo.Tipo_Transporte
	           (Id_Tipo_Transporte
	           ,Nombre_Tipo_Transporte)
	     	VALUES
	           (@maximo
	           ,@Nombre_Tipo_Transporte)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipo_Transporte_Select')
DROP PROCEDURE SP_Tipo_Transporte_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipo_Transporte_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Tipo_Transporte
	      ,Nombre_Tipo_Transporte 
		from Tipo_Transporte

END
GO

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_TipoPersona_Delete')
DROP PROCEDURE SP_TipoPersona_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_TipoPersona_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_TipoPersona char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.TipoPersona where Id_TipoPersona=@Id_TipoPersona

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_TipoPersona_Insert')
DROP PROCEDURE SP_TipoPersona_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_TipoPersona_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_TipoPersona char(4),
	@TipoPersona varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(6)
		select @maximo=right(Concat('0000', isnull(max(Id_TipoPersona),0)+1),4) from dbo.TipoPersona

		declare @Existe int
		select @Existe = count(Id_TipoPersona) from dbo.TipoPersona a where (a.Id_TipoPersona=@Id_TipoPersona)

		if @Existe>0 
		
			UPDATE dbo.TipoPersona
		        SET TipoPersona=@TipoPersona
		    WHERE
		    	Id_TipoPersona=@Id_TipoPersona
				
		else
		
			INSERT INTO dbo.TipoPersona
	           (Id_TipoPersona
	           ,TipoPersona)
	     	VALUES
	           (@maximo
	           ,@TipoPersona)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_TipoPersona_Select')
DROP PROCEDURE SP_TipoPersona_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_TipoPersona_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_TipoPersona
	      ,TipoPersona
		from TipoPersona 
		

END
GO

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipos_Activos_Select')
DROP PROCEDURE SP_Tipos_Activos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipos_Activos_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Tipo_Activo
	      ,Nombre_Tipo_Activo 
		from Tipo_Activo

END
GO

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipos_Empleados_Select')
DROP PROCEDURE SP_Tipos_Empleados_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipos_Empleados_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Tipo_Empleado
	      ,Nombre_Tipo_Empleado 
		from Tipo_Empleado

END
GO

GO
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Tipos_Placas_Select')
DROP PROCEDURE SP_Tipos_Placas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Tipos_Placas_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Tipo_Placa
	      ,Nombre_Tipo_Placa 
		from Tipo_Placa

END
GO

GO
