-- Tạo và sử dụng database
CREATE DATABASE DA1_ver1
GO
USE DA1_ver1
GO

-- Tạo các bảng
-- Tạo bảng TheLoaiPhim đầu tiên
CREATE TABLE TheLoaiPhim(
    MaTLP INT IDENTITY(1,1) PRIMARY KEY,
    TenTLP NVARCHAR(100)
);

-- Tạo bảng Phim (cần tham chiếu đến TheLoaiPhim)
CREATE TABLE Phim(
    MaPhim INT IDENTITY(1,1) PRIMARY KEY,
    TenPhim NVARCHAR(200),
    MoTa NVARCHAR(MAX),
    ThoiLuong INT,
    NgayKhoiChieu DATE,
    NgayKetThuc DATE,
    QuocGia NVARCHAR(100),
    DaoDien NVARCHAR(100),
    GioiHanTuoi INT,
    NamSX INT,
    MaTLP INT,
);

-- Tạo bảng Phim_theloai (cần tham chiếu đến Phim và TheLoaiPhim)
CREATE TABLE Phim_theloai(
    MaTLP INT,
    MaPhim INT,
    PRIMARY KEY (MaTLP, MaPhim),
    FOREIGN KEY (MaTLP) REFERENCES TheLoaiPhim(MaTLP),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim)
);

-- Tạo bảng PhongChieu
CREATE TABLE PhongChieu(
    MaPhongChieu INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    TongSoGhe INT DEFAULT 100,
    SoHangGhe INT DEFAULT 10,
    SoGhe1Hang INT DEFAULT 10
);

-- Tạo bảng GheNgoi (cần tham chiếu đến PhongChieu)
CREATE TABLE GheNgoi(
    MaGheNgoi INT IDENTITY(1,1) PRIMARY KEY,
    HangGhe CHAR(1) NOT NULL,  -- A, B, C, D, E, F, G, H, I, J
    SoGhe INT NOT NULL,        -- 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    -- LoaiGheNgoi NVARCHAR(30),  -- Thường, vip, blabla
    TrangThai NVARCHAR(20),    -- Trống, không trống, ngừng khai thác
    MaPhongChieu INT,
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
);

-- Tạo bảng CaChieu (cần tham chiếu đến PhongChieu và Phim)
CREATE TABLE CaChieu(
    MaCaChieu INT IDENTITY(1,1) PRIMARY KEY,
    ThoiGianChieu DATETIME,
    ThoiGianKetThuc DATETIME,
    GiaVe FLOAT,
    MaPhongChieu INT,
    MaPhim INT,
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim)
);

-- Tạo bảng Ve (cần tham chiếu đến CaChieu và GheNgoi)
CREATE TABLE Ve(
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaCaChieu INT,
    MaGheNgoi INT,
    FOREIGN KEY (MaCaChieu) REFERENCES CaChieu(MaCaChieu),
    FOREIGN KEY (MaGheNgoi) REFERENCES GheNgoi(MaGheNgoi)
);

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NamSinh INT,
    SoDienThoai VARCHAR(10) UNIQUE CHECK (ISNUMERIC(SoDienThoai) = 1),
    DiemTichLuy INT,
    CCCD VARCHAR(12) UNIQUE CHECK (ISNUMERIC(CCCD) = 1),
    TrangThai BIT DEFAULT 1
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(10) UNIQUE CHECK (ISNUMERIC(SoDienThoai) = 1),
    CMND_CCCD VARCHAR(12) UNIQUE CHECK (ISNUMERIC(CMND_CCCD) = 1),
    TrangThai BIT DEFAULT 1
);

-- Tạo bảng TaiKhoan (cần tham chiếu đến NhanVien)
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255),
    LoaiTK INT DEFAULT 1,
    MaNV INT UNIQUE,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo bảng HoaDon (cần tham chiếu đến NhanVien và KhachHang)
CREATE TABLE HoaDon(
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayBan DATETIME,
    TongTien FLOAT,
    MaNhanVien INT,
    MaKhachHang INT,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng ChiTietHoaDon (cần tham chiếu đến HoaDon và Ve)
CREATE TABLE ChiTietHoaDon(
    MaCTHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT,
    MaVe INT,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaVe) REFERENCES Ve(MaVe)
);

