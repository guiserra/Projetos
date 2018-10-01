CREATE TABLE [dbo].[Projeto] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (50) NOT NULL,
    [Tipo] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

