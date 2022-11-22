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
        private IKhachHangRepository _khachHangRepository;
        public QLLoaiHinhGDService()
        {
            _loaiHinhGiaoDichRepository = new LoaiHinhGiaoDichRepository();
            _khachHangRepository = new KhachHangRepository();
        }
        public string Add(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "Thêm không thành công ";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                IdLoaiGiaoDich = LoaiHinhGiaoDich.IdLoaiGiaoDich,
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                IdKhachHang = LoaiHinhGiaoDich.IdKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2,
                LoaiHinh3 = LoaiHinhGiaoDich.LoaiHinh3
            };
            if (_loaiHinhGiaoDichRepository.AddLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "TThêm thành công g";
            return "TThêm không thành công ";
        }

        public string Delete(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "Xóa không thành công";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                IdLoaiGiaoDich = LoaiHinhGiaoDich.IdLoaiGiaoDich,
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                IdKhachHang = LoaiHinhGiaoDich.IdKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2,
                LoaiHinh3 = LoaiHinhGiaoDich.LoaiHinh3
            };
            if (_loaiHinhGiaoDichRepository.AddLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<LoaiHinhGiaoDichView> GetAll()
        {
            List<LoaiHinhGiaoDichView> list = new List<LoaiHinhGiaoDichView>();
            list = (from n in _loaiHinhGiaoDichRepository.GetAllLoaiHinhGiaoDich()
                    join a in _khachHangRepository.GetAllKhachHang() on n.IdKhachHang equals a.IdKhachHang
                    select new LoaiHinhGiaoDichView
                    {
                       IdLoaiGiaoDich = n.IdLoaiGiaoDich,
                       MaLoaiGiaoDich = n.MaLoaiGiaoDich,
                       IdKhachHang = a.IdKhachHang,
                       LoaiHinh1 = n.LoaiHinh1,
                       LoaiHinh2 = n.LoaiHinh2,
                       LoaiHinh3 = n.LoaiHinh3,
                    }).ToList();
            return list;
        }

        public string Update(LoaiHinhGiaoDichView LoaiHinhGiaoDich)
        {
            if (LoaiHinhGiaoDich == null) return "Sửa không thành công";
            var LoaiHinhGiaoDichhang = new LoaiHinhGiaoDich()
            {
                IdLoaiGiaoDich = LoaiHinhGiaoDich.IdLoaiGiaoDich,
                MaLoaiGiaoDich = LoaiHinhGiaoDich.MaLoaiGiaoDich,
                IdKhachHang = LoaiHinhGiaoDich.IdKhachHang,
                LoaiHinh1 = LoaiHinhGiaoDich.LoaiHinh1,
                LoaiHinh2 = LoaiHinhGiaoDich.LoaiHinh2,
                LoaiHinh3 = LoaiHinhGiaoDich.LoaiHinh3
            };
            if (_loaiHinhGiaoDichRepository.UpdateLoaiHinhGiaoDich(LoaiHinhGiaoDichhang))
                return "sua thanh cong";
            return "Sửa không thành công";
        }
    }
}
