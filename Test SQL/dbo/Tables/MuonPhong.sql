CREATE TABLE [dbo].[MuonPhong] (
    [MaMP]      INT           IDENTITY (1, 1) NOT NULL,
    [TenNgMuon] NVARCHAR (50) NOT NULL,
    [MSSV/GV]   NVARCHAR (50) NOT NULL,
    [Note]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_MuonPhong] PRIMARY KEY CLUSTERED ([MaMP] ASC)
);

