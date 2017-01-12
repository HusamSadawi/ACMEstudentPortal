CREATE TABLE [dbo].[Students] (
    [studentID]      INT            IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (50)  NOT NULL,
    [sex]            NVARCHAR (MAX) NOT NULL,
    [email]          NVARCHAR (MAX) NOT NULL,
    [dateOfBirth]    DATE       NOT NULL,
    [nationality]    NVARCHAR (50)  NOT NULL,
    [mobile]         NVARCHAR (12)  NOT NULL,
    [course]         NVARCHAR (50)  NOT NULL,
    [graduationYear] INT            NOT NULL,
    [major]          NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([studentID] ASC)
);

