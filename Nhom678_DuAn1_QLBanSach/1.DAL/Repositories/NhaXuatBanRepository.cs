using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhaXuatBanRepository : INhaXuatBanRepository
    {
        private Nhom678 _dBContext;
        List<NhaXuatBan> _NhaXuatBanList;
        public NhaXuatBanRepository()
        {
            _dBContext = new Nhom678();
            _NhaXuatBanList = new List<NhaXuatBan>();
        }

        public bool AddNhaXuatBan(NhaXuatBan nxb)
        {
            if (nxb == null) return false;
            _dBContext.NhaXuatBans.Add(nxb);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteNhaXuatBan(NhaXuatBan nxb)
        {
            if (nxb == null) return false;
            var temp = _dBContext.NhaXuatBans.FirstOrDefault(c => c.MaNxb == nxb.MaNxb);
            _dBContext.NhaXuatBans.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<NhaXuatBan> GetAllNhaXuatBan()
        {
            _NhaXuatBanList = _dBContext.NhaXuatBans.ToList();
            return _NhaXuatBanList;
        }

        public NhaXuatBan GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNhaXuatBan(NhaXuatBan nxb)
        {
            if (nxb == null) return false;
            var temp = _dBContext.NhaXuatBans.FirstOrDefault(c => c.MaNxb == nxb.MaNxb);
            _dBContext.NhaXuatBans.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
