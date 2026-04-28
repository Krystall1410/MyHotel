using MH.GUI.Forms.Auth;
using MH.GUI.Forms.Options;

namespace MH.GUI.Forms.Main
{
    public partial class Trangchu : Form
    {

        public Trangchu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        public bool IsLoggedIn { get; set; } = false;

        public void UpdateMenuUI()
        {

            if (btnLogout != null)
            {
                btnLogout.Visible = IsLoggedIn;
            }
        }

        private void PicIcon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.White, 2);
            Brush brush = new SolidBrush(Color.White);

            Point[] roof = { new Point(5, 20), new Point(25, 5), new Point(45, 20) };
            g.FillPolygon(brush, roof);

            g.DrawRectangle(pen, 10, 20, 30, 25);

            g.FillRectangle(brush, 20, 30, 10, 15);

            g.FillRectangle(brush, 14, 23, 6, 5);
            g.FillRectangle(brush, 30, 23, 6, 5);

            pen.Dispose();
            brush.Dispose();
        }

        private void HideSubMenu()
        {
            if (pnSubMenuLeTan.Visible == true)
                pnSubMenuLeTan.Visible = false;
            if (pnSubMenuKhachHang.Visible == true)
                pnSubMenuKhachHang.Visible = false;
            if (pnSubMenuDieuHanh.Visible == true)
                pnSubMenuDieuHanh.Visible = false;
            if (pnSubMenuTaiChinh.Visible == true)
                pnSubMenuTaiChinh.Visible = false;
            if (pnSubMenuHeThong.Visible == true)
                pnSubMenuHeThong.Visible = false;
        }
        private void CustomizeDesign()
        {
            pnSubMenuLeTan.Visible = false;
            pnSubMenuKhachHang.Visible = false;
            pnSubMenuDieuHanh.Visible = false;
            pnSubMenuTaiChinh.Visible = false;
            pnSubMenuHeThong.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void OpenChildForm(Form childForm)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Ccas sự kiện trong nút chính

        private void btnMenuLeTan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuLeTan);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuKhachHang);
        }
        private void btnDieuHanh_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuDieuHanh);
        }
        private void btnTaiChinh_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuTaiChinh);
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuHeThong);
        }
        //Các sự kiện của nút con 
        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTiepNhanKhach());
            HideSubMenu();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                IsLoggedIn = false;
                UpdateMenuUI();

                this.Hide();

                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();

                this.Close();
            }
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MH.GUI.Forms.Options.frmChucVu());
            HideSubMenu();
        }
    }
}


