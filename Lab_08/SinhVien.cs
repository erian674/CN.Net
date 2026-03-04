using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class SinhVien : Form
    {
        string strConn = "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataAdapter daKhoa;
        DataTable dtSinhVien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        public SinhVien()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // 1. Cấu hình cột cho Grid
                dtgsinhviên.AutoGenerateColumns = false;

                // Thiết lập mapping nếu đủ cột
                if (dtgsinhviên.Columns.Count >= 7)
                {
                    dtgsinhviên.Columns[0].DataPropertyName = "MaSo";
                    dtgsinhviên.Columns[1].DataPropertyName = "HoTen";
                    dtgsinhviên.Columns[2].DataPropertyName = "NgaySinh";
                    dtgsinhviên.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dtgsinhviên.Columns[3].DataPropertyName = "GioiTinh";
                    dtgsinhviên.Columns[4].DataPropertyName = "DiaChi";
                    dtgsinhviên.Columns[5].DataPropertyName = "DienThoai";
                    dtgsinhviên.Columns[6].DataPropertyName = "Makhoa";
                }
                // 2. Load dữ liệu từ SQL
                // 2.1. Lấy danh sách KHOA
                daKhoa = new SqlDataAdapter("SELECT Makhoa, Tenkhoa FROM KHOA", conn);
                dtKhoa.Clear();
                daKhoa.Fill(dtKhoa);

                // Gán dữ liệu cho ComboBox
                cbbMaKhoa.DataSource = dtKhoa;
                cbbMaKhoa.DisplayMember = "Tenkhoa";
                cbbMaKhoa.ValueMember = "Makhoa";

                // 2.2. Lấy danh sách SINH VIÊN
                da = new SqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSo ASC", conn);
                dtSinhVien.Clear();
                da.Fill(dtSinhVien);

                bs.DataSource = dtSinhVien;
                dtgsinhviên.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void HienThiThongTin(int index)
        {
            try
            {
                DataGridViewRow row = dtgsinhviên.Rows[index];

                // Chép dữ liệu từ Grid lên Textbox
                txtMSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();

                // Xử lý Ngày sinh
                if (row.Cells[2].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);

                //Xử lý Giới tính cho CheckBox ---
                bool isNam = false;
                if (row.Cells[3].Value != DBNull.Value)
                    isNam = Convert.ToBoolean(row.Cells[3].Value);

                chkGioiTinh.Checked = isNam; // Tick nếu là Nam (true), bỏ tick nếu là Nữ (false)
                                             // --------------------------------------------

                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSdt.Text = row.Cells[5].Value.ToString();

                // Xử lý ComboBox Khoa
                cbbMaKhoa.SelectedValue = row.Cells[6].Value.ToString();
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMSV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    string query = @"INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Makhoa) 
                             VALUES (@MaSo, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @Makhoa)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaSo", txtMSV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@GioiTinh", chkGioiTinh.Checked);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@Makhoa", cbbMaKhoa.SelectedValue);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");

                    LoadData(); // Cập nhật lại lưới ngay lập tức

                    txtMSV.Clear();
                    txtHoTen.Clear();
                    txtMSV.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: \n" + ex.Message);
            }
        }       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMSV.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                    return;
                }

                string maSV = txtMSV.Text;
                string tenSV = txtHoTen.Text;

                DialogResult kq = MessageBox.Show(
                    $"CẢNH BÁO: Sinh viên {tenSV} (Mã: {maSV}) có thể đang có điểm thi.\n" +
                    "Nếu xóa, TOÀN BỘ ĐIỂM THI của sinh viên này cũng sẽ bị xóa theo.\n\n" +
                    "Bạn có chắc chắn muốn xóa không?",
                    "Xác nhận xóa nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (kq == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(strConn))
                    {
                        connection.Open();

                        // BƯỚC 1: Xóa điểm thi trước (Trong bảng KetQua)
                        string sqlXoaDiem = "DELETE FROM KetQua WHERE MaSo = @MaSo";
                        SqlCommand cmdXoaDiem = new SqlCommand(sqlXoaDiem, connection);
                        cmdXoaDiem.Parameters.AddWithValue("@MaSo", maSV);
                        cmdXoaDiem.ExecuteNonQuery();

                        // BƯỚC 2: Xóa sinh viên sau (Trong bảng SinhVien)
                        string sqlXoaSV = "DELETE FROM SinhVien WHERE MaSo = @MaSo";
                        SqlCommand cmdXoaSV = new SqlCommand(sqlXoaSV, connection);
                        cmdXoaSV.Parameters.AddWithValue("@MaSo", maSV);
                        cmdXoaSV.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa sinh viên và toàn bộ điểm thi liên quan!");

                        LoadData(); // Cập nhật lại lưới

                        // Xóa trắng form
                        txtMSV.Clear();
                        txtHoTen.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể xóa: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát ứng dụng?",
               "Xác nhận thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2  // Mặc định chọn "No"
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dtgsinhviên_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng hiện tại người dùng đang chọn
            if (e.RowIndex >= 0)
            {
                HienThiThongTin(e.RowIndex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMSV.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    string query = @"UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, 
                             GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai, Makhoa = @Makhoa 
                             WHERE MaSo = @MaSo";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaSo", txtMSV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@GioiTinh", chkGioiTinh.Checked);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@Makhoa", cbbMaKhoa.SelectedValue);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Sửa thông tin sinh viên thành công!");
                    else
                        MessageBox.Show("Không tìm thấy sinh viên để sửa!");

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }
    }
}
