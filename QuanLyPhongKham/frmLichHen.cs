using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {

        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string lichHen =
                dtpNgayGioHen.Value.ToString("dd/MM/yyyy HH:mm") +
                " - " +
                txtTenBenhNhan.Text;

            danhSachLichHen.Add(lichHen);

            lstLichHen.Items.Add(lichHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
