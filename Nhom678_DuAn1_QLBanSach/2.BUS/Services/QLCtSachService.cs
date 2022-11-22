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
    public class QLCtSachService : ICtSachService
    {
        private ISanPhamRepository _iSachRepository;
        private ITacGiaRepository _iTacGiaRepository;
        private IChiTietSachRepository _iChiTietSachRepository ;
        private INhaXuatBanRepository _iNhaXuatBanRepository ;
        private ITheLoaiCtRepository _iTheLoaiCtRepository ;
        public QLCtSachService()
        {
            _iSachRepository = new SanPhamRepository();
            _iTacGiaRepository = new TacGiaRepository();
            _iChiTietSachRepository = new ChiTietSPRepository();
            _iNhaXuatBanRepository = new NhaXuatBanRepository();
            _iTheLoaiCtRepository = new TheLoaiCtRepository();
        }
     
        public string Add(CtSachView ctSachV)
        {
            if (ctSachV == null) return "Thêm không thành công ";
            var chiTietSanPham = new ChiTietSach()
            {
                IdChiTietSach = ctSachV.IdChiTietSach,
                MaChiTietSach = ctSachV.MaChiTietSach,
                IdTheLoaiChiTiet = ctSachV.IdTheLoaiChiTiet,
                IdNxb = ctSachV.IdNxb,
                IdTacGia = ctSachV.IdTacGia,
                IdSach = ctSachV.IdSach,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.AddChiTietSach(chiTietSanPham))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(CtSachView ctSachV)
        {
            if (ctSachV == null) return "Xóa không thành công";
            var chiTietSanPham = new ChiTietSach()
            {
                MaChiTietSach = ctSachV.MaChiTietSach,
                IdTheLoaiChiTiet = ctSachV.IdTheLoaiChiTiet,
                IdNxb = ctSachV.IdNxb,
                IdTacGia = ctSachV.IdTacGia,
                IdSach = ctSachV.IdSach,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.DeleteChiTietSach(chiTietSanPham))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<CtSachView> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CtSachView> GetAllChiTietSach()
        {
            List<CtSachView> lstPhamViews = new List<CtSachView>();
            lstPhamViews =
                (from a in _iChiTietSachRepository.GetAllChiTietSach()
                 join b in _iSachRepository.GetAllSach() on a.IdSach equals b.IdSach
                 join d in _iTacGiaRepository.GetAllTacGia() on a.IdTacGia equals d.IdTacGia
                 join e in _iNhaXuatBanRepository.GetAllNhaXuatBan() on a.IdNxb equals e.IdNxb
                 join f in _iTheLoaiCtRepository.GetAllTheLoaiCt() on a.IdTheLoaiChiTiet equals f.IdTheLoaiChiTiet
                 select new CtSachView
                 {
                     MaChiTietSach = a.MaChiTietSach,
                     IdSach = b.IdSach,
                     IdTacGia = d.IdTacGia,
                     IdNxb = e.IdNxb,
                     IdTheLoaiChiTiet = f.IdTheLoaiChiTiet,
                     TrangThai = a.TrangThai,
                 }
                ).ToList();
            return lstPhamViews;
        }

        public ChiTietSach GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public string Update(CtSachView ctSachV)
        {
            if (ctSachV == null) return "Sửa không thành công";
            var chiTietSanPham = new ChiTietSach()
            {
                MaChiTietSach = ctSachV.MaChiTietSach,
                IdTheLoaiChiTiet = ctSachV.IdTheLoaiChiTiet,
                IdNxb = ctSachV.IdNxb,
                IdTacGia = ctSachV.IdTacGia,
                IdSach = ctSachV.IdSach,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.UpdateChiTietSach(chiTietSanPham))
                return "Sửa  thành công";
            return "Sửa không thành công";
        }
    }
}
