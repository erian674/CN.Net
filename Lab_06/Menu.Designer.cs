namespace Lab_06
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
            Sinhvien = new ToolStripButton();
            QLSV = new ToolStripButton();
            ThaoTacSo = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Sinhvien, QLSV, ThaoTacSo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1440, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Sinhvien
            // 
            Sinhvien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Sinhvien.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sinhvien.Image = (Image)resources.GetObject("Sinhvien.Image");
            Sinhvien.ImageTransparentColor = Color.Magenta;
            Sinhvien.Name = "Sinhvien";
            Sinhvien.Size = new Size(105, 30);
            Sinhvien.Text = "Sinh viên";
            Sinhvien.Click += Sinhvien_Click;
            // 
            // QLSV
            // 
            QLSV.DisplayStyle = ToolStripItemDisplayStyle.Text;
            QLSV.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QLSV.Image = (Image)resources.GetObject("QLSV.Image");
            QLSV.ImageTransparentColor = Color.Magenta;
            QLSV.Name = "QLSV";
            QLSV.Size = new Size(182, 30);
            QLSV.Text = "Quản lý sinh viên";
            QLSV.Click += QLSV_Click;
            // 
            // ThaoTacSo
            // 
            ThaoTacSo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ThaoTacSo.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThaoTacSo.Image = (Image)resources.GetObject("ThaoTacSo.Image");
            ThaoTacSo.ImageTransparentColor = Color.Magenta;
            ThaoTacSo.Name = "ThaoTacSo";
            ThaoTacSo.Size = new Size(123, 30);
            ThaoTacSo.Text = "Thao tác số";
            ThaoTacSo.Click += ThaoTacSo_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 588);
            Controls.Add(toolStrip1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton Sinhvien;
        private ToolStripButton QLSV;
        private ToolStripButton ThaoTacSo;
    }
}