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
        private ITheLoaiCtRepository _iLoaiCtRepository;

        public QlSachService()
        {
            _iPhamRepository = new SanPhamRepository();
            _iLoaiCtRepository = new TheLoaiCtRepository();
        }

        public string Add(SachView sachView)
        {
            if (sachView == null) return "Them khong thanh cong";
            var obj = new Sach()
            {
                MaSach = sachView.MaSach,
                MaTheLoaiChiTiet = sachView.MaTheLoaiChiTiet,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                TacGia = sachView.TacGia,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
                SoLuongConLai = sachView.SoLuongConLai,
                TrangThai = sachView.TrangThai,

            };
            if (_iPhamRepository.AddSach(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(SachView sachView)
        {
            if (sachView == null) return "Xoa khong thanh cong";
            var obj = new Sach()
            {
                MaSach = sachView.MaSach,
                MaTheLoaiChiTiet = sachView.MaTheLoaiChiTiet,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                TacGia = sachView.TacGia,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
                SoLuongConLai = sachView.SoLuongConLai,
                TrangThai = sachView.TrangThai,
            };
            if (_iPhamRepository.DeleteSach(obj))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<SachView> GetAll()
        {
            List<SachView> list = new List<SachView>();
            list = (from n in _iPhamRepository.GetAllSach()
                    join a in _iLoaiCtRepository.GetAllTheLoaiCt() on n.MaTheLoaiChiTiet equals a.MaTheLoaiChiTiet
                    select new SachView
                    {
                        MaSach = n.MaSach,
                        MaTheLoaiChiTiet = a.MaTheLoaiChiTiet,
                        NgayXuatBan = n.NgayXuatBan,
                        SoTrang = n.SoTrang,
                        SoLuong = n.SoLuong,
                        TacGia = n.TacGia,
                        MoTa = n.MoTa,
                        NgayNhap = n.NgayNhap,
                        NgayXuat = n.NgayXuat,
                        SoLuongConLai = n.SoLuongConLai,
                        TrangThai = n.TrangThai,
                    }).ToList();
            return list;
        }

       
        public string Update(SachView sachView)
        {
            if (sachView == null) return "Sua khong thanh cong";
            var obj = new Sach()
            {
                MaSach = sachView.MaSach,
                MaTheLoaiChiTiet = sachView.MaTheLoaiChiTiet,
                NgayXuatBan = sachView.NgayXuatBan,
                SoTrang = sachView.SoTrang,
                SoLuong = sachView.SoLuong,
                TacGia = sachView.TacGia,
                MoTa = sachView.MoTa,
                NgayNhap = sachView.NgayNhap,
                NgayXuat = sachView.NgayXuat,
                SoLuongConLai = sachView.SoLuongConLai,
                TrangThai = sachView.TrangThai,
            };
            if (_iPhamRepository.UpdateSach(obj))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }

    }
}
