using MH.BLL.Services;
using MH.Domain.entities;
using MH.GUI.Forms.CRUD;

namespace MH.GUI.Forms.Options
{
    public partial class frmChucVu : Form
    {
        private readonly ChucVuService _chucVuService = new ChucVuService();

        public frmChucVu()
        {
            InitializeComponent();
            this.Load += FrmChucVu_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            if (btnXoa != null) btnXoa.Click += BtnXoa_Click;
            if (btnTimKiem != null) btnTimKiem.Click += BtnTimKiem_Click;
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var listChucVu = _chucVuService.GetAllChucVu();
                HienThiGrid(listChucVu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiGrid(List<ChucVu> lst)
        {
            dgvChucVu.DataSource = lst;

            if (dgvChucVu.Columns["MaChucVu"] != null)
                dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã Chức Vụ";

            if (dgvChucVu.Columns["TenChucVu"] != null)
                dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";

            if (dgvChucVu.Columns["TaiKhoans"] != null) dgvChucVu.Columns["TaiKhoans"].Visible = false;
            if (dgvChucVu.Columns["Luongs"] != null) dgvChucVu.Columns["Luongs"].Visible = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmChucVu_Detail f = new frmChucVu_Detail();
            f.lblTitle.Text = "THÊM MỚI CHỨC VỤ";

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 chức vụ cần sửa!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvChucVu.SelectedRows[0];
            string maChucVu = row.Cells["MaChucVu"].Value?.ToString();
            string tenChucVu = row.Cells["TenChucVu"].Value?.ToString();

            frmChucVu_Detail f = new frmChucVu_Detail();

            ChucVu cv = new ChucVu { MaChucVu = maChucVu, TenChucVu = tenChucVu };
            f.LoadDataForEdit(cv);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 chức vụ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvChucVu.SelectedRows[0];
            string maChucVu = row.Cells["MaChucVu"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa chức vụ [{maChucVu}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool ketQua = _chucVuService.DeleteChucVu(maChucVu);
                if (ketQua)
                {
                    MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Chức vụ này có thể đã được gán cho nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {

            string tuKhoa = "";

            if (txtTimKiem != null)
            {
                tuKhoa = txtTimKiem.Text.Trim();
            }

            var ketQua = _chucVuService.SearchChucVu(tuKhoa);

            if (ketQua == null || ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy chức vụ nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            HienThiGrid(ketQua);
        }
    }
}