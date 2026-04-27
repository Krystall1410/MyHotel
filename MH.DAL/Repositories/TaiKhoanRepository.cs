using MH.DAL.Models; // Theo cấu trúc folder Contexts của bạn
using MH.Domain.entities;

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
    }
}