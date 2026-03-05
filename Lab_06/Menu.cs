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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Sinhvien_Click(object sender, EventArgs e)
        {
            frmSinhvien f = new frmSinhvien();
            f.MdiParent = this;
            f.Show();
        }

        private void QLSV_Click(object sender, EventArgs e)
        {
            frmQLSV f = new frmQLSV();
            f.MdiParent = this;
            f.Show();
        }

        private void ThaoTacSo_Click(object sender, EventArgs e)
        {
            frmThaotacso f = new frmThaotacso();
            f.MdiParent = this;
            f.Show();
        }
    }
}
