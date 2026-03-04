namespace Lab_08
{
    partial class Khoa
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
            Makhoa = new DataGridViewTextBoxColumn();
            Tenkhoa = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(18, 15);
            txtMaKhoa.Margin = new Padding(4);
            txtMaKhoa.Multiline = true;
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(324, 38);
            txtMaKhoa.TabIndex = 0;
            txtMaKhoa.Text = "nhập mã khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(18, 81);
            txtTenKhoa.Margin = new Padding(4);
            txtTenKhoa.Multiline = true;
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(324, 38);
            txtTenKhoa.TabIndex = 0;
            txtTenKhoa.Text = "nhập tên khoa";
            // 
            // dgvKhoa
            // 
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { Makhoa, Tenkhoa });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKhoa.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKhoa.Dock = DockStyle.Bottom;
            dgvKhoa.Location = new Point(0, 133);
            dgvKhoa.Margin = new Padding(4);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvKhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKhoa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(666, 562);
            dgvKhoa.TabIndex = 1;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            // 
            // Makhoa
            // 
            Makhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Makhoa.DefaultCellStyle = dataGridViewCellStyle2;
            Makhoa.HeaderText = "Mã khoa";
            Makhoa.MinimumWidth = 6;
            Makhoa.Name = "Makhoa";
            Makhoa.ReadOnly = true;
            // 
            // Tenkhoa
            // 
            Tenkhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tenkhoa.DefaultCellStyle = dataGridViewCellStyle3;
            Tenkhoa.HeaderText = "Tên khoa";
            Tenkhoa.MinimumWidth = 6;
            Tenkhoa.Name = "Tenkhoa";
            Tenkhoa.ReadOnly = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(366, 15);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 51);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(517, 15);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(143, 51);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(366, 74);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 51);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(517, 74);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 51);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Khoa
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 695);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Khoa";
            Text = "Nhập thông tin khoa";
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