namespace Lab_06
{
    partial class frmQLSV
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
            label1 = new Label();
            label2 = new Label();
            txtMsv = new TextBox();
            txtHoTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCapNhat = new Button();
            txtTimKiem = new TextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnSang = new Button();
            btnSangHet = new Button();
            btnVe = new Button();
            btnVeHet = new Button();
            lstDSSV = new ListView();
            STT = new ColumnHeader();
            Msv = new ColumnHeader();
            HoTen = new ColumnHeader();
            lstDSDC = new ListView();
            STTDC = new ColumnHeader();
            MSVDC = new ColumnHeader();
            HoTenDC = new ColumnHeader();
            btnThem = new Button();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(280, 9);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 0;
            label2.Text = "Họ Tên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMsv
            // 
            txtMsv.BackColor = Color.MistyRose;
            txtMsv.Location = new Point(18, 37);
            txtMsv.Multiline = true;
            txtMsv.Name = "txtMsv";
            txtMsv.Size = new Size(184, 34);
            txtMsv.TabIndex = 1;
            txtMsv.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.SeaShell;
            txtHoTen.Location = new Point(216, 37);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(231, 34);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(210, 36);
            label3.TabIndex = 0;
            label3.Text = "Danh sách sinh viên";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(643, 98);
            label4.Name = "label4";
            label4.Size = new Size(204, 36);
            label4.TabIndex = 0;
            label4.Text = "Danh sách đã chọn";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Salmon;
            btnCapNhat.Location = new Point(548, 37);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 34);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Linen;
            txtTimKiem.Location = new Point(354, 98);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(283, 36);
            txtTimKiem.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PeachPuff;
            btnXoa.Location = new Point(769, 37);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Moccasin;
            btnThoat.Location = new Point(864, 37);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cornsilk;
            btnTimKiem.Location = new Point(228, 98);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 36);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTimKiem.KeyPress += btnTimKiem_KeyPress;
            // 
            // btnSang
            // 
            btnSang.BackColor = Color.LemonChiffon;
            btnSang.Location = new Point(338, 185);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(173, 29);
            btnSang.TabIndex = 2;
            btnSang.Text = ">";
            btnSang.UseVisualStyleBackColor = false;
            btnSang.Click += btnSang_Click;
            // 
            // btnSangHet
            // 
            btnSangHet.BackColor = Color.LightGoldenrodYellow;
            btnSangHet.Location = new Point(338, 363);
            btnSangHet.Name = "btnSangHet";
            btnSangHet.Size = new Size(173, 29);
            btnSangHet.TabIndex = 2;
            btnSangHet.Text = ">>";
            btnSangHet.UseVisualStyleBackColor = false;
            btnSangHet.Click += btnSangHet_Click;
            // 
            // btnVe
            // 
            btnVe.BackColor = Color.Khaki;
            btnVe.Location = new Point(338, 271);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(173, 29);
            btnVe.TabIndex = 2;
            btnVe.Text = "<";
            btnVe.UseVisualStyleBackColor = false;
            btnVe.Click += btnVe_Click;
            // 
            // btnVeHet
            // 
            btnVeHet.BackColor = Color.PaleGoldenrod;
            btnVeHet.Location = new Point(338, 457);
            btnVeHet.Name = "btnVeHet";
            btnVeHet.Size = new Size(173, 29);
            btnVeHet.TabIndex = 2;
            btnVeHet.Text = "<<";
            btnVeHet.UseVisualStyleBackColor = false;
            btnVeHet.Click += btnVeHet_Click;
            // 
            // lstDSSV
            // 
            lstDSSV.BackColor = Color.Cornsilk;
            lstDSSV.Columns.AddRange(new ColumnHeader[] { STT, Msv, HoTen });
            lstDSSV.ForeColor = SystemColors.WindowText;
            lstDSSV.FullRowSelect = true;
            lstDSSV.Location = new Point(18, 137);
            lstDSSV.Name = "lstDSSV";
            lstDSSV.Size = new Size(314, 389);
            lstDSSV.TabIndex = 3;
            lstDSSV.UseCompatibleStateImageBehavior = false;
            lstDSSV.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // Msv
            // 
            Msv.Text = "Mã Sinh Viên";
            Msv.Width = 135;
            // 
            // HoTen
            // 
            HoTen.Text = "Họ Tên";
            HoTen.Width = 80;
            // 
            // lstDSDC
            // 
            lstDSDC.BackColor = Color.Cornsilk;
            lstDSDC.Columns.AddRange(new ColumnHeader[] { STTDC, MSVDC, HoTenDC });
            lstDSDC.ForeColor = SystemColors.WindowText;
            lstDSDC.FullRowSelect = true;
            lstDSDC.Location = new Point(533, 137);
            lstDSDC.Name = "lstDSDC";
            lstDSDC.Size = new Size(314, 389);
            lstDSDC.TabIndex = 3;
            lstDSDC.UseCompatibleStateImageBehavior = false;
            lstDSDC.View = View.Details;
            // 
            // STTDC
            // 
            STTDC.Text = "STT";
            // 
            // MSVDC
            // 
            MSVDC.Text = "Mã Sinh Viên";
            MSVDC.Width = 135;
            // 
            // HoTenDC
            // 
            HoTenDC.Text = "Họ Tên";
            HoTenDC.Width = 80;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SandyBrown;
            btnThem.Location = new Point(453, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightSalmon;
            btnLuu.Location = new Point(674, 37);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmQLSV
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(956, 539);
            ControlBox = false;
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lstDSDC);
            Controls.Add(lstDSSV);
            Controls.Add(btnVeHet);
            Controls.Add(btnVe);
            Controls.Add(btnSangHet);
            Controls.Add(btnSang);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTimKiem);
            Controls.Add(txtHoTen);
            Controls.Add(txtMsv);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmQLSV";
            Text = "QUẢN LÝ SINH VIÊN";
            Load += frmQLSV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMsv;
        private TextBox txtHoTen;
        private Label label3;
        private Label label4;
        private Button btnCapNhat;
        private TextBox txtTimKiem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnSang;
        private Button btnSangHet;
        private Button btnVe;
        private Button btnVeHet;
        private ListView lstDSSV;
        private ColumnHeader STT;
        private ColumnHeader Msv;
        private ColumnHeader HoTen;
        private ListView lstDSDC;
        private ColumnHeader STTDC;
        private ColumnHeader MSVDC;
        private ColumnHeader HoTenDC;
        private Button btnThem;
        private Button btnLuu;
    }
}