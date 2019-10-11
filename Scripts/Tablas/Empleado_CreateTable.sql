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