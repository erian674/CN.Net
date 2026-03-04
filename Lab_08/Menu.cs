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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Mon f = new Mon();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            NhapDiem f = new NhapDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            XemDiem f = new XemDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.MdiParent = this;
            f.Show();
        }
    }
}
