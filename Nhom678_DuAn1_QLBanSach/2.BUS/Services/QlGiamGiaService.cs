using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QlGiamGiaService : IGiamGiaService
    {
        private IGiamGiaRepository _iGiamGiaRepository;

        public QlGiamGiaService()
        {
            _iGiamGiaRepository = new GiamGiaRepository();
        }

        public string Add(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Thêm không thành công ";
            var obj = new GiamGium()
            {
                IdGiamGia = giamGiaView.IdGiamGia,
                MaGiamGia = giamGiaView.MaGiamGia,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.AddGiamGia(obj))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Xóa không thành công";
            var obj = new GiamGium()
            {
                IdGiamGia = giamGiaView.IdGiamGia,
                MaGiamGia = giamGiaView.MaGiamGia,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.DeleteGiamGia(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<GiamGiaView> GetAll()
        {
            List<GiamGiaView> list = new List<GiamGiaView>();
            list = (from a in _iGiamGiaRepository.GetAllGiamGia()
                    select new GiamGiaView
                    {
                        IdGiamGia = a.IdGiamGia,
                        MaGiamGia = a.MaGiamGia,
                        DoiTuongGg = a.DoiTuongGg,
                        ThoiHan = a.ThoiHan,
                        PhanTram = a.PhanTram,
                    }).ToList();
            return list;
        }

        public string Update(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Sửa không thành công";
            var obj = new GiamGium()
            {
                IdGiamGia = giamGiaView.IdGiamGia,
                MaGiamGia = giamGiaView.MaGiamGia,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.UpdateGiamGia(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}