CREATE TABLE [dbo].[Phong] (
    [MaPhong]  INT           IDENTITY (1, 1) NOT NULL,
    [TenPhong] NVARCHAR (50) NOT NULL,
    [MayChieu] BIT           NOT NULL,
    [AmThanh]  BIT           NOT NULL,
    [AnhSang]  BIT           NOT NULL,
    [MayLanh]  BIT           NOT NULL,
    [Ro]       BIT           NOT NULL,
    [SucChua]  INT           NOT NULL,
    CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED ([MaPhong] ASC)
);

