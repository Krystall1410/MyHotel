using MH.DAL.Repositories;
using MH.Domain.entities;

namespace MH.BLL.Services
{
    public class AuthService
    {
        private readonly TaiKhoanRepository _repo = new TaiKhoanRepository();

        public string Register(string user, string pass, string confirm, string role)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (pass != confirm)
                return "Mật khẩu xác nhận không khớp!";

            if (_repo.IsUsernameExists(user))
                return "Tên đăng nhập đã tồn tại!";

            var newAcc = new TaiKhoan
            {
                TenDangNhap = user,
                MatKhau = pass, // Gợi ý: Nên mã hóa mật khẩu ở đây
                MaChucVu = role
            };

            return _repo.AddAccount(newAcc) ? "Thành công" : "Lỗi hệ thống!";
        }
        public string Login(string username, string password)
        {
            // Quy tắc: BLL kiểm tra tính hợp lệ trước
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!";
            }

            // Gọi DAL để xác thực
            bool isAuthenticated = _repo.Authenticate(username, password);

            return isAuthenticated ? "Thành công" : "Tên đăng nhập hoặc mật khẩu không chính xác!";
        }
    }
}