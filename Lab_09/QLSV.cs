using Lab_09.Models;
using Microsoft.EntityFrameworkCore;
namespace Lab_09
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void Sinhvien_Click(object sender, EventArgs e)
        {
            FrmSinhVien f = new FrmSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void Khoa_Click(object sender, EventArgs e)
        {
            FrmKhoa f = new FrmKhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void Monhoc_Click(object sender, EventArgs e)
        {
            FrmMonHoc f = new FrmMonHoc();
            f.MdiParent = this;
            f.Show();
        }

        private void Ketqua_Click(object sender, EventArgs e)
        {
            FrmKetQua f = new FrmKetQua();
            f.MdiParent = this;
            f.Show();
        }
    }
}
