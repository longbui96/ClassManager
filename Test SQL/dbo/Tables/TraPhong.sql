CREATE TABLE [dbo].[TraPhong] (
    [MaTP]     INT           IDENTITY (1, 1) NOT NULL,
    [TenNgTra] NVARCHAR (50) NULL,
    [MSSV/GV]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_TraPhong] PRIMARY KEY CLUSTERED ([MaTP] ASC)
);

