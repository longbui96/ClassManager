CREATE TABLE [dbo].[TKBieu] (
    [MaPhong] INT  NOT NULL,
    [MaLH]    INT  NOT NULL,
    [TietBD]  INT  NOT NULL,
    [TietKT]  INT  NOT NULL,
    [Ngay]    DATE NOT NULL,
    [MaMP]    INT  NULL,
    [MaTP]    INT  NULL,
    CONSTRAINT [PK_TKBieu] PRIMARY KEY CLUSTERED ([MaPhong] ASC, [MaLH] ASC, [TietBD] ASC, [TietKT] ASC, [Ngay] ASC),
    CONSTRAINT [FK_TKBieu_LopHoc] FOREIGN KEY ([MaLH]) REFERENCES [dbo].[LopHoc] ([MaLH]),
    CONSTRAINT [FK_TKBieu_MuonPhong] FOREIGN KEY ([MaMP]) REFERENCES [dbo].[MuonPhong] ([MaMP]),
    CONSTRAINT [FK_TKBieu_Phong] FOREIGN KEY ([MaPhong]) REFERENCES [dbo].[Phong] ([MaPhong]),
    CONSTRAINT [FK_TKBieu_Tiet] FOREIGN KEY ([TietBD]) REFERENCES [dbo].[Tiet] ([MaTiet]),
    CONSTRAINT [FK_TKBieu_Tiet1] FOREIGN KEY ([TietKT]) REFERENCES [dbo].[Tiet] ([MaTiet]),
    CONSTRAINT [FK_TKBieu_TraPhong] FOREIGN KEY ([MaTP]) REFERENCES [dbo].[TraPhong] ([MaTP])
);

