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
    public class QlHoaDonCtService : IHoaDonCtService
    {
        private IHoaDonCtRepository _hoaDonCtRepository;
        private IHoaDonRepository _hoaDonRepository;
        private IChiTietSachRepository _chiTietSachRepository;
        private IGiamGiaRepository _igiamGiaRepository;
        public QlHoaDonCtService()
        {
            _hoaDonCtRepository = new HoaDonCtRepository();
            _hoaDonRepository = new HoaDonRepository();
            _chiTietSachRepository = new ChiTietSPRepository();
            _igiamGiaRepository = new GiamGiaRepository();
        }
        public string Add(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "Thêm không thành công ";
            }
            var temp = new HoaDonChiTiet()
            {
                IdHoaDonChiTiet = hoaDonCtView.IdHoaDonChiTiet,
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                IdHoaDon = hoaDonCtView.IdHoaDon,
                IdChiTietSach = hoaDonCtView.IdChiTietSach,
                IdGiamGia = hoaDonCtView.IdGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                GiaCuoi = hoaDonCtView.GiaCuoi,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.AddHoaDonCt(temp))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "Xóa không thành công";
            }
            var temp = new HoaDonChiTiet()
            {
                IdHoaDonChiTiet = hoaDonCtView.IdHoaDonChiTiet,
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                IdHoaDon = hoaDonCtView.IdHoaDon,
                IdChiTietSach = hoaDonCtView.IdChiTietSach,
                IdGiamGia = hoaDonCtView.IdGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                GiaCuoi = hoaDonCtView.GiaCuoi,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.DeleteHoaDonCt(temp))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<HoaDonCtView> GetAll()
        {
            List<HoaDonCtView> temp = new List<HoaDonCtView>();
            temp = (from a in _hoaDonCtRepository.GetAllHoaDonCt()
                    join b in _hoaDonRepository.GetAllHoaDon() on a.IdHoaDon equals b.IdHoaDon
                    join c in _chiTietSachRepository.GetAllChiTietSach() on a.IdChiTietSach equals c.IdChiTietSach
                    join d in _igiamGiaRepository.GetAllGiamGia() on a.IdGiamGia equals d.IdGiamGia
                    select new HoaDonCtView
                    {
                        IdHoaDonChiTiet = a.IdHoaDonChiTiet,
                        MaHoaDonChiTiet = a.MaHoaDonChiTiet,
                        IdHoaDon = b.IdHoaDon,
                        IdChiTietSach = c.IdChiTietSach,
                        IdGiamGia = d.IdGiamGia,
                        GiaGoc = a.GiaGoc,
                        GiaCuoi = a.GiaCuoi,
                        TrangThai = a.TrangThai,
                    }).ToList();
            return temp;
        }

        public string Update(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "Sửa không thành công";
            }
            var temp = new HoaDonChiTiet()
            {
                IdHoaDonChiTiet = hoaDonCtView.IdHoaDonChiTiet,
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                IdHoaDon = hoaDonCtView.IdHoaDon,
                IdChiTietSach = hoaDonCtView.IdChiTietSach,
                IdGiamGia = hoaDonCtView.IdGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                GiaCuoi = hoaDonCtView.GiaCuoi,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.UpdateHoaDonCt(temp))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
