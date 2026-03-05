using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_03
{
    public partial class USVABS : Form
    {
        public USVABS()
        {
            InitializeComponent();
        }
        public int TimUSCLN(int a, int b)
        {
            // Sử dụng thuật toán Euclid để tìm USCLN
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        public int TimBSCNN(int a, int b)
        {
            // BSCNN có thể được tính bằng công thức: BSCNN(a, b) = (a * b) / USCLN(a, b)
            return (a * b) / TimUSCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox và chuyển đổi sang kiểu int
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Kiểm tra xem người dùng đã chọn USCLN hay BSCNN
            if (raUSCLN.Checked)
            {
                txtKetqua.Text = TimUSCLN(a, b).ToString();
            }
            else if (raBSCNN.Checked)
            {
                txtKetqua.Text = TimBSCNN(a, b).ToString();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của các TextBox và bỏ chọn các RadioButton
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
            raUSCLN.Checked = false;
            raBSCNN.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát ứng dụng
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
