using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TinhToan_Click(object sender, EventArgs e)
        {
            TINHTOAN f = new TINHTOAN();
            f.MdiParent = this;
            f.Show();
        }

        private void UsclnvaBcnn_Click(object sender, EventArgs e)
        {
            USVABS f = new USVABS();
            f.MdiParent = this;
            f.Show();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator f = new Calculator();
            f.MdiParent = this;
            f.Show();
        }
    }
}
