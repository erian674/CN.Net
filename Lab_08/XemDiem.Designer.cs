namespace Lab_08
{
    partial class XemDiem
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvDiem = new DataGridView();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            SoTiet = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            txtKhoa = new TextBox();
            cbbTenSV = new ComboBox();
            cbbMaSo = new ComboBox();
            btnThoat = new Button();
            btnXem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // dgvDiem
            // 
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { MaMH, TenMH, SoTiet, Diem });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Tempus Sans ITC", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDiem.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDiem.Dock = DockStyle.Bottom;
            dgvDiem.Location = new Point(0, 133);
            dgvDiem.Margin = new Padding(4);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDiem.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvDiem.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(963, 471);
            dgvDiem.TabIndex = 10;
            // 
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaMH.DefaultCellStyle = dataGridViewCellStyle2;
            MaMH.HeaderText = "Mã môn học";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            // 
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenMH.DefaultCellStyle = dataGridViewCellStyle3;
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            // 
            // SoTiet
            // 
            SoTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoTiet.DefaultCellStyle = dataGridViewCellStyle4;
            SoTiet.HeaderText = "Số tiết học";
            SoTiet.MinimumWidth = 6;
            SoTiet.Name = "SoTiet";
            SoTiet.ReadOnly = true;
            // 
            // Diem
            // 
            Diem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Diem.DefaultCellStyle = dataGridViewCellStyle5;
            Diem.HeaderText = "Điểm";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.ReadOnly = true;
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(320, 8);
            txtKhoa.Margin = new Padding(4);
            txtKhoa.Multiline = true;
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(346, 34);
            txtKhoa.TabIndex = 9;
            txtKhoa.Text = "hiển thị tên khoa";
            // 
            // cbbTenSV
            // 
            cbbTenSV.FormattingEnabled = true;
            cbbTenSV.Location = new Point(18, 68);
            cbbTenSV.Margin = new Padding(4);
            cbbTenSV.Name = "cbbTenSV";
            cbbTenSV.Size = new Size(279, 33);
            cbbTenSV.TabIndex = 7;
            cbbTenSV.Text = "chọn tên sinh viên";
            // 
            // cbbMaSo
            // 
            cbbMaSo.FormattingEnabled = true;
            cbbMaSo.Location = new Point(18, 8);
            cbbMaSo.Margin = new Padding(4);
            cbbMaSo.Name = "cbbMaSo";
            cbbMaSo.Size = new Size(279, 33);
            cbbMaSo.TabIndex = 8;
            cbbMaSo.Text = "chọn mã số sinh viên";
            cbbMaSo.SelectedIndexChanged += cbbMaSo_SelectedIndexChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(826, 8);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(687, 8);
            btnXem.Margin = new Padding(4);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(131, 34);
            btnXem.TabIndex = 14;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // XemDiem
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 604);
            ControlBox = false;
            Controls.Add(dgvDiem);
            Controls.Add(txtKhoa);
            Controls.Add(cbbTenSV);
            Controls.Add(cbbMaSo);
            Controls.Add(btnThoat);
            Controls.Add(btnXem);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "XemDiem";
            Text = "Xem kết quả học tập của sinh viên";
            Load += XemDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiem;
        private TextBox txtKhoa;
        private ComboBox cbbTenSV;
        private ComboBox cbbMaSo;
        private Button btnThoat;
        private Button btnXem;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn SoTiet;
        private DataGridViewTextBoxColumn Diem;
    }
}