using MH.DAL;
using MH.Domain.entities;

namespace MH.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();

        public string DangNhap(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!";
            }

            TaiKhoan tk = _taiKhoanDAL.KiemTraDangNhap(username, password);

            if (tk != null)
            {
                return "OK";
            }
            else
            {
                return "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }
    }
}