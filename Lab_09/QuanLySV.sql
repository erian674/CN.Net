-- ============================================-- TẠO DATABASE-- ============================================
CREATE DATABASE QuanLySV;
GO
USE QuanLySV;
GO
-- ============================================-- BẢNG KHOA (tạo trước — SinhVien tham chiếu)-- ============================================
CREATE TABLE KHOA (
    MaKhoa  nvarchar(6)   PRIMARY KEY,
    TenKhoa nvarchar(30)  NOT NULL);
-- ============================================-- BẢNG SinhVien-- ============================================
CREATE TABLE SinhVien (
    MaSo      int           PRIMARY KEY IDENTITY(1,1),
    HoTen     nvarchar(50)  NOT NULL,
    NgaySinh  datetime,
    GioiTinh  bit           DEFAULT 1,   -- 1=Nam, 0=Nữ    
    DiaChi    nvarchar(50),
    DienThoai int,
    MaKhoa    nvarchar(6)      REFERENCES KHOA(MaKhoa)
);
-- ============================================-- BẢNG Mon (Môn học)-- ============================================
CREATE TABLE Mon (
    MaMH   nvarchar(6)   PRIMARY KEY,
    TenMH  nvarchar(50)  NOT NULL,
    SoTiet int);
-- ============================================-- BẢNG KetQua — quan hệ N-N-- ============================================
CREATE TABLE KetQua (
    MaSo  int       REFERENCES SinhVien(MaSo),
    MaMH  nvarchar(6)  REFERENCES Mon(MaMH),
    Diem  int       CHECK (Diem BETWEEN 0 AND 10),
    PRIMARY KEY (MaSo, MaMH)
);
-- ============================================-- DỮ LIỆU MẪU-- ============================================
INSERT INTO KHOA VALUES    
    (N'CNTT', N'Công nghệ thông tin'),
    (N'QTKD', N'Quản trị kinh doanh'),
    (N'KT', N'Kế toán');
INSERT INTO SinhVien (HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai,MaKhoa) VALUES    
    (N'Nguyễn Văn An',  '2003-05-15', 1, N'Đồng Nai',   0912345678, N'CNTT  '),
    (N'Trần Thị Bình', '2003-08-22', 0, N'TP.HCM',     0987654321, N'CNTT  '),
    (N'Lê Văn Cường',  '2004-01-10', 1, N'Bình Dương', 0909111222, N'QTKD  '),
    (N'Phạm Thị Dung', '2004-03-18', 0, N'Long An',    0903333444, N'KT    ');

INSERT INTO Mon VALUES
    (N'LTCT', N'Lập trình C++',    45),
    (N'CSDL', N'Cơ sở dữ liệu',    60),
    (N'CTDL', N'Cấu trúc dữ liệu', 45);

INSERT INTO KetQua VALUES
    (1, N'LTCT  ', 8), (1, N'CSDL  ', 7),
    (2, N'LTCT  ', 9), (2, N'CTDL  ', 6),
    (3, N'CSDL  ', 8);
GO
ALTER TABLE SinhVien 
ALTER COLUMN DienThoai varchar(15);
GO
ALTER TABLE KetQua DROP CONSTRAINT CK__KetQua__Diem__5FB337D6;
GO
ALTER TABLE KetQua 
ALTER COLUMN Diem float;
GO
ALTER TABLE KetQua ADD CONSTRAINT CK_KetQua_Diem CHECK (Diem BETWEEN 0 AND 10);
GO
UPDATE SinhVien
SET DienThoai = '0' + DienThoai
WHERE DienThoai IS NOT NULL AND LEFT(DienThoai, 1) <> '0';
GO