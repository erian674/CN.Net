using Microsoft.Data.SqlClient;
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
    public partial class FrmMonHoc : Form
    {
        string connectionString =
        "Data Source=DESKTOP-QPEFGNO\\NHUNHU;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";
        public FrmMonHoc()
        {
            InitializeComponent();
        }
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT * FROM Mon";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
