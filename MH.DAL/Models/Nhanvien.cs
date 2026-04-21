using System;
using System.Collections.Generic;

namespace MH.DAL.Models;

public partial class Nhanvien
{
    public string MãNhânViên { get; set; } = null!;

    public string TênNhânViên { get; set; } = null!;

    public DateOnly NgàySinh { get; set; }

    public string? GiớiTính { get; set; }

    public string Cccd { get; set; } = null!;

    public string? ĐịaChỉ { get; set; }

    public string? Email { get; set; }

    public string? SốĐiệnThoại { get; set; }

    public string TrạngThái { get; set; } = null!;

    public string ChứcVụ { get; set; } = null!;

    public decimal LươngCơBản { get; set; }
}
