create database RM_CNPM
use RM_CNPM

-- Bảng quản lý tài khoản đăng nhập
CREATE TABLE TaiKhoan (
    MaTK CHAR(10) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL, -- Mật khẩu cần mã hóa trước khi lưu
    VaiTro NVARCHAR(20) NOT NULL CHECK (VaiTro IN (N'Admin', N'Quản lý', N'Nhân viên')),
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động' CHECK (TrangThai IN (N'Hoạt động', N'Bị khóa')),
    MaNV CHAR(10) NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL
);

-- Bảng quản lý nhân viên
-- Tạo bảng master: NhanVien
CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255) NULL
);


CREATE TABLE ChiTietNhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    SoDienThoai NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    PhongBan NVARCHAR(100) NULL,
    ChucVu NVARCHAR(100) NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE CASCADE
);

-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaKH CHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(50) NOT NULL,
    SDT VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(50) UNIQUE NULL,
    LoaiKH NVARCHAR(50) NULL,
    NgayDangKy DATE DEFAULT GETDATE()
);

-- Bảng bàn ăn
CREATE TABLE BanAn (
    MaBan CHAR(10) PRIMARY KEY,
    SoBan INT UNIQUE NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Trống' CHECK (TrangThai IN (N'Trống', N'Có khách', N'Đã đặt'))
);

-- Bảng đặt bàn
CREATE TABLE DatBan (
    MaDatBan CHAR(10) PRIMARY KEY,
    MaKH CHAR(10) NULL,
    MaBan CHAR(10) NOT NULL,
    ThoiGianDat DATETIME NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Chưa xác nhận' CHECK (TrangThai IN (N'Chưa xác nhận', N'Đã xác nhận', N'Đã hủy')),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE SET NULL,
    FOREIGN KEY (MaBan) REFERENCES BanAn(MaBan) ON DELETE CASCADE
);

-- Bảng danh mục món ăn
CREATE TABLE DanhMuc (
    MaDanhMuc CHAR(10) PRIMARY KEY,
    TenDanhMuc NVARCHAR(255) UNIQUE NOT NULL
);

-- Bảng món ăn
CREATE TABLE MonAn (
    MaMon CHAR(10) PRIMARY KEY,
    TenMon NVARCHAR(50) NOT NULL,
    Gia DECIMAL(10,2) NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Còn hàng' CHECK (TrangThai IN (N'Còn hàng', N'Hết hàng')),
    MoTa NVARCHAR(MAX) NULL
);

-- Mối quan hệ giữa món ăn và danh mục
CREATE TABLE MonAn_DanhMuc (
    MaMon CHAR(10),
    MaDanhMuc CHAR(10),
    PRIMARY KEY (MaMon, MaDanhMuc),
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon) ON DELETE CASCADE,
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc) ON DELETE CASCADE
);

-- Bảng đơn hàng
CREATE TABLE DonHang (
    MaDonHang CHAR(10) PRIMARY KEY,
    MaKH CHAR(10) NULL,
    MaNV CHAR(10) NULL,
    MaBan CHAR(10) NULL,
    ThoiGianDat DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(20) DEFAULT N'Chưa hoàn thành' CHECK (TrangThai IN (N'Chưa hoàn thành', N'Đã hoàn thành', N'Đã hủy')),
    TongTien DECIMAL(10,2) DEFAULT 0,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE SET NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
    FOREIGN KEY (MaBan) REFERENCES BanAn(MaBan) ON DELETE SET NULL
);

-- Bảng chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaDonHang CHAR(10),
    MaMon CHAR(10),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(10,2) NOT NULL,
    ThanhTien DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (MaDonHang, MaMon),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang) ON DELETE CASCADE,
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon) ON DELETE CASCADE
);

-- Bảng hóa đơn
CREATE TABLE HoaDon (
    MaHD CHAR(10) PRIMARY KEY,
    NgayLap DATE DEFAULT GETDATE(),
    MaKH CHAR(10) NULL,
    MaNV CHAR(10) NULL,
	MaKM CHAR(10) NULL,
    TongTien DECIMAL(10,2) NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Chưa thanh toán' CHECK (TrangThai IN (N'Đã huỷ', N'Đã thanh toán')),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE SET NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
	FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM) ON DELETE SET NULL
);



-- Bảng chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaHD CHAR(10),
    MaMon CHAR(10),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(10,2) NOT NULL,
    ThanhTien DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (MaHD, MaMon),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon) ON DELETE CASCADE
);

-- Bảng kho nguyên liệu
CREATE TABLE KhoNguyenLieu (
    MaNL CHAR(10) PRIMARY KEY,
    TenNL NVARCHAR(50) NOT NULL,
    DonViTinh NVARCHAR(20) NOT NULL,
    SoLuongTon INT DEFAULT 0,
    GiaNhap DECIMAL(10,2) NOT NULL
);

