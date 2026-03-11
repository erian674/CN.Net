namespace Lab_09
{
    partial class FrmSinhVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cbbGioiTinh = new ComboBox();
            lblMaSo = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDiaChi = new TextBox();
            cbbMaKhoa = new ComboBox();
            dgvSinhVien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            label8 = new Label();
            txtTimKiem = new TextBox();
            txtDienThoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(117, 59);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(316, 34);
            txtHoTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(117, 113);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(253, 34);
            dtpNgaySinh.TabIndex = 2;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new Point(117, 173);
            cbbGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(253, 36);
            cbbGioiTinh.TabIndex = 3;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.ForeColor = Color.Red;
            lblMaSo.Location = new Point(117, 10);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(85, 28);
            lblMaSo.TabIndex = 0;
            lblMaSo.Text = "lblMaSo";
            lblMaSo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 0;
            label3.Text = "Họ tên";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 0;
            label4.Text = "Giới tính";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 65);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 0;
            label5.Text = "Điện thoại";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 10);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 119);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 0;
            label7.Text = "Mã khoa";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(616, 13);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(316, 34);
            txtDiaChi.TabIndex = 1;
            // 
            // cbbMaKhoa
            // 
            cbbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaKhoa.FormattingEnabled = true;
            cbbMaKhoa.Location = new Point(616, 119);
            cbbMaKhoa.Margin = new Padding(3, 4, 3, 4);
            cbbMaKhoa.Name = "cbbMaKhoa";
            cbbMaKhoa.Size = new Size(253, 36);
            cbbMaKhoa.TabIndex = 3;
            // 
            // dgvSinhVien
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSinhVien.Dock = DockStyle.Bottom;
            dgvSinhVien.Location = new Point(0, 216);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSinhVien.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvSinhVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1516, 515);
            dgvSinhVien.TabIndex = 4;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.LightSalmon;
            btnThem.Location = new Point(976, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 56);
            btnThem.TabIndex = 5;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.OrangeRed;
            btnSua.Location = new Point(1081, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 56);
            btnSua.TabIndex = 5;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Peru;
            btnXoa.Location = new Point(1185, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 56);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.DarkGoldenrod;
            btnLamMoi.Location = new Point(1289, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 56);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "🔄Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.YellowGreen;
            btnTimKiem.Location = new Point(1289, 99);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(133, 56);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(972, 113);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 0;
            label8.Text = "Từ khóa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1060, 110);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(223, 34);
            txtTimKiem.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(616, 65);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(316, 34);
            txtDienThoai.TabIndex = 1;
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 731);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvSinhVien);
            Controls.Add(cbbMaKhoa);
            Controls.Add(cbbGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTimKiem);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtHoTen);
            Controls.Add(lblMaSo);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmSinhVien";
            Text = "Nhập thông tin sinh viên";
            Load += SinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbbGioiTinh;
        private Label lblMaSo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDiaChi;
        private ComboBox cbbMaKhoa;
        private DataGridView dgvSinhVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Label label8;
        private TextBox txtTimKiem;
        private TextBox txtDienThoai;
    }
}