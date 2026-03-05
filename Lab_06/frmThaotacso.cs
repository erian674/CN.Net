namespace Lab_06
{
    public partial class frmThaotacso : Form
    {
        public frmThaotacso()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            int so;
            // Kiểm tra nếu người dùng nhập vào một số nguyên hợp lệ
            if (int.TryParse(txtSo.Text, out so))
            {
                ltsSo.Items.Add(so);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi");
            }
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox và tăng mỗi số lên 2
            for (int i = 0; i < ltsSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(ltsSo.Items[i]);
                ltsSo.Items[i] = x + 2;
            }
        }

        private void btnChandau_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox và chọn phần tử đầu tiên là số chẵn
            for (int i = 0; i < ltsSo.Items.Count; i++)
            {
                // Chuyển phần tử hiện tại thành số nguyên
                int x = Convert.ToInt32(ltsSo.Items[i]);
                // Kiểm tra nếu số đó là số chẵn
                if (x % 2 == 0)
                {
                    ltsSo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn");
        }

        private void btnLecuoi_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox từ cuối đến đầu và chọn phần tử cuối cùng là số lẻ
            for (int i = ltsSo.Items.Count - 1; i >= 0; i--)
            {
                int x = Convert.ToInt32(ltsSo.Items[i]);
                // Kiểm tra nếu số đó là số lẻ
                if (x % 2 != 0)
                {
                    ltsSo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ");
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có phần tử nào được chọn trong ListBox
            if (ltsSo.SelectedIndex != -1)
                ltsSo.Items.RemoveAt(ltsSo.SelectedIndex);
            else
                MessageBox.Show("Chưa chọn phần tử");
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ListBox có phần tử nào thì xóa phần tử đầu tiên
            if (ltsSo.Items.Count > 0)
                ltsSo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ListBox có phần tử nào thì xóa phần tử cuối cùng
            if (ltsSo.Items.Count > 0)
                ltsSo.Items.RemoveAt(ltsSo.Items.Count - 1);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi kết thúc chương trình
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình không?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1 // YES là mặc định
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
