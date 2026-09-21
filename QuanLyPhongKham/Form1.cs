namespace QuanLyPhongKham
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void menuBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan frm = new frmBenhNhan();

            frm.MdiParent = this;

            frm.Show();
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen frm = new frmLichHen();

            frm.MdiParent = this;

            frm.Show();
        }
    }
}
