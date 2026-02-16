namespace Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageicons;
            TreeNode goc = treeView1.Nodes.Add("Ký tự đặc biệt");
            goc.ImageIndex = 5; // dựa trên index của image list bắt đầu từ 0 
            goc.SelectedImageIndex = 5;
            TreeNode nodecong = goc.Nodes.Add("+");
            TreeNode nodetru = goc.Nodes.Add("-");
            TreeNode nodenhan = goc.Nodes.Add("*");
            TreeNode nodechia = goc.Nodes.Add("/");
            nodecong.ImageIndex = 6;
            nodetru.ImageIndex = 6;
            nodenhan.ImageIndex = 6;
            nodechia.ImageIndex = 6;

            nodecong.SelectedImageIndex = 5;
            nodetru.SelectedImageIndex = 4;
            nodenhan.SelectedImageIndex = 5;
            nodechia.SelectedImageIndex = 4;

            TreeNode gockytu = treeView1.Nodes.Add("Ký tự");
            gockytu.ImageIndex = 5; // dựa trên index của image list bắt đầu từ 0 
            gockytu.SelectedImageIndex = 5;

            for (char i = 'a'; i <= 'z'; i++)
            {
                TreeNode kt = gockytu.Nodes.Add(i + "");
                kt.ImageIndex = 6;
                kt.SelectedImageIndex = 6;
            }
            TreeNode gocdayso = treeView1.Nodes.Add("Dãy số");
            gocdayso.ImageIndex = 5; // dựa trên index của image list bắt đầu từ 0 
            gocdayso.SelectedImageIndex = 5;

            for (int i = 0; i <= 9; i++)
            {
                TreeNode ds = gocdayso.Nodes.Add(i + "");
                ds.ImageIndex = 3;
                ds.SelectedImageIndex = 4;
            }
        }
    }

}
