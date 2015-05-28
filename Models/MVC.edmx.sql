
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2015 16:28:40
-- Generated from EDMX file: G:\Xamarin Studio\AspNetMVC3\Models\MVC.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestePratico];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tbCidadetbEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbCidade] DROP CONSTRAINT [FK_tbCidadetbEstado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tbCidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCidade];
GO
IF OBJECT_ID(N'[dbo].[tbEstado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbEstado];
GO
IF OBJECT_ID(N'[dbo].[tbPessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPessoa];
GO
IF OBJECT_ID(N'[dbo].[tbProduto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbProduto];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tbCidades'
CREATE TABLE [dbo].[tbCidades] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Cidade] nvarchar(max)  NULL,
    [tbEstado_id] int  NOT NULL
);
GO

-- Creating table 'tbEstadoes'
CREATE TABLE [dbo].[tbEstadoes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tbPessoas'
CREATE TABLE [dbo].[tbPessoas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NULL,
    [cpf] nvarchar(11)  NULL,
    [telefone] varchar(50)  NULL,
    [email] nvarchar(max)  NULL,
    [rg] nvarchar(max)  NULL,
    [genero] char(10)  NULL,
    [dataNasc] datetime  NULL,
    [tbCidade_id] int  NOT NULL
);
GO

-- Creating table 'tbProdutoes'
CREATE TABLE [dbo].[tbProdutoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Produto] nvarchar(max)  NULL,
    [Fabricacao] datetime  NULL,
    [Validade] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'tbCidades'
ALTER TABLE [dbo].[tbCidades]
ADD CONSTRAINT [PK_tbCidades]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbEstadoes'
ALTER TABLE [dbo].[tbEstadoes]
ADD CONSTRAINT [PK_tbEstadoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbPessoas'
ALTER TABLE [dbo].[tbPessoas]
ADD CONSTRAINT [PK_tbPessoas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'tbProdutoes'
ALTER TABLE [dbo].[tbProdutoes]
ADD CONSTRAINT [PK_tbProdutoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [tbEstado_id] in table 'tbCidades'
ALTER TABLE [dbo].[tbCidades]
ADD CONSTRAINT [FK_tbCidadetbEstado]
    FOREIGN KEY ([tbEstado_id])
    REFERENCES [dbo].[tbEstadoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCidadetbEstado'
CREATE INDEX [IX_FK_tbCidadetbEstado]
ON [dbo].[tbCidades]
    ([tbEstado_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------