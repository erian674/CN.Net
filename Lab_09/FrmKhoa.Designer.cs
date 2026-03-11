namespace Lab_09
{
    partial class FrmKhoa
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvKhoa = new DataGridView();
            label7 = new Label();
            txtMaKhoa = new TextBox();
            label1 = new Label();
            txtTenKhoa = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // dgvKhoa
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvKhoa.DefaultCellStyle = dataGridViewCellStyle8;
            dgvKhoa.Dock = DockStyle.Bottom;
            dgvKhoa.Location = new Point(0, 164);
            dgvKhoa.Margin = new Padding(4);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvKhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKhoa.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(937, 511);
            dgvKhoa.TabIndex = 0;
            dgvKhoa.SelectionChanged += dgvKhoa_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 1;
            label7.Text = "Mã khoa";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(106, 9);
            txtMaKhoa.Margin = new Padding(3, 4, 3, 4);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(210, 34);
            txtMaKhoa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên khoa";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(106, 66);
            txtTenKhoa.Margin = new Padding(3, 4, 3, 4);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(339, 34);
            txtTenKhoa.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.YellowGreen;
            btnTimKiem.Location = new Point(335, 114);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 43);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.DarkGoldenrod;
            btnLamMoi.Location = new Point(799, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 56);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Peru;
            btnXoa.Location = new Point(695, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 56);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.OrangeRed;
            btnSua.Location = new Point(591, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 56);
            btnSua.TabIndex = 11;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.LightSalmon;
            btnThem.Location = new Point(486, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 56);
            btnThem.TabIndex = 12;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(106, 121);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(223, 34);
            txtTimKiem.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 121);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 6;
            label8.Text = "Từ khóa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmKhoa
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 675);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(dgvKhoa);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmKhoa";
            Text = "Nhập thông tin khoa";
            Load += FrmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhoa;
        private Label label7;
        private TextBox txtMaKhoa;
        private Label label1;
        private TextBox txtTenKhoa;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Label label8;
    }
}