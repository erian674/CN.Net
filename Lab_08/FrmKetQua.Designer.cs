namespace Lab_08
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cbbMaSo = new ComboBox();
            cbbMaMH = new ComboBox();
            txtDiem = new TextBox();
            dgvKetQua = new DataGridView();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // cbbMaSo
            // 
            cbbMaSo.FormattingEnabled = true;
            cbbMaSo.Location = new Point(12, 12);
            cbbMaSo.Name = "cbbMaSo";
            cbbMaSo.Size = new Size(176, 28);
            cbbMaSo.TabIndex = 0;
            cbbMaSo.Text = "Chọn Sinh viên";
            // 
            // cbbMaMH
            // 
            cbbMaMH.FormattingEnabled = true;
            cbbMaMH.Location = new Point(12, 60);
            cbbMaMH.Name = "cbbMaMH";
            cbbMaMH.Size = new Size(176, 28);
            cbbMaMH.TabIndex = 0;
            cbbMaMH.Text = "Chọn Môn học";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(213, 12);
            txtDiem.Multiline = true;
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(232, 28);
            txtDiem.TabIndex = 1;
            txtDiem.Text = "Nhập điểm";
            // 
            // dgvKetQua
            // 
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, TenMH, MaMH, Diem });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvKetQua.DefaultCellStyle = dataGridViewCellStyle7;
            dgvKetQua.Dock = DockStyle.Bottom;
            dgvKetQua.Location = new Point(0, 107);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvKetQua.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvKetQua.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKetQua.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(693, 371);
            dgvKetQua.TabIndex = 2;
            dgvKetQua.CellClick += dgvKetQua_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(571, 46);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 55);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(451, 46);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 55);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(331, 46);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 55);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(211, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 55);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // MaSo
            // 
            MaSo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaSo.DefaultCellStyle = dataGridViewCellStyle2;
            MaSo.HeaderText = "Mã số";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            MaSo.ReadOnly = true;
            MaSo.Width = 78;
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
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenMH.DefaultCellStyle = dataGridViewCellStyle4;
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            TenMH.Width = 123;
            // 
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaMH.DefaultCellStyle = dataGridViewCellStyle5;
            MaMH.HeaderText = "Mã môn học";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            MaMH.Width = 121;
            // 
            // Diem
            // 
            Diem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Diem.DefaultCellStyle = dataGridViewCellStyle6;
            Diem.HeaderText = "Điểm";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.ReadOnly = true;
            Diem.Width = 74;
            // 
            // FrmKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 478);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKetQua);
            Controls.Add(txtDiem);
            Controls.Add(cbbMaMH);
            Controls.Add(cbbMaSo);
            Name = "FrmKetQua";
            Text = "Kết Quả";
            Load += FrmKetQua_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbMaSo;
        private ComboBox cbbMaMH;
        private TextBox txtDiem;
        private DataGridView dgvKetQua;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn Diem;
    }
}