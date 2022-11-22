using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QlChucVuService : IChucVuService
    {
        private IChucVuRepository _iChucVuRepository;
        public QlChucVuService()
        {
            _iChucVuRepository = new ChucVuRepository();
        }
        public string Add(ChucVuView cvView)
        {
            if (cvView == null) return "Them khong thanh cong";
            var obj = new ChucVu()
            {
                IdChucVu = cvView.IdChucVu,
                MaChucVu = cvView.MaChucVu,
                TenChucVu = cvView.TenChucVu,
                TrangThai = cvView.TrangThai,
            };
            if (_iChucVuRepository.AddChucVu(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(ChucVuView cvView)
        {
            if (cvView == null) return "Xóa không thành công";
            var obj = new ChucVu()
            {
                IdChucVu = cvView.IdChucVu,
                MaChucVu = cvView.MaChucVu,
                TenChucVu = cvView.TenChucVu,
                TrangThai = cvView.TrangThai,
            };
            if (_iChucVuRepository.DeleteChucVu(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> list = new List<ChucVuView>();
            list = (from a in _iChucVuRepository.GetAllChucVu()
                    select new ChucVuView
                    {
                        IdChucVu=a.IdChucVu,
                        MaChucVu = a.MaChucVu,
                        TenChucVu = a.TenChucVu,
                        TrangThai=a.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(ChucVuView cvView)
        {
            if (cvView == null) return "Sửa không thành công";
            var obj = new ChucVu()
            {
                IdChucVu = cvView.IdChucVu,
                MaChucVu = cvView.MaChucVu,
                TenChucVu = cvView.TenChucVu,
                TrangThai = cvView.TrangThai,
            };
            if (_iChucVuRepository.UpdateChucVu(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
