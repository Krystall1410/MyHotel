namespace MH.Domain.entities;

public partial class KhachHang
{
    public string MaKhachHang { get; set; } = null!;

    public string TenKhachHang { get; set; } = null!;

    public string Cccd { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public virtual ICollection<ThuePhong> ThuePhongs { get; set; } = new List<ThuePhong>();
}
