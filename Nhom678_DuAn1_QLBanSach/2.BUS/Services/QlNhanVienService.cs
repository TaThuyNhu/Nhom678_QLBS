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
    public class QlNhanVienService : INhanVienService
    {
        private INhanVienRepository _iNvRepository;
        private ICuaHangRepository _cuaHangRepository;
        private IChucVuRepository _chucVuRepository;
        public QlNhanVienService()
        {
            _iNvRepository = new NhanVienRepository();
            _cuaHangRepository = new CuaHangRepository();
            _chucVuRepository = new ChucVuRepository();
        }
        public string Add(NhanVienView nvv)
        {
            if (nvv == null)
            {
                return "Thêm không thành công ";
            }
            var temp = new NhanVien()
            {
                IdNhanVien = nvv.IdNhanVien,
                MaNhanVien = nvv.MaNhanVien,
                IdChucVu = nvv.IdChucVu,
                IdCuaHang = nvv.IdCuaHang,
                HoTen = nvv.HoTen,
                Tuoi = nvv.Tuoi,
                QueQuan = nvv.QueQuan,
                GioiTinh = nvv.GioiTinh,
                SoDienThoai = nvv.SoDienThoai,
                Email = nvv.Email,
                TrangThai = nvv.TrangThai,
            };
            if (_iNvRepository.AddNhanVien(temp))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(NhanVienView nvv)
        {
            if (nvv == null) return "Xóa không thành công";

            var temp = new NhanVien()
            {
                IdNhanVien = nvv.IdNhanVien,
                MaNhanVien = nvv.MaNhanVien,
                IdChucVu = nvv.IdChucVu,
                IdCuaHang = nvv.IdCuaHang,
                HoTen = nvv.HoTen,
                Tuoi = nvv.Tuoi,
                QueQuan = nvv.QueQuan,
                GioiTinh = nvv.GioiTinh,
                SoDienThoai = nvv.SoDienThoai,
                Email = nvv.Email,
                TrangThai = nvv.TrangThai,
            };
            if (_iNvRepository.DeleteNhanVien(temp))
            {
                GetAll();
                return "Xóa thành công";
            };
            return "Xóa không thành công";
        }

        public List<NhanVienView> GetAll()
        {
            List<NhanVienView> nvView = new List<NhanVienView>();
            nvView = (from a in _iNvRepository.GetAllNhanVien()
                      join b in _cuaHangRepository.GetAllCuaHang() on a.IdCuaHang equals b.IdCuaHang
                      join c in _chucVuRepository.GetAllChucVu() on a.IdChucVu equals c.IdChucVu
                      select new NhanVienView
                      {
                          IdNhanVien = a.IdNhanVien,
                          MaNhanVien = a.MaNhanVien,
                          IdCuaHang = b.IdCuaHang,
                          IdChucVu = c.IdChucVu,
                          HoTen = a.HoTen,
                          Tuoi = a.Tuoi,
                          QueQuan = a.QueQuan,
                          GioiTinh = a.GioiTinh,
                          SoDienThoai = a.SoDienThoai,
                          Email = a.Email,
                          TrangThai = a.TrangThai,
                      }).ToList();
            return nvView;
        }

        public string Update(NhanVienView nvv)
        {
            if (nvv == null) return "Sửa không thành công";
            var temp = new NhanVien()
            {
                IdNhanVien = nvv.IdNhanVien,
                MaNhanVien = nvv.MaNhanVien,
                IdChucVu = nvv.IdChucVu,
                IdCuaHang = nvv.IdCuaHang,
                HoTen = nvv.HoTen,
                Tuoi = nvv.Tuoi,
                QueQuan = nvv.QueQuan,
                GioiTinh = nvv.GioiTinh,
                SoDienThoai = nvv.SoDienThoai,
                Email = nvv.Email,
                TrangThai = nvv.TrangThai,
            };
            if (_iNvRepository.UpdateNhanVien(temp))
            {
                GetAll();
                return "Sửa thành công";
            };
            return "Sửa không thành công";
        }
    }
}
