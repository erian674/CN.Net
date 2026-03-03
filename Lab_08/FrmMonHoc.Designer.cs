namespace Lab_08
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtMaMH = new TextBox();
            dgvMon = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtTenMH = new TextBox();
            txtSoTiet = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            SoTiet = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học";
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(123, 10);
            txtMaMH.Multiline = true;
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(220, 34);
            txtMaMH.TabIndex = 1;
            // 
            // dgvMon
            // 
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { MaMH, TenMH, SoTiet });
            dgvMon.Dock = DockStyle.Bottom;
            dgvMon.Location = new Point(0, 157);
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMon.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMon.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(616, 364);
            dgvMon.TabIndex = 2;
            dgvMon.CellClick += dgvMon_CellClick;
            // 
            // label2
            // 
            label2.Location = new Point(16, 59);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên môn học";
            // 
            // label3
            // 
            label3.Location = new Point(16, 108);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 0;
            label3.Text = "Số tiết";
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(123, 54);
            txtTenMH.Multiline = true;
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(220, 34);
            txtTenMH.TabIndex = 1;
            // 
            // txtSoTiet
            // 
            txtSoTiet.Location = new Point(123, 99);
            txtSoTiet.Multiline = true;
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(220, 34);
            txtSoTiet.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(359, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 54);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(488, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 50);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(359, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 61);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(488, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 61);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaMH.DefaultCellStyle = dataGridViewCellStyle2;
            MaMH.HeaderText = "Mã môn học";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            MaMH.Width = 121;
            // 
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenMH.DefaultCellStyle = dataGridViewCellStyle3;
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            TenMH.Width = 123;
            // 
            // SoTiet
            // 
            SoTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoTiet.DefaultCellStyle = dataGridViewCellStyle4;
            SoTiet.HeaderText = "Số tiết";
            SoTiet.MinimumWidth = 6;
            SoTiet.Name = "SoTiet";
            SoTiet.ReadOnly = true;
            SoTiet.Width = 81;
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 521);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvMon);
            Controls.Add(txtSoTiet);
            Controls.Add(txtTenMH);
            Controls.Add(txtMaMH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMonHoc";
            Text = "Môn Học";
            Load += FrmMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaMH;
        private DataGridView dgvMon;
        private Label label2;
        private Label label3;
        private TextBox txtTenMH;
        private TextBox txtSoTiet;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn SoTiet;
    }
}