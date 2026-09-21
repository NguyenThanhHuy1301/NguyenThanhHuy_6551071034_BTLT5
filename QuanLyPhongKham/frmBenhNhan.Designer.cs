namespace QuanLyPhongKham
{
    partial class frmBenhNhan
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numTuoi = new NumericUpDown();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(94, 59);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            lblHoTen.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(271, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 135);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Tuổi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 202);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 3;
            label3.Text = "Triệu chứng:";
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(271, 128);
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(150, 27);
            numTuoi.TabIndex = 4;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(271, 202);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(125, 27);
            txtTrieuChung.TabIndex = 5;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(286, 265);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(94, 29);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(85, 311);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(395, 104);
            lstBenhNhan.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(numTuoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private NumericUpDown numTuoi;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
    }
}