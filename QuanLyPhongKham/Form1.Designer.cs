namespace QuanLyPhongKham
{
    partial class frmParent
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
            menuStrip1 = new MenuStrip();
            menuNghiepVu = new ToolStripMenuItem();
            menuBenhNhan = new ToolStripMenuItem();
            menuLichHen = new ToolStripMenuItem();
            menuCuaSo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuNghiepVu, menuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = menuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuNghiepVu
            // 
            menuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { menuBenhNhan, menuLichHen });
            menuNghiepVu.Name = "menuNghiepVu";
            menuNghiepVu.Size = new Size(91, 24);
            menuNghiepVu.Text = "Nghiệp vụ";
            // 
            // menuBenhNhan
            // 
            menuBenhNhan.Name = "menuBenhNhan";
            menuBenhNhan.Size = new Size(228, 26);
            menuBenhNhan.Text = "Thông tin bệnh nhân";
            menuBenhNhan.Click += menuBenhNhan_Click;
            // 
            // menuLichHen
            // 
            menuLichHen.Name = "menuLichHen";
            menuLichHen.Size = new Size(228, 26);
            menuLichHen.Text = "Đặt lịch hẹn";
            menuLichHen.Click += menuLichHen_Click;
            // 
            // menuCuaSo
            // 
            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(68, 24);
            menuCuaSo.Text = "Cửa sổ";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Text = "Quản lý phòng khám";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuNghiepVu;
        private ToolStripMenuItem menuBenhNhan;
        private ToolStripMenuItem menuCuaSo;
        private ToolStripMenuItem menuLichHen;
    }
}
