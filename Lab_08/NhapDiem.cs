using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class NhapDiem : Form
    {
        // Cập nhật chuỗi kết nối với tên server và database của bạn
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void FrmKetQua_Load(object sender, EventArgs e)
        {
            LoadComboBoxSinhVien();
            LoadComboBoxMonHoc();
            LoadData();
        }
        // Phương thức tải dữ liệu từ database và hiển thị lên ComboBox Sinh viên và DataGridView
        private void LoadComboBoxSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSo, HoTen FROM SinhVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbbMaSo.DataSource = dt;
                cbbMaSo.DisplayMember = "MaSo"; 
                cbbMaSo.ValueMember = "MaSo";
            }
        }
        // Phương thức tải dữ liệu từ database và hiển thị lên ComboBox Môn học
        private void LoadComboBoxMonHoc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMH, TenMH FROM Mon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbbMaMH.DataSource = dt;
                cbbMaMH.DisplayMember = "TenMH"; 
                cbbMaMH.ValueMember = "MaMH";    
            }
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Truy vấn SQL để lấy dữ liệu kết quả học tập, kết hợp với tên sinh viên và tên môn học
                string query = @"
                    SELECT kq.MaSo, sv.HoTen, kq.MaMH, mh.TenMH, kq.Diem
                    FROM KetQua kq
                    INNER JOIN SinhVien sv ON kq.MaSo = sv.MaSo
                    INNER JOIN Mon mh ON kq.MaMH = mh.MaMH";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Thiết lập DataGridView để hiển thị dữ liệu
                dgvKetQua.AutoGenerateColumns = false;
                dgvKetQua.DataSource = dt;
                dgvKetQua.Columns[0].DataPropertyName = "MaSo";
                dgvKetQua.Columns[1].DataPropertyName = "HoTen";
                dgvKetQua.Columns[2].DataPropertyName = "MaMH";
                dgvKetQua.Columns[3].DataPropertyName = "TenMH";
                dgvKetQua.Columns[4].DataPropertyName = "Diem";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                float diem;
                // Kiểm tra xem điểm có phải là một số hợp lệ hay không
                if (!float.TryParse(txtDiem.Text, out diem))
                {
                    MessageBox.Show("Điểm phải là một số hợp lệ!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES (@MaSo, @MaMH, @Diem)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSo", cbbMaSo.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaMH", cbbMaMH.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diem", diem);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm điểm thành công!");
                    LoadData();
                    txtDiem.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm (Có thể sinh viên này đã có điểm môn này rồi): \n" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                float diem;
                // Kiểm tra xem điểm có phải là một số hợp lệ hay không
                if (!float.TryParse(txtDiem.Text, out diem))
                {
                    MessageBox.Show("Điểm phải là một số hợp lệ!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE KetQua SET Diem = @Diem WHERE MaSo = @MaSo AND MaMH = @MaMH";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSo", cbbMaSo.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaMH", cbbMaMH.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diem", diem);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Sửa điểm thành công!");
                    else
                        MessageBox.Show("Không tìm thấy kết quả để sửa!");

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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa điểm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM KetQua WHERE MaSo = @MaSo AND MaMH = @MaMH";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSo", cbbMaSo.SelectedValue);
                        cmd.Parameters.AddWithValue("@MaMH", cbbMaMH.SelectedValue);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        txtDiem.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];
                cbbMaSo.SelectedValue = row.Cells["MaSo"].Value;
                cbbMaMH.SelectedValue = row.Cells["MaMH"].Value.ToString();
                txtDiem.Text = row.Cells["Diem"].Value.ToString();
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
