using MH.BLL.Services;
using MH.Domain.entities;

namespace MH.GUI.Forms.CRUD
{
    public partial class frmChucVu_Detail : Form
    {
        private readonly ChucVuService _chucVuService;
        public bool IsEditMode { get; set; } = false;

        public frmChucVu_Detail()
        {
            InitializeComponent();
            _chucVuService = new ChucVuService();

            this.btnLuu.Click += BtnLuu_Click;
            this.btnHuy.Click += BtnHuy_Click;
        }

        public void LoadDataForEdit(ChucVu cv)
        {
            txtMaChucVu.Text = cv.MaChucVu;
            txtTenChucVu.Text = cv.TenChucVu;

            txtMaChucVu.ReadOnly = true;
            IsEditMode = true;
            lblTitle.Text = "SỬA CHỨC VỤ";
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string maChucVu = txtMaChucVu.Text.Trim();
            string tenChucVu = txtTenChucVu.Text.Trim();


            if (string.IsNullOrEmpty(maChucVu) || string.IsNullOrEmpty(tenChucVu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin (Mã chức vụ và Tên chức vụ)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChucVu cv = new ChucVu
            {
                MaChucVu = maChucVu,
                TenChucVu = tenChucVu
            };

            bool result = false;
            try
            {
                if (IsEditMode)
                {
                    // Gọi hàm từ BLL
                    result = _chucVuService.UpdateChucVu(cv);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Gọi hàm từ BLL
                    result = _chucVuService.AddChucVu(cv);
                    if (result)
                    {
                        MessageBox.Show("Thêm chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Thêm thất bại! Mã chức vụ này có thể đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (IsEditMode)
                {
                    MessageBox.Show("Cập nhật thất bại! Xin kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}