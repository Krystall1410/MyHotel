namespace MH.Domain.entities;

public partial class ChucVu
{
    public string MaChucVu { get; set; } = null!;

    public string TenChucVu { get; set; } = null!;

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
