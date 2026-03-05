using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }
        // Hàm kiểm tra xem Mã SV đã tồn tại trong lstDSSV hoặc lstDSDC hay chưa
        bool kiemTraMaSV(string ma)
        {
            // Duyệt qua danh sách sinh viên
            for (int i = 0; i < lstDSSV.Items.Count; i++)
            {
                // So sánh Mã SV nhập vào với Mã SV trong danh sách
                if (lstDSSV.Items[i].SubItems[1].Text == ma)
                {
                    return false;
                }
            }

            // Duyệt qua danh sách đã chọn
            for (int i = 0; i < lstDSDC.Items.Count; i++)
            {
                // So sánh Mã SV nhập vào với Mã SV trong danh sách đã chọn
                if (lstDSDC.Items[i].SubItems[1].Text == ma)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ Mã SV và Họ Tên chưa
            if (txtMsv.Text.Trim() == "" || txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
            }
            // Nếu đã nhập đủ, tiếp tục kiểm tra xem Mã SV có hợp lệ (hoặc trùng) không
            else if (kiemTraMaSV(txtMsv.Text.Trim()) == false)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo");
                txtMsv.SelectAll();
                txtHoTen.Focus();
            }
            else
            {
                // Nếu Mã SV hợp lệ, thêm sinh viên vào danh sách
                int stt = lstDSSV.Items.Count + 1;
                ListViewItem li = new ListViewItem(stt.ToString());
                // Thêm Mã SV và Họ Tên vào các cột tiếp theo của ListViewItem
                li.SubItems.Add(txtMsv.Text.Trim());
                li.SubItems.Add(txtHoTen.Text.Trim());
                lstDSSV.Items.Add(li);
                txtMsv.Clear();
                txtHoTen.Clear();
                txtMsv.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            // Duyệt qua danh sách sinh viên và xóa những sinh viên nào được chọn
            while (i < lstDSSV.Items.Count)
            {
                // Nếu sinh viên tại vị trí i được chọn, xóa nó khỏi danh sách
                if (lstDSSV.Items[i].Selected == true)
                {
                    lstDSSV.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                danhsothutu(lstDSSV);
            }
        }
        private void danhsothutu(ListView lv)
        {
            // Cập nhật lại số thứ tự cho các sinh viên trong danh sách sau khi có sự thay đổi
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận với 2 nút Yes/ No
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes thì mới thoát
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            // Thêm 5 sinh viên mẫu vào danh sách khi form được tải
            for (int i = 1; i <= 5; i++)
            {
                // Tạo một ListViewItem mới với số thứ tự là i
                ListViewItem li = new ListViewItem(i.ToString());
                li.SubItems.Add("01" + i);
                li.SubItems.Add("Như " + i);

                lstDSSV.Items.Add(li); // Sửa từ ControlAdded sang Items.Add
            }
        }
        private void tim(ListView lv, string text)
        {
            // Chuyển chuỗi tìm kiếm thành chữ hoa để so sánh không phân biệt chữ hoa thường
            text = text.ToUpper();
            // Duyệt qua tất cả các sinh viên trong danh sách và kiểm tra xem Mã SV hoặc Họ Tên có chứa chuỗi tìm kiếm hay không
            for (int i = 0; i < lv.Items.Count; i++)
            {
                // Lấy Mã SV và Họ Tên của sinh viên tại vị trí i, chuyển chúng thành chữ hoa để so sánh
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();
                // Nếu Mã SV hoặc Họ Tên chứa chuỗi tìm kiếm, chọn sinh viên đó và đảm bảo nó hiển thị trong danh sách
                if (maSV.Contains(text) || hoTen.Contains(text))
                {
                    lv.Items[i].Selected = true;
                    lv.Items[i].EnsureVisible();
                    lv.Items[i].Focused = true;
                }
                else
                {
                    lv.Items[i].Selected = false;
                }
            }
        }
        // Hàm thực hiện tìm kiếm khi người dùng nhấn Enter hoặc click vào nút Tìm Kiếm
        private void thucHienTim()
        {
            // Gọi hàm tìm kiếm với danh sách sinh viên và chuỗi tìm kiếm từ textbox
            tim(lstDSSV, txtTimKiem.Text);
            txtTimKiem.SelectAll();
            txtTimKiem.Focus();
        }

        private void btnTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu người dùng nhấn phím Enter, thực hiện tìm kiếm
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                thucHienTim();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            thucHienTim();
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            int i = 0;
            // Duyệt qua danh sách sinh viên và chuyển những sinh viên nào được chọn sang danh sách đã chọn
            while (i < lstDSSV.Items.Count)
            {
                // Nếu sinh viên tại vị trí i được chọn, tạo một bản sao của nó và thêm vào danh sách đã chọn, sau đó xóa nó khỏi danh sách sinh viên
                if (lstDSSV.Items[i].Selected)
                {
                    // ⭐ CLONE: Tạo một bản sao của ListViewItem tại vị trí i để tránh việc tham chiếu đến cùng một đối tượng
                    ListViewItem li = (ListViewItem)lstDSSV.Items[i].Clone();

                    lstDSDC.Items.Add(li);
                    lstDSSV.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            danhsothutu(lstDSSV);
            danhsothutu(lstDSDC);
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            // Duyệt qua danh sách đã chọn và chuyển những sinh viên nào được chọn trở lại danh sách sinh viên
            int i = 0;
            while (i < lstDSDC.Items.Count)
            {
                // Nếu sinh viên tại vị trí i được chọn, tạo một bản sao của nó và thêm vào danh sách sinh viên, sau đó xóa nó khỏi danh sách đã chọn
                if (lstDSDC.Items[i].Selected)
                {
                    ListViewItem li = (ListViewItem)lstDSDC.Items[i].Clone(); // ⭐ CLONE

                    lstDSSV.Items.Add(li);
                    lstDSDC.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            danhsothutu(lstDSDC);
            danhsothutu(lstDSSV);
        }

        private void btnSangHet_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả sinh viên trong danh sách sinh viên và chuyển tất cả sang danh sách đã chọn
            while (lstDSSV.Items.Count > 0)
            {
                ListViewItem li = (ListViewItem)lstDSSV.Items[0].Clone(); // ⭐ CLONE

                lstDSDC.Items.Add(li);
                lstDSSV.Items.RemoveAt(0);
            }

            danhsothutu(lstDSSV);
            danhsothutu(lstDSDC);
        }

        private void btnVeHet_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả sinh viên trong danh sách đã chọn và chuyển tất cả trở lại danh sách sinh viên
            while (lstDSDC.Items.Count > 0)
            {
                ListViewItem li = (ListViewItem)lstDSDC.Items[0].Clone(); // ⭐ CLONE

                lstDSSV.Items.Add(li);
                lstDSDC.Items.RemoveAt(0);
            }

            danhsothutu(lstDSDC);
            danhsothutu(lstDSSV);
        }
    }
}
