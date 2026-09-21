namespace DanhSachViecLam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);

                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void mnuDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int index = lstCongViec.SelectedIndex;

                    lstCongViec.Items[index] =
                        "[Hoàn thành] " + congViec;

                    lstCongViec.SelectedIndex = index;
                }
            }
        }

        private void mnuXoaCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc trước khi xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tất cả công việc không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
