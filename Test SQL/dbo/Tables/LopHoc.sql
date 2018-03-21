CREATE TABLE [dbo].[LopHoc] (
    [MaLH]   INT           IDENTITY (1, 1) NOT NULL,
    [MaMon]  INT           NOT NULL,
    [TenLop] NVARCHAR (50) NOT NULL,
    [MaGV]   INT           NOT NULL,
    [NgayBD] DATE          NULL,
    [NgayKT] DATE          NULL,
    CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED ([MaLH] ASC),
    CONSTRAINT [FK_LopHoc_GiangVien] FOREIGN KEY ([MaGV]) REFERENCES [dbo].[GiangVien] ([MaGV]),
    CONSTRAINT [FK_LopHoc_Mon] FOREIGN KEY ([MaMon]) REFERENCES [dbo].[Mon] ([MaMon])
);

