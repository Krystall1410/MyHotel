using System;
using System.Windows.Forms;

namespace MH.GUI.Forms.Auth
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            // Thêm các ch?c v? c? b?n vào ComboBox
            cmbRole.Items.Add("Qu?n lý");
            cmbRole.Items.Add("L? tân");
            cmbRole.Items.Add("Nhân viên");
            cmbRole.SelectedIndex = 1; // M?c ??nh ch?n L? tân
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tr? v? trang ??ng nh?p
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // X? lý logic ??ng ký ? ?ây
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nh?p ??y ?? thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("M?t kh?u xác nh?n không kh?p!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: G?i BLL ?? l?u vào c? s? d? li?u
            MessageBox.Show($"??ng ký thành công tài kho?n: {username}\nCh?c v?: {role}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
