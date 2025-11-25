-- =========================================
-- 1. TẠO DATABASE
-- =========================================
CREATE DATABASE QLCH1;
GO
USE QLCH1;
GO

-- =========================================
-- 2. LOẠI TÀI KHOẢN
-- =========================================
CREATE TABLE LoaiTaiKhoan (
    MaTK NVARCHAR(100) PRIMARY KEY,
    LoaiTK NVARCHAR(50) NOT NULL
);

INSERT INTO LoaiTaiKhoan (MaTK, LoaiTK) VALUES
(N'TK01', N'Vip'), (N'TK02', N'KHM'), (N'TK03', N'Vip'),
(N'TK04', N'KHM'), (N'TK05', N'Vip');

-- =========================================
-- 3. KHÁCH HÀNG
-- =========================================
CREATE TABLE KhachHang (
    MaKH NVARCHAR(100) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    Email NVARCHAR(50),
    DiaChi NVARCHAR(200),
    LoaiTaiKhoan NVARCHAR(50)
);

INSERT INTO KhachHang (MaKH, TenKH, SoDienThoai, Email, DiaChi, LoaiTaiKhoan) VALUES
(N'KH01', N'Nguyễn Văn A', '0911111111', N'a@gmail.com', N'An Giang', N'Vip'),
(N'KH02', N'Trần Thị B', '0922222222', N'b@gmail.com', N'TP.HCM', N'KHM'),
(N'KH03', N'Lê Văn C', '0933333333', N'c@gmail.com', N'Vĩnh Long', N'Vip'),
(N'KH04', N'Phạm Thị D', '0944444444', N'd@gmail.com', N'Đồng Tháp', N'KHM'),
(N'KH05', N'Hoàng Văn E', '0955555555', N'e@gmail.com', N'Cần Thơ', N'Vip');

-- =========================================
-- 4. SIZE
-- =========================================
CREATE TABLE SIZE (
    MaSize NVARCHAR(100) PRIMARY KEY,
    SoSize NVARCHAR(10)
);

INSERT INTO SIZE (MaSize, SoSize) VALUES
(N'S01', N'S'), (N'S02', N'M'), (N'S03', N'L'), (N'S04', N'XL');

-- =========================================
-- 5. SẢN PHẨM
-- =========================================
CREATE TABLE SanPham (
    MaSP NVARCHAR(100) PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL,
    SoSize NVARCHAR(10),
    MauSac NVARCHAR(50),
    Gia DECIMAL(18,2) NOT NULL,
    SoLuongTon INT NOT NULL DEFAULT 0,
    MaSize NVARCHAR(100),
    FOREIGN KEY (MaSize) REFERENCES SIZE(MaSize)
);

INSERT INTO SanPham (MaSP, TenSP, SoSize, MauSac, Gia, SoLuongTon, MaSize) VALUES
(N'SP01', N'Áo sơ mi', N'S', N'Trắng', 250000, 20, N'S01'),
(N'SP02', N'Quần jeans', N'M', N'Xanh', 400000, 30, N'S02'),
(N'SP03', N'Váy công sở', N'L', N'Đen', 350000, 25, N'S03'),
(N'SP04', N'Áo phông', N'XL', N'Nâu', 600000, 15, N'S04'),
(N'SP05', N'Đầm lụa', N'XL', N'Đỏ', 800000, 10, N'S04');

