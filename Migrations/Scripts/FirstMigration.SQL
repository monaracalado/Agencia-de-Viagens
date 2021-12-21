IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(40) NOT NULL,
    [CPF] char(11) NOT NULL,
    [Nascimento] date NOT NULL,
    [Email] char(40) NOT NULL,
    [Sexo] text NOT NULL,
    [Telefone1] char(15) NOT NULL,
    [Telefone2] char(15) NOT NULL,
    [Origem] text NOT NULL,
    [Destino] text NOT NULL,
    [DataIda] date NOT NULL,
    [DataVolta] date NOT NULL,
    [Situacao] nvarchar(9) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211221011956_FirstMigration', N'6.0.1');
GO

COMMIT;
GO

