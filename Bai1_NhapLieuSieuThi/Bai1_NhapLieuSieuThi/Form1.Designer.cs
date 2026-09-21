namespace Bai1_NhapLieuSieuThi
{
    partial class FormBanHang
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
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(165, 36);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(593, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(165, 98);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(593, 27);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(165, 171);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(593, 27);
            txtDonGia.TabIndex = 4;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(165, 239);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(524, 239);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trang (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "MaSP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 171);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Đơn giá";
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(109, 285);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(649, 144);
            lstKetQua.TabIndex = 10;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "FormBanHang";
            Text = "Form1";
            KeyDown += FormBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstKetQua;
    }
}
