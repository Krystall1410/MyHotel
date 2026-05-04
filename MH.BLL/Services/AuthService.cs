using MH.DAL.Repositories;
using MH.Domain.entities;
using System;

namespace MH.BLL.Services
{
    public class AuthService
    {
        private readonly TaiKhoanRepository _repo = new TaiKhoanRepository();
        public string Register(string user, string pass, string confirm)
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
                MatKhau = pass,
                MaChucVu = "NV" 
            };

            return _repo.AddAccount(newAcc) ? "Thành công" : "Lỗi hệ thống!";
        }
        public TaiKhoan Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            var account = _repo.GetAccount(username, password);
            return account;
        }
    }
}