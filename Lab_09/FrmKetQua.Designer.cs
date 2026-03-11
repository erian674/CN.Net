namespace Lab_09
{
    partial class FrmKetQua
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
            label2 = new Label();
            label3 = new Label();
            cbbSinhVien = new ComboBox();
            cbbMonHoc = new ComboBox();
            txtDiem = new TextBox();
            dgvKetQua = new DataGridView();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 0;
            label2.Text = "Môn học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 15);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 0;
            label3.Text = "Điểm thi";
            // 
            // cbbSinhVien
            // 
            cbbSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSinhVien.FormattingEnabled = true;
            cbbSinhVien.Location = new Point(109, 12);
            cbbSinhVien.Name = "cbbSinhVien";
            cbbSinhVien.Size = new Size(259, 36);
            cbbSinhVien.TabIndex = 1;
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(108, 71);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(259, 36);
            cbbMonHoc.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(482, 15);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(119, 34);
            txtDiem.TabIndex = 2;
            // 
            // dgvKetQua
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKetQua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKetQua.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKetQua.Dock = DockStyle.Bottom;
            dgvKetQua.Location = new Point(0, 127);
            dgvKetQua.Margin = new Padding(4);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvKetQua.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvKetQua.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKetQua.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(1061, 503);
            dgvKetQua.TabIndex = 8;
            dgvKetQua.SelectionChanged += dgvKetQua_SelectionChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.YellowGreen;
            btnTimKiem.Location = new Point(712, 77);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 43);
            btnTimKiem.TabIndex = 22;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.DarkGoldenrod;
            btnLamMoi.Location = new Point(920, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 56);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "🔄Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Peru;
            btnXoa.Location = new Point(816, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 56);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.OrangeRed;
            btnSua.Location = new Point(712, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 56);
            btnSua.TabIndex = 25;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.LightSalmon;
            btnThem.Location = new Point(607, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 56);
            btnThem.TabIndex = 26;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(483, 77);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(223, 34);
            txtTimKiem.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 77);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 20;
            label8.Text = "Từ khóa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmKetQua
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 630);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(dgvKetQua);
            Controls.Add(txtDiem);
            Controls.Add(cbbMonHoc);
            Controls.Add(cbbSinhVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmKetQua";
            Text = "Xem thông tin kết quả của sinh viên";
            Load += FrmKetQua_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbSinhVien;
        private ComboBox cbbMonHoc;
        private TextBox txtDiem;
        private DataGridView dgvKetQua;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Label label8;
    }
}