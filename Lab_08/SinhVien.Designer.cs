namespace Lab_08
{
    partial class SinhVien
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtSdt = new TextBox();
            cbbMaKhoa = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            chkGioiTinh = new CheckBox();
            label7 = new Label();
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewCheckBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            MaKhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgsinhviên).BeginInit();
            SuspendLayout();
            // 
            // dtgsinhviên
            // 
            dtgsinhviên.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgsinhviên.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgsinhviên.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsinhviên.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa });
            dtgsinhviên.Dock = DockStyle.Bottom;
            dtgsinhviên.Location = new Point(0, 195);
            dtgsinhviên.Margin = new Padding(4);
            dtgsinhviên.Name = "dtgsinhviên";
            dtgsinhviên.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgsinhviên.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgsinhviên.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtgsinhviên.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtgsinhviên.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgsinhviên.Size = new Size(1513, 531);
            dtgsinhviên.TabIndex = 0;
            dtgsinhviên.CellClick += dtgsinhviên_CellClick;
            // 
            // label1
            // 
            label1.Location = new Point(13, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 34);
            label1.TabIndex = 1;
            label1.Text = "Mã số sinh viên";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(181, 8);
            txtMSV.Margin = new Padding(4);
            txtMSV.Multiline = true;
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(330, 34);
            txtMSV.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(13, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(13, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(181, 60);
            txtHoTen.Margin = new Padding(4);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(330, 31);
            txtHoTen.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(181, 112);
            dtpNgaySinh.Margin = new Padding(4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(146, 33);
            dtpNgaySinh.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(519, 8);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 34);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(519, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 31);
            label5.TabIndex = 1;
            label5.Text = "Số điện thoại";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(13, 159);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 31);
            label6.TabIndex = 1;
            label6.Text = "Giới tính";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(687, 8);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(330, 34);
            txtDiaChi.TabIndex = 2;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(687, 60);
            txtSdt.Margin = new Padding(4);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(330, 31);
            txtSdt.TabIndex = 2;
            // 
            // cbbMaKhoa
            // 
            cbbMaKhoa.FormattingEnabled = true;
            cbbMaKhoa.Location = new Point(687, 110);
            cbbMaKhoa.Margin = new Padding(4);
            cbbMaKhoa.Name = "cbbMaKhoa";
            cbbMaKhoa.Size = new Size(330, 33);
            cbbMaKhoa.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1037, 8);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 55);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1169, 8);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 55);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1169, 71);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 55);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1037, 71);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(124, 55);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new Point(180, 167);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(18, 17);
            chkGioiTinh.TabIndex = 8;
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Location = new Point(519, 110);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 31);
            label7.TabIndex = 1;
            label7.Text = "Mã khoa";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaSo
            // 
            MaSo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSo.DefaultCellStyle = dataGridViewCellStyle2;
            MaSo.HeaderText = "Mã sinh viên";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            MaSo.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoTen.DefaultCellStyle = dataGridViewCellStyle3;
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.NullValue = false;
            GioiTinh.DefaultCellStyle = dataGridViewCellStyle5;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Resizable = DataGridViewTriState.True;
            GioiTinh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChi.DefaultCellStyle = dataGridViewCellStyle6;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DienThoai.DefaultCellStyle = dataGridViewCellStyle7;
            DienThoai.HeaderText = "Số điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // MaKhoa
            // 
            MaKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaKhoa.DefaultCellStyle = dataGridViewCellStyle8;
            MaKhoa.HeaderText = "Mã Khoa";
            MaKhoa.MinimumWidth = 6;
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            // 
            // SinhVien
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 726);
            ControlBox = false;
            Controls.Add(chkGioiTinh);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cbbMaKhoa);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtSdt);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMSV);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dtgsinhviên);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SinhVien";
            Text = "Nhập thông tin sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgsinhviên).EndInit();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDiaChi;
        private TextBox txtSdt;
        private ComboBox cbbMaKhoa;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private CheckBox chkGioiTinh;
        private Label label7;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewCheckBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn MaKhoa;
    }
}
