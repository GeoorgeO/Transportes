USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Transportes'))
BEGIN
	create Database Transportes
END