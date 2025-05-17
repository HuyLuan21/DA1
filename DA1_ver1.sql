CREATE DATABASE DA1_ver1
GO
USE DA1_ver1
GO
-- Tạo bảng TheLoaiPhim đầu tiên
CREATE TABLE TheLoaiPhim(
    MaTLP INT PRIMARY KEY,
    TenTLP NVARCHAR(100)
);

-- Tạo bảng Phim (cần tham chiếu đến TheLoaiPhim)
CREATE TABLE Phim(
    MaPhim INT PRIMARY KEY,
    TenPhim NVARCHAR(200),
    MoTa TEXT,
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
    MaPhongChieu INT PRIMARY KEY,
    TenPhong NVARCHAR(100),
    TongSoGhe INT,
    SoHangGhe INT,
    SoGhe1Hang INT
);

-- Tạo bảng GheNgoi (cần tham chiếu đến PhongChieu)
CREATE TABLE GheNgoi(
    MaGheNgoi INT PRIMARY KEY,
    HangGhe CHAR(2) NOT NULL,  -- A, B, AA, BB, ...
    SoGhe INT NOT NULL,        -- 1, 2, 11, 22, ...
    LoaiGheNgoi NVARCHAR(30),  -- Thường, vip, blabla
    TrangThai NVARCHAR(20),    -- Trống, không trống, ngừng khai thác
    MaPhongChieu INT,
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
);

-- Tạo bảng CaChieu (cần tham chiếu đến PhongChieu và Phim)
CREATE TABLE CaChieu(
    MaCaChieu INT PRIMARY KEY,
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
    MaVe INT PRIMARY KEY,
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
    SoDienThoai VARCHAR(15),
    DiemTichLuy INT,
    CCCD CHAR(12)
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    CMND_CCCD CHAR(12)
);
ALTER TABLE NhanVien ADD TrangThai bit DEFAULT 1;
UPDATE NhanVien SET TrangThai = 1;
-- Tạo bảng TaiKhoan (cần tham chiếu đến NhanVien)
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255),
    LoaiTK int,
    MaNV INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo bảng HoaDon (cần tham chiếu đến NhanVien và KhachHang)
CREATE TABLE HoaDon(
    MaHoaDon INT PRIMARY KEY,
    NgayBan DATETIME,
    TongTien FLOAT,
    MaNhanVien INT,
    MaKhachHang INT,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng ChiTietHoaDon (cần tham chiếu đến HoaDon và Ve)
CREATE TABLE ChiTietHoaDon(
    MaCTHoaDon INT PRIMARY KEY,
    MaHoaDon INT,
    MaVe INT,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaVe) REFERENCES Ve(MaVe)
);


--- cơ bản là thế này, đọc xem có cần chỉnh sửa ở đâu ko xong viết nốt trigger thêm xóa sửa nh
--du lieu mau
INSERT INTO TheLoaiPhim (MaTLP, TenTLP) 
VALUES 
(1, 'Hành động'),
(2, 'Hài'),
(3, 'Kinh dị'),
(4, 'Lãng mạn');

INSERT INTO Phim (MaPhim, TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, QuocGia, DaoDien, GioiHanTuoi, NamSX, MaTLP) 
VALUES 
(1, N'Avengers: Endgame', N'Cuộc chiến cuối cùng của các Avengers chống lại Thanos', 181, '2019-04-26', '2019-04-26', N'Mỹ', 'Anthony Russo, Joe Russo', 13, 2019, 1),
(2, N'Spider-Man: No Way Home', N'Peter Parker phải đối mặt với những rắc rối khi các nhân vật từ các vũ trụ khác xuất hiện', 148, '2021-12-17', '2021-12-17', N'Mỹ', 'Jon Watts', 13, 2021, 1),
(3, N'A Quiet Place', N'Một gia đình sống trong im lặng để tránh khỏi quái vật', 95, '2018-04-06', '2018-04-06', N'Mỹ', 'John Krasinski', 18, 2018, 3),
(4, N'The Notebook', N'Một câu chuyện tình yêu giữa Noah và Allie', 123, '2004-06-25', '2004-06-25', N'Mỹ', 'Nick Cassavetes', 13, 2004, 4);

INSERT INTO Phim_theloai (MaTLP, MaPhim)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(1, 2),
(4, 1);

INSERT INTO PhongChieu (MaPhongChieu, TenPhong, TongSoGhe, SoHangGhe, SoGhe1Hang)
VALUES 
(1, 'Phong 1', 100, 10, 10),
(2, 'Phong 2', 150, 15, 10);

