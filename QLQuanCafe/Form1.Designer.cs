namespace QLQuanCafe
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
            menuStrip1 = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            menuDoiMauNen = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuDoiMauNen, menuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(88, 24);
            menuHeThong.Text = "Hệ Thống";
            // 
            // menuDoiMauNen
            // 
            menuDoiMauNen.Name = "menuDoiMauNen";
            menuDoiMauNen.Size = new Size(177, 26);
            menuDoiMauNen.Text = "Đổi màu nền";
            menuDoiMauNen.Click += menuDoiMauNen_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(177, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Size = new Size(63, 20);
            lblGioHienTai.Text = "00:00:00";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = false;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(110, 20);
            lblTrangThai.Text = "...";
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenQuan
            // 
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Size = new Size(612, 20);
            lblTenQuan.Spring = true;
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG - 6551071034";
            lblTenQuan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuDoiMauNen;
        private ToolStripMenuItem menuThoat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGioHienTai;
        private ToolStripStatusLabel lblTenQuan;
        private ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Timer timer1;
        private ColorDialog colorDialog1;
    }
}
