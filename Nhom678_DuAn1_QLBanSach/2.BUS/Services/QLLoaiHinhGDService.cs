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
    public class QLLoaiHinhGDService
    {
        private ILoaiHinhGiaoDichRepository _loaiHinhGiaoDichRepository;
        public QLLoaiHinhGDService()
        {
            _loaiHinhGiaoDichRepository = new LoaiHinhGiaoDichRepository();
        }
        public string Add(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "Them LoaiHinhGiaoDichng thanh cong";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                MaKhachHang = LoaiHinhGiaoDich.MaKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2
            };
            if (_loaiHinhGiaoDichRepository.AddLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "Them thanh cong";
            return "Them LoaiHinhGiaoDichng thanh cong";
        }

        public string Delete(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "xoa LoaiHinhGiaoDichng thanh cong";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                MaKhachHang = LoaiHinhGiaoDich.MaKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2
            };
            if (_loaiHinhGiaoDichRepository.AddLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "xoa thanh cong";
            return "xoa LoaiHinhGiaoDichng thanh cong";
        }

        public List<LoaiHinhGiaoDichView> GetAll()
        {
            List<LoaiHinhGiaoDichView> list = new List<LoaiHinhGiaoDichView>();
            list = (from n in _loaiHinhGiaoDichRepository.GetAllLoaiHinhGiaoDich()
                    select new LoaiHinhGiaoDichView
                    {
                       MaLoaiGiaoDich = n.MaLoaiGiaoDich,
                       MaKhachHang = n.MaKhachHang,
                       LoaiHinh1 = n.LoaiHinh1,
                       LoaiHinh2 = n.LoaiHinh2
                    }).ToList();
            return list;
        }

        public string Update(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "sua LoaiHinhGiaoDichng thanh cong";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                MaKhachHang = LoaiHinhGiaoDich.MaKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2
            };
            if (_loaiHinhGiaoDichRepository.UpdateLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "sua thanh cong";
            return "sua LoaiHinhGiaoDichng thanh cong";
        }
    }
}
