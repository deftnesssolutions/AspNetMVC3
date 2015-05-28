
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2015 18:12:14
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

-- Creating table 'tbCidade'
CREATE TABLE [dbo].[tbCidade] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Cidade] nvarchar(max)  NULL,
    [tbEstado_id] int  NOT NULL
);
GO

-- Creating table 'tbEstado'
CREATE TABLE [dbo].[tbEstado] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tbPessoa'
CREATE TABLE [dbo].[tbPessoa] (
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

-- Creating table 'tbProduto'
CREATE TABLE [dbo].[tbProduto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Produto] nvarchar(max)  NULL,
    [Fabricacao] datetime  NULL,
    [Validade] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'tbCidade'
ALTER TABLE [dbo].[tbCidade]
ADD CONSTRAINT [PK_tbCidade]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbEstado'
ALTER TABLE [dbo].[tbEstado]
ADD CONSTRAINT [PK_tbEstado]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbPessoa'
ALTER TABLE [dbo].[tbPessoa]
ADD CONSTRAINT [PK_tbPessoa]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'tbProduto'
ALTER TABLE [dbo].[tbProduto]
ADD CONSTRAINT [PK_tbProduto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [tbEstado_id] in table 'tbCidade'
ALTER TABLE [dbo].[tbCidade]
ADD CONSTRAINT [FK_tbCidadetbEstado]
    FOREIGN KEY ([tbEstado_id])
    REFERENCES [dbo].[tbEstado]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbCidadetbEstado'
CREATE INDEX [IX_FK_tbCidadetbEstado]
ON [dbo].[tbCidade]
    ([tbEstado_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------