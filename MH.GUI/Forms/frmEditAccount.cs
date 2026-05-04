using MH.DAL.Models;
using MH.Domain.entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MH.GUI.Forms
{
    public partial class frmEditAccount : Form
    {
        public frmEditAccount(string user, string pass, string role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            cboRole.Items.Add("AD");
            cboRole.Items.Add("NV");
            cboRole.Items.Add("QL");
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUsername.Text = user;
            txtPassword.Text = pass;
            cboRole.SelectedItem = role; 
            txtUsername.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MyHotelContext())
                {
                    var account = db.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == txtUsername.Text);

                    if (account != null)
                    {
                        account.MatKhau = txtPassword.Text;
                        account.MaChucVu = cboRole.Text.Trim();
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }
    }
}