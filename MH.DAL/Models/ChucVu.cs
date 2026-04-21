using System;
using System.Collections.Generic;

namespace MH.DAL.Models;

public partial class ChucVu
{
    public string MãChứcVụ { get; set; } = null!;

    public string TênChứcVụ { get; set; } = null!;

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
