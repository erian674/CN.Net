namespace Lab_05
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnthem = new Button();
            tbtongtien = new TextBox();
            label7 = new Label();
            btnthoat = new Button();
            btntinhtien = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            sorangtram = new NumericUpDown();
            label2 = new Label();
            ckchuphinhrang = new CheckBox();
            cktaytrang = new CheckBox();
            ckcaovoi = new CheckBox();
            tbfullname = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnxoa = new Button();
            btntai = new Button();
            btnluu = new Button();
            listkhachhang = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sorangtram).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(tbtongtien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnthoat);
            groupBox1.Controls.Add(btntinhtien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(sorangtram);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ckchuphinhrang);
            groupBox1.Controls.Add(cktaytrang);
            groupBox1.Controls.Add(ckcaovoi);
            groupBox1.Controls.Add(tbfullname);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 13.2000008F);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(573, 454);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý thanh toán";
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Thistle;
            btnthem.ForeColor = SystemColors.ActiveCaptionText;
            btnthem.Location = new Point(319, 349);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(228, 34);
            btnthem.TabIndex = 16;
            btnthem.Text = "Thêm vào danh sách";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // tbtongtien
            // 
            tbtongtien.Location = new Point(120, 302);
            tbtongtien.Margin = new Padding(3, 2, 3, 2);
            tbtongtien.Name = "tbtongtien";
            tbtongtien.Size = new Size(427, 33);
            tbtongtien.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 302);
            label7.Name = "label7";
            label7.Size = new Size(101, 26);
            label7.TabIndex = 14;
            label7.Text = "Tổng tiền";
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Thistle;
            btnthoat.ForeColor = SystemColors.ActiveCaptionText;
            btnthoat.Location = new Point(87, 402);
            btnthoat.Margin = new Padding(3, 2, 3, 2);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(402, 34);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // btntinhtien
            // 
            btntinhtien.BackColor = Color.Thistle;
            btntinhtien.ForeColor = SystemColors.ActiveCaptionText;
            btntinhtien.Location = new Point(14, 349);
            btntinhtien.Margin = new Padding(3, 2, 3, 2);
            btntinhtien.Name = "btntinhtien";
            btntinhtien.Size = new Size(207, 34);
            btntinhtien.TabIndex = 12;
            btntinhtien.Text = "Tính  tổng tiền";
            btntinhtien.UseVisualStyleBackColor = false;
            btntinhtien.Click += btntinhtien_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 248);
            label6.Name = "label6";
            label6.Size = new Size(91, 26);
            label6.TabIndex = 11;
            label6.Text = "80.000 đ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 185);
            label5.Name = "label5";
            label5.Size = new Size(102, 26);
            label5.TabIndex = 10;
            label5.Text = "200.000 đ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 145);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 9;
            label4.Text = "1.200.000 đ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 99);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 8;
            label3.Text = "100.000 đ";
            // 
            // sorangtram
            // 
            sorangtram.Location = new Point(120, 241);
            sorangtram.Margin = new Padding(3, 2, 3, 2);
            sorangtram.Name = "sorangtram";
            sorangtram.Size = new Size(319, 33);
            sorangtram.TabIndex = 7;
            sorangtram.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 243);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 5;
            label2.Text = "Trám răng";
            // 
            // ckchuphinhrang
            // 
            ckchuphinhrang.AutoSize = true;
            ckchuphinhrang.Location = new Point(14, 181);
            ckchuphinhrang.Margin = new Padding(3, 2, 3, 2);
            ckchuphinhrang.Name = "ckchuphinhrang";
            ckchuphinhrang.Size = new Size(180, 30);
            ckchuphinhrang.TabIndex = 4;
            ckchuphinhrang.Text = "Chụp hình răng";
            ckchuphinhrang.UseVisualStyleBackColor = true;
            // 
            // cktaytrang
            // 
            cktaytrang.AutoSize = true;
            cktaytrang.Location = new Point(14, 141);
            cktaytrang.Margin = new Padding(3, 2, 3, 2);
            cktaytrang.Name = "cktaytrang";
            cktaytrang.Size = new Size(176, 30);
            cktaytrang.TabIndex = 3;
            cktaytrang.Text = "Tẩy trắng răng ";
            cktaytrang.UseVisualStyleBackColor = true;
            // 
            // ckcaovoi
            // 
            ckcaovoi.AutoSize = true;
            ckcaovoi.Location = new Point(14, 95);
            ckcaovoi.Margin = new Padding(3, 2, 3, 2);
            ckcaovoi.Name = "ckcaovoi";
            ckcaovoi.Size = new Size(107, 30);
            ckcaovoi.TabIndex = 2;
            ckcaovoi.Text = "Cạo vôi";
            ckcaovoi.UseVisualStyleBackColor = true;
            // 
            // tbfullname
            // 
            tbfullname.Location = new Point(173, 38);
            tbfullname.Margin = new Padding(3, 2, 3, 2);
            tbfullname.Name = "tbfullname";
            tbfullname.Size = new Size(394, 33);
            tbfullname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(161, 26);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.GhostWhite;
            groupBox2.Controls.Add(btnxoa);
            groupBox2.Controls.Add(btntai);
            groupBox2.Controls.Add(btnluu);
            groupBox2.Controls.Add(listkhachhang);
            groupBox2.Font = new Font("Times New Roman", 13.2000008F);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(623, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(606, 454);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.LavenderBlush;
            btnxoa.ForeColor = SystemColors.ActiveCaptionText;
            btnxoa.Location = new Point(190, 402);
            btnxoa.Margin = new Padding(3, 2, 3, 2);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(213, 34);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xóa khách hàng";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btntai
            // 
            btntai.BackColor = Color.LavenderBlush;
            btntai.ForeColor = SystemColors.ActiveCaptionText;
            btntai.Location = new Point(434, 338);
            btntai.Margin = new Padding(3, 2, 3, 2);
            btntai.Name = "btntai";
            btntai.Size = new Size(135, 34);
            btntai.TabIndex = 2;
            btntai.Text = "Tải file";
            btntai.UseVisualStyleBackColor = false;
            btntai.Click += btntai_Click;
            // 
            // btnluu
            // 
            btnluu.BackColor = Color.LavenderBlush;
            btnluu.ForeColor = SystemColors.ActiveCaptionText;
            btnluu.Location = new Point(45, 338);
            btnluu.Margin = new Padding(3, 2, 3, 2);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(135, 34);
            btnluu.TabIndex = 1;
            btnluu.Text = "Lưu file";
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
            // 
            // listkhachhang
            // 
            listkhachhang.ForeColor = SystemColors.InfoText;
            listkhachhang.FormattingEnabled = true;
            listkhachhang.ItemHeight = 25;
            listkhachhang.Location = new Point(45, 55);
            listkhachhang.Margin = new Padding(3, 2, 3, 2);
            listkhachhang.Name = "listkhachhang";
            listkhachhang.Size = new Size(524, 229);
            listkhachhang.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1241, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sorangtram).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ckcaovoi;
        private TextBox tbfullname;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox cktaytrang;
        private Label label2;
        private CheckBox ckchuphinhrang;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown sorangtram;
        private Button btntinhtien;
        private Label label6;
        private Button btnthem;
        private TextBox tbtongtien;
        private Label label7;
        private Button btnthoat;
        private Button btntai;
        private Button btnluu;
        private ListBox listkhachhang;
        private Button btnxoa;
    }

}
