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
    public class KhoRepository : IKhoRepository
    {
        private Nhom678 _dBContext;
        List<Kho> _KhoList;
        public KhoRepository()
        {
            _dBContext = new Nhom678();
            _KhoList = new List<Kho>();
        }

        public bool AddKho(Kho k)
        {
            if (k == null) return false;
            _dBContext.Khos.Add(k);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteKho(Kho k)
        {
            if (k == null) return false;
            var temp = _dBContext.Khos.FirstOrDefault(c => c.MaKho == k.MaKho);
            _dBContext.Khos.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<Kho> GetAllKho()
        {
            _KhoList = _dBContext.Khos.ToList();
            return _KhoList;
        }

        public Kho GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateKho(Kho k)
        {
            if (k == null) return false;
            var temp = _dBContext.Khos.FirstOrDefault(c => c.MaKho == k.MaKho);
            _dBContext.Khos.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
