using System;
using System.Windows.Forms;
<<<<<<< HEAD
using MH.BLL; // Gọi thư viện tầng BLL
=======
using MH.BLL.Services;
>>>>>>> origin/CongHung

namespace MH.GUI.Forms.Auth
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _authService = new AuthService();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            TaiKhoanBLL bll = new TaiKhoanBLL();
            string ketQua = bll.DangNhap(user, pass);

            if (ketQua == "OK")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MH.GUI.Forms.Main.Trangchu fTrangChu = new MH.GUI.Forms.Main.Trangchu();
                this.Hide();
                fTrangChu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            // Gọi tầng BLL xử lý
            string result = _authService.Login(user, pass);

            if (result == "Thành công")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form trang chủ (Trangchu.cs trong folder Main)
                this.Hide();
                // frmMain main = new frmMain(); // Tên class thực tế của bạn trong Trangchu.cs
                // main.Show();
            }
            else
            {
                // Hiển thị lỗi từ BLL trả về
                MessageBox.Show(result, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển sang Form đăng ký
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
            this.Show();
>>>>>>> origin/CongHung
        }
    }
}