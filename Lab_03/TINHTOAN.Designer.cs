namespace Lab_03
{
    partial class TINHTOAN
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
            lblson = new Label();
            lblsom = new Label();
            lblketqua = new Label();
            txtsom = new TextBox();
            txtson = new TextBox();
            txtketqua = new TextBox();
            btncong = new Button();
            btntru = new Button();
            btnnhan = new Button();
            btnchia = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(487, 79);
            label1.TabIndex = 0;
            label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblson.Location = new Point(18, 134);
            lblson.Margin = new Padding(4, 0, 4, 0);
            lblson.Name = "lblson";
            lblson.Size = new Size(107, 26);
            lblson.TabIndex = 0;
            lblson.Text = "Nhập số n";
            lblson.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsom
            // 
            lblsom.AutoSize = true;
            lblsom.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsom.Location = new Point(18, 199);
            lblsom.Margin = new Padding(4, 0, 4, 0);
            lblsom.Name = "lblsom";
            lblsom.Size = new Size(113, 26);
            lblsom.TabIndex = 0;
            lblsom.Text = "Nhập số m";
            lblsom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblketqua
            // 
            lblketqua.AutoSize = true;
            lblketqua.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblketqua.Location = new Point(18, 265);
            lblketqua.Margin = new Padding(4, 0, 4, 0);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(84, 26);
            lblketqua.TabIndex = 0;
            lblketqua.Text = "Kết quả";
            lblketqua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtsom
            // 
            txtsom.BorderStyle = BorderStyle.FixedSingle;
            txtsom.Font = new Font("Times New Roman", 13.2000008F);
            txtsom.Location = new Point(188, 199);
            txtsom.Margin = new Padding(4);
            txtsom.Name = "txtsom";
            txtsom.Size = new Size(341, 33);
            txtsom.TabIndex = 1;
            txtsom.TextAlign = HorizontalAlignment.Right;
            // 
            // txtson
            // 
            txtson.BorderStyle = BorderStyle.FixedSingle;
            txtson.Font = new Font("Times New Roman", 13.2000008F);
            txtson.Location = new Point(188, 135);
            txtson.Margin = new Padding(4);
            txtson.Name = "txtson";
            txtson.Size = new Size(341, 33);
            txtson.TabIndex = 1;
            txtson.TextAlign = HorizontalAlignment.Right;
            // 
            // txtketqua
            // 
            txtketqua.BackColor = Color.MistyRose;
            txtketqua.BorderStyle = BorderStyle.FixedSingle;
            txtketqua.Font = new Font("Times New Roman", 13.2000008F);
            txtketqua.Location = new Point(188, 266);
            txtketqua.Margin = new Padding(4);
            txtketqua.Name = "txtketqua";
            txtketqua.ReadOnly = true;
            txtketqua.Size = new Size(341, 33);
            txtketqua.TabIndex = 1;
            txtketqua.TextAlign = HorizontalAlignment.Center;
            // 
            // btncong
            // 
            btncong.AutoSize = true;
            btncong.BackColor = Color.LightSalmon;
            btncong.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btncong.Location = new Point(13, 421);
            btncong.Margin = new Padding(4);
            btncong.Name = "btncong";
            btncong.Size = new Size(62, 44);
            btncong.TabIndex = 2;
            btncong.Text = "+";
            btncong.UseVisualStyleBackColor = false;
            btncong.Click += btncong_Click;
            // 
            // btntru
            // 
            btntru.BackColor = Color.PeachPuff;
            btntru.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btntru.Location = new Point(93, 421);
            btntru.Margin = new Padding(4);
            btntru.Name = "btntru";
            btntru.Size = new Size(62, 45);
            btntru.TabIndex = 2;
            btntru.Text = "-";
            btntru.UseVisualStyleBackColor = false;
            btntru.Click += btntru_Click;
            // 
            // btnnhan
            // 
            btnnhan.BackColor = Color.Orange;
            btnnhan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btnnhan.Location = new Point(176, 421);
            btnnhan.Margin = new Padding(4);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(62, 46);
            btnnhan.TabIndex = 2;
            btnnhan.Text = "x";
            btnnhan.UseVisualStyleBackColor = false;
            btnnhan.Click += btnnhan_Click;
            // 
            // btnchia
            // 
            btnchia.BackColor = Color.Tan;
            btnchia.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btnchia.Location = new Point(257, 421);
            btnchia.Margin = new Padding(4);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(62, 47);
            btnchia.TabIndex = 2;
            btnchia.Text = "/";
            btnchia.UseVisualStyleBackColor = false;
            btnchia.Click += btnchia_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Red;
            btnxoa.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btnxoa.Location = new Point(354, 421);
            btnxoa.Margin = new Padding(4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(104, 44);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Tomato;
            btnthoat.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold);
            btnthoat.Location = new Point(482, 421);
            btnthoat.Margin = new Padding(4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(122, 44);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 500);
            ControlBox = false;
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnchia);
            Controls.Add(btnnhan);
            Controls.Add(btntru);
            Controls.Add(btncong);
            Controls.Add(txtketqua);
            Controls.Add(txtson);
            Controls.Add(txtsom);
            Controls.Add(lblketqua);
            Controls.Add(lblsom);
            Controls.Add(lblson);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "TÍNH TOÁN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblson;
        private Label lblsom;
        private Label lblketqua;
        private TextBox txtsom;
        private TextBox txtson;
        private TextBox txtketqua;
        private Button btncong;
        private Button btntru;
        private Button btnnhan;
        private Button btnchia;
        private Button btnxoa;
        private Button btnthoat;
    }
}
