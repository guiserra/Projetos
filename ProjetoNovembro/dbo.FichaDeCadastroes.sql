﻿CREATE TABLE [dbo].[FichaDeCadastroes] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Nome]              NVARCHAR (50)  NOT NULL,
    [Sexo]              NVARCHAR (1)   NOT NULL,
    [Endereco]          NVARCHAR (50)  NOT NULL,
    [NumeroCasa]        INT            NOT NULL,
    [Complemento]       NVARCHAR (20)  NOT NULL,
    [Cep]               INT            NOT NULL,
    [Bairro]            NVARCHAR (50)  NOT NULL,
    [Cidade]            NVARCHAR (20)  NOT NULL,
    [Regiao]            NVARCHAR (20)  NOT NULL,
    [Estado]            NVARCHAR (20)  NOT NULL,
    [DataNascimento]    DATE       NOT NULL,
    [LocalNascimento]   NVARCHAR (50)  NOT NULL,
    [EstadoCivil]       NVARCHAR (20)  NOT NULL,
    [Raca]              NVARCHAR (10)  NOT NULL,
    [Email]             NVARCHAR (20)  NULL,
    [NumTelefoneRes]    INT            NULL,
    [NumCelular]        INT            NULL,
    [Rg]                INT            NOT NULL,
    [RgDataExpe]        DATE       NOT NULL,
    [RgOrgaoEmissor]    NVARCHAR (10)  NOT NULL,
    [Cpf]               INT            NOT NULL,
    [NomeMae]           NVARCHAR (50)  NOT NULL,
    [NomePai]           NVARCHAR (50)  NOT NULL,
    [Pis]               INT            NULL,
    [Dependentes]       NVARCHAR (300) NULL,
    [TrabalhouResource] NVARCHAR (20) NOT NULL,
    [Idioma]            NVARCHAR (30)  NULL,
    CONSTRAINT [PK_dbo.FichaDeCadastroes] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Pis] ASC),
    UNIQUE NONCLUSTERED ([Cpf] ASC),
    UNIQUE NONCLUSTERED ([Rg] ASC)
);
