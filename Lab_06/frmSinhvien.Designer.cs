namespace Lab_06
{
    partial class frmSinhvien
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
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            btnXoa = new Button();
            grpLopA = new GroupBox();
            lstLopA = new ListBox();
            grpLopB = new GroupBox();
            lstLopB = new ListBox();
            btnKetThuc = new Button();
            btnCapnhat = new Button();
            btnSang = new Button();
            btnVe = new Button();
            btnSangHet = new Button();
            btnVeHet = new Button();
            grpLopA.SuspendLayout();
            grpLopB.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MistyRose;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(649, 61);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(112, 33);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.Snow;
            txtHoTen.Location = new Point(130, 64);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(284, 34);
            txtHoTen.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Location = new Point(70, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 35);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // grpLopA
            // 
            grpLopA.BackColor = Color.SeaShell;
            grpLopA.Controls.Add(lstLopA);
            grpLopA.Location = new Point(12, 117);
            grpLopA.Name = "grpLopA";
            grpLopA.Size = new Size(250, 287);
            grpLopA.TabIndex = 4;
            grpLopA.TabStop = false;
            grpLopA.Text = "Lớp A:";
            // 
            // lstLopA
            // 
            lstLopA.BackColor = Color.Snow;
            lstLopA.Dock = DockStyle.Fill;
            lstLopA.FormattingEnabled = true;
            lstLopA.ItemHeight = 25;
            lstLopA.Location = new Point(3, 29);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(244, 255);
            lstLopA.TabIndex = 0;
            // 
            // grpLopB
            // 
            grpLopB.BackColor = Color.SeaShell;
            grpLopB.Controls.Add(lstLopB);
            grpLopB.Location = new Point(387, 117);
            grpLopB.Name = "grpLopB";
            grpLopB.Size = new Size(250, 287);
            grpLopB.TabIndex = 4;
            grpLopB.TabStop = false;
            grpLopB.Text = "Lớp B:";
            // 
            // lstLopB
            // 
            lstLopB.BackColor = Color.Snow;
            lstLopB.Dock = DockStyle.Fill;
            lstLopB.FormattingEnabled = true;
            lstLopB.ItemHeight = 25;
            lstLopB.Location = new Point(3, 29);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(244, 255);
            lstLopB.TabIndex = 1;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.Salmon;
            btnKetThuc.Location = new Point(457, 410);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(131, 35);
            btnKetThuc.TabIndex = 3;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.BackColor = Color.AntiqueWhite;
            btnCapnhat.Location = new Point(457, 64);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(131, 35);
            btnCapnhat.TabIndex = 3;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnSang
            // 
            btnSang.BackColor = Color.NavajoWhite;
            btnSang.Location = new Point(268, 208);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(54, 29);
            btnSang.TabIndex = 5;
            btnSang.Text = ">";
            btnSang.UseVisualStyleBackColor = false;
            btnSang.Click += btnSang_Click;
            // 
            // btnVe
            // 
            btnVe.BackColor = Color.NavajoWhite;
            btnVe.Location = new Point(328, 208);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(53, 29);
            btnVe.TabIndex = 5;
            btnVe.Text = "<";
            btnVe.UseVisualStyleBackColor = false;
            btnVe.Click += btnVe_Click;
            // 
            // btnSangHet
            // 
            btnSangHet.BackColor = Color.NavajoWhite;
            btnSangHet.Location = new Point(268, 275);
            btnSangHet.Name = "btnSangHet";
            btnSangHet.Size = new Size(54, 29);
            btnSangHet.TabIndex = 5;
            btnSangHet.Text = ">>";
            btnSangHet.UseVisualStyleBackColor = false;
            btnSangHet.Click += btnSangHet_Click;
            // 
            // btnVeHet
            // 
            btnVeHet.BackColor = Color.NavajoWhite;
            btnVeHet.Location = new Point(328, 275);
            btnVeHet.Name = "btnVeHet";
            btnVeHet.Size = new Size(53, 29);
            btnVeHet.TabIndex = 5;
            btnVeHet.Text = "<<";
            btnVeHet.UseVisualStyleBackColor = false;
            btnVeHet.Click += btnVeHet_Click;
            // 
            // frmSinhvien
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(649, 461);
            ControlBox = false;
            Controls.Add(btnVe);
            Controls.Add(btnVeHet);
            Controls.Add(btnSangHet);
            Controls.Add(btnSang);
            Controls.Add(grpLopB);
            Controls.Add(grpLopA);
            Controls.Add(btnCapnhat);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoa);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmSinhvien";
            Text = "QUẢN LÝ SINH VIÊN";
            Load += frmSinhvien_Load;
            grpLopA.ResumeLayout(false);
            grpLopB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private Button btnXoa;
        private GroupBox grpLopA;
        private GroupBox grpLopB;
        private Button btnKetThuc;
        private Button btnCapnhat;
        private Button btnSang;
        private Button btnVe;
        private Button btnSangHet;
        private Button btnVeHet;
        private ListBox lstLopA;
        private ListBox lstLopB;
    }
}