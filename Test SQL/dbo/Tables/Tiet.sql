CREATE TABLE [dbo].[Tiet] (
    [MaTiet]  INT           IDENTITY (1, 1) NOT NULL,
    [TenTiet] NVARCHAR (50) NOT NULL,
    [Ca]      INT           NOT NULL,
    CONSTRAINT [PK_Tiet] PRIMARY KEY CLUSTERED ([MaTiet] ASC)
);

