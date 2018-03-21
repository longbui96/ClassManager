CREATE TABLE [dbo].[GiangVien] (
    [MaGV]  INT           IDENTITY (1, 1) NOT NULL,
    [TenGV] NVARCHAR (50) NOT NULL,
    [Note]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED ([MaGV] ASC)
);

