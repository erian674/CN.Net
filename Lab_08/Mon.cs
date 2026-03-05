using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class Mon : Form
    {
        // Cập nhật chuỗi kết nối với tên server và database của bạn
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        public Mon()
        {
            InitializeComponent();
        }
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Phương thức tải dữ liệu từ database và hiển thị lên DataGridView
        private void LoadData()
        {
            // Sử dụng using để đảm bảo kết nối được đóng đúng cách
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Mở kết nối
                string query = "SELECT * FROM Mon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Thiết lập DataGridView để hiển thị dữ liệu
                dgvMon.AutoGenerateColumns = false;
                dgvMon.DataSource = dt;
                dgvMon.Columns[0].DataPropertyName = "MaMH";
                dgvMon.Columns[1].DataPropertyName = "TenMH";
                dgvMon.Columns[2].DataPropertyName = "SoTiet";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Sử dụng using để đảm bảo kết nối được đóng đúng cách
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Chuỗi truy vấn SQL để thêm một môn học mới vào bảng Mon
                string query = "INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES (@MaMH, @TenMH, @SoTiet)";
                SqlCommand cmd = new SqlCommand(query, conn);
                // Thêm các tham số vào câu lệnh SQL để tránh lỗi SQL Injection
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txtSoTiet.Text));
                // Mở kết nối và thực thi câu lệnh SQL
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadData();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sử dụng using để đảm bảo kết nối được đóng đúng cách
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Chuỗi truy vấn SQL để cập nhật thông tin môn học trong bảng Mon
                string query = "UPDATE Mon SET TenMH = @TenMH, SoTiet = @SoTiet WHERE MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txtSoTiet.Text));
                // Mở kết nối và thực thi câu lệnh SQL
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Sử dụng using để đảm bảo kết nối được đóng đúng cách
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Chuỗi truy vấn SQL để xóa một môn học khỏi bảng Mon dựa trên Mã môn học
                string query = "DELETE FROM Mon WHERE MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                // Mở kết nối và thực thi câu lệnh SQL
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn và hiển thị lên các TextBox tương ứng
                DataGridViewRow row = dgvMon.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
            }
        }
    }
}
