using MH.DAL.Models;
using MH.Domain.entities;

namespace MH.DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoan? KiemTraDangNhap(string username, string password)
        {
            using (var db = new MyHotelContext())
            {
                return db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == username && tk.MatKhau == password);
            }
        }
    }
}