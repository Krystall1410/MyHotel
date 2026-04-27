namespace MH.Domain.entities;

public partial class TaiKhoan
{
    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? MaChucVu { get; set; }

    public virtual ChucVu? MaChucVuNavigation { get; set; }
}
