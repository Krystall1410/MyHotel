using System;
using System.Windows.Forms;
using MH.BLL.Services;

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
        }
    }
}