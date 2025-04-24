CREATE DATABASE DA1;
USE DA1;
GO

-- Tạo bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100),
    NamSinh INT,
    SoDienThoai VARCHAR(10),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    DiemTichLuy INT,
    CCCD CHAR(10)
);

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    CMND_CCCD CHAR(10)
);

-- Tạo bảng Tài Khoản
CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT,
    TenDN NVARCHAR(50),
    MatKhau NVARCHAR(255),
    LoaiTK NVARCHAR(50),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Tạo bảng Phòng Chiếu
CREATE TABLE PhongChieu (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(100),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    SoChoNgoi INT,
    TinhTrang NVARCHAR(50),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    SoHangGhe INT,
    SoGhe1Hang INT
);

-- Tạo bảng Thể Loại
CREATE TABLE TheLoai (
    MaLoaiPhim INT PRIMARY KEY,
    TenTheLoai NVARCHAR(100)  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
);

-- Tạo bảng Phim
CREATE TABLE Phim (
    MaPhim INT PRIMARY KEY,
    MaLoaiPhim INT,
    TenPhim NVARCHAR(200),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    MoTa TEXT,
    ThoiLuong INT,
    NgayKhoiChieu DATE,
    NgayKetThuc DATE,
    QuocGia NVARCHAR(100),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    DaoDien NVARCHAR(100),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    GioiHanTuoi INT,
    NamSX INT,
    FOREIGN KEY (MaLoaiPhim) REFERENCES TheLoai(MaLoaiPhim)
);

-- Tạo bảng Ca Chiếu
CREATE TABLE CaChieu (
    MaCaChieu INT PRIMARY KEY,
    MaPhong INT,
    MaPhim INT,  
    TenPhim NVARCHAR(200),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    ThoiGianChieu DATETIME,
    ThoiGianKetThuc DATETIME,
    GiaVe DECIMAL(10,2),
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim)
);

-- Tạo bảng Vé
-- Tạo bảng Vé với thêm nhân viên (Nhân Viên tạo vé)
CREATE TABLE Ve (
    ID INT PRIMARY KEY,
    LoaiVe NVARCHAR(50),  -- Loại vé (Ví dụ: Thường, VIP)
    MaCaChieu INT,        -- Mã ca chiếu
    MaGheNgoi NVARCHAR(10),  -- Mã ghế ngồi
    MaKhachHang INT,      -- Mã khách hàng
    TrangThai NVARCHAR(50),  -- Trạng thái vé (Ví dụ: Đã thanh toán)
    TienBanVe DECIMAL(10,2),  -- Tiền bán vé
    MaNV INT,             -- Mã nhân viên (Nhân viên tạo vé)
    FOREIGN KEY (MaCaChieu) REFERENCES CaChieu(MaCaChieu),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)  -- Mối quan hệ với bảng Nhân Viên
);

-- Tạo bảng Lịch Chiếu Phim
CREATE TABLE LichChieuPhim (
    MaCaChieu INT PRIMARY KEY,
    TenPhim NVARCHAR(200),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    ThoiGianChieu DATETIME,
    MaPhong INT,
    FOREIGN KEY (MaPhong) REFERENCES PhongChieu(MaPhong)
);

-- Tạo bảng Bang Phu
CREATE TABLE BangPhu (
    MaCaChieu INT,
    MaPhongChieu INT,
    TenPhim NVARCHAR(200),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    ThoiGian DATETIME,
    TrangThaiChieu NVARCHAR(50),  -- Sửa thành NVARCHAR để hỗ trợ tiếng Việt
    PRIMARY KEY (MaCaChieu, MaPhongChieu),
    FOREIGN KEY (MaCaChieu) REFERENCES CaChieu(MaCaChieu),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhong)
);

-- Dữ liệu mẫu cho bảng Nhân Viên
-- Dữ liệu mẫu cho bảng Nhân Viên
INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
VALUES 
(N'Nguyễn Văn Nam', '1990-05-15', N'Hà Nội', '0987654321', N'1234567890'),
(N'Phạm Thị Lan', '1985-03-10', N'Bắc Ninh', '0912345678', N'0987654321'),
(N'Vũ Minh Tuấn', '1992-12-25', N'Hồ Chí Minh', '0909876543', N'2345678901'),
(N'Trần Thị Mai', '1988-08-05', N'Hải Phòng', '0976543210', N'3456789012');

-- Dữ liệu mẫu cho bảng Phòng Chiếu
INSERT INTO PhongChieu (MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGhe1Hang) 
VALUES 
(1, N'Phòng Chiếu 1', 120, N'Hoạt động', 10, 12),
(2, N'Phòng Chiếu 2', 100, N'Hoạt động', 10, 10),
(3, N'Phòng Chiếu VIP', 80, N'Hoạt động', 8, 10),
(4, N'Phòng Chiếu 4', 120, N'Bảo trì', 10, 12);

-- Dữ liệu mẫu cho bảng Thể Loại
INSERT INTO TheLoai (MaLoaiPhim, TenTheLoai) 
VALUES 
(1, N'Hành động'),
(2, N'Tình cảm'),
(3, N'Kinh dị'),
(4, N'Hoạt hình'),
(5, N'Hài hước'),
(6, N'Khoa học viễn tưởng');

