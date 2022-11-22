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
    public class GiamGiaRepository : IGiamGiaRepository
    {
        private Nhom678 _dBContext;
        List<GiamGium> giamGia;
        public GiamGiaRepository()
        {
            _dBContext = new Nhom678();
            giamGia = new List<GiamGium>();
        }
        public bool AddGiamGia(GiamGium gg)
        {
            if (gg == null) return false;
            _dBContext.GiamGia.Add(gg);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteGiamGia(GiamGium gg)
        {
            if (gg == null) return false;
            var temp = _dBContext.GiamGia.FirstOrDefault(c => c.MaGiamGia == gg.MaGiamGia);
            _dBContext.GiamGia.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<GiamGium> GetAllGiamGia()
        {
            return giamGia = _dBContext.GiamGia.ToList();
        }

        public GiamGium GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGiamGia(GiamGium gg)
        {
            if (gg == null) return false;
            var temp = _dBContext.GiamGia.FirstOrDefault(c => c.MaGiamGia == gg.MaGiamGia);
            _dBContext.GiamGia.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
