IF EXISTS (SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'TechSupport')
BEGIN
    DROP DATABASE TechSupport
END
GO

CREATE DATABASE TechSupport
GO
