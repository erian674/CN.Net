using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class FrmKhoa : Form
    {
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM KHOA";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO KHOA (Makhoa, Tenkhoa) VALUES (@Makhoa, @Tenkhoa)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@Tenkhoa", txtTenKhoa.Text);

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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE KHOA SET Tenkhoa = @Tenkhoa WHERE Makhoa = @Makhoa";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@Tenkhoa", txtTenKhoa.Text);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

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
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM KHOA WHERE Makhoa = @Makhoa";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Makhoa", txtMaKhoa.Text);

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
            if (e.RowIndex >= 0)
            {
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
