namespace Lab_08
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            toolStrip1 = new ToolStrip();
            SinhVien = new ToolStripButton();
            Khoa = new ToolStripButton();
            Mon = new ToolStripButton();
            NhapDiem = new ToolStripButton();
            XemDiem = new ToolStripButton();
            ThongKe = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            hỗTrToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SinhVien, Khoa, Mon, NhapDiem, XemDiem, ThongKe, toolStripButton4 });
            toolStrip1.Location = new Point(0, 34);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(1174, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SinhVien
            // 
            SinhVien.Font = new Font("Times New Roman", 13.2000008F);
            SinhVien.Image = (Image)resources.GetObject("SinhVien.Image");
            SinhVien.ImageTransparentColor = Color.Magenta;
            SinhVien.Name = "SinhVien";
            SinhVien.Size = new Size(128, 30);
            SinhVien.Text = "Sinh Viên";
            SinhVien.Click += toolStripButton3_Click;
            // 
            // Khoa
            // 
            Khoa.Font = new Font("Times New Roman", 13.2000008F);
            Khoa.Image = (Image)resources.GetObject("Khoa.Image");
            Khoa.ImageTransparentColor = Color.Magenta;
            Khoa.Name = "Khoa";
            Khoa.Size = new Size(86, 30);
            Khoa.Text = "Khoa";
            Khoa.Click += toolStripButton1_Click;
            // 
            // Mon
            // 
            Mon.Font = new Font("Times New Roman", 13.2000008F);
            Mon.Image = (Image)resources.GetObject("Mon.Image");
            Mon.ImageTransparentColor = Color.Magenta;
            Mon.Name = "Mon";
            Mon.Size = new Size(122, 30);
            Mon.Text = "Môn Học";
            Mon.Click += toolStripButton2_Click;
            // 
            // NhapDiem
            // 
            NhapDiem.Font = new Font("Times New Roman", 13.2000008F);
            NhapDiem.Image = (Image)resources.GetObject("NhapDiem.Image");
            NhapDiem.ImageTransparentColor = Color.Magenta;
            NhapDiem.Name = "NhapDiem";
            NhapDiem.Size = new Size(143, 30);
            NhapDiem.Text = "Nhập Điểm";
            NhapDiem.Click += toolStripButton5_Click;
            // 
            // XemDiem
            // 
            XemDiem.Font = new Font("Times New Roman", 13.2000008F);
            XemDiem.Image = (Image)resources.GetObject("XemDiem.Image");
            XemDiem.ImageTransparentColor = Color.Magenta;
            XemDiem.Name = "XemDiem";
            XemDiem.Size = new Size(137, 30);
            XemDiem.Text = "Xem Điểm";
            XemDiem.Click += toolStripButton6_Click;
            // 
            // ThongKe
            // 
            ThongKe.Font = new Font("Times New Roman", 13.2000008F);
            ThongKe.Image = (Image)resources.GetObject("ThongKe.Image");
            ThongKe.ImageTransparentColor = Color.Magenta;
            ThongKe.Name = "ThongKe";
            ThongKe.Size = new Size(185, 30);
            ThongKe.Text = "Thống Kê Khoa";
            ThongKe.Click += toolStripButton7_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(90, 30);
            toolStripButton4.Text = "Thoát";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, chứcNăngToolStripMenuItem, hỗTrToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(1174, 34);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(118, 30);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F);
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(130, 30);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // hỗTrToolStripMenuItem
            // 
            hỗTrToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F);
            hỗTrToolStripMenuItem.Name = "hỗTrToolStripMenuItem";
            hỗTrToolStripMenuItem.Size = new Size(92, 30);
            hỗTrToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 636);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Menu";
            Text = "Quản Lý Sinh viên";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton SinhVien;
        private ToolStripButton Khoa;
        private ToolStripButton Mon;
        private ToolStripButton NhapDiem;
        private ToolStripButton XemDiem;
        private ToolStripButton ThongKe;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem hỗTrToolStripMenuItem;
        private ToolStripButton toolStripButton4;
    }
}