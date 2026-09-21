namespace DanhSachViecLam
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
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnuDanhDauHoanThanh = new ToolStripMenuItem();
            mnuXoaCongViec = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCongViecMoi.Location = new Point(65, 58);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(312, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(436, 56);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = contextMenuStrip1;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(32, 117);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(656, 264);
            lstCongViec.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnuDanhDauHoanThanh, mnuXoaCongViec, mnuXoaTatCa });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(221, 76);
            // 
            // mnuDanhDauHoanThanh
            // 
            mnuDanhDauHoanThanh.Name = "mnuDanhDauHoanThanh";
            mnuDanhDauHoanThanh.Size = new Size(220, 24);
            mnuDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuDanhDauHoanThanh.Click += mnuDanhDauHoanThanh_Click;
            // 
            // mnuXoaCongViec
            // 
            mnuXoaCongViec.Name = "mnuXoaCongViec";
            mnuXoaCongViec.Size = new Size(220, 24);
            mnuXoaCongViec.Text = "Xóa công việc này";
            mnuXoaCongViec.Click += mnuXoaCongViec_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuDanhDauHoanThanh;
        private ToolStripMenuItem mnuXoaCongViec;
        private ToolStripMenuItem mnuXoaTatCa;
    }
}
