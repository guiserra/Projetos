CREATE TABLE [dbo].[Sprint] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (50)  NOT NULL,
    [Descricao] NVARCHAR (MAX) NOT NULL,
    [Duracao]   INT            NOT NULL,
    [DtInicio]  DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

