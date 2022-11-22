using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLNhaXuatBanService
    {
        private INhaXuatBanRepository _nhaXuatBanRepository;
        public QLNhaXuatBanService()
        {
            _nhaXuatBanRepository = new NhaXuatBanRepository();
        }
        public string Add(NxbView nxb)
        {
            if (nxb == null) return "Thêm không thành công ";
            var khohang = new NhaXuatBan()
            {
                IdNxb = nxb.IdNxb,
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.AddNhaXuatBan(khohang))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(NxbView nxb)
        {
            if (nxb == null) return "Xóa không thành công";
            var nhaXuatBan = new NhaXuatBan()
            {
                IdNxb = nxb.IdNxb,
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.DeleteNhaXuatBan(nhaXuatBan))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<NxbView> GetAll()
        {
            List<NxbView> list = new List<NxbView>();
            list = (from n in _nhaXuatBanRepository.GetAllNhaXuatBan()
                    select new NxbView
                    {
                        IdNxb = n.IdNxb,
                        MaNxb = n.MaNxb,
                        TenNxb= n.TenNxb,
                        DiaChi= n.DiaChi,
                        Url = n.Url,
                    }).ToList();
            return list;
        }

        public string Update(NxbView nxb)
        {
            if (nxb == null) return "Sửa không thành công";
            var nhaXuatBan = new NhaXuatBan()
            {
                IdNxb = nxb.IdNxb,
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.UpdateNhaXuatBan(nhaXuatBan))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
