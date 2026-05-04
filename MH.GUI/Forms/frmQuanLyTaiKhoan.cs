using MH.DAL.Models;
using MH.Domain.entities; 
using MH.GUI.Forms.Auth;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH.GUI.Forms
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new MyHotelContext())
                {
                    var list = db.TaiKhoans.Select(p => new
                    {
                        p.TenDangNhap,
                        p.MatKhau,
                        p.MaChucVu
                    }).ToList();

                    dgvTaiKhoan.DataSource = list;
                    if (dgvTaiKhoan.Columns.Count > 0)
                    {
                        dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                        dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                        dgvTaiKhoan.Columns["MaChucVu"].HeaderText = "Mã chức vụ";
                        dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;
            string userName = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {userName}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MyHotelContext())
                    {
                        var account = db.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == userName);
                        if (account != null)
                        {
                            db.TaiKhoans.Remove(account);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công!");
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            try
            {
                using (var db = new MyHotelContext())
                {
                    var result = db.TaiKhoans
                        .Where(x => x.TenDangNhap.Contains(keyword))
                        .Select(p => new
                        {
                            p.TenDangNhap,
                            p.MatKhau,
                            p.MaChucVu
                        }).ToList();

                    dgvTaiKhoan.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn sửa!");
                return;
            }
            string user = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            string pass = dgvTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            string role = dgvTaiKhoan.CurrentRow.Cells["MaChucVu"].Value.ToString();
            frmEditAccount fEdit = new frmEditAccount(user, pass, role);
            fEdit.ShowDialog();
            LoadData();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
    }
}

    
