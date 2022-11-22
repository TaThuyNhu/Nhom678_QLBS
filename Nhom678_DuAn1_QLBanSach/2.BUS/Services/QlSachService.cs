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
    public class QlSachService : ISachService
    {
        private ISanPhamRepository _iPhamRepository;

        public QlSachService()
        {
            _iPhamRepository = new SanPhamRepository();
        }

        public string Add(SachView sachView)
        {
            if (sachView == null) return "Thêm không thành công ";
            var obj = new Sach()
            {
                IdSach = sachView.IdSach,
                MaSach = sachView.MaSach,
                TenSach = sachView.TenSach,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                AnBan = sachView.AnBan,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
            };
            if (_iPhamRepository.AddSach(obj))
                return "Thêm thành công ";
            return "TThêm không thành công ";
        }

        public string Delete(SachView sachView)
        {
            if (sachView == null) return "Xóa không thành công";
            var obj = new Sach()
            {
                IdSach = sachView.IdSach,
                MaSach = sachView.MaSach,
                TenSach = sachView.TenSach,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                AnBan = sachView.AnBan,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
            };
        if (_iPhamRepository.DeleteSach(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<SachView> GetAll()
        {
            List<SachView> list = new List<SachView>();
            list = (from n in _iPhamRepository.GetAllSach()
                    select new SachView
                    {
                        IdSach = n.IdSach,
                        MaSach = n.MaSach,
                        TenSach= n.TenSach,
                        NgayXuatBan = n.NgayXuatBan,
                        SoTrang = n.SoTrang,
                        SoLuong = n.SoLuong,
                        AnBan = n.AnBan,
                        MoTa = n.MoTa,
                        NgayNhap = n.NgayNhap,
                        NgayXuat = n.NgayXuat,
                    }).ToList();
            return list;
        }


        public string Update(SachView sachView)
        {
            if (sachView == null) return "Sửa không thành công";
            var obj = new Sach()
            {
                IdSach = sachView.IdSach,
                MaSach = sachView.MaSach,
                TenSach = sachView.TenSach,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                AnBan = sachView.AnBan,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
            };
            if (_iPhamRepository.UpdateSach(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }

    }
}
