using MH.BLL.Services;
using MH.Domain.entities;
using MH.Domain;
using System;
using System.Windows.Forms;

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
            string usernameInput = txtUsername.Text.Trim();
            string passwordInput = txtPassword.Text;
            TaiKhoan account = _authService.Login(usernameInput, passwordInput);

            if (account != null)
            {
                Session.CurrentRole = account.MaChucVu;
                Session.UserName = account.TenDangNhap;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var main = new MH.GUI.Forms.Main.Trangchu();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}