CREATE DATABASE DA1_ver1
GO
USE DA1_ver1
GO
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
    TongSoGhe INT,
    SoHangGhe INT,
    SoGhe1Hang INT
);

-- Tạo bảng GheNgoi (cần tham chiếu đến PhongChieu)
CREATE TABLE GheNgoi(
    MaGheNgoi INT IDENTITY(1,1) PRIMARY KEY,
    HangGhe CHAR(2) NOT NULL,  -- A, B, AA, BB, ...
    SoGhe INT NOT NULL,        -- 1, 2, 11, 22, ...
    LoaiGheNgoi NVARCHAR(30),  -- Thường, vip, blabla
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


--- cơ bản là thế này, đọc xem có cần chỉnh sửa ở đâu ko xong viết nốt trigger thêm xóa sửa nh
--du lieu mau
INSERT INTO TheLoaiPhim (TenTLP) 
VALUES 
(N'Hành động'),
(N'Hài'),
(N'Kinh dị'),
(N'Lãng mạn');

INSERT INTO Phim (TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, QuocGia, DaoDien, GioiHanTuoi, NamSX, MaTLP) 
VALUES 
(N'Avengers: Endgame', N'Cuộc chiến cuối cùng của các Avengers chống lại Thanos', 181, '2019-04-26', '2019-04-26', N'Mỹ', N'Anthony Russo, Joe Russo', 13, 2019, 1),
(N'Spider-Man: No Way Home', N'Peter Parker phải đối mặt với những rắc rối khi các nhân vật từ các vũ trụ khác xuất hiện', 148, '2021-12-17', '2021-12-17', N'Mỹ', N'Jon Watts', 13, 2021, 1),
(N'A Quiet Place', N'Một gia đình sống trong im lặng để tránh khỏi quái vật', 95, '2018-04-06', '2018-04-06', N'Mỹ', N'John Krasinski', 18, 2018, 3),
(N'The Notebook', N'Một câu chuyện tình yêu giữa Noah và Allie', 123, '2004-06-25', '2004-06-25', N'Mỹ', N'Nick Cassavetes', 13, 2004, 4);

INSERT INTO Phim_theloai (MaTLP, MaPhim)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(1, 2),
(4, 1);

INSERT INTO PhongChieu (TenPhong, TongSoGhe, SoHangGhe, SoGhe1Hang)
VALUES 
('Phong 1', 100, 10, 10),
('Phong 2', 150, 15, 10);

INSERT INTO GheNgoi (HangGhe, SoGhe, LoaiGheNgoi, TrangThai, MaPhongChieu)
VALUES 
('A', 1, N'Thường', N'Trống', 1),
('A', 2, N'VIP', N'Trống', 1),
('B', 1, N'Thường', N'Đã đặt', 2),
('B', 2, N'VIP', N'Trống', 2);

INSERT INTO CaChieu (ThoiGianChieu, ThoiGianKetThuc, GiaVe, MaPhongChieu, MaPhim)
VALUES
('2023-05-10 18:00:00', '2023-05-10 20:30:00', 120000, 1, 1),
('2023-05-10 20:30:00', '2023-05-10 23:00:00', 100000, 2, 2);

INSERT INTO Ve (MaCaChieu, MaGheNgoi)
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4);

INSERT INTO KhachHang (HoTen, NamSinh, SoDienThoai, DiemTichLuy, CCCD)
VALUES 
(N'Nguyễn Văn A', 1990, '0987654321', 100, '123456789012'),
(N'Trần Thị B', 1985, '0912345678', 200, '234567890123');

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
VALUES 
(N'Lê Minh C', '1980-05-20', N'Hà Nội', '0912345679', '987654321012'),
(N'Phạm Thị D', '1990-07-15', N'Hồ Chí Minh', '0931234567', '876543210123');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTK, MaNV)
VALUES
('admin', 'a', 1, 1),
('user2', 'a', 2, 2);

INSERT INTO HoaDon (NgayBan, TongTien, MaNhanVien, MaKhachHang)
VALUES
('2023-05-10 18:30:00', 240000, 1, 1),
('2023-05-10 20:45:00', 200000, 2, 2);

INSERT INTO ChiTietHoaDon (MaHoaDon, MaVe)
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4);
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