
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/24/2022 10:21:17
-- Generated from EDMX file: C:\Users\mcordoba\source\repos\AIP_SCP\SCP_ADO\Modelo\SCP_USERDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AIP_SCP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [contraseña] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Nuevos_Usuarios'
CREATE TABLE [dbo].[Nuevos_Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [ncarnet] nvarchar(max)  NOT NULL,
    [puesto] nvarchar(max)  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Nuevos_Usuarios'
ALTER TABLE [dbo].[Nuevos_Usuarios]
ADD CONSTRAINT [PK_Nuevos_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId] in table 'Nuevos_Usuarios'
ALTER TABLE [dbo].[Nuevos_Usuarios]
ADD CONSTRAINT [FK_UsuarioNuevos_Usuario]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioNuevos_Usuario'
CREATE INDEX [IX_FK_UsuarioNuevos_Usuario]
ON [dbo].[Nuevos_Usuarios]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------