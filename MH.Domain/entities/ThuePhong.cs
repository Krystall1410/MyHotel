namespace MH.Domain.entities;

public partial class ThuePhong
{
    public int MaPhieuThue { get; set; }

    public string MaKhachHang { get; set; } = null!;

    public string MaPhong { get; set; } = null!;

    public string MaNhanVien { get; set; } = null!;

    public DateTime GioCheckIn { get; set; }

    public DateTime GioCheckOut { get; set; }

    public DateTime GioCheckOutThucTe { get; set; }

    public decimal TienCoc { get; set; }

    public int SoNguoiO { get; set; }

    public string? GhiChu { get; set; }

    public string TrangThaiThanhToan { get; set; } = null!;

    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;

    public virtual Nhanvien MaNhanVienNavigation { get; set; } = null!;

    public virtual Phong MaPhongNavigation { get; set; } = null!;
}
