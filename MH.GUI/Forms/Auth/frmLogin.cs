using System;
using System.Windows.Forms;
using MH.BLL; // Gọi thư viện tầng BLL

namespace MH.GUI.Forms.Auth
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
        }
    }
}