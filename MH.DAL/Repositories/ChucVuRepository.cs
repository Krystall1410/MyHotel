using MH.DAL.Models;
using MH.Domain.entities;

namespace MH.DAL.Repositories
{
    public class ChucVuRepository
    {
        private readonly MyHotelContext _context = new MyHotelContext();

        // Lấydanh sách
        public List<ChucVu> GetAllChucVu()
        {
            return _context.ChucVus.ToList();
        }

        //Dùng để kiểm tra trùng mã 
        public ChucVu GetChucVuById(string maChucVu)
        {
            return _context.ChucVus.FirstOrDefault(c => c.MaChucVu == maChucVu);
        }

        // Thêm mới chức vụ
        public bool AddChucVu(ChucVu cv)
        {
            try
            {
                _context.ChucVus.Add(cv);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Cập nhật tên chức vụ
        public bool UpdateChucVu(ChucVu cv)
        {
            try
            {
                var existCv = _context.ChucVus.FirstOrDefault(c => c.MaChucVu == cv.MaChucVu);
                if (existCv != null)
                {
                    // cập nhật các trường được phép 
                    existCv.TenChucVu = cv.TenChucVu;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Xóa chức vụ
        public bool DeleteChucVu(string maChucVu)
        {
            try
            {
                var existCv = _context.ChucVus.FirstOrDefault(c => c.MaChucVu == maChucVu);
                if (existCv != null)
                {
                    _context.ChucVus.Remove(existCv);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Tìm kiếm chức vụ theo Tên
        public List<ChucVu> SearchChucVu(string keyword)
        {
            return _context.ChucVus
                           .Where(c => c.TenChucVu.Contains(keyword) || c.MaChucVu.Contains(keyword))
                           .ToList();
        }
    }
}