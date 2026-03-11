using Lab_09.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class FrmKetQua : Form
    {
        private QuanLySvContext db = new QuanLySvContext();
        public FrmKetQua()
        {
            InitializeComponent();
        }

        private void FrmKetQua_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDanhSachKetQua();
        }
        // ─── LOAD COMBOBOX SINH VIÊN & MÔN HỌC ───
        private void LoadComboBoxes()
        {
            // Load ComboBox Sinh Viên
            cbbSinhVien.DataSource = db.SinhViens.ToList();
            cbbSinhVien.DisplayMember = "HoTen"; // Hiện tên
            cbbSinhVien.ValueMember = "MaSo";    // Lưu mã ẩn ở dưới

            // Load ComboBox Môn Học
            cbbMonHoc.DataSource = db.Mons.ToList();
            cbbMonHoc.DisplayMember = "TenMh";
            cbbMonHoc.ValueMember = "MaMh";
        }

        // ─── LOAD DANH SÁCH ĐIỂM ───
        private void LoadDanhSachKetQua()
        {
            // Dùng Include để lấy được thông tin Tên từ bảng khác
            var ds = db.KetQuas
                .Include(kq => kq.MaSoNavigation) // Tên navigation property tùy thuộc EF Core sinh ra
                .Include(kq => kq.MaMhNavigation)
                .Select(kq => new
                {
                    MaSo = kq.MaSo,
                    TenSV = kq.MaSoNavigation != null ? kq.MaSoNavigation.HoTen : "",
                    MaMh = kq.MaMh,
                    TenMh = kq.MaMhNavigation != null ? kq.MaMhNavigation.TenMh : "",
                    Diem = kq.Diem
                }).ToList();

            dgvKetQua.DataSource = ds;

            if (dgvKetQua.Columns.Count > 0)
            {
                dgvKetQua.Columns["MaSo"].HeaderText = "Mã SV";
                dgvKetQua.Columns["TenSV"].HeaderText = "Tên Sinh Viên";
                dgvKetQua.Columns["MaMh"].HeaderText = "Mã MH";
                dgvKetQua.Columns["TenMh"].HeaderText = "Tên Môn Học";
                dgvKetQua.Columns["Diem"].HeaderText = "Điểm";

                dgvKetQua.Columns["TenSV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvKetQua.Focused) return;
            if (dgvKetQua.CurrentRow == null) return;

            DataGridViewRow row = dgvKetQua.CurrentRow;

            // Gán giá trị lại cho ComboBox dựa vào ValueMember (Mã)
            cbbSinhVien.SelectedValue = row.Cells["MaSo"].Value;
            cbbMonHoc.SelectedValue = row.Cells["MaMh"].Value?.ToString();
            txtDiem.Text = row.Cells["Diem"].Value?.ToString();

            // QUAN TRỌNG: Khóa 2 ComboBox lại, không cho sửa Mã SV và Mã MH (vì là khóa chính)
            cbbSinhVien.Enabled = false;
            cbbMonHoc.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // 1. Làm sạch các ô nhập liệu và ô tìm kiếm
            txtDiem.Clear();
            txtTimKiem.Clear(); // Thêm dòng này để xóa từ khóa tìm kiếm cũ

            if (cbbSinhVien.Items.Count > 0) cbbSinhVien.SelectedIndex = 0;
            if (cbbMonHoc.Items.Count > 0) cbbMonHoc.SelectedIndex = 0;

            // 2. Mở khóa lại 2 ComboBox để Thêm mới
            cbbSinhVien.Enabled = true;
            cbbMonHoc.Enabled = true;

            // 3. THÊM DÒNG NÀY: Gọi hàm tải lại toàn bộ danh sách điểm lên lưới
            LoadDanhSachKetQua();

            // 4. Tắt bôi xanh và đưa trỏ chuột về ô Điểm
            dgvKetQua.ClearSelection();
            txtDiem.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbSinhVien.SelectedValue == null || cbbMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh Viên và Môn Học!"); return;
            }
            // Thay toàn bộ dấu phẩy thành dấu chấm để đồng nhất dữ liệu
            string inputDiem = txtDiem.Text.Trim().Replace(',', '.');
            // Dùng InvariantCulture để ép C# luôn hiểu dấu chấm (.) là dấu thập phân chuẩn quốc tế
            if (!double.TryParse(inputDiem, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double diemSo) || diemSo < 0 || diemSo > 10)
            {
                MessageBox.Show("Điểm phải là số hợp lệ nằm trong khoảng từ 0 đến 10 (VD: 8.5 hoặc 8,5)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            int maSV = (int)cbbSinhVien.SelectedValue;
            string MaMh = cbbMonHoc.SelectedValue.ToString();

            // Kiểm tra xem sinh viên này đã thi môn này chưa
            if (db.KetQuas.Any(kq => kq.MaSo == maSV && kq.MaMh == MaMh))
            {
                MessageBox.Show("Sinh viên này đã có điểm môn này rồi! Bạn chỉ có thể Sửa điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KetQua kqMoi = new KetQua
            {
                MaSo = maSV,
                MaMh = MaMh,
                Diem = diemSo // diemSo giờ đã chứa được số thập phân
            };

            db.KetQuas.Add(kqMoi);
            db.SaveChanges();

            LoadDanhSachKetQua();
            MessageBox.Show("Nhập điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbSinhVien.SelectedValue == null || cbbMonHoc.SelectedValue == null) return;
            // Thay toàn bộ dấu phẩy thành dấu chấm để đồng nhất dữ liệu
            string inputDiem = txtDiem.Text.Trim().Replace(',', '.');
            // Dùng InvariantCulture để ép C# luôn hiểu dấu chấm (.) là dấu thập phân chuẩn quốc tế
            if (!double.TryParse(inputDiem, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double diemSo) || diemSo < 0 || diemSo > 10)
            {
                MessageBox.Show("Điểm phải là số hợp lệ nằm trong khoảng từ 0 đến 10 (VD: 8.5 hoặc 8,5)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            int maSV = (int)cbbSinhVien.SelectedValue;
            string MaMh = cbbMonHoc.SelectedValue.ToString();

            // Tìm bằng 2 Khóa chính (Composite Key)
            KetQua? kqSua = db.KetQuas.Find(maSV, MaMh);

            if (kqSua != null)
            {
                kqSua.Diem = diemSo; // Chỉ được phép sửa Điểm
                db.SaveChanges();
                LoadDanhSachKetQua();
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbSinhVien.SelectedValue == null || cbbMonHoc.SelectedValue == null) return;

            var cf = MessageBox.Show("Bạn có chắc chắn muốn xóa điểm thi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            int maSV = (int)cbbSinhVien.SelectedValue;
            string MaMh = cbbMonHoc.SelectedValue.ToString();

            KetQua? kqXoa = db.KetQuas.Find(maSV, MaMh);

            if (kqXoa != null)
            {
                db.KetQuas.Remove(kqXoa);
                db.SaveChanges();
                LoadDanhSachKetQua();
                btnLamMoi.PerformClick();
                MessageBox.Show("Đã xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim().ToLower();

            // Tìm kiếm bao gồm: Mã SV, Tên SV, và Tên Môn Học
            var kq = db.KetQuas
                .Include(k => k.MaSoNavigation)
                .Include(k => k.MaMhNavigation)
                .Where(k =>
                    k.MaSo.ToString().Contains(kw) ||
                    (k.MaSoNavigation != null && k.MaSoNavigation.HoTen.ToLower().Contains(kw)) ||
                    (k.MaMhNavigation != null && k.MaMhNavigation.TenMh.ToLower().Contains(kw))
                )
                .Select(k => new
                {
                    MaSo = k.MaSo,
                    TenSV = k.MaSoNavigation != null ? k.MaSoNavigation.HoTen : "",
                    MaMh = k.MaMh,
                    TenMh = k.MaMhNavigation != null ? k.MaMhNavigation.TenMh : "",
                    Diem = k.Diem
                }).ToList();

            dgvKetQua.DataSource = kq;

            // Thông báo nếu không có kết quả
            if (kq.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả điểm thi nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
