using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class ThongKe : Form
    {
        string strConn = "Data Source=DESKTOP-QPEFGNO\\NHU;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True";
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoa();
        }
        private void LoadComboBoxKhoa()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string query = "SELECT Makhoa, Tenkhoa FROM KHOA";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbbKhoa.DataSource = dt;
                    cbbKhoa.DisplayMember = "Tenkhoa"; // Hiện tên khoa
                    cbbKhoa.ValueMember = "Makhoa";    // Lấy mã khoa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khoa: " + ex.Message);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn khoa chưa
                if (cbbKhoa.SelectedValue == null) return;

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    // Truy vấn sinh viên theo mã khoa đã chọn
                    string query = @"
                        SELECT MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai
                        FROM SinhVien 
                        WHERE Makhoa = @MaKhoa";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKhoa", cbbKhoa.SelectedValue.ToString());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtResult = new DataTable();
                    da.Fill(dtResult);

                    // Hiển thị lên lưới
                    dgvThongKe.AutoGenerateColumns = false;
                    dgvThongKe.DataSource = dtResult;
                    dgvThongKe.Columns[0].DataPropertyName = "MaSo";
                    dgvThongKe.Columns[1].DataPropertyName = "HoTen";
                    dgvThongKe.Columns[2].DataPropertyName = "NgaySinh";
                    dgvThongKe.Columns[3].DataPropertyName = "GioiTinh";
                    dgvThongKe.Columns[4].DataPropertyName = "DiaChi";
                    dgvThongKe.Columns[5].DataPropertyName = "DienThoai";
                    // 3. Hiển thị tổng số sinh viên đếm được
                    lblTongSo.Text = "Tổng số sinh viên: " + dtResult.Rows.Count.ToString();

                    if (dtResult.Rows.Count == 0)
                    {
                        MessageBox.Show("Khoa này hiện chưa có sinh viên nào!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
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