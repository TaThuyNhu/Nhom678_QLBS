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
        private IKhoRepository _iKhoRepository ;
        private ITacGiaRepository _iTacGiaRepository;
        private IChiTietSachRepository _iChiTietSachRepository ;
        private INhaXuatBanRepository _iNhaXuatBanRepository ;
        private ITheLoaiCtRepository _iTheLoaiCtRepository ;
        public QLCtSachService()
        {
            _iSachRepository = new SanPhamRepository();
            _iKhoRepository = new KhoRepository();
            _iTacGiaRepository = new TacGiaRepository();
            _iChiTietSachRepository = new ChiTietSPRepository();
            _iNhaXuatBanRepository = new NhaXuatBanRepository();
            _iTheLoaiCtRepository = new TheLoaiCtRepository();
        }
     
        public string Add(CtSachView ctSachV)
        {
            if (ctSachV == null) return "Them khong thanh cong";
            var chiTietSanPham = new ChiTietSach()
            {
                MaChiTietSach = ctSachV.MaChiTietSach,
                MaKho = ctSachV.MaKho,
                MaTacGia = ctSachV.MaTacGia,
                MaSach = ctSachV.MaSach,
                MaTheLoaiChiTiet = ctSachV.MaTheLoaiChiTiet,
                MaNxb =ctSachV.MaNxb,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.AddChiTietSach(chiTietSanPham))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(CtSachView ctSachV)
        {
            if (ctSachV == null) return "Xoa khong thanh cong";
            var chiTietSanPham = new ChiTietSach()
            {
                MaChiTietSach = ctSachV.MaChiTietSach,
                MaKho = ctSachV.MaKho,
                MaTacGia = ctSachV.MaTacGia,
                MaSach = ctSachV.MaSach,
                MaTheLoaiChiTiet = ctSachV.MaTheLoaiChiTiet,
                MaNxb = ctSachV.MaNxb,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.DeleteChiTietSach(chiTietSanPham))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
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
                 join b in _iSachRepository.GetAllSach() on a.MaSach equals b.MaSach
                 join c in _iKhoRepository.GetAllKho() on a.MaKho equals c.MaKho
                 join d in _iTacGiaRepository.GetAllTacGia() on a.MaTacGia equals d.MaTacGia
                 join e in _iNhaXuatBanRepository.GetAllNhaXuatBan() on a.MaNxb equals e.MaNxb
                 join f in _iTheLoaiCtRepository.GetAllTheLoaiCt() on a.MaTheLoaiChiTiet equals f.MaTheLoaiChiTiet
                 select new CtSachView
                 {
                     MaChiTietSach = a.MaChiTietSach,
                     MaSach = b.MaSach,
                     MaKho = c.MaKho,
                     MaTacGia = d.MaTacGia,
                     MaNxb = e.MaNxb,
                     MaTheLoaiChiTiet = f.MaTheLoaiChiTiet,
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
            if (ctSachV == null) return "sua khong thanh cong";
            var chiTietSanPham = new ChiTietSach()
            {
                MaChiTietSach = ctSachV.MaChiTietSach,
                MaKho = ctSachV.MaKho,
                MaTacGia = ctSachV.MaTacGia,
                MaSach = ctSachV.MaSach,
                MaTheLoaiChiTiet = ctSachV.MaTheLoaiChiTiet,
                MaNxb = ctSachV.MaNxb,
                TrangThai = ctSachV.TrangThai,
            };
            if (_iChiTietSachRepository.UpdateChiTietSach(chiTietSanPham))
                return "sua thanh cong";
            return "sua khong thanh cong";
        }
    }
}
