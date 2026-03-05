namespace Lab_04
{
    public partial class Form1 : Form
    {
        private ImageList ImageIcons;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo ImageList và thêm các hình ảnh vào đó
            treeView1.ImageList = ImageIcons;
            // Thêm các node vào TreeView
            TreeNode goc = treeView1.Nodes.Add("Ký tự đặc biệt");
            goc.ImageIndex = 2; // dựa trên index của image list (bắt đầu từ 0);
            goc.SelectedImageIndex = 2;
            // Thêm các node con vào node goc
            TreeNode nodeCong = goc.Nodes.Add("+");
            TreeNode nodeTru = goc.Nodes.Add("-");
            TreeNode nodeNhan = goc.Nodes.Add("*");
            TreeNode nodeChia = goc.Nodes.Add("/");
            // Gán hình ảnh cho các node con
            nodeCong.ImageIndex = 4;
            nodeTru.ImageIndex = 4;
            nodeNhan.ImageIndex = 4;
            nodeChia.ImageIndex = 4;
            // Gán hình ảnh khi node được chọn
            nodeCong.SelectedImageIndex = 5;
            nodeTru.SelectedImageIndex = 5;
            nodeNhan.SelectedImageIndex = 5;
            nodeChia.SelectedImageIndex = 5;
            // Thêm node "Ký tự" và các node con từ 'a' đến 'z'
            TreeNode gockytu = treeView1.Nodes.Add("Ký tự");
            gockytu.ImageIndex = 2;
            gockytu.SelectedImageIndex = 2;
            // Thêm các node con từ 'a' đến 'z'
            for (char i = 'a'; i <= 'z'; i++)
            {
                // Thêm node con với tên là ký tự hiện tại
                TreeNode kt = gockytu.Nodes.Add(i + "");
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }
            // Thêm node "Dãy số" và các node con từ 0 đến 9
            TreeNode gocdayso = treeView1.Nodes.Add("Dãy số");
            gocdayso.ImageIndex = 2;
            gocdayso.SelectedImageIndex = 2;
            // Thêm các node con từ 0 đến 9
            for (int i = 0; i <= 9; i++)
            {
                // Thêm node con với tên là số hiện tại
                TreeNode kt = gocdayso.Nodes.Add(i.ToString());
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }
        }
    }

}