-- Tạo các trigger
GO
-- Drop trigger if exists
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_UpdateGheNgoiStatus')
    DROP TRIGGER trg_UpdateGheNgoiStatus
GO

-- Trigger cập nhật trạng thái ghế khi thêm vé mới
CREATE TRIGGER trg_UpdateGheNgoiStatus
ON Ve
AFTER INSERT
AS
BEGIN
    UPDATE GheNgoi
    SET TrangThai = N'Đã đặt'
    FROM GheNgoi g
    INNER JOIN inserted i ON g.MaGheNgoi = i.MaGheNgoi
END
GO

-- Thêm dữ liệu mẫu
-- Dữ liệu mẫu cho TheLoaiPhim
INSERT INTO TheLoaiPhim (TenTLP) 
VALUES 
(N'Hành động'),
(N'Hài'),
(N'Kinh dị'),
(N'Lãng mạn'),
(N'Viễn tưởng'),
(N'Hoạt hình'),
(N'Tài liệu'),
(N'Phiêu lưu');

-- Dữ liệu mẫu cho Phim
INSERT INTO Phim (TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, QuocGia, DaoDien, GioiHanTuoi, NamSX, MaTLP) 
VALUES 
(N'Avengers: Endgame', N'Cuộc chiến cuối cùng của các Avengers chống lại Thanos', 181, '2024-04-26', '2024-05-26', N'Mỹ', N'Anthony Russo, Joe Russo', 13, 2019, 1),
(N'Spider-Man: No Way Home', N'Peter Parker phải đối mặt với những rắc rối khi các nhân vật từ các vũ trụ khác xuất hiện', 148, '2024-04-26', '2024-05-26', N'Mỹ', N'Jon Watts', 13, 2021, 1),
(N'A Quiet Place', N'Một gia đình sống trong im lặng để tránh khỏi quái vật', 95, '2024-04-26', '2024-05-26', N'Mỹ', N'John Krasinski', 18, 2018, 3),
(N'The Notebook', N'Một câu chuyện tình yêu giữa Noah và Allie', 123, '2024-04-26', '2024-05-26', N'Mỹ', N'Nick Cassavetes', 13, 2004, 4),
(N'Inception', N'Giấc mơ trong giấc mơ', 148, '2024-04-26', '2024-05-26', N'Mỹ', N'Christopher Nolan', 13, 2010, 5);

-- Dữ liệu mẫu cho Phim_theloai
INSERT INTO Phim_theloai (MaTLP, MaPhim)
VALUES
(1, 1), -- Avengers: Endgame - Hành động
(5, 1), -- Avengers: Endgame - Viễn tưởng
(1, 2), -- Spider-Man - Hành động
(5, 2), -- Spider-Man - Viễn tưởng
(3, 3), -- A Quiet Place - Kinh dị
(4, 4), -- The Notebook - Lãng mạn
(5, 5); -- Inception - Viễn tưởng

-- Dữ liệu mẫu cho PhongChieu
INSERT INTO PhongChieu (TenPhong)
VALUES 
(N'Phòng 1'),
(N'Phòng 2'),
(N'Phòng 3'),
(N'Phòng 4');

-- Dữ liệu mẫu cho GheNgoi
-- Thêm ghế cho tất cả các phòng
DECLARE @HangGhe CHAR(1)
DECLARE @SoGhe INT
DECLARE @MaPhongChieu INT = 1

WHILE @MaPhongChieu <= 4
BEGIN
    SET @HangGhe = 'A'
    WHILE @HangGhe <= 'J'
    BEGIN
        SET @SoGhe = 0
        WHILE @SoGhe <= 9
        BEGIN
            INSERT INTO GheNgoi (HangGhe, SoGhe, TrangThai, MaPhongChieu)
            VALUES (@HangGhe, @SoGhe, N'Trống', @MaPhongChieu)
            SET @SoGhe = @SoGhe + 1
        END
        SET @HangGhe = CHAR(ASCII(@HangGhe) + 1)
    END
    SET @MaPhongChieu = @MaPhongChieu + 1
