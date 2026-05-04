using MH.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MH.GUI.Forms
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new MyHotelContext())
                {
                    var data = db.LoaiPhongs.ToList();

                    dgvLoaiPhong.DataSource = null;
                    dgvLoaiPhong.AutoGenerateColumns = true;
                    dgvLoaiPhong.DataSource = data;
                    if (dgvLoaiPhong.Columns["MaLoai"] != null)
                        dgvLoaiPhong.Columns["MaLoai"].HeaderText = "Mã Loại";

                    if (dgvLoaiPhong.Columns["TenLoai"] != null)
                        dgvLoaiPhong.Columns["TenLoai"].HeaderText = "Tên Loại Phòng";

                    if (dgvLoaiPhong.Columns["GiaGoc"] != null)
                    {
                        dgvLoaiPhong.Columns["GiaGoc"].HeaderText = "Giá Phòng";
                        dgvLoaiPhong.Columns["GiaGoc"].DefaultCellStyle.Format = "N0";
                    }
                    if (dgvLoaiPhong.Columns["Phongs"] != null)
                        dgvLoaiPhong.Columns["Phongs"].Visible = false;
                    dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmEditLoaiPhong f = new frmEditLoaiPhong();
            f.IsAddMode = true;
            f.ShowDialog();
            LoadData();     
        }
        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow != null)
            {
                frmEditLoaiPhong f = new frmEditLoaiPhong();
                f.IsAddMode = false;
                f.MaLoai = dgvLoaiPhong.CurrentRow.Cells["MaLoai"].Value.ToString();
                f.TenLoai = dgvLoaiPhong.CurrentRow.Cells["TenLoai"].Value.ToString();
                f.Gia = dgvLoaiPhong.CurrentRow.Cells["GiaGoc"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại phòng để sửa!");
            }
        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null || dgvLoaiPhong.CurrentRow.Cells["MaLoai"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            string maLoai = dgvLoaiPhong.CurrentRow.Cells["MaLoai"].Value.ToString();
            var xacNhan = MessageBox.Show($"Bạn có chắc muốn xóa loại {maLoai}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MyHotelContext())
                    {
                        var loai = db.LoaiPhongs.Find(maLoai);
                        if (loai != null)
                        {
                            db.LoaiPhongs.Remove(loai);
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa! Loại phòng này đang được sử dụng ở bảng khác.");
                }
            }
        }
        private void btnSearchPhong_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchMaLoai.Text.Trim().ToLower();
            using (var db = new MyHotelContext())
            {
                var result = db.LoaiPhongs
                               .Where(lp => lp.MaLoai.ToLower().Contains(keyword) || lp.TenLoai.ToLower().Contains(keyword))
                               .ToList();
                dgvLoaiPhong.DataSource = result;
            }
        }

        private void txtSearchMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchMaLoai.Text)) LoadData();
        }

    }
}