INSERT INTO GheNgoi (MaGheNgoi, HangGhe, SoGhe, LoaiGheNgoi, TrangThai, MaPhongChieu)
VALUES 
(1, 'A', 1, 'Thường', 'Trống', 1),
(2, 'A', 2, 'VIP', 'Trống', 1),
(3, 'B', 1, 'Thường', 'Không trống', 2),
(4, 'B', 2, 'VIP', 'Trống', 2);

INSERT INTO CaChieu (MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, GiaVe, MaPhongChieu, MaPhim)
VALUES
(1, '2023-05-10 18:00:00', '2023-05-10 20:30:00', 120000, 1, 1),
(2, '2023-05-10 20:30:00', '2023-05-10 23:00:00', 100000, 2, 2);

INSERT INTO Ve (MaVe, MaCaChieu, MaGheNgoi)
VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 4);

INSERT INTO KhachHang (HoTen, NamSinh, SoDienThoai, DiemTichLuy, CCCD)
VALUES 
('Nguyễn Văn A', 1990, '0987654321', 100, '123456789012'),
('Trần Thị B', 1985, '0912345678', 200, '234567890123');

INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
VALUES 
(1, N'Lê Minh C', '1980-05-20', 'Hà Nội', '0912345679', '987654321012'),
(2, N'Phạm Thị D', '1990-07-15', 'Hồ Chí Minh', '0931234567', '876543210123');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTK, MaNV)
VALUES
('user1', 'password1', 1, 1),
('user2', 'password2', 2, 2);

INSERT INTO HoaDon (MaHoaDon, NgayBan, TongTien, MaNhanVien, MaKhachHang)
VALUES
(1, '2023-05-10 18:30:00', 240000, 1, 1),
(2, '2023-05-10 20:45:00', 200000, 2, 2);

INSERT INTO ChiTietHoaDon (MaCTHoaDon, MaHoaDon, MaVe)
VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 4);
SELECT MaNhanVien AS "Mã nhân viên",HoTen AS "Họ tên",NgaySinh AS"Ngày sinh",DiaChi AS"Địa chỉ",SoDienThoai AS"Số điện thoại",CMND_CCCD AS "CCCD" FROM NhanVien

SELECT MaPhim AS "Mã phim",TenPhim AS "Tên phim",Mota AS" Mô tả" ,ThoiLuong AS"Thời lượng", NgayKhoiChieu AS "Ngày khởi chiếu",NgayKetThuc AS "Ngày kết thúc",QuocGia AS"Quốc gia",NamSX AS"Năm sản xuất" from phim
go  
CREATE TRIGGER insert_nv
ON NhanVien
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaxMa INT;
    SELECT @MaxMa = ISNULL(MAX(MaNhanVien), 0) FROM NhanVien;

    DECLARE @Temp TABLE (
        MaNhanVien INT,
        HoTen NVARCHAR(100),
        NgaySinh DATE,
        DiaChi NVARCHAR(200),
        SoDienThoai VARCHAR(15),
        CMND_CCCD NVARCHAR(12)
    );

    INSERT INTO @Temp (MaNhanVien, HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
    SELECT
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) + @MaxMa AS MaNhanVien,
        HoTen,
        NgaySinh,
        DiaChi,
        SoDienThoai,
        CMND_CCCD
    FROM inserted;

    INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
    SELECT MaNhanVien, HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD FROM @Temp;
END;
INSERT INTO NhanVien (MaNhanVien,HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
                         VALUES (1,
                                N'Lê Minh C', 
                                '1980-05-20', 
                                N'Hà Nội', 
                                '0912345679', 
                                '987654321012');

                                INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
VALUES 
(1, N'Lê Minh C', '1980-05-20', N'Hà Nội', '0912345679', '987654321012'),
(2, N'Phạm Thị D', '1990-07-15', N'Hồ Chí Minh', '0931234567', '876543210123');

-- truy van phim theo ca chieu
SELECT * from CaChieu
SELECT * FROM Phim
SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p 
on cc.MaPhim = p.MaPhim
SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p on cc.MaPhim = p.MaPhim WHERE p.TenPhim = 'Avengers: Endgame'
SELECT tlp.TenTLP FROM Phim p INNER JOIN Phim_theloai pt ON p.MaPhim = pt.MaPhim 
INNER JOIN TheLoaiPhim tlp ON pt.MaTLP = tlp.MaTLP WHERE p.MaPhim = 2
SELECT MaPhim AS "Mã phim", TenPhim AS "Tên phim", Mota AS "Mô tả", ThoiLuong AS "Thời lượng", NgayKhoiChieu AS "Ngày khởi chiếu", NgayKetThuc AS "Ngày kết thúc", QuocGia AS "Quốc gia",DaoDien AS"Đạo diễn",GioiHanTuoi AS"Giới hạn tuổi", NamSX AS "Năm sản xuất" FROM phim;