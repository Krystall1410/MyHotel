namespace MH.Domain.entities;

public partial class Nhanvien
{
    public string MaNhanVien { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string Cccd { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public string TrangThai { get; set; } = null!;

    public string ChucVu { get; set; } = null!;

    public decimal LuongCoBan { get; set; }

    public virtual ICollection<ThuePhong> ThuePhongs { get; set; } = new List<ThuePhong>();
}
