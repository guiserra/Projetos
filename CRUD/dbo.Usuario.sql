CREATE TABLE [dbo].[Usuario] (
    [Codigo] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   NVARCHAR (50) NOT NULL,
    [Login]  NVARCHAR (50) NOT NULL,
    [Senha]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

