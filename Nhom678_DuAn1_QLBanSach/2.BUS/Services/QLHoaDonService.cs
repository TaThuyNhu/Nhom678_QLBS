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
        private IKhachHangRepository khachHangRepository;
        private INhanVienRepository nhanVienRepository;
        public QLHoaDonService()
        {
            HoaDonRepository = new HoaDonRepository();
            khachHangRepository = new KhachHangRepository();
            nhanVienRepository = new NhanVienRepository();
        }

        public string Add(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Them khong thanh cong";
            }
            var temp = new HoaDon()
            {
                MaHoaDon = hoaDonView.MaHoaDon,
                //MaKhachHang = hoaDonView.MaKhachHang,
                MaNhanVien = hoaDonView.MaNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                //TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }
        public string Delete(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Xoa khong thanh cong";
            }
            var temp = new HoaDon()
            {
                MaHoaDon = hoaDonView.MaHoaDon,
                //MaKhachHang = hoaDonView.MaKhachHang,
                MaNhanVien = hoaDonView.MaNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                //TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> list = new List<HoaDonView>();
            list = (from n in HoaDonRepository.GetAllHoaDon()
                    //join b in khachHangRepository.GetAllKhachHang() on n.MaKhachHang equals b.MaKhachHang
                    join c in nhanVienRepository.GetAllNhanVien() on n.MaNhanVien equals c.MaNhanVien
                    select new HoaDonView
                    {
                        MaHoaDon = n.MaHoaDon,
                        //MaKhachHang = b.MaKhachHang,
                        MaNhanVien = c.MaNhanVien,
                        NgayTaoDon = n.NgayTaoDon,
                        NgayNhan = n.NgayNhan,
                        NgayShip = n.NgayShip,
                        //TrangThai = n.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(HoaDonView hoaDonView)
        {
            if (hoaDonView == null)
            {
                return "Sua khong thanh cong";
            }
            var temp = new HoaDon()
            {
                MaHoaDon = hoaDonView.MaHoaDon,
                //MaKhachHang = hoaDonView.MaKhachHang,
                MaNhanVien = hoaDonView.MaNhanVien,
                NgayTaoDon = hoaDonView.NgayTaoDon,
                NgayNhan = hoaDonView.NgayNhan,
                NgayShip = hoaDonView.NgayShip,
                //TrangThai = hoaDonView.TrangThai,
            };
            if (HoaDonRepository.AddHoaDon(temp))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }


    }
}
