namespace Lab_09
{
    partial class QLSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSV));
            toolStrip1 = new ToolStrip();
            Sinhvien = new ToolStripButton();
            Khoa = new ToolStripButton();
            Monhoc = new ToolStripButton();
            Ketqua = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Sinhvien, Khoa, Monhoc, Ketqua });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 35);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Sinhvien
            // 
            Sinhvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sinhvien.Image = (Image)resources.GetObject("Sinhvien.Image");
            Sinhvien.ImageTransparentColor = Color.Magenta;
            Sinhvien.Name = "Sinhvien";
            Sinhvien.Size = new Size(115, 32);
            Sinhvien.Text = "Sinh viên";
            Sinhvien.Click += Sinhvien_Click;
            // 
            // Khoa
            // 
            Khoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Khoa.Image = (Image)resources.GetObject("Khoa.Image");
            Khoa.ImageTransparentColor = Color.Magenta;
            Khoa.Name = "Khoa";
            Khoa.Size = new Size(81, 32);
            Khoa.Text = "Khoa";
            Khoa.Click += Khoa_Click;
            // 
            // Monhoc
            // 
            Monhoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Monhoc.Image = (Image)resources.GetObject("Monhoc.Image");
            Monhoc.ImageTransparentColor = Color.Magenta;
            Monhoc.Name = "Monhoc";
            Monhoc.Size = new Size(114, 32);
            Monhoc.Text = "Môn học";
            Monhoc.Click += Monhoc_Click;
            // 
            // Ketqua
            // 
            Ketqua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ketqua.Image = (Image)resources.GetObject("Ketqua.Image");
            Ketqua.ImageTransparentColor = Color.Magenta;
            Ketqua.Name = "Ketqua";
            Ketqua.Size = new Size(103, 32);
            Ketqua.Text = "Kết quả";
            Ketqua.Click += Ketqua_Click;
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "QLSV";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton Sinhvien;
        private ToolStripButton Khoa;
        private ToolStripButton Monhoc;
        private ToolStripButton Ketqua;
    }
}
