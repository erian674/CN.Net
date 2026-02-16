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
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            lstLopA.Items.AddRange(new string[]
            {
                "Phùng Khánh Duy",
                "Vũ Hải Luân",
                "Lê Thị Quỳnh Như",
                "Nguyễn Quốc Luân",
                "Nguyễn Hoàng Đăng Khoa",
                "Bùi Thị Lệ Thu",
                "Lê Huỳnh Thiên Sơn",
                "Lê Bích Sơn",
                "Nguyễn Hoàng Thiện",
                "Nguyễn Đình Lực",
                "Phạm Công Minh",
            });
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() != "")
            {
                lstLopA.Items.Add(txtHoTen.Text.Trim());
                txtHoTen.Clear();
                txtHoTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
            }
        }

        private void btnSang_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
        }

        private void btnSangHet_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopA.Items)
                lstLopB.Items.Add(item);

            lstLopA.Items.Clear();
        }

        private void btnVeHet_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopB.Items)
                lstLopA.Items.Add(item);

            lstLopB.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            else if (lstLopB.SelectedItem != null)
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            else
                MessageBox.Show("Chưa chọn sinh viên!");
        }
        bool isExit = false;
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
            );

            if (r == DialogResult.Yes)
            {
                isExit = true;
                Application.Exit();
            }
        }
    }
}
