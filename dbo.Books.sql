CREATE TABLE [dbo].[Books] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Tittel] NVARCHAR (50) NULL,
    [Auther] NVARCHAR (50) NULL,
    [Price]  FLOAT (53)    NULL,
    [Cat]    NVARCHAR (50) NULL,
    [Date]   DATETIME      NULL,
    [Rate]   INT           NULL,
    [Cover]  IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

