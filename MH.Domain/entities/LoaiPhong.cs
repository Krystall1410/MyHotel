namespace MH.Domain.entities;

public partial class LoaiPhong
{
    public string MaLoai { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public decimal GiaGoc { get; set; }

    public virtual ICollection<Phong> Phongs { get; set; } = new List<Phong>();
}
