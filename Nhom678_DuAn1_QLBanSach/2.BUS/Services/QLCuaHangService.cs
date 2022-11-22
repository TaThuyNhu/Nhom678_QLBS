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
    public class QLCuaHangService : ICuaHangService
    {
        private ICuaHangRepository _iCuaHangRepository;
        public QLCuaHangService()
        {
            _iCuaHangRepository = new CuaHangRepository();
        }
        public string Add(CuaHangView cuaHangView)
        {
            if (cuaHangView == null) return "Thêm không thành công ";
            var obj = new CuaHang()
            {
                IdCuaHang = cuaHangView.IdCuaHang,
                MaCuaHang = cuaHangView.MaCuaHang,
                TenCuaHang = cuaHangView.TenCuaHang,
                DiaChi = cuaHangView.DiaChi,
                //TrangThai = cuaHangView.TrangThai,
            };
            if (_iCuaHangRepository.AddCuaHang(obj))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(CuaHangView cuaHangView)
        {
            if (cuaHangView == null) return "Xóa không thành công";
            var obj = new CuaHang()
            {
                IdCuaHang = cuaHangView.IdCuaHang,
                MaCuaHang = cuaHangView.MaCuaHang,
                TenCuaHang = cuaHangView.TenCuaHang,
                DiaChi = cuaHangView.DiaChi,
                //TrangThai = cuaHangView.TrangThai,
            };
            if (_iCuaHangRepository.DeleteCuaHang(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<CuaHangView> GetAll()
        {
            List<CuaHangView> list = new List<CuaHangView>();
            list = (from n in _iCuaHangRepository.GetAllCuaHang()
                    select new CuaHangView
                    {
                        IdCuaHang = n.IdCuaHang,
                        MaCuaHang = n.MaCuaHang,
                        TenCuaHang = n.TenCuaHang,
                        DiaChi = n.DiaChi,
                        //TrangThai = n.TrangThai,
                    }).ToList();
            return list;
        }

        public Guid GetIdCuaHangFromTen(string ten)
        {
            throw new NotImplementedException();
        }

        public string Update(CuaHangView cuaHangView)
        {
            if (cuaHangView == null) return "Sửa không thành công";
            var obj = new CuaHang()
            {
                IdCuaHang = cuaHangView.IdCuaHang,
                MaCuaHang = cuaHangView.MaCuaHang,
                TenCuaHang = cuaHangView.TenCuaHang,
                DiaChi = cuaHangView.DiaChi,
                //TrangThai = cuaHangView.TrangThai,
            };
            if (_iCuaHangRepository.UpdateCuaHang(obj))
                return "Sửa  thành công";
            return "Sửa không thành côngg";
        }
    }
}
