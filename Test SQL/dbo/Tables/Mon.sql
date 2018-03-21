CREATE TABLE [dbo].[Mon] (
    [MaMon]  INT           IDENTITY (1, 1) NOT NULL,
    [TenMon] NVARCHAR (50) NOT NULL,
    [Note]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Mon] PRIMARY KEY CLUSTERED ([MaMon] ASC)
);

