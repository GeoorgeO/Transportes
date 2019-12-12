USE [Transportes]
GO
IF OBJECT_ID('Salidas_RevisionUnidad') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin
		
	CREATE TABLE [dbo].[Salidas_RevisionUnidad](
		[Id_Salida] [char](10) NOT NULL,
		[AceiteMotor] [bit] NOT NULL,
		[LiqDireccionHidraulica] [bit] NOT NULL,
		[Anticongelante] [bit] NOT NULL,
		[TCirculacion] [bit] NOT NULL,
		[TCombustible] [bit] NOT NULL,
		[TLicencia] [bit] NOT NULL,
		[LimpiezaInterior] [bit] NOT NULL,
		[PresionLlantas] [bit] NOT NULL,
		[Luces] [bit] NOT NULL,
		[CajaCampo] [bit] NOT NULL,
		[Combustible] [numeric](18,0)NOT NULL,
	 CONSTRAINT [PK_SalidasRevisionUnidad] PRIMARY KEY CLUSTERED 
	(
		[Id_Salida] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	end