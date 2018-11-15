CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (1000)  NOT NULL,
    [ContextKey]     NVARCHAR (1000)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (64)   NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC)
);

