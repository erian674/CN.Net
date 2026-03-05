namespace Lab_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetPay()
        {
            // Biến lưu tổng tiền
            double total = 0;
            // 1. kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(tbfullname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo ");
                return;
            }
            //2.Tính toán
            if (ckcaovoi.Checked) total += 100000;
            if (cktaytrang.Checked) total += 1200000;
            if (ckchuphinhrang.Checked) total += 200000;
            total += ((int)sorangtram.Value * 80000);
            //3. Hiển thị kết quả
            tbtongtien.Text = total.ToString();
        }
        private void btntinhtien_Click(object sender, EventArgs e)
        {
            // Gọi hàm tính tiền khi nhấn nút
            GetPay();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tổng tiền chưa được tính hoặc tên khách hàng chưa nhập
            string info = tbfullname.Text + "-" + tbtongtien.Text;
            listkhachhang.Items.Add(info);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            if ((MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                this.Close();
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có mục nào được chọn trong ListBox
            if (listkhachhang.SelectedIndex != -1)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn hay không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // Xóa mục tại vị trí đang chọn
                    listkhachhang.Items.RemoveAt(listkhachhang.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để xóa!", "Thông báo");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Sử dụng try-catch để xử lý lỗi khi lưu file
            try
            {
                // Khởi tạo hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Chọn nơi lưu danh sách khách hàng";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    // Sử dụng StreamWriter để ghi dữ liệu vào file đã chọn
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        foreach (var item in listkhachhang.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Đã lưu danh sách vào tệp thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
            }
        }

        private void btntai_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Bộ lọc định dạng file 
            openFileDialog.Title = "Chọn tệp dữ liệu khách hàng để tải";
            // Sử dụng try-catch để xử lý lỗi khi đọc file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listkhachhang.Items.Clear(); // Xóa danh sách hiện tại trước khi tải mới [cite: 435]

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listkhachhang.Items.Add(line); // Nạp từng dòng vào ListBox [cite: 435]
                        }
                    }
                    MessageBox.Show("Đã tải dữ liệu từ tệp lên danh sách!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message);
                }
            }
        }
    }
}
