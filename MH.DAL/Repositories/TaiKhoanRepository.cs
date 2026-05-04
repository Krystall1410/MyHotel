using MH.DAL.Models;
using MH.Domain.entities;
using System.Linq; // Đảm bảo có thư viện này để dùng FirstOrDefault

namespace MH.DAL.Repositories
{
    public class TaiKhoanRepository
    {
        private readonly MyHotelContext _context = new MyHotelContext();

        public bool IsUsernameExists(string username)
        {
            return _context.TaiKhoans.Any(x => x.TenDangNhap == username);
        }

        public bool AddAccount(TaiKhoan account)
        {
            try
            {
                _context.TaiKhoans.Add(account);
                _context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Authenticate(string username, string password)
        {
            var account = _context.TaiKhoans
                .FirstOrDefault(tk => tk.TenDangNhap == username && tk.MatKhau == password);

            return account != null;
        }

        // --- THÊM HÀM NÀY ĐỂ PHÂN QUYỀN ---
        public TaiKhoan GetAccount(string username, string password)
        {
            // Tìm và trả về đối tượng tài khoản khớp với user/pass
            // Nếu không tìm thấy, nó sẽ trả về null
            return _context.TaiKhoans
                .FirstOrDefault(tk => tk.TenDangNhap == username && tk.MatKhau == password);
        }
    }
}