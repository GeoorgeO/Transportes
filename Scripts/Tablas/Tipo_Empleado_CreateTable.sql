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