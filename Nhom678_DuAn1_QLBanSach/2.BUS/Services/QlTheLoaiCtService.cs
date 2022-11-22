using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QlTheLoaiCtService : ITheLoaiCtService
    {
        private ITheLoaiCtRepository _iTheLoaiCtRepository;
        private ITheLoaiRepository _iTheLoaiRepository;

        public QlTheLoaiCtService()
        {
            _iTheLoaiCtRepository = new TheLoaiCtRepository();
            _iTheLoaiRepository = new TheLoaiRepository();
        }

        public string Add(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Thêm không thành công ";
            var obj = new TheLoaiChiTiet()
            {
                IdTheLoaiChiTiet = theLoaiCtView.IdTheLoaiChiTiet,
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                IdTheLoai = theLoaiCtView.IdTheLoai,
                TenTheLoai = theLoaiCtView.TenTheLoai,
                TrangThai = theLoaiCtView.TrangThai,
            };
            if (_iTheLoaiCtRepository.AddTheLoaiCt(obj))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Xóa không thành công";
            var obj = new TheLoaiChiTiet()
            {
                IdTheLoaiChiTiet = theLoaiCtView.IdTheLoaiChiTiet,
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                IdTheLoai = theLoaiCtView.IdTheLoai,
                TenTheLoai = theLoaiCtView.TenTheLoai,
                TrangThai = theLoaiCtView.TrangThai,
            };
            if (_iTheLoaiCtRepository.DeleteTheLoaiCt(obj))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<TheLoaiCtView> GetAll()
        {
            List<TheLoaiCtView> list = new List<TheLoaiCtView>();
            list = (from a in _iTheLoaiCtRepository.GetAllTheLoaiCt()
                    join b in _iTheLoaiRepository.GetAllTheLoai() on a.IdTheLoai equals b.IdTheLoai
                    select new TheLoaiCtView
                    {
                        IdTheLoaiChiTiet = a.IdTheLoaiChiTiet,
                        MaTheLoaiChiTiet = a.MaTheLoaiChiTiet,
                        IdTheLoai = b.IdTheLoai,
                        TenTheLoai = a.TenTheLoai,
                        TrangThai = a.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Sửa không thành công";
            var obj = new TheLoaiChiTiet()
            {
                IdTheLoaiChiTiet = theLoaiCtView.IdTheLoaiChiTiet,
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                IdTheLoai = theLoaiCtView.IdTheLoai,
                TenTheLoai = theLoaiCtView.TenTheLoai,
                TrangThai = theLoaiCtView.TrangThai,
            };
            if (_iTheLoaiCtRepository.UpdateTheLoaiCt(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}