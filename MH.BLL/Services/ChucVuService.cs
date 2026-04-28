using MH.DAL.Repositories;
using MH.Domain.entities;

namespace MH.BLL.Services
{
    public class ChucVuService
    {
        private readonly ChucVuRepository _chucVuRepository;

        public ChucVuService()
        {
            _chucVuRepository = new ChucVuRepository();
        }

        //  lấy danh sách
        public List<ChucVu> GetAllChucVu()
        {
            return _chucVuRepository.GetAllChucVu();
        }

        //  theo mã
        public ChucVu GetChucVuById(string maChucVu)
        {
            if (string.IsNullOrWhiteSpace(maChucVu))
            {
                return null;
            }
            return _chucVuRepository.GetChucVuById(maChucVu);
        }

        // Thêm mới 
        public bool AddChucVu(ChucVu cv)
        {
            if (cv == null || string.IsNullOrWhiteSpace(cv.MaChucVu) || string.IsNullOrWhiteSpace(cv.TenChucVu))
            {
                return false;
            }
            var existingCv = _chucVuRepository.GetChucVuById(cv.MaChucVu);
            if (existingCv != null)
            {
                return false;
            }

            return _chucVuRepository.AddChucVu(cv);
        }

        // Cập nhật
        public bool UpdateChucVu(ChucVu cv)
        {
            if (cv == null || string.IsNullOrWhiteSpace(cv.MaChucVu) || string.IsNullOrWhiteSpace(cv.TenChucVu))
            {
                return false;
            }

            return _chucVuRepository.UpdateChucVu(cv);
        }

        // Xóa 
        public bool DeleteChucVu(string maChucVu)
        {
            if (string.IsNullOrWhiteSpace(maChucVu))
            {
                return false;
            }

            return _chucVuRepository.DeleteChucVu(maChucVu);
        }

        // Tìm kiếm 
        public List<ChucVu> SearchChucVu(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllChucVu();
            }

            return _chucVuRepository.SearchChucVu(keyword);
        }
    }
}