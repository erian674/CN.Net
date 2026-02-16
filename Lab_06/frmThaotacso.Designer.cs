namespace Lab_06
{
    partial class frmThaotacso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSo = new TextBox();
            btnCapnhat = new Button();
            ltsSo = new ListBox();
            grpChucnang = new GroupBox();
            btnXoaCuoi = new Button();
            btnXoaDau = new Button();
            btnXoaDangChon = new Button();
            btnLecuoi = new Button();
            btnChandau = new Button();
            btTang2 = new Button();
            btnKetThuc = new Button();
            grpChucnang.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSo
            // 
            txtSo.BackColor = Color.Snow;
            txtSo.Location = new Point(248, 9);
            txtSo.Multiline = true;
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(342, 40);
            txtSo.TabIndex = 1;
            txtSo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCapnhat
            // 
            btnCapnhat.BackColor = Color.MistyRose;
            btnCapnhat.Location = new Point(596, 9);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(124, 40);
            btnCapnhat.TabIndex = 2;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // ltsSo
            // 
            ltsSo.BackColor = Color.Snow;
            ltsSo.FormattingEnabled = true;
            ltsSo.ItemHeight = 25;
            ltsSo.Location = new Point(12, 52);
            ltsSo.Name = "ltsSo";
            ltsSo.Size = new Size(230, 379);
            ltsSo.TabIndex = 3;
            // 
            // grpChucnang
            // 
            grpChucnang.BackColor = Color.Snow;
            grpChucnang.Controls.Add(btnXoaCuoi);
            grpChucnang.Controls.Add(btnXoaDau);
            grpChucnang.Controls.Add(btnXoaDangChon);
            grpChucnang.Controls.Add(btnLecuoi);
            grpChucnang.Controls.Add(btnChandau);
            grpChucnang.Controls.Add(btTang2);
            grpChucnang.Location = new Point(248, 55);
            grpChucnang.Name = "grpChucnang";
            grpChucnang.Size = new Size(472, 376);
            grpChucnang.TabIndex = 4;
            grpChucnang.TabStop = false;
            grpChucnang.Text = "Chức năng";
            // 
            // btnXoaCuoi
            // 
            btnXoaCuoi.BackColor = Color.Wheat;
            btnXoaCuoi.Location = new Point(43, 330);
            btnXoaCuoi.Name = "btnXoaCuoi";
            btnXoaCuoi.Size = new Size(393, 40);
            btnXoaCuoi.TabIndex = 8;
            btnXoaCuoi.Text = "Xóa phần tử cuối";
            btnXoaCuoi.UseVisualStyleBackColor = false;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            // 
            // btnXoaDau
            // 
            btnXoaDau.BackColor = Color.Moccasin;
            btnXoaDau.Location = new Point(43, 271);
            btnXoaDau.Name = "btnXoaDau";
            btnXoaDau.Size = new Size(393, 40);
            btnXoaDau.TabIndex = 7;
            btnXoaDau.Text = "Xóa phần tử đầu";
            btnXoaDau.UseVisualStyleBackColor = false;
            btnXoaDau.Click += btnXoaDau_Click;
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.BackColor = Color.PapayaWhip;
            btnXoaDangChon.Location = new Point(43, 207);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(393, 40);
            btnXoaDangChon.TabIndex = 6;
            btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            btnXoaDangChon.UseVisualStyleBackColor = false;
            btnXoaDangChon.Click += btnXoaDangChon_Click;
            // 
            // btnLecuoi
            // 
            btnLecuoi.BackColor = Color.BlanchedAlmond;
            btnLecuoi.Location = new Point(43, 151);
            btnLecuoi.Name = "btnLecuoi";
            btnLecuoi.Size = new Size(393, 40);
            btnLecuoi.TabIndex = 5;
            btnLecuoi.Text = "Chọn số lẻ cuối";
            btnLecuoi.UseVisualStyleBackColor = false;
            btnLecuoi.Click += btnLecuoi_Click;
            // 
            // btnChandau
            // 
            btnChandau.BackColor = Color.AntiqueWhite;
            btnChandau.Location = new Point(43, 92);
            btnChandau.Name = "btnChandau";
            btnChandau.Size = new Size(393, 40);
            btnChandau.TabIndex = 4;
            btnChandau.Text = "Chọn số chẵn đầu";
            btnChandau.UseVisualStyleBackColor = false;
            btnChandau.Click += btnChandau_Click;
            // 
            // btTang2
            // 
            btTang2.BackColor = Color.Linen;
            btTang2.Location = new Point(43, 32);
            btTang2.Name = "btTang2";
            btTang2.Size = new Size(393, 40);
            btTang2.TabIndex = 3;
            btTang2.Text = "Tăng mỗi phần tử lên 2";
            btTang2.UseVisualStyleBackColor = false;
            btTang2.Click += btTang2_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.SeaShell;
            btnKetThuc.Location = new Point(12, 437);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(708, 40);
            btnKetThuc.TabIndex = 9;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // frmThaotacso
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(732, 488);
            ControlBox = false;
            Controls.Add(btnKetThuc);
            Controls.Add(grpChucnang);
            Controls.Add(ltsSo);
            Controls.Add(btnCapnhat);
            Controls.Add(txtSo);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmThaotacso";
            Text = "THAO TÁC SỐ";
            grpChucnang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSo;
        private Button btnCapnhat;
        private ListBox ltsSo;
        private GroupBox grpChucnang;
        private Button btnLecuoi;
        private Button btnChandau;
        private Button btTang2;
        private Button btnXoaCuoi;
        private Button btnXoaDau;
        private Button btnXoaDangChon;
        private Button btnKetThuc;
    }
}
