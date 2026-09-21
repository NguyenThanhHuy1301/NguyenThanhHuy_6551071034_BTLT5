namespace Bai1_NhapLieuSieuThi
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                txtMaSP.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();

                txtMaSP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dong =
       txtMaSP.Text + " | " +
       txtSoLuong.Text + " | " +
       txtDonGia.Text;

            lstKetQua.Items.Add(dong);

            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtMaSP.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {

        }
    }
}
