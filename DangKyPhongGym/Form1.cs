namespace DangKyPhongGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string goiTap = cboGoiTap.Text;
            int soBuoi = (int)numSoBuoiTuan.Value;

            string thongTin =
                "ĐĂNG KÝ HỘI VIÊN THÀNH CÔNG\n\n" +
                "Họ tên: " + hoTen + "\n" +
                "Số điện thoại: " + sdt + "\n" +
                "Gói tập: " + goiTap + "\n" +
                "Số buổi/tuần: " + soBuoi;

            MessageBox.Show(
                thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
