CREATE DATABASE [PetStock]
GO

USE [PetStock]
GO

CREATE TABLE [Client] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [Name] NVARCHAR(100) NOT NULL,
    [Email] NVARCHAR(150) UNIQUE NOT NULL,
    [Phone] NVARCHAR(20),
    [Address] NVARCHAR(255),
    [RegistrationDate] DATETIME DEFAULT GETDATE()
)
CREATE TABLE [UserRole] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [Name] NVARCHAR(100) NOT NULL,
)
CREATE TABLE [User] (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [Name] NVARCHAR(100) NOT NULL,
    [Email] NVARCHAR(150) UNIQUE NOT NULL,
    [Role] INT NOT NULL FOREIGN KEY REFERENCES [UserRole](Id),
    [PasswordHash] NVARCHAR(255) NOT NULL,
    [RegistrationDate] DATETIME DEFAULT GETDATE(),
)
CREATE TABLE [Category] (
    [Id] INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100) NOT NULL,
    [SoftDelete] BIT DEFAULT 0 
)
CREATE TABLE [Product] (
    [Id] INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(255),
    [CategoryId] INT NOT NULL FOREIGN KEY REFERENCES [Category](Id),
    [Price] DECIMAL(10,2) NOT NULL,
    [StockQuantity] INT NOT NULL,
    [SoftDelete] BIT DEFAULT 0
)
CREATE TABLE [Sale] ( 
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [ClientId] INT FOREIGN KEY REFERENCES [Client](Id),
    [SaleDate] DATETIME DEFAULT GETDATE(),
    [Total] DECIMAL(10,2) NOT NULL,
    [SoftDelete] BIT DEFAULT 0
)
CREATE TABLE [SaleItem] ( 
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [SaleId] INT NOT NULL FOREIGN KEY REFERENCES [Sale](Id),
    [ProductId] INT NOT NULL FOREIGN KEY REFERENCES [Product](Id),
    [Quantity] INT NOT NULL,
    [UnitPrice] DECIMAL(10,2) NOT NULL,
    [Subtotal] AS (Quantity * UnitPrice) PERSISTED
)
CREATE TABLE [StockTransaction] ( 
    [Id] INT PRIMARY KEY IDENTITY,
    [ProductId] INT NOT NULL FOREIGN KEY REFERENCES [Product](Id),
    [Type] NVARCHAR(10) CHECK ([Type] IN ('Entrance','Exit')),
    [Quantity] INT NOT NULL,
    [Date] DATETIME NOT NULL DEFAULT GETDATE() 
)
GO