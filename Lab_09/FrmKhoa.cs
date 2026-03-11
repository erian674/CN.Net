using Lab_09.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class FrmKhoa : Form
    {
        // Khai báo DbContext
        private QuanLySvContext db = new QuanLySvContext();
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
        }
        // ─── LOAD DANH SÁCH KHOA LÊN LƯỚI ───
        private void LoadDanhSachKhoa()
        {
            var ds = db.Khoas.Select(k => new
            {
                k.MaKhoa,
                k.TenKhoa
            }).ToList();

            dgvKhoa.DataSource = ds;

            if (dgvKhoa.Columns.Count > 0)
            {
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã khoa";
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";

                dgvKhoa.Columns["TenKhoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            // THÊM DÒNG NÀY: Nếu DataGridView không được người dùng click vào thì thoát luôn
            if (!dgvKhoa.Focused) return;

            if (dgvKhoa.CurrentRow == null) return;
            DataGridViewRow row = dgvKhoa.CurrentRow;

            txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString();
            txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString();

            // KHÓA ô Mã khoa
            txtMaKhoa.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khoa và Tên Khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return;
            }

            string maKhoaMoi = txtMaKhoa.Text.Trim();

            // Kiểm tra trùng mã (Bắt buộc vì MaKhoa không tự động tăng)
            if (db.Khoas.Any(k => k.MaKhoa == maKhoaMoi))
            {
                MessageBox.Show("Mã khoa này đã tồn tại! Vui lòng nhập mã khác.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKhoa.Focus();
                return;
            }

            // Tạo object Khoa
            Khoa khoaMoi = new Khoa
            {
                MaKhoa = maKhoaMoi,
                TenKhoa = txtTenKhoa.Text.Trim()
            };

            db.Khoas.Add(khoaMoi);
            db.SaveChanges();

            LoadDanhSachKhoa();
            LamMoiForm();

            MessageBox.Show("Thêm khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa!"); return;
            }

            Khoa? k = db.Khoas.Find(maKhoa);

            if (k == null)
            {
                MessageBox.Show("Không tìm thấy khoa này!"); return;
            }

            // Chỉ cập nhật Tên Khoa
            k.TenKhoa = txtTenKhoa.Text.Trim();

            db.SaveChanges();
            LoadDanhSachKhoa();

            MessageBox.Show("Cập nhật tên khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!"); return;
            }

            var cf = MessageBox.Show(
            $"Xóa khoa: {txtTenKhoa.Text}?\nCẢNH BÁO: Toàn bộ sinh viên thuộc khoa này và điểm của họ cũng sẽ bị xóa sạch!",
            "Xác nhận xóa nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cf != DialogResult.Yes) return;

            // Bắt buộc xóa Dữ liệu liên quan trước (KetQua -> SinhVien -> Khoa)
            var svs = db.SinhViens.Where(sv => sv.MaKhoa == maKhoa).ToList();

            foreach (var sv in svs)
            {
                // Xóa điểm của từng sinh viên thuộc khoa này
                var kqs = db.KetQuas.Where(kq => kq.MaSo == sv.MaSo).ToList();
                db.KetQuas.RemoveRange(kqs);
            }

            // Xóa sinh viên thuộc khoa này
            db.SinhViens.RemoveRange(svs);

            // Xóa khoa
            Khoa? k = db.Khoas.Find(maKhoa);
            if (k != null) db.Khoas.Remove(k);

            db.SaveChanges();
            LoadDanhSachKhoa();
            LamMoiForm();

            MessageBox.Show("Xóa khoa và dọn dẹp dữ liệu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // ─── LÀM MỚI FORM ───
        private void LamMoiForm()
        {
            // Xóa trắng chữ cũ
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();

            // MỞ KHÓA LẠI Ô MÃ KHOA ĐỂ BẠN NHẬP MÃ MỚI
            txtMaKhoa.ReadOnly = false;

            // Đưa con trỏ chuột nhấp nháy vào ô Mã Khoa để gõ luôn cho tiện
            txtMaKhoa.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
            dgvKhoa.ClearSelection();
            LamMoiForm();          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();

            var kq = db.Khoas
                .Where(k => k.MaKhoa.ToLower().Contains(kw) || k.TenKhoa.ToLower().Contains(kw))
                .Select(k => new
                {
                    k.MaKhoa,
                    k.TenKhoa
                }).ToList();

            dgvKhoa.DataSource = kq;
        }
    }
}
