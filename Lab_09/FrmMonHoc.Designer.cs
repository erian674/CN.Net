namespace Lab_09
{
    partial class FrmMonHoc
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
            txtTenMh = new TextBox();
            txtMaMh = new TextBox();
            label1 = new Label();
            label7 = new Label();
            dgvMonHoc = new DataGridView();
            label2 = new Label();
            txtSoTiet = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // txtTenMh
            // 
            txtTenMh.Location = new Point(134, 70);
            txtTenMh.Margin = new Padding(3, 4, 3, 4);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.Size = new Size(339, 34);
            txtTenMh.TabIndex = 5;
            // 
            // txtMaMh
            // 
            txtMaMh.Location = new Point(134, 13);
            txtMaMh.Margin = new Padding(3, 4, 3, 4);
            txtMaMh.Name = "txtMaMh";
            txtMaMh.Size = new Size(210, 34);
            txtMaMh.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 70);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên môn học";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 13);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 4;
            label7.Text = "Mã môn học";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvMonHoc
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMonHoc.Dock = DockStyle.Bottom;
            dgvMonHoc.Location = new Point(0, 123);
            dgvMonHoc.Margin = new Padding(4);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvMonHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvMonHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvMonHoc.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(1105, 611);
            dgvMonHoc.TabIndex = 7;
            dgvMonHoc.SelectionChanged += dgvMonHoc_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 16);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 3;
            label2.Text = "Số tiết";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSoTiet
            // 
            txtSoTiet.Location = new Point(425, 13);
            txtSoTiet.Margin = new Padding(3, 4, 3, 4);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(210, 34);
            txtSoTiet.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.YellowGreen;
            btnTimKiem.Location = new Point(956, 73);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(131, 43);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.DarkGoldenrod;
            btnLamMoi.Location = new Point(954, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 56);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "🔄Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Peru;
            btnXoa.Location = new Point(850, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 56);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.OrangeRed;
            btnSua.Location = new Point(746, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 56);
            btnSua.TabIndex = 18;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.LightSalmon;
            btnThem.Location = new Point(641, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 56);
            btnThem.TabIndex = 19;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(727, 80);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(223, 34);
            txtTimKiem.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 80);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 13;
            label8.Text = "Từ khóa";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 734);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(dgvMonHoc);
            Controls.Add(txtTenMh);
            Controls.Add(txtSoTiet);
            Controls.Add(txtMaMh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmMonHoc";
            Text = "Nhập thông tin môn học";
            Load += FrmMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMh;
        private TextBox txtMaMh;
        private Label label1;
        private Label label7;
        private DataGridView dgvMonHoc;
        private Label label2;
        private TextBox txtSoTiet;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Label label8;
    }
}