CREATE DATABASE PetStock;
GO

USE PetStock;

CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),-- Chave primária
    Nome NVARCHAR(100) NOT NULL,-- Nome do cliente
    Email NVARCHAR(150) UNIQUE NOT NULL,-- Email único e obrigatório
    Telefone NVARCHAR(20),-- Telefone opcional
    Endereco NVARCHAR(255),-- Endereço opcional
    DataCadastro DATETIME DEFAULT GETDATE() -- Data de cadastro
);

CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),-- Chave primária
    Nome NVARCHAR(100) NOT NULL,-- Nome do usuário
    Email NVARCHAR(150) UNIQUE NOT NULL,-- Email único e obrigatório
    SenhaHash NVARCHAR(255) NOT NULL,-- Senha hash
    DataCadastro DATETIME DEFAULT GETDATE(),-- Data de cadastro
    Perfil NVARCHAR(50) NOT NULL -- Perfil (exemplo: 'Administrador','Colaborador')
);

CREATE TABLE Categoria (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255),
    SoftDelete BIT DEFAULT 0 
);

CREATE TABLE Produto (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255),
    CategoriaId INT NOT NULL FOREIGN KEY REFERENCES Categoria(Id),
    PrecoCusto DECIMAL(10,2) NOT NULL,
    QuantidadeEstoque INT NOT NULL,
    SoftDelete BIT DEFAULT 0
);

CREATE TABLE Venda ( 
    Id INT PRIMARY KEY IDENTITY(1,1),-- Chave primária 
    ClienteId INT FOREIGN KEY REFERENCES Cliente(Id),-- Chave estrangeira 
    DataVenda DATETIME DEFAULT GETDATE(),-- Data da venda 
    Total DECIMAL(10,2) NOT NULL,-- Valor total da venda 
    SoftDelete BIT DEFAULT 0 -- SoftDelete 
);

CREATE TABLE ItemVenda ( 
    Id INT PRIMARY KEY IDENTITY(1,1),-- Chave primária 
    VendaId INT NOT NULL FOREIGN KEY REFERENCES Venda(Id),-- Chave estrangeira 
    ProdutoId INT NOT NULL FOREIGN KEY REFERENCES Produto(Id),-- Chave estrangeira 
    Quantidade INT NOT NULL,-- Quantidade de produtos vendidos 
    PrecoUnitario DECIMAL(10,2) NOT NULL,-- Preço unitário no momento da venda 
    Subtotal AS (Quantidade * PrecoUnitario) PERSISTED -- Subtotal calculado 
);

CREATE TABLE MovimentacoesEstoque ( 
    Id INT PRIMARY KEY IDENTITY,
    ProdutoId INT NOT NULL FOREIGN KEY REFERENCES Produto(Id),
    Tipo NVARCHAR(10) CHECK (Tipo IN ('Entrada','Saida')),
    Quantidade INT NOT NULL,
    Data DATETIME NOT NULL DEFAULT GETDATE() 
);