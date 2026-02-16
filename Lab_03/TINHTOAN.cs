namespace Lab_03
{
    public partial class TINHTOAN : Form
    {
        public TINHTOAN()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Tong = n + m;
            txtketqua.Text = Tong.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtson.Text = "";
            txtsom.Text = "";
            txtketqua.Text = "";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Tru = n - m;
            txtketqua.Text = Tru.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            double Nhan = n * m;
            txtketqua.Text = Nhan.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            if(m != 0)
            {
                double Chia = n / m;
                txtketqua.Text = Chia.ToString();
            }
            else
            {
                txtketqua.Text = "Không thể thực hiện phép chia cho 0!";
            }
        }
    }
}
