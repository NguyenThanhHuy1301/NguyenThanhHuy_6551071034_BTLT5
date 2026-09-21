namespace DangKyPhongGym
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGoiTap = new Label();
            cboGoiTap = new ComboBox();
            lblSoBuoiTuan = new Label();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(63, 50);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ Tên";
            lblHoTen.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(218, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            toolTip1.SetToolTip(txtHoTen, "Nhập đầy đủ họ và tên của hội viên");
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(63, 97);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(218, 97);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(69, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(78, 220);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(218, 215);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 7;
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(78, 271);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(58, 20);
            lblGoiTap.TabIndex = 8;
            lblGoiTap.Text = "Gói tập";
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(218, 268);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(151, 28);
            cboGoiTap.TabIndex = 9;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // lblSoBuoiTuan
            // 
            lblSoBuoiTuan.AutoSize = true;
            lblSoBuoiTuan.Location = new Point(78, 324);
            lblSoBuoiTuan.Name = "lblSoBuoiTuan";
            lblSoBuoiTuan.Size = new Size(95, 20);
            lblSoBuoiTuan.TabIndex = 10;
            lblSoBuoiTuan.Text = "Số buổi/tuần";
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(219, 324);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(150, 27);
            numSoBuoiTuan.TabIndex = 11;
            toolTip1.SetToolTip(numSoBuoiTuan, "Chọn số buổi tập trong một tuần, từ 1 đến 7 buổi");
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(338, 387);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            toolTip1.SetToolTip(btnDangKy, "Nhấn để đăng ký hội viên");
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(lblSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(lblGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGoiTap;
        private ComboBox cboGoiTap;
        private Label lblSoBuoiTuan;
        private NumericUpDown numSoBuoiTuan;
        private Button btnDangKy;
        private ToolTip toolTip1;
    }
}
