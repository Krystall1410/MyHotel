using System;
using System.Collections.Generic;

namespace MH.DAL.Models;

public partial class Luong
{
    public string MãChứcVụ { get; set; } = null!;

    public decimal LươngCơBản { get; set; }

    public decimal PhụCấp { get; set; }

    public decimal TiềnLàmThêmGiờ { get; set; }

    public virtual ChucVu MãChứcVụNavigation { get; set; } = null!;
}
