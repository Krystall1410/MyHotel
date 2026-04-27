namespace MH.Domain.entities;

public partial class Luong
{
    public string MaChucVu { get; set; } = null!;

    public decimal LuongCoBan { get; set; }

    public decimal PhuCap { get; set; }

    public decimal TienLamThemGio { get; set; }

    public virtual ChucVu MaChucVuNavigation { get; set; } = null!;
}
