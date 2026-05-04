using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.Domain.entities
{
    public static class Session
    {
        // Lưu vai trò của người dùng (ví dụ: "admin", "staff", "manager")
        public static string CurrentRole { get; set; }

        // Có thể lưu thêm tên người dùng để hiển thị trên giao diện
        public static string UserName { get; set; }

        // Hàm để xóa dữ liệu khi đăng xuất
        public static void Clear()
        {
            CurrentRole = null;
            UserName = null;
        }
    }
}
