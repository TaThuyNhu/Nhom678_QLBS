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
            if (nxb == null) return "Them khong thanh cong";
            var khohang = new NhaXuatBan()
            {
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.AddNhaXuatBan(khohang))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(NxbView nxb)
        {
            if (nxb == null) return "xoa khong thanh cong";
            var nhaXuatBan = new NhaXuatBan()
            {
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.DeleteNhaXuatBan(nhaXuatBan))
                return "xoa thanh cong";
            return "xoa khong thanh cong";
        }

        public List<NxbView> GetAll()
        {
            List<NxbView> list = new List<NxbView>();
            list = (from n in _nhaXuatBanRepository.GetAllNhaXuatBan()
                    select new NxbView
                    {
                        MaNxb = n.MaNxb,
                        TenNxb= n.TenNxb,
                        DiaChi= n.DiaChi,
                        Url = n.Url,
                    }).ToList();
            return list;
        }

        public string Update(NxbView nxb)
        {
            if (nxb == null) return "sua khong thanh cong";
            var nhaXuatBan = new NhaXuatBan()
            {
                MaNxb = nxb.MaNxb,
                TenNxb = nxb.TenNxb,
                DiaChi = nxb.DiaChi,
                Url = nxb.Url,
            };
            if (_nhaXuatBanRepository.UpdateNhaXuatBan(nhaXuatBan))
                return "sua thanh cong";
            return "sua khong thanh cong";
        }
    }
}
