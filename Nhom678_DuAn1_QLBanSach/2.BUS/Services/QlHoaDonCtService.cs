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
        private ISanPhamRepository _sanPhamRepository;
        IGiamGiaRepository _igiamGiaRepository;
        public QlHoaDonCtService()
        {
            _hoaDonCtRepository = new HoaDonCtRepository();
            _hoaDonRepository = new HoaDonRepository();
            _sanPhamRepository = new SanPhamRepository();
            _igiamGiaRepository = new GiamGiaRepository();
        }
        public string Add(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "Them khong thanh cong";
            }
            var temp = new HoaDonChiTiet()
            {
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                MaHoaDon = hoaDonCtView.MaHoaDon,
                //MaSach = hoaDonCtView.MaSach,
                MaGiamGia = hoaDonCtView.MaGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                //GiaBan = hoaDonCtView.GiaBan,
                //SoLuong = hoaDonCtView.SoLuong,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.AddHoaDonCt(temp))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "xoa khong thanh cong";
            }
            var temp = new HoaDonChiTiet()
            {
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                MaHoaDon = hoaDonCtView.MaHoaDon,
                //MaSach = hoaDonCtView.MaSach,
                MaGiamGia = hoaDonCtView.MaGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                //GiaBan = hoaDonCtView.GiaBan,
                //SoLuong = hoaDonCtView.SoLuong,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.DeleteHoaDonCt(temp))
                return "xoa thanh cong";
            return "xoa khong thanh cong";
        }

        public List<HoaDonCtView> GetAll()
        {
            List<HoaDonCtView> temp = new List<HoaDonCtView>();
            temp = (from a in _hoaDonCtRepository.GetAllHoaDonCt()
                    join b in _hoaDonRepository.GetAllHoaDon() on a.MaHoaDon equals b.MaHoaDon
                    //join c in _sanPhamRepository.GetAllSach() on a.MaSach equals c.MaSach
                    join d in _igiamGiaRepository.GetAllGiamGia() on a.MaGiamGia equals d.MaGg
                    select new HoaDonCtView
                    {
                        MaHoaDonChiTiet = a.MaHoaDonChiTiet,
                        MaHoaDon = b.MaHoaDon,
                        //MaSach = c.MaSach,
                        MaGiamGia = d.MaGg,
                        GiaGoc = a.GiaGoc,
                        //GiaBan = a.GiaBan,
                        //SoLuong = a.SoLuong,
                        TrangThai = a.TrangThai,
                    }).ToList();
            return temp;
        }

        public string Update(HoaDonCtView hoaDonCtView)
        {
            if (hoaDonCtView == null)
            {
                return "sua khong thanh cong";
            }
            var temp = new HoaDonChiTiet()
            {
                MaHoaDonChiTiet = hoaDonCtView.MaHoaDonChiTiet,
                MaHoaDon = hoaDonCtView.MaHoaDon,
                //MaSach = hoaDonCtView.MaSach,
                MaGiamGia = hoaDonCtView.MaGiamGia,
                GiaGoc = hoaDonCtView.GiaGoc,
                //GiaBan = hoaDonCtView.GiaBan,
                //SoLuong = hoaDonCtView.SoLuong,
                TrangThai = hoaDonCtView.TrangThai,
            };
            if (_hoaDonCtRepository.UpdateHoaDonCt(temp))
                return "sua thanh cong";
            return "sua khong thanh cong";
        }
    }
}
