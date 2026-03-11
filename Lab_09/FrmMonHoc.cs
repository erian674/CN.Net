using Lab_09.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class FrmMonHoc : Form
    {
        // Khai báo DbContext
        private QuanLySvContext db = new QuanLySvContext();
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonHoc();
        }
        // ─── LOAD DANH SÁCH MÔN HỌC ───
        private void LoadDanhSachMonHoc()
        {
            var ds = db.Mons.Select(m => new
            {
                m.MaMh,
                m.TenMh,
                m.SoTiet
            }).ToList();

            dgvMonHoc.DataSource = ds;

            if (dgvMonHoc.Columns.Count > 0)
            {
                dgvMonHoc.Columns["MaMh"].HeaderText = "Mã môn học";
                dgvMonHoc.Columns["TenMh"].HeaderText = "Tên môn học";
                dgvMonHoc.Columns["SoTiet"].HeaderText = "Số tiết";

                dgvMonHoc.Columns["TenMh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            // Nếu lưới không được người dùng focus thì bỏ qua (Tránh lỗi khi Load data ngầm)
            if (!dgvMonHoc.Focused) return;

            if (dgvMonHoc.CurrentRow == null) return;
            DataGridViewRow row = dgvMonHoc.CurrentRow;

            txtMaMh.Text = row.Cells["MaMh"].Value?.ToString();
            txtTenMh.Text = row.Cells["TenMh"].Value?.ToString();
            txtSoTiet.Text = row.Cells["SoTiet"].Value?.ToString();

            // Khóa Mã MH lại khi đang xem/sửa
            txtMaMh.ReadOnly = true;
        }
        // ─── LÀM MỚI FORM ───
        private void LamMoiForm()
        {
            txtMaMh.Clear();
            txtTenMh.Clear();
            txtSoTiet.Clear();
            txtTimKiem.Clear();

            // Mở khóa lại ô Mã MH để thêm mới
            txtMaMh.ReadOnly = false;
            txtMaMh.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadDanhSachMonHoc();
            dgvMonHoc.ClearSelection(); // Tắt bôi xanh
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMh.Text) || string.IsNullOrWhiteSpace(txtTenMh.Text) || string.IsNullOrWhiteSpace(txtSoTiet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ép kiểu Số tiết (Kiểm tra xem người dùng có gõ chữ vào không)
            if (!int.TryParse(txtSoTiet.Text.Trim(), out int soTietValid))
            {
                MessageBox.Show("Số tiết bắt buộc phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTiet.Focus();
                return;
            }

            string MaMh = txtMaMh.Text.Trim();
            if (db.Mons.Any(m => m.MaMh == MaMh))
            {
                MessageBox.Show("Mã môn học này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mon monMoi = new Mon
            {
                MaMh = MaMh,
                TenMh = txtTenMh.Text.Trim(),
                SoTiet = soTietValid
            };

            db.Mons.Add(monMoi);
            db.SaveChanges();

            LoadDanhSachMonHoc();
            LamMoiForm();
            MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaMh = txtMaMh.Text.Trim();
            if (string.IsNullOrEmpty(MaMh))
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (!int.TryParse(txtSoTiet.Text.Trim(), out int soTietValid))
            {
                MessageBox.Show("Số tiết bắt buộc phải là chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mon? m = db.Mons.Find(MaMh);
            if (m != null)
            {
                m.TenMh = txtTenMh.Text.Trim();
                m.SoTiet = soTietValid;

                db.SaveChanges();
                LoadDanhSachMonHoc();
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaMh = txtMaMh.Text.Trim();
            if (string.IsNullOrEmpty(MaMh)) return;

            var cf = MessageBox.Show($"Bạn có chắc chắn muốn xóa môn học {txtTenMh.Text}?\nCẢNH BÁO: Toàn bộ điểm thi của sinh viên ở môn này sẽ bị xóa!",
                "Xác nhận xóa nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cf != DialogResult.Yes) return;

            // Xóa điểm thi liên quan trong bảng KetQua trước
            var kqs = db.KetQuas.Where(kq => kq.MaMh == MaMh).ToList();
            db.KetQuas.RemoveRange(kqs);

            // Xóa Môn học
            Mon? m = db.Mons.Find(MaMh);
            if (m != null) db.Mons.Remove(m);

            db.SaveChanges();
            LoadDanhSachMonHoc();
            LamMoiForm();

            MessageBox.Show("Đã xóa môn học và điểm thi liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();

            var kq = db.Mons
                .Where(m => m.MaMh.ToLower().Contains(kw) || m.TenMh.ToLower().Contains(kw))
                .Select(m => new { m.MaMh, m.TenMh, m.SoTiet })
                .ToList();

            dgvMonHoc.DataSource = kq;
        }
    }
}
