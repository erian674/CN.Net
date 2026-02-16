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
    public partial class Calculator : Form
    {
        double so1 = 0, so2 = 0;
        double kq = 0;
        char pt;
        char error = 'E';
        public Calculator()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            pt = '+';
            so1 = double.Parse(txtCode.Text);
            txtCode.Text = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCode.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCode.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCode.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCode.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCode.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCode.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCode.Text = "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCode.Text = "0";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = double.Parse(txtCode.Text);
            txtCode.Text = "";
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = double.Parse(txtCode.Text);
            txtCode.Text = "";
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = double.Parse(txtCode.Text);
            txtCode.Text = "";
        }
        public void Tinh(double n1, double n2, char pt)
        {
            double kq = 0;
            switch (pt)
            {
                case '+':
                    kq = n1 + n2;
                    break;
                case '-':
                    kq = n1 - n2;
                    break;
                case '*':
                    kq = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        MessageBox.Show("Không thể thực hiện phép chia cho 0!");
                    }
                    else
                    {
                        kq = n1 / n2;
                    }
                    break;
            }
            txtCode.Text = kq.ToString();
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(txtCode.Text);
            Tinh(so1, so2, pt);
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtCode.Text);
            so1 *= -1;
            txtCode.Text = so1.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }
    }
}