-- Dữ liệu mẫu cho bảng Phim
INSERT INTO Phim (MaPhim, MaLoaiPhim, TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, QuocGia, DaoDien, GioiHanTuoi, NamSX) 
VALUES 
(1, 1, N'Người Nhện: Du Hành Vũ Trụ', N'Người Nhện phiêu lưu qua các vũ trụ song song', 120, '2024-03-15', '2024-04-15', N'Mỹ', N'Joaquim Dos Santos', 13, 2024),
(2, 4, N'Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời', N'Doraemon và những người bạn khám phá vùng đất mới', 110, '2024-03-10', '2024-04-10', N'Nhật Bản', N'Takumi Doyama', 0, 2024),
(3, 2, N'Chị Chị Em Em 2', N'Câu chuyện về tình chị em và những bí mật', 115, '2024-03-20', '2024-04-20', N'Việt Nam', N'Vũ Ngọc Đãng', 16, 2024),
(4, 6, N'Dune: Hành Tinh Cát - Phần 2', N'Cuộc phiêu lưu trên sa mạc Arrakis', 155, '2024-03-01', '2024-04-01', N'Mỹ', N'Denis Villeneuve', 13, 2024);

-- Dữ liệu mẫu cho bảng Khách Hàng
INSERT INTO KhachHang (TenKH, NamSinh, SoDienThoai, DiemTichLuy, CCCD) 
VALUES 
(N'Hoàng Văn Nam', 2000, N'0945678901', 100, N'0801234567'),
(N'Nguyễn Thị Hoa', 1995, N'0956789012', 150, N'0812345678'),
(N'Trần Văn Minh', 1988, N'0967890123', 200, N'0823456789'),
(N'Lê Thị Lan', 1992, N'0978901234', 50, N'0834567890');

-- Dữ liệu mẫu cho bảng Ca Chiếu
INSERT INTO CaChieu (MaCaChieu, MaPhong, MaPhim, TenPhim, ThoiGianChieu, ThoiGianKetThuc, GiaVe) 
VALUES 
(1, 1, 1, N'Người Nhện: Du Hành Vũ Trụ', '2024-03-15 09:00:00', '2024-03-15 11:00:00', 90000),
(2, 1, 1, N'Người Nhện: Du Hành Vũ Trụ', '2024-03-15 13:00:00', '2024-03-15 15:00:00', 90000),
(3, 2, 2, N'Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời', '2024-03-15 10:00:00', '2024-03-15 12:00:00', 75000),
(4, 3, 4, N'Dune: Hành Tinh Cát - Phần 2', '2024-03-15 15:00:00', '2024-03-15 17:35:00', 120000);

-- Dữ liệu mẫu cho bảng Vé
INSERT INTO Ve (ID, LoaiVe, MaCaChieu, MaGheNgoi, MaKhachHang, TrangThai, TienBanVe, MaNV) 
VALUES 
(1, N'Thường', 1, N'A1', 1, N'Đã thanh toán', 90000, 1),
(2, N'Thường', 1, N'A2', 1, N'Đã thanh toán', 90000, 1),
(3, N'VIP', 4, N'B5', 2, N'Đã thanh toán', 120000, 2),
(4, N'Thường', 3, N'C3', 3, N'Đã thanh toán', 75000, 3);

-- Dữ liệu mẫu cho bảng Lịch Chiếu Phim
INSERT INTO LichChieuPhim (MaCaChieu, TenPhim, ThoiGianChieu, MaPhong) 
VALUES 
(1, N'Người Nhện: Du Hành Vũ Trụ', '2024-03-15 09:00:00', 1),
(2, N'Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời', '2024-03-15 10:00:00', 2),
(3, N'Chị Chị Em Em 2', '2024-03-15 13:00:00', 3),
(4, N'Dune: Hành Tinh Cát - Phần 2', '2024-03-15 15:00:00', 3);

-- Dữ liệu mẫu cho bảng Bang Phu
INSERT INTO BangPhu (MaCaChieu, MaPhongChieu, TenPhim, ThoiGian, TrangThaiChieu) 
VALUES 
(1, 1, N'Người Nhện: Du Hành Vũ Trụ', '2024-03-15 09:00:00', N'Đang chiếu'),
(2, 2, N'Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời', '2024-03-15 10:00:00', N'Chưa chiếu'),
(3, 3, N'Chị Chị Em Em 2', '2024-03-15 13:00:00', N'Chưa chiếu'),
(4, 3, N'Dune: Hành Tinh Cát - Phần 2', '2024-03-15 15:00:00', N'Chưa chiếu');

-- Câu lệnh SELECT cho bảng Khách Hàng
SELECT MaKH AS "Mã khách hàng", Tenkh AS "Tên khách hàng", NamSinh AS "Năm sinh", SoDienThoai AS "Số điện thoại", DiemTichLuy AS "Điểm tích lũy", CCCD
FROM KhachHang;

-- Câu lệnh UPDATE cho bảng Khách Hàng
UPDATE KhachHang 
SET TenKH = N'Hoàng Văn Nam', 
    NamSinh = 1995, 
    SoDienThoai = '0956789012', 
    DiemTichLuy = 150,
    CCCD = '0812345678'
WHERE MaKH = 2;
