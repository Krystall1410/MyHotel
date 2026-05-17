using System;
using System.Collections.Generic;

namespace MH.Domain.entities;

public partial class LichLamViec
{
    public int MaLich { get; set; }

    public string MaNhanVien { get; set; } = null!;

    public DateTime NgayLamViec { get; set; }

    public string CaLam { get; set; } = null!; // Sáng, Chiều, Tối

    public string? GhiChu { get; set; }

    public virtual Nhanvien MaNhanVienNavigation { get; set; } = null!;
}
