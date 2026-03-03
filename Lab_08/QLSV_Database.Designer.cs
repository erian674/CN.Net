namespace Lab_08
{
    partial class QLSV_Database
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dtgsinhviên = new DataGridView();
            label1 = new Label();
            txtMSV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            raNam = new RadioButton();
            groupBox1 = new GroupBox();
            raNu = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtSdt = new TextBox();
            cbbMaKhoa = new ComboBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            MaKhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgsinhviên).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgsinhviên
            // 
            dtgsinhviên.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgsinhviên.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgsinhviên.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsinhviên.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa });
            dtgsinhviên.Dock = DockStyle.Bottom;
            dtgsinhviên.Location = new Point(0, 236);
            dtgsinhviên.Name = "dtgsinhviên";
            dtgsinhviên.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgsinhviên.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgsinhviên.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgsinhviên.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtgsinhviên.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgsinhviên.Size = new Size(937, 472);
            dtgsinhviên.TabIndex = 0;
            dtgsinhviên.CellClick += dtgsinhviên_CellClick;
            dtgsinhviên.CellFormatting += dtgsinhviên_CellFormatting;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã số sinh viên";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(130, 6);
            txtMSV.Multiline = true;
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(221, 34);
            txtMSV.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(112, 34);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(130, 48);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(221, 34);
            txtHoTen.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(130, 101);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(221, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // raNam
            // 
            raNam.Location = new Point(118, 26);
            raNam.Name = "raNam";
            raNam.Size = new Size(67, 24);
            raNam.TabIndex = 4;
            raNam.Text = "Nam";
            raNam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(raNu);
            groupBox1.Controls.Add(raNam);
            groupBox1.Location = new Point(12, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 66);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // raNu
            // 
            raNu.Location = new Point(266, 26);
            raNu.Name = "raNu";
            raNu.Size = new Size(67, 24);
            raNu.TabIndex = 4;
            raNu.Text = "Nữ";
            raNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(357, 6);
            label4.Name = "label4";
            label4.Size = new Size(112, 34);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(357, 48);
            label5.Name = "label5";
            label5.Size = new Size(112, 34);
            label5.TabIndex = 1;
            label5.Text = "Số điện thoại";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(357, 99);
            label6.Name = "label6";
            label6.Size = new Size(112, 29);
            label6.TabIndex = 1;
            label6.Text = "Mã khoa";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(475, 6);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(221, 34);
            txtDiaChi.TabIndex = 2;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(475, 48);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(221, 34);
            txtSdt.TabIndex = 2;
            // 
            // cbbMaKhoa
            // 
            cbbMaKhoa.FormattingEnabled = true;
            cbbMaKhoa.Location = new Point(475, 100);
            cbbMaKhoa.Name = "cbbMaKhoa";
            cbbMaKhoa.Size = new Size(221, 28);
            cbbMaKhoa.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(357, 156);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 59);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(475, 156);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 59);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(711, 156);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 59);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(711, 9);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 126);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(593, 156);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 59);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // MaSo
            // 
            MaSo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaSo.DefaultCellStyle = dataGridViewCellStyle2;
            MaSo.HeaderText = "Mã sinh viên";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            MaSo.ReadOnly = true;
            MaSo.Width = 120;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HoTen.DefaultCellStyle = dataGridViewCellStyle3;
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 83;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            NgaySinh.Width = 103;
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GioiTinh.DefaultCellStyle = dataGridViewCellStyle5;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 94;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DiaChi.DefaultCellStyle = dataGridViewCellStyle6;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 84;
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DienThoai.DefaultCellStyle = dataGridViewCellStyle7;
            DienThoai.HeaderText = "Số điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Width = 126;
            // 
            // MaKhoa
            // 
            MaKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaKhoa.DefaultCellStyle = dataGridViewCellStyle8;
            MaKhoa.HeaderText = "Mã Khoa";
            MaKhoa.MinimumWidth = 6;
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            MaKhoa.Width = 97;
            // 
            // QLSV_Database
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 708);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(cbbMaKhoa);
            Controls.Add(groupBox1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtSdt);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMSV);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dtgsinhviên);
            Name = "QLSV_Database";
            Text = "Sinh Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgsinhviên).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgsinhviên;
        private Label label1;
        private TextBox txtMSV;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private RadioButton raNam;
        private GroupBox groupBox1;
        private RadioButton raNu;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDiaChi;
        private TextBox txtSdt;
        private ComboBox cbbMaKhoa;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn MaKhoa;
    }
}
