namespace MH.Domain.entities;

public partial class Phong
{
    public string MaPhong { get; set; } = null!;

    public string SoPhong { get; set; } = null!;

    public string MaLoai { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public virtual LoaiPhong MaLoaiNavigation { get; set; } = null!;

    public virtual ICollection<ThuePhong> ThuePhongs { get; set; } = new List<ThuePhong>();
}
