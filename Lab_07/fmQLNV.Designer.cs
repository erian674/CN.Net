namespace Lab_07
{
    partial class frmQLNV
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dtpNgaysinh = new DateTimePicker();
            txtDiachi = new TextBox();
            txtSdt = new TextBox();
            txtHoten = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            lvDanhSachNhanVien = new ListView();
            hoten = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            diachi = new ColumnHeader();
            sdt = new ColumnHeader();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MistyRose;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(861, 97);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(7, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(119, 114);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(261, 33);
            dtpNgaysinh.TabIndex = 2;
            // 
            // txtDiachi
            // 
            txtDiachi.BackColor = Color.OldLace;
            txtDiachi.Location = new Point(523, 113);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(291, 34);
            txtDiachi.TabIndex = 1;
            // 
            // txtSdt
            // 
            txtSdt.BackColor = Color.OldLace;
            txtSdt.Location = new Point(523, 53);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(291, 34);
            txtSdt.TabIndex = 1;
            // 
            // txtHoten
            // 
            txtHoten.BackColor = Color.OldLace;
            txtHoten.Location = new Point(119, 47);
            txtHoten.Multiline = true;
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(261, 34);
            txtHoten.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(0, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(401, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 31);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(401, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 31);
            label4.TabIndex = 0;
            label4.Text = "Điện thoại";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(395, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 85);
            panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SeaShell;
            btnThoat.Location = new Point(340, 13);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 57);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SeaShell;
            btnSua.Location = new Point(231, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 57);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SeaShell;
            btnXoa.Location = new Point(122, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 57);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaShell;
            btnThem.Location = new Point(12, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PeachPuff;
            groupBox2.Controls.Add(lvDanhSachNhanVien);
            groupBox2.Location = new Point(12, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(840, 352);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // lvDanhSachNhanVien
            // 
            lvDanhSachNhanVien.BorderStyle = BorderStyle.FixedSingle;
            lvDanhSachNhanVien.Columns.AddRange(new ColumnHeader[] { hoten, ngaysinh, diachi, sdt });
            lvDanhSachNhanVien.FullRowSelect = true;
            lvDanhSachNhanVien.GridLines = true;
            lvDanhSachNhanVien.Location = new Point(7, 32);
            lvDanhSachNhanVien.Name = "lvDanhSachNhanVien";
            lvDanhSachNhanVien.Size = new Size(822, 314);
            lvDanhSachNhanVien.TabIndex = 0;
            lvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            lvDanhSachNhanVien.View = View.Details;
            // 
            // hoten
            // 
            hoten.Text = "Họ tên";
            hoten.Width = 180;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.TextAlign = HorizontalAlignment.Center;
            ngaysinh.Width = 180;
            // 
            // diachi
            // 
            diachi.Text = "Địa chỉ";
            diachi.TextAlign = HorizontalAlignment.Center;
            diachi.Width = 280;
            // 
            // sdt
            // 
            sdt.Text = "Điện thoại";
            sdt.TextAlign = HorizontalAlignment.Center;
            sdt.Width = 180;
            // 
            // frmQLNV
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(861, 744);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmQLNV";
            Text = "QUẢN LÝ NHÂN VIÊN";
            Load += frmQLNV_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgaysinh;
        private TextBox txtDiachi;
        private TextBox txtSdt;
        private TextBox txtHoten;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Button btnThem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox2;
        private ListView lvDanhSachNhanVien;
        private ColumnHeader hoten;
        private ColumnHeader ngaysinh;
        private ColumnHeader diachi;
        private ColumnHeader sdt;
    }
}
