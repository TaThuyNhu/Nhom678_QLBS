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
    public class QLKhoService : IKhoService
    {
        private IKhoRepository _khoRepository;
        public QLKhoService()
        {
            _khoRepository = new KhoRepository();
        }
        public string Add(KhoView kho)
        {
            if (kho == null) return "Them khong thanh cong";
            var khohang = new Kho()
            {
                MaKho = kho.MaKho,
                SoLuong = kho.SoLuong,
                NgayNhap = kho.NgayNhap,
                NgayXuat = kho.NgayXuat,
                SoLuongConLai = kho.SoLuongConLai,
            };
            if (_khoRepository.AddKho(khohang))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(KhoView kho)
        {
            if (kho == null) return "xoa khong thanh cong";
            var khohang = new Kho()
            {
                MaKho = kho.MaKho,
                SoLuong = kho.SoLuong,
                NgayNhap = kho.NgayNhap,
                NgayXuat = kho.NgayXuat,
                SoLuongConLai = kho.SoLuongConLai,
            };
            if (_khoRepository.AddKho(khohang))
                return "xoa thanh cong";
            return "xoa khong thanh cong";
        }

        public List<KhoView> GetAll()
        {
            List<KhoView> list = new List<KhoView>();
            list = (from n in _khoRepository.GetAllKho()
                    select new KhoView
                    {
                        MaKho = n.MaKho,
                        SoLuong = n.SoLuong,
                        NgayXuat = n.NgayXuat,
                        NgayNhap = n.NgayNhap,
                        SoLuongConLai = n.SoLuongConLai,
                        //TrangThai = n.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(KhoView kho)
        {
            if (kho == null) return "sua khong thanh cong";
            var khohang = new Kho()
            {
                MaKho = kho.MaKho,
                SoLuong = kho.SoLuong,
                NgayNhap = kho.NgayNhap,
                NgayXuat = kho.NgayXuat,
                SoLuongConLai = kho.SoLuongConLai,
            };
            if (_khoRepository.UpdateKho(khohang))
                return "sua thanh cong";
            return "sua khong thanh cong";
        }
    }
}