END

-- Dữ liệu mẫu cho CaChieu
INSERT INTO CaChieu (ThoiGianChieu, ThoiGianKetThuc, GiaVe, MaPhongChieu, MaPhim)
VALUES
('2024-04-26 08:00:00', '2024-04-26 11:01:00', 120000, 1, 1),
('2024-04-26 13:00:00', '2024-04-26 15:28:00', 120000, 1, 2),
('2024-04-26 18:00:00', '2024-04-26 20:03:00', 150000, 2, 3),
('2024-04-26 20:30:00', '2024-04-26 22:33:00', 150000, 2, 4),
('2024-04-26 09:00:00', '2024-04-26 11:28:00', 120000, 3, 5);

-- Dữ liệu mẫu cho KhachHang
INSERT INTO KhachHang (HoTen, NamSinh, SoDienThoai, DiemTichLuy, CCCD)
VALUES 
(N'Nguyễn Văn A', 1990, '0987654321', 100, '123456789012'),
(N'Trần Thị B', 1985, '0912345678', 200, '234567890123'),
(N'Lê Văn C', 1995, '0923456789', 150, '345678901234'),
(N'Phạm Thị D', 2000, '0934567890', 50, '456789012345');

-- Dữ liệu mẫu cho NhanVien
INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
VALUES 
(N'Lê Minh C', '1980-05-20', N'Hà Nội', '0912345679', '987654321012'),
(N'Phạm Thị D', '1990-07-15', N'Hồ Chí Minh', '0931234567', '876543210123'),
(N'Nguyễn Văn E', '1992-03-10', N'Đà Nẵng', '0945678901', '765432109876'),
(N'Trần Thị F', '1988-11-25', N'Hải Phòng', '0956789012', '654321098765');

-- Dữ liệu mẫu cho TaiKhoan
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTK, MaNV)
VALUES
('admin', 'admin123', 1, 1),
('manager', 'manager123', 1, 2),
('staff1', 'staff123', 0, 3),
('staff2', 'staff123', 0, 4);

-- Dữ liệu mẫu cho Ve
INSERT INTO Ve (MaCaChieu, MaGheNgoi)
VALUES
(1, 1), -- Phòng 1, Ghế A1
(1, 2), -- Phòng 1, Ghế A2
(2, 21), -- Phòng 2, Ghế A1
(2, 22), -- Phòng 2, Ghế A2
(3, 41), -- Phòng 3, Ghế A1
(3, 42); -- Phòng 3, Ghế A2

-- Dữ liệu mẫu cho HoaDon
INSERT INTO HoaDon (NgayBan, TongTien, MaNhanVien, MaKhachHang)
VALUES
('2024-04-26 08:30:00', 240000, 1, 1),
('2024-04-26 13:30:00', 240000, 2, 2),
('2024-04-26 18:30:00', 300000, 3, 3);

-- Dữ liệu mẫu cho ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaVe)
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5),
(3, 6);

-- Các câu truy vấn mẫu
SELECT 
    g.MaGheNgoi,
    g.HangGhe + CAST(g.SoGhe AS VARCHAR) as MaGhe,
    CASE 
        WHEN v.MaVe IS NOT NULL THEN N'Đã đặt'
        ELSE N'Trống'
    END as TrangThai
FROM GheNgoi g
INNER JOIN PhongChieu pc ON g.MaPhongChieu = pc.MaPhongChieu
INNER JOIN CaChieu cc ON pc.MaPhongChieu = cc.MaPhongChieu
LEFT JOIN Ve v ON g.MaGheNgoi = v.MaGheNgoi AND v.MaCaChieu = 2
WHERE cc.MaCaChieu = 2
ORDER BY g.HangGhe, g.SoGhe;

