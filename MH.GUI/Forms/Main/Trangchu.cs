using MH.Domain;
using MH.Domain.entities;
using MH.GUI.Forms.Auth;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MH.GUI.Forms.Main
{
    public partial class Trangchu : Form
    {
        public bool IsLoggedIn { get; set; } = false;

        public Trangchu()
        {
            InitializeComponent();
            CustomizeDesign();
            CheckPermission();
        }

        // --- PHÂN QUYỀN ---
        public void CheckPermission()
        {
            // Kiểm tra mã Admin (AD)
            if (Session.CurrentRole != "AD")
            {
                btnTaiChinh.Visible = false;
                btnHeThong.Visible = false;
                pnSubMenuTaiChinh.Visible = false;
                pnSubMenuHeThong.Visible = false;
            }
            else
            {
                btnTaiChinh.Visible = true;
                btnHeThong.Visible = true;
            }
        }

        // --- SỰ KIỆN CLICK (Mỗi nút chỉ giữ đúng 1 hàm) ---
        private void btnMenuLeTan_Click(object sender, EventArgs e) => ShowSubMenu(pnSubMenuLeTan);
        private void btnKhachHang_Click(object sender, EventArgs e) => ShowSubMenu(pnSubMenuKhachHang);
        private void btnDieuHanh_Click(object sender, EventArgs e) => ShowSubMenu(pnSubMenuDieuHanh);
        private void btnTaiChinh_Click(object sender, EventArgs e) => ShowSubMenu(pnSubMenuTaiChinh);
        private void btnHeThong_Click(object sender, EventArgs e) => ShowSubMenu(pnSubMenuHeThong);

        private void btnTaiKhoan_Click(object sender, EventArgs e) => HideSubMenu();

        private void btnQuanLiNhanSu_Click(object sender, EventArgs e) => HideSubMenu();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new frmLogin().ShowDialog();
                this.Close();
            }
        }

        // --- HỖ TRỢ GIAO DIỆN ---
        private void CustomizeDesign()
        {
            pnSubMenuLeTan.Visible = pnSubMenuKhachHang.Visible =
            pnSubMenuDieuHanh.Visible = pnSubMenuTaiChinh.Visible =
            pnSubMenuHeThong.Visible = false;
        }

        private void HideSubMenu()
        {
            pnSubMenuLeTan.Visible = pnSubMenuKhachHang.Visible =
            pnSubMenuDieuHanh.Visible = pnSubMenuTaiChinh.Visible =
            pnSubMenuHeThong.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (pnMain.Controls.Count > 0) pnMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void PicIcon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.White, 2))
            using (Brush brush = new SolidBrush(Color.White))
            {
                Point[] roof = { new Point(5, 20), new Point(25, 5), new Point(45, 20) };
                g.FillPolygon(brush, roof);
                g.DrawRectangle(pen, 10, 20, 30, 25);
                g.FillRectangle(brush, 20, 30, 10, 15);
                g.FillRectangle(brush, 14, 23, 6, 5);
                g.FillRectangle(brush, 30, 23, 6, 5);
            }
        }
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan());
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            
            frmLoaiPhong f = new frmLoaiPhong();
            pnMain.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnMain.Controls.Add(f);
            f.Show();
        }
    }
}