using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
namespace QuanLyPhongKham
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string benhNhan =
                "Họ tên: " + txtHoTen.Text +
                " - Tuổi: " + numTuoi.Value +
                " - Triệu chứng: " + txtTrieuChung.Text;

            danhSachBenhNhan.Add(benhNhan);

            lstBenhNhan.Items.Add(benhNhan);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = 0;

            txtHoTen.Focus();
        }
    }
    }

