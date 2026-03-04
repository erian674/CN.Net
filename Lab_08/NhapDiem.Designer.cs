namespace Lab_08
{
    partial class NhapDiem
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
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // cbbMaSo
            // 
            cbbMaSo.FormattingEnabled = true;
            cbbMaSo.Location = new Point(18, 15);
            cbbMaSo.Margin = new Padding(4);
            cbbMaSo.Name = "cbbMaSo";
            cbbMaSo.Size = new Size(279, 33);
            cbbMaSo.TabIndex = 0;
            cbbMaSo.Text = "chọn sinh viên";
            // 
            // cbbMaMH
            // 
            cbbMaMH.FormattingEnabled = true;
            cbbMaMH.Location = new Point(18, 75);
            cbbMaMH.Margin = new Padding(4);
            cbbMaMH.Name = "cbbMaMH";
            cbbMaMH.Size = new Size(279, 33);
            cbbMaMH.TabIndex = 0;
            cbbMaMH.Text = "chọn môn học";
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(320, 15);
            txtDiem.Margin = new Padding(4);
            txtDiem.Multiline = true;
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(346, 34);
            txtDiem.TabIndex = 1;
            txtDiem.Text = "nhập điểm";
            // 
            // dgvKetQua
            // 
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, MaMH, TenMH, Diem });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Tempus Sans ITC", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvKetQua.DefaultCellStyle = dataGridViewCellStyle7;
            dgvKetQua.Dock = DockStyle.Bottom;
            dgvKetQua.Location = new Point(0, 149);
            dgvKetQua.Margin = new Padding(4);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvKetQua.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvKetQua.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKetQua.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(1196, 471);
            dgvKetQua.TabIndex = 2;
            dgvKetQua.CellClick += dgvKetQua_CellClick;
            // 
            // MaSo
            // 
            MaSo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSo.DefaultCellStyle = dataGridViewCellStyle2;
            MaSo.HeaderText = "Mã số";
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
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaMH.DefaultCellStyle = dataGridViewCellStyle4;
            MaMH.HeaderText = "Mã môn học";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            // 
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenMH.DefaultCellStyle = dataGridViewCellStyle5;
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            // 
            // Diem
            // 
            Diem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Diem.DefaultCellStyle = dataGridViewCellStyle6;
            Diem.HeaderText = "Điểm";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(737, 56);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 67);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(598, 56);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 70);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(459, 56);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 70);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(320, 56);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 70);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // NhapDiem
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 620);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKetQua);
            Controls.Add(txtDiem);
            Controls.Add(cbbMaMH);
            Controls.Add(cbbMaSo);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "NhapDiem";
            Text = "Nhập kết quả học tập của sinh viên";
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
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn Diem;
    }
}