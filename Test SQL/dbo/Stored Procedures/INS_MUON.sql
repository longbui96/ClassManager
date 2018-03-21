
CREATE PROC INS_MUON @ten nvarchar(50), @ms nvarchar(50), @not nvarchar(50)
AS
BEGIN
	INSERT INTO MuonPhong (TenNgMuon, [MSSV/GV], Note) VALUES (@ten, @ms, @not)
END
