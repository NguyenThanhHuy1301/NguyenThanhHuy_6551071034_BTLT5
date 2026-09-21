using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai2_BangVeMini
{
    public partial class Form1 : Form
    {
        private bool dangVe = false;
        private Point diemCu;
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;

                diemCu = e.Location;

                lblViTri.Text =
                    "X: " + e.X + ", Y: " + e.Y + " - Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text =
        "X: " + e.X + ", Y: " + e.Y;

            if (dangVe)
            {
                g.DrawLine(
                    Pens.Black,
                    diemCu,
                    e.Location
                );

                diemCu = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;

                lblViTri.Text =
                    "X: " + e.X + ", Y: " + e.Y + " - Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();

                lblViTri.Text =
                    "X: " + e.X + ", Y: " + e.Y + " - Sẵn sàng";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