SELECT g.MaGheNgoi,g.HangGhe + CAST(g.SoGhe AS VARCHAR) as MaGhe,
                            CASE 
                            WHEN v.MaVe IS NOT NULL THEN N'Đã đặt'
                            ELSE N'Trống'
                            END as TrangThai
                            FROM GheNgoi g
                            INNER JOIN PhongChieu pc ON g.MaPhongChieu = pc.MaPhongChieu
                            INNER JOIN CaChieu cc ON pc.MaPhongChieu = cc.MaPhongChieu
                            LEFT JOIN Ve v ON g.MaGheNgoi = v.MaGheNgoi AND v.MaCaChieu = 2
                            WHERE cc.MaCaChieu = 2
                            ORDER BY g.HangGhe, g.SoGhe
-- Kiểm tra dữ liệu
--toan bo ghe dat dat
SELECT 
    v.MaVe AS "Mã vé",
    pc.TenPhong AS "Tên phòng",
    g.HangGhe + CAST(g.SoGhe AS VARCHAR) AS "Vị trí ghế",
    p.TenPhim AS "Tên phim",
    cc.ThoiGianChieu AS "Thời gian chiếu",
    cc.ThoiGianKetThuc AS "Thời gian kết thúc",
    cc.GiaVe AS "Giá vé"
FROM Ve v
INNER JOIN GheNgoi g ON v.MaGheNgoi = g.MaGheNgoi
INNER JOIN PhongChieu pc ON g.MaPhongChieu = pc.MaPhongChieu
INNER JOIN CaChieu cc ON v.MaCaChieu = cc.MaCaChieu
INNER JOIN Phim p ON cc.MaPhim = p.MaPhim
ORDER BY pc.TenPhong, cc.ThoiGianChieu, g.HangGhe, g.SoGhe;
SELECT * FROM PhongChieu;
SELECT * FROM GheNgoi;


-- Test trigger bằng cách thêm vé mới
INSERT INTO Ve (MaCaChieu, MaGheNgoi) VALUES (1, 1);

-- Thêm vé cho ghế đã đặt
INSERT INTO Ve (MaCaChieu, MaGheNgoi)
SELECT 1, MaGheNgoi
FROM GheNgoi 
WHERE MaPhongChieu = 1 AND TrangThai = N'Đã đặt';

INSERT INTO Ve (MaCaChieu, MaGheNgoi)
SELECT 2, MaGheNgoi
FROM GheNgoi 
WHERE MaPhongChieu = 2 AND TrangThai = N'Đã đặt';

-- Kiểm tra vé đã tạo
SELECT v.MaVe, v.MaCaChieu, g.HangGhe + CAST(g.SoGhe AS VARCHAR) as MaGhe, g.MaPhongChieu
FROM Ve v
JOIN GheNgoi g ON v.MaGheNgoi = g.MaGheNgoi
ORDER BY v.MaCaChieu, g.HangGhe, g.SoGhe;

SELECT MaNhanVien AS "Mã nhân viên",HoTen AS "Họ tên",NgaySinh AS"Ngày sinh",DiaChi AS"Địa chỉ",SoDienThoai AS"Số điện thoại",CMND_CCCD AS "CCCD" FROM NhanVien

SELECT MaPhim AS "Mã phim",TenPhim AS "Tên phim",Mota AS" Mô tả" ,ThoiLuong AS"Thời lượng", NgayKhoiChieu AS "Ngày khởi chiếu",NgayKetThuc AS "Ngày kết thúc",QuocGia AS"Quốc gia",NamSX AS"Năm sản xuất" from phim
go  


-- truy van phim theo ca chieu
SELECT * from CaChieu
SELECT * FROM Phim
SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p 
on cc.MaPhim = p.MaPhim
SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p on cc.MaPhim = p.MaPhim WHERE p.TenPhim = 'Avengers: Endgame'
SELECT tlp.TenTLP FROM Phim p INNER JOIN Phim_theloai pt ON p.MaPhim = pt.MaPhim 
INNER JOIN TheLoaiPhim tlp ON pt.MaTLP = tlp.MaTLP WHERE p.MaPhim = 2
SELECT MaPhim AS "Mã phim", TenPhim AS "Tên phim", Mota AS "Mô tả", ThoiLuong AS "Thời lượng", NgayKhoiChieu AS "Ngày khởi chiếu", NgayKetThuc AS "Ngày kết thúc", QuocGia AS "Quốc gia",DaoDien AS"Đạo diễn",GioiHanTuoi AS"Giới hạn tuổi", NamSX AS "Năm sản xuất" FROM phim;
SELECT * FROM TaiKhoan
SELECT TenDangNhap AS " Tên đăng nhập",MatKhau AS "Mật khẩu",LoaiTK AS "Loại TK",MaNV AS "Mã nhân viên" FROM TaiKhoan

