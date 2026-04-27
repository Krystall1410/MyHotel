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
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                this.Hide(); // Ẩn form Login thay vì Close ngay

                // Khởi tạo Trang chủ từ folder Main
                var main = new MH.GUI.Forms.Main.Trangchu();

                main.IsLoggedIn = true;
                main.UpdateMenuUI();

                // Sử dụng ShowDialog để chặn luồng, đảm bảo Form hiện lên
                main.ShowDialog();

                this.Close(); // Sau khi tắt Trang chủ thì mới đóng hẳn ứng dụng
            }
        }

        private void lnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // 2. Mở form Đăng ký dưới dạng hội thoại
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();

            // 3. Sau khi form Đăng ký đóng lại, hiện lại form Login để người dùng đăng nhập
            this.Show();

        }
    }
}