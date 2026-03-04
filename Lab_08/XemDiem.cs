using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class XemDiem : Form
    {
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        DataTable dtSinhVien;
        public XemDiem()
        {
            InitializeComponent();
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();
        }
        private void LoadDanhSachSinhVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Lấy Mã SV, Tên SV và nối bảng KHOA để lấy luôn Tên Khoa
                    string query = @"
                        SELECT sv.MaSo, sv.HoTen, k.Tenkhoa 
                        FROM SinhVien sv 
                        LEFT JOIN KHOA k ON sv.Makhoa = k.Makhoa";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    dtSinhVien = new DataTable();
                    da.Fill(dtSinhVien);

                    // Gán dữ liệu cho cbbMaSo
                    cbbMaSo.DataSource = dtSinhVien;
                    cbbMaSo.DisplayMember = "MaSo";
                    cbbMaSo.ValueMember = "MaSo";

                    // Gán dữ liệu cho cbbTenSV (Dùng chung dtSinhVien nên 2 combobox sẽ tự đồng bộ)
                    cbbTenSV.DataSource = dtSinhVien;
                    cbbTenSV.DisplayMember = "HoTen";
                    cbbTenSV.ValueMember = "MaSo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void cbbMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (cbbMaSo.SelectedIndex >= 0 && dtSinhVien != null)
            {
                // Lấy dòng dữ liệu hiện tại đang được chọn
                DataRowView row = (DataRowView)cbbMaSo.SelectedItem;

                // Hiển thị tên khoa tương ứng lên TextBox
                txtKhoa.Text = row["Tenkhoa"].ToString();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Nối bảng KetQua và bảng Mon để lấy Tên môn học và Số tiết
                    string query = @"
                        SELECT 
                            m.MaMH, 
                            m.TenMH, 
                            m.SoTiet, 
                            kq.Diem
                        FROM KetQua kq
                        INNER JOIN Mon m ON kq.MaMH = m.MaMH
                        WHERE kq.MaSo = @MaSo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSo", cbbMaSo.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtDiem = new DataTable();
                    da.Fill(dtDiem);

                    // Cho phép DataGridView tự tạo cột dựa trên câu lệnh SQL
                    dgvDiem.AutoGenerateColumns = false;
                    dgvDiem.DataSource = dtDiem;
                    dgvDiem.Columns[0].DataPropertyName = "MaMH";
                    dgvDiem.Columns[1].DataPropertyName = "TenMH";
                    dgvDiem.Columns[2].DataPropertyName = "SoTiet";
                    dgvDiem.Columns[3].DataPropertyName = "Diem";

                    // Thông báo nếu sinh viên này chưa có điểm nào
                    if (dtDiem.Rows.Count == 0)
                    {
                        MessageBox.Show("Sinh viên này chưa có điểm môn nào!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem điểm: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát ứng dụng?",
               "Xác nhận thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
