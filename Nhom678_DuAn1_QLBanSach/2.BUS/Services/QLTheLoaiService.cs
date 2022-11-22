using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QLTheLoaiService : ITheLoaiService
    {
        private ITheLoaiRepository _iTtheLoaiRepository;

        public QLTheLoaiService()
        {
            _iTtheLoaiRepository = new TheLoaiRepository();
        }

        public string Add(TheLoaiView tlView)
        {
            if (tlView == null) return "Thêm không thành công ";
            var obj = new TheLoai()
            {
                IdTheLoai = tlView.IdTheLoai,
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.AddTheLoai(obj))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(TheLoaiView tlView)
        {
            if (tlView == null) return "Xóa không thành công";
            var obj = new TheLoai()
            {
                IdTheLoai = tlView.IdTheLoai,
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.DeleteTheLoai(obj))
                return "Xóa thành côngg";
            return "Xóa không thành công";
        }

        public List<TheLoaiView> GetAll()
        {
            List<TheLoaiView> list = new List<TheLoaiView>();
            list = (from a in _iTtheLoaiRepository.GetAllTheLoai()
                    select new TheLoaiView
                    {
                        IdTheLoai=a.IdTheLoai,
                        MaTheLoai = a.MaTheLoai,
                        MoTa = a.MoTa,
                    }).ToList();
            return list;
        }

        public string Update(TheLoaiView tlView)
        {
            if (tlView == null) return "Sửa không thành công";
            var obj = new TheLoai()
            {
                IdTheLoai = tlView.IdTheLoai,
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.UpdateTheLoai(obj))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}