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