-- =========================================
-- 6. KHO
-- =========================================
CREATE TABLE Kho (
    MaSP NVARCHAR(100) PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL,
    SLTon INT NOT NULL DEFAULT 0,
    ThoiGianTon NVARCHAR(50),
    CanhBao NVARCHAR(100),
    KM NVARCHAR(50),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

INSERT INTO Kho (MaSP, TenSP, SLTon, ThoiGianTon, CanhBao, KM) VALUES
(N'SP01', N'Áo sơ mi', 50, N'15 ngày', N'Bình thường', N'Không có'),
(N'SP02', N'Quần jeans', 30, N'2 năm', N'Hàng tồn lâu', N'Mua 2 tặng 1'),
(N'SP03', N'Váy công sở', 15, N'10 ngày', N'Nhập thêm', N'Không có'),
(N'SP04', N'Áo phông', 15, N'5 ngày', N'Nhập thêm', N'Không có'),
(N'SP05', N'Đầm lụa', 10, N'3 ngày', N'Nhập thêm', N'Không có');

-- =========================================
-- 7. TÀI KHOẢN
-- =========================================
CREATE TABLE TaiKhoan (
    TenDangNhap NVARCHAR(100) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL,
    MaTK NVARCHAR(100),
    MaKH NVARCHAR(100),
    FOREIGN KEY (MaTK) REFERENCES LoaiTaiKhoan(MaTK),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaTK, MaKH) VALUES
(N'Vip01', '123', N'TK01', N'KH01'),
(N'KHM01', '123', N'TK02', N'KH02'),
(N'Vip02', '123', N'TK03', N'KH03'),
(N'KHM02', '123', N'TK04', N'KH04'),
(N'Vip03', '123', N'TK05', N'KH05');

-- =========================================
-- 8. PHIẾU NHẬP
-- =========================================
CREATE TABLE PhieuNhap (
    MaPN NVARCHAR(100) PRIMARY KEY,
    NgayNhap DATE NOT NULL,
    SoLuongNhap INT NOT NULL,
    TongTien DECIMAL(18,2),
    GhiChu NVARCHAR(100),
    MaSP NVARCHAR(100),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

INSERT INTO PhieuNhap (MaPN, NgayNhap, SoLuongNhap, TongTien, GhiChu, MaSP) VALUES
(N'PN001', '2025-01-05', 10, 2000000, N'Nhập khuyến mãi', N'SP01'),
(N'PN002', '2025-01-10', 30, 9000000, N'Nhập bổ sung hàng', N'SP02'),
(N'PN003', '2025-01-15', 45, 11250000, N'Nhập hàng khuyến mãi', N'SP03'),
(N'PN004', '2025-01-20', 45, 22500000, N'Nhập hàng thêm', N'SP04'),
(N'PN005', '2025-01-25', 50, 350000000, N'Nhập hàng theo đơn đặt', N'SP05');

-- =========================================
-- 9. CHI TIẾT PHIẾU NHẬP (KHÔNG FK TỚI SANPHAM)
-- =========================================
CREATE TABLE ChiTietPhieuNhap (
    MaCTPN NVARCHAR(100) PRIMARY KEY,
    MaPN NVARCHAR(100) NOT NULL,
    MaSP NVARCHAR(100),        -- chỉ lưu thông tin, không FK
    GiaNhapSP DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaPN) REFERENCES PhieuNhap(MaPN)
);

INSERT INTO ChiTietPhieuNhap (MaCTPN, MaPN, MaSP, GiaNhapSP) VALUES
(N'CTPN01', N'PN001', N'SP01', 200000),
(N'CTPN02', N'PN002', N'SP02', 300000),
(N'CTPN03', N'PN003', N'SP03', 250000),
(N'CTPN04', N'PN004', N'SP04', 500000),
(N'CTPN05', N'PN005', N'SP05', 700000);

-- =========================================
-- 10. HÓA ĐƠN
-- =========================================
CREATE TABLE HoaDon (
    MaHD NVARCHAR(100) PRIMARY KEY,
    MaKH NVARCHAR(100) NOT NULL,
    PhuongThucThanhToan NVARCHAR(50) NOT NULL,
    NgayBan DATE NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

INSERT INTO HoaDon (MaHD, MaKH, PhuongThucThanhToan, NgayBan, TongTien) VALUES
(N'HD01', N'KH01', N'Tiền mặt', '2025-11-01', 1000000),
(N'HD02', N'KH02', N'Chuyển khoản', '2025-11-02', 2000000),
(N'HD03', N'KH03', N'Thẻ', '2025-11-03', 1500000),
(N'HD04', N'KH04', N'Tiền mặt', '2025-11-04', 3000000),
(N'HD05', N'KH05', N'Chuyển khoản', '2025-11-05', 2500000);

-- =========================================
-- 11. CHI TIẾT HÓA ĐƠN
-- =========================================
CREATE TABLE ChiTietHoaDon (
    MaCTHD NVARCHAR(20) PRIMARY KEY,
    MaHD NVARCHAR(100) NOT NULL,
    MaSP NVARCHAR(100) NOT NULL,
    SoLuong INT NOT NULL,
    TienSP DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaSP, SoLuong, TienSP) VALUES
(N'CTHD01', N'HD01', N'SP01', 2, 200000),
(N'CTHD02', N'HD02', N'SP02', 3, 300000),
(N'CTHD03', N'HD03', N'SP03', 1, 250000),
(N'CTHD04', N'HD04', N'SP04', 4, 500000),
(N'CTHD05', N'HD05', N'SP05', 2, 700000);

-- =========================================
-- 12. DOANH THU
-- =========================================
CREATE TABLE DoanhThu (
    MaDT NVARCHAR(100) PRIMARY KEY,
    MaHD NVARCHAR(100) NOT NULL,
    Ngay DATE NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
);

INSERT INTO DoanhThu (MaDT, MaHD, Ngay, TongTien, GhiChu) VALUES
(N'DT001', N'HD01', '2025-01-01', 1000000, N'Doanh thu từ hóa đơn HD01'),
(N'DT002', N'HD02', '2025-01-02', 2000000, N'Doanh thu từ hóa đơn HD02'),
(N'DT003', N'HD03', '2025-01-03', 1500000, N'Doanh thu từ hóa đơn HD03'),
(N'DT004', N'HD04', '2025-01-04', 3000000, N'Doanh thu từ hóa đơn HD04'),
(N'DT005', N'HD05', '2025-01-05', 2500000, N'Doanh thu từ hóa đơn HD05');
-- =========================================
-- 13. TRUY VẤN KIỂM TRA
-- =========================================
SELECT * FROM LoaiTaiKhoan;
SELECT * FROM KhachHang;
SELECT * FROM SIZE;
SELECT * FROM SanPham;
SELECT * FROM Kho;
SELECT * FROM TaiKhoan;
SELECT * FROM PhieuNhap;
SELECT * FROM ChiTietPhieuNhap;
SELECT * FROM HoaDon;
SELECT * FROM ChiTietHoaDon;
SELECT * FROM DoanhThu;
