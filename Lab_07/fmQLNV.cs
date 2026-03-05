namespace Lab_07
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            // Tạo thông tin mẫu cho ListView
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ("Như " + i.ToString());
                item.SubItems.Add("06/07/200" + i);
                item.SubItems.Add("11/3 Ấp Suối Son " + i.ToString());
                item.SubItems.Add("0868667690");
                lvDanhSachNhanVien.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tất cả các trường đều đã được nhập
            if (txtHoten.Text.Trim().Length > 0 && txtDiachi.Text.Trim().Length > 0 && txtSdt.Text.Trim().Length > 0)
            {
                ListViewItem item = new ListViewItem(txtHoten.Text);
                // Định dạng ngày sinh theo kiểu "dd/MM/yyyy"
                item.Text = txtHoten.Text;
                item.SubItems.Add(dtpNgaysinh.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(txtDiachi.Text);
                item.SubItems.Add(txtSdt.Text);
                lvDanhSachNhanVien.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có một nhân viên được chọn trong ListView
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    lvDanhSachNhanVien.Items.Remove(lvDanhSachNhanVien.SelectedItems[0]);
                    txtHoten.Text = "";
                    dtpNgaysinh.Value = DateTime.Now;
                    txtDiachi.Text = "";
                    txtSdt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có một nhân viên được chọn trong ListView
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn sửa thông tin nhân viên này không?",
                    "Xác nhận sửa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                // Nếu Yes → cập nhật thông tin nhân viên trong ListView bằng giá trị mới từ các TextBox và DateTimePicker
                if (result == DialogResult.Yes)
                {
                    // Cập nhật thông tin nhân viên trong ListView
                    lvDanhSachNhanVien.SelectedItems[0].SubItems[0].Text = txtHoten.Text;
                    lvDanhSachNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaysinh.Value.ToString("dd/MM/yyyy");
                    lvDanhSachNhanVien.SelectedItems[0].SubItems[2].Text = txtDiachi.Text;
                    lvDanhSachNhanVien.SelectedItems[0].SubItems[3].Text = txtSdt.Text;

                    MessageBox.Show(
                        "Sửa thông tin nhân viên thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                // Nếu No → không làm gì cả
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát ứng dụng?",
               "Xác nhận thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2  // Mặc định chọn "No"
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
