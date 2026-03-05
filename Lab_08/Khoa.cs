using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class Khoa : Form
    {
        // Cập nhật chuỗi kết nối với tên server và database của bạn
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        public Khoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Phương thức tải dữ liệu từ database và hiển thị lên DataGridView
        private void LoadData()
        {
            try
            {
                // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    string query = "SELECT * FROM KHOA";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // Thiết lập DataGridView để hiển thị dữ liệu
                    dgvKhoa.AutoGenerateColumns = false;
                    dgvKhoa.DataSource = dt;
                    dgvKhoa.Columns[0].DataPropertyName = "Makhoa";
                    dgvKhoa.Columns[1].DataPropertyName = "Tenkhoa";             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Chuỗi truy vấn SQL để thêm một khoa mới vào bảng KHOA
                    string query = "INSERT INTO KHOA (Makhoa, Tenkhoa) VALUES (@Makhoa, @Tenkhoa)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@Tenkhoa", txtTenKhoa.Text);
                    // Mở kết nối và thực thi câu lệnh SQL
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khoa thành công!");
                    LoadData();

                    // Làm sạch ô nhập liệu
                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();
                    txtMaKhoa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm (Có thể mã khoa đã tồn tại): \n" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Chuỗi truy vấn SQL để cập nhật thông tin của một khoa dựa trên Mã khoa
                    string query = "UPDATE KHOA SET Tenkhoa = @Tenkhoa WHERE Makhoa = @Makhoa";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@Tenkhoa", txtTenKhoa.Text);
                    // Mở kết nối và thực thi câu lệnh SQL
                    conn.Open();
                    // ExecuteNonQuery trả về số dòng bị ảnh hưởng bởi câu lệnh SQL, giúp xác định xem việc cập nhật có thành công hay không
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // Kiểm tra xem có bao nhiêu dòng bị ảnh hưởng để xác định xem việc cập nhật có thành công hay không
                    if (rowsAffected > 0)
                        MessageBox.Show("Sửa thông tin khoa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy Mã khoa này để sửa!");

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Sử dụng using để đảm bảo kết nối được đóng đúng cách
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // Chuỗi truy vấn SQL để xóa một khoa dựa trên Mã khoa
                        string query = "DELETE FROM KHOA WHERE Makhoa = @Makhoa";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);
                        // Mở kết nối và thực thi câu lệnh SQL
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa khoa thành công!");
                        LoadData();

                        txtMaKhoa.Clear();
                        txtTenKhoa.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa khoa này vì có dữ liệu liên quan (Lỗi khóa ngoại): \n" + ex.Message);
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn và hiển thị lên các TextBox
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["Makhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["Tenkhoa"].Value.ToString();
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
