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
    public class QlKhachHangService : IKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepository;
        public QlKhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHangView kh)
        {
            if (kh == null) return "Thêm không thành công ";
            var obj = new KhachHang()
            {
                IdKhachHang = kh.IdKhachHang,
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                Sdt = kh.Sdt,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.AddKhachHang(obj))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(KhachHangView kh)
        {
            if (kh == null) return "Xóa không thành công";
            var obj = new KhachHang()
            {
                IdKhachHang = kh.IdKhachHang,
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                Sdt = kh.Sdt,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.DeleteKhachHang(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> list = new List<KhachHangView>();
            list = (from a in _iKhachHangRepository.GetAllKhachHang()
                    select new KhachHangView
                    {
                        MaKhachHang = a.MaKhachHang,
                        HoTen = a.HoTen,
                        GioiTinh = a.GioiTinh,
                        Tuoi = a.Tuoi,
                        Sdt = a.Sdt,
                        Email = a.Email,
                        DiaChi = a.DiaChi,
                        TrangThai = a.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(KhachHangView kh)
        {
            if (kh == null) return "Sửa không thành công";
            var obj = new KhachHang()
            {
                IdKhachHang = kh.IdKhachHang,
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                Sdt = kh.Sdt,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.UpdateKhachHang(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
