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
            // 1. Lấy dữ liệu từ giao diện
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string role = cmbRole.Text; // Giả định bạn đã có dữ liệu trong ComboBox

            // 2. Gọi logic xử lý từ BLL
            string result = _authService.Register(user, pass, confirm, role);

            // 3. Hiển thị kết quả
            if (result == "Thành công")
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}