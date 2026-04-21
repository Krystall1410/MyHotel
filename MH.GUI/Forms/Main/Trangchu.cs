namespace MH.GUI.Forms.Main
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            // Đăng ký sự kiện vẽ Logo
            //picIcon.Paint += PicIcon_Paint;
        }

        private void PicIcon_Paint(object sender, PaintEventArgs e)
        {
            // Tự động tạo một Logo bằng code (không cần file ảnh)
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.White, 2);
            Brush brush = new SolidBrush(Color.White);

            // Vẽ mái nhà (Khách sạn)
            Point[] roof = { new Point(5, 20), new Point(25, 5), new Point(45, 20) };
            g.FillPolygon(brush, roof);

            // Vẽ thân toà nhà
            g.DrawRectangle(pen, 10, 20, 30, 25);

            // Vẽ cửa ra vào chính giữa
            g.FillRectangle(brush, 20, 30, 10, 15);

            // Vẽ 2 cửa sổ
            g.FillRectangle(brush, 14, 23, 6, 5);
            g.FillRectangle(brush, 30, 23, 6, 5);

            pen.Dispose();
            brush.Dispose();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPMS_Click(object sender, EventArgs e)
        {

        }

        private void picIcon_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlSidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
