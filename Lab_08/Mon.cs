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
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Mon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMon.AutoGenerateColumns = false;
                dgvMon.DataSource = dt;
                dgvMon.Columns[0].DataPropertyName = "MaMH";
                dgvMon.Columns[1].DataPropertyName = "TenMH";
                dgvMon.Columns[2].DataPropertyName = "SoTiet";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES (@MaMH, @TenMH, @SoTiet)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txtSoTiet.Text));

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Mon SET TenMH = @TenMH, SoTiet = @SoTiet WHERE MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txtSoTiet.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Mon WHERE MaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMon.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
            }
        }
    }
}
