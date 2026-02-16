USE master;
GO
-- 1. Xóa database cũ nếu tồn tại để tạo lại cho sạch
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'StudentDB')
BEGIN
    ALTER DATABASE StudentDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE StudentDB;
END
GO
CREATE DATABASE StudentDB;
GO
USE StudentDB;
GO
-- 2. Tạo bảng KHOA
-- Sửa Makhoa thành varchar(10) cho thống nhất
CREATE TABLE KHOA (
    Makhoa varchar(10) PRIMARY KEY, 
    Tenkhoa nvarchar(50) -- Dùng nvarchar để lưu tiếng Việt
);
GO
-- 3. Tạo bảng Mon (Môn học)
CREATE TABLE Mon (
    MaMH varchar(10) PRIMARY KEY,
    TenMH nvarchar(50),
    SoTiet int
);
GO
-- 4. Tạo bảng SinhVien (QUAN TRỌNG NHẤT)
CREATE TABLE SinhVien (
    MaSo int PRIMARY KEY,          
    HoTen nvarchar(50),            
    NgaySinh datetime,             
    GioiTinh bit,                  
    DiaChi nvarchar(100),     
    DienThoai varchar(15),    
    Makhoa varchar(10) REFERENCES KHOA(Makhoa)
);
GO
-- 5. Tạo bảng KetQua
CREATE TABLE KetQua (
    MaSo int REFERENCES SinhVien(MaSo),
    MaMH varchar(10) REFERENCES Mon(MaMH),
    Diem float,
    PRIMARY KEY (MaSo, MaMH)
);
GO
-- --- INSERT DỮ LIỆU ---
INSERT INTO KHOA (Makhoa, Tenkhoa) VALUES 
('CNTT', N'Công Nghệ Thông Tin'),
('CNTP', N'Công Nghệ Thực Phẩm'),
('DDT', N'Điện - Điện Tử'),
('MT', N'Môi Trường'),
('NN', N'Ngoại Ngữ'),
('QTKD', N'Quản Trị Kinh Doanh');
INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES 
('001', N'Lập Trình Windows', 45),
('002', N'Cơ Sở Dữ Liệu', 45),
('003', N'Cấu Trúc Dữ Liệu', 60),
('004', N'Kỹ Thuật Lập Trình', 45),
('005', N'Ngữ Pháp', 30),
('006', N'Đọc Hiểu', 30),
('007', N'Nghe Nói', 45);
INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Makhoa) VALUES 
(100, N'Nguyễn Hà Giang', '1978-12-04', 1, N'Hoàng Hoa Thám', '0908496767', 'CNTT'),
(101, N'Nguyễn Hà Mỹ Tiên', '1988-01-01', 0, N'Lê Quang Định', '0901234567', 'CNTP'),
(102, N'Trần Ngọc Thảo', '1989-12-24', 0, N'Lý Thường Kiệt', '0903334455', 'CNTT'),
(106, N'Lê Bạch Yến', '1976-02-21', 0, N'757 Pasteur', '0923445556', 'CNTT');
INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES 
(100, '001', 5),
(100, '002', 6),
(100, '003', 7),
(100, '004', 8),
(106, '001', 8);
GO
SELECT * FROM SinhVien;