-- Bảng nhập kho
CREATE TABLE NhapKho (
    MaNK CHAR(10) PRIMARY KEY,
    NgayNhap DATE DEFAULT GETDATE(),
    MaNV CHAR(10) NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE SET NULL
);

-- Bảng chi tiết nhập kho
CREATE TABLE ChiTietNhapKho (
    MaNK CHAR(10),
    MaNL CHAR(10),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    GiaNhap DECIMAL(10,2) NOT NULL,
    ThanhTien DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (MaNK, MaNL),
    FOREIGN KEY (MaNK) REFERENCES NhapKho(MaNK) ON DELETE CASCADE,
    FOREIGN KEY (MaNL) REFERENCES KhoNguyenLieu(MaNL) ON DELETE CASCADE
);

-- Bảng khuyến mãi
CREATE TABLE KhuyenMai (
    MaKM CHAR(10) PRIMARY KEY,
    TenKM NVARCHAR(50) NOT NULL,
    NgayBD DATE NOT NULL,
    NgayKT DATE NOT NULL,
    MucGiamGia DECIMAL(5,2) NOT NULL
);

UPDATE KH
SET KH.LoaiKH = 
    CASE 
        WHEN DB.SoLanDatBan >= 10 THEN N'VIP'
        WHEN DB.SoLanDatBan >= 5 THEN N'Thường xuyên'
        WHEN DB.SoLanDatBan = 0 OR DB.SoLanDatBan IS NULL THEN N'Chưa từng đến'
        ELSE N'Thỉnh thoảng'
    END
FROM KhachHang KH
LEFT JOIN (
    SELECT MaKH, COUNT(*) AS SoLanDatBan 
    FROM DatBan 
    WHERE MaKH IS NOT NULL -- Đảm bảo không tính NULL
    GROUP BY MaKH
) DB ON KH.MaKH = DB.MaKH;


-- Thêm dữ liệu mẫu cho bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, SDT, Email, LoaiKH, NgayDangKy) VALUES
('KH001', N'Nguyễn Văn A', '0901123456', 'a@gmail.com', NULL, '2024-01-01'),
('KH002', N'Trần Thị B', '0912233445', 'b@gmail.com', NULL, '2024-02-01'),
('KH003', N'Phạm Văn C', '0923344556', 'c@gmail.com', NULL, '2024-03-01'),
('KH004', N'Lê Thị D', '0934455667', 'd@gmail.com', NULL, '2024-04-01'),
('KH005', N'Hoàng Văn E', '0945566778', 'e@gmail.com', NULL, '2024-05-01');

-- Thêm dữ liệu mẫu cho bảng BanAn
INSERT INTO BanAn (MaBan, SoBan, TrangThai) VALUES
('B001', 1, N'Trống'),
('B002', 2, N'Trống'),
('B003', 3, N'Trống'),
('B004', 4, N'Trống'),
('B005', 5, N'Trống');

-- Thêm dữ liệu mẫu cho bảng DatBan
INSERT INTO DatBan (MaDatBan, MaKH, MaBan, ThoiGianDat, TrangThai) VALUES
('DB001', 'KH001', 'B001', '2024-06-01 18:00:00', N'Đã xác nhận'),
('DB002', 'KH001', 'B002', '2024-06-05 19:00:00', N'Đã xác nhận'),
('DB003', 'KH001', 'B003', '2024-06-10 20:00:00', N'Đã xác nhận'),
('DB004', 'KH002', 'B001', '2024-06-15 18:30:00', N'Đã xác nhận'),
('DB005', 'KH002', 'B002', '2024-06-20 19:30:00', N'Đã xác nhận'),
('DB006', 'KH002', 'B003', '2024-06-25 20:30:00', N'Đã xác nhận'),
('DB007', 'KH002', 'B004', '2024-07-01 18:00:00', N'Đã xác nhận'),
('DB008', 'KH002', 'B005', '2024-07-05 19:00:00', N'Đã xác nhận'),
('DB009', 'KH003', 'B001', '2024-07-10 20:00:00', N'Đã xác nhận'),
('DB010', 'KH003', 'B002', '2024-07-15 18:30:00', N'Đã xác nhận'),
('DB011', 'KH003', 'B003', '2024-07-20 19:30:00', N'Đã xác nhận'),
('DB012', 'KH003', 'B004', '2024-07-25 20:30:00', N'Đã xác nhận'),
('DB013', 'KH003', 'B005', '2024-08-01 18:00:00', N'Đã xác nhận'),
('DB014', 'KH003', 'B001', '2024-08-05 19:00:00', N'Đã xác nhận'),
('DB015', 'KH003', 'B002', '2024-08-10 20:00:00', N'Đã xác nhận'),
('DB016', 'KH003', 'B003', '2024-08-15 18:30:00', N'Đã xác nhận'),
('DB017', 'KH003', 'B004', '2024-08-20 19:30:00', N'Đã xác nhận'),
('DB018', 'KH003', 'B005', '2024-08-25 20:30:00', N'Đã xác nhận');

SELECT * FROM KhachHang;
