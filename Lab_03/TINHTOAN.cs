namespace Lab_03
{
    public partial class TINHTOAN : Form
    {
        public TINHTOAN()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox, chuyển đổi sang kiểu số thực và thực hiện phép cộng
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Tong = n + m;
            txtketqua.Text = Tong.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của các TextBox và Label kết quả
            txtson.Text = "";
            txtsom.Text = "";
            txtketqua.Text = "";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox, chuyển đổi sang kiểu số thực và thực hiện phép trừ
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Tru = n - m;
            txtketqua.Text = Tru.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox, chuyển đổi sang kiểu số thực và thực hiện phép nhân
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Nhan = n * m;
            txtketqua.Text = Nhan.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox, chuyển đổi sang kiểu số thực và thực hiện phép chia
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            // Kiểm tra nếu m khác 0 mới thực hiện phép chia, tránh lỗi chia cho 0
            if (m != 0)
            {
                double Chia = n / m;
                txtketqua.Text = Chia.ToString();
            }
            else
            {
                txtketqua.Text = "Không thể thực hiện phép chia cho 0!";
            }
        }
    }
}
