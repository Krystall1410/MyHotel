using MH.BLL.Services;

namespace MH.GUI.Forms.Auth
{
    public partial class frmRegister : Form
    {
        private readonly AuthService _authService = new AuthService();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            ;

            // Gọi BLL để lưu tài khoản vào Database
            string result = _authService.Register(user, pass, confirm);

            if (result == "Thành công")
            {
                MessageBox.Show("Đăng ký thành công! Mời bạn đăng nhập.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form đăng ký để quay về form đăng nhập đang đợi phía sau
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    