SELECT * from PhongChieu
SELECT MaPhongChieu AS "Mã phòng chiếu",TenPhong AS "Tên phòng",TongSoGhe AS "Tổng số ghế" ,SoHangGhe AS "Số hàng ghế",SoGhe1Hang AS "Số ghế 1 hàng" FROM PhongChieu
SELECT * FROM CaChieu 
SELECT
    cc.MaCaChieu AS "Mã ca chiếu",
    p.MaPhim AS "Mã Phim",
    p.TenPhim AS "Tên Phim",
    pc.TenPhong AS "Phòng chiếu",
    cc.ThoiGianChieu AS "Thời gian chiếu",
    cc.ThoiGianKetThuc AS "Thời gian kết thúc",
    cc.GiaVe AS "Giá"
FROM
    CaChieu cc
JOIN
    Phim p ON cc.MaPhim = p.MaPhim
JOIN
    PhongChieu pc ON cc.MaPhongChieu = pc.MaPhongChieu;


    SELECT TenPhim FROM Phim
    SELECT TenPhong FROM PhongChieu

    INSERT Into CaChieu (MaCaChieu,ThoiGianChieu,ThoiGianKetThuc,GiaVe,MaPhongChieu,MaPhim)
    VALUES (1,'2023-05-10 18:00:00','2023-05-10 20:30:00',120000,1,1)

 
     SELECT 
         g.MaGheNgoi,
         g.HangGhe + CAST(g.SoGhe AS VARCHAR) as MaGhe,
         CASE 
             WHEN v.MaVe IS NOT NULL THEN N'Đã đặt'
             ELSE N'Trống'
         END as TrangThai
     FROM GheNgoi g
     INNER JOIN PhongChieu pc ON g.MaPhongChieu = pc.MaPhongChieu
     INNER JOIN CaChieu cc ON pc.MaPhongChieu = cc.MaPhongChieu
     LEFT JOIN Ve v ON g.MaGheNgoi = v.MaGheNgoi AND v.MaCaChieu = 1
     WHERE cc.MaCaChieu = 1
     ORDER BY g.HangGhe, g.SoGhe

     SELECT * FROM GheNgoi
SELECT * from CaChieu
SELECT * FROM Ve
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon
SELECT * FROM KhachHang
SELECT * FROM NhanVien
SELECT * FROM TaiKhoan
SELECT * from PhongChieu
SELECT * from GheNgoi


-- Thêm ghế cho phòng 1 (100 ghế)
-- DECLARE @HangGhe CHAR(1)
-- DECLARE @SoGhe INT
-- DECLARE @MaPhongChieu INT = 1

-- SET @HangGhe = 'A'
-- WHILE @HangGhe <= 'J'
-- BEGIN
--     SET @SoGhe = 0
--     WHILE @SoGhe <= 9
--     BEGIN
--         INSERT INTO GheNgoi (HangGhe, SoGhe, LoaiGheNgoi, TrangThai, MaPhongChieu)
--         VALUES (@HangGhe, @SoGhe, N'Thường', N'Trống', @MaPhongChieu)
--         SET @SoGhe = @SoGhe + 1
--     END
--     SET @HangGhe = CHAR(ASCII(@HangGhe) + 1)
-- END

-- Trigger cập nhật trạng thái ghế khi thêm vé mới
select * from PhongChieu
select * from GheNgoi
select * from CaChieu
select * from Ve
select * from HoaDon
select * from ChiTietHoaDon
select * from KhachHang
select * from NhanVien
select * from TaiKhoan
select * from HoaDon