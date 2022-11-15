using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietSPRepository : IChiTietSachRepository
    {
        private Nhom678 _dBContext;
        List<ChiTietSach> chiTietSaches;
        public ChiTietSPRepository()
        {
            _dBContext = new Nhom678();
        }

        public bool AddChiTietSach(ChiTietSach cts)
        {
            if (cts == null) return false;
            _dBContext.ChiTietSaches.Add(cts);
            _dBContext.SaveChanges();
            return true;
        }


        public bool DeleteChiTietSach(ChiTietSach cts)
        {
            if (cts == null) return false;
            var tempobj = _dBContext.ChiTietSaches.FirstOrDefault(c => c.MaChiTietSach == cts.MaChiTietSach);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<ChiTietSach> GetAllChiTietSach()
        {
            return _dBContext.ChiTietSaches.ToList();
        }

        public ChiTietSach GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateChiTietSach(ChiTietSach cts)
        {
            if (cts == null) return false;
            var tempobj = _dBContext.ChiTietSaches.FirstOrDefault(c => c.MaChiTietSach == cts.MaChiTietSach);
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

    }
}
