namespace Lab_03
{
    partial class USVABS
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
            groupBox1 = new GroupBox();
            txtA = new TextBox();
            txtB = new TextBox();
            lblB = new Label();
            lblA = new Label();
            groupBox2 = new GroupBox();
            raBSCNN = new RadioButton();
            raUSCLN = new RadioButton();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnBoqua = new Button();
            btnTim = new Button();
            txtKetqua = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(lblB);
            groupBox1.Controls.Add(lblA);
            groupBox1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtA
            // 
            txtA.BackColor = Color.MistyRose;
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Font = new Font("Times New Roman", 13.2000008F);
            txtA.Location = new Point(47, 50);
            txtA.Margin = new Padding(4);
            txtA.Name = "txtA";
            txtA.Size = new Size(500, 33);
            txtA.TabIndex = 4;
            txtA.TextAlign = HorizontalAlignment.Center;
            // 
            // txtB
            // 
            txtB.BackColor = Color.MistyRose;
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Font = new Font("Times New Roman", 13.2000008F);
            txtB.Location = new Point(47, 114);
            txtB.Margin = new Padding(4);
            txtB.Name = "txtB";
            txtB.Size = new Size(500, 33);
            txtB.TabIndex = 5;
            txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblB.Location = new Point(9, 114);
            lblB.Margin = new Padding(4, 0, 4, 0);
            lblB.Name = "lblB";
            lblB.Size = new Size(26, 26);
            lblB.TabIndex = 2;
            lblB.Text = "B";
            lblB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.Location = new Point(7, 50);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(28, 26);
            lblA.TabIndex = 3;
            lblA.Text = "A";
            lblA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(raBSCNN);
            groupBox2.Controls.Add(raUSCLN);
            groupBox2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(575, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 170);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tìm";
            // 
            // raBSCNN
            // 
            raBSCNN.AutoSize = true;
            raBSCNN.BackColor = Color.Linen;
            raBSCNN.Location = new Point(6, 105);
            raBSCNN.Name = "raBSCNN";
            raBSCNN.Size = new Size(107, 30);
            raBSCNN.TabIndex = 1;
            raBSCNN.TabStop = true;
            raBSCNN.Text = "BSCNN";
            raBSCNN.UseVisualStyleBackColor = false;
            // 
            // raUSCLN
            // 
            raUSCLN.AutoSize = true;
            raUSCLN.BackColor = Color.Linen;
            raUSCLN.Location = new Point(6, 49);
            raUSCLN.Name = "raUSCLN";
            raUSCLN.Size = new Size(105, 30);
            raUSCLN.TabIndex = 0;
            raUSCLN.TabStop = true;
            raUSCLN.Text = "USCLN";
            raUSCLN.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnBoqua);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(txtKetqua);
            groupBox3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 188);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(785, 170);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Coral;
            btnThoat.Location = new Point(541, 90);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 59);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBoqua
            // 
            btnBoqua.BackColor = Color.PaleGreen;
            btnBoqua.Location = new Point(341, 90);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(118, 59);
            btnBoqua.TabIndex = 5;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = false;
            btnBoqua.Click += btnBoqua_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Khaki;
            btnTim.Location = new Point(142, 90);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(118, 59);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtKetqua
            // 
            txtKetqua.BackColor = Color.Bisque;
            txtKetqua.BorderStyle = BorderStyle.FixedSingle;
            txtKetqua.Font = new Font("Times New Roman", 13.2000008F);
            txtKetqua.Location = new Point(10, 33);
            txtKetqua.Margin = new Padding(4);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.ReadOnly = true;
            txtKetqua.Size = new Size(768, 33);
            txtKetqua.TabIndex = 4;
            txtKetqua.TextAlign = HorizontalAlignment.Center;
            // 
            // USVABS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 374);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "USVABS";
            Text = "Ước số chung lớn nhất và Bội số chung nhỏ nhất";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblB;
        private Label lblA;
        private GroupBox groupBox2;
        private RadioButton raUSCLN;
        private RadioButton raBSCNN;
        private GroupBox groupBox3;
        private Button btnThoat;
        private Button btnBoqua;
        private Button btnTim;
        private TextBox txtKetqua;
    }
}