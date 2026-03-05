namespace Lab_03
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
            TinhToan = new ToolStripButton();
            UsclnvaBcnn = new ToolStripButton();
            Calculator = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TinhToan, UsclnvaBcnn, Calculator });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(1294, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TinhToan
            // 
            TinhToan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TinhToan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TinhToan.Image = (Image)resources.GetObject("TinhToan.Image");
            TinhToan.ImageTransparentColor = Color.Magenta;
            TinhToan.Name = "TinhToan";
            TinhToan.Size = new Size(106, 30);
            TinhToan.Text = "Tính toán";
            TinhToan.Click += TinhToan_Click;
            // 
            // UsclnvaBcnn
            // 
            UsclnvaBcnn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UsclnvaBcnn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsclnvaBcnn.Image = (Image)resources.GetObject("UsclnvaBcnn.Image");
            UsclnvaBcnn.ImageTransparentColor = Color.Magenta;
            UsclnvaBcnn.Name = "UsclnvaBcnn";
            UsclnvaBcnn.Size = new Size(176, 30);
            UsclnvaBcnn.Text = "Ước số và Bội số";
            UsclnvaBcnn.Click += UsclnvaBcnn_Click;
            // 
            // Calculator
            // 
            Calculator.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Calculator.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculator.Image = (Image)resources.GetObject("Calculator.Image");
            Calculator.ImageTransparentColor = Color.Magenta;
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(111, 30);
            Calculator.Text = "Calculator";
            Calculator.Click += Calculator_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 651);
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
        private ToolStripButton TinhToan;
        private ToolStripButton UsclnvaBcnn;
        private ToolStripButton Calculator;
    }
}