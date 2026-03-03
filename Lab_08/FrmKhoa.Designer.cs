namespace Lab_08
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            dgvKhoa = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            Makhoa = new DataGridViewTextBoxColumn();
            Tenkhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(12, 12);
            txtMaKhoa.Multiline = true;
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(217, 34);
            txtMaKhoa.TabIndex = 0;
            txtMaKhoa.Text = "Nhập Mã khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(12, 64);
            txtTenKhoa.Multiline = true;
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(217, 34);
            txtTenKhoa.TabIndex = 0;
            txtTenKhoa.Text = "Nhập Tên khoa";
            // 
            // dgvKhoa
            // 
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { Makhoa, Tenkhoa });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKhoa.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKhoa.Dock = DockStyle.Bottom;
            dgvKhoa.Location = new Point(0, 104);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvKhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhoa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(749, 346);
            dgvKhoa.TabIndex = 1;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(265, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 55);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(385, 17);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 55);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(505, 17);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 55);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(625, 17);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 55);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Makhoa
            // 
            Makhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Makhoa.DefaultCellStyle = dataGridViewCellStyle2;
            Makhoa.HeaderText = "Mã khoa";
            Makhoa.MinimumWidth = 6;
            Makhoa.Name = "Makhoa";
            Makhoa.ReadOnly = true;
            Makhoa.Width = 95;
            // 
            // Tenkhoa
            // 
            Tenkhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Tenkhoa.DefaultCellStyle = dataGridViewCellStyle3;
            Tenkhoa.HeaderText = "Tên khoa";
            Tenkhoa.MinimumWidth = 6;
            Tenkhoa.Name = "Tenkhoa";
            Tenkhoa.ReadOnly = true;
            Tenkhoa.Width = 97;
            // 
            // FrmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Name = "FrmKhoa";
            Text = "Khoa";
            Load += FrmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private DataGridView dgvKhoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridViewTextBoxColumn Makhoa;
        private DataGridViewTextBoxColumn Tenkhoa;
    }
}