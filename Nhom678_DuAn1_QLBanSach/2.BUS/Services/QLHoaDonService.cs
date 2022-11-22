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
    public class QLHoaDonService : IHoaDonService
    {
        private IHoaDonRepository HoaDonRepository;
        private ILoaiHinhGiaoDichRepository loaiHinhGiaoDichRepository;
        private INhanVienRepository nhanVienRepository;
        public QLHoaDonService()
        {
            HoaDonRepository = new HoaDonRepository();
            loaiHinhGiaoDichRepository = new LoaiHinhGiaoDichRepository();
            nhanVienRepository = new NhanVienRepository();
        }

        public string Add(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Thêm không thành công ";
            }
            var temp = new HoaDon()
            {
                IdHoaDon = hoaDonView.IdHoaDon,
                MaHoaDon = hoaDonView.MaHoaDon,
                IdLoaiGiaoDich = hoaDonView.IdLoaiGiaoDich,
                IdNhanVien = hoaDonView.IdNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }
        public string Delete(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Xóa không thành công";
            }
            var temp = new HoaDon()
            {
                IdHoaDon = hoaDonView.IdHoaDon,
                MaHoaDon = hoaDonView.MaHoaDon,
                IdLoaiGiaoDich = hoaDonView.IdLoaiGiaoDich,
                IdNhanVien = hoaDonView.IdNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> list = new List<HoaDonView>();
            list = (from n in HoaDonRepository.GetAllHoaDon()
                    join b in loaiHinhGiaoDichRepository.GetAllLoaiHinhGiaoDich() on n.IdLoaiGiaoDich equals b.IdLoaiGiaoDich
                    join c in nhanVienRepository.GetAllNhanVien() on n.IdNhanVien equals c.IdNhanVien
                    select new HoaDonView
                    {
                        IdHoaDon = n.IdHoaDon,
                        MaHoaDon = n.MaHoaDon,
                        IdNhanVien = c.IdNhanVien,
                        IdLoaiGiaoDich = b.IdLoaiGiaoDich,
                        NgayTaoDon = n.NgayTaoDon,
                        NgayNhan = n.NgayNhan,
                        NgayShip = n.NgayShip,
                        TrangThai = n.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Sửa không thành công";
            }
            var temp = new HoaDon()
            {
                IdHoaDon = hoaDonView.IdHoaDon,
                MaHoaDon = hoaDonView.MaHoaDon,
                IdLoaiGiaoDich = hoaDonView.IdLoaiGiaoDich,
                IdNhanVien = hoaDonView.IdNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Sửa thành công";
            return "Sửa không thành công";
        }


    }
}
