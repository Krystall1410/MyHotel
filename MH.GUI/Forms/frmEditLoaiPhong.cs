using MH.DAL.Models;
using MH.Domain.entities;
using System;
using System.Windows.Forms;

namespace MH.GUI.Forms
{
    public partial class frmEditLoaiPhong : Form
    {
        public bool IsAddMode { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string Gia { get; set; }

        public frmEditLoaiPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void frmEditLoaiPhong_Load(object sender, EventArgs e)
        {
            if (IsAddMode == false)
            {
                this.Text = "Cập nhật loại phòng";
                txtMaLoai.Text = MaLoai;
                txtTenLoai.Text = TenLoai;
                txtGia.Text = Gia;
                txtMaLoai.ReadOnly = true;
            }
            else
            {
                this.Text = "Thêm loại phòng mới";
                txtMaLoai.ReadOnly = false;
            }
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MyHotelContext())
                {
                    if (IsAddMode)
                    {
                        var moi = new LoaiPhong();
                        moi.MaLoai = txtMaLoai.Text.Trim();
                        moi.TenLoai = txtTenLoai.Text.Trim();
                        moi.GiaGoc = decimal.Parse(txtGia.Text);
                        db.LoaiPhongs.Add(moi);
                    }
                    else
                    {
                        string ma = txtMaLoai.Text.Trim();
                        var sua = db.LoaiPhongs.Find(ma);

                        if (sua != null)
                        {
                            sua.TenLoai = txtTenLoai.Text.Trim();

                            if (decimal.TryParse(txtGia.Text, out decimal giaCvt))
                            {
                                sua.GiaGoc = giaCvt;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu trong hệ thống!");
                            return;
                        }
                    }
                    db.SaveChanges();

                    MessageBox.Show("Lưu thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
