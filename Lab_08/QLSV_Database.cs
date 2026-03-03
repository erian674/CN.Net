using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class QLSV_Database : Form
    {
        string strConn = "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection conn;
        SqlDataAdapter da;
        SqlDataAdapter daKhoa;
        DataTable dtSinhVien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        public QLSV_Database()
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

                if (dtgsinhviên.Columns.Count >= 7)
                {
                    dtgsinhviên.Columns[0].DataPropertyName = "MaSo";
                    dtgsinhviên.Columns[1].DataPropertyName = "HoTen";
                    dtgsinhviên.Columns[2].DataPropertyName = "NgaySinh";
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

                // 2.2. Lấy danh sách SINH VIÊN
                da = new SqlDataAdapter("SELECT * FROM SinhVien ORDER BY MaSo ASC", conn);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                dtSinhVien.Clear();
                da.Fill(dtSinhVien);

                // 3. Gán dữ liệu cho ComboBox
                cbbMaKhoa.DataSource = dtKhoa;
                cbbMaKhoa.DisplayMember = "Tenkhoa";
                cbbMaKhoa.ValueMember = "Makhoa";

                bs.DataSource = dtSinhVien;
                dtgsinhviên.DataSource = bs;
                if (dtgsinhviên.Rows.Count > 0)
                {
                    HienThiThongTin(0);
                }
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

                // Xử lý Ngày sinh (cần kiểm tra null)
                if (row.Cells[2].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);

                // Xử lý Giới tính
                bool isNam = false;
                if (row.Cells[3].Value != DBNull.Value)
                    isNam = Convert.ToBoolean(row.Cells[3].Value);
                raNam.Checked = isNam;
                raNu.Checked = !isNam;

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
                // 1. Kiểm tra trùng mã trên lưới (RAM)
                string maMoi = txtMSV.Text;
                DataRow[] kiemTra = dtSinhVien.Select("MaSo = '" + maMoi + "'");
                if (kiemTra.Length > 0)
                {
                    MessageBox.Show("Mã này đã có trong danh sách rồi!");
                    return;
                }

                // 2. Tạo dòng mới và thêm vào DataTable
                DataRow row = dtSinhVien.NewRow();
                row["MaSo"] = txtMSV.Text;
                row["HoTen"] = txtHoTen.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                row["GioiTinh"] = raNam.Checked;
                row["DiaChi"] = txtDiaChi.Text;
                row["DienThoai"] = txtSdt.Text;
                row["Makhoa"] = cbbMaKhoa.SelectedValue;

                dtSinhVien.Rows.Add(row);

                MessageBox.Show("Đã thêm vào danh sách tạm (Nhớ bấm LƯU để ghi xuống CSDL).");

                // Xóa trắng để nhập tiếp nếu thích
                txtMSV.Text = "";
                txtHoTen.Text = "";
                txtMSV.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem có thay đổi gì trong bảng không
                DataTable changes = dtSinhVien.GetChanges();

                if (changes != null)
                {
                    // 2. Gửi tất cả thay đổi xuống SQL Server
                    int ketQua = da.Update(dtSinhVien);

                    if (ketQua > 0)
                    {
                        MessageBox.Show($"Đã lưu thành công {ketQua} thay đổi xuống CSDL!", "Thành công");

                        // 3. Chấp nhận các thay đổi để đồng bộ trạng thái
                        dtSinhVien.AcceptChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Không có gì mới để lưu cả!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu (Có thể trùng Mã hoặc sai dữ liệu):\n" + ex.Message);

                // Nếu lỗi thì nên tải lại dữ liệu cũ để tránh sai lệch
                LoadData(); 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có dòng nào được chọn không
            if (bs.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            // 2. Lấy Mã số và Tên của sinh viên đang chọn
            DataRowView row = (DataRowView)bs.Current;
            string maSV = row["MaSo"].ToString();
            string tenSV = row["HoTen"].ToString();

            // 3. Hỏi xác nhận kỹ hơn (Vì xóa là mất hết điểm)
            DialogResult kq = MessageBox.Show(
                $"CẢNH BÁO: Sinh viên {tenSV} (Mã: {maSV}) có thể đang có điểm thi.\n" +
                "Nếu xóa, TOÀN BỘ ĐIỂM THI của sinh viên này cũng sẽ bị xóa theo.\n\n" +
                "Bạn có chắc chắn muốn xóa không?",
                "Xác nhận xóa nguy hiểm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True");

                try
                {
                    connection.Open();

                    // --- BƯỚC 1: XÓA ĐIỂM THI TRƯỚC (Trong bảng KetQua) ---
                    string sqlXoaDiem = "DELETE FROM KetQua WHERE MaSo = '" + maSV + "'";
                    SqlCommand cmdXoaDiem = new SqlCommand(sqlXoaDiem, connection);
                    cmdXoaDiem.ExecuteNonQuery(); // Thực thi lệnh xóa điểm

                    // --- BƯỚC 2: XÓA SINH VIÊN SAU (Trong bảng SinhVien) ---
                    string sqlXoaSV = "DELETE FROM SinhVien WHERE MaSo = '" + maSV + "'";
                    SqlCommand cmdXoaSV = new SqlCommand(sqlXoaSV, connection);
                    int result = cmdXoaSV.ExecuteNonQuery(); // Thực thi lệnh xóa SV

                    if (result > 0)
                    {
                        MessageBox.Show("Đã xóa sinh viên và toàn bộ điểm thi liên quan!");

                        // --- BƯỚC 3: CẬP NHẬT LẠI GIAO DIỆN ---
                        bs.RemoveCurrent();

                        // Hoặc chắc ăn nhất là gọi lại hàm LoadData()
                        LoadData(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể xóa: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
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

        private void dtgsinhviên_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang vẽ cột "GioiTinh"
            if (dtgsinhviên.Columns[e.ColumnIndex].DataPropertyName == "GioiTinh")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Chuyển đổi giá trị bit/bool sang chuỗi
                    bool isMale = (bool)e.Value;
                    e.Value = isMale ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
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
                if (dtgsinhviên.CurrentRow == null) return;

                // Lấy dòng đang chọn dựa trên chỉ số Index của lưới
                int index = dtgsinhviên.CurrentRow.Index;
                DataRow row = dtSinhVien.Rows[index];

                // Cập nhật dữ liệu vào dòng đó
                row.BeginEdit(); // Bắt đầu sửa
                row["HoTen"] = txtHoTen.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                row["GioiTinh"] = raNam.Checked;
                row["DiaChi"] = txtDiaChi.Text;
                row["DienThoai"] = txtSdt.Text;
                row["Makhoa"] = cbbMaKhoa.SelectedValue;
                row.EndEdit();   // Kết thúc sửa

                MessageBox.Show("Đã sửa xong trên lưới. Hãy bấm LƯU để hoàn tất.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
