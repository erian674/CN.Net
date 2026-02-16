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
        bool kiemTraMaSV(string ma)
        {
            for (int i = 0; i < lstDSSV.Items.Count; i++)
            {
                if (lstDSSV.Items[i].SubItems[1].Text == ma)
                {
                    return false;
                }
            }

            // Duyệt qua danh sách đã chọn (ảnh 3)
            for (int i = 0; i < lstDSDC.Items.Count; i++)
            {
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
                int stt = lstDSSV.Items.Count + 1;
                ListViewItem li = new ListViewItem(stt.ToString());

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
            while (i < lstDSSV.Items.Count)
            {
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
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem li = new ListViewItem(i.ToString());
                li.SubItems.Add("01" + i);
                li.SubItems.Add("Như " + i);

                lstDSSV.Items.Add(li); // Sửa từ ControlAdded sang Items.Add
            }
        }
        private void tim(ListView lv, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();

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
        private void thucHienTim()
        {
            tim(lstDSSV, txtTimKiem.Text);
            txtTimKiem.SelectAll();
            txtTimKiem.Focus();
        }

        private void btnTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            while (i < lstDSSV.Items.Count)
            {
                if (lstDSSV.Items[i].Selected)
                {
                    ListViewItem li = (ListViewItem)lstDSSV.Items[i].Clone(); // ⭐ CLONE

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
            int i = 0;
            while (i < lstDSDC.Items.Count)
            {
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
