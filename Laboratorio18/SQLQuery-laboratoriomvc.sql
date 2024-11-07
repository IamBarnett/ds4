CREATE DATABASE laboratoriomvc;
GO

USE laboratoriomvc;
GO

CREATE TABLE [User] (
	id INT PRIMARY KEY IDENTITY(1,1),
	email NVARCHAR(255) NOT NULL,
	password NVARCHAR(255) NOT NULL
	);
	GO