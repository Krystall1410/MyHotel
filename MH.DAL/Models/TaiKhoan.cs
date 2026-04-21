using System;
using System.Collections.Generic;

namespace MH.DAL.Models;

public partial class TaiKhoan
{
    public string TênĐăngNhập { get; set; } = null!;

    public string MậtKhẩu { get; set; } = null!;

    public string? MãChứcVụ { get; set; }

    public virtual ChucVu? MãChứcVụNavigation { get; set; }
}
